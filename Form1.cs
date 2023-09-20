using System.Drawing;
using System.Windows.Forms;
using WinFormsApp4.Clases;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        LinkedList lista;
        public Form1()
        {
            InitializeComponent();
            lista = new LinkedList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtData.Text);
            if (lista.Exist(valor))
            {
                MessageBox.Show("Este elemento ya existe.");
                return;
            }

            Node nuevoNodo = new Node(int.Parse(txtData.Text), txtName.Text);
            lista.Add(nuevoNodo);
            lsLista.Items.Clear();
            lsLista.Items.AddRange(AgregarLista(lista.ToString()));


        }

        public string[] AgregarLista(string name)
        {
            string[] elementos = name.Split('_');
            return elementos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtData.Text);
            if (!lista.Exist(valor))
            {
                MessageBox.Show("Este elemento ya existe.");
                return;
            }

            lista.Remove(valor);
            lsLista.Items.Clear();
            lsLista.Items.AddRange(AgregarLista(lista.ToString()));
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int nNode = int.Parse(txtNodosCrear.Text);
            
            Node list;
            for (int i = 0; i < nNode; i++)
            {
                if (lista.Exist(i))
                {
                    MessageBox.Show("Este elemento ya existe.");
                    return;
                }

                list = new Node(i, "Nodo");
                lista.Add(list);
            }

            lsLista.Items.Clear();
            lsLista.Items.AddRange(AgregarLista(lista.ToString()));
        }
    }
}