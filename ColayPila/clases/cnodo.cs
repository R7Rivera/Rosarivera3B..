using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColayPila.clases
{
    class cnodo
    {
        private int dato;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        private cnodo siguiente = null;
        internal cnodo Siguiente { get => siguiente; set => siguiente = value; }

        public override string ToString()
        {
            return string.Format("{[0]}", dato);
        }


    }
}
