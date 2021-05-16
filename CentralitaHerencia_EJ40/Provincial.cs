using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion,destino,origen))
        {
            this.franjaHoraria = miFranja;
        }
        
        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float output;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    output = base.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    output = base.Duracion * 1.25f;
                    break;
                default:
                    output = base.Duracion * 0.66f;
                    break;
            }
            return output;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());    
            sb.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");
            sb.AppendLine($"El franja horaria es: {this.franjaHoraria}");
            return sb.ToString();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

    }
}
