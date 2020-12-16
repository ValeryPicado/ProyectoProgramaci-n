using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.UI.ViewModel
{
    public class CarritoViewModel
    {
        public int IdCarrito { get; set; }

        public int IdProducto { get; set; }

        public string IdUsuario { get; set; }

        public string NombreProductoC { get; set; }

        public string TipoProductoC { get; set; }

        public decimal PrecioC { get; set; }

        public int CantidadC { get; set; }

        public decimal TotalC { get; set; }
    }
}
