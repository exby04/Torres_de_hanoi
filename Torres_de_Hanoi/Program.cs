using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila INI = new Pila();
            Pila AUX = new Pila();
            Pila FIN = new Pila();
            Hanoi juegoHanoi = new Hanoi();

            Console.WriteLine("Bienvenido al programa de las torres de Hanoi de Alejandro y Adrian.\n");
            Console.WriteLine("Para empezar, cuantos discos quieres que tenga las torres de Hanoi:");

            string num_disco = Console.ReadLine();

            for (int i = int.Parse(num_disco); i >= 1; i--)
            {
                INI.push(new Disco(i));
            }

            Console.WriteLine("\nMuy bien. Ahora dime que clase de metodo quieres utilizar para resolver las torres, Recursivo o Iterativo (Indicalo con la R para recursivo y I para iterativo):");
            char metodo = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (metodo)
            {
                case 'r':
                    Console.WriteLine("\nPerfecto, pues empezamos!!!\n");
                    Console.WriteLine("Has escogido el metodo recursivo.\n");
                    int movimientosRecursivo = juegoHanoi.recursivo(int.Parse(num_disco), INI, FIN, AUX);
                    Console.WriteLine("Resuelto en " + movimientosRecursivo + " Movimientos");
                    break;
                case 'i':
                    Console.WriteLine("\nPerfecto, pues empezamos!!!\n");
                    Console.WriteLine("Has escogido el metodo iterativo.\n");
                    int movimientosIterativo = juegoHanoi.iterativo(int.Parse(num_disco), INI, FIN, AUX);
                    Console.WriteLine("Resuelto en " + movimientosIterativo + " Movimientos");
                    break;
                default:
                    Console.WriteLine("\nNo has seleccionado ningun tipo de metodo.");
                    break;
            }

            // Esperar a que el usuario presione una tecla antes de cerrar
            Console.WriteLine("\nPulse cualquier tecla para salir ...");
            Console.ReadKey();
        }
    }
}