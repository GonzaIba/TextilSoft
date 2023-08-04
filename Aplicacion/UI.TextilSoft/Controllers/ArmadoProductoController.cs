using AutoMapper;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities.ArmadoProductos;
using Domain.Enum;
using Domain.Models;
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
        private readonly ITransferService _transferService;
        private readonly IMapper _mapper;
        public ArmadoProductoController(IArmadoProductoService armadoProductoService,ITransferService transferService, IMapper mapper)
        {
            _armadoProductoService = armadoProductoService;
            _transferService = transferService;
            _mapper = mapper;
        }

        public dynamic ObtenerArmadoPorCodigo(ArmadoProductoEnum armadoProductoEnum, string code)
        {
            var (dynamicREsult, TipoEnum) = _armadoProductoService.ObtenerArmadoPorCodigo(armadoProductoEnum, code);
            switch (TipoEnum)
            {
                case ArmadoProductoEnum.TelaBase:
                    return _mapper.Map<TelaBaseEntity>(dynamicREsult);
                case ArmadoProductoEnum.TelaCombinacion:
                    return _mapper.Map<TelaCombinacionEntity>(dynamicREsult);
                case ArmadoProductoEnum.BolsilloInterior:
                    return _mapper.Map<BolsilloInteriorEntity>(dynamicREsult);
                case ArmadoProductoEnum.CinturaInterior:
                    return _mapper.Map<CinturaInteriorEntity>(dynamicREsult);
                case ArmadoProductoEnum.Collareta:
                    return _mapper.Map<CollaretaEntity>(dynamicREsult);
                case ArmadoProductoEnum.Lazo:
                    return _mapper.Map<LazoEntity>(dynamicREsult);
                case ArmadoProductoEnum.Vivo:
                    return _mapper.Map<VivoEntity>(dynamicREsult);
                case ArmadoProductoEnum.Forreria:
                    return _mapper.Map<ForreriaEntity>(dynamicREsult);
                case ArmadoProductoEnum.TipoPrenda:
                    return _mapper.Map<TipoPrendaEntity>(dynamicREsult);
                default:
                    return null;
            }
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

        public List<TransferEntity> ObtenerTransfer(string codigo = "")
        {
            var ListaTransferModel = new List<TransferModel>();
            if (codigo == "")
                ListaTransferModel = _transferService.Get().ToList();
            else
                ListaTransferModel = _transferService.Get(x => x.Codigo == codigo).ToList();
            
            var ListaTransfer = _mapper.Map<List<TransferEntity>>(ListaTransferModel);
            return ListaTransfer;
        }

        public void CrearTransfer(TransferEntity transfer)
        {
            var transferModel = _mapper.Map<TransferModel>(transfer);
            _transferService.Crear(transferModel);
        }
    }
}
