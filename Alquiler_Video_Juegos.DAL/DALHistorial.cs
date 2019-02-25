using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquiler_Video_Juegos.DAL.Model;
using System.Data.Entity;

namespace Alquiler_Video_Juegos.DAL.Model
{
    public class DALHistorial : IDisposable
    {
        private BDAlquiler_Video_JuegosEntities DBContext { get; set; }
        private DbContextTransaction Tran { get; set; }
        public List<Exception> Exceptions { get; set; }
        public DALHistorial()
        {
            DBContext = new BDAlquiler_Video_JuegosEntities();
            Tran = DBContext.Database.BeginTransaction();
            Exceptions = new List<Exception>();
        }

        public List<SP_HISTORIAL_POR_ID_Result> ObtenerHistorial(int IdCliente)
        {
            List<SP_HISTORIAL_POR_ID_Result> Listahistorial = null;// new List<SP_HISTORIAL_POR_ID_Result>();

            try
            {
                Listahistorial = DBContext.SP_HISTORIAL_POR_ID(IdCliente).ToList();
            }
            catch (Exception Ex)
            {
                Exceptions.Add(Ex);
            }

            return Listahistorial;
        }

        public void Dispose()
        {
            if (Exceptions.Count > 0)
            {
                Tran.Rollback();
            }
            else
            {
                DBContext.SaveChanges();
                Tran.Commit();
            }

            Tran.Dispose();
        }
    }
}
