using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._2
{
    public interface IColleccion
    {
        bool estaVacia();
        object extraer();
        object primero();
        bool aniadir(object elemento);
    }
}
