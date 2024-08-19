// See https://aka.ms/new-console-template for more information
using RepasoObjetos;


var suelto = new Suelto(); //el "var" hace que el compilador infiera que el tipo de la variable es lo que tiene a la derecha (es como usar "Object" pero sin castear)
var pack = new Pack();

pack.Precio = 1000;
pack.Cantidad = 2;

suelto.Precio = 100;
suelto.Medida = 5;


Producto[] array = { suelto, pack };
float total = 0;

foreach (Producto x in array)
{
    total += x.CalcularPrecio();
}

Console.WriteLine("TOTAL: $ " + total);