using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IReportesController
    {
        public dynamic ObtenerReportesConFiltro(ReporteTipoOperacionEnum tipoOperacionEnum, DateTime from, DateTime to);
    }
}
