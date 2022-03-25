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
    public partial class Testes : Form
    {
        public Testes()
        {
            InitializeComponent();
            construir();
        }

        private void Testes_Load(object sender, EventArgs e)
        {

        }

        public void construir()
        {
            int espacodiv;
            Chart1.Series.Clear();


            espacodiv = Convert.ToInt32(Math.Round(Program.Altura, 0) / 5);


            grafic_Continuos_Espaco(Program.Qtd_Termos_Tempo, 0, Program.Altura + 20, espacodiv, 0, (Program.tempo * 100), 0);
        }

        public void grafic_Continuos_Espaco(int n, double Mm, double MM, double InterY, double interX, double Max, double Mmx)
        {
            int i;
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
            Chart1.Series[Serie].ChartType = SeriesChartType.Line;
            Chart1.Series[Serie].Color = Color.Blue;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.0000";
            //chartEspaco.Series[0].IsVisibleInLegend = false;
            for (i = 0; i < n; i++)
            {
                Chart1.Series[Serie].Points.AddXY((i), Program.VetorEspacoG[i]);
            }
        }
    // --------------- //
}
}
