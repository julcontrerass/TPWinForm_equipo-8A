using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int id { get; set; }
        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int marca { get; set; }
        public int categoria { get; set; }
        public decimal precio { get; set; }
    }
}
