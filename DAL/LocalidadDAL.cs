using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class LocalidadDAL
    {

        public static List<Localidad> Listar(string pProv)
        {
            string mCommandText = "select descripcion, cod_localidad from localidad where cod_prov = (select cod_prov from Provincia where descripcion = '" + pProv + "' ) order by 1";

            DAO mDAO = new DAO();

            DataSet mDs = mDAO.ExecuteDataSet(mCommandText);

            List<Localidad> LiLocalidads = new List<Localidad>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDs.Tables[0].Rows)
                {
                    Localidad BELocalidad = new Localidad();
                    ValorizarEntidad(BELocalidad, mDr);
                    LiLocalidads.Add(BELocalidad);
                }

            }
            return LiLocalidads;

        }



        internal static void ValorizarEntidad(Localidad pLocalidad, DataRow pDr)
        {

            pLocalidad.descripcion = pDr["descripcion"].ToString();
            pLocalidad.cod_localidad = int.Parse(pDr["cod_localidad"].ToString());

        }
    }
}
