using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class Localidad
    {


        public List<BE.Localidad> ListarLocalidad(string pProv)
        {

           return LocalidadDAL.Listar(pProv);

        }




    }
}
