using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador
{
    static class Program
    {
        public static int Qtd_Termos_Tempo    = 0;
        public static int Qtd_Termos_Animacao = 0;
        public static int Qtd_Cont            = 1;

        public static int controleEspaco     = 0;
        public static int controleVelocidade = 0;
        public static int controleEnergia    = 0;
        public static int controleDados      = 0;
        public static int controleDadosX     = 0;

        public static int    calculos         = 0;
        public static string Planeta          = "";
        public static double Altura           = 0;
        public static double Gravidade        = 0;
        public static double Resistencia      = 0;
        public static double velicidadeini    = 0;
        public static double velicidadefinal  = 0;
      
        public static double massa            = 0;
        public static double tempo            = 0;

        public static double EnerginaCineticaMin  = 0;
        public static double EnerginaCineticaMax  = 0;
        public static double EnerginaPotencialMin = 0;
        public static double EnerginaPotencialMax = 0;

        public static double[] VetorEspaco;
        public static double[] VetorEspacoG; // Grafico

        public static double[] VetorVelocidade;
        public static double[] VetorVelocidadeG; // Grafico

        public static double[] VetorEnerginaCinetica;
        public static double[] VetorEnerginaCineticaG; // Grafico

        public static double[] VetorEnergiaPotencial;
        public static double[] VetorEnergiaPotencialG; // Grafico


        public static double[] VetorForcaArrasto;
        public static double velicidadeLimite  = 0;
        public static double EspacovelicidadeLimite = 0;
        public static double coeficienteArraso = 0;
        public static double TempoLimiteChao = 0;



        public static int[] VetorAnimacao = new int[5000]; // Grafico 

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
