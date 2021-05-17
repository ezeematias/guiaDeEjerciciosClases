using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        /// <summary>
        /// Cosntructor de clase Llamada
        /// </summary>
        /// <param name="duracion">Tiempo de duracion de la llamada.</param>
        /// <param name="nroDestino">Número al cual de va a llamar.</param>
        /// <param name="nroOrigen">Número del cual se realiza la llamada.</param>
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        /// <summary>
        /// Gett del atributo duracion.
        /// </summary>
        public float Duracion
        {
            get { return this.duracion; }
        }

        /// <summary>
        /// Get del atriburo nroDestino.
        /// </summary>
        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        /// <summary>
        /// Get del atributo nroOrigen.
        /// </summary>
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        /// <summary>
        /// Get de clase para el costo de la llamada. 
        /// </summary>
        public abstract float CostoLlamada { get; }        

        /// <summary>
        /// Mostrar datos de la llamada.
        /// </summary>
        /// <returns>Un string con los datos.</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duración de la llamada: {this.Duracion}");
            sb.AppendLine($"Número de destino: {this.NroDestino}");
            sb.AppendLine($"Número de origen: {this.NroOrigen}");
            return sb.ToString();
        }

        /// <summary>
        /// Indica si cual de las llamadas fue más larga.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns>Retorna [1] si la duración es menor, [2] si es mayor, [0] si es igual.</returns>
        public static int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            int output = 0;
            if(llamada1.Duracion < llamada2.Duracion)
            {
                output = 1;
            }else if (llamada1.Duracion > llamada2.Duracion)
            {
                output = -1;
            }
            return output;
        }

        /// <summary>
        /// Sobrecarta del operador == para comparar dos llamadas.
        /// </summary>
        /// <param name="l1">Primer llamada</param>
        /// <param name="l2">Segunda llamada</param>
        /// <returns>True si las llamadas son iguales.</returns>
        public static bool operator == (Llamada l1, Llamada l2)
        {
            if(!(l1 is null) && !(l2 is null) && l1.Equals(l2))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador != para comparar dos llamadas.
        /// </summary>
        /// <param name="l1">Primer llamada</param>
        /// <param name="l2">Segunda llamada</param>
        /// <returns>True si las llamadas son distintas.</returns>
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


        /// <summary>
        /// Tipos de llamadas.
        /// </summary>
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }





    }
}
