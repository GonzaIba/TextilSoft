using SL.Contracts;
using SL.Contracts.Repositories;
using SL.Contracts.Services;
using SL.Domain.Model;
using SL.Helper.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Business.Services
{
    public class LoggerService : GenericService<LoggerModel>, ILoggerService
    {
        private readonly CompanyConfiguration _companyConfiguration;
        public LoggerService(IUnitOfWork unitOfWork, CompanyConfiguration companyConfiguration)
        : base(unitOfWork, unitOfWork.GetRepository<ILoggerRepository>())
        {
            _companyConfiguration = companyConfiguration;
        }

        public void SaveLog(Exception ex, string message)
        {
            LoggerModel loggerModel = new LoggerModel();
            loggerModel.Thread = ex.StackTrace;
            loggerModel.Level = "aa";
            loggerModel.Logger = "??";
            loggerModel.CompanyId = _companyConfiguration.CompanyId;
            if (ex.InnerException != null)
            {
                string messageInner = LeerInnerException(ex.InnerException,"");
                loggerModel.Message = message + messageInner;
            }
            else
                loggerModel.Message = message + ex.Message;

            loggerModel.Exception = ex.GetType().Name.ToString();
            _repository.Insert(loggerModel);
            _unitOfWork.SaveChanges();
        }

        private string LeerInnerException(Exception ex, string message)
        {
            message += ex.Message;
            if (ex.InnerException != null)
                return LeerInnerException(ex, message);
            else
                return message;
        }
    }
}
