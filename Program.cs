
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tarea_2
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ListaDoble Lista1 = new ListaDoble();
            ListaDoble Lista2 = new ListaDoble();
            ListaDoble lista = new ListaDoble();
            Problemas problemas = new Problemas();

            Lista1.InsertInOrder(34);
            Lista1.InsertInOrder(3);
            Lista1.InsertInOrder(25);
            Lista1.InsertInOrder(15);
            Lista1.InsertInOrder(8);
            
            
            Lista2.InsertInOrder(5);
            Lista2.InsertInOrder(10);
            Lista2.InsertInOrder(14);
            Lista2.InsertInOrder(22);
            Lista2.InsertInOrder(28);
            Lista2.InsertInOrder(37);

            
            lista.AgregarPrimero(1);
            lista.AgregarPrimero(0);
            lista.AgregarPrimero(30);
            lista.AgregarPrimero(50);
            lista.AgregarPrimero(2);


            problemas.Invertir(lista);
            // problemas.MergeSorted(Lista2 , Lista1, ListaDoble.SortDirection.Asc);



            
            // Lista1.printMiddle();

            




        }

        
        


    }
}