using AutoMapper;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities.ArmadoProductos;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace UI.TextilSoft.Controllers
{
    public class ArmadoProductoController : IArmadoProductoController
    {
        private readonly IArmadoProductoService _armadoProductoService;
        private readonly IMapper _mapper;
        public ArmadoProductoController(IArmadoProductoService armadoProductoService, IMapper mapper)
        {
            _armadoProductoService = armadoProductoService;
            _mapper = mapper;
        }

        public dynamic ObtenerArmadoProductoPorTipo(ArmadoProductoEnum armadoProductoEnum) =>
            armadoProductoEnum switch
            {
                ArmadoProductoEnum.TelaBase =>  _mapper.Map<List<TelaBaseEntity>>(_armadoProductoService.ObtenerTelasBase()),
                ArmadoProductoEnum.TelaCombinacion => _mapper.Map<List<TelaCombinacionEntity>>(_armadoProductoService.ObtenerTelaCombinaciones()),
                ArmadoProductoEnum.BolsilloInterior => _mapper.Map<List<BolsilloInteriorEntity>>(_armadoProductoService.ObtenerBolsillosInteriores()),
                ArmadoProductoEnum.CinturaInterior => _mapper.Map<List<CinturaInteriorEntity>>(_armadoProductoService.ObtenerCinturasInteriores()),
                ArmadoProductoEnum.Collareta => _mapper.Map<List<CollaretaEntity>>(_armadoProductoService.ObtenerCollaretas()),
                ArmadoProductoEnum.Lazo => _mapper.Map<List<LazoEntity>>(_armadoProductoService.ObtenerLazos()),
                ArmadoProductoEnum.Vivo => _mapper.Map<List<VivoEntity>>(_armadoProductoService.ObtenerVivos()),
                ArmadoProductoEnum.Forreria => _mapper.Map<List<ForreriaEntity>>(_armadoProductoService.ObtenerForrerias()),
                ArmadoProductoEnum.TipoPrenda => _mapper.Map<List<TipoPrendaEntity>>(_armadoProductoService.ObtenerLosTiposDePrendas()),
                _ => null,
            };
    }
}
