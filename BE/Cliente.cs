using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {

        public Cliente()
        { }

        public Cliente(int pId)
        {
            cod_Cliente = pId;
        }

        public List<Telefono> LiTelefonos;

        public int cod_Cliente { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int cod_prov { get; set; }

        public int cod_localidad { get; set; }

        public string tipo_dni { get; set; }

        public int dni { get; set; }

        public bool baja { get; set; }

        public string direccion { get; set; }

        public int altura { get; set; }

        public int cod_postal { get; set; }




    }
}
