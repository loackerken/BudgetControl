using BudgetControl.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Data.Common.DbConnectionStringBuilder;
using static System.Data.EntityClient.EntityConnectionStringBuilder;

namespace BudgetControl
{




    public static class Database
    {

        public static List<Class.HMC_BGPERIOD> CollectPeriodData;
        public static List<Class.HMC_BGPERIOD> CollectPeriodUpdateData;
        public static string ErrMsg;
        public static bool CopyBudgetData(string BGCode, int RevNo, out int NewRevNo)
        {
            ErrMsg = "";
            bool result = false;
            var SetupData = (from c in DbModel.HMC_BGSETUP where c.BudgetCode == BGCode && c.ReviseNo == RevNo select c).FirstOrDefault();
            var MaxRevNo = (from c in DbModel.HMC_BGSETUP where c.BudgetCode == BGCode select c.ReviseNo).Max();
            if (MaxRevNo == null)
            {
                NewRevNo = -1;
                return result;

            }
            NewRevNo = MaxRevNo + 1;
            Class.HMC_BGSETUP NewHData = new HMC_BGSETUP();
            NewHData.BudgetCode = SetupData.BudgetCode;
            NewHData.CreateBy = "";
            NewHData.CreateDate = DateTime.Now;
            NewHData.ReviseNo = MaxRevNo + 1;
            NewHData.TotalBudget = SetupData.TotalBudget;
            NewHData.TotalAllocate = SetupData.TotalAllocate;
            DbModel.HMC_BGSETUP.Add(NewHData);

            var ProjectData = (from c in DbModel.HMC_BGPROJECT where c.BudgetCode == BGCode && c.ReviseNo == RevNo select c);
            foreach (var item in ProjectData)
            {
                Class.HMC_BGPROJECT NewData = new HMC_BGPROJECT();
                NewData.BudgetCode = BGCode;
                NewData.ReviseNo = MaxRevNo + 1;
                NewData.PrjCode = item.PrjCode;
                NewData.BGTotal = item.BGTotal;
                DbModel.HMC_BGPROJECT.Add(NewData);
            }


            var PeriodData = (from c in DbModel.HMC_BGPERIOD where c.BudgetCode == BGCode && c.ReviseNo == RevNo select c);
            foreach (var item in PeriodData)
            {
                Class.HMC_BGPERIOD NewData = new HMC_BGPERIOD();
                NewData.BudgetCode = BGCode;
                NewData.ReviseNo = MaxRevNo + 1;
                NewData.PrjCode = item.PrjCode;
                NewData.OCRCode = item.OCRCode;
                NewData.Period = item.Period;
                NewData.PeriodAmount = item.PeriodAmount;
                NewData.BudgetYear = item.BudgetYear;
                DbModel.HMC_BGPERIOD.Add(NewData);
            }

            var UpdateRevNo = (from c in Database.DbModel.HMC_BGSCENARIO where c.BudgetCode == BGCode select c).First();
            UpdateRevNo.ReviseNo = NewRevNo;

            try
            {
                DbModel.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                result = false;
            }
            return result;
        }

        /*
        private static System.Data.EntityClient.EntityConnectionStringBuilder oTempEntity = new System.Data.EntityClient.EntityConnectionStringBuilder
        {
            Metadata = "res://*",
            Provider = "System.Data.SqlClient",
            ProviderConnectionString = new System.Data.SqlClient.SqlConnectionStringBuilder
            {
                DataSource = Properties.Settings.Default.sapServer,
                InitialCatalog = Properties.Settings.Default.databaseName,
                IntegratedSecurity = false,
                UserID = Properties.Settings.Default.dbUser,
                Password = Properties.Settings.Default.dbPassword,
                MultipleActiveResultSets = true
            }.ConnectionString
        };
         * */
        private static HMC_Crypto.HMCCrypto.UseEncrypt Encrypt = new HMC_Crypto.HMCCrypto.UseEncrypt();
        public static System.Data.EntityClient.EntityConnectionStringBuilder oTempEntity = new System.Data.EntityClient.EntityConnectionStringBuilder
        {
            Metadata = "res://*",
            Provider = "System.Data.SqlClient",
            ProviderConnectionString = new System.Data.SqlClient.SqlConnectionStringBuilder
            {
                DataSource = Properties.Settings.Default.sapServer,
                InitialCatalog = Properties.Settings.Default.databaseName,
                IntegratedSecurity = false,
                UserID = Properties.Settings.Default.dbUser,
                Password = Encrypt.DecodeSymmetric("humanica", Properties.Settings.Default.dbPassword),
                MultipleActiveResultSets = true
            }.ConnectionString
        };

        public static void setNewConnection()
        {
            oTempEntity = new System.Data.EntityClient.EntityConnectionStringBuilder
            {
                Metadata = "res://*",
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = new System.Data.SqlClient.SqlConnectionStringBuilder
                {
                    DataSource = Properties.Settings.Default.sapServer,
                    InitialCatalog = Properties.Settings.Default.databaseName,
                    IntegratedSecurity = false,
                    UserID = Properties.Settings.Default.dbUser,
                    Password = Encrypt.DecodeSymmetric("humanica", Properties.Settings.Default.dbPassword),
                    MultipleActiveResultSets = true
                }.ConnectionString
            };
            // DbModel.CommandTimeout = 180;
            DbModel = new NSF_DevelopEntities();
            //DbModel.Database.Connection.ConnectionString = oTempEntity.ConnectionString;

        }

        public static bool CheckSetting()
        {
            Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.sapServer == null)
            {
                return false;
            }
            else
            {
                if (Properties.Settings.Default.sapServer == "")
                {
                    return false;
                }
            }

            if (Properties.Settings.Default.databaseName == null)
            {
                return false;
            }
            else
            {
                if (Properties.Settings.Default.databaseName == "")
                {
                    return false;
                }
            }

            if (Properties.Settings.Default.dbUser == null)
            {
                return false;
            }
            else
            {
                if (Properties.Settings.Default.dbUser == "")
                {
                    return false;
                }
            }

            if (Properties.Settings.Default.dbPassword == null)
            {
                return false;
            }
            else
            {
                if (Properties.Settings.Default.dbPassword == "")
                {
                    return false;
                }
            }
            return true;
        }

        public static NSF_DevelopEntities DbModel = new NSF_DevelopEntities();

        // DbM(oTempEntity.ConnectionString);
    }


}

//namespace BudgetControl.Class
//{
//    public partial class HMC_BGPERIOD
//    {
//        public string BudgetYear { get; set; }
//        // put your additional logic here
//    }
//}
