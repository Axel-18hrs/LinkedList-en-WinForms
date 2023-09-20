using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.Clases
{
    internal class Node
    {
        private int valor;
        private string? name;
        private Node? siguiente;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Node? Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Node(int valor, string? name)
        {
            this.valor = valor;
            this.name = name;
            this.siguiente = null;
        }
        public Node()
        {

        }

        public override string ToString()
        {
            return Valor.ToString() + " " + name;
        }
    }
}
