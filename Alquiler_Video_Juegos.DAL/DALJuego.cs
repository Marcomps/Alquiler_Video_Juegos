using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Video_Juegos.DAL.Model
{
   public class DALJuego
    {
        public int AgregarJuego(object Juego)
        {
            using (var DBContext = new BDAlquiler_Video_JuegosEntities())
            {
                var Transaccion = DBContext.Database.BeginTransaction();

                try
                {
                    var Tabla = Juego as Juego;
                    DBContext.Juegos.Add(Tabla);
                    DBContext.SaveChanges();
                    Transaccion.Commit();
                    return Tabla.id_Juego;
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();

                    return 0;


                }
            }
        }

        public List<Juego> ObtenerJuego()
        {
            List<Juego> ListaJuego= new List<Juego>();

            try
            {
                using (var DBContext = new BDAlquiler_Video_JuegosEntities())
                {
                    ListaJuego = DBContext.Juegos.ToList();
                }
            }
            catch (Exception ex)
            {

                return null;

            }


            return ListaJuego;



        }

        public int ActualizarJuego(object Juego)
        {
            using (var DBContext = new BDAlquiler_Video_JuegosEntities())
            {
                var Transaccion = DBContext.Database.BeginTransaction();

                try
                {
                    var Tabla = Juego as Juego;
                    var Dato = DBContext.Juegos.FirstOrDefault(x => x.id_Juego == Tabla.id_Juego);
                    Dato.Nombre_Juego = Tabla.Nombre_Juego;
                    Dato.Tipo = Tabla.Tipo;
                    Dato.Descripcion_Juego = Tabla.Descripcion_Juego;

                    int result=DBContext.SaveChanges();
                    Transaccion.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();

                    return 0;


                }
            }
        }

    }
}
