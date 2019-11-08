using System;
using System.Collections.Generic;
using System.Text;

namespace ColayPila.clases
{
    class Ecola
    {
        public void ecola()
        {
            
            Cola cola = new Cola();
            bool bon = true; int valor;
            do
            {
                valor = Menu();
                switch (valor)
                {
                    case 1: cola.InsertarNodo();
                        break;
                    case 2:
                        cola.DesplegarCola();
                        break;
                    case 3: bon = false; 
                        break;
                    default:
                        Console.WriteLine("**********Escoja la opción correcta**********");
                        Console.ReadKey();
                        break;
                }
            } while (bon);

            int Menu()
            {
                Console.Clear();


                Console.WriteLine("**********MENU*************");
                Console.WriteLine("'\n");
                Console.WriteLine(" 1) Ingresar numeros :\n");
                Console.WriteLine(" 2) Recorrer cola:\n");
                Console.WriteLine(" 3) Salir:\n");
                int opcion = int.Parse(Console.ReadLine());
                return opcion;
            }


        }
    }
}

