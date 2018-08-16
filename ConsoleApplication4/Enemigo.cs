using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Enemigo
    {
        public string Nombre { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }

        private int _Puntos;
        public int Puntos
        {
            get { return _Puntos; }
            set
            {
                if (value <= 100)
                {
                    _Puntos = value;
                }

                else
                {
                    Console.WriteLine("Puntos excesivos");
                }
            }
        }

        private int _Disparos;
        public int Disparos
        {
            get { return _Disparos; }
            set
            {
                if (value >= 10)
                {
                    
                    Console.WriteLine("El enemigo ha muerto, ASESINO. Has ganado " + Puntos + " Puntos");
                }

                else if (value >= 5)
                {
                    Puntos = Puntos - 20;
                    Console.WriteLine("Daño suficiente, El enemigo ha sido noqueado. Has Ganado " + Puntos + " Puntos");
                }
                else
                {
                    _Disparos = value;
                    Console.WriteLine("Daño Insuficiente, Has sido vencido");
                }
            }
        }

        private int _Explosion;
        public int Explosion
        {
            get { return _Explosion; }
            set
            {
                if (value >= 3)
                {
                    Console.WriteLine("Has vencido Al Mounstruo! Has ganado " + Puntos + " Puntos");
                }

                else
                {
                    _Explosion = value;
                    Console.WriteLine("Daño Insuficiente, Suerte a la proxima.");
                }
            }
        }




    

}
}
