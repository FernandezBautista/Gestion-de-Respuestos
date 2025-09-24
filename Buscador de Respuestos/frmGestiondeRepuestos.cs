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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

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
    }
}
