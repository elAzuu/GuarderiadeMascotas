using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DAO
    {
        SqlConnection mCon = new SqlConnection("Data Source=.;Initial Catalog=Guarderia;Integrated Security=True");

        public DataSet ExecuteDataSet(string pCommandtext)
        {
            SqlDataAdapter mDa = new SqlDataAdapter(pCommandtext, mCon);

            DataSet mDs = new DataSet();

            mDa.Fill(mDs);

            mCon.Close();

            return mDs;
        }


        public int ObtenerUltimoId(string pTabla)
        {

            SqlCommand mCom = new SqlCommand("SELECT ISNULL(MAX(cod_" + pTabla + "),0) FROM " + pTabla, mCon);
            mCon.Open();
            int salida = int.Parse(mCom.ExecuteScalar().ToString());

            mCon.Close();

            return salida;

        }


        public int ExecuteNonQry(string pCommandText)
        {
            SqlCommand mCom = new SqlCommand(pCommandText, mCon);

            mCon.Open();

            int salida = mCom.ExecuteNonQuery();

            mCon.Close();

            return salida;

        }

    }
}
