using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetControl
{
    public static class SAPConnector
    {
        public static SAPbobsCOM.Company mCompany = new SAPbobsCOM.Company();
        public static SAPbobsCOM.Company uCompany = new SAPbobsCOM.Company();
        public static bool canDelete = false;
        public static string errMsg;

        public static bool CheckSettingValue()
        {
            if (Properties.Settings.Default.dbServerType == null)
            {
                return false;
            }
            else
            {
                if (Properties.Settings.Default.dbServerType == "")
                {
                    return false;
                }
            }

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

            if (Properties.Settings.Default.sapLicenseServer == null)
            {
                return false;
            }
            else
            {
                if (Properties.Settings.Default.sapLicenseServer == "")
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

            return true;
        }

        public static bool ManagerConnect()
        {
            HMC_Crypto.HMCCrypto.UseEncrypt Encrypt = new HMC_Crypto.HMCCrypto.UseEncrypt();
            if (Properties.Settings.Default.dbServerType == "")
                mCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes)1;
            else
                mCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes)(Convert.ToInt32(Properties.Settings.Default.dbServerType) + 1);
            mCompany.Server = Properties.Settings.Default.sapServer;
            mCompany.LicenseServer = string.Format("{0}:{1}", Properties.Settings.Default.sapServer, 30000);//Properties.Settings.Default.sapLicenseSever;
            mCompany.DbUserName = Properties.Settings.Default.dbUser;
            mCompany.DbPassword = Encrypt.DecodeSymmetric("humanica", Properties.Settings.Default.dbPassword); //Must Encrypt
            mCompany.CompanyDB = Properties.Settings.Default.databaseName;

            Console.WriteLine("dbType : " + mCompany.DbServerType + " Server : " + mCompany.Server + " License : " + mCompany.LicenseServer + " User : " + mCompany.UserName + " Pass : " + mCompany.Password);

            if (mCompany.Connect() == 0)
            {
                Console.WriteLine("SAP Connected!");
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Cannot connect manager account. Please check setting." + mCompany.GetLastErrorDescription());
                return false;
            }
        }

        public static bool UserConnect(string username, string password)
        {
            HMC_Crypto.HMCCrypto.UseEncrypt Encrypt = new HMC_Crypto.HMCCrypto.UseEncrypt();
            if (Properties.Settings.Default.dbServerType == "")
                uCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes)1;
            else
                uCompany.DbServerType = (SAPbobsCOM.BoDataServerTypes)(Convert.ToInt32(Properties.Settings.Default.dbServerType) + 1);
            uCompany.Server = Properties.Settings.Default.sapServer;
            uCompany.LicenseServer = string.Format("{0}:{1}", Properties.Settings.Default.sapServer, 30000);
            uCompany.DbUserName = Properties.Settings.Default.dbUser;
            uCompany.DbPassword = Encrypt.DecodeSymmetric("humanica", Properties.Settings.Default.dbPassword); //Must Encrypt
            uCompany.CompanyDB = Properties.Settings.Default.databaseName;
            uCompany.UserName = username;
            uCompany.Password = password;

            return true;

#pragma warning disable CS0162 // Unreachable code detected
            if (uCompany.Connect() == 0)
#pragma warning restore CS0162 // Unreachable code detected
            {
                try
                {
                    SAPbobsCOM.Users user = (SAPbobsCOM.Users)uCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers);
                    user.GetByKey(uCompany.UserSignature);
                    Console.WriteLine("User LogisClear Flag = " + user.UserFields.Fields.Item("U_LogisClear").Value.ToString());
                    if (user.UserFields.Fields.Item("U_Logistics").Value.ToString() == "Y")
                    {
                        if (user.UserFields.Fields.Item("U_LogisClear").Value.ToString() == "Y")
                        {
                            canDelete = true;
                        }
                        else
                        {
                            canDelete = false;
                        }
                        return true;
                    }
                    else
                    {
                        errMsg = "No permision";
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error :" + e.Message);
                    errMsg = e.Message;
                    return false;
                }
            }
            else
            {
                if (uCompany.GetLastErrorCode() == 100000048)
                {
                //    var uLogin = (from u in Database.DbModel.OUSR
                //                  where u.USER_CODE == uCompany.UserName
                //                  select new { u.U_Logistics, u.U_LogisClear }).FirstOrDefault();

                //    if (uLogin.U_Logistics == "Y")
                //    {
                //        if (uLogin.U_LogisClear == "Y")
                //        {
                //            canDelete = true;
                //        }
                //        return true;
                //    }
                //    else
                //    {
                //        errMsg = "No permision";
                //        return false;
                //    }
                    return true;
                }
                else
                {
                    errMsg = uCompany.GetLastErrorDescription();
                    return false;
                }
            }
        }
    }
}
