using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendimia.App.Models
{
    class Venta
    {
        [Key]
        public int FolioVta { get; set; }
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente {get; set;}
        //public string NombreCte { get; set; }
        public DateTime Fecha { get; set; }
        public string Estatus { get; set; }
        
    }
}
