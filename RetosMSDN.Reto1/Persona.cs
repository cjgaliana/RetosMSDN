using System;

namespace RetosMSDN.Reto1
{
    public class Persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }


        /// <summary>
        /// Determina cuando el <see cref="System.Object" /> especificado es igual a otra instancia
        /// </summary>
        /// <param name="obj">El <see cref="System.Object" /> para comparar con esta instancia.</param>
        /// <returns>
        ///   <c>true</c> si el <see cref="System.Object" /> es igual a esta isntancia; Si no, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Persona otraPersona = obj as Persona;
            if (otraPersona == null)
            {
                return false;
            }

            return this.Nombre == otraPersona.Nombre
                   && this.Edad == otraPersona.Edad;
        }

        /// <summary>
        /// Devuelve el codigo hash de esta instancia
        /// </summary>
        /// <returns>
        /// El codigo hash de esta instancia, apto para ser usado en algoritmos de hashing y estructuras de datos como una tabla hash
        /// </returns>
        public override int GetHashCode()
        {
            return Tuple.Create(this.Edad, this.Nombre).GetHashCode();
        }
    }
}