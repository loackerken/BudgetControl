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
using BudgetControl.Class.Ext;

namespace BudgetControl
{
    public partial class BudgetSetup : Form
    {
        public ListBudgetSetup.Mode SetupMode = ListBudgetSetup.Mode.Update;
        Class.NSF_DevelopEntities context = new Class.NSF_DevelopEntities();
        BindingSource bi = new BindingSource();
        decimal SumAllocateAmount = 0;
        decimal SumBGAmount = 0;
        public BudgetSetup()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
 
            context.OPRJ.Load();

            bi.DataSource = context.OPRJ.Local.ToList().OrderBy(Sort => Sort.U_HMC_SortNo);

            dataGridView1.DataSource = bi;



            var ListColumn = (from c in Database.DbModel.OPRC where c.U_HMC_UseBudget == "Y" select new { code = c.PrcCode, name = c.PrcName }).ToList();
            string[] SumColumnName = new string[ListColumn.Count + 2];
            string[] SumFrozenColumnName = new string[3];
            SumColumnName[0] = "colTotalbudget";
            SumColumnName[1] = "ColTotalAllocate";
            int initColumn = 2;
            foreach (var item in ListColumn)
            {
                DataGridViewTextBoxColumn dc1 = new DataGridViewTextBoxColumn();
                dc1.Name = string.Format("ColEdt_{0}", item.code);
                dc1.HeaderText = string.Format("{0} : {1}", item.code, item.name);
                dc1.Width = 100;
                dc1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dc1.DefaultCellStyle.Format = "N2";
                dc1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dc1.ReadOnly = true;
                SumColumnName[initColumn] = dc1.Name;
                initColumn++;
                DataGridViewButtonColumn dc2 = new DataGridViewButtonColumn();
                dc2.Name = string.Format("ColBtn_{0}", item.code);
                dc2.HeaderText = "";
                dc2.Width = 25;
                dataGridView1.Columns.Add(dc1);
                dataGridView1.Columns.Add(dc2);
            }
            dataGridView1.SummaryColumns = SumColumnName;
            SumFrozenColumnName[0] = "Col";
            SumFrozenColumnName[0] = "Col";
            SumFrozenColumnName[0] = "Col";
            dataGridView1.CreateSummaryRow();
            dataGridView1.DisplaySumRowHeader = true;
            this.dataGridView1.SummaryRowVisible = true;
            //dataGridView1.Rows.Add(null, "Total", 0, 0);
            SetStatusMode();
        }

        private void BudgetSetup_Load(object sender, EventArgs e)
        {
            //context.Database.Connection.ConnectionString = "data source = 10.153.69.118; initial catalog = NSF_Develop; persist security info = True; user id = sa; password = p@ssw0rd";
            //context.Database.Connection.Open();
            //Database.setNewConnection();
            //BudgetControl.Database.CollectPeriodData = new List<Class.HMC_BGPERIOD>();
            //BudgetControl.Database.CollectPeriodUpdateData = new List<Class.HMC_BGPERIOD>();

        }






        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void SetStatusMode()
        {
            this.Text = string.Format("Budget Setup : {0}", SetupMode.ToString());
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].CellType.Name == "DataGridViewButtonCell")
            {
                BudgetSetupDetail frm = new BudgetSetupDetail(txtBGCode.Text, dataGridView1.Rows[e.RowIndex].Cells["ColPrjCode"].Value.ToString(), dataGridView1.Columns[e.ColumnIndex - 1].Name.Replace("ColEdt_", ""), txtRev.Text.ToIntorDefault());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = frm.SumAmount;
                }
                //MessageBox.Show(string.Format("{0}_{1}", dataGridView1.Columns[e.ColumnIndex].Name, dataGridView1.Rows[e.RowIndex].Cells["ColPrjCode"].Value.ToString()));
                SumAllocateRow(e.RowIndex);
            }
        }
        private void FillData(string BGCode, int RevNo)
        {
            Database.setNewConnection();
            BudgetControl.Database.CollectPeriodData = new List<Class.HMC_BGPERIOD>();
            BudgetControl.Database.CollectPeriodUpdateData = new List<Class.HMC_BGPERIOD>();

            txtBGName.Text = Database.DbModel.HMC_BGSCENARIO.Where(c => c.BudgetCode == BGCode).Select(c => c.BudgetName).FirstOrDefault();

            var GetData = (from c in Database.DbModel.HMC_BGPROJECT where c.BudgetCode == BGCode && c.ReviseNo == RevNo select c);
            if (GetData != null && GetData.ToList().Count() > 0)
            {
                string PrjCode = "";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    PrjCode = dataGridView1.Rows[i].Cells["colPrjCode"].Value.ToString();
                    var BGTotal = (from c in GetData where c.PrjCode == PrjCode && c.ReviseNo == RevNo select c.BGTotal).FirstOrDefault();
                    dataGridView1.Rows[i].Cells["colTotalbudget"].Value = BGTotal;
                }

                var GetPeriod = (from c in Database.DbModel.HMC_BGPERIOD where c.BudgetCode == BGCode && c.ReviseNo == RevNo select c);
                if (GetPeriod != null && GetPeriod.ToList().Count() > 0)
                {
                    string DimCode = "";
                    for (int Row = 0; Row < dataGridView1.RowCount; Row++)
                    {
                        PrjCode = dataGridView1.Rows[Row].Cells["colPrjCode"].Value.ToString();
                        var RowPrjData = (from c in GetPeriod where c.PrjCode == PrjCode select c);
                        for (int Col = 0; Col < dataGridView1.Columns.Count; Col++)
                        {
                            if (dataGridView1.Columns[Col].Name.StartsWith("ColEdt_"))
                            {
                                DimCode = dataGridView1.Columns[Col].Name.Replace("ColEdt_", "");

                                dataGridView1.Rows[Row].Cells[Col].Value = RowPrjData.Where(c => c.OCRCode == DimCode).Select(c => c.PeriodAmount).Sum();

                            }
                        }
                        SumAllocateRow(Row);
                    }

                }

            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["colTotalbudget"].Value = "";
                    dataGridView1.Rows[i].Cells["ColTotalAllocate"].Value = "";

                    for (int Col = 0; Col < dataGridView1.Columns.Count; Col++)
                    {
                        if (dataGridView1.Columns[Col].Name.StartsWith("ColEdt_"))
                        {
                            dataGridView1.Rows[i].Cells[Col].Value = "";
                        }
                    }
                    //SumAllocateRow(i);
                }
            }
        }
        private void SumAllocateRow(int rowIndex)
        {
            decimal SumAmount = 0;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Name.StartsWith("ColEdt_"))
                {
                    SumAmount += dataGridView1.Rows[rowIndex].Cells[i].Value.ToDecimalorDefault();
                }
            }
            dataGridView1.Rows[rowIndex].Cells["ColTotalAllocate"].Value = SumAmount;
        }
        private void SumBudget()
        {
            SumAllocateAmount = 0;
            SumBGAmount = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                SumBGAmount += dataGridView1.Rows[i].Cells["colTotalbudget"].Value.ToDecimalorDefault();
                SumAllocateAmount += dataGridView1.Rows[i].Cells["ColTotalAllocate"].Value.ToDecimalorDefault();
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListBudgetSetup frm = new BudgetControl.ListBudgetSetup(SetupMode);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBGCode.Text = frm.selectBGCode;
                txtBGName.Text = frm.selectBGName;
                if (SetupMode == ListBudgetSetup.Mode.Blank)
                    txtRev.Text = Convert.ToString(frm.selectBGRevise.ToIntorDefault() + 1);
                else
                    txtRev.Text = frm.selectBGRevise;

                chkApp.Checked = frm.selectStatus;

                FillData(frm.selectBGCode, frm.selectBGRevise.ToIntorDefault());
                SetStatusMode();
            }

        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            decimal BGAmount = dataGridView1.Rows[e.RowIndex].Cells["colTotalbudget"].Value.ToDecimalorDefault();
            decimal AllocateAmount = dataGridView1.Rows[e.RowIndex].Cells["ColTotalAllocate"].Value.ToDecimalorDefault();
            if (BGAmount > 0)
            {
                decimal diff = BGAmount - AllocateAmount;
                if (diff < 0)
                {
                    e.Cancel = true;
                    MessageBox.Show(string.Format("ตรวจพบยอดที่กำหนดเกินกว่ายอดที่ตั้งไว้ จำนวน {0}", Math.Abs(diff).ToString("N2")), "ตรวจสอบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string BGCode = txtBGCode.Text;
            string BGName = txtBGName.Text;
            int RevNo = txtRev.Text.ToIntorDefault();


            if (txtBGCode.Text != "")
            {
                SumBudget();

                var HData = (from c in Database.DbModel.HMC_BGSETUP where c.BudgetCode == BGCode && c.ReviseNo == RevNo select c).FirstOrDefault();
                #region AddNew

                if (HData == null)
                {
                    Class.HMC_BGSETUP NewHData = new Class.HMC_BGSETUP();
                    NewHData.BudgetCode = BGCode;
                    NewHData.ReviseNo = RevNo;
                    NewHData.CreateBy = "";
                    NewHData.CreateDate = DateTime.Now;
                    NewHData.Status = chkApp.Checked ? "Y" : "N";
                    NewHData.TotalBudget = SumBGAmount;
                    NewHData.TotalAllocate = SumAllocateAmount;

                    Database.DbModel.HMC_BGSETUP.Add(NewHData);
                    if (Database.CollectPeriodData.Count() > 0)
                    {
                        foreach (var item in Database.CollectPeriodData)
                        {
                            Database.DbModel.HMC_BGPERIOD.Add(item);
                        }

                    }
                    if (dataGridView1.RowCount > 0)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            Class.HMC_BGPROJECT PrjData = new Class.HMC_BGPROJECT();
                            PrjData.BGTotal = dataGridView1.Rows[i].Cells["colTotalbudget"].Value.ToDecimalorDefault();
                            PrjData.PrjCode = dataGridView1.Rows[i].Cells["ColPrjCode"].Value.ToString();
                            PrjData.BudgetCode = BGCode;
                            PrjData.ReviseNo = RevNo;
                            Database.DbModel.HMC_BGPROJECT.Add(PrjData);
                        }
                    }


                }
                #endregion
                #region UpdateIfExist
                else
                {
                    HData.TotalBudget = SumBGAmount;
                    HData.TotalAllocate = SumAllocateAmount;
                    HData.Status = chkApp.Checked ? "Y" : "N";
                    if (Database.CollectPeriodData.Count() > 0)
                    {
                        foreach (var item in Database.CollectPeriodData)
                        {
                            Database.DbModel.HMC_BGPERIOD.Add(item);
                        }

                    }
                    //if (Database.CollectPeriodUpdateData.Count() > 0)
                    //{
                    //    foreach (var item in Database.CollectPeriodUpdateData)
                    //    {
                    //        //Database.DbModel.HMC_BGPERIOD.Attach(item);
                    //        //Database.DbModel.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    //    }
                    //}
                    if (dataGridView1.RowCount > 0)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {

                            Class.HMC_BGPROJECT PrjData = new Class.HMC_BGPROJECT();
                            PrjData.BGTotal = dataGridView1.Rows[i].Cells["colTotalbudget"].Value.ToDecimalorDefault();
                            PrjData.PrjCode = dataGridView1.Rows[i].Cells["ColPrjCode"].Value.ToString();
                            PrjData.BudgetCode = BGCode;
                            PrjData.ReviseNo = RevNo;
                            var FoundRecord = (from c in Database.DbModel.HMC_BGPROJECT where c.BudgetCode == BGCode && c.PrjCode == PrjData.PrjCode && c.ReviseNo == RevNo select c).FirstOrDefault();
                            if (FoundRecord != null)
                            {
                                //Database.DbModel.HMC_BGPROJECT.Attach(PrjData);
                                //Database.DbModel.Entry(PrjData).State = System.Data.Entity.EntityState.Modified;
                                //var entity = Database.DbModel.HMC_BGPROJECT.Find(PrjData.BudgetCode, PrjData.ReviseNo, PrjData.PrjCode);
                                //Database.DbModel.Entry(entity).CurrentValues.SetValues(PrjData);
                                var entity = (from c in Database.DbModel.HMC_BGPROJECT where c.BudgetCode == PrjData.BudgetCode && c.PrjCode == PrjData.PrjCode && c.ReviseNo == RevNo select c).FirstOrDefault();
                                entity.BGTotal = PrjData.BGTotal;
                                //Database.DbModel.SaveChanges();
                            }
                            else
                                Database.DbModel.HMC_BGPROJECT.Add(PrjData);
                        }
                    }
                }
                try
                {
                    if (SetupMode == ListBudgetSetup.Mode.Blank)
                    {
                        var UpdateRevNo = (from c in Database.DbModel.HMC_BGSCENARIO where c.BudgetCode == txtBGCode.Text select c).First();
                        UpdateRevNo.ReviseNo = txtRev.Text.ToIntorDefault();
                        SetupMode = ListBudgetSetup.Mode.Update;
                    }
                    Database.DbModel.SaveChanges();
                    Database.CollectPeriodData.Clear();
                    Database.CollectPeriodUpdateData.Clear();
                    MessageBox.Show("บันทึกรายการแล้ว", "แจ้งผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (SetupMode == ListBudgetSetup.Mode.Blank)
                        SetupMode = ListBudgetSetup.Mode.Update;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("ไม่สามารถบันทึกรายการได้ พบปัญหา [{0}]", ex.Message), "โปรดตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                SetStatusMode();


                #endregion
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNewBudgetSetup frm = new CreateNewBudgetSetup();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.SetupMode == ListBudgetSetup.Mode.Blank)
                {
                    this.SetupMode = ListBudgetSetup.Mode.Blank;
                    this.txtRev.Text = "";
                    this.txtBGCode.Text = "";
                    chkApp.Checked = false;
                    FillData("xxxx", -1);
                }
                else if (frm.SetupMode == ListBudgetSetup.Mode.Update)
                {
                    this.SetupMode = ListBudgetSetup.Mode.Update;
                    this.txtRev.Text = "";
                    this.txtBGCode.Text = "";
                    chkApp.Checked = false;
                    FillData("xxxx", -1);
                }
                else
                {//Copy mode
                    this.SetupMode = ListBudgetSetup.Mode.Copy;
                    this.txtBGCode.Text = frm.BGCode;
                    this.txtRev.Text = Convert.ToString(frm.NewRevNo);
                    chkApp.Checked = false;
                    FillData(frm.BGCode, frm.NewRevNo);
                }

            }
            SetStatusMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["colTotalbudget"].Index && e.RowIndex >= 0)
            {
                // if the underlying type is int
                decimal value;
                try
                {
                    if (e.Value != null && decimal.TryParse(e.Value.ToString(), out value))
                    {
                        // e.Value = value.ToString("N2");

                        /*** OR ***

                        e.Value = value;
                        e.CellStyle.Format = "#k";

                        */
                        e.Value = value;
                        e.CellStyle.Format = "N2";
                    }
                    else if (e.Value !=null)
                    {
                        e.Value = e.Value.ToDecimalorDefault();
                        //MessageBox.Show("กรุณาป้อนตัวเลขให้ถูกต้อง", "ตรวจสอบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                       
                }
                catch (Exception ex)
                {

                    MessageBox.Show("กรุณาป้อนตัวเลขให้ถูกต้อง", "ตรวจสอบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            //if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            //    dataGridView1.DataGridControlSum_Resize(sender, e);
            

        }
    }
}
