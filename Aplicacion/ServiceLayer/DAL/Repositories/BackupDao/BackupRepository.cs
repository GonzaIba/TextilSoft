using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Repositories.BackupDao
{
    internal class BackupRepository
    {

        #region Singleton
        private readonly static BackupRepository _instance = new BackupRepository();

        public static BackupRepository GetInstance
        {
            get
            {
                return _instance;
            }
        }
        private BackupRepository()
        {

        }
        #endregion

        public void GenerarBackup()
        {
            string comando = AppSettings.Current.BackupDB;
            SqlConnection conexion = new SqlConnection(AppSettings.Current.sqlStringTextil);
            SqlCommand cmd = new SqlCommand(comando, conexion);
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }
    }
}
