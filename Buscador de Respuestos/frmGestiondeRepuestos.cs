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
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
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

        public struct Repuesto
        {
            public char Marca;
            public char Origen;
            public int Numero;
            public string Descripcion;
            public float Precio;
        }

        List<Repuesto> listaRepuestos = new List<Repuesto>();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbMarcaI.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }

            if (!opcNacionalI.Checked && !opcImportadoI.Checked)
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

            int numeroIngresado;
            if (!int.TryParse(txtNumero.Text, out numeroIngresado))
            {
                MessageBox.Show("El número ingresado no es válido.");
                return;
            }

            foreach (Repuesto rep in listaRepuestos)
            {
                if (rep.Numero == numeroIngresado)
                {
                    MessageBox.Show("Ya existe un repuesto con ese número.", "Error: Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            float precioIngresado;
            if (!float.TryParse(txtPrecio.Text, out precioIngresado))
            {
                MessageBox.Show("El precio ingresado no es válido. Revise el formato.");
                return;
            }

            Repuesto nuevoRepuesto = new Repuesto();

            nuevoRepuesto.Marca = cmbMarcaI.Text[0];

            if (opcNacionalI.Checked)
                nuevoRepuesto.Origen = 'N';
            else
                nuevoRepuesto.Origen = 'I';

            nuevoRepuesto.Numero = numeroIngresado;
            nuevoRepuesto.Descripcion = txtDescripcion.Text;
            nuevoRepuesto.Precio = precioIngresado;

            listaRepuestos.Add(nuevoRepuesto);

            MessageBox.Show("Repuesto cargado correctamente.");
            btnLimpiar_Click(sender, e);
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
            if (cmbMarcaC.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca para realizar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!opcImportadoC.Checked && !opcNacionalC.Checked)
            {
                MessageBox.Show("Debe elegir el origen para realizar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char marcaConsulta = cmbMarcaC.Text[0];
            char origenConsulta = opcNacionalC.Checked ? 'N' : 'I';

            lstResultados.Items.Clear();

            int cantidadEncontrada = 0;

            foreach (Repuesto rep in listaRepuestos)
            {
                if (rep.Marca == marcaConsulta && rep.Origen == origenConsulta)
                {
                    string item = $"Nro: {rep.Numero} - {rep.Descripcion} - Precio: ${rep.Precio}";
                    lstResultados.Items.Add(item);
                    cantidadEncontrada++;
                }
            }

            if (cantidadEncontrada == 0)
            {
                MessageBox.Show("No se encontraron repuestos con esos criterios.");
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) ||
                e.KeyChar == Convert.ToChar(Keys.Back) ||
                (e.KeyChar == ',' && !txtPrecio.Text.Contains(",")))
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
            lstResultados.Items.Clear();
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
        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}