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
    public partial class ModificarUsuario : Form
    {
        BL.Usuario BLUsuario = new BL.Usuario();
        BE.Usuario BEUsuario = new BE.Usuario();

        public ModificarUsuario()
        {
            InitializeComponent();

        }

        public ModificarUsuario(BE.Usuario pUsuario)
        {
            InitializeComponent();
            cmbIdioma.Items.Add("Español");
            cmbIdioma.Items.Add("Inglés");

            BEUsuario = pUsuario;
            txtApellido.Text = pUsuario.apellido;
            txtDNI.Text = pUsuario.dni.ToString();
            txtEmail.Text = pUsuario.email;
            txtNombre.Text = pUsuario.nombre;

            if (pUsuario.idioma == 1)
            {
                cmbIdioma.SelectedIndex = 0;
            }
            else
            {
                cmbIdioma.SelectedIndex = 1;
            }
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValorizarEntidad();
            BLUsuario.Guardar(BEUsuario);
            MessageBox.Show("¡Usuario modificado correctamente!");
            this.Close();

        }



        private void ValorizarEntidad()
        {
            BEUsuario.apellido = txtApellido.Text;
            BEUsuario.nombre = txtNombre.Text;
            BEUsuario.dni = int.Parse(txtDNI.Text);
            BEUsuario.email  = txtEmail.Text;

            if (cmbIdioma.SelectedIndex == 0)
            {
                BEUsuario.idioma = 1;
            }
            else
            {
                BEUsuario.idioma = 0;
            }
            
            
        }
    }
}
