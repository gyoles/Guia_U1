using Ejercicio1._2;

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


        Cola cola = new Cola();

        cola.aniadir(1);
        cola.aniadir(2);
        cola.aniadir(3);

        Console.WriteLine(cola.primero()); // 1
        Console.WriteLine(cola.extraer()); // 1
        Console.WriteLine(cola.primero()); // 2

        Console.WriteLine(cola.estaVacia()); // False

        cola.extraer();
        cola.extraer();

        Console.WriteLine(cola.estaVacia()); // True
    }
}
