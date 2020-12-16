using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public class Carrito
    {
        [Key]
        public int? IdCarrito { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Required]
        public string IdUsuario { get; set; }

        [Required]
        public string NombreProductoC { get; set; }

        [Required]
        public string TipoProductoC { get; set; }

        [Required]
        public decimal PrecioC { get; set; }

        [Required]
        public int CantidadC { get; set; }

        [Required]
        public decimal TotalC { get; set; }
    }
}
