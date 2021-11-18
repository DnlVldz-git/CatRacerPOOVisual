using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOVisual
{
    [Serializable]
    class Cuenta
    {
        private int id;
        private Double dineroInvertido;
        private Double dineroGanado;
        private Double dineroPerdido;
        private Double dineroTotal;

        public Cuenta(Double dineroInvertido)
        {
            this.DineroInvertido = dineroInvertido;
        }

        public Cuenta()
        {
            
        }

        public void calcularDineroTotal()
        {
            this.dineroTotal = this.dineroInvertido + (this.dineroGanado - this.dineroPerdido);
        }

        public void invertirDinero(Double dinero)
        {
            this.dineroInvertido += dinero;
            this.calcularDineroTotal();
        }

        public String Imprimir()
        {
            return ("Dinero Invertido: " + this.dineroInvertido + "\n Dinero Ganado: " + this.dineroGanado + "\n Dinero Perdido: " + this.dineroPerdido + "\n Dinero Total: " + this.dineroTotal);
        }

        public double DineroInvertido { get => dineroInvertido; set => dineroInvertido = value; }
        public double DineroGanado { get => dineroGanado; set => dineroGanado = value; }
        public double DineroPerdido { get => dineroPerdido; set => dineroPerdido = value; }
        public int Id { get => id; set => id = value; }

        public Double GetDineroTotal()
        {
            calcularDineroTotal();
            return this.dineroTotal;
        }
    }
}
