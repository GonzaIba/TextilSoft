using SL.EmailHelper.Contracts;
using SL.Helper.ResultClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SL.EmailHelper.Services
{
    public abstract class GenericEmailService : IGenericEmailService
    {
        public abstract void SendEmail(Message message);
        public abstract IGenericResult<string> SendEmailAsync(Message message);
    }
}
