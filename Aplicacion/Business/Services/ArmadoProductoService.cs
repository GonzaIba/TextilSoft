using Contracts.Repositories;
using Contracts.Services;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ArmadoProductoService :  IArmadoProductoService
    {
        private readonly ITelaBaseRepository _telaBaseRepository;
        private readonly ITelaCombinacionRepository _telaCombinacionRepository;
        private readonly IBolsilloInteriorRepository _bolsilloInteriorRepository;
        private readonly ICinturaInteriorRepository _cinturaInteriorRepository;
        private readonly ICollaretaRepository _collaretaRepository;
        private readonly ILazoRepository _lazoRepository;
        private readonly IVivoRepository _vivoRepository;
        private readonly IForreriaRepository _forreriaRepository;
        public ArmadoProductoService(
            ITelaBaseRepository telaBaseRepository,
            ITelaCombinacionRepository telaCombinacionRepository,
            IBolsilloInteriorRepository bolsilloInteriorRepository,
            ICinturaInteriorRepository cinturaInteriorRepository,
            ICollaretaRepository collaretaRepository,
            ILazoRepository lazoRepository,
            IVivoRepository vivoRepository,
            IForreriaRepository forreriaRepository
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
        #endregion
    }
}
