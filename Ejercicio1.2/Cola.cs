using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._2
{
    public class Cola : IColleccion
    {
        private List<object> elementos;

        public Cola()
        {
            elementos = new List<object>();
        }

        public bool estaVacia()
        {
            return elementos.Count == 0;
        }

        public bool aniadir(object elemento)
        {
            elementos.Add(elemento);
            return true;
        }

        public object extraer()
        {
            if (estaVacia())
            {
                return "La Cola está vacía";
            }
            else
            {
                object elemento = elementos[0];
                elementos.RemoveAt(0);
                return elemento;
            }
        }

        public object primero()
        {
            if (estaVacia())
            {
                return "La Cola está vacía";
            }
            else
            {
                return elementos[0];
            }
        }
    }
}
