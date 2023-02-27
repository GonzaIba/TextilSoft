using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;
using SL.Contracts.Services;
using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "config")]
namespace SL.Helper.Services.Log4net
{
    public class Logger : ILogger
    {
        private readonly IEmailService _emailService;
        private Usuario _usuario;
        private bool ValueSeted;
        public Logger(IEmailService emailService)
        {
            _emailService = emailService;
        }
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
        public void GenerateLog(Exception ex)
        {
            try
            {
                if (ex.GetType().Name.ToString() == "NullReferenceException")
                {

                }
                log.Error($"Usuario: {_usuario?.Nombre ?? "---"}:{_usuario?.DNI ?? "---"}  ",ex);
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
        public void GenerateInfo(string mensaje)
        {
            try
            {
                log.Info($"Usuario: {_usuario?.Nombre ?? "---"}:{_usuario?.DNI ?? "---"} "+mensaje);
            }
            catch
            {
            }
        }

        public void GenerateLogPerformance(string mensaje)
        {
            try
            {
                logPerformance.Info(mensaje);
            }
            catch
            {
            }
        }

        public void GenerateFatalLog(string message, Exception ex)
        {
            try
            {
                FatalLog.Fatal($"Usuario: {_usuario?.Nombre ?? "---"}:{_usuario?.DNI ?? "---"} " + message, ex);
                SendFatalErrorEmail(message);
            }
            catch
            {
            }
        }

        private void SendFatalErrorEmail(string message)
        {
            //aca enviamos el mail, agregar formato html para encabezado del mail


        }

        public void SetUser(Usuario usuario)
        {
            if (!ValueSeted)
            {
                _usuario = usuario;
                ValueSeted = true;
            }
        }

        public void Logout()
        {
            _usuario = null;
            ValueSeted = false;
        }
    }
}
