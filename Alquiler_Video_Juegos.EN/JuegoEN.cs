using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Video_Juegos.EN
{
    public class JuegoEN
    {
        public int id_Juego { get; set; }
        public string Nombre_Juego { get; set; }
        public string Descripcion_Juego { get; set; }
        public Nullable<int> Tipo { get; set; }
    }
}
