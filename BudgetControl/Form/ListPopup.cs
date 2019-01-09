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
    public partial class ListPopup : Form
    {
        public enum Mode
        {
           Dimension,
           Project

        }
        private Mode ListMode;
        public string selectCode = "";
        public string selectName = "";
        
        public ListPopup(Mode mode)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ListMode = mode;
        }

        public void btnChoose_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgRow in this.dataGridView1.SelectedRows)
            {
                selectCode = dgRow.Cells["ColCode"].Value.ToString();
                selectName = dgRow.Cells["ColName"].Value.ToString();
                 
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBudgetSetup_Load(object sender, EventArgs e)
        {
            try
            {
                if (ListMode == Mode.Dimension)
                {
                    this.Text = string.Format(this.Text, "Cost Center");
                    var ListData = (from c in Database.DbModel.OPRC where c.U_HMC_UseBudget == "Y" && c.Active == "Y" select new { Code = c.PrcCode, Name = c.PrcName }).ToList();
                    dataGridView1.DataSource = ListData.ToList();
                }
                else
                {
                    this.Text = string.Format(this.Text, "Project");
                    var ListData = (from c in Database.DbModel.OPRJ where c.U_HMC_UseBudget == "Y" && c.Active == "Y" select new { Code = c.PrjCode, Name = c.PrjName }).ToList();
                    dataGridView1.DataSource = ListData.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //if (ListMode == Mode.Blank)
            //{
            //    dataGridView1.Columns["ColStatus"].Visible = false;
            //    dataGridView1.DataSource = Database.DbModel.HMC_BGSCENARIO.ToList();

            //}

            //else
            //{
            //    var ListData = (from c in Database.DbModel.HMC_BGSETUP join d in Database.DbModel.HMC_BGSCENARIO on c.BudgetCode equals d.BudgetCode select new { BudgetCode = d.BudgetCode, BudgetName = d.BudgetName, ReviseNo = c.ReviseNo, BudgetYear = d.BudgetYear, NoOfPeriod = d.NoOfPeriod, Status = c.Status }).ToList();

            //    dataGridView1.DataSource = ListData.ToList();
            //}
           
       
        }

        
    }
}
