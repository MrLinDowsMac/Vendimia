using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendimia.App.Models
{
    class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public string NombreCte { get; set; }
        [Required]
        public string ApellidoPaterno { get; set; }
        [Required]
        public string ApellidoMaterno { get; set; }
        [Required]
        public string RFC { get; set; }

        [NotMapped]
        public string NombreCompleto => $"{NombreCte} {ApellidoPaterno} {ApellidoMaterno}";
    }
}
