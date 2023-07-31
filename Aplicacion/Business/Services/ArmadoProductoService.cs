using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class ArmadoProductoService : IArmadoProductoService
    {
        private readonly ITelaBaseRepository _telaBaseRepository;
        private readonly ITelaCombinacionRepository _telaCombinacionRepository;
        private readonly IBolsilloInteriorRepository _bolsilloInteriorRepository;
        private readonly ICinturaInteriorRepository _cinturaInteriorRepository;
        private readonly ICollaretaRepository _collaretaRepository;
        private readonly ILazoRepository _lazoRepository;
        private readonly IVivoRepository _vivoRepository;
        private readonly IForreriaRepository _forreriaRepository;
        private readonly ITipoPrendaRepository _tipoPrendaRepository;
        private readonly IMapper _mapper;
        public ArmadoProductoService(
            ITelaBaseRepository telaBaseRepository,
            ITelaCombinacionRepository telaCombinacionRepository,
            IBolsilloInteriorRepository bolsilloInteriorRepository,
            ICinturaInteriorRepository cinturaInteriorRepository,
            ICollaretaRepository collaretaRepository,
            ILazoRepository lazoRepository,
            IVivoRepository vivoRepository,
            IForreriaRepository forreriaRepository,
            ITipoPrendaRepository tipoPrendaRepository,
            IMapper mapper
            )
        {
            _telaBaseRepository = telaBaseRepository;
            _telaCombinacionRepository = telaCombinacionRepository;
            _bolsilloInteriorRepository = bolsilloInteriorRepository;
            _cinturaInteriorRepository = cinturaInteriorRepository;
            _collaretaRepository = collaretaRepository;
            _lazoRepository = lazoRepository;
            _vivoRepository = vivoRepository;
            _forreriaRepository = forreriaRepository;
            _tipoPrendaRepository = tipoPrendaRepository;
            _mapper = mapper;
        }

        public ProductosModel ObtenerCodigosDeArmados(ABMProductoEntity abmProductoEntity)
        {
            var producto = _mapper.Map<ProductosModel>(abmProductoEntity);
            producto.ID_TelaBase = _telaBaseRepository.Get(x => x.Codigo == abmProductoEntity.CodigoTelaBase).FirstOrDefault().ID_TelaBase;
            producto.ID_TelaCombinacion = _telaCombinacionRepository.Get(x => x.Codigo == abmProductoEntity.CodigoTelaCombinacion).FirstOrDefault().ID_TelaCombinacion;
            producto.ID_BolsilloInterior = _bolsilloInteriorRepository.Get(x => x.Codigo == abmProductoEntity.CodigoBolsilloInterior).FirstOrDefault().ID_BolsilloInterior;
            producto.ID_CinturaInterior = _cinturaInteriorRepository.Get(x => x.Codigo == abmProductoEntity.CodigoCinturaInterior).FirstOrDefault().ID_CinturaInterior;
            producto.ID_Collareta = _collaretaRepository.Get(x => x.Codigo == abmProductoEntity.CodigoCollareta).FirstOrDefault().ID_Collareta;
            producto.ID_Lazo = _lazoRepository.Get(x => x.Codigo == abmProductoEntity.CodigoLazo).FirstOrDefault().ID_Lazo;
            producto.ID_Vivo = _vivoRepository.Get(x => x.Codigo == abmProductoEntity.CodigoVivo).FirstOrDefault().ID_Vivo;
            producto.ID_Forreria = _forreriaRepository.Get(x => x.Codigo == abmProductoEntity.CodigoForreria).FirstOrDefault().ID_Forreria;
            producto.ID_TipoPrenda = _tipoPrendaRepository.Get(x => x.TipoPrenda == abmProductoEntity.TipoDePrenda).FirstOrDefault().ID_TipoPrenda;
            return producto;
        }


        #region Getters
        public List<TelaBaseModel> ObtenerTelasBase()
        {
            return _telaBaseRepository.Get().ToList();
        }

        public List<TelaCombinacionModel> ObtenerTelaCombinaciones()
        {
            return _telaCombinacionRepository.Get().ToList();
        }

        public List<BolsilloInteriorModel> ObtenerBolsillosInteriores()
        {
            return _bolsilloInteriorRepository.Get().ToList();
        }

        public List<CinturaInteriorModel> ObtenerCinturasInteriores()
        {
            return _cinturaInteriorRepository.Get().ToList();
        }

        public List<CollaretaModel> ObtenerCollaretas()
        {
            return _collaretaRepository.Get().ToList();
        }

        public List<LazoModel> ObtenerLazos()
        {
            return _lazoRepository.Get().ToList();
        }

        public List<VivoModel> ObtenerVivos()
        {
            return _vivoRepository.Get().ToList();
        }

        public List<ForreriaModel> ObtenerForrerias()
        {
            return _forreriaRepository.Get().ToList();
        }

        public List<TipoPrendaModel> ObtenerLosTiposDePrendas()
        {
            return _tipoPrendaRepository.Get().ToList();
        }
        #endregion
    }
}
