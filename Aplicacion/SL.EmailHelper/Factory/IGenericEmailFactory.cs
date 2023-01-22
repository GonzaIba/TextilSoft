using SL.EmailHelper.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.EmailHelper.Factory
{
    public interface IGenericEmailFactory
    {
        IGenericEmailService GetDefault();

        IGenericEmailService Get(GenericEmailTypeEnum emailType);
    }
}
