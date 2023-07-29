using Contracts.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TelaCombinacionRepository : GenericRepository<TelaCombinacionModel>, ITelaCombinacionRepository
    {
        public TelaCombinacionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
