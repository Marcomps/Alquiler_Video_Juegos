//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alquiler_Video_Juegos.DAL.Model
{
    using System;
    
    public partial class SP_HISTORIAL_POR_ID_Result
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