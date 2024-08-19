using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1
{
    public class Pila : IColleccion
    {
        private object[] elementos;
        private int contador;

        public Pila(int tam)
        {
            elementos = new object[tam];
            contador = 0;
        }
        
        public bool estaVacia()
        {
            return contador == 0;
        }

        public object extraer()
        {
            if (!estaVacia())
            {
                contador--;
                object elemento = elementos[contador];
                elementos[contador] = null;
                return elemento;
            }
            else
            {
                return "La pila está vacía";
            }
        }

        public object primero()
        {
            if (!estaVacia())
            {
                return elementos[contador - 1];
            }
            else
            {
                return "La pila está vacía";
            }
        }

        public bool aniadir(object elemento)
        {
            if(contador >= elementos.Length)
            {
                return false;
            }
            else
            {
                elementos[contador] = elemento;
                contador++;
                return true;
            }
        }
    }
}
