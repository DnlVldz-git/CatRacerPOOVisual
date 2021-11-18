using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{
    [Serializable]
    class Persona
    {
        private String nombre;
        private String sexo;
        private int edad;

        public Persona(String nombre, String sexo, int edad)
        {
            this.Nombre = nombre;
            if (edad >= 18)
            {
                this.Edad = edad;
            }
            else
            {
                throw new Exception("No tienes edad para apostar");
            }
            this.Sexo = sexo;

        }

        public virtual String Imprimir()
        {
            return ("Nombre: " + this.nombre + " Sexo: " + this.sexo + " Edad: " + this.edad);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
