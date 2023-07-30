using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductosEntity
    {
        public int ID_Producto { get; set; }
        public Guid Codigo { get; set; }
        public string Composicion { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public string TelaBase { get; set; }
        public string TelaCombinacion { get; set; }
        public string BolsilloInterior { get; set; }
        public string CinturaInterior { get; set; }
        public string Collareta { get; set; }
        public string Lazo { get; set; }
        public string Vivo { get; set; }
        public string Forreria { get; set; }
        public string ImagenPrenda { get; set; }
        public string TallePrenda { get; set; }
        public string TipoPrenda { get; set; }
        public int Stock { get; set; }
    }
}
