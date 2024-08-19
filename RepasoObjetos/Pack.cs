﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoObjetos
{
    public class Pack : Producto
    {
        public int Cantidad { get; set; }

        public override float CalcularPrecio()
        {
            return Cantidad * Precio;
        }
    }
}
