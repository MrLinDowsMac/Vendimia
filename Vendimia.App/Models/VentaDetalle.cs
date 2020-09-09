using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendimia.App.Models
{
    class VentaDetalle
    {
        [Key]
        public int IdVtaDetalle { get; set; }

        //public int FolioVta {get;set;}
        [ForeignKey("FolioVta")]
        public Venta Venta { get; set; }
        public int IdArticulo { get; set; }
        [ForeignKey("IdArticulo")]
        public Articulo Articulo { get; set; }
        [Required]
        public int Cantidad { get; set; }
        public double Importe { get; set; }
    }
}
