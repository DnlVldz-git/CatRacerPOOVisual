using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{
    class Juego
    {
        private String gato1;
        private String gato2;
        private String gato3;
        private String gatoSelec;
        private String ganador;
        private int[] num_gatos;
        private daoGatos daoG;
        private List<Gatos> gatos;

        public String PrintGato(int num)
        {
            return gatos[num].Nombre;
        }

        public void ObtenerGatosParticipantes()
        {
            daoG = new daoGatos();
            gatos = daoG.getAll();
            Random rnd = new Random();
            int gato1 = rnd.Next(gatos.Count);
            int gato2 = rnd.Next(gatos.Count);
            int gato3 = rnd.Next(gatos.Count);
            this.num_gatos = new int[3];
            num_gatos[0] = gato1;
            num_gatos[1] = gato2;
            num_gatos[2] = gato3;
            while (true)
            {
                if ((gato1 == gato2) || (gato1 == gato3) || (gato2 == gato3))
                {
                    gato1 = rnd.Next(gatos.Count);
                    gato2 = rnd.Next(gatos.Count);
                    gato3 = rnd.Next(gatos.Count);
                }
                else
                {
                    num_gatos[0] = gato1;
                    num_gatos[1] = gato2;
                    num_gatos[2] = gato3;
                    this.gato1 = PrintGato(gato1);
                    this.gato2 = PrintGato(gato2);
                    this.gato3 = PrintGato(gato3);
                    break;
                }
            }
        }

        public Boolean Jugar(Double dinero, Cuenta cuenta, int resp)
        {
            Random rnd = new Random();

            int ganador = rnd.Next(2);

            gatoSelec = PrintGato(num_gatos[resp-1]);

            this.ganador = PrintGato(num_gatos[ganador]);

            if (ganador == (resp - 1))
            {
                cuenta.DineroGanado += (dinero + (dinero / 2));
                cuenta.calcularDineroTotal();
                return true;
            }
            else
            {
                cuenta.DineroPerdido += (dinero);
                cuenta.calcularDineroTotal();
                return false;
            }
        }

        public String GetGato1()
        {
            return this.gato1;
        }

        public String GetGato2()
        {
            return this.gato2;
        }

        public String GetGato3()
        {
            return this.gato3;
        }

        public String GetGanador()
        {
            return this.ganador;
        }

        public String GetSelect()
        {
            return this.gatoSelec;
        }
    }
}
