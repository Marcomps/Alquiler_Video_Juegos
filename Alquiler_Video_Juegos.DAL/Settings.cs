using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_Video_Juegos.DAL
{
    public class Settings
    {
        public static string Version
        {
            get
            {
                string Version = string.Empty;
                try
                {
                    Version = ConfigurationManager.ConnectionStrings["Alquiler_Video_JuegosContext"].ConnectionString;
                }
                catch (Exception)
                {
                    Version = string.Empty;
                    // Log
                }

                return Version;
            }
        }
    }
}
