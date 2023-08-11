using Domain.Entities;
using Domain.Enum;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IVentasService : IGenericService<VentasModel>
    {
        /// <summary>
        /// Se registra una venta
        /// </summary>
        /// <param name="ventasModel"></param>
        public void RegistrarVenta(VentasModel ventasModel);

        /// <summary>
        /// Devuelve las ventas realizadas entre fechas
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public VentasModel ObtenerCapitalEntreFechas(DateTime from, DateTime to);

        /// <summary>
        /// Se obtienen las prendas mas vendidas entre fechas
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public List<VentasModel> ObtenerPrendasMasVendidas (DateTime from, DateTime to);

        /// <summary>
        /// Se obtienen las prendas menos vendidas entre fechas
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public List<VentasModel> ObtenerPrendasMenosVendidas(DateTime from, DateTime to);

        /// <summary>
        /// Se obtienen las prendas mas defectuosas entre fechas
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public List<ProductoDefectoModel> ObtenerPrendasMasDefectuosas(DateTime from, DateTime to);
    }
}
