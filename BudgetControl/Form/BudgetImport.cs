using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using BudgetControl.Class.Ext;


namespace BudgetControl
{
    public partial class BudgetImport : Form
    {
        Class.NSF_DevelopEntities context = new Class.NSF_DevelopEntities();
        BindingSource bi = new BindingSource();
        List<Event> dataTemp;
        List<Class.HMC_BGSETUP> dataResultBGSetup;
        List<Class.HMC_BGPROJECT> dataResultProject;
        List<Class.HMC_BGPERIOD> dataResultPeriod;

        public BudgetImport()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf("None");
            dtGridAnnual.AutoGenerateColumns = false;
        }
        public class Event
        {
            public string BudgetCode { get; set; }
            public string ReviseNo { get; set; }
            public string PrjCode { get; set; }
            public string OCRCode { get; set; }
            public double Amount { get; set; }
            public string Period { get; set; }

        }
        protected void btnBrowseAnnual_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx";
            this.openFileDialog1.Title = "Select an excel file";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo excel = new FileInfo(openFileDialog1.FileName);
                this.textBox1.Text = openFileDialog1.FileName;
                FileStream stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet result = excelReader.AsDataSet();

                Dictionary<string, string> test = new Dictionary<string, string>();
                test.Add("None", "None");
                foreach (DataTable item in result.Tables)
                {
                    test.Add(item.TableName, item.TableName);

                }
                comboBox1.DataSource = new BindingSource(test, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                comboBox2.DataSource = new BindingSource(test, null);
                comboBox2.DisplayMember = "Value";
                comboBox2.ValueMember = "Key";

                stream.Close();
            }
        }

        private void GetExcelData(string SheetName, bool HeadType = true)
        {
            FileStream stream = File.Open(textBox1.Text, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelReader.AsDataSet();


            stream.Close();
            dataTemp = new List<Event>();
            DataRow dtRow;
            for (int curRow = 0; curRow < result.Tables[SheetName].Rows.Count; curRow++)
            {
                if (curRow <= 1)
                {
                    continue;
                }
                else
                    dtRow = result.Tables[SheetName].Rows[curRow];

                if (HeadType)
                {

                    dataTemp.Add(new Event
                    {
                        BudgetCode = dtRow[0].ToString(), // excelReader.GetString(0),
                        ReviseNo = dtRow[1].ToString(), //excelReader.GetString(1),
                        PrjCode = dtRow[2].ToString(), //excelReader.GetString(2),
                        OCRCode = dtRow[3].ToString(),//excelReader.GetString(3),
                        Amount = Convert.ToDouble(dtRow[4].ToString()),//excelReader.GetDouble(4)
                        //Period = getPeriod.ToList()
                    });

                }
                else
                {
                    dataResultPeriod.Add(new Class.HMC_BGPERIOD
                    {
                        BudgetCode = dtRow[0].ToString(), // excelReader.GetString(0),
                        ReviseNo = dtRow[1].ToIntorDefault(), //excelReader.GetString(1),
                        PrjCode = dtRow[2].ToString(), //excelReader.GetString(2),
                        OCRCode = dtRow[3].ToString(),//excelReader.GetString(3),
                        Period = dtRow[4].ToIntorDefault(),//excelReader.GetString(4),
                        PeriodAmount = dtRow[5].ToDecimalorDefault()//excelReader.GetDouble(4)
                    });
                }
            }
            if (HeadType)
            {

                foreach (var item in dataTemp)
                {
                    //var foundPrjCode = dataResultProject.Where(c => c.PrjCode == item.PrjCode).Count();
                    //if (foundPrjCode > 0)
                    //    continue;

                    var SumBGAmount = dataTemp.Where(c => c.PrjCode == item.PrjCode).Sum(c => c.Amount);
                    var PeriodData = dataResultPeriod.Where(c => c.PrjCode == item.PrjCode && c.OCRCode == item.OCRCode);
                    Class.HMC_BGPROJECT NewData = new Class.HMC_BGPROJECT();
                    NewData.BudgetCode = item.BudgetCode;
                    if (item.ReviseNo == "")
                    {
                        try
                        {
                            var MaxRevNo = Database.DbModel.HMC_BGSETUP.Where(c => c.BudgetCode == item.BudgetCode).Max(c => c.ReviseNo);
                            if (MaxRevNo != null)
                            {
                                item.ReviseNo = (MaxRevNo + 1).ToString();
                            }
                        }
                        catch (Exception)
                        {

                            item.ReviseNo = "0";
                        }
                     
                    }
                    NewData.ReviseNo = item.ReviseNo.ToIntorDefault();
                    NewData.PrjCode = item.PrjCode;
                    NewData.BGTotal = SumBGAmount.ToDecimalorDefault();
                    NewData._OCRCode = item.OCRCode;
                    NewData._Amount = item.Amount.ToDecimalorDefault();
                    if (PeriodData != null)
                        NewData._PeriodData = PeriodData.ToList();

                    NewData.ValidataData();

                    dataResultProject.Add(NewData);





                }

                var SumBGTotal = dataResultProject.Sum(c => c.BGTotal);
                var BGCode = dataResultProject.FirstOrDefault().BudgetCode;
                var RevNo = dataResultProject.FirstOrDefault().ReviseNo;
                if (BGCode != "")
                {
                    dataResultBGSetup.Add(new Class.HMC_BGSETUP
                    {
                        BudgetCode = BGCode,
                        ReviseNo = RevNo,
                        Status = "N",
                        //CreateBy = "",
                        //CreateDate = DateTime.Now,
                        TotalBudget = SumBGTotal,
                        TotalAllocate = SumBGTotal
                    }
                    );
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox2.SelectedIndex = 0;
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
            }






        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected void btnLoad_Click(object sender, EventArgs e)
        {
            dataResultBGSetup = new List<Class.HMC_BGSETUP>();
            dataResultPeriod = new List<Class.HMC_BGPERIOD>();
            dataResultProject = new List<Class.HMC_BGPROJECT>();

            try
            {
            
                if (comboBox2.Text != "None")
                    GetExcelData(comboBox2.Text, false);

                if (comboBox1.Text != "None")
                    GetExcelData(comboBox1.Text, true);

                if (checkBox1.Checked)
                {
                    foreach (var item in dataResultProject)
                    {
                        item.DistributionAmount();
                        dataResultPeriod.AddRange(item._PeriodData);
                        item.ValidataData();
                    }
                }
                
                dataResultPeriod = new List<Class.HMC_BGPERIOD>();
                foreach (var item in dataResultProject)
                {
                    dataResultPeriod.AddRange(item._PeriodData);
                }
                this.dtGridAnnual.DataSource = dataResultProject;
                this.dtGridPeriod.DataSource = dataResultPeriod;
                //dtGridAnnual.Columns["Period"].Visible = false;
                //  dtGridAnnual.Columns.Add("colPeriod", "Period");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BudgetImport_Load(object sender, EventArgs e)
        {
            context.Database.Connection.ConnectionString = "data source = 10.153.69.118; initial catalog = NSF_Develop; persist security info = True; user id = sa; password = p@ssw0rd";
            context.Database.Connection.Open();
        }

        private bool ValidateData()
        {
            //1 . ให้ตรวจยอดเงินของตาราง H และตาราง Detail ผล Sum ต้องเท่ากัน
            //2 . กรณีเลือก Auto Allowcate ให้ทำการ make row detail และยอดเงิน และเช็คผล sum ตามข้อ 1 ถ้าถูกต้องจึงปล่อยผ่านฉพาะ record นี้
            //3.  ต้องผ่านทุก record จึงจะอนุญาตให้ import ได้



            return true;

        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Import Budget File ?", "Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                double amount = 0;
                int CountFalse = dataResultProject.Where(c => c._ValidPass == false).Count();
                //var checkhaveBG = from c in Database.DbModel.HMC_BGSETUP where c.BudgetCode == 

                if (CountFalse > 0)
                {
                    MessageBox.Show("Not Save");
                    return;

                }
                List<Class.HMC_BGPROJECT> NewDataProject = new List<Class.HMC_BGPROJECT>();
                foreach (var item in dataResultProject)
                {
                    var GetupRow = NewDataProject.Where(c => c.BudgetCode == item.BudgetCode && c.PrjCode == item.PrjCode && c.ReviseNo == item.ReviseNo);
                    if (GetupRow != null && GetupRow.Count() > 0)
                    {
                        continue;
                    }
                    else
                    {
                        //Database.DbModel = new Class.NSF_DevelopEntities();
                        if (Database.DbModel.Set<Class.HMC_BGPROJECT>().Any(c => c.PrjCode == item.PrjCode && c.BudgetCode == item.BudgetCode && c.ReviseNo == item.ReviseNo))
                        {
                            //context.Entry(item).State = System.Data.EntityState.Modified;
                            Database.DbModel.HMC_BGPROJECT.Attach(item);
                            Database.DbModel.Entry(item).State = System.Data.Entity.EntityState.Modified;

                        }
                        else
                        {
                            Database.DbModel.HMC_BGPROJECT.Add(item);
                        }
                        //Database.DbModel.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        NewDataProject.Add(item);
                        //Database.DbModel.SaveChanges();

                    }
                }
                foreach (var item in dataResultBGSetup)
                {
                    if (Database.DbModel.Set<Class.HMC_BGSETUP>().Any(c => c.BudgetCode == item.BudgetCode && c.ReviseNo == item.ReviseNo))
                    {
                        //context.Entry(item).State = System.Data.EntityState.Modified;
                        Database.DbModel.HMC_BGSETUP.Attach(item);
                        Database.DbModel.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        item.UpdateBy = SAPConnector.GetUserName();
                        item.UpdateDate = DateTime.Now;


                    }
                    else
                    {
                        Database.DbModel.HMC_BGSETUP.Add(item);
                        item.CreateBy = SAPConnector.GetUserName();
                        item.CreateDate = DateTime.Now;
                    }

                }
                foreach (var item in dataResultPeriod)
                {
                    if (Database.DbModel.Set<Class.HMC_BGPERIOD>().Any(c => c.OCRCode == item.OCRCode && c.Period == item.Period && c.PrjCode == item.PrjCode && c.BudgetCode == item.BudgetCode && c.ReviseNo == item.ReviseNo))
                    {
                        //context.Entry(item).State = System.Data.EntityState.Modified;
                        Database.DbModel.HMC_BGPERIOD.Attach(item);
                        Database.DbModel.Entry(item).State = System.Data.Entity.EntityState.Modified;

                    }
                    else
                    {
                        Database.DbModel.HMC_BGPERIOD.Add(item);
                    }

                }
                // List<Class.HMC_BGPROJECT> dataDistinctProject = new List<Class.HMC_BGPROJECT>();
                //var NewDataProject = (from c in dataResultProject
                //                      select new Class.HMC_BGPROJECT
                //                      {
                //                          BudgetCode = c.BudgetCode,
                //                          BGTotal = c.BGTotal,
                //                          PrjCode = c.PrjCode,
                //                          ReviseNo = c.ReviseNo
                //                      }).Distinct().ToList();

                //Database.DbModel.HMC_BGSETUP.AddRange(dataResultBGSetup);
                //Database.DbModel.HMC_BGPROJECT.AddRange(NewDataProject);
                //Database.DbModel.HMC_BGPERIOD.AddRange(dataResultPeriod);

                try
                {
                    Database.DbModel.SaveChanges();
                    MessageBox.Show("Save Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                try
                {
                    //if (dataResult.Count > 0)
                    //{

                    //    string err = "";
                    //    var sumList = (from l in dataResultPeriod
                    //                   group l by new { l.PrjCode, l.OCRCode } into g
                    //                   select new
                    //                   {
                    //                       g.Key.PrjCode,
                    //                       g.Key.OCRCode,
                    //                       sumAmt = g.Sum(x => x.Amount)
                    //                   }).ToList();

                    //    foreach(var l in sumList)
                    //    {
                    //        var data = (from d in dataResult
                    //                    where d.OCRCode == l.OCRCode && d.PrjCode == l.PrjCode
                    //                    select d).FirstOrDefault();

                    //        if(data.Amount == l.sumAmt)
                    //        {

                    //        }
                    //        else
                    //        {
                    //            err += l.PrjCode + " , " + l.OCRCode + "\n";
                    //        }
                    //    }

                    //    if (err != "")
                    //    {
                    //        MessageBox.Show("The sum is not equal." + "\n" + err);

                    //    }
                    //    // decimal HeadAmt = dtGridAnnual.SelectedCells[].ToDecimalorDefault();

                    //    //double result = 0;
                    //    //foreach (DataGridViewRow row in dtGridPeriod.Rows)
                    //    //{
                    //    //    result += Convert.ToDouble(row.Cells["Amount"].Value);
                    //    //}

                    //    double result = dtGridPeriod.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDouble(row.Cells["Amount"].Value));
                    //    //MessageBox.Show("result " + dataResult.Count);
                    //    //MessageBox.Show("sum: "+ result);
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtGridAnnual_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (chkShowAll.Checked)
                return;
            if (e.RowIndex >= 0)
            {
                string BGCode = dtGridAnnual.Rows[e.RowIndex].Cells["BGCode"].Value.ToString();
                string PrjCode = dtGridAnnual.Rows[e.RowIndex].Cells["PrjCode"].Value.ToString();
                string OCRCode = dtGridAnnual.Rows[e.RowIndex].Cells["OCRCode"].Value.ToString();
                int RevNo = dtGridAnnual.Rows[e.RowIndex].Cells["ReviseNo"].Value.ToIntorDefault();
                var FilterData = from c in dataResultPeriod where c.BudgetCode == BGCode && c.PrjCode == PrjCode && c.ReviseNo == RevNo && c.OCRCode == OCRCode select c;

                dtGridPeriod.DataSource = FilterData.ToList();
            }
        }

        private void chkShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowAll.Checked)
            {
                dtGridPeriod.DataSource = dataResultPeriod.ToList();
            }
        }
    }
}
