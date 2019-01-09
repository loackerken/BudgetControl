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
    public partial class ListTransfer : Form
    {
        public enum Mode
        {
            Blank,
            Copy,
            Update,

        }
        private Mode ListMode;
        public string selectBGCode = "";
        public string selectBGName = "";
        public string selectBGRevise = "";
        public string selectYear = "";
        public string selectPeriodNo = "";
        public bool selectStatus = false;
        public int selectTRNo = -1;
        public DateTime? selectTRDate;
        public ListTransfer(Mode mode)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ListMode = mode;
        }

        public void btnChoose_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgRow in this.dataGridView1.SelectedRows)
            {
                selectBGCode = dgRow.Cells["ColBudgetCode"].Value.ToString();
                selectBGName = dgRow.Cells["ColBudgetName"].Value.ToString();
                selectBGRevise = dgRow.Cells["ColReviseNo"].Value.ToString();
                selectYear = dgRow.Cells["colFiscalYear"].Value.ToString();
                selectPeriodNo = dgRow.Cells["colPeriod"].Value.ToString();
                selectStatus = dgRow.Cells["ColStatus"].Value.ToString() == "Y" ? true : false;
                selectTRNo = Convert.ToInt32(dgRow.Cells["ColTRNo"].Value.ToString());
                selectTRDate = (DateTime)dgRow.Cells["ColTRDate"].Value;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBudgetSetup_Load(object sender, EventArgs e)
        {
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
            var ListData = (from c in Database.DbModel.HMC_BGTRANH join d in Database.DbModel.HMC_BGSCENARIO on c.BudgetCode equals d.BudgetCode select new { TRNo = c.TRNo,TRDate = c.BGDate, BudgetCode = d.BudgetCode, BudgetName = d.BudgetName, ReviseNo = c.ReviseNo, BudgetYear = d.BudgetYear, NoOfPeriod = d.NoOfPeriod, Status = c.Approve }).ToList();
            dataGridView1.DataSource = ListData.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
