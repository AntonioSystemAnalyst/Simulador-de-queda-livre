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
    public partial class chartEnergia : Form
    {
        public chartEnergia()
        {
            InitializeComponent();
            construir();
        }

        private void chartEnergia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.controleEnergia = 0;
        }

        private void chartEnergia_Load(object sender, EventArgs e)
        {

        }

        public void construir()
        {
            int Energiadiv;
            Chart3.Series.Clear();
            Energiadiv = Convert.ToInt32(Math.Round(Program.EnerginaCineticaMax, 0) / 5);
            grafic_Continuos_Energia(Program.Qtd_Termos_Tempo, 0, Program.EnerginaPotencialMax + 200, Energiadiv, 0, ((Program.tempo * 100) + 20), 0);
        }


        public void grafic_Continuos_Energia(int n, double Mm, double MM, double InterY, double interX, double Max, double Mmx)
        {
            int i, x = 0;
            string Serie = "Energia cinética";
            string Serie2 = "Energia  potêncial";
            var chart = Chart3.ChartAreas[0];


            Chart3.Visible = true;
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

            Chart3.Series.Add(Serie);
            Chart3.Series[Serie].ChartType = SeriesChartType.Line;
            Chart3.Series[Serie].Color = Color.Blue;

            Chart3.Series.Add(Serie2);
            Chart3.Series[Serie2].ChartType = SeriesChartType.Line;
            Chart3.Series[Serie2].Color = Color.Red;

            //chartEnergia.Series[0].IsVisibleInLegend = false;
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
                        Chart3.Series[Serie].Points.AddXY((i), Program.VetorEnerginaCinetica[i]);
                        Chart3.Series[Serie2].Points.AddXY((i), Program.VetorEnergiaPotencialG[i]);
                    }
                }
                else
                {
                    Chart3.Series[Serie].Points.AddXY((i), Program.VetorEnerginaCinetica[i]);
                    Chart3.Series[Serie2].Points.AddXY((i), Program.VetorEnergiaPotencialG[i]); 
                }
            }
        }
    }
}
