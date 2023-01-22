﻿using SL.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmCompanyConfig : Form
    {
        private readonly ICompanyController _companyController;
        public FmCompanyConfig(ICompanyController companyController)
        {
            InitializeComponent();
            _companyController = companyController;
        }
    }
}
