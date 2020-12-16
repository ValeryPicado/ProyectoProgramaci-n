using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.UI.ViewModel
{
    public class ProductoViewModel
    {
        public int Id { get; set; }

        public string NombreProducto { get; set; }

        public string TipoProducto { get; set; }

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public IFormFile ProfileImage { get; set; }
    }
}
