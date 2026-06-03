using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSD.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesaria
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string estudiante = txtEstudiante.Text;
            string libro = txtLibro.Text;

            if (string.IsNullOrWhiteSpace(estudiante) || string.IsNullOrWhiteSpace(libro))
            {
                MessageBox.Show("Debe ingresar estudiante y libro.");
                return;
            }

            string registro = $"{estudiante} → {libro}";
            lstPrestamos.Items.Add(registro);

            txtEstudiante.Clear();
            txtLibro.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eliminar prestamo y actualizar la lista
            if (lstPrestamos.SelectedItem != null)
            {
                lstPrestamos.Items.Remove(lstPrestamos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un préstamo para eliminar.");
            }
        }
    }
}
