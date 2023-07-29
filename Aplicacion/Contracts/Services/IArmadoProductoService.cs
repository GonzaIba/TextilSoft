using Contracts.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IArmadoProductoService
    {
        public List<TelaBaseModel> ObtenerTelasBase();

        public List<TelaCombinacionModel> ObtenerTelaCombinaciones();

        public List<BolsilloInteriorModel> ObtenerBolsillosInteriores();

        public List<CinturaInteriorModel> ObtenerCinturasInteriores();

        public List<CollaretaModel> ObtenerCollaretas();

        public List<LazoModel> ObtenerLazos();

        public List<VivoModel> ObtenerVivos();

        public List<ForreriaModel> ObtenerForrerias();

    }
}
