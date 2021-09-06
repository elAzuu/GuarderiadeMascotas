using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;

namespace DAL
{
    public class ClienteDAL
    {

        static int mId;

        private static int ProximoId()
        {
            if (mId == 0)
                mId = (new DAO()).ObtenerUltimoId("Cliente");
            mId += 1;
            return mId;
        }



        public static int Guardar(Cliente pCliente)
        {
            DAO mDao = new DAO();

            if (pCliente.cod_Cliente == 0)
            {
                pCliente.cod_Cliente = ProximoId();



                string mCommandText = "INSERT into Cliente (cod_cliente, tipo_dni, dni, nombre, apellido, baja) "
                                        + " values (" + pCliente.cod_Cliente + ", '" + pCliente.tipo_dni + "', '" + pCliente.dni + "', '"
                                        + pCliente.nombre + "', '" + pCliente.apellido + "',  '0')";

                return mDao.ExecuteNonQry(mCommandText);

            }
            else
            {
                string mCommandText = "UPDATE Cliente set  nombre = '" + pCliente.nombre + "', apellido = '" + pCliente.apellido + "', dni = '" + pCliente.dni +
                                      "', tipo_dni = '" + pCliente.tipo_dni + "',  where cod_Cliente = " + pCliente.cod_Cliente;

                return mDao.ExecuteNonQry(mCommandText);
            }

        }

        public static int Eliminar(Cliente PCliente)
        {
            string mCommandText = "UPDATE Cliente set baja = '1' WHERE cod_Cliente = " + PCliente.cod_Cliente;
            DAO mDao = new DAO();
            return mDao.ExecuteNonQry(mCommandText);
        }

        public static Cliente Obtener(int pId)
        {
            string mCommandText = "SELECT cod_cliente, nombre, apellido, tipo_dni, dni, baja FROM Cliente WHERE cod_Cliente = " + pId;

            DAO mDAO = new DAO();

            DataSet mDs = mDAO.ExecuteDataSet(mCommandText);

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                Cliente BECliente = new Cliente(pId);
                ValorizarEntidad(BECliente, mDs.Tables[0].Rows[0]);
                return BECliente;
            }
            else
            {
                return null;
            }

        }

        public static List<Cliente> Listar()
        {
            string mCommandText = "SELECT cod_cliente, nombre, apellido, tipo_dni, dni  FROM Cliente where baja <> '1' Order By cod_Cliente";

            DAO mDAO = new DAO();

            DataSet mDs = mDAO.ExecuteDataSet(mCommandText);

            List<Cliente> LiClientes = new List<Cliente>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDs.Tables[0].Rows)
                {
                    Cliente BECliente = new Cliente();
                    ValorizarEntidad(BECliente, mDr);
                    LiClientes.Add(BECliente);
                }

            }
            return LiClientes;

        }

        internal static void ValorizarEntidad(Cliente pCliente, DataRow pDr)
        {
            pCliente.cod_Cliente = int.Parse(pDr["cod_Cliente"].ToString());
            pCliente.nombre = pDr["nombre"].ToString();
            pCliente.apellido = pDr["apellido"].ToString();
            pCliente.tipo_dni = pDr["tipo_dni"].ToString();
            pCliente.dni = int.Parse(pDr["dni"].ToString());

        }





        public static List<Cliente> Buscar(string pBuscar)
        {
            string mCommandText = "SELECT cod_cliente, nombre, apellido, tipo_dni, dni FROM Cliente where baja <> '1' and (nombre like '%" + pBuscar + "%' or apellido like '%"
                                   + pBuscar + "%' or email like '%" + pBuscar + "%' or dni like '%" + pBuscar + "%'  ) Order By cod_Cliente";

            DAO mDAO = new DAO();

            DataSet mDs = mDAO.ExecuteDataSet(mCommandText);

            List<Cliente> LiClientes = new List<Cliente>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDs.Tables[0].Rows)
                {
                    Cliente BECliente = new Cliente();
                    ValorizarEntidad(BECliente, mDr);
                    LiClientes.Add(BECliente);
                }

            }
            return LiClientes;

        }


    }
}
