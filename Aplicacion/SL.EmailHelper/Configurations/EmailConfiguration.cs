﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SL.EmailHelper.Configurations
{
    public class EmailConfiguration
    {
        public string Type { get; set; }
        public EmailSendGridConfiguration EmailSendGridConfiguration { get; set; }
        public EmailSMTPConfiguration EmailSMTPConfiguration { get; set; }
        public bool TestEnabled { get; set; }
    }
}
