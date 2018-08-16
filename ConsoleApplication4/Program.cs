using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccion;

            Enemigo enemigouno = new Enemigo();

            Console.WriteLine("Nombre del Jugador: ");
            enemigouno.Nombre = Console.ReadLine();

            enemigouno.PosicionX = 10;
            enemigouno.PosicionY = 0;
            enemigouno.Puntos = 50;

            Console.WriteLine("Posicion en X: " + enemigouno.PosicionX);
            Console.WriteLine("Posicion en Y: " + enemigouno.PosicionY);

            Console.WriteLine(" Elija 1 para Disparar o 2 para elegir");
            eleccion = int.Parse(Console.ReadLine());

            if (eleccion == 1)
            {
                Console.WriteLine("¿Cuantos Disparos realiza? ");
                enemigouno.Disparos = int.Parse(Console.ReadLine());
                Console.ReadLine();


            }
            else if (eleccion == 2)
            {
                Console.WriteLine("¿Cuantas Bombas usaras?");
                enemigouno.Explosion = int.Parse(Console.ReadLine());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Insertaste una opción Incorrecta");
                Console.ReadLine();
            }
        }
    }
}
