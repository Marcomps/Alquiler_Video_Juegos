using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Video_Juegos.EN
{
    class HistorialEN
    {


        public int id_Historial { get; set; }
        public int id_Juego { get; set; }
        public int id_Cliente { get; set; }
        public Nullable<System.DateTime> Fecha_Prestamo { get; set; }
        public Nullable<System.DateTime> Fecha_Entrega { get; set; }


    }
}
