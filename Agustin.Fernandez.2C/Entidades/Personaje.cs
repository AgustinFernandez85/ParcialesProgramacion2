using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personaje
    {
        #region Atributos
        private List<EHabilidades> listaHabilidades;
        protected string nombre;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor privado inicializa la lista de habilidades
        /// </summary>
        private Personaje() 
        {
            listaHabilidades = new List<EHabilidades>();
        }
        /// <summary>
        /// Constructor publico que asigna el nombre y las habilidades
        /// </summary>
        /// <param name="nombre"> parametro que recibe el nombre del personaje</param>
        /// <param name="habilidades">parametro que recibe la lista de habilidades</param>
        public Personaje(string nombre, List<EHabilidades> habilidades): this()
        {
            listaHabilidades = habilidades;
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Esta propiedad llama al metodo sobreescrito y retorna la lista de habilidades
        /// </summary>
        private string ListaHabilidades
        {
            get
            {
                return this.listaHabilidades.ToString();
            }
        }
        protected abstract string Nombre 
        {
            get;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Este operador compara por el tipo y el nombre
        /// </summary>
        /// <param name="listaPersonaje">la lista de personajes para comparar</param>
        /// <param name="personaje">el personaje a ser buscado en la lista </param>
        /// <returns>true si son iguales, false si no</returns>
        public static bool operator ==(List<Personaje> listaPersonaje, Personaje personaje) 
        {
            for (int i = 0; i < listaPersonaje.Count; i++)
            {
                if (listaPersonaje[i].GetType() == personaje.GetType())
                {
                    if (listaPersonaje[i].Nombre == personaje.Nombre)
                    {
                        return true;
                    }
                }
                else 
                {
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// Si son iguales solamente retorna la lista sin modificar y si no agrega el personaje
        /// </summary>
        /// <param name="listaPersonaje">la lista a ser comparada con el pj</param>
        /// <param name="personaje">personaje a ser comparado en la lista</param>
        /// <returns> retorna lista sin modificacion en caso de igualdad y si no agrega el personaje y devuelve la lista modificada</returns>
        public static List<Personaje> operator +(List<Personaje> listaPersonaje, Personaje personaje)
        {
            if (listaPersonaje == personaje)
            {
                return listaPersonaje;
            }
            else 
            {
                listaPersonaje.Add(personaje);
            }
            return listaPersonaje;
        }

        /// <summary>
        /// Pregunta por la igualdad de lista/personaje y lo niega 
        /// </summary>
        /// <param name="listaPersonaje">la lista a ser comparada con el pj</param>
        /// <param name="personaje">personaje a ser comparado en la lista</param>
        /// <returns>devuelve true si son diferentes y false si son iguales</returns>
        public static bool operator !=(List<Personaje> listaPersonaje, Personaje personaje) 
        {
            return !(listaPersonaje == personaje);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescribe el tostring para devolver los datos del personaje
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine("Lista Habilidades");
            for (int i = 0; i < listaHabilidades.Count; i++)
            {
                sb.AppendLine($"{this.listaHabilidades[i]}");
            }
            return sb.ToString();
        }
        #endregion
    }

    public enum EHabilidades 
    {
        Volar,
        SuperFuerza,
        Resistencia,
        Rayos,
        Energia,
        InteligenciaSuperior,
        Sigilo,
        Astucia
    }

    public enum EEquipamiento 
    {
        Armadura,
        Escudo,
        Martillo,
        Arco,
        Transformacion,
        ArtesMarciales
    }
}
