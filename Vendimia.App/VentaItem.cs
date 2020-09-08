using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendimia.App
{
    public class VentaItem
    {
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }
    }
}
