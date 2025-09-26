using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscador_de_Respuestos
{
    public partial class frmGestiondeRepuestos : Form
    {

        public frmGestiondeRepuestos()
        {
            InitializeComponent();
        }

        private void cmbMarcaI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void opcNacionalI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opcImportadoI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        int Indice = 0;
        public struct Repuesto

        {
            public char Marca;
            public char Origen;
            public int Numero;
            public string Descripcion;
            public float Precio;
        }

        Repuesto nuevoRepuesto;
        Repuesto[] VecRepuestos = new Repuesto[100];
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (Indice >= VecRepuestos.Length)
            {
                MessageBox.Show("Ya se cargaron los 100 repuestos.");
                return;
            }

            if (cmbMarcaI.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }

            if (opcNacionalI.Checked && opcImportadoI.Checked)
            {
                MessageBox.Show("Debe seleccionar el origen.");
                return;
            }

            if (txtNumero.Text == "")
            {
                MessageBox.Show("Debe ingresar un número.");
                return;
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return;
            }

            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio.");
                return;
            }

            Repuesto nuevoRepuesto = new Repuesto();
            nuevoRepuesto.Marca = cmbMarcaI.SelectedItem.ToString()[0];
            nuevoRepuesto.Origen = opcNacionalI.Checked ? 'N' : 'I';
            nuevoRepuesto.Numero = Convert.ToInt32(txtNumero.Text);
            nuevoRepuesto.Descripcion = txtDescripcion.Text;
            nuevoRepuesto.Precio = float.Parse(txtPrecio.Text);

            VecRepuestos[Indice] = nuevoRepuesto;
            Indice++;

            MessageBox.Show("Repuesto cargado correctamente.");
        }


        private void cmbMarcaC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void opcNacionalC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opcImportadoC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
        
        {
            if (cmbMarcaC.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar una marca para realizar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!opcImportadoC.Checked && !opcNacionalI.Checked)
                MessageBox.Show("Debe elegir el origen para realizar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

            {
               char marca = cmbMarcaC.SelectedItem.ToString()[0];
               char origen = opcNacionalC.Checked ? 'N' : 'I';
            }
        
        
        }

        private void frmGestiondeRepuestos_Load(object sender, EventArgs e)
        {

        }

        private void lblNumeroI_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblConsulta_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbMarcaI.SelectedIndex = -1;
            opcNacionalI.Checked = false;
            opcImportadoI.Checked = false;
            txtNumero.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            cmbMarcaC.SelectedIndex = -1;
            opcNacionalC.Checked = false;
            opcImportadoC.Checked = false;
        }

        private void lblOrigenI_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcionI_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}


