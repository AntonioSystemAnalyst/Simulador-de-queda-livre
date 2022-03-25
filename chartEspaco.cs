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
    public partial class chartEspaco : Form
    {
        public chartEspaco()
        {
            InitializeComponent();
            construir();
        }

        private void chartEspaco_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.controleEspaco = 0;
        }

        private void chartEspaco_Load(object sender, EventArgs e)
        {

        }

        public void construir ()
        {
            int espacodiv;
            Chart1.Series.Clear();


            espacodiv = Convert.ToInt32(Math.Round(Program.Altura, 0) / 5);
       

            grafic_Continuos_Espaco(Program.Qtd_Termos_Tempo, 0, Program.Altura + 20, espacodiv, 0, ((Program.tempo * 100) + 20), 0);
        }

        public void grafic_Continuos_Espaco(int n, double Mm, double MM, double InterY, double interX, double Max, double Mmx)
        {
            int i, x  = 0;
            string Serie = "Espaço";
            var chart = Chart1.ChartAreas[0];


            Chart1.Visible = true;
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

            Chart1.Series.Add(Serie);
            Chart1.Series[Serie].ChartType = SeriesChartType.Spline;
            Chart1.Series[Serie].Color = Color.Blue;

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
                        Chart1.Series[Serie].Points.AddXY((i), Program.VetorEspacoG[i]);
                    }
                }
                else
                {
                    Chart1.Series[Serie].Points.AddXY((i), Program.VetorEspacoG[i]);
                }
            }
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
