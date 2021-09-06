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
    public partial class Alta_Cliente : Form
        
    {

        BL.Cliente BLCliente = new BL.Cliente();
        public Alta_Cliente()
        {
            InitializeComponent();
            
            BL.Provincia Pr = new BL.Provincia();
            
            cmbProv.DataSource = Pr.ListarProvincia();
            cmbProv.DisplayMember = "descripcion";

            cmbDNI.Items.Add("DNI");
            cmbDNI.Items.Add("LE");
            cmbDNI.Items.Add("CI");
            cmbDNI.Items.Add("LC");

            BuscarLocalidades();

            cmbProv.SelectedIndex = -1;
            cmbCiudad.SelectedIndex = -1;


        }

        private void cmbProv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void Alta_Cliente_Load(object sender, EventArgs e)
        {

        }



        private void cmbProv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscarLocalidades();

        }


        private void BuscarLocalidades()
        {
            BL.Localidad Lo = new BL.Localidad();
            cmbCiudad.DataSource = Lo.ListarLocalidad(cmbProv.Text);
            cmbCiudad.DisplayMember = "descripcion";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            BE.Cliente BECliente = new BE.Cliente();

            BECliente.nombre = txtNombre.Text;
            BECliente.apellido = txtApellido.Text;
            BECliente.direccion = txtDire.Text;
            BECliente.cod_postal = int.Parse(txtCP.Text);
            BECliente.dni = int.Parse(txtDNI.Text);
            BECliente.tipo_dni = cmbDNI.Text;
            


            BLCliente.Guardar(BECliente);




        }
    }
}
