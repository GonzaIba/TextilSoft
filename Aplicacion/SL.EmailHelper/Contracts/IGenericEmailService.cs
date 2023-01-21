using SL.Helper.ResultClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.EmailHelper.Contracts
{
    public interface IGenericEmailService
    {
        void SendEmail(Message message);
        IGenericResult<string> SendEmailAsync(Message message);
    }
}
