using Contracts.Repositories;
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
    public interface IArmadoProductoService
    {
        /// <summary>
        /// Se obtienen las tela base
        /// </summary>
        /// <returns></returns>
        public List<TelaBaseModel> ObtenerTelasBase();

        /// <summary>
        /// Se obtienen las telas combinaciones
        /// </summary>
        /// <returns></returns>
        public List<TelaCombinacionModel> ObtenerTelaCombinaciones();

        /// <summary>
        /// Se obtienen los bolsillos interiores
        /// </summary>
        /// <returns></returns>
        public List<BolsilloInteriorModel> ObtenerBolsillosInteriores();

        /// <summary>
        /// Se obtienen todas las cinturas interiores
        /// </summary>
        /// <returns></returns>
        public List<CinturaInteriorModel> ObtenerCinturasInteriores();

        /// <summary>
        /// Se obtienen todas las collaretas
        /// </summary>
        /// <returns></returns>
        public List<CollaretaModel> ObtenerCollaretas();

        /// <summary>
        /// Se obtienen todos los lazos
        /// </summary>
        /// <returns></returns>
        public List<LazoModel> ObtenerLazos();

        /// <summary>
        /// Se obtienen todos los vivos
        /// </summary>
        /// <returns></returns>
        public List<VivoModel> ObtenerVivos();

        /// <summary>
        /// Se obtienen todas las forrerias
        /// </summary>
        /// <returns></returns>
        public List<ForreriaModel> ObtenerForrerias();

        /// <summary>
        /// Se obtienen todos los tipos de prenda
        /// </summary>
        /// <returns></returns>
        public List<TipoPrendaModel> ObtenerLosTiposDePrendas();

        /// <summary>
        /// Devuelve un objeto producto a través de un codigo de armado
        /// </summary>
        /// <param name="aBMProductoEntity"></param>
        /// <returns></returns>
        public ProductosModel ObtenerCodigosDeArmados(ABMProductoEntity aBMProductoEntity);

        /// <summary>
        /// Devuelve un tipo armado de producto y el num
        /// </summary>
        /// <param name="armadoProductoEnum"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        (dynamic, ArmadoProductoEnum) ObtenerArmadoPorCodigo(ArmadoProductoEnum armadoProductoEnum, string code);
    }
}
