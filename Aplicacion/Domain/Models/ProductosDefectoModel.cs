using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductoDefectoModel : GenericEntity
    {
        public int ID_ProductoDefecto { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public string Motivo { get; set; }
        public Guid CreateUser { get; set; }

        public virtual ProductosModel Producto { get; set; }
    }
}
