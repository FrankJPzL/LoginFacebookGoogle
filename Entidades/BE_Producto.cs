using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BE_Producto
    {
        public int cod_Producto { get; set; }        
        public String Des_Producto { get; set; }
        public Int32 stock { get; set; }
        public decimal precio { get; set; }
        public String imagen { get; set; }
       public  BE_Marca Marca { get; set; }

    }
}
