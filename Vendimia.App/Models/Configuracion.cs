using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendimia.App.Models
{
    
    class Configuracion
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        public bool PrimerConfiguracion { get; set; }
//        [Column(TypeName = "decimal(6,4)")]
        //[Required]
        public decimal TasaFinanciamiento {get;set;}
 //       [Column(TypeName = "decimal(6,4)")]
        //[Required]
        public decimal Enganche { get; set; }
        //[Required]
        public int PlazoMaximo { get; set; }
    }
}
