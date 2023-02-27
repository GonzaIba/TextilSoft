using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Services.Log4net
{
    public interface ILogger
    {
        void GenerateLog(Exception ex);
        void GenerateInfo(string mensaje);
        void GenerateLogPerformance(string mensaje);
        void GenerateFatalLog(string message, Exception ex);
    }
}
