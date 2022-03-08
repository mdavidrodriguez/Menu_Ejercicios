using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.logica
{
    internal class Ejercicio_4
    {
        public void run()
        {
            Console.WriteLine("Calculo del Fatorial de un numero");
            Console.WriteLine("Digite un numero: ");
            int num = int.Parse(Console.ReadLine());
            int Factor = 1;
            for (int i = 1; i <= num; i++)
                Factor = Factor * i;
            Console.WriteLine("El factorial del numero es: " + Factor);
            Console.ReadLine();
        }
    }
}
