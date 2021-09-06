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

namespace GuarderideMascotas
{
    public partial class BajaUsuario : Form
    {
        BL.Usuario BLUsuario = new BL.Usuario();
        BE.Usuario BEUsuario = new BE.Usuario();
        public BajaUsuario()
        {
            InitializeComponent();
        }

        public BajaUsuario(BE.Usuario pUsuario)
        {
            InitializeComponent();

            cmbidioma.Items.Add("Español");
            cmbidioma.Items.Add("Inglés");

            BEUsuario = pUsuario;
            txtApellido.Text = pUsuario.apellido;
            txtDNI.Text = pUsuario.dni.ToString();
            txtEmail.Text = pUsuario.email;
            txtNombre.Text = pUsuario.nombre;

            if (pUsuario.idioma == 1)
            {
                cmbidioma.SelectedIndex = 0;
            }
            else
            {
                cmbidioma.SelectedIndex = -1;
            }



        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            BLUsuario.BajaUsuario(BEUsuario);
            MessageBox.Show("¡Usuario eliminado correctamente!");
            this.Close();


        }


    }
}
