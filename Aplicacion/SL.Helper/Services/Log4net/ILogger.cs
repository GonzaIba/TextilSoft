﻿using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Services.Log4net
{
    public interface ILogger
    {
        void GenerateLogError(string message, Exception ex);
        void GenerateInfo(string mensaje);
        void GenerateLogPerformance(string mensaje);
        void GenerateFatalLog(string message, Exception ex);

        void SetUser(Usuario usuario);
        void Logout();
    }
}
