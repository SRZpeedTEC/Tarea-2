using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    public class Nodo
    {
        public int data {  get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }

        public Nodo(int data)
        {
            this.data = data;
            this.Siguiente = null;
            this.Anterior = null;
        }

    }

}
