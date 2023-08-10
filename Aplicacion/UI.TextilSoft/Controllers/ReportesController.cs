using AutoMapper;
using Business.Services;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using Domain.Entities.ArmadoProductos;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class ReportesController : IReportesController
    {
        private readonly IVentasService _ventasService;
        private readonly IEmpleadosService _empleadosService;
        private readonly IMapper _mapper;
        public ReportesController(IVentasService ventasService, IMapper mapper, IEmpleadosService empleadosService)
        {
            _ventasService = ventasService;
            _mapper = mapper;
            _empleadosService = empleadosService;
        }
        public dynamic ObtenerReportesConFiltro(ReporteTipoOperacionEnum tipoOperacionEnum, DateTime from, DateTime to)
        {
            switch (tipoOperacionEnum)
            {
                case ReporteTipoOperacionEnum.PrendaMasVendida:
                    var listaPrendasMasVendidas = _ventasService.ObtenerPrendasMasVendidas(from, to);
                    var PrendasMasVendidas = listaPrendasMasVendidas.GroupBy(x => x.Producto.TipoPrenda)
                    .Select(g => new ReportePrendasEntity
                    {
                        CodigoPrenda = g.Select(x => x.Producto.TipoPrenda).FirstOrDefault().ID_TipoPrenda.ToString(),
                        TipoPrenda = g.Select(x => x.Producto.TipoPrenda).FirstOrDefault().TipoPrenda,
                        Cantidad = g.Sum(x => x.Cantidad)
                    })
                    .OrderByDescending(x => x.Cantidad)
                    .ToList();
                    return PrendasMasVendidas;
                case ReporteTipoOperacionEnum.PrendaMenosVendida:
                    var listaPrendasMenosVendidas = _ventasService.ObtenerPrendasMenosVendidas(from, to);
                    var PrendasMenosVendidas = listaPrendasMenosVendidas.GroupBy(x => x.Producto.TipoPrenda)
                    .Select(g => new ReportePrendasEntity
                    {
                        CodigoPrenda = g.Select(x => x.Producto.TipoPrenda).FirstOrDefault().ID_TipoPrenda.ToString(),
                        TipoPrenda = g.Select(x => x.Producto.TipoPrenda).FirstOrDefault().TipoPrenda,
                        Cantidad = g.Sum(x => x.Cantidad)
                    })
                    .OrderBy(x => x.Cantidad)
                    .ToList();
                    return PrendasMenosVendidas;
                case ReporteTipoOperacionEnum.PrendasMasDefectuosa:
                    var listaPrendasMasDefectuosas = _ventasService.ObtenerPrendasMasDefectuosas(from, to);
                    var PrendasMasDefecuosas = listaPrendasMasDefectuosas.GroupBy(x => x.Producto.TipoPrenda)
                    .Select(g => new ReportePrendasEntity
                    {
                        CodigoPrenda = g.Select(x => x.Producto.TipoPrenda).FirstOrDefault().ID_TipoPrenda.ToString(),
                        TipoPrenda = g.Select(x => x.Producto.TipoPrenda).FirstOrDefault().TipoPrenda,
                        Cantidad = g.Sum(x => x.Cantidad)
                    })
                    .OrderByDescending(x => x.Cantidad)
                    .ToList();
                    return null;
                case ReporteTipoOperacionEnum.TotalCapitalRecibido:
                    var listCapitalEntreFechas = _ventasService.ObtenerCapitalEntreFechas(from, to);
                    var Empleado = _empleadosService.GetById(listCapitalEntreFechas.CreateUser);
                    ReporteCapitalEntity capitalEntity = new();
                    capitalEntity.TotalRecaudado = listCapitalEntreFechas.TotalCapitalRecibido;
                    capitalEntity.NombreEmpleado = Empleado.Nombre;
                    capitalEntity.DNIEmpleado = Empleado.DNI.ToString();
                    return capitalEntity;
                default:
                    return null;
            }
        }
    }
}
