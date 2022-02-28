using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public sealed class AppSettings
    {
        private readonly static AppSettings _instance = new AppSettings();
        public readonly string sqlStringTextil = ConfigurationManager.ConnectionStrings["DBConecction"].ConnectionString;
        public readonly string BackupDB = "BACKUP DATABASE[ProyectoTextil] TO  DISK = N'" + ConfigurationManager.AppSettings["TEMP_BACKUP"] + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + " " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + " ProyectoTextil.bak" + "' WITH NOFORMAT, NOINIT, NAME = N'ProyectoTextil-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
        public readonly string filepath = ConfigurationManager.AppSettings["TEMP_LOG"];

        public static AppSettings Current
        {
            get
            {
                return _instance;
            }
        }
    }
}
