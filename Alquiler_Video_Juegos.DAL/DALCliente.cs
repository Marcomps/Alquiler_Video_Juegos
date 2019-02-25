using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquiler_Video_Juegos.DAL.Model;

namespace Alquiler_Video_Juegos.DAL.Model
{
   public class DALCliente
    {
        public int AgregarCliente(object Cliente)
        {
            using (var DBContext = new BDAlquiler_Video_JuegosEntities())
            {
                var Transaccion = DBContext.Database.BeginTransaction();

                try
                {
                    var Tabla = Cliente as Cliente;
                    DBContext.Clientes.Add(Tabla);
                    DBContext.SaveChanges();
                    Transaccion.Commit();
                    return Tabla.id_Cliente;
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();

                    return 0;

                    
                }
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> ListaCliente = new List<Cliente>();

            try
            {
                using (var DBContext = new BDAlquiler_Video_JuegosEntities())
                {
                    ListaCliente = DBContext.Clientes.ToList();
                }
            }
            catch (Exception ex)
            {

                return null;
                
            }


            return ListaCliente;



        }
    }

}
