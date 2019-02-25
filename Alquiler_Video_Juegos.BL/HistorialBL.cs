using System;
using System.Collections.Generic;
using System.Linq;
using Alquileres_Video_Juego.ENT;
using Alquiler_Video_Juegos.DAL;
using Alquiler_Video_Juegos.DAL.Model;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Video_Juegos.BL
{
    public class HistorialBL
    {
        DALHistorial HistorialDAL = new DALHistorial();

        public List<HistorialENT> ObtenerHistorial(int IdCliente)
        {
            List<HistorialENT> Resultado = null;

            using (DALHistorial HistorialDAL = new DALHistorial())
            {
                List<SP_HISTORIAL_POR_ID_Result> ObtenerLista = HistorialDAL.ObtenerHistorial(IdCliente);

                Resultado = ObtenerLista.Select(Obj => new HistorialENT()
                {
                    Fecha_Entrega = Obj.FECHA_ENTREGA,
                    Fecha_Prestamo = Obj.FECHA_PRESTAMO,
                    IdCliente = Obj.IDCLIENTE,
                    IdHistorial = Obj.HISTORIAL,
                    IdJuego = Obj.ID_JUEGO

                }).ToList();
            }

            return Resultado;
        }
    }
}
