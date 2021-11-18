using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOVisual
{
    [Serializable]
    class Usuario : Persona
    {        
        private List<Cuenta> cuenta;
        private String tipo;
        private String contra;
        private int id;
        private double cantidadApuesta;

        public Usuario(int id, Double dinero, String nombre, String sexo, int edad) : base(nombre, sexo, edad)
        {
            this.id = id;
            Cuenta cuentaTemp = new Cuenta(dinero);
            cuenta = new List<Cuenta>();
            cuenta.Add(cuentaTemp);
            DefinirTipo(dinero);
        }

        public String getSexo()
        {
            return base.Sexo;
        }

        public int getEdad()
        {
            return base.Edad;
        }

        public String getNombre()
        {
            return base.Nombre;
        }

        public String getContra()
        {
            return this.contra;
        }

        public void setContra(String contra)
        {
            this.contra = contra;
        }

        public void setCantidad(Double cantidad) 
        {
            this.cantidadApuesta = cantidad;
        }

        public Double getCantidad()
        {
            return this.cantidadApuesta;
        }

        public override String Imprimir()
        {
            return (base.Imprimir() + " Id: " + this.id + " Tipo de Cuenta: " + this.tipo + "\n" + cuenta.ElementAt(0).Imprimir());
        }

        public List<Cuenta> GetCuentas()
        {
            return this.cuenta;
        }

        public void SetCuentas(List<Cuenta> cuentas)
        {
            this.cuenta = cuentas;
        }

        public void AddCuenta(double dinero)
        {
            Cuenta cuentaTemp = new Cuenta(dinero);
            cuenta.Add(cuentaTemp);
        }


        public int GetId()
        {
            return this.id;
        }

        public String getTipo()
        {
            return this.tipo;
        }

        public void DefinirTipo(Double dinero)
        {
            if (dinero <= 100)
            {
                this.tipo = "normal";
            }
            else if ((dinero >= 101) && (dinero <= 500))
            {
                this.tipo = "ricachón";
            }
            else if ((dinero >= 501))
            {
                this.tipo = "big baller";
            }
        }


    }
}
