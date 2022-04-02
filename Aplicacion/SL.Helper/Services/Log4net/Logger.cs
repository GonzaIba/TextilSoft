using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "config")]
namespace SL.Helper.Services.Log4net
{
    public static class Logger
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("LogerManager");
        private static readonly log4net.ILog logPerformance = log4net.LogManager.GetLogger("Performance");
        private static readonly log4net.ILog FatalLog = log4net.LogManager.GetLogger("AdoNetAppender");

        /// <summary>
        /// Agrega una linea al archivo de log
        /// </summary>
        /// <param name="mensaje">
        /// Mensaje a guardar en el archivo
        /// </param>
        public static void GenerateLog(Exception ex)
        {
            try
            {
                if (ex.GetType().Name.ToString() == "NullReferenceException")
                {

                }
                log.Error(ex);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Agrega una linea al archivo de log
        /// </summary>
        /// <param name="mensaje">
        /// Mensaje a guardar en el archivo
        /// </param>
        public static void GenerateInfo(string mensaje)
        {
            try
            {
                log.Info(mensaje);
            }
            catch
            {
            }
        }

        public static void GenerateLogPerformance(string mensaje)
        {
            try
            {
                logPerformance.Info(mensaje);
            }
            catch
            {
            }
        }

        public static void GenerateFatalLog(string message, Exception ex)
        {
            try
            {
                FatalLog.Fatal(message, ex);
                SendFatalErrorEmail(message);
            }
            catch
            {
            }
        }

        private static void SendFatalErrorEmail(string message)
        {
            //aca enviamos el mail, agregar formato html para encabezado del mail



        }


    }
}
