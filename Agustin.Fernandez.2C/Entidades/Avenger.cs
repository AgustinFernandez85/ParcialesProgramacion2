using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avenger : Personaje
    {
        #region Atributos
        private EEquipamiento equipamiento;
        #endregion

        #region Constructor
        /// <summary>
        /// Asigna el equipamiento y llama al constructor base para asignar los demas atributos
        /// </summary>
        /// <param name="nombre">nombre del avenger</param>
        /// <param name="habilidades"> conjunto de habilidades del avenger</param>
        /// <param name="equip"> conjunto de equipamiento del avenger</param>
        public Avenger(string nombre, List<EHabilidades> habilidades, EEquipamiento equip) : base(nombre, habilidades) 
        {
            this.equipamiento = equip;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve la frase con el nombre del avenger 
        /// </summary>
        protected override string Nombre 
        {
            get 
            {
                return $"Mi nombre es {this.nombre} y si no puedo y si no puedo proteger la tierra, la vengaré";
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrescribe el metodo tostring y le agrega el equipamiento
        /// </summary>
        /// <returns>retorna el stringbuilder </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Equipamiento: {this.equipamiento}");
            return sb.ToString();
        }
        #endregion  
    }
}
