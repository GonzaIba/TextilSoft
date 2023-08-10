using Contracts.Controllers;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Factory;
using UI.TextilSoft.MainForm;

namespace UI.TextilSoft.SubForms.Informes_Reportes.Reporte_Ventas
{
    public partial class FmReporteVentas : Form
    {
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        public FmReporteVentas(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
        }

        private void fmCboxTipoArmado_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoOperacionEnum = (ReporteTipoOperacionEnum)Enum.Parse(typeof(ReporteTipoOperacionEnum),Enum.GetNames(typeof(ReporteTipoOperacionEnum)).ToList().Where(x => x == fmCboxTipoOperacion.SelectedItem.ToString().Replace(" ","")).FirstOrDefault().ToString());
            GrillaReportes.DataSource = _factory.UseNew<IReportesController>().ObtenerReportesConFiltro(tipoOperacionEnum,fmDateDesde.Value,fmDateHasta.Value);
        }

        private void FmReporteVentas_Load(object sender, EventArgs e)
        {
            fmCboxTipoOperacion.SelectedIndex = -1;
            //GrillaReportes.DataSource = _factory.UseNew<IReportesController>().ObtenerReportesConFiltro();
        }
    }
}
