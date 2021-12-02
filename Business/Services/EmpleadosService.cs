using AutoMapper;
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
    public class EmpleadosService : GenericService<EmpleadosModel>, IEmpleadosService
    {
        private readonly IMapper _mapper;
        public EmpleadosService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IEmpleadosRepository>())
        {
            _mapper = mapper;
        }

    }
}
