using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.logica
{
    internal class Ejercicio_3
    {
        public void run()
        {
            Console.WriteLine("Saber si un numero es Primo");
            Console.WriteLine("Ingrese un numero: ");
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            if (esPrimo(numero))
            {
                Console.WriteLine("----------------");
                Console.WriteLine("Es primo");
                Console.WriteLine("-----------------");

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("|    No Es primo     |");
                Console.WriteLine("------------------------");

                Console.ReadLine();
            }

        }



        static bool esPrimo(int numero)
        {
            
            int cont = 0;
            int[] numeros = new int[numero];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
            }
            foreach (int i in numeros)
            {
                if (i == 1 || i == numero)
                {
                    continue;
                }
                if (numero % i == 0)
                {
                    cont++;
                }
            }
            return
                cont == 0;
        }
    }
}

