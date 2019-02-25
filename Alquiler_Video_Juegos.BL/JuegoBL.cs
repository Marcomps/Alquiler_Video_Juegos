using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquileres_Video_Juego.ENT;
using Alquiler_Video_Juegos.DAL;
using Alquiler_Video_Juegos.DAL.Model;
using System.Data;
using Alquiler_Video_Juegos;

namespace Alquiler_Video_Juegos.BL
{
   public class JuegoBL
    {
        DALJuego JuegoDAL = new DALJuego();
        JuegoENT JuegoENT = new JuegoENT();

        public List<JuegoENT> ObtenerRegistros()
        {

            List<Juego> ObtenerLista = JuegoDAL.ObtenerJuego();
            List<JuegoENT> Resultado = ObtenerLista.Select(Obj => new JuegoENT()
            {

                id_Juego = Obj.id_Juego,
                Nombre_Juego = Obj.Nombre_Juego,
                Descripcion_Juego = Obj.Descripcion_Juego,
                Tipo = Obj.Tipo
      

            }).ToList();

            return Resultado;

        }


        public int AgregarJuegoBD(JuegoENT DatosJuego)
        {
            return JuegoDAL.AgregarJuego(new Juego()
            {


                id_Juego = DatosJuego.id_Juego,
                Nombre_Juego = DatosJuego.Nombre_Juego,
                Descripcion_Juego = DatosJuego.Descripcion_Juego,
                Tipo = DatosJuego.Tipo


            });
        }

    }
}
