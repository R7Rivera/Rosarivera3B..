﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColayPila.clases
{
    class CSTACK
    {
        private cnodo ancla;

        private cnodo trabajo;

        public CSTACK()
        {
            ancla = new cnodo();

            ancla.Siguiente = null;

        }

        public void Push(int pDato)
        {
            cnodo temp = new cnodo();

            temp.Dato = pDato;

            temp.Siguiente = ancla.Siguiente;

            ancla.Siguiente = temp;


        }

        public int Pop()
        {
            int valor = 0;

            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }

        public int Peek()
        {
            int valor = 0;
            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;


            }
            return valor;
        }

        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                int d = trabajo.Dato;
                Console.WriteLine("{[0]}", d);
            }
        }



    }
}

