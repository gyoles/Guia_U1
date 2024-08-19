using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoObjetos
{
    public class Suelto : Producto
    {
        public int Medida { get; set; }

        public override float CalcularPrecio()
        {
            return Medida * Precio;
        }
    }
}
