using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMeidanteListasEnlazadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Catalogo_estructura_ cat = new Catalogo_estructura_();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                ClaseBase nuevo;
                nuevo = new ClaseBase(txtProducto.Text, txtAlumno.Text, txtVehiculo.Text, Convert.ToInt32(txtContacto.Text));
                cat.agregarInicio(nuevo);
                txtAlumno.Clear();
                txtContacto.Clear();
                txtProducto.Clear();
                txtVehiculo.Clear();
            }
            catch (FormatException )
            {
                DialogResult r = MessageBox.Show("Llena todos los campos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
           txtCatalogo.Text = cat.reporte();
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtCatalogo.Text = cat.reporteInverso();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            cat.eliminarPrimero();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            cat.eliminarUltimo();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            cat.invertirLista();
        }
    }
}
