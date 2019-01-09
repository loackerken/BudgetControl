using BudgetControl.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetControl
{
    public static class Database
    {
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
                Password = Encrypt.DecodeSymmetric("humanica",Properties.Settings.Default.dbPassword),
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
            DbModel.Database.Connection.ConnectionString = oTempEntity.ConnectionString;
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
