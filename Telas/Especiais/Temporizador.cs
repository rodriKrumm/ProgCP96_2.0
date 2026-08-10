using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class Temporizador : Form
    {
        public static string receberMsg2;
        public static char[] vetorvazio2 = new char[32];
        public static char[] vetorMensagem2;

        public static char[] visualizarTextbox;

        public static int visualizar_clicado;

        public static char mostrar1 = ' ';
        public static char mostrar2 = ' ';
        public static char mostrar3 = ' ';
        public static char mostrar4 = ' ';
        public static char mostrar5 = ' ';
        public static char mostrar6 = ' ';
        public static char mostrar7 = ' ';

        public static char[] mostrarDecimos;

        public static int diferenca;

        public static string textbox;

        public static int arquivoTempo;



        public static int value;
        public static int value1;
        public static int value2;
        public static int value3;
        public static int value4;

        public static int valueMAX;
        public static int valueMAX1;
        public static int valueMAX2;
        public static int valueMAX3;
        public static int valueMax4;

        public static int valueMIN;
        public static int valueMIN1;
        public static int valueMIN2;
        public static int valueMIN3;
        public static int valueMin4;

        public static char[] vetorSemVisualizar = new char[32]; // vetor para salvar o conteudo do textbox sem precisar clicar em visualizar

        public static int M;
        public static int C;
        public static int D;
        public static int U;

        public static int M2;
        public static int C2;
        public static int D2;
        public static int U2;

        public static char fabrica1;
        public static char fabrica2;
        public static char fabrica3;
        public static char fabrica4;
        public static char fabrica5;
        public static char fabrica6;

        public static string adicionarZero1; //adiciona 0 nos parametros abaixo de 99.
        public static string adicionarzero2;// adiciona 00 nos parametros abaixo de 9.

        public static string add_tempo;

        char max1;
        char max2;
        char max3;
        char max4;

        char min1;
        char min2;
        char min3;
        char min4;

        public static char[] vetordisplay;
        public static char pos26;
        public static char pos27;
        public static char pos28;
        public static char pos29;
        public static char pos30;
        public static char pos31;

        public static char[] escalaFabrica;
        public static char[] escalaMax;
        public static char[] escalaMin;




        public static char[] Tempo1;

        public static int mudar_RB;
        public string vet;
        public static string[] vetor_txb5 = new string[43];
        public static char[] passarMsg = new char[25];
        public static char[] vetortemporario;

        public static string SalvarConteudoTempo01;
        public static string SalvarConteudoTempo02;
        public static string SalvarConteudoTempo03;
        public static string SalvarConteudoTempo04;
        public static string SalvarConteudoTempo05;
        public static string SalvarConteudoTempo06;
        public static string SalvarConteudoTempo07;
        public static string SalvarConteudoTempo08;
        public static string SalvarConteudoTempo09;
        public static string SalvarConteudoTempo10;
        public static string SalvarConteudoTempo11;
        public static string SalvarConteudoTempo12;
        public static string SalvarConteudoTempo13;
        public static string SalvarConteudoTempo14;
        public static string SalvarConteudoTempo15;
        public static string SalvarConteudoTempo16;
        public static string SalvarConteudoTempo17;
        public static string SalvarConteudoTempo18;
        public static string SalvarConteudoTempo19;
        public static string SalvarConteudoTempo20;
        public static string SalvarConteudoTempo21;
        public static string SalvarConteudoTempo22;
        public static string SalvarConteudoTempo23;
        public static string SalvarConteudoTempo24;

        /// <Variaveis para salvar valores na matriz principal>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        int TP_01 = 124;
        int TP_02 = 125;
        int TP_03 = 126;
        int TP_04 = 127;
        int TP_05 = 128;
        int TP_06 = 129;
        int TP_07 = 130;
        int TP_08 = 131;

        int TP_09 = 132;
        int TP_10 = 133;
        int TP_11 = 134;
        int TP_12 = 135;
        int TP_13 = 136;
        int TP_14 = 137;
        int TP_15 = 138;
        int TP_16 = 139;

        int TP_17 = 140;
        int TP_18 = 141;
        int TP_19 = 142;
        int TP_20 = 143;
        int TP_21 = 144;
        int TP_22 = 145;
        int TP_23 = 146;
        int TP_24 = 147;

        public Temporizador()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form1.click_selecionar[1] = 0;
            Form1.img = Properties.Resources.linhas_gridview;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;

            Close();
        }
        private void btn_decimos_Click(object sender, EventArgs e)
        {
            mudar_RB = 1;
            tracBar_fabrica.Maximum = 999;
            trackBar_minimo.Maximum = 1000;
            trackBar_maximo.Maximum = 1000;

            tracBar_fabrica.TickFrequency = 20;
            trackBar_maximo.TickFrequency = 20;
            trackBar_minimo.TickFrequency = 20;

            if (mudar_RB == 3)
            {
                M = tracBar_fabrica.Value / 600;
                C = (tracBar_fabrica.Value - (M * 600)) / 60;
                D = (tracBar_fabrica.Value - ((M * 600) + (C * 60))) / 10;
                U = tracBar_fabrica.Value - ((M * 600) + (C * 60) + (D * 10));
            }
            else
            {
                C = ((tracBar_fabrica.Value % 1000) / 100);
                D = ((tracBar_fabrica.Value % 100) / 10);
                U = (tracBar_fabrica.Value % 10);

            }
            if (mudar_RB == 3)
            {
                M = trackBar_maximo.Value / 600;
                C = (trackBar_maximo.Value - (M * 600)) / 60;
                D = (trackBar_maximo.Value - ((M * 600) + (C * 60))) / 10;
                U = trackBar_maximo.Value - ((M * 600) + (C * 60) + (D * 10));

            }
            else
            {
                C = ((trackBar_maximo.Value % 1000) / 100);
                D = ((trackBar_maximo.Value % 100) / 10);
                U = (trackBar_maximo.Value % 10);
            }
            if (mudar_RB == 3)
            {
                M = trackBar_minimo.Value / 600;
                C = (trackBar_minimo.Value - (M * 600)) / 60;
                D = (trackBar_minimo.Value - ((M * 600) + (C * 60))) / 10;
                U = trackBar_minimo.Value - ((M * 600) + (C * 60) + (D * 10));
            }
            else
            {
                C = ((trackBar_minimo.Value % 1000) / 100);
                D = ((trackBar_minimo.Value % 100) / 10);
                U = (trackBar_minimo.Value % 10);
            }
           

            btn_segundos.BackColor = Color.Azure;
            btn_horasMinutos.BackColor = Color.Azure;
            btn_decimos.BackColor = Color.LightGray;

            radioButton1.Text = "Tempo 1";
            radioButton2.Text = "Tempo 2";
            radioButton3.Text = "Tempo 3";
            radioButton4.Text = "Tempo 4";
            radioButton5.Text = "Tempo 7";
            radioButton6.Text = "Tempo 6";
            radioButton7.Text = "Tempo 8";
            radioButton8.Text = "Tempo 5";



            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            rb_parametro1.Enabled = true;
            rb_parametro2.Enabled = true;
            rb_parametroFixo.Enabled = true;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;

            rb_parametroFixo.Checked = true;

        }
        private void btn_segundos_Click(object sender, EventArgs e)
        {
            mudar_RB = 2;
            tracBar_fabrica.Maximum = 1000;
            trackBar_maximo.Maximum = 1000;
            trackBar_minimo.Maximum = 999;

            tracBar_fabrica.TickFrequency = 20;
            trackBar_maximo.TickFrequency = 20;
            trackBar_minimo.TickFrequency = 20;

            btn_segundos.BackColor = Color.LightGray;
            btn_horasMinutos.BackColor = Color.Azure;
            btn_decimos.BackColor = Color.Azure;

            radioButton1.Text = "Tempo 9";
            radioButton2.Text = "Tempo 10";
            radioButton3.Text = "Tempo 11";
            radioButton4.Text = "Tempo 12";
            radioButton5.Text = "Tempo 15";
            radioButton6.Text = "Tempo 14";
            radioButton7.Text = "Tempo 16";
            radioButton8.Text = "Tempo 13";

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            rb_parametro1.Enabled = true;
            rb_parametro2.Enabled = true;
            rb_parametroFixo.Enabled = true;

            rb_parametroFixo.Checked = true;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
        }
        private void btn_horasMinutos_Click(object sender, EventArgs e)
        {
            mudar_RB = 3;

            tracBar_fabrica.Maximum = 5940;
            trackBar_maximo.Maximum = 5940;
            trackBar_minimo.Maximum = 5940;

            tracBar_fabrica.TickFrequency = 100;
            trackBar_maximo.TickFrequency = 100;
            trackBar_minimo.TickFrequency = 100;

            btn_segundos.BackColor = Color.Azure;
            btn_horasMinutos.BackColor = Color.LightGray;
            btn_decimos.BackColor = Color.Azure;

            radioButton1.Text = "Tempo 17";
            radioButton2.Text = "Tempo 18";
            radioButton3.Text = "Tempo 19";
            radioButton4.Text = "Tempo 20";
            radioButton5.Text = "Tempo 23";
            radioButton6.Text = "Tempo 22";
            radioButton7.Text = "Tempo 24";
            radioButton8.Text = "Tempo 21";

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            rb_parametro1.Enabled = true;
            rb_parametro2.Enabled = true;
            rb_parametroFixo.Enabled = true;

            rb_parametroFixo.Checked = true;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;

        }
        private void Temporizador_Shown(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            trackBar_maximo.Enabled = false;
            trackBar_minimo.Enabled = false;
            tracBar_fabrica.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            radioButton1.Checked = false;
            
            rb_parametroFixo.Checked = true;
            rb_parametro1.Checked = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tb_comentario.Text = Form1.linha78.Trim();

            if (radioButton1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                trackBar_maximo.Enabled = true;
                trackBar_minimo.Enabled = true;
                tracBar_fabrica.Enabled = true;

                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;

                if (radioButton1.Text == "Tempo 1")
                {
                    arquivoTempo = 1;
                    char[] Tempo1 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT01.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo1.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo1[0];
                        vetorSemVisualizar[1] = Tempo1[1];
                        vetorSemVisualizar[2] = Tempo1[2];
                        vetorSemVisualizar[3] = Tempo1[3];
                        vetorSemVisualizar[4] = Tempo1[4];
                        vetorSemVisualizar[5] = Tempo1[5];
                        vetorSemVisualizar[6] = Tempo1[6];
                        vetorSemVisualizar[7] = Tempo1[7];
                        vetorSemVisualizar[8] = Tempo1[8];
                        vetorSemVisualizar[9] = Tempo1[9];
                        vetorSemVisualizar[10] = Tempo1[10];
                        vetorSemVisualizar[11] = Tempo1[11];
                        vetorSemVisualizar[12] = Tempo1[12];
                        vetorSemVisualizar[13] = Tempo1[13];
                        vetorSemVisualizar[14] = Tempo1[14];
                        vetorSemVisualizar[15] = Tempo1[15];
                        vetorSemVisualizar[16] = Tempo1[16];
                        vetorSemVisualizar[17] = Tempo1[17];
                        vetorSemVisualizar[18] = Tempo1[18];
                        vetorSemVisualizar[19] = Tempo1[19];
                        vetorSemVisualizar[20] = Tempo1[20];
                        vetorSemVisualizar[21] = Tempo1[21];
                        vetorSemVisualizar[22] = Tempo1[22];
                        vetorSemVisualizar[23] = Tempo1[23];
                        vetorSemVisualizar[24] = Tempo1[24];

                        value1 = int.Parse(Tempo1[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo1[27].ToString()) * 100;
                        value3 = int.Parse(Tempo1[28].ToString()) * 10;
                        value4 = int.Parse(Tempo1[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo1[26];
                        fabrica2 = Tempo1[27];
                        fabrica3 = Tempo1[28];
                        fabrica4 = Tempo1[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = Tempo1[26].ToString() + Tempo1[27].ToString() + Tempo1[28].ToString() + "." + Tempo1[29].ToString() + "s";
                    }

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    for (int x = 0; x < Tempo1.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo1[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo1[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo1[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo1[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo1[31];
                        max2 = Tempo1[32];
                        max3 = Tempo1[33];
                        max4 = Tempo1[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo1[31].ToString() + Tempo1[32].ToString() + Tempo1[33].ToString() + "." + Tempo1[34].ToString() + "s";
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    for (int x = 0; x < Tempo1.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo1[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo1[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo1[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo1[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo1[36];
                        min2 = Tempo1[37];
                        min3 = Tempo1[38];
                        min4 = Tempo1[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo1[36].ToString() + Tempo1[37].ToString() + Tempo1[38].ToString() + "." + Tempo1[39].ToString() + "s";
                    }

                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo01.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();

                    Form1.click_selecionar[1] = TP_01;
                    Form1.img = Properties.Resources.temporizador_01;

                    passarMsg = textBox5.Text.ToCharArray();
                }

                if (radioButton1.Text == "Tempo 9")
                {
                    arquivoTempo = 9;
                    char[] Tempo9 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT09.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo9.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo9[0];
                        vetorSemVisualizar[1] = Tempo9[1];
                        vetorSemVisualizar[2] = Tempo9[2];
                        vetorSemVisualizar[3] = Tempo9[3];
                        vetorSemVisualizar[4] = Tempo9[4];
                        vetorSemVisualizar[5] = Tempo9[5];
                        vetorSemVisualizar[6] = Tempo9[6];
                        vetorSemVisualizar[7] = Tempo9[7];
                        vetorSemVisualizar[8] = Tempo9[8];
                        vetorSemVisualizar[9] = Tempo9[9];
                        vetorSemVisualizar[10] = Tempo9[10];
                        vetorSemVisualizar[11] = Tempo9[11];
                        vetorSemVisualizar[12] = Tempo9[12];
                        vetorSemVisualizar[13] = Tempo9[13];
                        vetorSemVisualizar[14] = Tempo9[14];
                        vetorSemVisualizar[15] = Tempo9[15];
                        vetorSemVisualizar[16] = Tempo9[16];
                        vetorSemVisualizar[17] = Tempo9[17];
                        vetorSemVisualizar[18] = Tempo9[18];
                        vetorSemVisualizar[19] = Tempo9[19];
                        vetorSemVisualizar[20] = Tempo9[20];
                        vetorSemVisualizar[21] = Tempo9[21];
                        vetorSemVisualizar[22] = Tempo9[22];
                        vetorSemVisualizar[23] = Tempo9[23];
                        vetorSemVisualizar[24] = Tempo9[24];

                        value1 = int.Parse(Tempo9[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo9[27].ToString()) * 100;
                        value3 = int.Parse(Tempo9[28].ToString()) * 10;
                        value4 = int.Parse(Tempo9[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo9[26];
                        fabrica2 = Tempo9[27];
                        fabrica3 = Tempo9[28];
                        fabrica4 = Tempo9[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = tracBar_fabrica.Value.ToString() + "s";
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    for (int x = 0; x < Tempo9.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo9[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo9[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo9[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo9[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo9[31];
                        max2 = Tempo9[32];
                        max3 = Tempo9[33];
                        max4 = Tempo9[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = trackBar_maximo.Value.ToString() + "s";
                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    for (int x = 0; x < Tempo9.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo9[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo9[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo9[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo9[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                        min1 = Tempo9[36];
                        min2 = Tempo9[37];
                        min3 = Tempo9[38];
                        min4 = Tempo9[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = trackBar_minimo.Value.ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo09.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();

                    Form1.click_selecionar[1] = TP_09;
                    Form1.img = Properties.Resources.temporizador_09;

                    passarMsg = textBox5.Text.ToCharArray();
                }

                if (radioButton1.Text == "Tempo 17")
                {
                    arquivoTempo = 17;
                    char[] Tempo17 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT17.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo


                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo17.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo17[0];
                        vetorSemVisualizar[1] = Tempo17[1];
                        vetorSemVisualizar[2] = Tempo17[2];
                        vetorSemVisualizar[3] = Tempo17[3];
                        vetorSemVisualizar[4] = Tempo17[4];
                        vetorSemVisualizar[5] = Tempo17[5];
                        vetorSemVisualizar[6] = Tempo17[6];
                        vetorSemVisualizar[7] = Tempo17[7];
                        vetorSemVisualizar[8] = Tempo17[8];
                        vetorSemVisualizar[9] = Tempo17[9];
                        vetorSemVisualizar[10] = Tempo17[10];
                        vetorSemVisualizar[11] = Tempo17[11];
                        vetorSemVisualizar[12] = Tempo17[12];
                        vetorSemVisualizar[13] = Tempo17[13];
                        vetorSemVisualizar[14] = Tempo17[14];
                        vetorSemVisualizar[15] = Tempo17[15];
                        vetorSemVisualizar[16] = Tempo17[16];
                        vetorSemVisualizar[17] = Tempo17[17];
                        vetorSemVisualizar[18] = Tempo17[18];
                        vetorSemVisualizar[19] = Tempo17[19];
                        vetorSemVisualizar[20] = Tempo17[20];
                        vetorSemVisualizar[21] = Tempo17[21];
                        vetorSemVisualizar[22] = Tempo17[22];
                        vetorSemVisualizar[23] = Tempo17[23];
                        vetorSemVisualizar[24] = Tempo17[24];

                        value1 = int.Parse(Tempo17[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo17[27].ToString()) * 100;
                        value3 = int.Parse(Tempo17[28].ToString()) * 10;
                        value4 = int.Parse(Tempo17[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo17[26];
                        fabrica2 = Tempo17[27];
                        fabrica3 = Tempo17[28];
                        fabrica4 = Tempo17[29];

                        tracBar_fabrica.Value = value;
                        textBox1.Text = Tempo17[26].ToString() + Tempo17[27].ToString() + ":" + Tempo17[28].ToString() + Tempo17[29].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo17.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo17[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo17[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo17[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo17[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        if (valueMAX > 5940)
                        {
                            valueMAX = 5940;
                        }

                        max1 = Tempo17[31];
                        max2 = Tempo17[32];
                        max3 = Tempo17[33];
                        max4 = Tempo17[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo17[31].ToString() + Tempo17[32].ToString() + ":" + Tempo17[33].ToString() + Tempo17[34].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo17.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo17[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo17[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo17[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo17[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo17[36];
                        min2 = Tempo17[37];
                        min3 = Tempo17[38];
                        min4 = Tempo17[39];

                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo17[26].ToString() + Tempo17[27].ToString() + ":" + Tempo17[28].ToString() + Tempo17[29].ToString() + "h";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo17.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();

                    Form1.click_selecionar[1] = TP_17;
                    Form1.img = Properties.Resources.temporizador_17;
                }
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                trackBar_maximo.Enabled = false;
                trackBar_minimo.Enabled = false;
                tracBar_fabrica.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tb_comentario.Text = Form1.linha79.Trim();
            if (rb_parametroFixo.Checked == true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (radioButton2.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                trackBar_maximo.Enabled = true;
                trackBar_minimo.Enabled = true;
                tracBar_fabrica.Enabled = true;

                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;

                if (radioButton2.Text == "Tempo 2")
                {
                    arquivoTempo = 2;

                    char[] Tempo2 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT02.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo2.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo2[0];
                        vetorSemVisualizar[1] = Tempo2[1];
                        vetorSemVisualizar[2] = Tempo2[2];
                        vetorSemVisualizar[3] = Tempo2[3];
                        vetorSemVisualizar[4] = Tempo2[4];
                        vetorSemVisualizar[5] = Tempo2[5];
                        vetorSemVisualizar[6] = Tempo2[6];
                        vetorSemVisualizar[7] = Tempo2[7];
                        vetorSemVisualizar[8] = Tempo2[8];
                        vetorSemVisualizar[9] = Tempo2[9];
                        vetorSemVisualizar[10] = Tempo2[10];
                        vetorSemVisualizar[11] = Tempo2[11];
                        vetorSemVisualizar[12] = Tempo2[12];
                        vetorSemVisualizar[13] = Tempo2[13];
                        vetorSemVisualizar[14] = Tempo2[14];
                        vetorSemVisualizar[15] = Tempo2[15];
                        vetorSemVisualizar[16] = Tempo2[16];
                        vetorSemVisualizar[17] = Tempo2[17];
                        vetorSemVisualizar[18] = Tempo2[18];
                        vetorSemVisualizar[19] = Tempo2[19];
                        vetorSemVisualizar[20] = Tempo2[20];
                        vetorSemVisualizar[21] = Tempo2[21];
                        vetorSemVisualizar[22] = Tempo2[22];
                        vetorSemVisualizar[23] = Tempo2[23];
                        vetorSemVisualizar[24] = Tempo2[24];

                        value1 = int.Parse(Tempo2[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo2[27].ToString()) * 100;
                        value3 = int.Parse(Tempo2[28].ToString()) * 10;
                        value4 = int.Parse(Tempo2[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo2[26];
                        fabrica2 = Tempo2[27];
                        fabrica3 = Tempo2[28];
                        fabrica4 = Tempo2[29];

                        tracBar_fabrica.Value = value;


                        textBox1.Text = Tempo2[26].ToString() + Tempo2[27].ToString() + Tempo2[28].ToString() + "." + Tempo2[29].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo2.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo2[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo2[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo2[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo2[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo2[31];
                        max2 = Tempo2[32];
                        max3 = Tempo2[33];
                        max4 = Tempo2[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo2[31].ToString() + Tempo2[32].ToString() + Tempo2[33].ToString() + "." + Tempo2[34].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo2.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo2[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo2[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo2[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo2[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo2[36];
                        min2 = Tempo2[37];
                        min3 = Tempo2[38];
                        min4 = Tempo2[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo2[36].ToString() + Tempo2[37].ToString() + Tempo2[38].ToString() + "." + Tempo2[39].ToString() + "s";
                    }

                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo02.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();

                    Form1.click_selecionar[1] = TP_02;
                    Form1.img = Properties.Resources.temporizador_02;

                }

                if (radioButton2.Text == "Tempo 10")
                {
                    arquivoTempo = 10;
                    char[] Tempo10 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT10.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo10.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo10[0];
                        vetorSemVisualizar[1] = Tempo10[1];
                        vetorSemVisualizar[2] = Tempo10[2];
                        vetorSemVisualizar[3] = Tempo10[3];
                        vetorSemVisualizar[4] = Tempo10[4];
                        vetorSemVisualizar[5] = Tempo10[5];
                        vetorSemVisualizar[6] = Tempo10[6];
                        vetorSemVisualizar[7] = Tempo10[7];
                        vetorSemVisualizar[8] = Tempo10[8];
                        vetorSemVisualizar[9] = Tempo10[9];
                        vetorSemVisualizar[10] = Tempo10[10];
                        vetorSemVisualizar[11] = Tempo10[11];
                        vetorSemVisualizar[12] = Tempo10[12];
                        vetorSemVisualizar[13] = Tempo10[13];
                        vetorSemVisualizar[14] = Tempo10[14];
                        vetorSemVisualizar[15] = Tempo10[15];
                        vetorSemVisualizar[16] = Tempo10[16];
                        vetorSemVisualizar[17] = Tempo10[17];
                        vetorSemVisualizar[18] = Tempo10[18];
                        vetorSemVisualizar[19] = Tempo10[19];
                        vetorSemVisualizar[20] = Tempo10[20];
                        vetorSemVisualizar[21] = Tempo10[21];
                        vetorSemVisualizar[22] = Tempo10[22];
                        vetorSemVisualizar[23] = Tempo10[23];
                        vetorSemVisualizar[24] = Tempo10[24];

                        value1 = int.Parse(Tempo10[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo10[27].ToString()) * 100;
                        value3 = int.Parse(Tempo10[28].ToString()) * 10;
                        value4 = int.Parse(Tempo10[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo10[26];
                        fabrica2 = Tempo10[27];
                        fabrica3 = Tempo10[28];
                        fabrica4 = Tempo10[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = tracBar_fabrica.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo10.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo10[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo10[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo10[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo10[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;



                        max1 = Tempo10[31];
                        max2 = Tempo10[32];
                        max3 = Tempo10[33];
                        max4 = Tempo10[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = trackBar_maximo.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo10.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo10[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo10[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo10[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo10[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                        min1 = Tempo10[36];
                        min2 = Tempo10[37];
                        min3 = Tempo10[38];
                        min4 = Tempo10[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = trackBar_minimo.Value.ToString() + "s";
                    }

                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo10.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();

                    Form1.click_selecionar[1] = TP_10;
                    Form1.img = Properties.Resources.temporizador_10;
                }
                if (radioButton2.Text == "Tempo 18")
                {
                    arquivoTempo = 18;
                    char[] Tempo18 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT18.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo18.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo18[0];
                        vetorSemVisualizar[1] = Tempo18[1];
                        vetorSemVisualizar[2] = Tempo18[2];
                        vetorSemVisualizar[3] = Tempo18[3];
                        vetorSemVisualizar[4] = Tempo18[4];
                        vetorSemVisualizar[5] = Tempo18[5];
                        vetorSemVisualizar[6] = Tempo18[6];
                        vetorSemVisualizar[7] = Tempo18[7];
                        vetorSemVisualizar[8] = Tempo18[8];
                        vetorSemVisualizar[9] = Tempo18[9];
                        vetorSemVisualizar[10] = Tempo18[10];
                        vetorSemVisualizar[11] = Tempo18[11];
                        vetorSemVisualizar[12] = Tempo18[12];
                        vetorSemVisualizar[13] = Tempo18[13];
                        vetorSemVisualizar[14] = Tempo18[14];
                        vetorSemVisualizar[15] = Tempo18[15];
                        vetorSemVisualizar[16] = Tempo18[16];
                        vetorSemVisualizar[17] = Tempo18[17];
                        vetorSemVisualizar[18] = Tempo18[18];
                        vetorSemVisualizar[19] = Tempo18[19];
                        vetorSemVisualizar[20] = Tempo18[20];
                        vetorSemVisualizar[21] = Tempo18[21];
                        vetorSemVisualizar[22] = Tempo18[22];
                        vetorSemVisualizar[23] = Tempo18[23];
                        vetorSemVisualizar[24] = Tempo18[24];

                        value1 = int.Parse(Tempo18[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo18[27].ToString()) * 100;
                        value3 = int.Parse(Tempo18[28].ToString()) * 10;
                        value4 = int.Parse(Tempo18[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo18[26];
                        fabrica2 = Tempo18[27];
                        fabrica3 = Tempo18[28];
                        fabrica4 = Tempo18[29];

                        tracBar_fabrica.Value = value;
                        textBox1.Text = Tempo18[26].ToString() + Tempo18[27].ToString() + ":" + Tempo18[28].ToString() + Tempo18[29].ToString() + "h";

                    }
                    for (int x = 0; x < Tempo18.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo18[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo18[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo18[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo18[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        if (valueMAX > 5940)
                        {
                            valueMAX = 5940;
                        }

                        max1 = Tempo18[31];
                        max2 = Tempo18[32];
                        max3 = Tempo18[33];
                        max4 = Tempo18[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo18[31].ToString() + Tempo18[32].ToString() + ":" + Tempo18[33].ToString() + Tempo18[34].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo18.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo18[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo18[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo18[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo18[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo18[36];
                        min2 = Tempo18[37];
                        min3 = Tempo18[38];
                        min4 = Tempo18[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo18[36].ToString() + Tempo18[37].ToString() + ":" + Tempo18[38].ToString() + Tempo18[39].ToString() + "h";
                    }

                    M = tracBar_fabrica.Value / 600;
                    C = (tracBar_fabrica.Value - (M * 600)) / 60;
                    D = (tracBar_fabrica.Value - ((M * 600) + (C * 60))) / 10;
                    U = tracBar_fabrica.Value - ((M * 600) + (C * 60) + (D * 10));

                    M = trackBar_maximo.Value / 600;
                    C = (trackBar_maximo.Value - (M2 * 600)) / 60;
                    D = (trackBar_maximo.Value - ((M2 * 600) + (C2 * 60))) / 10;
                    U = trackBar_maximo.Value - ((M2 * 600) + (C2 * 60) + (D2 * 10));

                    M = trackBar_minimo.Value / 600;
                    C = (trackBar_minimo.Value - (M * 600)) / 60;
                    D = (trackBar_minimo.Value - ((M * 600) + (C * 60))) / 10;
                    U = trackBar_minimo.Value - ((M * 600) + (C * 60) + (D * 10));



                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo18.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();

                    Form1.click_selecionar[1] = TP_18;
                    Form1.img = Properties.Resources.temporizador_18;


                }
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                trackBar_maximo.Enabled = false;
                trackBar_minimo.Enabled = false;
                tracBar_fabrica.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tb_comentario.Text = Form1.linha80.Trim();
            if (rb_parametroFixo.Checked == true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }

            if (radioButton3.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                trackBar_maximo.Enabled = true;
                trackBar_minimo.Enabled = true;
                tracBar_fabrica.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                if (radioButton3.Text == "Tempo 3")
                {
                    arquivoTempo = 3;

                    char[] Tempo3 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT03.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo3.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo3[0];
                        vetorSemVisualizar[1] = Tempo3[1];
                        vetorSemVisualizar[2] = Tempo3[2];
                        vetorSemVisualizar[3] = Tempo3[3];
                        vetorSemVisualizar[4] = Tempo3[4];
                        vetorSemVisualizar[5] = Tempo3[5];
                        vetorSemVisualizar[6] = Tempo3[6];
                        vetorSemVisualizar[7] = Tempo3[7];
                        vetorSemVisualizar[8] = Tempo3[8];
                        vetorSemVisualizar[9] = Tempo3[9];
                        vetorSemVisualizar[10] = Tempo3[10];
                        vetorSemVisualizar[11] = Tempo3[11];
                        vetorSemVisualizar[12] = Tempo3[12];
                        vetorSemVisualizar[13] = Tempo3[13];
                        vetorSemVisualizar[14] = Tempo3[14];
                        vetorSemVisualizar[15] = Tempo3[15];
                        vetorSemVisualizar[16] = Tempo3[16];
                        vetorSemVisualizar[17] = Tempo3[17];
                        vetorSemVisualizar[18] = Tempo3[18];
                        vetorSemVisualizar[19] = Tempo3[19];
                        vetorSemVisualizar[20] = Tempo3[20];
                        vetorSemVisualizar[21] = Tempo3[21];
                        vetorSemVisualizar[22] = Tempo3[22];
                        vetorSemVisualizar[23] = Tempo3[23];
                        vetorSemVisualizar[24] = Tempo3[24];

                        value1 = int.Parse(Tempo3[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo3[27].ToString()) * 100;
                        value3 = int.Parse(Tempo3[28].ToString()) * 10;
                        value4 = int.Parse(Tempo3[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo3[26];
                        fabrica2 = Tempo3[27];
                        fabrica3 = Tempo3[28];
                        fabrica4 = Tempo3[29];

                        tracBar_fabrica.Value = value;


                        textBox1.Text = Tempo3[26].ToString() + Tempo3[27].ToString() + Tempo3[28].ToString() + "." + Tempo3[29].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo3.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo3[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo3[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo3[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo3[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo3[31];
                        max2 = Tempo3[32];
                        max3 = Tempo3[33];
                        max4 = Tempo3[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo3[31].ToString() + Tempo3[32].ToString() + Tempo3[33].ToString() + "." + Tempo3[34].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo3.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo3[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo3[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo3[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo3[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo3[36];
                        min2 = Tempo3[37];
                        min3 = Tempo3[38];
                        min4 = Tempo3[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo3[36].ToString() + Tempo3[37].ToString() + Tempo3[38].ToString() + "." + Tempo3[39].ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo03.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();

                    Form1.click_selecionar[1] = TP_03;
                    Form1.img = Properties.Resources.temporizador_03;
                }

                if (radioButton3.Text == "Tempo 11")
                {
                    arquivoTempo = 11;

                    char[] Tempo11 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT11.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo11.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo11[0];
                        vetorSemVisualizar[1] = Tempo11[1];
                        vetorSemVisualizar[2] = Tempo11[2];
                        vetorSemVisualizar[3] = Tempo11[3];
                        vetorSemVisualizar[4] = Tempo11[4];
                        vetorSemVisualizar[5] = Tempo11[5];
                        vetorSemVisualizar[6] = Tempo11[6];
                        vetorSemVisualizar[7] = Tempo11[7];
                        vetorSemVisualizar[8] = Tempo11[8];
                        vetorSemVisualizar[9] = Tempo11[9];
                        vetorSemVisualizar[10] = Tempo11[10];
                        vetorSemVisualizar[11] = Tempo11[11];
                        vetorSemVisualizar[12] = Tempo11[12];
                        vetorSemVisualizar[13] = Tempo11[13];
                        vetorSemVisualizar[14] = Tempo11[14];
                        vetorSemVisualizar[15] = Tempo11[15];
                        vetorSemVisualizar[16] = Tempo11[16];
                        vetorSemVisualizar[17] = Tempo11[17];
                        vetorSemVisualizar[18] = Tempo11[18];
                        vetorSemVisualizar[19] = Tempo11[19];
                        vetorSemVisualizar[20] = Tempo11[20];
                        vetorSemVisualizar[21] = Tempo11[21];
                        vetorSemVisualizar[22] = Tempo11[22];
                        vetorSemVisualizar[23] = Tempo11[23];
                        vetorSemVisualizar[24] = Tempo11[24];

                        value1 = int.Parse(Tempo11[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo11[27].ToString()) * 100;
                        value3 = int.Parse(Tempo11[28].ToString()) * 10;
                        value4 = int.Parse(Tempo11[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo11[26];
                        fabrica2 = Tempo11[27];
                        fabrica3 = Tempo11[28];
                        fabrica4 = Tempo11[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = tracBar_fabrica.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo11.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo11[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo11[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo11[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo11[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;



                        max1 = Tempo11[31];
                        max2 = Tempo11[32];
                        max3 = Tempo11[33];
                        max4 = Tempo11[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = trackBar_maximo.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo11.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo11[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo11[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo11[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo11[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                        min1 = Tempo11[36];
                        min2 = Tempo11[37];
                        min3 = Tempo11[38];
                        min4 = Tempo11[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = trackBar_minimo.Value.ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo11.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();

                    Form1.click_selecionar[1] = TP_11;
                    Form1.img = Properties.Resources.temporizador_11;

                }

                if (radioButton3.Text == "Tempo 19")
                {
                    arquivoTempo = 19;

                    char[] Tempo19 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT19.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo19.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo19[0];
                        vetorSemVisualizar[1] = Tempo19[1];
                        vetorSemVisualizar[2] = Tempo19[2];
                        vetorSemVisualizar[3] = Tempo19[3];
                        vetorSemVisualizar[4] = Tempo19[4];
                        vetorSemVisualizar[5] = Tempo19[5];
                        vetorSemVisualizar[6] = Tempo19[6];
                        vetorSemVisualizar[7] = Tempo19[7];
                        vetorSemVisualizar[8] = Tempo19[8];
                        vetorSemVisualizar[9] = Tempo19[9];
                        vetorSemVisualizar[10] = Tempo19[10];
                        vetorSemVisualizar[11] = Tempo19[11];
                        vetorSemVisualizar[12] = Tempo19[12];
                        vetorSemVisualizar[13] = Tempo19[13];
                        vetorSemVisualizar[14] = Tempo19[14];
                        vetorSemVisualizar[15] = Tempo19[15];
                        vetorSemVisualizar[16] = Tempo19[16];
                        vetorSemVisualizar[17] = Tempo19[17];
                        vetorSemVisualizar[18] = Tempo19[18];
                        vetorSemVisualizar[19] = Tempo19[19];
                        vetorSemVisualizar[20] = Tempo19[20];
                        vetorSemVisualizar[21] = Tempo19[21];
                        vetorSemVisualizar[22] = Tempo19[22];
                        vetorSemVisualizar[23] = Tempo19[23];
                        vetorSemVisualizar[24] = Tempo19[24];

                        value1 = int.Parse(Tempo19[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo19[27].ToString()) * 100;
                        value3 = int.Parse(Tempo19[28].ToString()) * 10;
                        value4 = int.Parse(Tempo19[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo19[26];
                        fabrica2 = Tempo19[27];
                        fabrica3 = Tempo19[28];
                        fabrica4 = Tempo19[29];

                        tracBar_fabrica.Value = value;
                        textBox1.Text = Tempo19[26].ToString() + Tempo19[27].ToString() + ":" + Tempo19[28].ToString() + Tempo19[29].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo19.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo19[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo19[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo19[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo19[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        if (valueMAX > 5940)
                        {
                            valueMAX = 5940;
                        }

                        max1 = Tempo19[31];
                        max2 = Tempo19[32];
                        max3 = Tempo19[33];
                        max4 = Tempo19[34];


                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo19[31].ToString() + Tempo19[32].ToString() + ":" + Tempo19[33].ToString() + Tempo19[34].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo19.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo19[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo19[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo19[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo19[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo19[36];
                        min2 = Tempo19[37];
                        min3 = Tempo19[38];
                        min4 = Tempo19[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = Tempo19[36].ToString() + Tempo19[37].ToString() + ":" + Tempo19[38].ToString() + Tempo19[39].ToString() + "h";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo19.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_19;
                    Form1.img = Properties.Resources.temporizador_19;

                }
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                trackBar_maximo.Enabled = false;
                trackBar_minimo.Enabled = false;
                tracBar_fabrica.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tb_comentario.Text = Form1.linha81.Trim();
            if (rb_parametroFixo.Checked == true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (radioButton4.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                trackBar_maximo.Enabled = true;
                trackBar_minimo.Enabled = true;
                tracBar_fabrica.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                if (radioButton4.Text == "Tempo 4")
                {
                    arquivoTempo = 4;

                    char[] Tempo4 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT04.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo4.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo4[0];
                        vetorSemVisualizar[1] = Tempo4[1];
                        vetorSemVisualizar[2] = Tempo4[2];
                        vetorSemVisualizar[3] = Tempo4[3];
                        vetorSemVisualizar[4] = Tempo4[4];
                        vetorSemVisualizar[5] = Tempo4[5];
                        vetorSemVisualizar[6] = Tempo4[6];
                        vetorSemVisualizar[7] = Tempo4[7];
                        vetorSemVisualizar[8] = Tempo4[8];
                        vetorSemVisualizar[9] = Tempo4[9];
                        vetorSemVisualizar[10] = Tempo4[10];
                        vetorSemVisualizar[11] = Tempo4[11];
                        vetorSemVisualizar[12] = Tempo4[12];
                        vetorSemVisualizar[13] = Tempo4[13];
                        vetorSemVisualizar[14] = Tempo4[14];
                        vetorSemVisualizar[15] = Tempo4[15];
                        vetorSemVisualizar[16] = Tempo4[16];
                        vetorSemVisualizar[17] = Tempo4[17];
                        vetorSemVisualizar[18] = Tempo4[18];
                        vetorSemVisualizar[19] = Tempo4[19];
                        vetorSemVisualizar[20] = Tempo4[20];
                        vetorSemVisualizar[21] = Tempo4[21];
                        vetorSemVisualizar[22] = Tempo4[22];
                        vetorSemVisualizar[23] = Tempo4[23];
                        vetorSemVisualizar[24] = Tempo4[24];

                        value1 = int.Parse(Tempo4[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo4[27].ToString()) * 100;
                        value3 = int.Parse(Tempo4[28].ToString()) * 10;
                        value4 = int.Parse(Tempo4[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo4[26];
                        fabrica2 = Tempo4[27];
                        fabrica3 = Tempo4[28];
                        fabrica4 = Tempo4[29];

                        tracBar_fabrica.Value = value;


                        textBox1.Text = Tempo4[26].ToString() + Tempo4[27].ToString() + Tempo4[28].ToString() + "." + Tempo4[29].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo4.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo4[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo4[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo4[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo4[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo4[31];
                        max2 = Tempo4[32];
                        max3 = Tempo4[33];
                        max4 = Tempo4[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo4[31].ToString() + Tempo4[32].ToString() + Tempo4[33].ToString() + "." + Tempo4[34].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo4.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo4[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo4[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo4[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo4[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo4[36];
                        min2 = Tempo4[37];
                        min3 = Tempo4[38];
                        min4 = Tempo4[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo4[36].ToString() + Tempo4[37].ToString() + Tempo4[38].ToString() + "." + Tempo4[39].ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo04.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_04;
                    Form1.img = Properties.Resources.temporizador_04;
                }

                if (radioButton4.Text == "Tempo 12")
                {
                    arquivoTempo = 12;

                    char[] Tempo12 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT12.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo12.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo12[0];
                        vetorSemVisualizar[1] = Tempo12[1];
                        vetorSemVisualizar[2] = Tempo12[2];
                        vetorSemVisualizar[3] = Tempo12[3];
                        vetorSemVisualizar[4] = Tempo12[4];
                        vetorSemVisualizar[5] = Tempo12[5];
                        vetorSemVisualizar[6] = Tempo12[6];
                        vetorSemVisualizar[7] = Tempo12[7];
                        vetorSemVisualizar[8] = Tempo12[8];
                        vetorSemVisualizar[9] = Tempo12[9];
                        vetorSemVisualizar[10] = Tempo12[10];
                        vetorSemVisualizar[11] = Tempo12[11];
                        vetorSemVisualizar[12] = Tempo12[12];
                        vetorSemVisualizar[13] = Tempo12[13];
                        vetorSemVisualizar[14] = Tempo12[14];
                        vetorSemVisualizar[15] = Tempo12[15];
                        vetorSemVisualizar[16] = Tempo12[16];
                        vetorSemVisualizar[17] = Tempo12[17];
                        vetorSemVisualizar[18] = Tempo12[18];
                        vetorSemVisualizar[19] = Tempo12[19];
                        vetorSemVisualizar[20] = Tempo12[20];
                        vetorSemVisualizar[21] = Tempo12[21];
                        vetorSemVisualizar[22] = Tempo12[22];
                        vetorSemVisualizar[23] = Tempo12[23];
                        vetorSemVisualizar[24] = Tempo12[24];

                        value1 = int.Parse(Tempo12[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo12[27].ToString()) * 100;
                        value3 = int.Parse(Tempo12[28].ToString()) * 10;
                        value4 = int.Parse(Tempo12[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo12[26];
                        fabrica2 = Tempo12[27];
                        fabrica3 = Tempo12[28];
                        fabrica4 = Tempo12[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = tracBar_fabrica.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo12.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo12[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo12[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo12[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo12[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;



                        max1 = Tempo12[31];
                        max2 = Tempo12[32];
                        max3 = Tempo12[33];
                        max4 = Tempo12[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = trackBar_maximo.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo12.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo12[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo12[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo12[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo12[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                        min1 = Tempo12[36];
                        min2 = Tempo12[37];
                        min3 = Tempo12[38];
                        min4 = Tempo12[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = trackBar_minimo.Value.ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo12.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_12;
                    Form1.img = Properties.Resources.temporizador_12;

                }

                if (radioButton4.Text == "Tempo 20")
                {
                    arquivoTempo = 20;

                    char[] Tempo20 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT20.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo20.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo20[0];
                        vetorSemVisualizar[1] = Tempo20[1];
                        vetorSemVisualizar[2] = Tempo20[2];
                        vetorSemVisualizar[3] = Tempo20[3];
                        vetorSemVisualizar[4] = Tempo20[4];
                        vetorSemVisualizar[5] = Tempo20[5];
                        vetorSemVisualizar[6] = Tempo20[6];
                        vetorSemVisualizar[7] = Tempo20[7];
                        vetorSemVisualizar[8] = Tempo20[8];
                        vetorSemVisualizar[9] = Tempo20[9];
                        vetorSemVisualizar[10] = Tempo20[10];
                        vetorSemVisualizar[11] = Tempo20[11];
                        vetorSemVisualizar[12] = Tempo20[12];
                        vetorSemVisualizar[13] = Tempo20[13];
                        vetorSemVisualizar[14] = Tempo20[14];
                        vetorSemVisualizar[15] = Tempo20[15];
                        vetorSemVisualizar[16] = Tempo20[16];
                        vetorSemVisualizar[17] = Tempo20[17];
                        vetorSemVisualizar[18] = Tempo20[18];
                        vetorSemVisualizar[19] = Tempo20[19];
                        vetorSemVisualizar[20] = Tempo20[20];
                        vetorSemVisualizar[21] = Tempo20[21];
                        vetorSemVisualizar[22] = Tempo20[22];
                        vetorSemVisualizar[23] = Tempo20[23];
                        vetorSemVisualizar[24] = Tempo20[24];

                        value1 = int.Parse(Tempo20[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo20[27].ToString()) * 100;
                        value3 = int.Parse(Tempo20[28].ToString()) * 10;
                        value4 = int.Parse(Tempo20[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo20[26];
                        fabrica2 = Tempo20[27];
                        fabrica3 = Tempo20[28];
                        fabrica4 = Tempo20[29];

                        tracBar_fabrica.Value = value;
                        textBox1.Text = Tempo20[26].ToString() + Tempo20[27].ToString() + ":" + Tempo20[28].ToString() + Tempo20[29].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo20.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo20[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo20[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo20[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo20[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        if (valueMAX > 5940)
                        {
                            valueMAX = 5940;
                        }

                        max1 = Tempo20[31];
                        max2 = Tempo20[32];
                        max3 = Tempo20[33];
                        max4 = Tempo20[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo20[31].ToString() + Tempo20[32].ToString() + ":" + Tempo20[33].ToString() + Tempo20[34].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo20.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo20[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo20[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo20[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo20[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo20[36];
                        min2 = Tempo20[37];
                        min3 = Tempo20[38];
                        min4 = Tempo20[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo20[36].ToString() + Tempo20[37].ToString() + ":" + Tempo20[38].ToString() + Tempo20[39].ToString() + "h";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo20.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_20;
                    Form1.img = Properties.Resources.temporizador_20;
                }
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                trackBar_maximo.Enabled = false;
                trackBar_minimo.Enabled = false;
                tracBar_fabrica.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            tb_comentario.Text = Form1.linha82.Trim();
            if (rb_parametroFixo.Checked == true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (radioButton8.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                trackBar_maximo.Enabled = true;
                trackBar_minimo.Enabled = true;
                tracBar_fabrica.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                if (radioButton8.Text == "Tempo 5")
                {
                    arquivoTempo = 5;

                    char[] Tempo5 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT05.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo5.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo5[0];
                        vetorSemVisualizar[1] = Tempo5[1];
                        vetorSemVisualizar[2] = Tempo5[2];
                        vetorSemVisualizar[3] = Tempo5[3];
                        vetorSemVisualizar[4] = Tempo5[4];
                        vetorSemVisualizar[5] = Tempo5[5];
                        vetorSemVisualizar[6] = Tempo5[6];
                        vetorSemVisualizar[7] = Tempo5[7];
                        vetorSemVisualizar[8] = Tempo5[8];
                        vetorSemVisualizar[9] = Tempo5[9];
                        vetorSemVisualizar[10] = Tempo5[10];
                        vetorSemVisualizar[11] = Tempo5[11];
                        vetorSemVisualizar[12] = Tempo5[12];
                        vetorSemVisualizar[13] = Tempo5[13];
                        vetorSemVisualizar[14] = Tempo5[14];
                        vetorSemVisualizar[15] = Tempo5[15];
                        vetorSemVisualizar[16] = Tempo5[16];
                        vetorSemVisualizar[17] = Tempo5[17];
                        vetorSemVisualizar[18] = Tempo5[18];
                        vetorSemVisualizar[19] = Tempo5[19];
                        vetorSemVisualizar[20] = Tempo5[20];
                        vetorSemVisualizar[21] = Tempo5[21];
                        vetorSemVisualizar[22] = Tempo5[22];
                        vetorSemVisualizar[23] = Tempo5[23];
                        vetorSemVisualizar[24] = Tempo5[24];

                        value1 = int.Parse(Tempo5[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo5[27].ToString()) * 100;
                        value3 = int.Parse(Tempo5[28].ToString()) * 10;
                        value4 = int.Parse(Tempo5[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo5[26];
                        fabrica2 = Tempo5[27];
                        fabrica3 = Tempo5[28];
                        fabrica4 = Tempo5[29];

                        tracBar_fabrica.Value = value;


                        textBox1.Text = Tempo5[26].ToString() + Tempo5[27].ToString() + Tempo5[28].ToString() + "." + Tempo5[29].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo5.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo5[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo5[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo5[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo5[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo5[31];
                        max2 = Tempo5[32];
                        max3 = Tempo5[33];
                        max4 = Tempo5[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo5[31].ToString() + Tempo5[32].ToString() + Tempo5[33].ToString() + "." + Tempo5[34].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo5.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo5[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo5[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo5[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo5[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo5[36];
                        min2 = Tempo5[37];
                        min3 = Tempo5[38];
                        min4 = Tempo5[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo5[36].ToString() + Tempo5[37].ToString() + Tempo5[38].ToString() + "." + Tempo5[39].ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo05.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_05;
                    Form1.img = Properties.Resources.temporizador_05;
                }

                if (radioButton8.Text == "Tempo 13")
                {
                    arquivoTempo = 13;

                    char[] Tempo13 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT13.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo13.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo13[0];
                        vetorSemVisualizar[1] = Tempo13[1];
                        vetorSemVisualizar[2] = Tempo13[2];
                        vetorSemVisualizar[3] = Tempo13[3];
                        vetorSemVisualizar[4] = Tempo13[4];
                        vetorSemVisualizar[5] = Tempo13[5];
                        vetorSemVisualizar[6] = Tempo13[6];
                        vetorSemVisualizar[7] = Tempo13[7];
                        vetorSemVisualizar[8] = Tempo13[8];
                        vetorSemVisualizar[9] = Tempo13[9];
                        vetorSemVisualizar[10] = Tempo13[10];
                        vetorSemVisualizar[11] = Tempo13[11];
                        vetorSemVisualizar[12] = Tempo13[12];
                        vetorSemVisualizar[13] = Tempo13[13];
                        vetorSemVisualizar[14] = Tempo13[14];
                        vetorSemVisualizar[15] = Tempo13[15];
                        vetorSemVisualizar[16] = Tempo13[16];
                        vetorSemVisualizar[17] = Tempo13[17];
                        vetorSemVisualizar[18] = Tempo13[18];
                        vetorSemVisualizar[19] = Tempo13[19];
                        vetorSemVisualizar[20] = Tempo13[20];
                        vetorSemVisualizar[21] = Tempo13[21];
                        vetorSemVisualizar[22] = Tempo13[22];
                        vetorSemVisualizar[23] = Tempo13[23];
                        vetorSemVisualizar[24] = Tempo13[24];

                        value1 = int.Parse(Tempo13[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo13[27].ToString()) * 100;
                        value3 = int.Parse(Tempo13[28].ToString()) * 10;
                        value4 = int.Parse(Tempo13[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo13[26];
                        fabrica2 = Tempo13[27];
                        fabrica3 = Tempo13[28];
                        fabrica4 = Tempo13[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = tracBar_fabrica.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo13.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo13[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo13[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo13[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo13[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;



                        max1 = Tempo13[31];
                        max2 = Tempo13[32];
                        max3 = Tempo13[33];
                        max4 = Tempo13[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = trackBar_maximo.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo13.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo13[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo13[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo13[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo13[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                        min1 = Tempo13[36];
                        min2 = Tempo13[37];
                        min3 = Tempo13[38];
                        min4 = Tempo13[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = trackBar_minimo.Value.ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo13.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_13;
                    Form1.img = Properties.Resources.temporizador_13;
                }

                if (radioButton8.Text == "Tempo 21")
                {
                    arquivoTempo = 21;

                    char[] Tempo21 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT21.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo21.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo21[0];
                        vetorSemVisualizar[1] = Tempo21[1];
                        vetorSemVisualizar[2] = Tempo21[2];
                        vetorSemVisualizar[3] = Tempo21[3];
                        vetorSemVisualizar[4] = Tempo21[4];
                        vetorSemVisualizar[5] = Tempo21[5];
                        vetorSemVisualizar[6] = Tempo21[6];
                        vetorSemVisualizar[7] = Tempo21[7];
                        vetorSemVisualizar[8] = Tempo21[8];
                        vetorSemVisualizar[9] = Tempo21[9];
                        vetorSemVisualizar[10] = Tempo21[10];
                        vetorSemVisualizar[11] = Tempo21[11];
                        vetorSemVisualizar[12] = Tempo21[12];
                        vetorSemVisualizar[13] = Tempo21[13];
                        vetorSemVisualizar[14] = Tempo21[14];
                        vetorSemVisualizar[15] = Tempo21[15];
                        vetorSemVisualizar[16] = Tempo21[16];
                        vetorSemVisualizar[17] = Tempo21[17];
                        vetorSemVisualizar[18] = Tempo21[18];
                        vetorSemVisualizar[19] = Tempo21[19];
                        vetorSemVisualizar[20] = Tempo21[20];
                        vetorSemVisualizar[21] = Tempo21[21];
                        vetorSemVisualizar[22] = Tempo21[22];
                        vetorSemVisualizar[23] = Tempo21[23];
                        vetorSemVisualizar[24] = Tempo21[24];

                        value1 = int.Parse(Tempo21[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo21[27].ToString()) * 100;
                        value3 = int.Parse(Tempo21[28].ToString()) * 10;
                        value4 = int.Parse(Tempo21[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo21[26];
                        fabrica2 = Tempo21[27];
                        fabrica3 = Tempo21[28];
                        fabrica4 = Tempo21[29];

                        tracBar_fabrica.Value = value;
                        textBox1.Text = Tempo21[26].ToString() + Tempo21[27].ToString() + ":" + Tempo21[28].ToString() + Tempo21[29].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo21.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo21[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo21[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo21[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo21[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        if (valueMAX > 5940)
                        {
                            valueMAX = 5940;
                        }

                        max1 = Tempo21[31];
                        max2 = Tempo21[32];
                        max3 = Tempo21[33];
                        max4 = Tempo21[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo21[31].ToString() + Tempo21[32].ToString() + ":" + Tempo21[33].ToString() + Tempo21[34].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo21.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo21[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo21[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo21[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo21[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo21[36];
                        min2 = Tempo21[37];
                        min3 = Tempo21[38];
                        min4 = Tempo21[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo21[36].ToString() + Tempo21[37].ToString() + ":" + Tempo21[38].ToString() + Tempo21[39].ToString() + "h";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo21.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_21;
                    Form1.img = Properties.Resources.temporizador_21;
                }
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                trackBar_maximo.Enabled = false;
                trackBar_minimo.Enabled = false;
                tracBar_fabrica.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            tb_comentario.Text = Form1.linha85.Trim();

            if (rb_parametroFixo.Checked == true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }

            if (radioButton7.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                trackBar_maximo.Enabled = true;
                trackBar_minimo.Enabled = true;
                tracBar_fabrica.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;

                if (radioButton7.Text == "Tempo 8")
                {
                    arquivoTempo = 8;

                    char[] Tempo8 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT08.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo8.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo8[0];
                        vetorSemVisualizar[1] = Tempo8[1];
                        vetorSemVisualizar[2] = Tempo8[2];
                        vetorSemVisualizar[3] = Tempo8[3];
                        vetorSemVisualizar[4] = Tempo8[4];
                        vetorSemVisualizar[5] = Tempo8[5];
                        vetorSemVisualizar[6] = Tempo8[6];
                        vetorSemVisualizar[7] = Tempo8[7];
                        vetorSemVisualizar[8] = Tempo8[8];
                        vetorSemVisualizar[9] = Tempo8[9];
                        vetorSemVisualizar[10] = Tempo8[10];
                        vetorSemVisualizar[11] = Tempo8[11];
                        vetorSemVisualizar[12] = Tempo8[12];
                        vetorSemVisualizar[13] = Tempo8[13];
                        vetorSemVisualizar[14] = Tempo8[14];
                        vetorSemVisualizar[15] = Tempo8[15];
                        vetorSemVisualizar[16] = Tempo8[16];
                        vetorSemVisualizar[17] = Tempo8[17];
                        vetorSemVisualizar[18] = Tempo8[18];
                        vetorSemVisualizar[19] = Tempo8[19];
                        vetorSemVisualizar[20] = Tempo8[20];
                        vetorSemVisualizar[21] = Tempo8[21];
                        vetorSemVisualizar[22] = Tempo8[22];
                        vetorSemVisualizar[23] = Tempo8[23];
                        vetorSemVisualizar[24] = Tempo8[24];

                        value1 = int.Parse(Tempo8[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo8[27].ToString()) * 100;
                        value3 = int.Parse(Tempo8[28].ToString()) * 10;
                        value4 = int.Parse(Tempo8[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo8[26];
                        fabrica2 = Tempo8[27];
                        fabrica3 = Tempo8[28];
                        fabrica4 = Tempo8[29];

                        tracBar_fabrica.Value = value;


                        textBox1.Text = Tempo8[26].ToString() + Tempo8[27].ToString() + Tempo8[28].ToString() + "." + Tempo8[29].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo8.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo8[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo8[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo8[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo8[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo8[31];
                        max2 = Tempo8[32];
                        max3 = Tempo8[33];
                        max4 = Tempo8[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo8[31].ToString() + Tempo8[32].ToString() + Tempo8[33].ToString() + "." + Tempo8[34].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo8.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo8[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo8[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo8[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo8[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo8[36];
                        min2 = Tempo8[37];
                        min3 = Tempo8[38];
                        min4 = Tempo8[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo8[36].ToString() + Tempo8[37].ToString() + Tempo8[38].ToString() + "." + Tempo8[39].ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo08.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_08;
                    Form1.img = Properties.Resources.temporizador_08;
                }

                if (radioButton7.Text == "Tempo 16")
                {
                    arquivoTempo = 16;

                    char[] Tempo16 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT16.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo16.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo16[0];
                        vetorSemVisualizar[1] = Tempo16[1];
                        vetorSemVisualizar[2] = Tempo16[2];
                        vetorSemVisualizar[3] = Tempo16[3];
                        vetorSemVisualizar[4] = Tempo16[4];
                        vetorSemVisualizar[5] = Tempo16[5];
                        vetorSemVisualizar[6] = Tempo16[6];
                        vetorSemVisualizar[7] = Tempo16[7];
                        vetorSemVisualizar[8] = Tempo16[8];
                        vetorSemVisualizar[9] = Tempo16[9];
                        vetorSemVisualizar[10] = Tempo16[10];
                        vetorSemVisualizar[11] = Tempo16[11];
                        vetorSemVisualizar[12] = Tempo16[12];
                        vetorSemVisualizar[13] = Tempo16[13];
                        vetorSemVisualizar[14] = Tempo16[14];
                        vetorSemVisualizar[15] = Tempo16[15];
                        vetorSemVisualizar[16] = Tempo16[16];
                        vetorSemVisualizar[17] = Tempo16[17];
                        vetorSemVisualizar[18] = Tempo16[18];
                        vetorSemVisualizar[19] = Tempo16[19];
                        vetorSemVisualizar[20] = Tempo16[20];
                        vetorSemVisualizar[21] = Tempo16[21];
                        vetorSemVisualizar[22] = Tempo16[22];
                        vetorSemVisualizar[23] = Tempo16[23];
                        vetorSemVisualizar[24] = Tempo16[24];

                        value1 = int.Parse(Tempo16[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo16[27].ToString()) * 100;
                        value3 = int.Parse(Tempo16[28].ToString()) * 10;
                        value4 = int.Parse(Tempo16[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo16[26];
                        fabrica2 = Tempo16[27];
                        fabrica3 = Tempo16[28];
                        fabrica4 = Tempo16[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = tracBar_fabrica.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo16.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo16[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo16[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo16[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo16[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;



                        max1 = Tempo16[31];
                        max2 = Tempo16[32];
                        max3 = Tempo16[33];
                        max4 = Tempo16[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = trackBar_maximo.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo16.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo16[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo16[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo16[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo16[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                        min1 = Tempo16[36];
                        min2 = Tempo16[37];
                        min3 = Tempo16[38];
                        min4 = Tempo16[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = trackBar_minimo.Value.ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo16.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_16;
                    Form1.img = Properties.Resources.temporizador_16;
                }

                if (radioButton7.Text == "Tempo 24")
                {
                    arquivoTempo = 24;

                    char[] Tempo24 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT24.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[6];
                    char[] vetorTxt2 = new char[6];
                    char[] vetorTxt3 = new char[6];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo24.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo24[0];
                        vetorSemVisualizar[1] = Tempo24[1];
                        vetorSemVisualizar[2] = Tempo24[2];
                        vetorSemVisualizar[3] = Tempo24[3];
                        vetorSemVisualizar[4] = Tempo24[4];
                        vetorSemVisualizar[5] = Tempo24[5];
                        vetorSemVisualizar[6] = Tempo24[6];
                        vetorSemVisualizar[7] = Tempo24[7];
                        vetorSemVisualizar[8] = Tempo24[8];
                        vetorSemVisualizar[9] = Tempo24[9];
                        vetorSemVisualizar[10] = Tempo24[10];
                        vetorSemVisualizar[11] = Tempo24[11];
                        vetorSemVisualizar[12] = Tempo24[12];
                        vetorSemVisualizar[13] = Tempo24[13];
                        vetorSemVisualizar[14] = Tempo24[14];
                        vetorSemVisualizar[15] = Tempo24[15];
                        vetorSemVisualizar[16] = Tempo24[16];
                        vetorSemVisualizar[17] = Tempo24[17];
                        vetorSemVisualizar[18] = Tempo24[18];
                        vetorSemVisualizar[19] = Tempo24[19];
                        vetorSemVisualizar[20] = Tempo24[20];
                        vetorSemVisualizar[21] = Tempo24[21];
                        vetorSemVisualizar[22] = Tempo24[22];
                        vetorSemVisualizar[23] = Tempo24[23];
                        vetorSemVisualizar[24] = Tempo24[24];

                        value1 = int.Parse(Tempo24[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo24[27].ToString()) * 100;
                        value3 = int.Parse(Tempo24[28].ToString()) * 10;
                        value4 = int.Parse(Tempo24[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo24[26];
                        fabrica2 = Tempo24[27];
                        fabrica3 = Tempo24[28];
                        fabrica4 = Tempo24[29];

                        tracBar_fabrica.Value = value;
                        textBox1.Text = Tempo24[26].ToString() + Tempo24[27].ToString() + ":" + Tempo24[28].ToString() + Tempo24[29].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo24.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo24[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo24[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo24[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo24[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        if (valueMAX > 5940)
                        {
                            valueMAX = 5940;
                        }

                        max1 = Tempo24[31];
                        max2 = Tempo24[32];
                        max3 = Tempo24[33];
                        max4 = Tempo24[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox1.Text = Tempo24[31].ToString() + Tempo24[32].ToString() + ":" + Tempo24[33].ToString() + Tempo24[34].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo24.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo24[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo24[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo24[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo24[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo24[36];
                        min2 = Tempo24[37];
                        min3 = Tempo24[38];
                        min4 = Tempo24[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox1.Text = Tempo24[36].ToString() + Tempo24[37].ToString() + ":" + Tempo24[38].ToString() + Tempo24[39].ToString() + "h";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo24.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_24;
                    Form1.img = Properties.Resources.temporizador_24;
                }
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                trackBar_maximo.Enabled = false;
                trackBar_minimo.Enabled = false;
                tracBar_fabrica.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            tb_comentario.Text = Form1.linha83.Trim();

            if (rb_parametroFixo.Checked == true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (radioButton6.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                trackBar_maximo.Enabled = true;
                trackBar_minimo.Enabled = true;
                tracBar_fabrica.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                if (radioButton6.Text == "Tempo 6")
                {
                    arquivoTempo = 6;

                    char[] Tempo6 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT06.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo6.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo6[0];
                        vetorSemVisualizar[1] = Tempo6[1];
                        vetorSemVisualizar[2] = Tempo6[2];
                        vetorSemVisualizar[3] = Tempo6[3];
                        vetorSemVisualizar[4] = Tempo6[4];
                        vetorSemVisualizar[5] = Tempo6[5];
                        vetorSemVisualizar[6] = Tempo6[6];
                        vetorSemVisualizar[7] = Tempo6[7];
                        vetorSemVisualizar[8] = Tempo6[8];
                        vetorSemVisualizar[9] = Tempo6[9];
                        vetorSemVisualizar[10] = Tempo6[10];
                        vetorSemVisualizar[11] = Tempo6[11];
                        vetorSemVisualizar[12] = Tempo6[12];
                        vetorSemVisualizar[13] = Tempo6[13];
                        vetorSemVisualizar[14] = Tempo6[14];
                        vetorSemVisualizar[15] = Tempo6[15];
                        vetorSemVisualizar[16] = Tempo6[16];
                        vetorSemVisualizar[17] = Tempo6[17];
                        vetorSemVisualizar[18] = Tempo6[18];
                        vetorSemVisualizar[19] = Tempo6[19];
                        vetorSemVisualizar[20] = Tempo6[20];
                        vetorSemVisualizar[21] = Tempo6[21];
                        vetorSemVisualizar[22] = Tempo6[22];
                        vetorSemVisualizar[23] = Tempo6[23];
                        vetorSemVisualizar[24] = Tempo6[24];

                        value1 = int.Parse(Tempo6[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo6[27].ToString()) * 100;
                        value3 = int.Parse(Tempo6[28].ToString()) * 10;
                        value4 = int.Parse(Tempo6[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo6[26];
                        fabrica2 = Tempo6[27];
                        fabrica3 = Tempo6[28];
                        fabrica4 = Tempo6[29];

                        tracBar_fabrica.Value = value;


                        textBox1.Text = Tempo6[26].ToString() + Tempo6[27].ToString() + Tempo6[28].ToString() + "." + Tempo6[29].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo6.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo6[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo6[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo6[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo6[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo6[31];
                        max2 = Tempo6[32];
                        max3 = Tempo6[33];
                        max4 = Tempo6[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo6[31].ToString() + Tempo6[32].ToString() + Tempo6[33].ToString() + "." + Tempo6[34].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo6.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo6[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo6[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo6[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo6[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo6[36];
                        min2 = Tempo6[37];
                        min3 = Tempo6[38];
                        min4 = Tempo6[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo6[36].ToString() + Tempo6[37].ToString() + Tempo6[38].ToString() + "." + Tempo6[39].ToString() + "s";
                    }



                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo06.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_06;
                    Form1.img = Properties.Resources.temporizador_06;
                }
                if (radioButton6.Text == "Tempo 14")
                {
                    arquivoTempo = 14;

                    char[] Tempo14 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT14.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo14.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo14[0];
                        vetorSemVisualizar[1] = Tempo14[1];
                        vetorSemVisualizar[2] = Tempo14[2];
                        vetorSemVisualizar[3] = Tempo14[3];
                        vetorSemVisualizar[4] = Tempo14[4];
                        vetorSemVisualizar[5] = Tempo14[5];
                        vetorSemVisualizar[6] = Tempo14[6];
                        vetorSemVisualizar[7] = Tempo14[7];
                        vetorSemVisualizar[8] = Tempo14[8];
                        vetorSemVisualizar[9] = Tempo14[9];
                        vetorSemVisualizar[10] = Tempo14[10];
                        vetorSemVisualizar[11] = Tempo14[11];
                        vetorSemVisualizar[12] = Tempo14[12];
                        vetorSemVisualizar[13] = Tempo14[13];
                        vetorSemVisualizar[14] = Tempo14[14];
                        vetorSemVisualizar[15] = Tempo14[15];
                        vetorSemVisualizar[16] = Tempo14[16];
                        vetorSemVisualizar[17] = Tempo14[17];
                        vetorSemVisualizar[18] = Tempo14[18];
                        vetorSemVisualizar[19] = Tempo14[19];
                        vetorSemVisualizar[20] = Tempo14[20];
                        vetorSemVisualizar[21] = Tempo14[21];
                        vetorSemVisualizar[22] = Tempo14[22];
                        vetorSemVisualizar[23] = Tempo14[23];
                        vetorSemVisualizar[24] = Tempo14[24];

                        value1 = int.Parse(Tempo14[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo14[27].ToString()) * 100;
                        value3 = int.Parse(Tempo14[28].ToString()) * 10;
                        value4 = int.Parse(Tempo14[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo14[26];
                        fabrica2 = Tempo14[27];
                        fabrica3 = Tempo14[28];
                        fabrica4 = Tempo14[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = tracBar_fabrica.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo14.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo14[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo14[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo14[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo14[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;



                        max1 = Tempo14[31];
                        max2 = Tempo14[32];
                        max3 = Tempo14[33];
                        max4 = Tempo14[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = trackBar_maximo.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo14.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo14[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo14[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo14[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo14[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                        min1 = Tempo14[36];
                        min2 = Tempo14[37];
                        min3 = Tempo14[38];
                        min4 = Tempo14[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = trackBar_minimo.Value.ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo14.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_14;
                    Form1.img = Properties.Resources.temporizador_14;
                }
                if (radioButton6.Text == "Tempo 22")
                {
                    arquivoTempo = 22;

                    char[] Tempo22 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT22.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo22.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo22[0];
                        vetorSemVisualizar[1] = Tempo22[1];
                        vetorSemVisualizar[2] = Tempo22[2];
                        vetorSemVisualizar[3] = Tempo22[3];
                        vetorSemVisualizar[4] = Tempo22[4];
                        vetorSemVisualizar[5] = Tempo22[5];
                        vetorSemVisualizar[6] = Tempo22[6];
                        vetorSemVisualizar[7] = Tempo22[7];
                        vetorSemVisualizar[8] = Tempo22[8];
                        vetorSemVisualizar[9] = Tempo22[9];
                        vetorSemVisualizar[10] = Tempo22[10];
                        vetorSemVisualizar[11] = Tempo22[11];
                        vetorSemVisualizar[12] = Tempo22[12];
                        vetorSemVisualizar[13] = Tempo22[13];
                        vetorSemVisualizar[14] = Tempo22[14];
                        vetorSemVisualizar[15] = Tempo22[15];
                        vetorSemVisualizar[16] = Tempo22[16];
                        vetorSemVisualizar[17] = Tempo22[17];
                        vetorSemVisualizar[18] = Tempo22[18];
                        vetorSemVisualizar[19] = Tempo22[19];
                        vetorSemVisualizar[20] = Tempo22[20];
                        vetorSemVisualizar[21] = Tempo22[21];
                        vetorSemVisualizar[22] = Tempo22[22];
                        vetorSemVisualizar[23] = Tempo22[23];
                        vetorSemVisualizar[24] = Tempo22[24];

                        value1 = int.Parse(Tempo22[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo22[27].ToString()) * 100;
                        value3 = int.Parse(Tempo22[28].ToString()) * 10;
                        value4 = int.Parse(Tempo22[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo22[26];
                        fabrica2 = Tempo22[27];
                        fabrica3 = Tempo22[28];
                        fabrica4 = Tempo22[29];

                        tracBar_fabrica.Value = value;
                        textBox1.Text = Tempo22[26].ToString() + Tempo22[27].ToString() + ":" + Tempo22[28].ToString() + Tempo22[29].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo22.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo22[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo22[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo22[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo22[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        if (valueMAX > 5940)
                        {
                            valueMAX = 5940;
                        }

                        max1 = Tempo22[31];
                        max2 = Tempo22[32];
                        max3 = Tempo22[33];
                        max4 = Tempo22[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo22[31].ToString() + Tempo22[32].ToString() + ":" + Tempo22[33].ToString() + Tempo22[34].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo22.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo22[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo22[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo22[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo22[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo22[36];
                        min2 = Tempo22[37];
                        min3 = Tempo22[38];
                        min4 = Tempo22[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo22[36].ToString() + Tempo22[37].ToString() + ":" + Tempo22[38].ToString() + Tempo22[39].ToString() + "h";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo22.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_22;
                    Form1.img = Properties.Resources.temporizador_22;
                }
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                trackBar_maximo.Enabled = false;
                trackBar_minimo.Enabled = false;
                tracBar_fabrica.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tb_comentario.Text = Form1.linha84.Trim();

            if (rb_parametroFixo.Checked == true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (radioButton5.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                trackBar_maximo.Enabled = true;
                trackBar_minimo.Enabled = true;
                tracBar_fabrica.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                if (radioButton5.Text == "Tempo 7")
                {
                    arquivoTempo = 7;

                    char[] Tempo7 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT07.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo7.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo7[0];
                        vetorSemVisualizar[1] = Tempo7[1];
                        vetorSemVisualizar[2] = Tempo7[2];
                        vetorSemVisualizar[3] = Tempo7[3];
                        vetorSemVisualizar[4] = Tempo7[4];
                        vetorSemVisualizar[5] = Tempo7[5];
                        vetorSemVisualizar[6] = Tempo7[6];
                        vetorSemVisualizar[7] = Tempo7[7];
                        vetorSemVisualizar[8] = Tempo7[8];
                        vetorSemVisualizar[9] = Tempo7[9];
                        vetorSemVisualizar[10] = Tempo7[10];
                        vetorSemVisualizar[11] = Tempo7[11];
                        vetorSemVisualizar[12] = Tempo7[12];
                        vetorSemVisualizar[13] = Tempo7[13];
                        vetorSemVisualizar[14] = Tempo7[14];
                        vetorSemVisualizar[15] = Tempo7[15];
                        vetorSemVisualizar[16] = Tempo7[16];
                        vetorSemVisualizar[17] = Tempo7[17];
                        vetorSemVisualizar[18] = Tempo7[18];
                        vetorSemVisualizar[19] = Tempo7[19];
                        vetorSemVisualizar[20] = Tempo7[20];
                        vetorSemVisualizar[21] = Tempo7[21];
                        vetorSemVisualizar[22] = Tempo7[22];
                        vetorSemVisualizar[23] = Tempo7[23];
                        vetorSemVisualizar[24] = Tempo7[24];

                        value1 = int.Parse(Tempo7[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo7[27].ToString()) * 100;
                        value3 = int.Parse(Tempo7[28].ToString()) * 10;
                        value4 = int.Parse(Tempo7[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo7[26];
                        fabrica2 = Tempo7[27];
                        fabrica3 = Tempo7[28];
                        fabrica4 = Tempo7[29];

                        tracBar_fabrica.Value = value;


                        textBox1.Text = Tempo7[26].ToString() + Tempo7[27].ToString() + Tempo7[28].ToString() + "." + Tempo7[29].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo7.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo7[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo7[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo7[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo7[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        max1 = Tempo7[31];
                        max2 = Tempo7[32];
                        max3 = Tempo7[33];
                        max4 = Tempo7[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo7[31].ToString() + Tempo7[32].ToString() + Tempo7[33].ToString() + "." + Tempo7[34].ToString() + "s";
                    }
                    for (int x = 0; x < Tempo7.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo7[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo7[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo7[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo7[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo7[36];
                        min2 = Tempo7[37];
                        min3 = Tempo7[38];
                        min4 = Tempo7[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo7[36].ToString() + Tempo7[37].ToString() + Tempo7[38].ToString() + "." + Tempo7[39].ToString() + "s";
                    }


                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo07.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_07;
                    Form1.img = Properties.Resources.temporizador_07;
                }

                if (radioButton5.Text == "Tempo 15")
                {
                    arquivoTempo = 15;

                    char[] Tempo15 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT15.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo15.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo15[0];
                        vetorSemVisualizar[1] = Tempo15[1];
                        vetorSemVisualizar[2] = Tempo15[2];
                        vetorSemVisualizar[3] = Tempo15[3];
                        vetorSemVisualizar[4] = Tempo15[4];
                        vetorSemVisualizar[5] = Tempo15[5];
                        vetorSemVisualizar[6] = Tempo15[6];
                        vetorSemVisualizar[7] = Tempo15[7];
                        vetorSemVisualizar[8] = Tempo15[8];
                        vetorSemVisualizar[9] = Tempo15[9];
                        vetorSemVisualizar[10] = Tempo15[10];
                        vetorSemVisualizar[11] = Tempo15[11];
                        vetorSemVisualizar[12] = Tempo15[12];
                        vetorSemVisualizar[13] = Tempo15[13];
                        vetorSemVisualizar[14] = Tempo15[14];
                        vetorSemVisualizar[15] = Tempo15[15];
                        vetorSemVisualizar[16] = Tempo15[16];
                        vetorSemVisualizar[17] = Tempo15[17];
                        vetorSemVisualizar[18] = Tempo15[18];
                        vetorSemVisualizar[19] = Tempo15[19];
                        vetorSemVisualizar[20] = Tempo15[20];
                        vetorSemVisualizar[21] = Tempo15[21];
                        vetorSemVisualizar[22] = Tempo15[22];
                        vetorSemVisualizar[23] = Tempo15[23];
                        vetorSemVisualizar[24] = Tempo15[24];

                        value1 = int.Parse(Tempo15[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo15[27].ToString()) * 100;
                        value3 = int.Parse(Tempo15[28].ToString()) * 10;
                        value4 = int.Parse(Tempo15[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo15[26];
                        fabrica2 = Tempo15[27];
                        fabrica3 = Tempo15[28];
                        fabrica4 = Tempo15[29];

                        tracBar_fabrica.Value = value;

                        textBox1.Text = tracBar_fabrica.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo15.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo15[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo15[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo15[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo15[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;



                        max1 = Tempo15[31];
                        max2 = Tempo15[32];
                        max3 = Tempo15[33];
                        max4 = Tempo15[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = trackBar_maximo.Value.ToString() + "s";
                    }
                    for (int x = 0; x < Tempo15.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo15[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo15[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo15[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo15[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                        min1 = Tempo15[36];
                        min2 = Tempo15[37];
                        min3 = Tempo15[38];
                        min4 = Tempo15[39];
                        trackBar_minimo.Value = valueMIN;

                        textBox3.Text = trackBar_minimo.Value.ToString() + "s";
                    }

                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo15.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_15;
                    Form1.img = Properties.Resources.temporizador_15;
                }

                if (radioButton5.Text == "Tempo 23")
                {
                    arquivoTempo = 23;

                    char[] Tempo23 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT23.txt").ToCharArray();// vetor que pega os valores da escala de fabrica no arquivo
                    char[] vetorTxt1 = new char[5];
                    char[] vetorTxt2 = new char[5];
                    char[] vetorTxt3 = new char[5];

                    // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                    for (int x = 0; x < Tempo23.Length; x++)
                    {
                        vetorSemVisualizar[0] = Tempo23[0];
                        vetorSemVisualizar[1] = Tempo23[1];
                        vetorSemVisualizar[2] = Tempo23[2];
                        vetorSemVisualizar[3] = Tempo23[3];
                        vetorSemVisualizar[4] = Tempo23[4];
                        vetorSemVisualizar[5] = Tempo23[5];
                        vetorSemVisualizar[6] = Tempo23[6];
                        vetorSemVisualizar[7] = Tempo23[7];
                        vetorSemVisualizar[8] = Tempo23[8];
                        vetorSemVisualizar[9] = Tempo23[9];
                        vetorSemVisualizar[10] = Tempo23[10];
                        vetorSemVisualizar[11] = Tempo23[11];
                        vetorSemVisualizar[12] = Tempo23[12];
                        vetorSemVisualizar[13] = Tempo23[13];
                        vetorSemVisualizar[14] = Tempo23[14];
                        vetorSemVisualizar[15] = Tempo23[15];
                        vetorSemVisualizar[16] = Tempo23[16];
                        vetorSemVisualizar[17] = Tempo23[17];
                        vetorSemVisualizar[18] = Tempo23[18];
                        vetorSemVisualizar[19] = Tempo23[19];
                        vetorSemVisualizar[20] = Tempo23[20];
                        vetorSemVisualizar[21] = Tempo23[21];
                        vetorSemVisualizar[22] = Tempo23[22];
                        vetorSemVisualizar[23] = Tempo23[23];
                        vetorSemVisualizar[24] = Tempo23[24];

                        value1 = int.Parse(Tempo23[26].ToString()) * 1000;
                        value2 = int.Parse(Tempo23[27].ToString()) * 100;
                        value3 = int.Parse(Tempo23[28].ToString()) * 10;
                        value4 = int.Parse(Tempo23[29].ToString()) * 1;

                        value = value1 + value2 + value3 + value4;

                        fabrica1 = Tempo23[26];
                        fabrica2 = Tempo23[27];
                        fabrica3 = Tempo23[28];
                        fabrica4 = Tempo23[29];

                        tracBar_fabrica.Value = value;
                        textBox1.Text = Tempo23[26].ToString() + Tempo23[27].ToString() + ":" + Tempo23[28].ToString() + Tempo23[29].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo23.Length; x++)
                    {
                        valueMAX1 = int.Parse(Tempo23[31].ToString()) * 1000;
                        valueMAX2 = int.Parse(Tempo23[32].ToString()) * 100;
                        valueMAX3 = int.Parse(Tempo23[33].ToString()) * 10;
                        valueMax4 = int.Parse(Tempo23[34].ToString()) * 1;

                        valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                        if (valueMAX > 5940)
                        {
                            valueMAX = 5940;
                        }

                        max1 = Tempo23[31];
                        max2 = Tempo23[32];
                        max3 = Tempo23[33];
                        max4 = Tempo23[34];

                        trackBar_maximo.Value = valueMAX;
                        textBox2.Text = Tempo23[31].ToString() + Tempo23[32].ToString() + ":" + Tempo23[33].ToString() + Tempo23[34].ToString() + "h";
                    }
                    for (int x = 0; x < Tempo23.Length; x++)
                    {
                        valueMIN1 = int.Parse(Tempo23[36].ToString()) * 1000;
                        valueMIN2 = int.Parse(Tempo23[37].ToString()) * 100;
                        valueMIN3 = int.Parse(Tempo23[38].ToString()) * 10;
                        valueMin4 = int.Parse(Tempo23[39].ToString()) * 1;

                        valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;
                        min1 = Tempo23[36];
                        min2 = Tempo23[37];
                        min3 = Tempo23[38];
                        min4 = Tempo23[39];
                        trackBar_minimo.Value = valueMIN;
                        textBox3.Text = Tempo23[36].ToString() + Tempo23[37].ToString() + ":" + Tempo23[38].ToString() + Tempo23[39].ToString() + "h";
                    }

                    string existe4 = new string(vetorSemVisualizar);
                    textBox5.Text = existe4;

                    passarMsg = textBox5.Text.ToCharArray();

                    vetortemporario = Form1.RecebendoconteudoTempo23.ToCharArray();
                    vetorSemVisualizar = textBox5.Text.ToCharArray();
                    Form1.click_selecionar[1] = TP_23;
                    Form1.img = Properties.Resources.temporizador_23;
                }
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                trackBar_maximo.Enabled = false;
                trackBar_minimo.Enabled = false;
                tracBar_fabrica.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Form1.saidaOuDisplay = 0;
            Form1.completarLinha = 1;

            for (int i = 0; i < 32; i++)
            {
                vetorvazio2[i] = ' ';
            }

            passarMsg = textBox5.Text.ToArray();
            vetorMensagem2 = passarMsg; // vetor que recebe a mensagem do display 

            for (int i = 0; i < vetorMensagem2.Length; i++)
            {
                vetorvazio2[i] = vetorMensagem2[i];
            }

            lb_0.Text = vetorvazio2[0].ToString();
            lb_1.Text = vetorvazio2[1].ToString();
            lb_2.Text = vetorvazio2[2].ToString();
            lb_3.Text = vetorvazio2[3].ToString();
            lb_4.Text = vetorvazio2[4].ToString();
            lb_5.Text = vetorvazio2[5].ToString();
            lb_6.Text = vetorvazio2[6].ToString();
            lb_7.Text = vetorvazio2[7].ToString();
            lb_8.Text = vetorvazio2[8].ToString();
            lb_9.Text = vetorvazio2[9].ToString();
            lb_10.Text = vetorvazio2[10].ToString();
            lb_11.Text = vetorvazio2[11].ToString();
            lb_12.Text = vetorvazio2[12].ToString();
            lb_13.Text = vetorvazio2[13].ToString();
            lb_14.Text = vetorvazio2[14].ToString();
            lb_15.Text = vetorvazio2[15].ToString();
            lb_16.Text = vetorvazio2[16].ToString();
            lb_17.Text = vetorvazio2[17].ToString();
            lb_18.Text = vetorvazio2[18].ToString();
            lb_19.Text = vetorvazio2[19].ToString();
            lb_20.Text = vetorvazio2[20].ToString();
            lb_21.Text = vetorvazio2[21].ToString();
            lb_22.Text = vetorvazio2[22].ToString();
            lb_23.Text = vetorvazio2[23].ToString();
            lb_24.Text = vetorvazio2[24].ToString();

            lb_26.Text = mostrar1.ToString();
            lb_27.Text = mostrar2.ToString();
            lb_28.Text = mostrar3.ToString();
            lb_29.Text = mostrar4.ToString();
            lb_30.Text = mostrar5.ToString();
            lb_31.Text = mostrar6.ToString();

            if (visualizar_clicado == 1) // se foi clicado em visualizar antes de ok
            {
                vetortemporario[0] = VisorCLP.vetorvazio[0];
                vetortemporario[1] = VisorCLP.vetorvazio[1];
                vetortemporario[2] = VisorCLP.vetorvazio[2];
                vetortemporario[3] = VisorCLP.vetorvazio[3];
                vetortemporario[4] = VisorCLP.vetorvazio[4];
                vetortemporario[5] = VisorCLP.vetorvazio[5];
                vetortemporario[6] = VisorCLP.vetorvazio[6];
                vetortemporario[7] = VisorCLP.vetorvazio[7];
                vetortemporario[8] = VisorCLP.vetorvazio[8];
                vetortemporario[9] = VisorCLP.vetorvazio[9];
                vetortemporario[10] = VisorCLP.vetorvazio[10];
                vetortemporario[11] = VisorCLP.vetorvazio[11];
                vetortemporario[12] = VisorCLP.vetorvazio[12];
                vetortemporario[13] = VisorCLP.vetorvazio[13];
                vetortemporario[14] = VisorCLP.vetorvazio[14];
                vetortemporario[15] = VisorCLP.vetorvazio[15];
                vetortemporario[16] = VisorCLP.vetorvazio[16];
                vetortemporario[17] = VisorCLP.vetorvazio[17];
                vetortemporario[18] = VisorCLP.vetorvazio[18];
                vetortemporario[19] = VisorCLP.vetorvazio[19];
                vetortemporario[20] = VisorCLP.vetorvazio[20];
                vetortemporario[21] = VisorCLP.vetorvazio[21];
                vetortemporario[22] = VisorCLP.vetorvazio[22];
                vetortemporario[23] = VisorCLP.vetorvazio[23];
                vetortemporario[24] = VisorCLP.vetorvazio[24];
                vetortemporario[25] = ';';

                vetortemporario[26] = fabrica1;
                vetortemporario[27] = fabrica2;
                vetortemporario[28] = fabrica3;
                vetortemporario[29] = fabrica4;

                vetortemporario[30] = ';';

                vetortemporario[31] = max1;
                vetortemporario[32] = max2;
                vetortemporario[33] = max3;
                vetortemporario[34] = max4;

                vetortemporario[35] = ';';

                vetortemporario[36] = min1;
                vetortemporario[37] = min2;
                vetortemporario[38] = min3;
                vetortemporario[39] = min4;
                vetortemporario[40] = ';';
                vetortemporario[42] = ';';
            }
            else // Ou clicado direto no botao ok
            {

                vetortemporario[0] = vetorvazio2[0];
                vetortemporario[1] = vetorvazio2[1];
                vetortemporario[2] = vetorvazio2[2];
                vetortemporario[3] = vetorvazio2[3];
                vetortemporario[4] = vetorvazio2[4];
                vetortemporario[5] = vetorvazio2[5];
                vetortemporario[6] = vetorvazio2[6];
                vetortemporario[7] = vetorvazio2[7];
                vetortemporario[8] = vetorvazio2[8];
                vetortemporario[9] = vetorvazio2[9];
                vetortemporario[10] = vetorvazio2[10];
                vetortemporario[11] = vetorvazio2[11];
                vetortemporario[12] = vetorvazio2[12];
                vetortemporario[13] = vetorvazio2[13];
                vetortemporario[14] = vetorvazio2[14];
                vetortemporario[15] = vetorvazio2[15];
                vetortemporario[16] = vetorvazio2[16];
                vetortemporario[17] = vetorvazio2[17];
                vetortemporario[18] = vetorvazio2[18];
                vetortemporario[19] = vetorvazio2[19];
                vetortemporario[20] = vetorvazio2[20];
                vetortemporario[21] = vetorvazio2[21];
                vetortemporario[22] = vetorvazio2[22];
                vetortemporario[23] = vetorvazio2[23];
                vetortemporario[24] = vetorvazio2[24];
                vetortemporario[25] = ';';

                vetortemporario[26] = fabrica1;
                vetortemporario[27] = fabrica2;
                vetortemporario[28] = fabrica3;
                vetortemporario[29] = fabrica4;

                vetortemporario[30] = ';';

                vetortemporario[31] = max1;
                vetortemporario[32] = max2;
                vetortemporario[33] = max3;
                vetortemporario[34] = max4;

                vetortemporario[35] = ';';

                vetortemporario[36] = min1;
                vetortemporario[37] = min2;
                vetortemporario[38] = min3;
                vetortemporario[39] = min4;
                vetortemporario[40] = ';';
                vetortemporario[42] = ';';

            }
            if (rb_parametro1.Checked == true) { vetortemporario[41] = '1'; }
            if (rb_parametro2.Checked == true) { vetortemporario[41] = '2'; }
            if (rb_parametroFixo.Checked == true) { vetortemporario[41] = '3'; }

            foreach (char letra in vetortemporario)
            {
                if (arquivoTempo == 1)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT01.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 2)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT02.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 3)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT03.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 4)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT04.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 5)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT05.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 6)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT06.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 7)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT07.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 8)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT08.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 9)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT09.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 10)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT10.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 11)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT11.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 12)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT12.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 13)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT13.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 14)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT14.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 15)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT15.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 16)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT16.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 17)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT17.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 18)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT18.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 19)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT19.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 20)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT20.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();

                }
                if (arquivoTempo == 21)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT21.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 22)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT22.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 23)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT23.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoTempo == 24)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileT24.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
            }

            if (radioButton1.Checked == true)
            {
                Form1.Linha78_TEM01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha78_TEM01. 
                string converter = new string(Form1.Linha78_TEM01); // converte Linha78_TEM01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[78] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha79 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha79.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha79.Close(); //fecha o arquivo depois de salvar.
                }

            }

            if (radioButton2.Checked == true)
            {
                Form1.Linha79_TEM02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha79_TEM02. 
                string converter = new string(Form1.Linha79_TEM02); // converte Linha79_TEM02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[79] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha80 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha80.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha80.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton3.Checked == true)
            {
                Form1.Linha80_TEM03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha80_TEM03. 
                string converter = new string(Form1.Linha80_TEM03); // converte Linha80_TEM03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[80] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha81 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha81.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha81.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton4.Checked == true)
            {
                Form1.Linha81_TEM04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha81_TEM04. 
                string converter = new string(Form1.Linha81_TEM04); // converte Linha81_TEM04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[81] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha82 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha82.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha82.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton5.Checked == true)
            {
                Form1.Linha82_TEM05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha82_TEM05. 
                string converter = new string(Form1.Linha82_TEM05); // converte Linha82_TEM05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[82] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha83 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha83.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha83.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton6.Checked == true)
            {
                Form1.Linha83_TEM06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha83_TEM06. 
                string converter = new string(Form1.Linha83_TEM06); // converte Linha83_TEM06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[83] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha84 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha84.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha84.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton7.Checked == true)
            {
                Form1.Linha84_TEM07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha84_TEM07. 
                string converter = new string(Form1.Linha84_TEM07); // converte Linha84_TEM07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[84] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha85 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha85.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha85.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton8.Checked == true)
            {
                Form1.Linha85_TEM08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha85_TEM08. 
                string converter = new string(Form1.Linha85_TEM08); // converte Linha85_TEM08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[85] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha86 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha86.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha86.Close(); //fecha o arquivo depois de salvar.
                }
            }

            Form1.tooltip = tb_comentario.Text.Trim();
            if (tb_comentario.Text.Length < 1)
            {
                tb_comentario.Text = tb_comentario.Text + "        ";
            }
            if (tb_comentario.Text.Length < 2)
            {
                tb_comentario.Text = tb_comentario.Text + "       ";
            }
            else if (tb_comentario.Text.Length < 3)
            {
                tb_comentario.Text = tb_comentario.Text + "      ";
            }
            else if (tb_comentario.Text.Length < 4)
            {
                tb_comentario.Text = tb_comentario.Text + "     ";
            }
            else if (tb_comentario.Text.Length < 5)
            {
                tb_comentario.Text = tb_comentario.Text + "    ";
            }
            else if (tb_comentario.Text.Length < 6)
            {
                tb_comentario.Text = tb_comentario.Text + "   ";
            }
            else if (tb_comentario.Text.Length < 8)
            {
                tb_comentario.Text = tb_comentario.Text + " ";
            }

            Form1.btn_txt = tb_comentario.Text.Substring(0, 8);

            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Cursor = new Cursor(Handle);
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_tempo.Handle);
            Close();
        }
        private void Temporizador_Load(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            rb_parametro1.Enabled = false;
            rb_parametro2.Enabled = false;
            rb_parametroFixo.Enabled = false;
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            VisorCLP visor = new VisorCLP();
            visor.TopLevel = true;
            visor.Visible = true;
            visor.StartPosition = FormStartPosition.Manual;
            visor.Location = new Point(866, 78);

            visualizarTextbox = textBox1.Text.ToCharArray();
            if (mudar_RB == 2)
            {
                mostrar1 = ' ';
                mostrar2 = visualizarTextbox[1];
                mostrar3 = visualizarTextbox[2];
                mostrar4 = visualizarTextbox[3];
                mostrar5 = visualizarTextbox[4];
            }
            if (mudar_RB == 1)
            {
                mostrar1 = ' ';
                mostrar2 = visualizarTextbox[1];
                mostrar3 = visualizarTextbox[2];
                mostrar4 = visualizarTextbox[3];
                mostrar5 = visualizarTextbox[4];
                mostrar6 = visualizarTextbox[5];
            }
            if (mudar_RB == 3)
            {
                mostrar1 = visualizarTextbox[0];
                mostrar2 = visualizarTextbox[1];
                mostrar3 = visualizarTextbox[2];
                mostrar4 = visualizarTextbox[3];
                mostrar5 = visualizarTextbox[4];
                mostrar6 = visualizarTextbox[5];
            }

            visualizar_clicado = 1;
            passarMsg = textBox5.Text.ToCharArray();
        }
        //Fabrica:

        ////////////////////////////////////////////////////////////////////////////////////////////////// Maximo
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            if (mudar_RB == 3)
            {
                M = trackBar_maximo.Value / 600;
                C = (trackBar_maximo.Value - (M * 600)) / 60;
                D = (trackBar_maximo.Value - ((M * 600) + (C * 60))) / 10;
                U = trackBar_maximo.Value - ((M * 600) + (C * 60) + (D * 10));



                string MaxM = M.ToString(); // converte int m em string
                string MaxC = C.ToString();
                string MaxD = D.ToString();
                string MaxU = U.ToString();

                max1 = Convert.ToChar(MaxM); // converte a string m e char
                max2 = Convert.ToChar(MaxC);
                max3 = Convert.ToChar(MaxD);
                max4 = Convert.ToChar(MaxU);

                if (trackBar_maximo.Value < tracBar_fabrica.Value)
                {
                    trackBar_maximo.Value = tracBar_fabrica.Value + 1;
                    return;
                }
                if (trackBar_maximo.Value >= 5940)
                {
                    trackBar_maximo.Value = trackBar_maximo.Value -= 1;
                    trackBar_maximo.Value = 5940;
                }
                textBox2.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";
            }


            if (mudar_RB == 1)
            {
                M = ((trackBar_maximo.Value % 10000) / 1000);
                C = ((trackBar_maximo.Value % 1000) / 100);
                D = ((trackBar_maximo.Value % 100) / 10);
                U = (trackBar_maximo.Value % 10);



                string MaxM = M.ToString(); // converte int m em string
                string MaxC = C.ToString();
                string MaxD = D.ToString();
                string MaxU = U.ToString();

                max1 = Convert.ToChar(MaxM); // converte a string m e char
                max2 = Convert.ToChar(MaxC);
                max3 = Convert.ToChar(MaxD);
                max4 = Convert.ToChar(MaxU);

                if (trackBar_maximo.Value < tracBar_fabrica.Value)
                {
                    trackBar_maximo.Value = tracBar_fabrica.Value + 1;
                    return;
                }
                if (trackBar_maximo.Value >= 999)
                {
                    trackBar_maximo.Value = 999;
                }
                textBox2.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";
            }
            if (mudar_RB == 2)
            {

                M = ((trackBar_maximo.Value % 10000) / 1000);
                C = ((trackBar_maximo.Value % 1000) / 100);
                D = ((trackBar_maximo.Value % 100) / 10);
                U = (trackBar_maximo.Value % 10);



                string stringM = M.ToString(); // converte int m em string
                string stringC = C.ToString();
                string stringD = D.ToString();
                string stringU = U.ToString();

                max1 = Convert.ToChar(stringM); // converte a string m e char
                max2 = Convert.ToChar(stringC);
                max3 = Convert.ToChar(stringD);
                max4 = Convert.ToChar(stringU);

                if (trackBar_maximo.Value < tracBar_fabrica.Value)
                {
                    trackBar_maximo.Value = tracBar_fabrica.Value + 1;
                    return;
                }
                if (trackBar_maximo.Value >= 999)
                {
                    trackBar_maximo.Value = 999;
                }
                textBox2.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////  minimo
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar_minimo.Value <= 0)
            {
                trackBar_minimo.Value = 0;
            }
            if (trackBar_minimo.Value > tracBar_fabrica.Value)
            {

                trackBar_minimo.Value = tracBar_fabrica.Value - 1;
                return;
            }
            if (mudar_RB == 3)
            {
                M = trackBar_minimo.Value / 600;
                C = (trackBar_minimo.Value - (M * 600)) / 60;
                D = (trackBar_minimo.Value - ((M * 600) + (C * 60))) / 10;
                U = trackBar_minimo.Value - ((M * 600) + (C * 60) + (D * 10));

                string MinM = M.ToString(); // converte int m em string
                string MinC = C.ToString();
                string MinD = D.ToString();
                string MinU = U.ToString();

                min1 = Convert.ToChar(MinM); // converte a string m e char
                min2 = Convert.ToChar(MinC);
                min3 = Convert.ToChar(MinD);
                min4 = Convert.ToChar(MinU);

                textBox3.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";

            }
            if (mudar_RB == 1)
            {
                M = ((trackBar_minimo.Value % 10000) / 1000);
                C = ((trackBar_minimo.Value % 1000) / 100);
                D = ((trackBar_minimo.Value % 100) / 10);
                U = (trackBar_minimo.Value % 10);

                string MinM = M.ToString(); // converte int m em string
                string MinC = C.ToString();
                string MinD = D.ToString();
                string MinU = U.ToString();

                min1 = Convert.ToChar(MinM); // converte a string m e char
                min2 = Convert.ToChar(MinC);
                min3 = Convert.ToChar(MinD);
                min4 = Convert.ToChar(MinU);

                textBox3.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";

            }

            if (mudar_RB == 2)
            {
                M = ((trackBar_minimo.Value % 10000) / 1000);
                C = ((trackBar_minimo.Value % 1000) / 100);
                D = ((trackBar_minimo.Value % 100) / 10);
                U = (trackBar_minimo.Value % 10);



                string MinM = M.ToString(); // converte int m em string
                string MinC = C.ToString();
                string MinD = D.ToString();
                string MinU = U.ToString();

                min1 = Convert.ToChar(MinM); // converte a string m e char
                min2 = Convert.ToChar(MinC);
                min3 = Convert.ToChar(MinD);
                min4 = Convert.ToChar(MinU);
                textBox3.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Incrementa valor no trackbar Fabrica
        private void button5_Click(object sender, EventArgs e)
        {
            if (mudar_RB == 1)
            {
                if (tracBar_fabrica.Value >= 998)
                {
                    tracBar_fabrica.Value = 998;

                }
                tracBar_fabrica.Value = tracBar_fabrica.Value += 1;

                M = (tracBar_fabrica.Value % 10000) / 1000;
                C = ((tracBar_fabrica.Value % 1000) / 100);
                D = ((tracBar_fabrica.Value % 100) / 10);
                U = (tracBar_fabrica.Value % 10);
                textBox1.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";

            }
            if (mudar_RB == 2)
            {
                if (tracBar_fabrica.Value >= 998)
                {
                    tracBar_fabrica.Value = 998;

                }
                tracBar_fabrica.Value = tracBar_fabrica.Value += 1;
                M = (tracBar_fabrica.Value % 10000) / 1000;
                C = ((tracBar_fabrica.Value % 1000) / 100);
                D = ((tracBar_fabrica.Value % 100) / 10);
                U = (tracBar_fabrica.Value % 10);
                textBox1.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";
            }
            if (mudar_RB == 3)
            {
                if (tracBar_fabrica.Value >= 5939)
                {
                    tracBar_fabrica.Value = 5939;

                }
                tracBar_fabrica.Value = tracBar_fabrica.Value += 1;
                M = tracBar_fabrica.Value / 600;
                C = (tracBar_fabrica.Value - (M * 600)) / 60;
                D = (tracBar_fabrica.Value - ((M * 600) + (C * 60))) / 10;
                U = tracBar_fabrica.Value - ((M * 600) + (C * 60) + (D * 10));
                textBox1.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";
            }

        }
        /////////////////////////////////////////////////////////////////////////////////// Decrementa valor no trackbar Fabrica
        private void button4_Click(object sender, EventArgs e)
        {
            tracBar_fabrica.Value = tracBar_fabrica.Value -= 1;
            if (tracBar_fabrica.Value < trackBar_minimo.Value)
            {
                tracBar_fabrica.Value = trackBar_minimo.Value + 1;
                return;
            }
            if (tracBar_fabrica.Value > trackBar_maximo.Value)
            {
                tracBar_fabrica.Value = trackBar_maximo.Value - 1;
                return;
            }
            if (tracBar_fabrica.Value <= 1)
            {
                tracBar_fabrica.Value = 1;
            }
            if (mudar_RB == 3)
            {
                M = (tracBar_fabrica.Value % 10000) / 1000;
                C = ((tracBar_fabrica.Value % 1000) / 100);
                D = ((tracBar_fabrica.Value % 100) / 10);
                U = (tracBar_fabrica.Value % 10);

                textBox1.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";
            }
            if (mudar_RB == 1)
            {
                M = (tracBar_fabrica.Value % 10000) / 1000;
                C = ((tracBar_fabrica.Value % 1000) / 100);
                D = ((tracBar_fabrica.Value % 100) / 10);
                U = (tracBar_fabrica.Value % 10);
                textBox1.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";
            }
            if (mudar_RB == 2)
            {
                M = (tracBar_fabrica.Value % 10000) / 1000;
                C = ((tracBar_fabrica.Value % 1000) / 100);
                D = ((tracBar_fabrica.Value % 100) / 10);
                U = (tracBar_fabrica.Value % 10);
                textBox1.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";
            }

        }
        // Incrementa valor no trackbar Maximo
        private void button7_Click(object sender, EventArgs e)
        {
            if (mudar_RB == 1)
            {
                if (trackBar_maximo.Value >= 998)
                {
                    trackBar_maximo.Value = 998;

                }
                trackBar_maximo.Value = trackBar_maximo.Value += 1;

                M = (trackBar_maximo.Value % 10000) / 1000;
                C = ((trackBar_maximo.Value % 1000) / 100);
                D = ((trackBar_maximo.Value % 100) / 10);
                U = (trackBar_maximo.Value % 10);
                textBox2.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";
            }
            if (mudar_RB == 2)
            {
                if (trackBar_maximo.Value >= 998)
                {
                    trackBar_maximo.Value = 998;

                }
                trackBar_maximo.Value = trackBar_maximo.Value += 1;
                M = (trackBar_maximo.Value % 10000) / 1000;
                C = ((trackBar_maximo.Value % 1000) / 100);
                D = ((trackBar_maximo.Value % 100) / 10);
                U = (trackBar_maximo.Value % 10);
                textBox2.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";
            }
            if (mudar_RB == 3)
            {
                if (trackBar_maximo.Value >= 5939)
                {
                    trackBar_maximo.Value = 5939;

                }
                trackBar_maximo.Value = trackBar_maximo.Value += 1;
                M = trackBar_maximo.Value / 600;
                C = (trackBar_maximo.Value - (M * 600)) / 60;
                D = (trackBar_maximo.Value - ((M * 600) + (C * 60))) / 10;
                U = trackBar_maximo.Value - ((M * 600) + (C * 60) + (D * 10));
                textBox2.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trackBar_maximo.Value = trackBar_maximo.Value -= 1;
            if (trackBar_maximo.Value < tracBar_fabrica.Value)
            {
                trackBar_maximo.Value = tracBar_fabrica.Value + 1;
                return;
            }
            if (mudar_RB == 3)
            {
                M = (trackBar_maximo.Value % 10000) / 1000;
                C = ((trackBar_maximo.Value % 1000) / 100);
                D = ((trackBar_maximo.Value % 100) / 10);
                U = (trackBar_maximo.Value % 10);

                textBox2.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";
            }
            if (mudar_RB == 1)
            {
                M = (trackBar_maximo.Value % 10000) / 1000;
                C = ((trackBar_maximo.Value % 1000) / 100);
                D = ((trackBar_maximo.Value % 100) / 10);
                U = (trackBar_maximo.Value % 10);
                textBox2.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";
            }
            if (mudar_RB == 2)
            {
                M = (trackBar_maximo.Value % 10000) / 1000;
                C = ((trackBar_maximo.Value % 1000) / 100);
                D = ((trackBar_maximo.Value % 100) / 10);
                U = (trackBar_maximo.Value % 10);
                textBox2.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mudar_RB == 1)
            {
                if (trackBar_minimo.Value >= 998)
                {
                    trackBar_minimo.Value = 998;

                }
                trackBar_minimo.Value = trackBar_minimo.Value += 1;

                M = (trackBar_minimo.Value % 10000) / 1000;
                C = ((trackBar_minimo.Value % 1000) / 100);
                D = ((trackBar_minimo.Value % 100) / 10);
                U = (trackBar_minimo.Value % 10);
                textBox3.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";
            }
            if (mudar_RB == 2)
            {
                if (trackBar_minimo.Value >= 998)
                {
                    trackBar_minimo.Value = 998;

                }
                trackBar_minimo.Value = trackBar_minimo.Value += 1;
                M = (trackBar_minimo.Value % 10000) / 1000;
                C = ((trackBar_minimo.Value % 1000) / 100);
                D = ((trackBar_minimo.Value % 100) / 10);
                U = (trackBar_minimo.Value % 10);
                textBox3.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";
            }
            if (mudar_RB == 3)
            {
                if (trackBar_minimo.Value >= 5939)
                {
                    trackBar_minimo.Value = 5939;

                }
                trackBar_minimo.Value = trackBar_minimo.Value += 1;
                M = trackBar_minimo.Value / 600;
                C = (trackBar_minimo.Value - (M * 600)) / 60;
                D = (trackBar_minimo.Value - ((M * 600) + (C * 60))) / 10;
                U = trackBar_minimo.Value - ((M * 600) + (C * 60) + (D * 10));
                textBox3.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (mudar_RB == 1)
            {
                if (trackBar_minimo.Value <= 0)
                {
                    trackBar_minimo.Value = 0;
                }
                trackBar_minimo.Value = trackBar_minimo.Value -= 1;

                M = (trackBar_minimo.Value % 10000) / 1000;
                C = ((trackBar_minimo.Value % 1000) / 100);
                D = ((trackBar_minimo.Value % 100) / 10);
                U = (trackBar_minimo.Value % 10);
                textBox3.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";
            }
            if (mudar_RB == 2)
            {
                if (trackBar_minimo.Value <= 0)
                {
                    trackBar_minimo.Value = 0;
                }
                trackBar_minimo.Value = trackBar_minimo.Value -= 1;
                M = (trackBar_minimo.Value % 10000) / 1000;
                C = ((trackBar_minimo.Value % 1000) / 100);
                D = ((trackBar_minimo.Value % 100) / 10);
                U = (trackBar_minimo.Value % 10);
                textBox3.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";
            }
            if (mudar_RB == 3)
            {
                if (trackBar_minimo.Value <= 0)
                {
                    trackBar_minimo.Value = 0;
                }
                trackBar_minimo.Value = trackBar_minimo.Value -= 1;
                M = trackBar_minimo.Value / 600;
                C = (trackBar_minimo.Value - (M * 600)) / 60;
                D = (trackBar_minimo.Value - ((M * 600) + (C * 60))) / 10;
                U = trackBar_minimo.Value - ((M * 600) + (C * 60) + (D * 10));
                textBox3.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tracBar_fabrica.Value.ToString());
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.() ";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString())) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(tracBar_fabrica.Value.ToString());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar_maximo.Value.ToString());
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar_minimo.Value.ToString());

        }
        private void tracBar_fabrica_Scroll(object sender, EventArgs e)
        {
            if (mudar_RB == 3)
            {
                M = tracBar_fabrica.Value / 600;
                C = (tracBar_fabrica.Value - (M * 600)) / 60;
                D = (tracBar_fabrica.Value - ((M * 600) + (C * 60))) / 10;
                U = tracBar_fabrica.Value - ((M * 600) + (C * 60) + (D * 10));

                string stringM = M.ToString(); // converte int M em string
                string stringC = C.ToString();
                string stringD = D.ToString();
                string stringU = U.ToString();

                if (tracBar_fabrica.Value < trackBar_minimo.Value)
                {
                    tracBar_fabrica.Value = trackBar_minimo.Value + 1;
                    return;
                }
                if (tracBar_fabrica.Value >= trackBar_maximo.Value)
                {
                    tracBar_fabrica.Value = trackBar_maximo.Value - 1;
                    return;
                }
                if (tracBar_fabrica.Value == tracBar_fabrica.Minimum)
                {
                    stringU = "0";
                    tracBar_fabrica.Value = trackBar_minimo.Value + 1;
                }

                fabrica1 = Convert.ToChar(stringM); // converte a string M em char
                fabrica2 = Convert.ToChar(stringC);
                fabrica3 = Convert.ToChar(stringD);
                fabrica4 = Convert.ToChar(stringU);
                
                textBox1.Text = M.ToString() + C.ToString() + ":" + D.ToString() + U.ToString() + "h";
            }

            if (mudar_RB == 1)
            {
                M = ((tracBar_fabrica.Value % 10000) / 1000);
                C = ((tracBar_fabrica.Value % 1000) / 100);
                D = ((tracBar_fabrica.Value % 100) / 10);
                U = (tracBar_fabrica.Value % 10);

                string stringM = M.ToString(); // converte int m em string
                string stringC = C.ToString();
                string stringD = D.ToString();
                string stringU = U.ToString();

                if (tracBar_fabrica.Value < trackBar_minimo.Value)
                {
                    tracBar_fabrica.Value = trackBar_minimo.Value + 1;
                    return;
                }
                if (tracBar_fabrica.Value >= trackBar_maximo.Value)
                {
                    tracBar_fabrica.Value = trackBar_maximo.Value - 1;
                    return;
                }
                if (tracBar_fabrica.Value == tracBar_fabrica.Minimum)
                {
                    stringU = "0";
                    tracBar_fabrica.Value = trackBar_minimo.Value + 1;
                }

                fabrica1 = Convert.ToChar(stringM); // converte a string m e char
                fabrica2 = Convert.ToChar(stringC);
                fabrica3 = Convert.ToChar(stringD);
                fabrica4 = Convert.ToChar(stringU);
                
                textBox1.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";

            }
            if (mudar_RB == 2)
            {
                 M = ((tracBar_fabrica.Value % 10000) / 1000);
                 C = ((tracBar_fabrica.Value % 1000) / 100);
                 D = ((tracBar_fabrica.Value % 100) / 10);
                 U = (tracBar_fabrica.Value % 10);

                 string stringM = M.ToString(); // converte int m em string
                 string stringC = C.ToString();
                 string stringD = D.ToString();
                 string stringU = U.ToString();

                 if (tracBar_fabrica.Value < trackBar_minimo.Value)
                 {
                     tracBar_fabrica.Value = trackBar_minimo.Value + 1;
                     return;
                 }
                 if (tracBar_fabrica.Value >= trackBar_maximo.Value)
                 {
                     tracBar_fabrica.Value = trackBar_maximo.Value - 1;
                     return;
                 }
                 if (tracBar_fabrica.Value == tracBar_fabrica.Minimum)
                 {
                     stringU = "0";
                     tracBar_fabrica.Value = trackBar_minimo.Value + 1;
                 }
                 fabrica1 = Convert.ToChar(stringM); // converte a string m e char
                 fabrica2 = Convert.ToChar(stringC);
                 fabrica3 = Convert.ToChar(stringD);
                 fabrica4 = Convert.ToChar(stringU);
                 textBox1.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";

            }
        }

        private void rb_parametroFixo_CheckedChanged(object sender, EventArgs e)
        {
            /*trackBar_maximo.Visible = false;
            trackBar_minimo.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            textBox1.Visible = false;*/
        }

        private void rb_parametro1_CheckedChanged(object sender, EventArgs e)
        {
           /* trackBar_maximo.Visible = true;
            trackBar_minimo.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            textBox1.Visible = true;*/
        }

        private void rb_parametro2_CheckedChanged(object sender, EventArgs e)
        {
           /* trackBar_maximo.Visible = true;
            trackBar_minimo.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            textBox1.Visible = true;*/

        }
    }
}
