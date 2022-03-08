using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.presentacion
{
    class MenuPrincipal
    {
    
        public void dibujar()
        {
            int op=0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(15, 8); Console.Write(" M E N U   P R N C I P A L");
                Console.SetCursorPosition(20, 10); Console.Write("1. Ejercico 1");
                Console.SetCursorPosition(20, 12); Console.Write("2. Ejercico 2");
                Console.SetCursorPosition(20, 14); Console.Write("3. Ejercicio 3");
                Console.SetCursorPosition(20, 16); Console.Write("4. Ejercicio 4");
                Console.SetCursorPosition(20, 18); Console.Write("5. Ejercicio 5");
                Console.SetCursorPosition(20, 20); Console.Write("6. Ejercicio 6");

                Console.SetCursorPosition(20, 26); Console.Write("9. salir");

                Console.SetCursorPosition(20, 24); Console.Write("Digite una opcion : ");
                Console.SetCursorPosition(40, 24); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        logica.Ejercicio_1 ej1= new logica.Ejercicio_1();
                        ej1.run();
                        break;
                    case 2:
                        Console.Clear();
                        logica.Ejercicio_2 ej2 = new logica.Ejercicio_2();
                        ej2.captura();
                        Console.ReadKey();
                        ej2.dprincipal();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        logica.Ejercicio_3 eje3 = new logica.Ejercicio_3();
                        eje3.run();
                        break;
                    case 4:
                        Console.Clear();
                        logica.Ejercicio_4 eje4 = new logica.Ejercicio_4();
                        eje4.run();
                        break;

                    case 5:
                        Console.Clear();
                        logica.Ejercicio_5 eje5 = new logica.Ejercicio_5();
                        eje5.run();
                        break;

                    case 6:
                        Console.Clear();
                        logica.Ejercicio_6 eje6 = new logica.Ejercicio_6();
                        eje6.run();
                        break;
                    //default:
                    //    Console.Clear();
                    //    Console.SetCursorPosition(15, 8); Console.Write("opcio no disponible ...");
                    //    Console.SetCursorPosition(15, 10); Console.Write("gracias por usar productos johnp ...");
                    //    Console.ReadKey();
                    //    break;
                }

               

            } while (op!= 9);
        }
    }
}
