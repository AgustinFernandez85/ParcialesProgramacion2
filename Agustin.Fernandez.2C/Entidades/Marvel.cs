using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Marvel
    {
        #region Atributo
        private static List<Personaje> listaPersonajes;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor privado que instancia la lista de personajes
        /// </summary>
        static Marvel() 
        {
            listaPersonajes = new List<Personaje>();
        }
        #endregion

        #region Propiedad
        /// <summary>
        /// Esta propiedad pregunta primero si esta el valor en la lista y si no esta lo agrega
        /// </summary>
        public static Personaje Personaje
        {
            set
            {
                if (Marvel.listaPersonajes != value) 
                {
                    Marvel.listaPersonajes.Add(value);
                }
            }
        }
        #endregion

        #region Metodo

        /// <summary>
        /// Este Metodo devuelve toda la informacion de cada personaje y establece un encabezado (avenger o enemigo) dependiendo su tipo
        /// </summary>
        /// <returns></returns>
        public static string MostrarInformacion() 
        {
            StringBuilder sb = new StringBuilder();
            foreach (Personaje item in listaPersonajes)
            {
                if (item is Avenger)
                {
                    sb.AppendLine("*****Avenger*****");
                    sb.AppendLine(item.ToString());
                }
                else if (item is Enemigo)
                {
                    sb.AppendLine("*****Enemigo*****");
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
        #endregion
    }
}
