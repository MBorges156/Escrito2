using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            PersonaControlador.Crear(txtID.Text, txtNombre.Text, txtApellido.Text);
            MessageBox.Show("Persona ingresada con exito");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
                string id = tablaDeDatos.SelectedRows[0].Cells["id"].Value.ToString();
                DialogResult resultado = MessageBox.Show(
                    $"Esta seguro que quiere eliminar el usuario {id}?",
                    "Esta seguro?",
                    MessageBoxButtons.YesNo);
            }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = tablaDeDatos.SelectedRows[0].Cells["nombre"].Value.ToString();
            txtApellido.Text = tablaDeDatos.SelectedRows[0].Cells["apellido"].Value.ToString();
        }
    }
}
