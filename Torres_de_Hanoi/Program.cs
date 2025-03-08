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
            Console.WriteLine("Bienvenido al programa de las torres de Hanoi de Alex y Adrian.\n");
            Console.WriteLine("Para empezar, cuantos discos quieres que tenga las torres de Hanoi:");
            ConsoleKeyInfo num_disco = Console.ReadKey();
            Console.WriteLine("\nMuy bien. Ahora dime que clase de metodo quieres utilizar para resolver las torres, Recursivo o Iterativo(Indicalo con la la R para recursivo y I para iterativo):");
            char metodo = char.ToLower(Console.ReadKey().KeyChar);
            switch (metodo)
            {
                case 'r':
                    Console.WriteLine("\nPerfecto, pues empezamos!!!\n");
                    Console.WriteLine("Has escogido el metodo recursivo.\n");
                    break;
                case 'i':
                    Console.WriteLine("\nPerfecto, pues empezamos!!!\n");
                    Console.WriteLine("Has escogido el metodo iterativo.\n");
                    break;
                default:
                    Console.WriteLine("\nNo has seleccionado ningun tipo de metodo.");
                    break;
            }
            
        }
    }
}
