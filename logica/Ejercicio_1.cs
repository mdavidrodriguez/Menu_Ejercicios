using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.logica
{
    class Ejercicio_1
    {
        public void run()
        {
            Console.WriteLine("Tablas de multiplicar del 1 al 10");

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Tabla del: " + i);
                Console.WriteLine("----------------------");
                for (int k = 0; k < 11; k++)
                {
                    Console.WriteLine(i + "x" + k + "=" + i * k);
                }
            }
            Console.ReadLine();
        }
        }
    }

