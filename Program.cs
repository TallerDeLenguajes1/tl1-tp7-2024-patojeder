using System.ComponentModel;
using EspacioCalculadora;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("punto 1)");
int eleccion, seguir, numero;
string num, ele;
Calculadora nuevaCalculadora = new Calculadora();
do
{
    Console.WriteLine("ingrese la operacion que quiere realizar: ");
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Multiplicar");    
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("0 para salir.");
    ele = Console.ReadLine();
    int.TryParse(ele, out eleccion);

switch (eleccion)
{
    case 1:
        Console.WriteLine("ingrese el numero a sumar");
        num = Console.ReadLine();
        int.TryParse(num, out numero);
        nuevaCalculadora.Sumar(numero);
        Console.WriteLine("La suma es: ");
        Console.Write(+nuevaCalculadora.Resultado);
        break;
    case 2: 
        Console.WriteLine("ingrese el numero a RESTAR");
        num = Console.ReadLine();
        int.TryParse(num, out numero);
        nuevaCalculadora.Restar(numero);
        Console.WriteLine("La resta es: ");
        Console.Write(+nuevaCalculadora.Resultado);
        break;

    case 3: 
        Console.WriteLine("ingrese el numero por el que desea multiplicar");
        num = Console.ReadLine();
                int.TryParse(num, out numero);
        nuevaCalculadora.Multiplicar(numero);
        Console.WriteLine("La multiplicacion es: ");
        Console.Write(+nuevaCalculadora.Resultado);
        break;


    case 4:
        Console.WriteLine("ingrese el numero por el que desea dividir");
        num = Console.ReadLine();
        int.TryParse(num, out numero);
        nuevaCalculadora.Multiplicar(numero);
        Console.WriteLine("La division es: ");
        Console.Write(+nuevaCalculadora.Resultado);
        break;  


    default:
    break;
}

Console.WriteLine("Desea ralizar otra operacion: ");
seguir = Console.Read();

} while (seguir != 0);


