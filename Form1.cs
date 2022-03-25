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
    public partial class Form1 : Form
    {
        public static int controleSimulacao = 1; // controla botão 
        public static int controlePlaneta = 1; // controla botão 

        public static double VelocidadeFinal = 0;
        public static double EnerginaCineticaMin = 0;
        public static double EnerginaCineticaMax = 0;
        public static double EnerginaPotencialMin = 0;
        public static double EnerginaPotencialMax = 0;
        public static double Tempo = 0;

        public static int PassoX = 1;
        public static int InicioX = 0;
        public static int IntervaloX = 1;

        public static double QtdAnimacao = 0;
        public static int ContAnimacao = 0;

        public static int QtdTempo = 0;

        public static int cont = 0;
        public static int controleEspaco = 0;


        public static int tipodemovimento = 0;

        public static int controleIniciar = 0;

        public static int controleResistencia = 0;

        public static int construirgrafico = 1;
        public static int controlegrafico = 1; // btn
        public static int attgrafico = 0; // attgrafico

        public static int contImagem = 1;

        public static int Tipovelocidade = 0;

        public static double controleTempo = 0;
        public static int[] Ax = new int[15];

        public static int contQtd = 0;

        public static int controlGraphic = 0;

        public static int controleinicial = 0;

        Dados xDados = new Dados();

        public Form1()
        {
            InitializeComponent();
            redimensionarforme(1);
            gboxresultados.Text = "Créditos";
            timer1.Enabled = true;
            timerRadios.Enabled = true;
            RDBOX1.Checked = true;
            cmbPlaneta.Text = "Terra";
            txtAltura.Text = "100";
            txtgravit.Text = "9,8";
            txtVelocidadeFinal.Text = "0";
            txtVelocidadeInicial.Text = "0";
            txtMassa.Text = "10";
            RCTBoxResultado.Text = " -----------------------------------------------------------------------------\n Simulador de  queda livre\n -----------------------------------------------------------------------------\n Turma de Física de 2020:\n\n José Antonio \\ Paloma dos Santos \\ Pedro Lucas";
            Carregar();
            Program.Planeta = "Terra";
            timer2.Enabled = true;
            timerDesligaResistencia.Enabled = true;
        }
        public void Carregar()  // Concerta a posição dos objetos, reseta as variaveis, pega os dados das txt box e passa para o program C
        {

            pctBola.Location = new Point(183, 13);
            LBPlaneta.Location = new Point(211, 13);
            LBGravidade.Location = new Point(156, 13);
            PCBoxgravidade.Location = new Point(173, 13);

            controleEspaco = 0;
            QtdAnimacao = 0;
            ContAnimacao = 0;
            cont = 0;
            controleEspaco = 0;
            controleTempo = 0;
            contQtd = 0;


            Program.Altura = Convert.ToDouble(txtAltura.Text);
            Program.Gravidade = Convert.ToDouble(txtgravit.Text);
            Program.velicidadefinal = Convert.ToDouble(txtVelocidadeFinal.Text);
            Program.velicidadeini = Convert.ToDouble(txtVelocidadeInicial.Text);
            Program.massa = Convert.ToDouble(txtMassa.Text);
            Program.Planeta = cmbPlaneta.Text;
        }

        public void calcular()
        {
            if (Program.Resistencia == 0) // Calcula os dados no vacuo
            {
                if (Program.Resistencia == 0)
                {
                    Program.velicidadefinal = Math.Sqrt((Program.velicidadeini * Program.velicidadeini) + (2 * Program.Gravidade * Program.Altura));
                    Program.tempo = (Program.velicidadefinal - Program.velicidadeini) / Program.Gravidade;
                    Program.EnerginaCineticaMax = (Program.massa * (Program.velicidadefinal * Program.velicidadefinal) / 2);
                    Program.EnerginaCineticaMin = (Program.massa * (Program.velicidadeini * Program.velicidadeini) / 2);
                    Program.EnerginaPotencialMax = Program.massa * Program.Altura * Program.Gravidade;
                    Program.EnerginaPotencialMin = 0;
                    Program.Qtd_Termos_Tempo = Convert.ToInt32(Program.tempo / 0.01);
                }
            }
            if (Program.Resistencia == 1) // Calcula os dados com resistencia do ar
            {
                double Ax   = 0;
                double Ter1 = 0;
                double Ter2 = 0;
                double Ter3 = 0;
                double Ter4 = 0;
                Program.coeficienteArraso = 0.47;

                // Velocidade limite
                Ax = (Program.Altura * Program.coeficienteArraso) / Program.massa;
                Ter1 = Math.Sqrt(Program.massa / (Program.Gravidade * Program.coeficienteArraso));
                Ter2 = 0.693147 + Ax;
                Program.tempo = Ter1 * Ter2;
                // ----------------- //

                // Ter1 = Math.Sqrt(Program.massa / (Program.Gravidade * Program.coeficienteArraso));
                // Ter2 = Math.Pow(2.71, ((Program.Altura*Program.coeficienteArraso)/Program.massa));
                // Ter3 = Math.Sqrt ((Math.Pow(2.71, ((2*Program.Altura * Program.coeficienteArraso) / Program.massa)))-1);
                // Ter4 = Math.Log(Ter2 + Ter3);
                // Program.tempo = Ter1 * Ter4;
                // ----------------- //
                Program.velicidadeLimite = Math.Sqrt((Program.massa * Program.Gravidade) / Program.coeficienteArraso);
                Program.velicidadefinal = Program.velicidadeLimite;
                // Espaço onde o movimento é mudado
                Program.EspacovelicidadeLimite = ((Program.velicidadefinal * Program.velicidadefinal) - (Program.velicidadeini * Program.velicidadeini) / (2 * Program.Gravidade));
                // tempo do espaço limite ao chao
                Program.TempoLimiteChao = Program.EspacovelicidadeLimite * Program.velicidadefinal;
                Program.EnerginaCineticaMax = (Program.massa * (Program.velicidadefinal * Program.velicidadefinal) / 2);
                Program.EnerginaCineticaMin = (Program.massa * (Program.velicidadeini * Program.velicidadeini) / 2);
                Program.EnerginaPotencialMax = Program.massa * Program.Altura * Program.Gravidade;
                Program.EnerginaPotencialMin = 0;
            }
        }
        public static void limpar()
        {
            int i;
            for (i = 0; i < 5000; i++)
            {
                Program.VetorAnimacao[i] = 0;
            }
        }
        public static void animacao()
        {
            int i, contAnimacao = 0, unidade = 0, cont = 0;
            double QtdAx = 0, QtdMax = 0, Ax = 0;
            limpar();
            if (QtdTempo >= 288)
            {
                QtdAnimacao = Math.Round(Convert.ToDouble(QtdTempo) / 288, 1);

                QtdAx = QtdAnimacao;
                QtdMax = QtdAnimacao;

                for (i = 0; i < Program.Qtd_Termos_Tempo; i++)
                {
                    if (i < QtdMax)
                    {

                        Program.VetorAnimacao[i] = contAnimacao;
                    }
                    else
                    {
                        QtdMax = QtdMax + QtdAx;
                        contAnimacao = contAnimacao + 1;
                        Program.VetorAnimacao[i] = contAnimacao;
                    }
                }
                Program.Qtd_Termos_Animacao = contAnimacao;
            }
            else
            {
                Ax = 288 / QtdTempo;
                unidade = Convert.ToInt32(Ax);
                Console.WriteLine("Unidade: " + unidade);
                for (i = 0; i < Program.Qtd_Termos_Tempo; i++)
                {
                    Program.VetorAnimacao[i] = contAnimacao;
                    contAnimacao = contAnimacao + unidade;
                    cont = cont + 1;
                }
                QtdAnimacao = unidade;
                Program.Qtd_Termos_Animacao = cont;
            }
        }

        public void redimensionarforme(int op) // redimensiona a janela
        {
            if (op == 1) // fechado 
            {
                this.Size = new System.Drawing.Size(828, 354);
                groupBox1.Location = new Point(3, -3); // 3; -3
            }
            if (op == 2) // aberto
            {
                this.Size = new System.Drawing.Size(828, 720); // 3; 342
                groupBox1.Location = new Point(3, 363);
            }
        }
        // Simulãção
        private void button2_Click(object sender, EventArgs e)
        {
            tipodemovimento = 0;
            BTResistenciaAr.Enabled = true;
            BTNGraficos.Enabled = true;
            timer2.Enabled = false;
            Carregar();
            calcular();
            if (controleSimulacao == 1)
            {
                redimensionarforme(2);
                ReallyCenterToScreen();
                controleSimulacao = 0;
                BTSimulacao.Text = "Resetar Simulador";
                GBox2.Visible = true;
                RCTBoxResultado.Visible = false;
                Carregar();
                calcular();
                Preencher();
                grafic_Espaco();
                grafic_velocidade();
                grafic_Energia();
                BTNIniciar.Enabled = true;
                LBPlaentaNome.Text = Program.Planeta;
                LBGravidadeValor.Text = "G = " + Program.Gravidade + "m/s²";
                gboxresultados.Text = "Resultados";
                LBPlaneta.Text = " -> " + Math.Round(Program.Altura, 3) + "m";
                LBTempo.Text = "T = " + Math.Round(Program.tempo, 3) + "s";
                LBVelocidade.Text = "V = " + Math.Round(Program.velicidadefinal, 3) + "m/s";
                ECMax.Text = "Emax = " + Math.Round(Program.EnerginaCineticaMax, 3) + "J";
                ECMin.Text = "Emin = " + Math.Round(Program.EnerginaCineticaMin, 3) + "J";
                EPMax.Text = "Emax = " + Math.Round(Program.EnerginaPotencialMax, 3) + "J";
                EPMin.Text = "Emin = " + Math.Round(Program.EnerginaPotencialMin, 3) + "J";
                LBMassahue.Text = "M = " + Program.massa + "Kg";
            }
            else
            {
                Application.Restart();
            }
        }
        private void BTNResultados_Click(object sender, EventArgs e)
        {
            if (Program.calculos == 0)
            {
                Form2 x = new Form2();
                x.Show();
                Program.calculos = 1;
            }
        }
        private void BTNIniciar_Click(object sender, EventArgs e) // incia a simulação
        {
            double alt = 0;
            double Mas = 0;
            double Vel = 0;
            double Gra = 0;
            try
            {
                alt = Convert.ToDouble(txtAltura.Text);
                Mas = Convert.ToDouble(txtMassa.Text);
                Vel = Convert.ToDouble(txtVelocidadeInicial.Text);
                Gra = Convert.ToDouble(txtgravit.Text);
                timerDesligaResistencia.Enabled = false;
                if (controleIniciar == 0)
                {
                    if (Gra == 0)
                    {
                        LBPlaentaNome.Text = Program.Planeta;
                        LBGravidadeValor.Text = "G = 0 m/s²";
                        LBTempo.Text = "T = infinito s";
                        LBVelocidade.Text = "V = 0 m/s";
                        ECMax.Text = "Emax = 0 J";
                        ECMin.Text = "Emin = 0 J";
                        EPMax.Text = "Emax = 0 J";
                        EPMin.Text = "Emin = 0 J";
                        LBMassahue.Text = "M = " + Program.massa + "Kg";
                        LBPlaneta.Text = " -> " + Math.Round(Program.Altura, 3) + "m";
                    }
                    else
                    {
                        if (alt < 1001 && Mas < 1001 && Vel < 100 && Gra < 30 && Gra > 1.5)
                        {
                            Carregar();
                            calcular();
                            CarregarVetores();
                            LBPlaentaNome.Text = Program.Planeta;
                            LBGravidadeValor.Text = "G = " + Program.Gravidade + "m/s²";
                            LBTempo.Text = "T = " + Math.Round(Program.tempo, 3) + "s";
                            LBVelocidade.Text = "V = " + Math.Round(Program.velicidadefinal, 3) + "m/s";
                            ECMax.Text = "Emax = " + Math.Round(Program.EnerginaCineticaMax, 3) + "J";
                            ECMin.Text = "Emin = " + Math.Round(Program.EnerginaCineticaMin, 3) + "J";
                            EPMax.Text = "Emax = " + Math.Round(Program.EnerginaPotencialMax, 3) + "J";
                            EPMin.Text = "Emin = " + Math.Round(Program.EnerginaPotencialMin, 3) + "J";
                            LBMassahue.Text = "M = " + Program.massa + "Kg";
                            BTNParar.Enabled = true;
                            BTNContinuar.Enabled = false;
                            BTNAvancar.Enabled = false;
                            BTNVoltar.Enabled = false;
                            BTResistenciaAr.Enabled = false;
                            if (Program.Resistencia == 0)
                            {
                                timerEspaco.Enabled = true;
                            }
                            BTNIniciar.Enabled = false;
                            BTNIniciar.Text = "Reiniciar";
                            controleIniciar = 1;
                            BTNResultados.Enabled = true;
                            BTNResultados.Visible = true;
                            if (txtgravit.Text != "0")
                            {
                                controlGraphic = 1;
                            }
                        }
                        else
                        {
                            MessageBox.Show(" A altura deve ser menor que 1000 m\n A gravidade deve ser menor que 30 m/s^2\n A gravidade deve ser maior que 1,5 m/s^2\n A massa deve ser menor que 100 kg\n A velocidade inicial deve ser menor que 100 m/s");
                        }
                    }
                }
                else // Reiniciar
                {
                    alt = Convert.ToDouble(txtAltura.Text);
                    Mas = Convert.ToDouble(txtMassa.Text);
                    Vel = Convert.ToDouble(txtVelocidadeInicial.Text);
                    Gra = Convert.ToDouble(txtgravit.Text);
                    if (Gra == 0)
                    {
                        LBPlaentaNome.Text = "Outro";
                        LBGravidadeValor.Text = "G = 0 m/s²";
                        LBTempo.Text = "T = infinito s";
                        LBVelocidade.Text = "V = 0 m/s";
                        ECMax.Text = "Emax = 0 J";
                        ECMin.Text = "Emin = 0 J";
                        EPMax.Text = "Emax = 0 J";
                        EPMin.Text = "Emin = 0 J";
                        LBMassahue.Text = "M = " + Program.massa + "Kg";
                        LBPlaneta.Text = " -> " + Math.Round(Program.Altura, 3) + "m";
                        BTNParar.Enabled = false;
                        BTNContinuar.Enabled = true;
                        BTNAvancar.Enabled = false;
                        BTNVoltar.Enabled = false;
                        BTResistenciaAr.Enabled = false;
                        //timerEspacoResistencia.Enabled = true;
                        BTNIniciar.Enabled = false;
                        if (construirgrafico == 2)
                        {
                            construirgrafico = 1;
                        }
                        BTNResultados.Enabled = true;
                        BTNResultados.Visible = true;
                        tipodemovimento = 0;
                    }
                    else
                    {

                        if (alt < 1001 && Mas < 1001 && Vel < 100 && Gra < 30 && Gra > 1.5)
                        {
                            if (Program.Resistencia == 0) // Calcula os dados sem resistencia do ar
                            {
                                if (controleIniciar == 1)
                                {
                                    timerEspaco.Enabled = false;
                                    Carregar();
                                    calcular();
                                    CarregarVetores();
                                    LBPlaentaNome.Text = Program.Planeta;
                                    LBGravidadeValor.Text = "G = " + Program.Gravidade + "m/s²";
                                    LBTempo.Text = "T = " + Math.Round(Program.tempo, 3) + "s";
                                    LBVelocidade.Text = "V = " + Math.Round(Program.velicidadefinal, 3) + "m/s";
                                    ECMax.Text = "Emax = " + Math.Round(Program.EnerginaCineticaMax, 3) + "J";
                                    ECMin.Text = "Emin = " + Math.Round(Program.EnerginaCineticaMin, 3) + "J";
                                    EPMax.Text = "Emax = " + Math.Round(Program.EnerginaPotencialMax, 3) + "J";
                                    EPMin.Text = "Emin = " + Math.Round(Program.EnerginaPotencialMin, 3) + "J";
                                    LBMassahue.Text = "M = " + Program.massa + "Kg";
                                    LBPlaneta.Text = " -> " + Math.Round(Program.Altura, 3) + "m";
                                    BTNParar.Enabled = false;
                                    BTNContinuar.Enabled = true;
                                    BTNAvancar.Enabled = false;
                                    BTNVoltar.Enabled = false;
                                    //timerEspaco.Enabled = true;
                                    BTNIniciar.Enabled = false;
                                    if (construirgrafico == 2)
                                    {
                                        construirgrafico = 1;
                                    }
                                    BTNResultados.Enabled = true;
                                    BTNResultados.Visible = true;
                                    tipodemovimento = 0;
                                }
                            }
                            else
                            {
                                if (controleIniciar == 1) // Calcula os dados com  resistencia do ar
                                {
                                    timerEspaco.Enabled = false;
                                    Console.WriteLine("Ligouuu");
                                    Carregar();
                                    calcular();
                                    CarregarVetoresResistencia();
                                    LBPlaentaNome.Text = Program.Planeta;
                                    LBGravidadeValor.Text = "G = " + Program.Gravidade + "m/s²";
                                    LBTempo.Text = "T = " + Math.Round(Program.tempo, 3) + "s";
                                    LBVelocidade.Text = "V = " + Math.Round(Program.velicidadefinal, 3) + "m/s";
                                    ECMax.Text = "Emax = " + Math.Round(Program.EnerginaCineticaMax, 3) + "J";
                                    ECMin.Text = "Emin = " + Math.Round(Program.EnerginaCineticaMin, 3) + "J";
                                    EPMax.Text = "Emax = " + Math.Round(Program.EnerginaPotencialMax, 3) + "J";
                                    EPMin.Text = "Emin = " + Math.Round(Program.EnerginaPotencialMin, 3) + "J";
                                    LBMassahue.Text = "M = " + Program.massa + "Kg";
                                    LBPlaneta.Text = " -> " + Math.Round(Program.Altura, 3) + "m";
                                    BTNParar.Enabled = true;
                                    BTNContinuar.Enabled = true;
                                    BTNAvancar.Enabled = false;
                                    BTNVoltar.Enabled = false;
                                    //timerEspacoResistencia.Enabled = true;
                                    BTNIniciar.Enabled = false;
                                    if (construirgrafico == 2)
                                    {
                                        construirgrafico = 1;
                                    }
                                    BTNResultados.Enabled = true;
                                    BTNResultados.Visible = true;
                                    tipodemovimento = 1;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(" A altura deve ser menor que 1000 m\n A gravidade deve ser menor que 30 m/s^2\n A massa deve ser menor que 100 kg\n A velocidade inicial deve ser menor que 100 m/s");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro !!! Caracteres não permitos ou numeros muito grandes !!!");
            }
        }
        private void BTNParar_Click(object sender, EventArgs e)
        {
            BTNVoltar.Enabled = true;
            BTNAvancar.Enabled = true;
            BTNIniciar.Enabled = true;
            BTNParar.Enabled = false;
            BTNContinuar.Enabled = true;
            timerEspaco.Enabled = false;
            timerEspacoResistencia.Enabled = false;
            BTResistenciaAr.Enabled = true;
        }

        private void BTNContinuar_Click(object sender, EventArgs e)
        {
            if (Program.Resistencia == 0 && tipodemovimento == 0)
            {
                BTNVoltar.Enabled = false;
                BTNAvancar.Enabled = false;
                BTNIniciar.Enabled = false;
                BTNParar.Enabled = true;
                BTNContinuar.Enabled = false;
                timerEspaco.Enabled = true;
                BTResistenciaAr.Enabled = false;
            }
            else
            {
                if (Program.Resistencia == 1 && tipodemovimento == 1)
                {
                    BTNVoltar.Enabled = false;
                    BTNAvancar.Enabled = false;
                    BTNIniciar.Enabled = false;
                    BTNParar.Enabled = true;
                    BTNContinuar.Enabled = false;
                    timerEspacoResistencia.Enabled = true;
                    BTResistenciaAr.Enabled = false;
                }
                else
                {
                    if (Program.Resistencia == 0 && tipodemovimento == 1)
                    {
                        BTResistenciaAr.Text = "Resistência atm [On]";
                        Program.Resistencia = 1;
                        controleResistencia = 1;
                        BTNVoltar.Enabled = false;
                        BTNAvancar.Enabled = false;
                        BTNIniciar.Enabled = false;
                        BTNParar.Enabled = true;
                        BTNContinuar.Enabled = false;
                        //timerEspaco.Enabled = true;
                        BTResistenciaAr.Enabled = false;
                    }
                    else
                    {
                        if (Program.Resistencia == 1 && tipodemovimento == 0)
                        {
                            BTResistenciaAr.Text = "Resistência atm [Off]";
                            Program.Resistencia = 0;
                            controleResistencia = 0;
                            BTNVoltar.Enabled = false;
                            BTNAvancar.Enabled = false;
                            BTNIniciar.Enabled = false;
                            BTNParar.Enabled = true;
                            BTNContinuar.Enabled = false;
                            timerEspaco.Enabled = true;
                            BTResistenciaAr.Enabled = false;
                        }
                    }
                }
            }
        }
        // Calcular
        private void button1_Click(object sender, EventArgs e)
        {
            Resultadostexto(); // exibe os valores obtidos
        }
        protected void ReallyCenterToScreen() // centraliza a janela
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
        private void timerRadios_Tick(object sender, EventArgs e)
        {
            if (RDBOX1.Checked == true)
            {
                //txtVelocidadeInicial.Text = "0";
                //txtVelocidadeFinal.Text   = "0";
            }
            if (RDBOX2.Checked == true)
            {
                //txtVelocidadeFinal.Text   = "0";
                //txtVelocidadeInicial.Text = "0";
            }
        }
        private void Resultadostexto() // exibe os principais resultados
        {
            RCTBoxResultado.Text = " -----------------------------------------------------------------------------\n";
            RCTBoxResultado.Text += " Dados iniciais\n";
            RCTBoxResultado.Text += " -----------------------------------------------------------------------------\n";
            RCTBoxResultado.Text += " Tempo: " + Program.tempo + " s\n";
            RCTBoxResultado.Text += " Velocidade inicial: " + Program.velicidadeini + " m/s\n";
            RCTBoxResultado.Text += " Velocidade Final: " + Program.velicidadefinal + " m/s\n";
            RCTBoxResultado.Text += " Energia Cinética Minima: " + Program.EnerginaCineticaMin + " J\n";
            RCTBoxResultado.Text += " Energia Cinética Máxima: " + Program.EnerginaCineticaMax + " J\n";
            RCTBoxResultado.Text += " Energia Potêncial Minima: " + Program.EnerginaPotencialMin + " J\n";
            RCTBoxResultado.Text += " Energia Potêncial Máxima: " + Program.EnerginaPotencialMax + " J\n";
            RCTBoxResultado.Text += " -----------------------------------------------------------------------------\n";
        }
        private void button1_Click_1(object sender, EventArgs e) // botão corpo, muda a imagem do objeto que cai 
        {
            contImagem = contImagem + 1;
            if (contImagem == 1)
            {
                pctBola.ImageLocation = (@"ball\ball.png");
            }
            if (contImagem == 2)
            {
                pctBola.ImageLocation = (@"ball\ball2.png");
            }
            if (contImagem == 3)
            {
                pctBola.ImageLocation = (@"ball\pokeball.png");
            }
            if (contImagem == 4)
            {
                pctBola.ImageLocation = (@"ball\granada.png");
            }
            if (contImagem == 5)
            {
                pctBola.ImageLocation = (@"ball\img1.png");
            }
            if (contImagem == 6)
            {
                pctBola.ImageLocation = (@"ball\img2.png");
            }
            if (contImagem == 7)
            {
                pctBola.ImageLocation = (@"ball\img3.png");
            }
            if (contImagem == 8)
            {
                pctBola.ImageLocation = (@"ball\img4.png");
            }
            if (contImagem == 9)
            {
                pctBola.ImageLocation = (@"ball\img5.png");
            }
            if (contImagem == 10)
            {
                pctBola.ImageLocation = (@"ball\img6.png");
            }
            if (contImagem == 11)
            {
                contImagem = 1;
                pctBola.ImageLocation = (@"ball\ball.png");
            }
        }
        private void BTNGraficos_Click(object sender, EventArgs e) // liga e desliga os graficos
        {
            if (controlegrafico == 0)
            {
                BTNGraficos.Text = "G Off";
                construirgrafico = 1;
                controlegrafico = 1;
            }
            else
            {
                if (controlegrafico == 1)
                {

                    BTNGraficos.Text = "G On";
                    construirgrafico = 0;
                    controlegrafico = 0;
                }
            }
        }
        private void timerEspacoResistencia_Tick(object sender, EventArgs e)
        {
            int espacodiv = 0;
            int velocidadediv = 0;
            int Energiadiv = 0;
            controleTempo = controleTempo + 0.01;
            controleEspaco = controleEspaco - 1;
            if (controleTempo <= Program.tempo)
            {
                LBPlaneta.Text = " -> " + Math.Round(Program.VetorEspaco[controleEspaco], 3) + "m";
                txtEspaco.Text = "" + Math.Round(Program.VetorEspaco[controleEspaco], 3);
                textTempo.Text = "" + Math.Round(controleTempo, 2);
                txtVelocidade.Text = "" + Math.Round(Program.VetorVelocidadeG[controleEspaco], 3);
                txtEnergiaCinetica.Text = "" + Math.Round(Program.VetorEnerginaCineticaG[controleEspaco], 3);
                txtEnergiaPotencial.Text = "" + Math.Round(Program.VetorEnergiaPotencial[controleEspaco], 3);
                if (construirgrafico == 0)
                {
                    chartEspaco.Series.Clear();
                    chartVelocidade.Series.Clear();
                    chartEnergia.Series.Clear();

                    if (Tipovelocidade == 0)
                    {
                        espacodiv = Convert.ToInt32(Math.Round(Program.Altura, 0) / 5);
                        velocidadediv = Convert.ToInt32(Math.Round(Program.velicidadefinal, 0) / 5);
                        Energiadiv = Convert.ToInt32(Math.Round(Program.EnerginaPotencialMax, 0) / 5);

                        grafic_Continuos_velocidade(cont, 0, Program.velicidadefinal + 20, velocidadediv, 0, ((Program.tempo * 100) + 20), 0);
                        grafic_Continuos_Espaco(cont, 0, Program.Altura + 20, espacodiv, 0, ((Program.tempo * 100) + 20), 0);
                        grafic_Continuos_Energia(cont, 0, Program.EnerginaPotencialMax + 200, Energiadiv, 0, ((Program.tempo * 100) + 20), 0);
                    }
                }
                else
                {
                    if (construirgrafico == 1)
                    {
                        chartEspaco.Series.Clear();
                        chartVelocidade.Series.Clear();
                        chartEnergia.Series.Clear();

                        if (Tipovelocidade == 0)
                        {
                            espacodiv = Convert.ToInt32(Math.Round(Program.Altura, 0) / 5);
                            velocidadediv = Convert.ToInt32(Math.Round(Program.velicidadefinal, 0) / 5);
                            Energiadiv = Convert.ToInt32(Math.Round(Program.EnerginaPotencialMax, 0) / 5);

                            grafic_Continuos_velocidade(QtdTempo + 1, 0, Program.velicidadefinal + 20, velocidadediv, 0, ((Program.tempo * 100) + 20), 0);
                            grafic_Continuos_Espaco(QtdTempo + 1, 0, Program.Altura + 20, espacodiv, 0, ((Program.tempo * 100) + 20), 0);
                            grafic_Continuos_Energia(QtdTempo + 1, 0, Program.EnerginaPotencialMax + 200, Energiadiv, 0, ((Program.tempo * 100) + 20), 0);
                        }
                        
                        construirgrafico = 2;
                    }
                }
                pctBola.Location = new Point(183, 13 + Program.VetorAnimacao[ContAnimacao]);
                LBPlaneta.Location = new Point(211, 13 + Program.VetorAnimacao[ContAnimacao]);
                LBGravidade.Location = new Point(156, 13 + Program.VetorAnimacao[ContAnimacao]);
                PCBoxgravidade.Location = new Point(173, 13 + Program.VetorAnimacao[ContAnimacao]);
                ContAnimacao = ContAnimacao + 1;
            }
            else
            {
                timerEspacoResistencia.Enabled = false;
            }
            cont = cont + 1;
        }
        private void timerEspaco_Tick(object sender, EventArgs e) // timer que controla tudo 
        {
            int espacodiv = 0;
            int velocidadediv = 0;
            int Energiadiv = 0;
            controleTempo = controleTempo + 0.01;
            controleEspaco = controleEspaco - 1;
            if (controleTempo <= Program.tempo)
            {
                LBPlaneta.Text = " -> " + Math.Round(Program.VetorEspaco[controleEspaco], 3) + "m";
                txtEspaco.Text = "" + Math.Round(Program.VetorEspaco[controleEspaco], 3);
                textTempo.Text = "" + Math.Round(controleTempo, 2);
                txtVelocidade.Text = "" + Math.Round(Program.VetorVelocidadeG[controleEspaco], 3);
                txtEnergiaCinetica.Text = "" + Math.Round(Program.VetorEnerginaCineticaG[controleEspaco], 3);
                txtEnergiaPotencial.Text = "" + Math.Round(Program.VetorEnergiaPotencial[controleEspaco], 3);
                if (construirgrafico == 0)
                {
                    chartEspaco.Series.Clear();
                    chartVelocidade.Series.Clear();
                    chartEnergia.Series.Clear();
                    if (Tipovelocidade == 0)
                    {
                        espacodiv = Convert.ToInt32(Math.Round(Program.Altura, 0) / 5);
                        velocidadediv = Convert.ToInt32(Math.Round(Program.velicidadefinal, 0) / 5);
                        Energiadiv = Convert.ToInt32(Math.Round(Program.EnerginaCineticaMax, 0) / 5);

                        grafic_Continuos_velocidade(cont, 0, Program.velicidadefinal + 20, velocidadediv, 0, ((Program.tempo * 100) + 20), 0);
                        grafic_Continuos_Espaco(cont, 0, Program.Altura + 20, espacodiv, 0, ((Program.tempo * 100) + 20), 0);
                        grafic_Continuos_Energia(cont, 0, Program.EnerginaCineticaMax + 200, Energiadiv, 0, ((Program.tempo * 100) + 20), 0);
                    }
                    else
                    {
                        if (Tipovelocidade == 1)
                        {
                            espacodiv = Convert.ToInt32(Math.Round(Program.Altura, 0) / 5);
                            velocidadediv = Convert.ToInt32(Math.Round(Program.velicidadefinal, 0) / 5);
                            Energiadiv = Convert.ToInt32(Math.Round(Program.EnerginaCineticaMax, 0) / 5);
                            grafic_Continuos_velocidade(cont, 0, Program.velicidadefinal + 20, velocidadediv, 0, ((Program.tempo * 100) + 20), 0);
                            grafic_Continuos_Espaco(cont, 0, Program.Altura + 20, espacodiv, 0, ((Program.tempo * 100) + 20), 0);
                            grafic_Continuos_Energia(cont, 0, Program.EnerginaCineticaMax + 200, Energiadiv, 0, ((Program.tempo * 100) + 20), 0);
                        }

                    }
                }
                else
                {
                    if (construirgrafico == 1)
                    {
                        chartEspaco.Series.Clear();
                        chartVelocidade.Series.Clear();
                        chartEnergia.Series.Clear();
                        if (Tipovelocidade == 0)
                        {
                            espacodiv = Convert.ToInt32(Math.Round(Program.Altura, 0) / 5);
                            velocidadediv = Convert.ToInt32(Math.Round(Program.velicidadefinal, 0) / 5);
                            Energiadiv = Convert.ToInt32(Math.Round(Program.EnerginaCineticaMax, 0) / 5);
                            grafic_Continuos_velocidade(QtdTempo + 1, 0, Program.velicidadefinal + 20, velocidadediv, 0, ((Program.tempo * 100) + 20), 0);
                            grafic_Continuos_Espaco(QtdTempo + 1, 0, Program.Altura + 20, espacodiv, 0, ((Program.tempo * 100) + 20), 0);
                            grafic_Continuos_Energia(QtdTempo + 1, 0, Program.EnerginaCineticaMax + 200, Energiadiv, 0, ((Program.tempo * 100) + 20), 0);
                        }
                        else
                        {
                            if (Tipovelocidade == 1)
                            {
                                espacodiv = Convert.ToInt32(Math.Round(Program.Altura, 0) / 5);
                                velocidadediv = Convert.ToInt32(Math.Round(Program.velicidadefinal, 0) / 5);
                                Energiadiv = Convert.ToInt32(Math.Round(Program.EnerginaCineticaMax, 0) / 5);
                                grafic_Continuos_velocidade(QtdTempo + 1, 0, Program.velicidadefinal + 20, velocidadediv, 0, ((Program.tempo * 100) + 20), 0);
                                grafic_Continuos_Espaco(QtdTempo + 1, 0, Program.Altura + 20, espacodiv, 0, ((Program.tempo * 100) + 20), 0);
                                grafic_Continuos_Energia(QtdTempo + 1, 0, Program.EnerginaCineticaMax + 200, Energiadiv, 0, ((Program.tempo * 100) + 20), 0);
                            }
                        }
                        construirgrafico = 2;
                    }
                }
                pctBola.Location = new Point(183, 13 + Program.VetorAnimacao[ContAnimacao]);
                LBPlaneta.Location = new Point(211, 13 + Program.VetorAnimacao[ContAnimacao]);
                LBGravidade.Location = new Point(156, 13 + Program.VetorAnimacao[ContAnimacao]);
                PCBoxgravidade.Location = new Point(173, 13 + Program.VetorAnimacao[ContAnimacao]);
                ContAnimacao = ContAnimacao + 1;
            }
            else
            {
                timerEspaco.Enabled = false;
            }
            cont = cont + 1;
        }
        private void CarregarVetores() // carrega os vetores com os dados
        {
            int i, cont = 0;
            double tempo = 0;
            double QtdTempox = Program.tempo / (0.01);
            QtdTempo = Convert.ToInt32(QtdTempox);
            Program.Qtd_Termos_Tempo = Convert.ToInt32(QtdTempo);
            Program.VetorEspaco = new double[QtdTempo + 2];
            Program.VetorEspacoG = new double[QtdTempo + 2];
            Program.VetorVelocidade = new double[QtdTempo + 2];
            Program.VetorVelocidadeG = new double[QtdTempo + 2];
            Program.VetorEnerginaCinetica = new double[QtdTempo + 2];
            Program.VetorEnerginaCineticaG = new double[QtdTempo + 2];
            Program.VetorEnergiaPotencial = new double[QtdTempo + 2];
            Program.VetorEnergiaPotencialG = new double[QtdTempo + 2];
            controleEspaco = QtdTempo;
            // Espaço 
            for (i = 0; i < QtdTempo + 1; i++)
            {
                Program.VetorEspaco[i] = ((Program.velicidadeini * tempo) + (Program.Gravidade * (tempo * tempo)) / 2);
                tempo = tempo + 0.01;
            }
            for (i = QtdTempo; i >= 0; i--)
            {
                Program.VetorEspacoG[cont] = Program.VetorEspaco[i];
                cont = cont + 1;
            }
            cont = 0;
            tempo = 0;
            // Velocidade
            for (i = 0; i < QtdTempo + 1; i++)
            {
                Program.VetorVelocidade[i] = (Program.velicidadeini + (Program.Gravidade * tempo));

                tempo = tempo + 0.01;
            }
            for (i = QtdTempo; i >= 0; i--)
            {
                Program.VetorVelocidadeG[i] = Program.VetorVelocidade[cont];
                cont = cont + 1;
            }
            cont = 0;
            tempo = 0;
            // Energia cinética
            for (i = 0; i < QtdTempo + 1; i++)
            {
                Program.VetorEnerginaCinetica[i] = (Program.massa * (Program.VetorVelocidade[i] * Program.VetorVelocidade[i]) / 2);
                tempo = tempo + 0.01;
            }
            for (i = QtdTempo; i >= 0; i--)
            {
                Program.VetorEnerginaCineticaG[i] = Program.VetorEnerginaCinetica[cont];
                cont = cont + 1;
            }
            cont = 0;
            tempo = 0;
            // Energia potencial 
            for (i = 0; i < QtdTempo + 1; i++)
            {
                Program.VetorEnergiaPotencial[i] = Program.massa * Program.VetorEspaco[i] * Program.Gravidade;
                tempo = tempo + 0.01;
            }
            for (i = QtdTempo; i >= 0; i--)
            {
                Program.VetorEnergiaPotencialG[i] = Program.VetorEnergiaPotencial[cont];
                cont = cont + 1;
            }
            // Animação
            animacao();
            cont = 0;
            tempo = 0;
        }

        private void CarregarVetoresResistencia() // carrega os vetores com os dados
        {
            int i, cont = 0;
            double tempo = 0;
            double Ax = 0;
            double term1 = 0, term2 = 0;
            double QtdTempox = Program.tempo / (0.01);
            QtdTempo = Convert.ToInt32(QtdTempox);
            Program.Qtd_Termos_Tempo = Convert.ToInt32(QtdTempo);
            Program.VetorEspaco = new double[QtdTempo + 2];
            Program.VetorEspacoG = new double[QtdTempo + 2];
            Program.VetorVelocidade = new double[QtdTempo + 2];
            Program.VetorVelocidadeG = new double[QtdTempo + 2];
            Program.VetorEnerginaCinetica = new double[QtdTempo + 2];
            Program.VetorEnerginaCineticaG = new double[QtdTempo + 2];
            Program.VetorEnergiaPotencial = new double[QtdTempo + 2];
            Program.VetorEnergiaPotencialG = new double[QtdTempo + 2];
            controleEspaco = QtdTempo;
            // Espaço 
            for (i = 0; i < QtdTempo + 1; i++)
            {
                term1 = (Program.Gravidade * Program.coeficienteArraso) / Program.massa;
                Ax = Math.Cosh((tempo * (Math.Sqrt(term1))));
                Program.VetorEspaco[i] = (Program.massa / Program.coeficienteArraso) * Math.Log(Ax);
                tempo = tempo + 0.01;
            }
            for (i = QtdTempo; i >= 0; i--)
            {
                Program.VetorEspacoG[cont] = Program.VetorEspaco[i];
                cont = cont + 1;
            }
            cont = 0;
            tempo = 0;
            // Velocidade
            for (i = 0; i < QtdTempo + 1; i++)
            {
                term1 = Math.Sqrt((Program.massa * Program.Gravidade) / Program.coeficienteArraso);
                term2 = (Program.Gravidade * Program.coeficienteArraso) / Program.massa;
                Ax = (tempo * (Math.Sqrt(term2)));
                Program.VetorVelocidade[i] = term1 * Math.Tanh(Ax);
                tempo = tempo + 0.01;
            }
            for (i = QtdTempo; i >= 0; i--)
            {
                Program.VetorVelocidadeG[i] = Program.VetorVelocidade[cont];
                cont = cont + 1;
            }
            cont = 0;
            tempo = 0;
            // Energia cinética
            for (i = 0; i < QtdTempo + 1; i++)
            {
                Program.VetorEnerginaCinetica[i] = (Program.massa * (Program.VetorVelocidade[i] * Program.VetorVelocidade[i]) / 2);
                tempo = tempo + 0.01;
            }
            for (i = QtdTempo; i >= 0; i--)
            {
                Program.VetorEnerginaCineticaG[i] = Program.VetorEnerginaCinetica[cont];
                cont = cont + 1;
            }
            cont = 0;
            tempo = 0;
            // Energia potencial 
            for (i = 0; i < QtdTempo + 1; i++)
            {
                Program.VetorEnergiaPotencial[i] = Program.massa * Program.VetorEspaco[i] * Program.Gravidade;
                tempo = tempo + 0.01;
            }
            for (i = QtdTempo; i >= 0; i--)
            {
                Program.VetorEnergiaPotencialG[i] = Program.VetorEnergiaPotencial[cont];
                cont = cont + 1;
            }
            // Animação
            animacao();
            cont = 0;
            tempo = 0;
        }
        // ---------------------------------------------------- //
        // chart

        public void Preencher()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Ax[i] = rnd.Next(1, 100);
            }
        }

        public void grafic_Espaco()
        {
            int i;
            string Serie = "Espaço";
            var chart = chartEspaco.ChartAreas[0];

            //PopText += 1;
            //Serie += " " + PopText;

            chartEspaco.Visible = true;
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 11;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 100;
            chart.AxisY.Interval = 10;
            chart.AxisX.Interval = 1;
            chartEspaco.Series.Add(Serie);
            chartEspaco.Series[Serie].ChartType = SeriesChartType.Spline;
            chartEspaco.Series[Serie].Color = Color.Blue;
            chartEspaco.Series[0].IsVisibleInLegend = false;
            for (i = 1; i < 11; i++)
            {
                chartEspaco.Series[Serie].Points.AddXY((i), Ax[i - 1]);
            }
        }

        public void grafic_velocidade()
        {
            int i;
            string Serie = "Velocidade";
            var chart = chartVelocidade.ChartAreas[0];
            chartVelocidade.Visible = true;
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 11;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 100;
            chart.AxisY.Interval = 10;
            chart.AxisX.Interval = 1;
            chartVelocidade.Series.Add(Serie);
            chartVelocidade.Series[Serie].ChartType = SeriesChartType.Spline;
            chartVelocidade.Series[Serie].Color = Color.Blue;
            chartVelocidade.Series[0].IsVisibleInLegend = false;
            for (i = 1; i < 11; i++)
            {
                chartVelocidade.Series[Serie].Points.AddXY((i), Ax[i - 1]);
            }
        }
        public void grafic_Energia()
        {
            int i;
            string Serie = "Energia cinética";
            string Serie2 = "Energia  potêncial";
            var chart = chartEnergia.ChartAreas[0];
            chartEnergia.Visible = true;
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 11;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 100;
            chart.AxisY.Interval = 10;
            chart.AxisX.Interval = 1;
            chartEnergia.Series.Add(Serie);
            chartEnergia.Series[Serie].ChartType = SeriesChartType.Spline;
            chartEnergia.Series[Serie].Color = Color.Blue;
            chartEnergia.Series.Add(Serie2);
            chartEnergia.Series[Serie2].ChartType = SeriesChartType.Spline;
            chartEnergia.Series[Serie2].Color = Color.Red;
            chartEnergia.Series[0].IsVisibleInLegend = false;
            for (i = 1; i < 11; i++)
            {
                chartEnergia.Series[Serie].Points.AddXY((i), Ax[i - 1]);
                chartEnergia.Series[Serie2].Points.AddXY((i), Ax[i + 1]);
            }
        }
        public void grafic_Continuos_Espaco(int n, double Mm, double MM, double InterY, double interX, double Max, double Mmx)
        {
            int i;
            string Serie = "Espaço";
            var chart = chartEspaco.ChartAreas[0];
            chartEspaco.Visible = true;
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
            chartEspaco.Series.Add(Serie);
            chartEspaco.Series[Serie].ChartType = SeriesChartType.Spline;
            chartEspaco.Series[Serie].Color = Color.Blue;
            for (i = 0; i < n; i++)
            {
                chartEspaco.Series[Serie].Points.AddXY((i), Program.VetorEspacoG[i]);
            }
        }
        public void grafic_Continuos_velocidade(int n, double Mm, double MM, double InterY, double interX, double Max, double Mmx)
        {
            int i;
            string Serie = "Velocidade";
            var chart = chartVelocidade.ChartAreas[0];
            chartVelocidade.Visible = true;
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
            chartVelocidade.Series.Add(Serie);
            chartVelocidade.Series[Serie].ChartType = SeriesChartType.Spline;
            chartVelocidade.Series[Serie].Color = Color.Blue;
            for (i = 0; i < n; i++)
            {
                chartVelocidade.Series[Serie].Points.AddXY((i), Program.VetorVelocidade[i]);
            }
        }
        public void grafic_Continuos_Energia(int n, double Mm, double MM, double InterY, double interX, double Max, double Mmx)
        {
            int i;
            string Serie = "Energia cinética";
            string Serie2 = "Energia  potêncial";
            var chart = chartEnergia.ChartAreas[0];
            chartEnergia.Visible = true;
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
            chartEnergia.Series.Add(Serie);
            chartEnergia.Series[Serie].ChartType = SeriesChartType.Line;
            chartEnergia.Series[Serie].Color = Color.Blue;
            chartEnergia.Series.Add(Serie2);
            chartEnergia.Series[Serie2].ChartType = SeriesChartType.Line;
            chartEnergia.Series[Serie2].Color = Color.Red;
            for (i = 0; i < n; i++)
            {
                chartEnergia.Series[Serie2].Points.AddXY((i), Program.VetorEnergiaPotencialG[i]);
                chartEnergia.Series[Serie].Points.AddXY((i), Program.VetorEnerginaCinetica[i]);

            }
        }
        // ----------------------------------------------------- //
        private void PCBOX1_Click(object sender, EventArgs e)
        {
            controlePlaneta += 1;
            Program.Qtd_Cont = controlePlaneta;
            if (controlePlaneta == 1)
            {
                cmbPlaneta.Text = "Terra";
            }
            if (controlePlaneta == 2)
            {
                cmbPlaneta.Text = "Lua";
            }
            if (controlePlaneta == 3)
            {
                cmbPlaneta.Text = "Mercúrio";
            }
            if (controlePlaneta == 4)
            {
                cmbPlaneta.Text = "Vênus";
            }
            if (controlePlaneta == 5)
            {
                cmbPlaneta.Text = "Marte";
            }
            if (controlePlaneta == 6)
            {
                cmbPlaneta.Text = "Júpter";
            }
            if (controlePlaneta == 7)
            {
                cmbPlaneta.Text = "Saturno";
            }
            if (controlePlaneta == 8)
            {
                cmbPlaneta.Text = "Urano";
            }
            if (controlePlaneta == 9)
            {
                cmbPlaneta.Text = "Netuno";
            }
            if (controlePlaneta == 10)
            {
                cmbPlaneta.Text = "Plutão";
            }
            if (controlePlaneta == 11)
            {
                cmbPlaneta.Text = "Ganimedes";
            }
            if (controlePlaneta == 12)
            {
                cmbPlaneta.Text = "IO";
            }
            if (controlePlaneta == 13)
            {
                cmbPlaneta.Text = "Outro";
            }
            if (controlePlaneta == 14)
            {
                controlePlaneta = 1;
                cmbPlaneta.Text = "Terra";
            }
        }
        private void PCBOX2_Click(object sender, EventArgs e)
        {
            controlePlaneta -= 1;
            Program.Qtd_Cont = controlePlaneta;
            if (controlePlaneta == 1)
            {
                cmbPlaneta.Text = "Terra";
            }
            if (controlePlaneta == 2)
            {
                cmbPlaneta.Text = "Lua";
            }
            if (controlePlaneta == 3)
            {
                cmbPlaneta.Text = "Mercúrio";
            }
            if (controlePlaneta == 4)
            {
                cmbPlaneta.Text = "Vênus";
            }
            if (controlePlaneta == 5)
            {
                cmbPlaneta.Text = "Marte";
            }
            if (controlePlaneta == 6)
            {
                cmbPlaneta.Text = "Júpter";
            }
            if (controlePlaneta == 7)
            {
                cmbPlaneta.Text = "Saturno";
            }
            if (controlePlaneta == 8)
            {
                cmbPlaneta.Text = "Urano";
            }
            if (controlePlaneta == 9)
            {
                cmbPlaneta.Text = "Netuno";
            }
            if (controlePlaneta == 10)
            {
                cmbPlaneta.Text = "Plutão";
            }
            if (controlePlaneta == 11)
            {
                cmbPlaneta.Text = "Ganimedes";
            }
            if (controlePlaneta == 12)
            {
                cmbPlaneta.Text = "IO";
            }
            if (controlePlaneta == 13)
            {
                cmbPlaneta.Text = "Outro";
            }
            if (controlePlaneta == 0)
            {
                controlePlaneta = 11;
                cmbPlaneta.Text = "Outro";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmbPlaneta.Text == "Terra")
            {
                BNTPlaneta.Text = "Terra";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = true;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "9,8";
                controlePlaneta = 1;
                Program.Planeta = "Terra";
            }
            if (cmbPlaneta.Text == "Mercúrio")
            {
                BNTPlaneta.Text = "Mercúrio";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = true;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "3,7";
                controlePlaneta = 3;
                Program.Planeta = "Mercúrio";
            }
            if (cmbPlaneta.Text == "Vênus")
            {
                BNTPlaneta.Text = "Vênus";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = true;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "8,87";
                controlePlaneta = 4;
                Program.Planeta = "Vênus";
            }
            if (cmbPlaneta.Text == "Marte")
            {
                BNTPlaneta.Text = "Marte";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = true;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "3,71";
                controlePlaneta = 5;
                Program.Planeta = "Marte";
            }
            if (cmbPlaneta.Text == "Júpter")
            {
                BNTPlaneta.Text = "Júpter";
                PCBjupiter.Visible = true;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "24,79";
                controlePlaneta = 6;
                Program.Planeta = "Júpter";
            }
            if (cmbPlaneta.Text == "Urano")
            {
                BNTPlaneta.Text = "Urano";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = true;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "8,69";
                controlePlaneta = 8;
                Program.Planeta = "Urano";
            }
            if (cmbPlaneta.Text == "Netuno")
            {
                BNTPlaneta.Text = "Netuno";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = true;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "11,15";
                controlePlaneta = 9;
                Program.Planeta = "Netuno";
            }
            if (cmbPlaneta.Text == "Plutão")
            {
                BNTPlaneta.Text = "Plutão";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = true;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "0,62";
                controlePlaneta = 10;
                Program.Planeta = "Plutão";
            }
            if (cmbPlaneta.Text == "Lua")
            {
                BNTPlaneta.Text = "Lua";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = true;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "1,62";
                controlePlaneta = 2;
                Program.Planeta = "Lua";
            }
            if (cmbPlaneta.Text == "Saturno")
            {
                BNTPlaneta.Text = "Saturno";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = true;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                txtgravit.Text = "10,44";
                controlePlaneta = 7;
                Program.Planeta = "Saturno";
            }
            if (cmbPlaneta.Text == "Outro")
            {
                BNTPlaneta.Text = "Outro";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = true;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = false;
                controlePlaneta = 13;
            }
            if (cmbPlaneta.Text == "Ganimedes")
            {
                BNTPlaneta.Text = "Ganimedes";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = true;
                PCBoxIO.Visible = false;
                txtgravit.Text = "1.5";
                controlePlaneta = 11;
            }
            if (cmbPlaneta.Text == "IO")
            {
                BNTPlaneta.Text = "IO";
                PCBjupiter.Visible = false;
                PCBoxmarte.Visible = false;
                PCBoxsaturno.Visible = false;
                PCBoxurano.Visible = false;
                PCBoxvenus.Visible = false;
                PCBoxterra.Visible = false;
                PCBoxmercurio.Visible = false;
                PCBoxnetuno.Visible = false;
                PCBoxlua.Visible = false;
                PCBoxplutao.Visible = false;
                PCBoxoutro.Visible = false;
                PCBoxPandora.Visible = false;
                PCBoxIO.Visible = true;
                txtgravit.Text = "1,796";
                controlePlaneta = 12;
            }
        }
        private void chartEspaco_Click(object sender, EventArgs e)
        {
            if (Program.controleEspaco == 0 && controlGraphic == 1)
            {
                chartEspaco x = new chartEspaco();
                x.Show();
                Program.controleEspaco = 1;
            }
        }
        private void chart2_Click(object sender, EventArgs e)
        {
            if (Program.controleVelocidade == 0 && controlGraphic == 1)
            {
                chartVelocidade x = new chartVelocidade();
                x.Show();
                Program.controleVelocidade = 1;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            if (Program.controleEnergia == 0 && controlGraphic == 1)
            {
                chartEnergia x = new chartEnergia();
                x.Show();
                Program.controleEnergia = 1;
            }
        }
        private void RDBOX1_CheckedChanged(object sender, EventArgs e)
        {
            if (controleinicial == 1)
            {
                BTResistenciaAr.Enabled = true;
            }
            TimerConfigLanc.Enabled = false;
            controleinicial = 1;
            txtVelocidadeInicial.Text = "0";
            txtVelocidadeInicial.Enabled = false;
            Tipovelocidade = 0;
        }

        private void RDBOX2_CheckedChanged(object sender, EventArgs e)
        {
            TimerConfigLanc.Enabled = true;
            txtVelocidadeInicial.Enabled = true;
            txtVelocidadeInicial.Text = "10";
            Tipovelocidade = 1;
        }
        private void BNTPlaneta_Click(object sender, EventArgs e)
        {
            Program.Planeta = cmbPlaneta.Text;
            if (controlePlaneta != 13)
            {
                if (Program.controleDados == 0)
                {
                    Program.controleDadosX = 0;
                    Dados xDados = new Dados();
                    xDados.Show();
                    Program.controleDados = 1;
                }
                else
                {
                    if (Program.controleDados == 1)
                    {
                        Program.controleDadosX = 1;
                        Program.controleDados = 0;
                        System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(1000));
                        Dados xDados = new Dados();
                        xDados.Show();
                        Program.controleDados = 1;
                    }
                }
            }
        }
        private void BTResistenciaAr_Click(object sender, EventArgs e)
        {
            if (controleResistencia == 0)
            {
                BTResistenciaAr.Text = "Resistência atm [On]";
                Program.Resistencia = 1;
                controleResistencia = 1;
            }
            else
            {
                BTResistenciaAr.Text = "Resistência atm [Off]";
                Program.Resistencia = 0;
                controleResistencia = 0;
            }
        }
        private void TimerConfigLanc_Tick(object sender, EventArgs e)
        {
            Program.Resistencia = 0;
            BTResistenciaAr.Enabled = false;
            BTResistenciaAr.Text = "Resistencia atm [off]";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            RDBOX1.Checked = true;
        }
        private void RCTBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void RCTBoxResultado_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void RBTResistencia_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timerDesligaResistencia_Tick(object sender, EventArgs e)
        {
            BTResistenciaAr.Enabled = false;
        }
        // ------------- 
    }
}
