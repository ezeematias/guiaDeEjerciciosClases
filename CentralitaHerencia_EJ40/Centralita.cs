using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float output = 0;
            foreach (Llamada llamadas in listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if(llamadas is Local)
                        {
                            output += ((Local)llamadas).CostoLlamada;
                        }
                            break;
                    case Llamada.TipoLlamada.Provincial:
                        if(llamadas is Provincial)
                        {
                            output += ((Provincial)llamadas).CostoLlamada;
                        }
                        break;         
                    default:
                        if (llamadas is Local)
                        {
                            output += ((Local)llamadas).CostoLlamada;
                        }else  if (llamadas is Provincial)
                        {
                            output += ((Provincial)llamadas).CostoLlamada;
                        }                        
                        break;
                }
            }            
            return output;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia provincial: {this.GananciasPorProvincial}");
            sb.AppendLine("Llamadas realizadas: ");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }        
    }
}
