using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMPrueba
{
    public partial class Menu : Form
    {
        List<String> lista = new List<String>();
        public Menu()
        {
            InitializeComponent();
            //añado items a la lista
            listBox2.Items.Add("Item 1");
            listBox2.Items.Add("Item 2");
            listBox2.Items.Add("Item 3");
            listBox2.Items.Add("Item 4");
            listBox2.Refresh();
            panel2.Hide();
            panel3.Hide();
            panelMenu1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMenu1.Hide();
            panel3.Hide();
            panel2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panelMenu1.Show();
        }

        private void agregarALista(object sender, EventArgs e)
        {
            String seleccionado;
            try
            {
                seleccionado = listBox2.SelectedItem.ToString();
                lista.Add(seleccionado);
                foreach (String elem in lista)
                {
                    Console.WriteLine(elem + "\n");
                }
                //Console.WriteLine(seleccionado);
            }
            catch (Exception)
            {
                Console.WriteLine("rompiste todo wacha");
                MessageBox.Show("Debe seleccionar un elemento de la lista");
            }
        }

        private void mostrarMenu3(object sender, EventArgs e)
        {
            panelMenu1.Hide();
            panel2.Hide();
            panel3.Show();
            dataGridView1.DataSource = lista;
            
        }
    }
}
