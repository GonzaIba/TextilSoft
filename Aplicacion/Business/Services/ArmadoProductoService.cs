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
        private readonly IBolsilloInteriorRepository _bolsilloInteriorRepository;
        private readonly ICinturaInteriorRepository _cinturaInteriorRepository;
        private readonly ILazoRepository _lazoRepository;
        private readonly IVivoRepository _vivoRepository;
        public ArmadoProductoService(
            ITelaBaseRepository telaBaseRepository,
            IBolsilloInteriorRepository bolsilloInteriorRepository,
            ICinturaInteriorRepository cinturaInteriorRepository,
            ILazoRepository lazoRepository,
            IVivoRepository vivoRepository
            )
        {
            _telaBaseRepository = telaBaseRepository;
            _bolsilloInteriorRepository = bolsilloInteriorRepository;
            _cinturaInteriorRepository = cinturaInteriorRepository;
            _lazoRepository = lazoRepository;
            _vivoRepository = vivoRepository;
        }

        public List<TelaBaseModel> ObtenerTelasBase()
        {
            return _telaBaseRepository.Get().ToList();
        }

        public List<BolsilloInteriorModel> ObtenerBolsillosInteriores()
        {
            return _bolsilloInteriorRepository.Get().ToList();
        }

        public List<CinturaInteriorModel> ObtenerCinturasInteriores()
        {
            return _cinturaInteriorRepository.Get().ToList();
        }

        public List<LazoModel> ObtenerLazos()
        {
            return _lazoRepository.Get().ToList();
        }

        public List<VivoModel> ObtenerVivos()
        {
            return _vivoRepository.Get().ToList();
        }
    }
}
