﻿using System;
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
        public Color Color { get; set; }
        public string Composicion { get; set; }
        public string Estampa { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public string Tejido { get; set; }
        public string TallePrenda { get; set; }
        public string TipoProducto { get; set; }
        public int Stock { get; set; }
    }
}
