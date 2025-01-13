using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class ProductoModel
    {
        public string Codigo { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Descripcion { get; set; } = string.Empty;
        public string Categoria { get; set; } = "Selecciona una...";
        public string Tipo { get; set; } = string.Empty;
        public bool BajoConsumo { get; set; } = false;
        public decimal Precio { get; set; } = decimal.Zero;
        public int Stock { get; set; } = 0;
    }
}
