using SL.Domain.Enums;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts.Services
{
    public interface ILoggerService : IGenericService<LoggerModel>
    {
        void SaveLog(Exception ex, string message,LogLevelEnum logLevelEnum);
    }
}
