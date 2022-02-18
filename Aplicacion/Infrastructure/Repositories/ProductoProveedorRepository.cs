using Contracts.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductoProveedorRepository : GenericRepository<ProductosProveedorModel>, IProductosProveedorRepository
    {
        public ProductoProveedorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
