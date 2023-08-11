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
        /// <summary>
        /// Devuelve una lista de reportes según el Enum y entre fechas.
        /// </summary>
        /// <param name="tipoOperacionEnum"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public dynamic ObtenerReportesConFiltro(ReporteTipoOperacionEnum tipoOperacionEnum, DateTime from, DateTime to);
    }
}
