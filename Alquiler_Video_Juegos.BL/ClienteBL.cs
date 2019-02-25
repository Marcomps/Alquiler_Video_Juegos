using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquileres_Video_Juego.ENT;
using Alquiler_Video_Juegos.DAL;
using Alquiler_Video_Juegos.DAL.Model;
using System.Data;

namespace Alquiler_Video_Juegos.BL
{
    public class ClienteBL
    {
        DALCliente ClienteDAL = new DALCliente();
        ClienteENT ClienteENT = new ClienteENT();

        public List<ClienteENT> ObtenerRegistrosTodosUsuariosBD()
        {

            List<Cliente> ObtenerLista = ClienteDAL.ObtenerClientes();
            List<ClienteENT> Resultado = ObtenerLista.Select(Obj => new ClienteENT()
            {

                id_Cliente = Obj.id_Cliente,
                Nombre_Cliente=Obj.Nombre_Cliente,
                Direccion_Cliente =Obj.Direccion_Cliente,
                Tel_Cliente =Obj.Tel_Cliente

            }).ToList();

            return Resultado;

        }


        public int AgregarUsuarioBD(ClienteENT DatosUsuario)
        {
            return ClienteDAL.AgregarCliente(new Cliente()
            {
                id_Cliente = DatosUsuario.id_Cliente,
                Nombre_Cliente= DatosUsuario.Nombre_Cliente,
                Direccion_Cliente = DatosUsuario.Direccion_Cliente,
                Tel_Cliente = DatosUsuario.Tel_Cliente
            });
        }

    }
}
