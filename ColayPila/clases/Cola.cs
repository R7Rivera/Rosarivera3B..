using System;

namespace ColayPila.clases
{
    class Cola
        {
            private cnodo primero = new cnodo();
            private cnodo ultimo = new cnodo();

            public Cola()
            {
                primero = null;
            }

            public void InsertarNodo()
            {

                cnodo nuevo = new cnodo();
                Console.WriteLine("*********Ingrese un número***********:\n");
                nuevo.Dato = int.Parse(Console.ReadLine());

                if (primero == null)
                {
                    primero = nuevo;
                    primero.Siguiente = nuevo;
                    ultimo = nuevo;
                }

                else
                {
                    ultimo.Siguiente = nuevo;
                    nuevo.Siguiente = null;
                    ultimo = nuevo;
                }



                Console.WriteLine("\n*******Ingresado correctamente**********");


            }
            public void DesplegarCola()
            {
                cnodo actual = new cnodo();
                actual = primero;
                if (primero != null)
                {
                    while (actual != null)
                    {
                        Console.WriteLine(" " + actual.Dato);
                        actual = actual.Siguiente;
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("************La cola esta vacía*************");
                    Console.ReadKey();
                }
            }
        }
    }

