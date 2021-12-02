using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProveedoresService : GenericService<ProveedoresModel>, IProveedoresService
    {
        private readonly IMapper _mapper;
        public ProveedoresService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IProveedoresRepository>())
        {
            _mapper = mapper;
        }
        public void CrearFactura(ProveedoresModel proveedoresModel)
        {
            try
            {

                //var result = MapperHelper.GetMapper().Map<ProveedoresEntity, ProveedoresModel>(proveedoresEntity);

                var proveedorrepositorio = _unitOfWork.GetRepository<IClientesRepository>();


                //_unitOfWork.Save();
                ////var _clientesRepository = _unitOfWork.GetRepository<IClientesRepository>().Get(x=>x.DNI == 10,
                //                                                                               includeProperties: "",
                //                                                                               ignoreQueryFilters: true,
                //                                                                               tracking: true
                //                                                                                );

                //var objeto = _clientesRepository.Get(
                //    relation => relation.DNI == 1010
                //    );


                //var objeto2 = _clientesRepository.Table.AsEnumerable<>
                //var objeto3 = _clientesRepository.Table.I(
                //    n => n.Apellido == "uowddd");

                var resultadoo = Get(x => x.DNI == 1006, includeProperties: "ProductoProveedor").ToList().First().LugarEmpresa;

                //var resultadoo = _clientesRepository.Get(x => x.DNI == 10).ToList().First().Nombre;
                //_clientesRepository.Insert(clientes);
                //var test = proveedorrepositorio.Get(e => e.Mail == "jejeje");
                //result.ID_Proveedor = proveedoresEntity.DNI;
                //var test2 = clientesservice.Get(e => e.ID_Cliente == 123);

                //_repository.Insert(proveedoresEntity);

                

                _unitOfWork.Save();
                //ProveedoresRepository.GetInstance.Insert(proveedoresEntity);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
            }
            catch(InvalidOperationException)
            {
                throw;
            }
        }

        public void Test(IEnumerable<ProveedoresModel> listita)
        {
            var resultado = _mapper.Map<IEnumerable<ProveedoresEntity>>(listita);
        }       
    }
}
