using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class Cliente
    {
        

        DAO dDao = new DAO();
        BE.Cliente BECliente = new BE.Cliente();

        public int Guardar(BE.Cliente pCliente)
        {

            int salida = ClienteDAL.Guardar(pCliente);

            return salida;

        }

        public int UltimoId(string Ptabla)
        {
            return dDao.ObtenerUltimoId(Ptabla);

        }

        public List<BE.Cliente> ListarCliente()
        {

            return ClienteDAL.Listar();
        }


        public BE.Cliente RecuperarCliente(int pId)
        {
            return ClienteDAL.Obtener(pId);

        }

        public int BajaCliente(BE.Cliente pCliente)
        {

            return ClienteDAL.Eliminar(pCliente);

        }

        


        public List<BE.Cliente> Buscar(string pBuscar)
        {
            return ClienteDAL.Buscar(pBuscar);
        }
    }
}
