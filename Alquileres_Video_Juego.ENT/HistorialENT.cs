using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres_Video_Juego.ENT
{
   public class HistorialENT
    {
        public int IdHistorial { get; set; }
        public int IdJuego { get; set; }
        public int IdCliente { get; set; }
        public Nullable<System.DateTime> Fecha_Prestamo { get; set; }
        public Nullable<System.DateTime> Fecha_Entrega { get; set; }
    }


    public class HistorialIDENT
    {
        public int HISTORIAL { get; set; }
        public Nullable<System.DateTime> FECHA_PRESTAMO { get; set; }
        public Nullable<System.DateTime> FECHA_ENTREGA { get; set; }
        public int IDCLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string TEL_CLIENTE { get; set; }
        public string DIRECION_CLIENTE { get; set; }
        public int ID_JUEGO { get; set; }
        public string NOMBRE_JUEGO { get; set; }
        public Nullable<int> TIPO { get; set; }
    }

}
