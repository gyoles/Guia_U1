using Ejercicio1._1;

class Program
{
    static void Main()
    {
        Pila pila = new Pila(5);

        pila.aniadir(1);
        pila.aniadir(2);
        pila.aniadir(3);

        Console.WriteLine(pila.primero()); // 3
        Console.WriteLine(pila.extraer()); // 3
        Console.WriteLine(pila.primero()); // 2

        Console.WriteLine(pila.estaVacia()); // False

        pila.extraer();
        pila.extraer();

        Console.WriteLine(pila.estaVacia()); // True
    }
}

