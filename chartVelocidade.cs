using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulador
{
    public partial class chartVelocidade : Form
    {
        public chartVelocidade()
        {
            InitializeComponent();
            construir();
        }

        private void chartVelocidade_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.controleVelocidade = 0;
        }

        private void chartVelocidade_Load(object sender, EventArgs e)
        {

        }

        public void construir()
        {
            int velocidadediv;
            Chart2.Series.Clear();
            velocidadediv = Convert.ToInt32(Math.Round(Program.velicidadefinal, 0) / 5);
            grafic_Continuos_velocidade(Program.Qtd_Termos_Tempo, 0, Program.velicidadefinal + 20, velocidadediv, 0, ((Program.tempo * 100) + 20), 0);
        }

        public void grafic_Continuos_velocidade(int n, double Mm, double MM, double InterY, double interX, double Max, double Mmx)
        {
            int i, x = 0;
            string Serie = "Velocidade";
            var chart = Chart2.ChartAreas[0];


            Chart2.Visible = true;
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = Mmx;
            chart.AxisX.Maximum = Max;

            chart.AxisY.Minimum = Mm;
            chart.AxisY.Maximum = MM;
            chart.AxisY.Interval = InterY;
            chart.AxisX.Interval = interX;

            Chart2.Series.Add(Serie);
            Chart2.Series[Serie].ChartType = SeriesChartType.Spline;
            Chart2.Series[Serie].Color = Color.Blue;

            //chartEspaco.Series[0].IsVisibleInLegend = false;


            if (n > 1000)
            {
                x = n / 100;
            }

            for (i = 0; i < n; i++)
            {
                if (x != 0)
                {
                    if (i % x == 0)
                    {
                        Chart2.Series[Serie].Points.AddXY((i), Program.VetorVelocidade[i]);
                    }
                }
                else
                {
                    Chart2.Series[Serie].Points.AddXY((i), Program.VetorVelocidade[i]);
                } 
            }
        }
    }
}
