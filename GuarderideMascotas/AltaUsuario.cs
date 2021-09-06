using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BL;

namespace GuarderideMascotas
{
    public partial class AltaUsuario : Form

    {

        BL.Usuario BLUsuario = new BL.Usuario();

        public AltaUsuario()
        {
            InitializeComponent();

            cmbIdioma.Items.Add("Español");
            cmbIdioma.Items.Add("Inglés");
            cmbIdioma.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtDNI.Text != "" && txtEmail.Text != "")
            {
                int resultado;
                if (int.TryParse(txtDNI.Text, out resultado))
                {

                    BE.Usuario BEUsuario = new BE.Usuario();

                    int ultimoid = BLUsuario.UltimoId("Usuario") + 1;

                    BEUsuario.apellido = txtApellido.Text;
                    BEUsuario.nombre = txtNombre.Text;
                    BEUsuario.email = txtEmail.Text;
                    BEUsuario.dni = int.Parse(txtDNI.Text);
                    BEUsuario.bloqueado = true;

                    if (cmbIdioma.SelectedIndex == 0 || cmbIdioma.SelectedIndex == -1)
                    {
                        BEUsuario.idioma = 1;
                    }
                    else
                    {
                        BEUsuario.idioma = 2;
                    }

                    BEUsuario.GenerarUsuario(ultimoid);

                    BLUsuario.Guardar(BEUsuario);
                    LimpiarCampos();

                    MessageBox.Show("¡Usuario creado correctamente!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡Formato de DNI ingresado no válido!");
                }

            }
            else
            {
                MessageBox.Show("¡Debe completar todos los campos para poder crear un nuevo usuario!");
            }
        }


           


        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text   = "";
            txtEmail.Text    = "";
            txtDNI.Text      = "";
            cmbIdioma.SelectedIndex = -1;

        }
    }
}
