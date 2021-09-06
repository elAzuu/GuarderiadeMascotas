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
using System.Text.RegularExpressions;


namespace GuarderideMascotas
{
    public partial class IniciarSesion : Form
    {

        BE.Usuario BEUsuario = new BE.Usuario();
        BL.Usuario BLUsuario = new BL.Usuario();
        public bool Iniciado { get; set; }

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "" && txtUsuario.Text != "")
            {
                BEUsuario.usuario = txtUsuario.Text;
                BEUsuario.contraseña = txtContraseña.Text;
                int a = BLUsuario.VerificarUsuario(BEUsuario);

                if (a == 1)
                {
                    Iniciado = true;
                    MessageBox.Show("Bienvenido!");
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("Complete ambos campos para continuar...");
            }

        }
        
    }
}
