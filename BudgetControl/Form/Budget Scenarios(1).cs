using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace BudgetControl
{
    public partial class Budget_Scenarios : Form
    {
        
        Class.NSF_DevelopEntities context = new Class.NSF_DevelopEntities();
        BindingSource bi = new BindingSource();
       
        
        public Budget_Scenarios()
        {
            InitializeComponent();

            context.HMC_BGSCENARIO.Load();

            bi.DataSource = context.HMC_BGSCENARIO.Local;

            dataGridView1.DataSource = bi;

            DataGridViewComboBoxColumn colBudgetBy = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColSetupBudgetBy"];
            DataTable dtBGTypeColbudgetBy = new DataTable();
            dtBGTypeColbudgetBy.Columns.Add("Code", typeof(string));
            dtBGTypeColbudgetBy.Columns.Add("Name", typeof(string));
            dtBGTypeColbudgetBy.Rows.Add(new Object[] { "1", "1. Project" });
            dtBGTypeColbudgetBy.Rows.Add(new Object[] { "2", "2. Cost Center and Account" });
            dtBGTypeColbudgetBy.Rows.Add(new Object[] { "3", "3. Cost Center and Project" });

            colBudgetBy.DisplayMember = "Name";
            colBudgetBy.ValueMember = "Code";
            colBudgetBy.DataSource = dtBGTypeColbudgetBy;
            //----------------------------------
            DataGridViewComboBoxColumn colBudgetType = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColBudgetType"];
            DataTable dtBGTypeColbudgetType = new DataTable();
            dtBGTypeColbudgetType.Columns.Add("Code", typeof(string));
            dtBGTypeColbudgetType.Columns.Add("Name", typeof(string));
            dtBGTypeColbudgetType.Rows.Add(new Object[] { "0", "0. OB" });
            dtBGTypeColbudgetType.Rows.Add(new Object[] { "1", "1. General Budget" });

            colBudgetType.DisplayMember = "Name";
            colBudgetType.ValueMember = "Code";
            colBudgetType.DataSource = dtBGTypeColbudgetType;
            //-----------------------------------
            DataGridViewComboBoxColumn colBudgetPeriod = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColBudgetPeriod"];
            DataTable dtBGTypeColbudgetPeriod = new DataTable();
            dtBGTypeColbudgetPeriod.Columns.Add("Code", typeof(string));
            dtBGTypeColbudgetPeriod.Columns.Add("Name", typeof(string));
            dtBGTypeColbudgetPeriod.Rows.Add(new Object[] { "1", "1. Annual" });
            dtBGTypeColbudgetPeriod.Rows.Add(new Object[] { "2", "2. Period" });
            dtBGTypeColbudgetPeriod.Rows.Add(new Object[] { "3", "3. Ignore Period" });

            colBudgetPeriod.DisplayMember = "Name";
            colBudgetPeriod.ValueMember = "Code";
            colBudgetPeriod.DataSource = dtBGTypeColbudgetPeriod;


            //var ListPeriod = (from c in context.OACP select c.PeriodCat).ToList();
            //DataGridViewComboBoxColumn colBudgetYear = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColFiscalYear"];
            ////colBudgetYear.DisplayMember = "PeriodCat";
            ////colBudgetYear.ValueMember = "PeriodCat";
            //colBudgetYear.DataSource = ListPeriod;


            var ListPeriod = (from c in context.OACP select c.PeriodCat).ToList();
            DataGridViewComboBoxColumn colBudgetYear = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColFiscalYear"];
            //colBudgetYear.DisplayMember = "PeriodCat";
            //colBudgetYear.ValueMember = "PeriodCat";
            //colBudgetYear.DataSource = ListPeriod;
            colBudgetYear.Items.Clear();
            foreach (var idata in ListPeriod)
            {
                colBudgetYear.Items.Add(idata);
            }
            colBudgetYear.Items.Add("");
//-----------------------------------------------
            var PeriodFrom = (from c in context.OFPR select c.Code).ToList();
            DataGridViewComboBoxColumn colPeriodFrom = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColPeriodFrom"];
            //colBudgetYear.DisplayMember = "PeriodCat";
            //colBudgetYear.ValueMember = "PeriodCat";
            //colBudgetYear.DataSource = ListPeriod;
            colPeriodFrom.Items.Clear();
            foreach (var idata in PeriodFrom)
            {
                colPeriodFrom.Items.Add(idata);
            }
            colPeriodFrom.Items.Add("");
            //------------------------------------------------
            var PeriodTo = (from c in context.OFPR select c.Code).ToList();
            DataGridViewComboBoxColumn colPeriodTo = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColPeriodTo"];
            //colBudgetYear.DisplayMember = "PeriodCat";
            //colBudgetYear.ValueMember = "PeriodCat";
            //colBudgetYear.DataSource = ListPeriod;
            colPeriodTo.Items.Clear();
            foreach (var idata in PeriodTo)
            {
                colPeriodTo.Items.Add(idata);
            }
            colPeriodTo.Items.Add("");
            //------------------------------------------------
            
            

            //dataGridView1.DataSource = context.HMC_SendMail.ToList();

        }

        private void Budget_Scenarios_Load(object sender, EventArgs e)
        {
            context.Database.Connection.ConnectionString = "data source = 10.153.69.118; initial catalog = NSF_Develop; persist security info = True; user id = sa; password = p@ssw0rd";
            context.Database.Connection.Open();
            //-------------------------------------------------
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Save Complete");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ColBudgetPeriod"].Index)
            {
                if ("1,2".Contains(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                  
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells["ColFiscalYear"].Value = "";
                    //DataGridViewComboBoxColumn colBudgetYear = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColFiscalYear"];
                    //colBudgetYear.DataSource = null;
                }      
            }
             
          
            
        }

    private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["ColFiscalYear"].Index)
            {
                var ListPeriod = (from c in context.OACP select c.PeriodCat).ToList();
                DataGridViewComboBoxColumn colBudgetYear = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColFiscalYear"];
                //colBudgetYear.DisplayMember = "PeriodCat";
                //colBudgetYear.ValueMember = "PeriodCat";
                //colBudgetYear.DataSource = ListPeriod;
                
            }      
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

            if ("1,2".Contains(dataGridView1.Rows[e.RowIndex].Cells["ColBudgetPeriod"].Value.ToString()))
            {

            }
            else
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["ColFiscalYear"].Value != null && dataGridView1.Rows[e.RowIndex].Cells["ColFiscalYear"].Value.ToString() != "")
                {
                    MessageBox.Show("ไม่สามารถเลือก Fiscal Year ได้");
                    e.Cancel = true;
                }
            }
            
            //if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ColPeriodTo"].Index)
            //{
                string x = dataGridView1.Rows[e.RowIndex].Cells["ColPeriodFrom"].Value.ToString();
                string y = dataGridView1.Rows[e.RowIndex].Cells["ColPeriodTo"].Value.ToString();
                //int total = x - y;
                var CountPeriod = Database.DbModel.OFPR.Where(c => c.Code.CompareTo( x) >= 0 && c.Code.CompareTo(y) <= 0).Count();
                dataGridView1.Rows[e.RowIndex].Cells["ColNoPeriod"].Value = CountPeriod.ToString();
            //}
           if (dataGridView1.Rows[e.RowIndex].Cells["ColReviseNo"].Value == null)
            {
                dataGridView1.Rows[e.RowIndex].Cells["ColReviseNo"].Value = "-1";
            }
        }

        private void Budget_Scenarios_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

      



        //public void Load_Click(object sender, EventArgs e)
        //{
        //    context.HMC_BGSCENARIO.Load();

        //    bi.DataSource = context.HMC_BGSCENARIO.Local;

        //    dataGridView1.DataSource = bi;

        //    DataGridViewComboBoxColumn colBudgetBy = (DataGridViewComboBoxColumn )dataGridView1.Columns["ColSetupBudgetBy"];
        //    DataTable dtBGTypeColbudgetBy = new DataTable();
        //    dtBGTypeColbudgetBy.Columns.Add("Code", typeof(string));
        //    dtBGTypeColbudgetBy.Columns.Add("Name", typeof(string));
        //    dtBGTypeColbudgetBy.Rows.Add(new Object[] { "1", "1. Project" });
        //    dtBGTypeColbudgetBy.Rows.Add(new Object[] { "2", "2. Cost Center and Account" });
        //    dtBGTypeColbudgetBy.Rows.Add(new Object[] { "3", "3. Cost Center and Project" });

        //    colBudgetBy.DisplayMember = "Name";
        //    colBudgetBy.ValueMember = "Code";
        //    colBudgetBy.DataSource = dtBGTypeColbudgetBy;
        //    //----------------------------------
        //    DataGridViewComboBoxColumn colBudgetType = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColBudgetType"];
        //    DataTable dtBGTypeColbudgetType = new DataTable();
        //    dtBGTypeColbudgetType.Columns.Add("Code", typeof(string));
        //    dtBGTypeColbudgetType.Columns.Add("Name", typeof(string));
        //    dtBGTypeColbudgetType.Rows.Add(new Object[] { "0", "0. OB" });
        //    dtBGTypeColbudgetType.Rows.Add(new Object[] { "1", "1. General Budget" });

        //    colBudgetType.DisplayMember = "Name";
        //    colBudgetType.ValueMember = "Code";
        //    colBudgetType.DataSource = dtBGTypeColbudgetType;
        //    //-----------------------------------
        //    DataGridViewComboBoxColumn colBudgetPeriod = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColBudgetPeriod"];
        //    DataTable dtBGTypeColbudgetPeriod = new DataTable();
        //    dtBGTypeColbudgetPeriod.Columns.Add("Code", typeof(string));
        //    dtBGTypeColbudgetPeriod.Columns.Add("Name", typeof(string));
        //    dtBGTypeColbudgetPeriod.Rows.Add(new Object[] { "1", "1. Annual" });
        //    dtBGTypeColbudgetPeriod.Rows.Add(new Object[] { "2", "2. Period" });
        //    dtBGTypeColbudgetPeriod.Rows.Add(new Object[] { "3", "3. Ignore Period" });

        //    colBudgetPeriod.DisplayMember = "Name";
        //    colBudgetPeriod.ValueMember = "Code";
        //    colBudgetPeriod.DataSource = dtBGTypeColbudgetPeriod;

        //    //dataGridView1.DataSource = context.HMC_SendMail.ToList();
        //}
    }
}
