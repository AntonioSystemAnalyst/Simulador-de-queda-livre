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
    public partial class Dados : Form
    {
        DataSet ds = null;
        DataTable dt = null;

        public string astro = Program.Planeta;
        public int controlePlaneta = 1;

        public static int ControleMenu = 0;

        public static string n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19;

        private void PCBOX2_Click(object sender, EventArgs e)
        {
            controlePlaneta -= 1;
            if (controlePlaneta == 1)
            {
                astro = "Terra";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 2)
            {
                astro = "Lua";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 3)
            {
                astro = "Mercúrio";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 4)
            {
                astro = "Vênus";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 5)
            {
                astro = "Marte";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 6)
            {
                astro = "Júpter";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 7)
            {
                astro = "Saturno";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 8)
            {
                astro = "Urano";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 9)
            {
                astro = "Netuno";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 10)
            {
                astro = "Plutão";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 11)
            {
                astro = "Ganímedes";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 12)
            {
                astro = "IO";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 13)
            {
                astro = "Deimos";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 14)
            {
                astro = "Phobos";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 15)
            {
                astro = "Europa";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 16)
            {
                astro = "Encéfalo";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 17)
            {
                astro = "Titã";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 18)
            {
                astro = "Ariel";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 19)
            {
                astro = "Oberon";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 20)
            {
                astro = "Proteu";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 21)
            {
                astro = "Tritão";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 22)
            {
                astro = "Caronte";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 23)
            {
                astro = "Hidra";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 0)
            {
                astro = "Hidra";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
                controlePlaneta = 23;
            }
        }

        private void PCBOX1_Click(object sender, EventArgs e)
        {
            controlePlaneta += 1;
            if (controlePlaneta == 1)
            {
                astro = "Terra";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 2)
            {
                astro = "Lua";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 3)
            {
                astro = "Mercúrio";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 4)
            {
                astro = "Vênus";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 5)
            {
                astro = "Marte";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 6)
            {
                astro = "Júpter";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 7)
            {
                astro = "Saturno";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 8)
            {
                astro = "Urano";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 9)
            {
                astro = "Netuno";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 10)
            {
                astro = "Plutão";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 11)
            {
                astro = "Ganímedes";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 12)
            {
                astro = "IO";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 13)
            {
                astro = "Deimos";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 14)
            {
                astro = "Phobos";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 15)
            {
                astro = "Europa";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 16)
            {
                astro = "Encéfalo";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 17)
            {
                astro = "Titã";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 18)
            {
                astro = "Ariel";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 19)
            {
                astro = "Oberon";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 20)
            {
                astro = "Proteu";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 21)
            {
                astro = "Tritão";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 22)
            {
                astro = "Caronte";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 23)
            {
                astro = "Hidra";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
            }
            if (controlePlaneta == 24)
            {
                controlePlaneta = 1;
                astro = "Terra";
                carrega_dados(astro);
                inicio();
                Flip();
                LBPlaneta.Text = "" + astro;
                controlePlaneta = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Focus();
           

            if (Program.controleDadosX == 1)
            {
                Program.controleDadosX = 0;
                this.Close();
                timer1.Enabled = false;
            }


        }

        private void LBPlaneta_Click(object sender, EventArgs e)
        {

        }

        public Dados()
        {
            InitializeComponent();
            timer1.Enabled = true;
            controlePlaneta = Program.Qtd_Cont;
            carrega_dados(astro);
            inicio();
            Flip();
            //controlePlaneta = 1;
            RTBox.SelectionAlignment = HorizontalAlignment.Center;
            
        }

        public void inicio ()
        {
            ds = new DataSet();
            dt = new DataTable();

            dt = GetCustomers();
            ds.Tables.Add(dt);

            DataView my_DataView = ds.Tables[0].DefaultView;
            this.dgwDados.DataSource = my_DataView;

            LBPlaneta.Text = "" + Program.Planeta;
        }

        private void Dados_Load(object sender, EventArgs e)
        {
           

          
        }

        public void carrega_dados (string Planeta)
        {
            RTBox.SelectionAlignment = HorizontalAlignment.Center;
            if (Planeta == "Mercúrio")
            {
                n1 = "74.797.000";
                n2 = "15.329,1";
                n3 = "2.439,7";
                n4 = "4.879,4";
                n5 = "57.909.227";
                n6 = "60.827.208.742 ";
                n7 = "3,3010 x 10^23 ";
                n8 = "5,427";
                n9 = "3,7";
                n10 = "15.300";
                n11 = "58,646";
                n12 = "0,2408467";
                n13 = "170.503";
                n14 = "0,20563593";
                n15 = "7 graus";
                n16 = "0 graus";
                n17 = "-173 / 427 °C ";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Menor planeta do Sistema Solar e também o mais próximo do sol, por conta do seu eixo perpendicular ao plano da órbita, não apresenta estações do ano, e alguns locais não recebem a luz do sol.Sua fina atmosfera é composta por átomos de árgon, néon e hélio. Sua superficie é relativamente semelhante à da Lua, com grandes crateras formadas pelo impacto dos meteoritos que atingiram o planeta.";
            }

            if (Planeta == "Vênus")
            {
                n1 = "460.234.317";
                n2 = "38.024,6";
                n3 = "6.051,8";
                n4 = "12.104";
                n5 = "108.209.475";
                n6 = "928.415.345.893";
                n7 = "4,8673 x 10^24";
                n8 = "5,243";
                n9 = "8,87";
                n10 = "37.296";
                n11 = "-243,018";
                n12 = "0,61519726";
                n13 = "126.074";
                n14 = "0,00677672";
                n15 = "3,39 graus";
                n16 = "177,3 graus (R.T.) ";
                n17 = "462 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " É o segundo planeta do Sistema Solar e o mais quente, com uma atmosfera espessa e tóxica cheia de dióxido de carbono, criando envolta nuvens espessas de ácido sulfúrico que prendem o calor, causando um efeito estufa descontrolado.É visivel a olho nu, o planeta 'emite' grande luz, diante desse fator é superado somente pela lua.";
            }

            if (Planeta == "Terra")
            {
                n1 = "510.064.472";
                n2 = "40.030,2";
                n3 = "6.371,00";
                n4 = "12.742";
                n5 = "149.598.262";
                n6 = "1.083.206.916.846 ";
                n7 = "5,9722 x 10^24";
                n8 = "5.513";
                n9 = "9,80665";
                n10 = "40.284";
                n11 = "1";
                n12 = "1";
                n13 = "107.218";
                n14 = "0,01671123";
                n15 = "0,00005 graus";
                n16 = "23,4393 graus";
                n17 = "-88 / 58 °C";
                n18 = "1";
                n19 = "não";
                RTBox.Text = " Nosso planeta onde vivemos,isso ocorre por conta da atmosfera, camada que protege-nos da forte radiação solar que atinge a Terra, permitindo que haja vida, tambem estando relacionado a localização do planeta, chamada zona habitavel. É o único lugar que conhecemos até agora que é habitado por seres vivos. Terra é o maior dos quatro planetas mais próximos do Sol,com base na classe de planetas rochosos do Cinturao de Asteroides. O nome Terra é uma palavra germânica, que significa 'o solo'.";
            }

            if (Planeta == "Marte")
            {
                n1 = "144.371.391";
                n2 = "21.296,9";
                n3 = "3.389,5";
                n4 = "6.779";
                n5 = "227.943.824";
                n6 = "163.115.609.799 ";
                n7 = "6,4169 x 10^23 ";
                n8 = "3.934";
                n9 = "3,71";
                n10 = "18.108";
                n11 = "1.026";
                n12 = "1.8808476";
                n13 = "86.677";
                n14 = "0,0933941";
                n15 = "1,85 graus";
                n16 = "25,2 garus";
                n17 = "-153 / 20 °C";
                n18 = "2";
                n19 = "não";
                RTBox.Text = " Marte é o quarto planeta a partir do Sol, descrito como o 'Planeta Vermelho', porque o óxido de ferro predominante em sua superfície lhe dá uma aparência avermelhada, por conta de sua temperatura não há possibilidade de existir água no estado líquido. Sua atmosfera muito rarefeita, é composta por gás carbônico, dióxido de carbono, nitrogênio, argônio, néon e oxigênio.";
            }

            if (Planeta == "Júpter")
            {
                n1 = "61.418.738.571";
                n2 = "439.263,8";
                n3 = "69.911";
                n4 = "139.820";
                n5 = "778.340.821";
                n6 = "1.431.281.810.739.360 ";
                n7 = "1.8981 x 10^27 ";
                n8 = "1.326";
                n9 = "24,79";
                n10 = "216.720";
                n11 = "0,41354";
                n12 = "11,862615";
                n13 = "47.002";
                n14 = "0,04838624";
                n15 = "1,304 graus";
                n16 = "3,1 graus";
                n17 = "-110 °C";
                n18 = "79";
                n19 = "sim";
                RTBox.Text = " Júpiter é o quinto planeta a partir do sol e o maior planeta gasoso do sistema solar, sua atmosfera é composta principalmente de hidrogênio e hélio. Uma das características marcantes de Júpiter é a Grande Mancha Vermelha, considerada uma tempestade anticiclônica maior que a Terra.";
            }

            if (Planeta  == "Saturno")
            {
                n1 = "42.612.133.285";
                n2 = "365.882,4";
                n3 = "58.232";
                n4 = "116.460";
                n5 = "1.426.666.422";
                n6 = "827.129.915.150.897 ";
                n7 = "5,6832 x 10^26 ";
                n8 = "0,687";
                n9 = "10,4";
                n10 = "129.924";
                n11 = "0,444";
                n12 = "29,447498";
                n13 = "34.701";
                n14 = "0,05386179";
                n15 = "2,49 graus";
                n16 = "26,7 graus";
                n17 = "-125 °C";
                n18 = "83";
                n19 = "sim";
                RTBox.Text = " Saturno mais conhecido pelos anéis que o circundam, compostos possivelmente de partículas de luas do planeta que foram atingidas por asteroides e destruídas, trata-se do segundo maior planeta desse sistema solar, é um planeta gasoso, sendo basicamente composto de hidrogênio. Ele possui a peculiaridade de ser menos denso do que a água, ou seja, se fosse possível “mergulhá-lo” em uma bacia d'água, ele flutuaria.";
            }

            if (Planeta == "Urano")
            {
                n1 = "8.083.079.690";
                n2 = "159.354,1";
                n3 = "25.362";
                n4 = "50.724";
                n5 = "2.870.658.186";
                n6 = "68.334.355.695.584 ";
                n7 = "8,6810 x 10^25 ";
                n8 = "1.270";
                n9 = "8,87";
                n10 = "76.968";
                n11 = "-0,718";
                n12 = "84.016846";
                n13 = "24.477";
                n14 = "0,04725744";
                n15 = "0,77 graus";
                n16 = "97,8 graus (R.T.)";
                n17 = "-197 °C";
                n18 = "27";
                n19 = "sim";
                RTBox.Text = " Urano é um planeta pouco explorado, por conta de sua distancia e das dificuldades técnicas de exploração de sua superfície sendo ela formada por gases, principalmente hidrogenio e helio. Possui um total de 13 anéis, nao visiveis a olho nu, com relação a sua movimentação, o Sol em Urano nasce no oeste e se põe no leste diferente dos outros planetas.";
            }

            if (Planeta == "Netuno")
            {
                n1 = "7.618.272.763";
                n2 = "154.704,6";
                n3 = "24.622";
                n4 = "49.224";
                n5 = "4.498.396.441";
                n6 = "62.525.703.987.421 ";
                n7 = "1.0241 x 10^26 ";
                n8 = "1.638";
                n9 = "11,15";
                n10 = "84.816";
                n11 = "0,671";
                n12 = "164,79132";
                n13 = "19.566";
                n14 = "0,00859048";
                n15 = "1,77 graus";
                n16 = "28,3 graus";
                n17 = "-223,15 °C";
                n18 = "14";
                n19 = "sim";
                RTBox.Text = " Oitavo e mais distante planeta, o único planeta de nosso sistema solar não visível a olho nu e o primeiro previsto pela matemática antes de sua descoberta. Em Netuno desenvolve ventos que podem atingir aproximadamente 2.000 quilômetros por hora, isso devido à sua condição de planeta gasoso. Constituído quimicamente sua atmosfera de hidrogênio, hélio, além de vestígios de metano e hidrocarbonetos.";
            }

            if (Planeta == "Plutão")
            {
                n1 = "16.647.940";
                n2 = "7.231,9";
                n3 = "1.151";
                n4 = "2.376,6";
                n5 = "5.906.440.628 ";
                n6 = "6.387.259.783 ";
                n7 = "1.3090 x 10^22 ";
                n8 = "2,050";
                n9 = "0,66";
                n10 = "4.428";
                n11 = "-6,39";
                n12 = "248.54";
                n13 = "16.809";
                n14 = "0,2488273";
                n15 = "17,148 graus";
                n16 = "122,5 graus (R.T.)";
                n17 = "-233 °C";
                n18 = "5";
                n19 = "não";
                RTBox.Text = " Plutão é um Planeta anão, considerado um planeta ate 2006, isso ocorreu porque nao atende os criterios definido pela UAI, principalmente pelo fato de ter sua órbita influenciada por outros planetas. É um dos astros mais distantes do Sol e menos influenciado por ele.";
            }

            if (Planeta == "Lua")
            {
                n1 = "37.936.694,79";
                n2 = "10.917,0";
                n3 = "1737,5";
                n4 = "3.474,2";
                n5 = "384.400 ";
                n6 = "21.971.669.064 ";
                n7 = "7,3477 x 10^22 ";
                n8 = "3,344";
                n9 = "1,624";
                n10 = "8.552";
                n11 = "27,322";
                n12 = "29,5";
                n13 = "3.680,5";
                n14 = "0,0554";
                n15 = "5,2 graus";
                n16 = "6,68 graus";
                n17 = "-184 / 214 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " O único satélite natural da Terra e a quinta maior lua do sistema solar, com uma superfície bastante irregular, repleta de rochas, ela é desprovida de gases e recursos hidricos.Não sendo uma estrela, a Lua não emite luz própria. Entretanto, a vemos iluminada pois ela reflete a luz proveniente do Sol,A presença da Lua ajuda a estabilizar a oscilação do nosso planeta, o que ajuda a estabilizar o nosso clima.";
            }

            if (Planeta == "Deimos")
            {
                n1 = "483,05";
                n2 = "39";
                n3 = "6,2";
                n4 = "12,4";
                n5 = "23.458 ";
                n6 = "998 ";
                n7 = "1,4762 x 10^15 ";
                n8 = "1.471";
                n9 = "0,003";
                n10 = "20";
                n11 = "1.26244";
                n12 = "1,25";
                n13 = "4.864,8";
                n14 = "0,0002";
                n15 = "1,79 graus";
                n16 = "---";
                n17 = "-40,15 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Deimos é o menor e mais distante satelite de Marte, um meteorito primitivo podendo ter se formado no Cinturao de Asteroides entre Marte e Jupiter.Por ser um corpo irregular e muito escuro, tendo baixa gravidade uma pessoa escaparia saltando do satelite.";
            }

            if (Planeta == "Phobos")
            {
                n1 = "1.548,30";
                n2 = "69,7";
                n3 = "11,1";
                n4 = "22,533";
                n5 = "9.376";
                n6 = "5.729 ";
                n7 = "1.0659 x 10^16 ";
                n8 = "1,872";
                n9 = "0,0057";
                n10 = "41";
                n11 = "0.31891";
                n12 = "0.31891";
                n13 = "7696,7";
                n14 = "0,0151";
                n15 = "1,08 graus";
                n16 = "---";
                n17 = "-40,15 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Fobos é o maior satelite de Marte. orbitando Marte três vezes por dia e está tão perto da superfície do planeta que nem sempre pode ser visto em alguns locais de Marte.As forças de maré estão diminuindo o seu raio orbital em um ritmo lento mas constante, de alguns centímetros por ano.";
            }

            if (Planeta == "Europa")
            {
                n1 = "30.612.893,23";
                n2 = "9806,8";
                n3 = "1.560,8";
                n4 = "3.121,6";
                n5 = "671.100";
                n6 = "15.926.867.918 ";
                n7 = "4,7998 x 10^22 ";
                n8 = "3,013";
                n9 = "1,315";
                n10 = "7.293";
                n11 = "3,54167";
                n12 = "3,54";
                n13 = "49.476";
                n14 = "0,0094";
                n15 = "0,04 graus";
                n16 = "---";
                n17 = "-171,15 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Europa é a menor das quatro luas galileanas de Jupiter, pode ser o lugar mais promissor em nosso sistema solar para encontrar ambientes atuais adequados para alguma forma de vida fora da Terra,pois contém água 2 vezes mais líquido do que todos os oceanos do nosso planeta.";
            }

            if (Planeta == "Ganímedes")
            {
                n1 = "86.999.665,93";
                n2 = "16.532,3";
                n3 = "2.631,2";
                n4 = "5.268,2";
                n5 = "1.070.400";
                n6 = "76.304.506.998 ";
                n7 = "1,4819 x 10^23 ";
                n8 = "1,942";
                n9 = "1,428";
                n10 = "9.869";
                n11 = "7,154553";
                n12 = "7,154553";
                n13 = "39.165,6";
                n14 = "0,0013";
                n15 = "0,195 graus";
                n16 = "---";
                n17 = "-118,15 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Ganimedes é a maior satelite do nosso sistema solar e a única lua com seu próprio campo magnético. O campo magnético causa auroras boreais, em regiões que circundam os pólos norte e sul da lua. Os cientistas também encontraram fortes evidências de um oceano subterrâneo em Ganimedes.";
            }

            if (Planeta == "Encéfalo")
            {
                n1 = "798.648,27";
                n2 = "1.584,0";
                n3 = "252,1";
                n4 = "504,2";
                n5 = "238.037";
                n6 = "67.113.076 ";
                n7 = "1,0794 x 10^20 ";
                n8 = "1,608";
                n9 = "0,113";
                n10 = "861";
                n11 = "1.370218";
                n12 = "1.370218";
                n13 = "45.487,3";
                n14 = "0,0047";
                n15 = "0,02 graus";
                n16 = "---";
                n17 = "-201 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Encélado possui um oceano global de água líquida sob sua superfície gelada. Criovulcões no polo sul ejetam grandes jatos de vapor de água e outros voláteis como algumas partículas sólidas para o espaço.";
            }

            if (Planeta == "Titã")
            {
                n1 = "83.305.418,53";
                n2 = "16.177,5";
                n3 = "2.574,7";
                n4 = "5.149,5";
                n5 = "1.221.865";
                n6 = "71.496.320.086 ";
                n7 = "1,3455 x 10^23 ";
                n8 = "1,882";
                n9 = "1,354";
                n10 = "9.507";
                n11 = "15.94542";
                n12 = "15.94542";
                n13 = "20.051,2";
                n14 = "0,0288";
                n15 = "0,33 graus";
                n16 = "---";
                n17 = "-180,15 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Titã é a maior lua de Saturno, e a única com uma atmosfera substancial. De todos os lugares do sistema solar, Titã é o único lugar além da Terra conhecido por ter líquidos na forma de rios, lagos e mares em sua superfície.";
            }

            if (Planeta == "Ariel")
            {
                n1 = "4.211.307,59";
                n2 = "3.637,3";
                n3 = "578,9";
                n4 = "1.158";
                n5 = "190.900";
                n6 = "812.641.988 ";
                n7 = "1,2948 x 10^21 ";
                n8 = "1,592";
                n9 = "0,258";
                n10 = "1.967";
                n11 = "2.520379";
                n12 = "2.520379";
                n13 = "19.832,3";
                n14 = "0,0012";
                n15 = "0,31 graus";
                n16 = "---";
                n17 = "-215,2 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " A superfície de Ariel parece ser a mais jovem de todas as luas de Urano. possui poucas crateras grandes, mas muitas pequenas indicando que colisões de baixo impacto bastante recentes eliminaram as grandes crateras que teriam sido deixadas por ataques muito anteriores.";
            }

            if (Planeta == "Oberon")
            {
                n1 = "7.285.101,53";
                n2 = "4.784";
                n3 = "761,4";
                n4 = "1.522,8";
                n5 = "583.500";
                n6 = "1.848.958.769 ";
                n7 = "2,8834 x 10^21 ";
                n8 = "1,559";
                n9 = "0,332";
                n10 = "2.559";
                n11 = "13.46324";
                n12 = "13.46324";
                n13 = "11.349,2";
                n14 = "0,0014";
                n15 = "0,10 graus";
                n16 = "---";
                n17 = "-198,15 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Oberon é a segunda maior lua de Urano. Descoberta em 1787, pouco se sabia sobre esta lua até que a Voyager 2 passou por ela durante o sobrevôo de Urano em janeiro de 1986.";
            }

            if (Planeta == "Proteu")
            {
                n1 = "554.176,94";
                n2 = "1.319,5";
                n3 = "210,0";
                n4 = "420";
                n5 = "117.646";
                n6 = "38.792.386 ";
                n7 = "5,0355 x 10^19 ";
                n8 = "1,3";
                n9 = "0,76";
                n10 = "644";
                n11 = "---";
                n12 = "1.122315";
                n13 = "27.450,7";
                n14 = "0,0005";
                n15 = "0,04 graus";
                n16 = "---";
                n17 = "-222 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Proteu é uma das maiores luas conhecidas de Netuno, embora não seja tão grande quanto Tritão. A lua tem uma forma estranha de caixa e se tivesse um pouco mais de massa seria capaz de se transformar em uma esfera.";
            }

            if (Planeta == "Tritão")
            {
                n1 = "23.017.714,99";
                n2 = "8.503,7";
                n3 = "1353,4";
                n4 = "2.706,8";
                n5 = "354.759";
                n6 = "10.384.058.491 ";
                n7 = "2,1395 x 10^22 ";
                n8 = "2,059";
                n9 = "0,779";
                n10 = "5.229";
                n11 = "-5.87685";
                n12 = "-5.87685";
                n13 = "15.803,2";
                n14 = "0";
                n15 = "157,345 graus";
                n16 = "---";
                n17 = "-235,15 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Tritão é a maior das 13 luas de Netuno e a única grande lua do sistema solar com uma órbita retrógrada. Os cientistas pensam que Tritão é um objeto do cinturão de Kuiper capturado pela gravidade de Netuno há milhões de anos.";
            }

            if (Planeta == "Caronte")
            {
                n1 = "4.578.343,00";
                n2 = "3.792,5";
                n3 = "603,6";
                n4 = "1.212";
                n5 = "17.536";
                n6 = "921.162.612 ";
                n7 = "1,546626 x 10^21 ";
                n8 = "1,678";
                n9 = "0,283";
                n10 = "2.105";
                n11 = "6.38725";
                n12 = "6.38725";
                n13 = "718,8";
                n14 = "0,0022";
                n15 = "0 graus";
                n16 = "---";
                n17 = "-220 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Com metade do tamanho de Plutão, Caronte é a maior das luas de Plutão e o maior satélite conhecido em relação ao seu corpo original. Plutão-Caronte é o único sistema planetário duplo conhecido do nosso sistema solar.";
            }

            if (Planeta == "Hidra")
            {
                n1 = "16.286,02";
                n2 = "226,2";
                n3 = "36";
                n4 = "72";
                n5 = "64.749";
                n6 = "195.432 ";
                n7 = "9,891212 x 10^17 ";
                n8 = "5";
                n9 = "0,051";
                n10 = "218";
                n11 = "---";
                n12 = "38";
                n13 = "443,7";
                n14 = "0,0051";
                n15 = "0,17 graus";
                n16 = "---";
                n17 = "-229 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " Hydra é um dos dois (Nix o outro) pequenos satelites orbitando Plutão em 2005. Hydra foi nomeada referente a serpente de nove cabeças que Hércules lutou na mitologia grega e romana.";
            }

            if (Planeta == "IO")
            {
                n1 = "41.698.064,74";
                n2 = "11.445,5";
                n3 = "1821,6";
                n4 = "3.643,2";
                n5 = "421.800";
                n6 = "25.319.064.907 ";
                n7 = "98,9319 x 10^22 ";
                n8 = "3,528";
                n9 = "1,796";
                n10 = "8.552";
                n11 = "1,769138";
                n12 = "1,769138";
                n13 = "62.423,1";
                n14 = "0,0041";
                n15 = "0.04 graus";
                n16 = "---";
                n17 = "-143 °C";
                n18 = "0";
                n19 = "não";
                RTBox.Text = " A lua rochosa de Júpiter, Io, é o mundo mais vulcanicamente ativo do sistema solar. A atividade notável de Io é o resultado de um cabo de guerra entre a poderosa gravidade de Júpiter e as atrações menores de duas luas vizinhas que orbitam mais longe de Júpiter - Europa e Ganimedes.";
            }

        }
        private static DataTable GetCustomers()
        {
            DataTable table = new DataTable();
            table.TableName = "Customers";
            table.Columns.Add("hue", typeof(string));
            table.Columns.Add("Área da Superfície (km^2)", typeof(string));
            table.Columns.Add("Circunferência Equatorial (km)", typeof(string));
            table.Columns.Add("Raio Equatorial (km)", typeof(string));

            table.Columns.Add("Diâmetro (km)", typeof(string));
            table.Columns.Add("Distância Orbital Média (km)", typeof(string));
            table.Columns.Add("Volume (km^3)", typeof(string));
            table.Columns.Add("Massa (kg)", typeof(string));
            table.Columns.Add("Densidade (g/cm^3)", typeof(string));
            table.Columns.Add("Gravidade (m/s^2)", typeof(string));
            table.Columns.Add("Velocidade de Escape (km/h)", typeof(string));
            table.Columns.Add("Período de Rotação (Dias Terres.)", typeof(string));
            table.Columns.Add("Período de órbita (Anos Terres.)", typeof(string));

            table.Columns.Add("Velocidade Orbital (km/h)", typeof(string));
            table.Columns.Add("Excentricidade Orbital", typeof(string));
            table.Columns.Add("Inclinação da Órbita (°)", typeof(string));
            table.Columns.Add("Inclinação Equatorial (°)", typeof(string));

            table.Columns.Add("Temperatura da Superfície", typeof(string));
            table.Columns.Add("Quantidade de Luas", typeof(string));
            table.Columns.Add("Possui aneis", typeof(string));

            table.Rows.Add(new object[] { "hue",n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19});
         
            table.AcceptChanges();

            return table;
        }
        // --------------------------------------------------- //
        public DataSet FlipDataSet(DataSet my_DataSet)
        {
            DataSet ds = new DataSet();

            foreach (DataTable dt in my_DataSet.Tables)
            {
                DataTable table = new DataTable();

                for (int i = 0; i <= dt.Rows.Count; i++)
                {
                    table.Columns.Add(Convert.ToString(i));
                }
                DataRow r;
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    r = table.NewRow();
                    r[0] = dt.Columns[k].ToString();
                    for (int j = 1; j <= dt.Rows.Count; j++)
                        r[j] = dt.Rows[j - 1][k];
                    table.Rows.Add(r);
                }

                ds.Tables.Add(table);
            }

            return ds;
        }
        // --------------------------------------------------- //
        private void Flip ()
        {
            DataSet new_ds = FlipDataSet(ds); // Flip the DataSet
            DataView my_DataView = new_ds.Tables[0].DefaultView;
            this.dgwDados.DataSource = my_DataView;
        }
        // --------------------------------------------------- //
        private void Normal  ()
        {
            DataView my_DataView = ds.Tables[0].DefaultView;
            this.dgwDados.DataSource = my_DataView;
        }

        private void Dados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.controleDados = 0;
        }

     
        // --------------------------------------------------- //
    }
}
