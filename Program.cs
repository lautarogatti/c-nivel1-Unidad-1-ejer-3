using System;

namespace calculadoraDeTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, v, t;
            Console.WriteLine("Bienvenido a la calculadora de tiempo de viajes, por favor, inserte la cantidad de kilometros a recorrer:");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese la velocidad elegida para el viaje:");
            v = int.Parse(Console.ReadLine());
            t = d / v;
            Console.WriteLine("El tiempo aproximado de el viaje es de: " + t + " horas");
            Console.WriteLine("Gracias por utilizar la calculadora de tiempo de viajes");
        }
    }
}
