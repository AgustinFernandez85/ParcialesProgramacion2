using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enemigo : Personaje
    {

        #region Atributos
        private string objetivo;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor publico que asigna el objetivo y llama al base para asignar los demas atributos
        /// </summary>
        /// <param name="nombre"> nombre del enemigo</param>
        /// <param name="hab"> conjunto de habilidades del enemigo</param>
        /// <param name="objetivo"> string de el objetivo del enemigo</param>
        public Enemigo(string nombre, List<EHabilidades> hab, string objetivo) : base(nombre,hab) 
        {
            this.objetivo = objetivo;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve la frase con el nombre del villano
        /// </summary>
        protected override string Nombre 
        {
            get 
            {
                return $"Soy {this.nombre} y los voy a hacer pure";
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescribe el tostring para agregarle el objetivo del villano
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Objetivo: {this.objetivo}");
            return sb.ToString();
        }
        #endregion

    }
}
