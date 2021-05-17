using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        /// <summary>
        /// Constructor de la clase Local que llama a Llamada.
        /// </summary>
        /// <param name="llamada"></param>
        /// <param name="costo"></param>
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {           
            
        }

        /// <summary>
        /// Constructor de la clase Local que llama al constructor.
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="duracion"></param>
        /// <param name="destino"></param>
        /// <param name="costo"></param>
        public Local(string origen, float duracion, string destino, float costo) : base (duracion, destino, origen)
        {
            this.costo = costo;
        }

        /// <summary>
        /// Get del costo de llamada.
        /// </summary>
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        /// <summary>
        /// Muestra lso datos de la llamada.
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del ToString.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar();
        }

        /// <summary>
        /// Sobrecarga del Equlas.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj is Local);   
        }

        /// <summary>
        /// Calcula el costo de la llamada.
        /// </summary>
        /// <returns>Costo de llamada</returns>
        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }
    }
}
