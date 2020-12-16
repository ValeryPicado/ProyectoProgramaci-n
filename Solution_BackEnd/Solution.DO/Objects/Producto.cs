using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public class Producto
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public string NombreProducto { get; set; }

        [Required]
        public string TipoProducto { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public string ProfileImage { get; set; }
    }
}
