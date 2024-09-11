using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    public class ListaDoble
    {
        public Nodo Cabeza;
        public Nodo Cola;
        public Nodo Mitad; 
        public int Tamano;

        public ListaDoble() 
        {
            this.Cabeza = null;
            this.Cola = null;
            this.Mitad = null;
            this.Tamano = 0;
        }

        public enum SortDirection
        {
            Asc,
            Desc
        }

        public void AgregarPrimero(int value)
        {
            Nodo nodoAgregado = new Nodo(value);
            if (Cabeza == null)
            {
                Cabeza = nodoAgregado;
                Cola = nodoAgregado;               
            }
            else
            {
                Cabeza.Anterior = nodoAgregado;
                nodoAgregado.Siguiente = Cabeza;
                Cabeza = nodoAgregado;

            }
            Tamano++;
        }
            
                
        public void InsertInOrder(int value)

        {
            Nodo nuevoElemento = new Nodo(value);
            if (Cabeza == null)
            {
                Cabeza = nuevoElemento;
                Cola = nuevoElemento;
                Mitad = nuevoElemento;
                Tamano++;
                
            }

            else
            {
                Nodo actual = Cabeza;
                Nodo auxiliar = null;

                while (actual != null && actual.data < nuevoElemento.data)

                {
                    actual = actual.Siguiente;
                }

                {
                    if (actual == Cabeza)
                    {
                        nuevoElemento.Siguiente = Cabeza;
                        Cabeza.Anterior = nuevoElemento;
                        Cabeza = nuevoElemento;
                    }

                    else if (actual == null)
                    {
                        Cola.Siguiente = nuevoElemento;
                        nuevoElemento.Anterior = Cola;
                        Cola = nuevoElemento;
                    }
                    else
                    {
                        auxiliar = actual.Anterior;
                        auxiliar.Siguiente = nuevoElemento;
                        nuevoElemento.Anterior = auxiliar;
                        nuevoElemento.Siguiente = actual;
                        actual.Anterior = nuevoElemento;
                    }

                    Tamano ++;

                    if (Tamano % 2 == 0)
                    {
                        if (nuevoElemento.data >= Mitad.data)
                        {
                            Mitad = Mitad.Siguiente;
                        }
                    }

                    else
                    {
                        if(nuevoElemento.data < Mitad.data)
                        {
                            Mitad = Mitad.Anterior;
                        }
                    }
                    
                   
                }

            }
        }

        public void printMiddle()
        {
            Console.WriteLine(Mitad.data);
        }

        public int DeleteFirst()
        {
            int ValorDado = Cabeza.data;
            Cabeza = Cabeza.Siguiente;
            Cabeza.Anterior = null;
            Tamano--;
            
            return ValorDado;
        }

        public int DeleteLast()
        {
            int ValorDado = Cola.data;
            Cola = Cola.Anterior;
            Cola.Siguiente = null;
            Tamano--;

            return ValorDado;
        }

        public bool DeleteValue(int value)
        {
            
            if (Cabeza == null)
            {
                return false;
            }

            Nodo actual = Cabeza;

            
            while (actual != null && actual.data != value)
            {
                actual = actual.Siguiente;
            }

            
            if (actual == null)
            {
                return false;
            }

           
            if (Cabeza == Cola && actual == Cabeza)
            {
                Cabeza = null;
                Cola = null;
            }
            
            else if (actual == Cabeza)
            {
                Cabeza = Cabeza.Siguiente;
                Cabeza.Anterior = null;
            }
            
            else if (actual == Cola)
            {
                Cola = Cola.Anterior;
                Cola.Siguiente = null;
            }
            
            else
            {
                actual.Anterior.Siguiente = actual.Siguiente;
                actual.Siguiente.Anterior = actual.Anterior;
            }

            
            Tamano--;

            if (Tamano % 2 == 0)
            {
                if (actual.data >= Mitad.data)
                {
                    Mitad = Mitad.Anterior;
                }
            }
            else
            {
                if (actual.data < Mitad.data)
                {
                    Mitad = Mitad.Siguiente;
                }
            }

            return true; 
        }

        public int GetMiddle()
        {
            if(Mitad == null)
            {
                throw new ArgumentNullException("La mitad de la lista es null");
            }

            if (Tamano == 0)
            {
                throw new InvalidOperationException("La lista está vacía y no tiene un elemento central.");
            }

            return Mitad.data;


        }

              
        public void Print()
        {
            if (Tamano == 0)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo temp = Cabeza;
            for (int i = 0; i < Tamano; i++) 
            {
                Console.WriteLine(temp.data);
                temp = temp.Siguiente;
            }
        }

    }
}
