using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblConf_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //1. Validar el nombre
            if(string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingresa tu nombre.", "Validación",
                   MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            //2. Definir si desea respuesta
            List<string> Motivo = new List<string>();
            if(radConsulta.Checked)
            {
                Motivo.Add(radConsulta.Text);
            }
            if(radQueja.Checked)
            {
                Motivo.Add(radQueja.Text);
            }
            if(radSugerencia.Checked)
            {
                Motivo.Add(radSugerencia.Text);
            }

            if(Motivo.Count == 0) 
            {
                MessageBox.Show("Por favor selecciona tu motivo de contacto.", "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
        }
            string respuesta = "";

    }
}
