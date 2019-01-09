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
    public partial class Setting : Form
    {
        private HMC_Crypto.HMCCrypto.UseEncrypt Encrypt;
        public Setting()
        {
            InitializeComponent();
            Encrypt = new HMC_Crypto.HMCCrypto.UseEncrypt();
            textBox1.Text = Properties.Settings.Default.sapServer;
            textBox2.Text = Properties.Settings.Default.databaseName;

            if (Properties.Settings.Default.dbServerType == "")
                comboBox1.SelectedIndex = 0;
            else
                comboBox1.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.dbServerType);

            textBox3.Text = Properties.Settings.Default.dbUser;
            if (!Properties.Settings.Default.dbPassword.Equals(""))
            {
                //textBox4.Text = Encryption.Decrypt(Properties.Settings.Default.dbPassword,true);
                // textBox4.Text = Properties.Settings.Default.dbPassword;
                textBox4.Text = Encrypt.DecodeSymmetric("humanica", Properties.Settings.Default.dbPassword);
            }
            else
            {
                textBox4.Text = "";
            }
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please type SAP server.");
            }
            else if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Please type database name.");
            }
            else if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Please select SAP server type");
            }
            else if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Please Type Database Login : ");
            }
            else if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("Please Type Database Password");
            }
            //else if (txtPathReport.Text.Equals(""))
            //{
            //    MessageBox.Show("Please Input Report file path.");
            //}
            else
            {
                Properties.Settings.Default.sapServer = textBox1.Text;
                Properties.Settings.Default.databaseName = textBox2.Text;
                Properties.Settings.Default.dbServerType = comboBox1.SelectedIndex.ToString();
                Properties.Settings.Default.dbUser = textBox3.Text;
                // Properties.Settings.Default.dbPassword = Encryption.Encrypt(textBox3.Text, true);
                // Properties.Settings.Default.dbPassword = textBox3.Text;
                Properties.Settings.Default.dbPassword = Encrypt.EncodeSymmetric("humanica", textBox4.Text);
                //  Properties.Settings.Default.reportPath = txtPathReport.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
