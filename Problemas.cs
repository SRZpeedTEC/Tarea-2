using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    public class Problemas
    {

        // PROBLEMA 1
        public void MergeSorted(ListaDoble listaA, ListaDoble listaB, ListaDoble.SortDirection direction)
        {
          
            if (listaA == null || listaB == null)
            {
                throw new ArgumentNullException("No puede haber una lista null");
            }

            else if (listaA.Tamano != 0 && listaB.Tamano == 0)
            {
                if (direction == ListaDoble.SortDirection.Asc)
                {
                    listaA.Print();
                }

                else
                {                   
                    Invertir(listaA);
                    listaA.Print();
                }

            }

            else if (listaA.Tamano == 0 && listaB.Tamano != 0)
            {
                if (direction == ListaDoble.SortDirection.Asc)
                {
                    Nodo actualB = listaB.Cabeza;

                    while (actualB != null)
                    {
                        listaA.InsertInOrder(actualB.data);
                        actualB = actualB.Siguiente;
                    }

                    listaA.Print();
                }

                else 
                {
                    Nodo actualB = listaB.Cabeza;


                    while (actualB != null)
                    {
                        listaA.InsertInOrder(actualB.data);
                        actualB = actualB.Siguiente;
                    }

                    Invertir(listaA);
                    listaA.Print();

                }

            }
            else
            {
                if (direction == ListaDoble.SortDirection.Asc) 
                {                   

                                      
                    Nodo actualB = listaB.Cabeza;
                                       

                    while (actualB != null)
                    {
                        listaA.InsertInOrder(actualB.data);
                        actualB = actualB.Siguiente;
                    }
                   
                    listaA.Print();

                }
                else if (direction == ListaDoble.SortDirection.Desc)
                {
                    
                    Nodo actualB = listaB.Cabeza;
                   

                    while (actualB != null)
                    {
                        listaA.InsertInOrder(actualB.data);
                        actualB = actualB.Siguiente;
                    }
                    Invertir(listaA);

                    listaA.Print();

                }
            }
        }

        

        public void Invertir(ListaDoble Lista)
        {
            // Verifica si la lista está vacía o solo tiene un nodo

            if (Lista == null)
            {
                throw new ArgumentNullException("Lista no puede ser vacia");
            }


            else if (Lista.Cabeza == null || Lista.Cabeza.Siguiente == null)
            {
                Console.WriteLine("Lista vacia");
            }

            Nodo actual = Lista.Cabeza;
            Nodo temp = null;

            // Recorre la lista e intercambia los enlaces
            while (actual != null)
            {
                // Intercambia los enlaces Siguiente y Anterior
                temp = actual.Siguiente;
                actual.Siguiente = actual.Anterior;
                actual.Anterior = temp;

                actual = temp;
            }

            // Intercambia Cabeza y Cola
            temp = Lista.Cabeza;
            Lista.Cabeza = Lista.Cola;
            Lista.Cola = temp;

            Lista.Print();
        }

    }


}
