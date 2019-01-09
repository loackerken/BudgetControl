using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetControl.Class.Ext;

namespace BudgetControl
{
    public partial class CreateNewBudgetSetup : Form
    {
        public string BGCode = "";
        public int RevNo = -1;
        public int NewRevNo = -1;
        public ListBudgetSetup.Mode SetupMode = ListBudgetSetup.Mode.Blank;
        public CreateNewBudgetSetup()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBudgetSetup frm = new BudgetControl.ListBudgetSetup(ListBudgetSetup.Mode.Copy);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBGCode.Text = frm.selectBGCode;
                txtRevNo.Text = frm.selectBGRevise;
                BGCode = frm.selectBGCode;
                RevNo = frm.selectBGRevise.ToIntorDefault();
                radioCopy.Checked = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioBlank.Checked)
                SetupMode = ListBudgetSetup.Mode.Blank;
            else if (radUpdate.Checked)
            {
                SetupMode = ListBudgetSetup.Mode.Update;
            }
            else
            {
                SetupMode = ListBudgetSetup.Mode.Copy;
                if (Database.CopyBudgetData(BGCode, RevNo, out NewRevNo) == false)
                    MessageBox.Show(Database.ErrMsg, "พบข้อผิดพลาดในการคัดลอก", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
