using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            texto();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.calculos = 0;
        }


        public void texto ()
        {
           
            RTBox.Text = " ----------------------------------------------------------------------------------------------\n";
            RTBox.Text += "  RESULTADOS\n";
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            RTBox.Text += " Astro     : " + Program.Planeta + "\n";
            RTBox.Text += " Gravidade : " + Program.Gravidade + " m/s^2\n";
            RTBox.Text += " Altura    : " + Program.Altura + " m\n";
            RTBox.Text += " Massa     : " + Program.massa + " kg\n";
            RTBox.Text += " Tempo     : " + Program.tempo + " s\n";
            if (Program.Resistencia == 1)
            {
                RTBox.Text += " Coeficiente de arrasto : " + Program.coeficienteArraso + " \n";
                RTBox.Text += " Velocidade limite      :" + Program.velicidadeLimite + " \n";
            }
            RTBox.Text += " Velocidade Inicial : " + Program.velicidadeini + " m/s\n";
            RTBox.Text += " Velocidade Final  : " + Program.velicidadefinal + " m/s\n";
            RTBox.Text += " Energia Cinetica Max  : " + Program.EnerginaCineticaMax + " j\n";
            RTBox.Text += " Energia Cinetica Min  : " + Program.EnerginaCineticaMin + " j\n";
            RTBox.Text += " Energia Potencial Max  : " + Program.EnerginaPotencialMax + " j\n";
            RTBox.Text += " Energia Potencial Min  : " + Program.EnerginaPotencialMin + " j\n";
            RTBox.Text += " Quantidade de posições : " + Program.Qtd_Termos_Tempo + " \n";


            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            //grafico();
        }

        public void grafico ()
        {
            int i;
            double temp = 0;
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            RTBox.Text += " Espaço\n";
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            for (i = 0; i < Program.Qtd_Termos_Tempo; i++)
            {
                RTBox.Text += " Espaço em T = [" + temp + "] s = " + Program.VetorEspaco[i] + " m\n";
                temp = temp + 0.01;
            }
            temp = 0;
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            RTBox.Text += " Espaço G\n";
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            for (i = 0; i < Program.Qtd_Termos_Tempo; i++)
            {
                RTBox.Text += " Espaço em T = [" + temp + "] s = " + Program.VetorEspacoG[i] + " m\n";
                temp = temp + 0.01;
            }
            temp = 0;
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            RTBox.Text += " Velocidade\n";
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            for (i = 0; i < Program.Qtd_Termos_Tempo; i++)
            {
                RTBox.Text += " Velocidade em T = [" + temp + "] s = " + Program.VetorVelocidade[i] + " m/s\n";
                temp = temp + 0.01;
            }
            temp = 0;
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            RTBox.Text += " Energia Cinetica\n";
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            for (i = 0; i < Program.Qtd_Termos_Tempo; i++)
            {
                RTBox.Text += " Eng. Cinetica em T = [" + temp + "] s = " + Program.VetorEnerginaCinetica[i] + " j\n";
                temp = temp + 0.01;
            }
            temp = 0;
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            RTBox.Text += " Energia Potencial\n";
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
            for (i = 0; i < Program.Qtd_Termos_Tempo; i++)
            {
                RTBox.Text += " Eng. Potencial em T = [" + temp + "] s = " + Program.VetorEnergiaPotencialG[i] + " j\n";
                temp = temp + 0.01;
            }
            temp = 0;
            RTBox.Text += " ----------------------------------------------------------------------------------------------\n";
        }

    }
}
