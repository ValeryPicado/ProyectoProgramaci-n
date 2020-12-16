using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.UI.Models
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }

        public string CodigoFactura { get; set; }

        public DateTime Fecha { get; set; }

        public int IdProducto { get; set; }

        public string IdUsuario { get; set; }

        public string NombreProductoF { get; set; }

        public string TipoProductoF { get; set; }

        public decimal PrecioF { get; set; }

        public int CantidadF { get; set; }

        public decimal TotalF { get; set; }

    }
}
