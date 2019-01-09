using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetControl.Class
{
    class ExtendClass
    {
    }
    public partial class HMC_BGPROJECT
    {
        public string _ValidateMessage { get; set; }
        public bool _ValidPass { get; set; }
        public int _NoOfPeriod { get; set; }
        public string _OCRCode { get; set; }
        public decimal _Amount { get; set; }
        public List<Class.HMC_BGPERIOD> _PeriodData { get; set; }
        public void ValidataData()
        {
            _ValidateMessage = "";
            _ValidPass = false;
            _NoOfPeriod = 0;
            CheckProject();
            CheckBudgetCode();
            CheckDimension();
            if (checkNoPeriod())
            {
                CheckAmount();
            }
            if (_ValidateMessage == "")
            {
                _ValidPass = true; 
            }
        }
        private bool checkNoPeriod()
        {
            bool result = false;
            if (_PeriodData != null && _NoOfPeriod == _PeriodData.Count)
            {
                result = true;
            }
            else
            {
                result = false;
                _ValidateMessage += string.Format("จำนวนงวด ไม่ถูกต้อง");
            }
            return result;
        }

        private void CheckAmount()
        {
            var SumAmountinPeriod = _PeriodData.Sum(c => c.PeriodAmount);
            decimal DiffAmount = _Amount - SumAmountinPeriod.GetValueOrDefault();
            if (DiffAmount != 0)
            {
                _ValidateMessage += string.Format("ยอดเงินรวมของ Period ไม่ตรงกับยอด Project Amount ผลต่างจำนวน {0}", DiffAmount);
            }
        }
        private void CheckProject()
        {
            var foundPrj = from c in Database.DbModel.OPRJ
                           where c.PrjCode == PrjCode && c.U_HMC_UseBudget == "Y"
                           select c;
            if (foundPrj == null || foundPrj.Count() <= 0)
            {
                _ValidateMessage += string.Format("ไม่พบ Project Code {0}", PrjCode);
            }

        }
        private void CheckBudgetCode()
        {
            var foundBGCode = from c in Database.DbModel.HMC_BGSCENARIO
                              where c.BudgetCode == BudgetCode
                              select c;
            if (foundBGCode == null || foundBGCode.Count() <= 0)
            {
                _ValidateMessage += string.Format("ไม่พบ Project Code {0}", BudgetCode);
            }
            else
            {
                _NoOfPeriod = foundBGCode.FirstOrDefault().NoOfPeriod.GetValueOrDefault();
                foreach (var item in _PeriodData)
                {
                    item.BudgetYear = foundBGCode.FirstOrDefault().BudgetYear;
                }
                             
            }
        }
        private void CheckDimension()
        {
            var foundDimension = from c in Database.DbModel.OPRC
                                 where c.PrcCode == _OCRCode && c.U_HMC_UseBudget == "Y"
                                 select c;
            if (foundDimension == null || foundDimension.Count() <= 0)
            {
                _ValidateMessage += string.Format("ไม่พบ Dimension Code {0}", _OCRCode);
            }

        }
        public void DistributionAmount()
        {
            // decimal SumValue = 0;
            for (int i = 1; i <= _NoOfPeriod; i++)
            {
                HMC_BGPERIOD Perioddata = new HMC_BGPERIOD();
                Perioddata.BudgetCode = BudgetCode;
                Perioddata.OCRCode = _OCRCode;
                Perioddata.PrjCode = PrjCode;
                Perioddata.ReviseNo = ReviseNo;
                Perioddata.Period = i;
                if (i == _NoOfPeriod)
                {
                    var SumValue = _PeriodData.Sum(c => c.PeriodAmount);
                    Perioddata.PeriodAmount = Math.Round(_Amount - SumValue.GetValueOrDefault(), 2);

                }
                else
                {
                    Perioddata.PeriodAmount = Math.Round(_Amount / _NoOfPeriod, 2);
                }

                _PeriodData.Add(Perioddata);


            }

        }

    }
}
