using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.Clases
{
    internal class LinkedList
    {
        private Node head;
        public LinkedList() 
        {
            head = null;
        }


        public void Add(Node node)
        {
            Node nuevoNodo = node;

            if (head == null)
            {
                head = nuevoNodo;
                return; 
            }

            if (nuevoNodo.Valor < head.Valor)
            {
                nuevoNodo.Siguiente = head;
                head = nuevoNodo;
                return;
            }

            Node nodoActual = head;
            while (nodoActual.Siguiente != null)
            {
                if (nuevoNodo.Valor < nodoActual.Siguiente.Valor)
                {
                    nuevoNodo.Siguiente = nodoActual.Siguiente;
                    nodoActual.Siguiente = nuevoNodo;
                    return;
                }
                nodoActual = nodoActual.Siguiente;
            }
            nodoActual.Siguiente = nuevoNodo;

        }
        public void Remove(int valorNodo)
        {
            if (head == null)
            {
                return;
            }
            if (head.Valor == valorNodo)
            {
                head = head.Siguiente;
                return;
            }

            Node nodoActual = head;
            while (nodoActual.Siguiente != null)
            {
                if (nodoActual.Siguiente.Valor == valorNodo)
                {
                    nodoActual.Siguiente = nodoActual.Siguiente.Siguiente;
                    break;
                }
                nodoActual = nodoActual.Siguiente;
            }
            return;
        }

        public bool Exist(int valorNodo)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Valor == valorNodo)
            {
                return true;
            }

            Node? nodoActual = head;
            while (nodoActual.Siguiente != null)
            {
                if (nodoActual.Siguiente.Valor >= valorNodo)
                {
                    break;
                }
                nodoActual = nodoActual.Siguiente;
            }

            if (nodoActual != null && nodoActual.Siguiente != null && nodoActual.Siguiente.Valor == valorNodo)
            {
                return true;
            }
            return false;
        }

        public int Count()
        {
            int count = 0;
            Node nodoActual = head;
            while(nodoActual != null)
            {
                count++;
                nodoActual = nodoActual.Siguiente;
            }
            return count;
        }

        public override string ToString()
        {
            Node? nodoActual = head;
            string r = "";
            while (nodoActual != null)
            {
                r += nodoActual.ToString() + "_";
                nodoActual = nodoActual.Siguiente;
            }
            return r;
        }
    }
}
