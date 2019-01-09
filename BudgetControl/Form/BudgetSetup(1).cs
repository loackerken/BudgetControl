using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetControl
{
    public partial class BudgetSetup : Form
    {
        Class.NSF_DevelopEntities context = new Class.NSF_DevelopEntities();
        BindingSource bi = new BindingSource();
        public BudgetSetup()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            context.OPRJ.Load();

            bi.DataSource = context.OPRJ.Local.ToList().OrderBy(Sort => Sort.U_HMC_SortNo);

            dataGridView1.DataSource = bi;

            var ListColumn = (from c in Database.DbModel.OPRC where c.U_HMC_UseBudget == "Y" select new { code = c.PrcCode, name = c.PrcName }).ToList();
            foreach (var item in ListColumn)
            {
                DataGridViewTextBoxColumn dc1 = new DataGridViewTextBoxColumn();
                dc1.Name = string.Format("ColEdt_{0}", item.code);
                dc1.HeaderText = string.Format("{0} : {1}", item.code, item.name);
                dc1.Width = 100;
                DataGridViewButtonColumn dc2 = new DataGridViewButtonColumn();
                dc2.Name = string.Format("ColBtn_{0}", item.code);
                dc2.HeaderText = "";
                dc2.Width = 25;
                dataGridView1.Columns.Add(dc1);
                dataGridView1.Columns.Add(dc2);
            }


        }

        private void BudgetSetup_Load(object sender, EventArgs e)
        {
            context.Database.Connection.ConnectionString = "data source = 10.153.69.118; initial catalog = NSF_Develop; persist security info = True; user id = sa; password = p@ssw0rd";
            context.Database.Connection.Open();
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListBudgetSetup selectFrom = new ListBudgetSetup();
            if (selectFrom.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = selectFrom.selectBGCode;
                textBox2.Text = selectFrom.selectBGName;
                textBox3.Text = selectFrom.selectBGRevise;
            }
           

         
            //dataGridView1.DataSource = objDisplay;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name.Contains("Btn"))
            {
                MessageBox.Show(string.Format("{0}_{1}", dataGridView1.Columns[e.ColumnIndex].Name,dataGridView1.Rows[e.RowIndex].Cells["ColPrjCode"].Value.ToString()));
            }
        }
    }
}
