using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BE;

namespace GuarderideMascotas
{
    public partial class GestionarUsuario : Form
    {
        internal BL.Usuario BLUsuario = new BL.Usuario();

        public GestionarUsuario()
        {
            InitializeComponent();        
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AltaUsuario AlUs = new AltaUsuario();
            AlUs.Show();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarUsuario_Load(object sender, EventArgs e)
        {

            dgvUsuarios.Columns.Add("Id", "Id");
            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["Id"].DataPropertyName = "cod_usuario";
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns["Nombre"].DataPropertyName = "nombre";
            dgvUsuarios.Columns["Nombre"].Width = 100;
            dgvUsuarios.Columns.Add("Apellido", "Apellido");
            dgvUsuarios.Columns["apellido"].DataPropertyName = "apellido";
            dgvUsuarios.Columns["apellido"].Width = 100;
            dgvUsuarios.Columns.Add("DNI", "DNI");
            dgvUsuarios.Columns["DNI"].DataPropertyName = "dni";
            dgvUsuarios.Columns["DNI"].Width = 100;
            dgvUsuarios.Columns.Add("Email", "Email");
            dgvUsuarios.Columns["Email"].DataPropertyName = "email";
            dgvUsuarios.Columns["Email"].Width = dgvUsuarios.Width - 200 - 3;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.AutoGenerateColumns = false;
            Actualizar();

        }

        private void Actualizar()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = BLUsuario.ListarUsuario();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BE.Usuario BEUsuaruio = new BE.Usuario();


            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int mId = int.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());

                BEUsuaruio = BLUsuario.RecuperarUsuario(mId);

                ModificarUsuario ModU = new ModificarUsuario(BEUsuaruio);
                ModU.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            BE.Usuario BEUsuaruio = new BE.Usuario();

            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int mId = int.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());

                BEUsuaruio = BLUsuario.RecuperarUsuario(mId);

                BajaUsuario Baju = new BajaUsuario(BEUsuaruio);
                Baju.Show();
            }


        }

        private void btnir_Click(object sender, EventArgs e)
        {

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = BLUsuario.Buscar(txtBuscar.Text);
            txtBuscar.Text = "";
                        
        }
    }
}
