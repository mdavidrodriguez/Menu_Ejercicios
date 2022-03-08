using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.logica
{
    class Ejercicio_2
    {
        int [,] m = new int[3,3];

        public void captura()
        {
            int i, j, num;
            Console.SetCursorPosition(20,2);Console.Write("sistema de captura de matrices");
            for (i = 0; i < 3; i++)
            {
                for ( j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(15+(5*j),2*(i+2)); num = int.Parse(Console.ReadLine());
                    m[i,j]= num;
                }
            }
            Console.ReadKey();

        }

        public void dprincipal()

        {
            int i, j;
            Console.Clear();
            Console.SetCursorPosition(25,2); Console.Write("elementos de la diagonal principal");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i==j)
                    {
                            Console.SetCursorPosition(15 + (5 * j), 2 * (i + 2)); Console.Write(m[i, j]);
                           
                    }
                   
                }
            }
            Console.ReadKey();
        }

    }
}
