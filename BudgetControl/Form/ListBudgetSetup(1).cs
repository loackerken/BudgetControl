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
    public partial class ListBudgetSetup : Form
    {
        public string selectBGCode = "";
        public string selectBGName = "";
        public string selectBGRevise = "";
        public ListBudgetSetup()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        
        }

        public void btnChoose_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgRow in this.dataGridView1.SelectedRows)
            {
                selectBGCode = dgRow.Cells["ColBudgetCode"].Value.ToString();
                selectBGName = dgRow.Cells["ColBudgetName"].Value.ToString();
                selectBGRevise = dgRow.Cells["ColReviseNo"].Value.ToString(); 
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBudgetSetup_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.DbModel.HMC_BGSCENARIO.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
