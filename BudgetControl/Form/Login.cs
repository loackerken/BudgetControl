using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetControl
{
    public partial class Login : Form
    {
        Class.NSF_DevelopEntities context = new Class.NSF_DevelopEntities();
        Setting _settingForm;
        public bool LoginFlag { get; set; }
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;
            _settingForm = new Setting();
            LoginFlag = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            progressBar1.Visible = false;
            textBox2.UseSystemPasswordChar = true;
        }
       // ----------------------
        void tryLogin()
        {
            //context.Database.Connection.ConnectionString = "data source = 10.153.69.118; initial catalog = NSF_Develop; persist security info = True; user id = sa; password = p@ssw0rd";
            
            try
            {
                if (context.Database.Connection.State == ConnectionState.Open)
                {
                }
                else
                {
                    if (Database.CheckSetting())
                    {
                       
                        context.Database.Connection.Open();
                        if (context.Database.Connection.State == ConnectionState.Open)
                        {
                        }
                        else
                        {
                            LoginFlag = false;
                            System.Windows.Forms.MessageBox.Show("Please check Database Login.");
                            return;
                        }
                    }
                    else
                    {
                        LoginFlag = false;
                        MessageBox.Show("Database setting not complete,Please Check");
                        return;
                    }
                }

                if (SAPConnector.UserConnect(textBox1.Text, textBox2.Text))
                {
                    Console.WriteLine("User Logined");
                    LoginFlag = true;
                    //this.Dispose();
                }
                else
                {
                    LoginFlag = false;
                    MessageBox.Show("Login DI Failed : " + SAPConnector.errMsg);
                    return;
                }
            }
            catch (Exception ex)
            {
                LoginFlag = false;
                string error = ex.Message;
                if (ex.InnerException != null)
                {
                    error += " : " + ex.InnerException.Message;
                }
                MessageBox.Show("Login Failed : " + error);
                return;
            }
        }
       // ----------------------






        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!LoginFlag)
            {
                e.Cancel = true;
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            _settingForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            progressBar1.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginFlag = false;
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            tryLogin();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnLogin.Enabled = true;
            progressBar1.Visible = false;
            if (LoginFlag)
            {
                this.Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
