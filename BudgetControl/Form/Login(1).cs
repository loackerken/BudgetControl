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
        Setting _settingForm;
        public bool LoginFlag { get; set; }
        public Login()
        {
            InitializeComponent();
            
            _settingForm = new Setting();
            LoginFlag = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            progressBar1.Visible = false;
        }
        //----------------------
        //void tryLogin()
        //{
        //    try
        //    {
        //        if (Database.DbModel.Connection.State == ConnectionState.Open)
        //        {
        //        }
        //        else
        //        {
        //            if (Database.CheckSetting())
        //            {
        //                Database.setNewConnection();
        //                Database.DbModel.Connection.Open();
        //                if (Database.DbModel.Connection.State == ConnectionState.Open)
        //                {
        //                }
        //                else
        //                {
        //                    LoginFlag = false;
        //                    System.Windows.Forms.MessageBox.Show("Please check Database Login.");
        //                    return;
        //                }
        //            }
        //            else
        //            {
        //                LoginFlag = false;
        //                MessageBox.Show("Database setting not complete,Please Check");
        //                return;
        //            }
        //        }

        //        if (SAPConnector.UserConnect(textBox1.Text, textBox2.Text))
        //        {
        //            Console.WriteLine("User Logined");
        //            LoginFlag = true;
        //            //this.Dispose();
        //        }
        //        else
        //        {
        //            LoginFlag = false;
        //            MessageBox.Show("Login DI Failed : " + SAPConnector.errMsg);
        //            return;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        LoginFlag = false;
        //        string error = ex.Message;
        //        if (ex.InnerException != null)
        //        {
        //            error += " : " + ex.InnerException.Message;
        //        }
        //        MessageBox.Show("Login Failed : " + error);
        //        return;
        //    }
        //}
        //----------------------






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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginFlag = false;
            this.Dispose();
            this.Close();
            Application.Exit();
        }
    }
}
