using iTextSharp.text;
using iTextSharp.text.pdf;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using log4net;
using Microsoft.AspNetCore.Http;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Helper.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Services.Log4net
{
    public class Logger : ILogger
    {
        private readonly ILoggerService _loggerService;
        private readonly IEmailService _emailService;
        private readonly ICompanyService _companyService;
        private readonly CompanyConfiguration _companyConfiguration;
        private Usuario _usuario;
        private bool ValueSeted;
        public Logger(IEmailService emailService, CompanyConfiguration companyConfiguration, ICompanyService companyService, ILoggerService loggerService)
        {
            _emailService = emailService;
            _companyConfiguration = companyConfiguration;
            _companyService = companyService;
            _loggerService = loggerService;
            InitializeLogger();
        }
        private log4net.ILog log = log4net.LogManager.GetLogger("LoggerManager");
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger("LogerManager");
        private readonly log4net.ILog logPerformance = log4net.LogManager.GetLogger("Performance");
        private readonly log4net.ILog FatalLog = log4net.LogManager.GetLogger("AdoNetAppender");

        /// <summary>
        /// Agrega una linea al archivo de log
        /// </summary>
        /// <param name="mensaje">
        /// Mensaje a guardar en el archivo
        /// </param>
        public void GenerateLogError(string mensaje, Exception ex)
        {
            try
            {
                if (ex.GetType().Name.ToString() == "NullReferenceException")
                {

                }
                log.Error($"Usuario: {_usuario?.Nombre ?? "---"}:{_usuario?.DNI ?? "---"}  "+ mensaje, ex);
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
                log = log4net.LogManager.GetLogger("HOJALDRE");
                log.Info($"Usuario: {_usuario?.Nombre ?? "---"}:{_usuario?.DNI ?? "---"} "+mensaje);
            }
            catch
            {
            }
        }


        /// <summary>
        /// Agrega una linea al archivo de log cuando ocurre un error fatal. Este envia un mail automaticamente (en caso de que este activado) y lo inserta en la tabla
        /// </summary>
        /// <param name="mensaje">
        /// Mensaje a guardar en el archivo (generalmente se usa el Init y el finish).
        /// </param>
        public void GenerateFatalLog(string message, Exception ex)
        {
            try
            {
                string MensajeUsuario = $"Usuario: {_usuario?.Nombre ?? "---"}:{_usuario?.DNI ?? "---"} " + message;
                FatalLog.Fatal(MensajeUsuario, ex);
                _loggerService.SaveLog(ex, MensajeUsuario);
                SendFatalErrorEmail(message);
            }
            catch
            {
            }
        }


        /// <summary>
        /// Agrega una linea al archivo de performance (Se utiliza para ver el rendimiento de ciertos metodos o funciones.
        /// </summary>
        /// <param name="mensaje">
        /// Mensaje a guardar en el archivo (generalmente se usa el Init y el finish).
        /// </param>
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

        #region Extras
        private void SendFatalErrorEmail(string message)
        {
            string mailCompany = _companyService.Get(x => x.CompanyId == _companyConfiguration.CompanyId).FirstOrDefault().CompanyMail;
            //aca enviamos el mail, agregar formato html para encabezado del mail
            if(!string.IsNullOrEmpty(mailCompany))
                _emailService.NotificateFatalError(mailCompany, message);
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

        private void InitializeLogger()
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date [%thread] %-5level %logger [%ndc] %line - %message%newline";
            patternLayout.ActivateOptions();

            RollingFileAppender roller = new RollingFileAppender();
            roller.LockingModel = new FileAppender.MinimalLock();
            roller.Name = "LoggerManager";
            roller.AppendToFile = false;
            roller.File = @"Logs\EventLog.txt";
            roller.Layout = patternLayout;
            roller.MaxSizeRollBackups = 5;
            roller.MaximumFileSize = "10MB";
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
            roller.StaticLogFileName = true;
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);

            MemoryAppender memory = new MemoryAppender();
            memory.ActivateOptions();
            hierarchy.Root.AddAppender(memory);

            //hierarchy.Root.Level = Level.Info;
            hierarchy.Configured = true;
        }
        #endregion
    }
}
