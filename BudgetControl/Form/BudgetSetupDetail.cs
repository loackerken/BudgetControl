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
using System.Globalization;

namespace BudgetControl
{
    public partial class BudgetSetupDetail : Form
    {
        decimal tempSumAmt = 0;
        int NoPeriod = 0;
        string FiscalYear = "";
        public decimal SumAmount = 0;

        public BudgetSetupDetail(string BGCode, string PrjCode, string DimCode,int RevNo)
        {

            InitializeComponent();

            var BG = Database.DbModel.HMC_BGSCENARIO.Where(c => c.BudgetCode == BGCode).FirstOrDefault();
            if (BG == null)
            {
                MessageBox.Show(string.Format("Budget Code {0} not found.", BGCode), "Validate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOK.Enabled = false;
                //btnCancel_Click(null,null);
                return;

            }

            txtBGCode.Text = BGCode;
            txtBGName.Text = BG.BudgetName;
            NoPeriod = BG.NoOfPeriod.GetValueOrDefault();
            FiscalYear = BG.BudgetYear;
            txtRev.Text = RevNo.ToString();
            var PJ = Database.DbModel.OPRJ.Where(c => c.PrjCode == PrjCode).FirstOrDefault();
            txtPrjCode.Text = PrjCode;
            lblPrjName.Text = PJ.PrjName;
            var DIM = Database.DbModel.OPRC.Where(c => c.PrcCode == DimCode).FirstOrDefault();
            txtDimCode.Text = DimCode;
            lblDimName.Text = DIM.PrcName;
            InitData();
            SumAllocate();

        }
        private void InitData()
        {
            //var GetData = Database.DbModel.HMC_BGPERIOD.Where(c => c.BudgetCode == txtBGCode.Text && c.ReviseNo == Convert.ToInt16(txtRev.Text));
            dataGridView1.AutoGenerateColumns = false;
            int RevNo = Convert.ToInt32(txtRev.Text);
            //var GetData = (from c in Database.DbModel.HMC_BGPERIOD where c.BudgetCode == txtBGCode.Text && c.ReviseNo == RevNo && c.PrjCode == txtPrjCode.Text && c.OCRCode == txtDimCode.Text select new { BudgetYear = FiscalYear, BudgetCode = c.BudgetCode, ReviseNo=c.ReviseNo,PrjCode = c.PrjCode, OCRCode = c.OCRCode, Period = c.Period, PeriodAmount = c.PeriodAmount }).ToList();
            var GetData = (from c in Database.DbModel.HMC_BGPERIOD where c.BudgetCode == txtBGCode.Text && c.ReviseNo == RevNo && c.PrjCode == txtPrjCode.Text && c.OCRCode == txtDimCode.Text select c);
            Console.WriteLine(GetData.Count());
            if (GetData != null && GetData.ToList().Count() > 0)
            {
                dataGridView1.DataSource = GetData.ToList();
            }
            else
            {
                if (BudgetControl.Database.CollectPeriodData != null && BudgetControl.Database.CollectPeriodData.Count > 0)
                {
                    var GetDatafromList = (from c in BudgetControl.Database.CollectPeriodData where c.BudgetCode == txtBGCode.Text && c.ReviseNo == RevNo && c.PrjCode == txtPrjCode.Text && c.OCRCode == txtDimCode.Text select c);
                    if (GetDatafromList != null && GetDatafromList.ToList().Count > 0)
                    {
                        dataGridView1.DataSource = GetDatafromList.ToList();
                        return;
                    }
                    else
                    {
                        //do step down;
                    }
                }

                decimal? DefValue = 0;
                //var NewData = (from c in Database.DbModel.HMC_BGPERIOD where c.BudgetCode == "xxxx" select new { BudgetYear = FiscalYear, Period = c.Period, Amount = c.PeriodAmount }).ToList();
                List<Class.HMC_BGPERIOD> NewData = new List<Class.HMC_BGPERIOD>();
                for (int i = 1; i <= NoPeriod; i++)
                {
                    NewData.Add(new Class.HMC_BGPERIOD { BudgetYear = FiscalYear, BudgetCode = txtBGCode.Text, OCRCode = txtDimCode.Text, Period = i, PeriodAmount = 0, PrjCode = txtPrjCode.Text, ReviseNo = RevNo });
                }

                dataGridView1.DataSource = NewData;

                dataGridView1.Columns["ColAmount"].ReadOnly = false;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ColAmount"].Index && e.RowIndex >= 0)
            {
                // if the underlying type is int
                int value;
                try
                {
                    if (e.Value != null && int.TryParse(e.Value.ToString(), out value))
                    {
                        // e.Value = value.ToString("N2");

                        /*** OR ***

                        e.Value = value;
                        e.CellStyle.Format = "#k";

                        */
                        e.Value = value;
                        e.CellStyle.Format = "N2";
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("กรุณาป้อนตัวเลขให้ถูกต้อง", "ตรวจสอบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }




        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SumAllocate();
        }
        private void SumAllocate()
        {
            List<Class.HMC_BGPERIOD> data = (List<Class.HMC_BGPERIOD>)dataGridView1.DataSource;
            SumAmount = data.Sum(c => c.PeriodAmount).GetValueOrDefault();
            txtAmount.Text = SumAmount.ToString("N2");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (BudgetControl.Database.CollectPeriodData == null)
                BudgetControl.Database.CollectPeriodData = new List<Class.HMC_BGPERIOD>();

            SumAllocate();
            List<Class.HMC_BGPERIOD> data = (List<Class.HMC_BGPERIOD>)dataGridView1.DataSource;
            foreach (var item in data)
            {
                var findRecord = (from c in BudgetControl.Database.DbModel.HMC_BGPERIOD where c.BudgetCode == item.BudgetCode && c.PrjCode == item.PrjCode && c.OCRCode == item.OCRCode && c.ReviseNo == item.ReviseNo && c.Period == item.Period select c).FirstOrDefault();
                if (findRecord != null)
                {
                    if (BudgetControl.Database.CollectPeriodUpdateData == null)
                        BudgetControl.Database.CollectPeriodUpdateData = new List<Class.HMC_BGPERIOD>();

                    findRecord.PeriodAmount = item.PeriodAmount;
                    BudgetControl.Database.CollectPeriodUpdateData.Add(findRecord);
                }
                else
                {
                    var findColRecord = (from c in BudgetControl.Database.DbModel.HMC_BGPERIOD where c.BudgetCode == item.BudgetCode && c.PrjCode == item.PrjCode && c.OCRCode == item.OCRCode && c.ReviseNo == item.ReviseNo && c.Period == item.Period select c).FirstOrDefault();
                    if (findColRecord != null)
                        findColRecord.PeriodAmount = item.PeriodAmount;
                    else
                        BudgetControl.Database.CollectPeriodData.Add(item);
                }

            }

        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            
            decimal HeadAmt = txtAmount.Text.ToDecimalorDefault();
            txtAmount.Text = HeadAmt.ToString("N2");
            if (tempSumAmt == HeadAmt)
                return;
            int RowCount = dataGridView1.Rows.Count;
            if (HeadAmt > 0 && RowCount > 0)
            {
                decimal sumAmt = 0;
                decimal averageAmt = Math.Round(HeadAmt / RowCount, 2);
                for (int i = 0; i < RowCount; i++)
                {
                    if (i == RowCount - 1)
                    {
                        dataGridView1.Rows[i].Cells["ColAmount"].Value = HeadAmt - sumAmt;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells["ColAmount"].Value = averageAmt;
                        sumAmt += averageAmt;
                    }
                }
            }

        }

        private void BudgetSetupDetail_Load(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            //TextBox myTxt = (TextBox)sender;
            //if (myTxt.Text == "")
            //    return;
            //int n = myTxt.SelectionStart;
            //decimal text = Convert.ToDecimal(myTxt.Text);
            //myTxt.Text = String.Format("{0:N2}", text);
            //myTxt.SelectionStart = n+ 1;
        }
         

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            tempSumAmt = txtAmount.Text.ToDecimalorDefault();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == '.') && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
