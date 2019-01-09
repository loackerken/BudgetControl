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
    public partial class BudgetTransfer : Form
    {
        string mBGCode = "";
        string mBGDimCode = "";
        string mBGPrjCode = "";
        int mRevNo = -1;
        public BudgetTransfer()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBGCode_Click(object sender, EventArgs e)
        {
            ListBudgetSetup frm = new BudgetControl.ListBudgetSetup(ListBudgetSetup.Mode.Copy);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBGCode.Text = frm.selectBGCode;
                txtRevNo.Text = frm.selectBGRevise;
                txtBGName.Text = frm.selectBGName;

                mBGCode = frm.selectBGCode;
                mRevNo = frm.selectBGRevise.ToIntorDefault();
                initPeriod();
            }
        }
        private void initPeriod()
        {
            var pData = (from c in Database.DbModel.HMC_BGPERIOD where c.BudgetCode == mBGCode && c.ReviseNo == mRevNo select c.Period);
            DataGridViewComboBoxColumn combo1 = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColFromPeriod"];
            DataGridViewComboBoxColumn combo2 = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColToPeriod"];

            combo1.Items.Clear();
            combo2.Items.Clear();
            foreach (var item in pData.Distinct())
            {
                combo1.Items.Add(item.ToString());
                combo2.Items.Add(item.ToString());
            }


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListTransfer frm = new BudgetControl.ListTransfer(ListTransfer.Mode.Copy);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBGCode.Text = frm.selectBGCode;
                txtRevNo.Text = frm.selectBGRevise;
                txtBGName.Text = frm.selectBGName;
                txtTRNo.Text = frm.selectTRNo.ToString();
                chkApprove.Checked = frm.selectStatus;
                if (frm.selectTRDate != null)
                    dtDate.Value = frm.selectTRDate.Value;

                var lines = from c in Database.DbModel.HMC_BGTRANL where c.TRNo == frm.selectTRNo select c;
                if (lines.Count() != 0)
                {
                    dataGridView1.DataSource = lines.ToList();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                switch (dataGridView1.Columns[e.ColumnIndex].Name)
                {
                    case "ColBFCost":
                        {
                            ListPopup frm = new ListPopup(ListPopup.Mode.Dimension);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                dataGridView1.Rows[e.RowIndex].Cells["ColHFCost"].Value = frm.selectCode;
                                dataGridView1.Rows[e.RowIndex].Cells["ColFromCost"].Value = string.Format("({0}) {1}", frm.selectCode, frm.selectName);
                            }

                        }
                        break;
                    case "ColBTCost":
                        {
                            ListPopup frm = new ListPopup(ListPopup.Mode.Dimension);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                dataGridView1.Rows[e.RowIndex].Cells["ColHTCost"].Value = frm.selectCode;
                                dataGridView1.Rows[e.RowIndex].Cells["ColToCost"].Value = string.Format("({0}) {1}", frm.selectCode, frm.selectName);
                            }

                        }
                        break;
                    case "ColBFProject":
                        {
                            ListPopup frm = new ListPopup(ListPopup.Mode.Project);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                dataGridView1.Rows[e.RowIndex].Cells["ColHFProject"].Value = frm.selectCode;
                                dataGridView1.Rows[e.RowIndex].Cells["ColFromProject"].Value = string.Format("({0}) {1}", frm.selectCode, frm.selectName);
                            }

                        }
                        break;
                    case "ColBTProject":
                        {
                            ListPopup frm = new ListPopup(ListPopup.Mode.Project);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                dataGridView1.Rows[e.RowIndex].Cells["ColHTProject"].Value = frm.selectCode;
                                dataGridView1.Rows[e.RowIndex].Cells["ColToProject"].Value = string.Format("({0}) {1}", frm.selectCode, frm.selectName);
                            }

                        }
                        break;
                    

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ColAmount"].Index && e.RowIndex >= 0)
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
                    else if (e.Value != null)
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ("ColFromPeriod" == dataGridView1.Columns[e.ColumnIndex].Name)
            {
                mBGPrjCode = dataGridView1.Rows[e.RowIndex].Cells["ColHFProject"].Value.ToString();
                mBGDimCode = dataGridView1.Rows[e.RowIndex].Cells["ColHFCost"].Value.ToString();
                int Period = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToIntorDefault();
                var Balance = (from c in Database.DbModel.HMC_BGPERIOD where c.BudgetCode == mBGCode && c.PrjCode == mBGPrjCode && c.OCRCode == mBGDimCode && c.ReviseNo == mRevNo && c.Period == Period select c.PeriodAmount).FirstOrDefault();
                dataGridView1.Rows[e.RowIndex].Cells["ColBalance"].Value = Balance;
            }

        }
    }
}
