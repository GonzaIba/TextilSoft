using log4net.Core;
using ServiceLayer.DAL.Repositories.BackupDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL.BackupBLL
{
    internal class BackupService
    {
        #region Singleton
        private readonly static BackupService _instance = new BackupService();

        public static BackupService GetInstance
        {
            get
            {
                return _instance;
            }
        }
        private BackupService()
        {

        }
        #endregion

        public void GenerarBackup()
        {
            try
            {
                BackupRepository.GetInstance.GenerarBackup();
                //LoggerManager.Current.Write($"Fecha: {DateTime.Now} | Mensaje: Se genero un backup de la BD correctamente.", EventLevel.Informational);
            }
            catch (Exception ex)
            {
                //LoggerManager.Current.Write($"Fecha: {DateTime.Now} | Mensaje: Ocurrio un error al generar un backup de la BD. | Detalle Mensaje: {ex.Message} |", EventLevel.Warning);
                throw ex;
            }
        }
    }
}
