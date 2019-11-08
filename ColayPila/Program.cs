using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColayPila.clases;

namespace ColayPila
{
    class Program
    {
        static void Main(string[] args)
        {
            Epila pila = new Epila();
            Ecola cola = new Ecola();

            bool ban = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                int valor;
                valor = Menu();



                switch (valor)
                {
                    case 1: pila.epila(); 
                        break;
                    case 2: cola.ecola(); 
                        break;
                    case 3: ban = false;
                        break;
                    default:
                        Console.WriteLine("*********Escoja la opción correcta************");
                        Console.ReadKey();
                        break;
                }
            } while (ban);

            int Menu()
            {
                Console.Clear();
                int opcion;

                Console.WriteLine("************MENU***************");
                Console.WriteLine("\n");
                Console.WriteLine(" 1) Ejercicio Pila\n");
                Console.WriteLine(" 2) Ejercicio Cola\n");
                Console.WriteLine(" 3) Salir\n");
                opcion = int.Parse(Console.ReadLine());
                return opcion;



            }
        }


    }


}




