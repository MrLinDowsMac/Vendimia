using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendimia.App.Models
{
    class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }

    }
}
