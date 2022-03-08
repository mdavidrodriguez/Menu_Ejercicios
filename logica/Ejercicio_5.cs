using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.logica
{
    internal class Ejercicio_5
    {
        public void run()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Bienvenido al juego adivina un numero");
                Console.WriteLine("Adivina el numero");
                Console.WriteLine("1 - Nivel Facil\n" +
                    "2 - Nivel Intermedio\n" +
                    "3 - Nivel Dificil\n" +
                    "4 - Salir");


                Console.WriteLine("Ingrese una opcion");
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        jugar(10);
                        break;
                    case 2:
                        jugar(7);
                        break;
                    case 3:
                        jugar(5);
                        break;
                    case 4:
                        Console.WriteLine("Cerrando Programa");
                        salir = true;
                        break;


                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

            }

        }
        static void jugar(int vidas)
        {
            Random num = new Random();

            int valor = num.Next(10, 101); ;

            int numeroElegido = -1;
            //int leer = Convert.ToInt32(Console.ReadLine());

            while (numeroElegido != valor)
            {
                Console.WriteLine("Ingrese un numero entre 1 y 100");
                numeroElegido = Convert.ToInt32(Console.ReadLine());

                if (numeroElegido > valor)
                {
                    Console.WriteLine("Ingrese un numero menor");
                    vidas--;
                }
                else
                {
                    if (valor > numeroElegido)
                    {
                        Console.WriteLine("Ingrese un numero mayor");
                        vidas--;
                    }

                }
                if (vidas == 0)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("|          Game Over          |");
                    Console.WriteLine("------------------------------");
                    break;
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("|          Te quedan:   {0}", vidas + " Vidas");
                Console.WriteLine("------------------------------");


            }
            if (numeroElegido == valor)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("|     Felicidades! Ganaste     |");
                Console.WriteLine("------------------------------");
            }
        }
    }
}
