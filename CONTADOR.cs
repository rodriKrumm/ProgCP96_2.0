using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class CONTADOR : Form
    {
        int CON_01 = 114;
        int CON_02 = 115;
        int ZCON_01 = 98;
        int ZCON_02 = 99;


        public static int M;
        public static int C;
        public static int D;
        public static int U;

        public static int arquivoContador;

        public static char[] vetorSemVisualizar = new char[32];

        public static char[] visualizarTextbox;

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

        public static char fabrica1;
        public static char fabrica2;
        public static char fabrica3;
        public static char fabrica4;
        public static char fabrica5;
        public static char fabrica6;

        char max1;
        char max2;
        char max3;
        char max4;
        char max5;
        char max6;

        char min1;
        char min2;
        char min3;
        char min4;
        char min5;
        char min6;

        public static int visualizar_clicado;

        public static char mostrar1 = ' ';
        public static char mostrar2 = ' ';
        public static char mostrar3 = ' ';
        public static char mostrar4 = ' ';
        public static char mostrar5 = ' ';
        public static char mostrar6 = ' ';
        public static char mostrar7 = ' ';

        public static char[] passarMsg = new char[25];
        public static char[] vetortemporario;

        public static string receberMsg2;
        public static char[] vetorvazio2 = new char[32];
        public static char[] vetorMensagem2;

        public CONTADOR()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                arquivoContador = 1;

                trackBar_Fabrica.Enabled = true;
                trackBar_Maximo.Enabled = true;
                trackBar_Minimo.Enabled = true;
                button3.Enabled = true;
                tb_comentario.Text = Form1.linha68.Trim();

                char[] Contador1 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileC01.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

                // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                for (int x = 0; x < Contador1.Length; x++)
                {
                    vetorSemVisualizar[0] = Contador1[0];
                    vetorSemVisualizar[1] = Contador1[1];
                    vetorSemVisualizar[2] = Contador1[2];
                    vetorSemVisualizar[3] = Contador1[3];
                    vetorSemVisualizar[4] = Contador1[4];
                    vetorSemVisualizar[5] = Contador1[5];
                    vetorSemVisualizar[6] = Contador1[6];
                    vetorSemVisualizar[7] = Contador1[7];
                    vetorSemVisualizar[8] = Contador1[8];
                    vetorSemVisualizar[9] = Contador1[9];
                    vetorSemVisualizar[10] = Contador1[10];
                    vetorSemVisualizar[11] = Contador1[11];
                    vetorSemVisualizar[12] = Contador1[12];
                    vetorSemVisualizar[13] = Contador1[13];
                    vetorSemVisualizar[14] = Contador1[14];
                    vetorSemVisualizar[15] = Contador1[15];
                    vetorSemVisualizar[16] = Contador1[16];
                    vetorSemVisualizar[17] = Contador1[17];
                    vetorSemVisualizar[18] = Contador1[18];
                    vetorSemVisualizar[19] = Contador1[19];
                    vetorSemVisualizar[20] = Contador1[20];
                    vetorSemVisualizar[21] = Contador1[21];
                    vetorSemVisualizar[22] = Contador1[22];
                    vetorSemVisualizar[23] = Contador1[23];
                    vetorSemVisualizar[24] = Contador1[24];

                    value1 = int.Parse(Contador1[26].ToString()) * 1000;
                    value2 = int.Parse(Contador1[27].ToString()) * 100;
                    value3 = int.Parse(Contador1[28].ToString()) * 10;
                    value4 = int.Parse(Contador1[29].ToString()) * 1;

                    value = value1 + value2 + value3 + value4;

                    fabrica1 = Contador1[26];
                    fabrica2 = Contador1[27];
                    fabrica3 = Contador1[28];
                    fabrica4 = Contador1[29];

                    trackBar_Fabrica.Value = value;

                    textBox1.Text = Contador1[26].ToString() + Contador1[27].ToString() + Contador1[28].ToString() + Contador1[29].ToString() + " ";
                }
                for (int x = 0; x < Contador1.Length; x++)
                {
                    valueMAX1 = int.Parse(Contador1[31].ToString()) * 1000;
                    valueMAX2 = int.Parse(Contador1[32].ToString()) * 100;
                    valueMAX3 = int.Parse(Contador1[33].ToString()) * 10;
                    valueMax4 = int.Parse(Contador1[34].ToString()) * 1;

                    valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                    max1 = Contador1[31];
                    max2 = Contador1[32];
                    max3 = Contador1[33];
                    max4 = Contador1[34];

                    trackBar_Maximo.Value = valueMAX;
                    textBox2.Text = Contador1[31].ToString() + Contador1[32].ToString() + Contador1[33].ToString() + Contador1[34].ToString() + " ";
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                for (int x = 0; x < Contador1.Length; x++)
                {
                    valueMIN1 = int.Parse(Contador1[36].ToString()) * 1000;
                    valueMIN2 = int.Parse(Contador1[37].ToString()) * 100;
                    valueMIN3 = int.Parse(Contador1[38].ToString()) * 10;
                    valueMin4 = int.Parse(Contador1[39].ToString()) * 1;

                    valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                    min1 = Contador1[36];
                    min2 = Contador1[37];
                    min3 = Contador1[38];
                    min4 = Contador1[39];
                    trackBar_Minimo.Value = valueMIN;

                    textBox3.Text = Contador1[36].ToString() + Contador1[37].ToString() + Contador1[38].ToString() + Contador1[39].ToString() + " ";
                }
                string existe4 = new string(vetorSemVisualizar);
                textBox5.Text = existe4;

                passarMsg = textBox5.Text.ToCharArray();

                vetortemporario = Form1.RecebendoconteudoTempo09.ToCharArray();
                vetorSemVisualizar = textBox5.Text.ToCharArray();

                Form1.click_selecionar[1] = CON_01;
                Form1.img = Properties.Resources.contador01;
            }
        } 

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                arquivoContador = 2;
                trackBar_Fabrica.Enabled = true;
                trackBar_Maximo.Enabled = true;
                trackBar_Minimo.Enabled = true;
                button3.Enabled = true;
                tb_comentario.Text = Form1.linha69.Trim();
                char[] Contador2 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileC02.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo
                for (int x = 0; x < Contador2.Length; x++)
                {
                    vetorSemVisualizar[0] = Contador2[0];
                    vetorSemVisualizar[1] = Contador2[1];
                    vetorSemVisualizar[2] = Contador2[2];
                    vetorSemVisualizar[3] = Contador2[3];
                    vetorSemVisualizar[4] = Contador2[4];
                    vetorSemVisualizar[5] = Contador2[5];
                    vetorSemVisualizar[6] = Contador2[6];
                    vetorSemVisualizar[7] = Contador2[7];
                    vetorSemVisualizar[8] = Contador2[8];
                    vetorSemVisualizar[9] = Contador2[9];
                    vetorSemVisualizar[10] = Contador2[10];
                    vetorSemVisualizar[11] = Contador2[11];
                    vetorSemVisualizar[12] = Contador2[12];
                    vetorSemVisualizar[13] = Contador2[13];
                    vetorSemVisualizar[14] = Contador2[14];
                    vetorSemVisualizar[15] = Contador2[15];
                    vetorSemVisualizar[16] = Contador2[16];
                    vetorSemVisualizar[17] = Contador2[17];
                    vetorSemVisualizar[18] = Contador2[18];
                    vetorSemVisualizar[19] = Contador2[19];
                    vetorSemVisualizar[20] = Contador2[20];
                    vetorSemVisualizar[21] = Contador2[21];
                    vetorSemVisualizar[22] = Contador2[22];
                    vetorSemVisualizar[23] = Contador2[23];
                    vetorSemVisualizar[24] = Contador2[24];

                    value1 = int.Parse(Contador2[26].ToString()) * 1000;
                    value2 = int.Parse(Contador2[27].ToString()) * 100;
                    value3 = int.Parse(Contador2[28].ToString()) * 10;
                    value4 = int.Parse(Contador2[29].ToString()) * 1;

                    value = value1 + value2 + value3 + value4;

                    fabrica1 = Contador2[26];
                    fabrica2 = Contador2[27];
                    fabrica3 = Contador2[28];
                    fabrica4 = Contador2[29];

                    trackBar_Fabrica.Value = value;

                    textBox1.Text = Contador2[26].ToString() + Contador2[27].ToString() + Contador2[28].ToString() + Contador2[29].ToString() + " ";
                }
                for (int x = 0; x < Contador2.Length; x++)
                {
                    valueMAX1 = int.Parse(Contador2[31].ToString()) * 1000;
                    valueMAX2 = int.Parse(Contador2[32].ToString()) * 100;
                    valueMAX3 = int.Parse(Contador2[33].ToString()) * 10;
                    valueMax4 = int.Parse(Contador2[34].ToString()) * 1;

                    valueMAX = valueMAX1 + valueMAX2 + valueMAX3 + valueMax4;

                    max1 = Contador2[31];
                    max2 = Contador2[32];
                    max3 = Contador2[33];
                    max4 = Contador2[34];

                    trackBar_Maximo.Value = valueMAX;
                    textBox2.Text = Contador2[31].ToString() + Contador2[32].ToString() + Contador2[33].ToString() + Contador2[34].ToString() + " ";
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                for (int x = 0; x < Contador2.Length; x++)
                {
                    valueMIN1 = int.Parse(Contador2[36].ToString()) * 1000;
                    valueMIN2 = int.Parse(Contador2[37].ToString()) * 100;
                    valueMIN3 = int.Parse(Contador2[38].ToString()) * 10;
                    valueMin4 = int.Parse(Contador2[39].ToString()) * 1;

                    valueMIN = valueMIN1 + valueMIN2 + valueMIN3 + valueMin4;

                    min1 = Contador2[36];
                    min2 = Contador2[37];
                    min3 = Contador2[38];
                    min4 = Contador2[39];

                    trackBar_Minimo.Value = valueMIN;

                    textBox3.Text = Contador2[36].ToString() + Contador2[37].ToString() + Contador2[38].ToString() + Contador2[39].ToString() + " ";
                }
                string existe4 = new string(vetorSemVisualizar);
                textBox5.Text = existe4;

                passarMsg = textBox5.Text.ToCharArray();

                vetortemporario = Form1.RecebendoconteudoCont02.ToCharArray();
                vetorSemVisualizar = textBox5.Text.ToCharArray();
                Form1.click_selecionar[1] = CON_02;
                Form1.img = Properties.Resources.contador02;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            arquivoContador = 3;

            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            tb_comentario.Text       = Form1.linha114.Trim();

            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();


            vetorSemVisualizar = textBox5.Text.ToCharArray();
            Form1.click_selecionar[1] = ZCON_01;
            Form1.img = Properties.Resources.contador01z;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            arquivoContador = 4;

            groupBox2.Visible  = false;
            groupBox3.Visible  = false;
            groupBox4.Visible  = false;
            tb_comentario.Text = Form1.linha115.Trim();

            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();


            vetorSemVisualizar = textBox5.Text.ToCharArray();
            Form1.click_selecionar[1] = ZCON_02;
            Form1.img = Properties.Resources.contador02z;

        }



        private void trackBar_Fabrica_Scroll(object sender, EventArgs e)
        {
            if (trackBar_Fabrica.Value < trackBar_Minimo.Value)
            {
                trackBar_Fabrica.Value = trackBar_Minimo.Value + 1;
                return;
            }
            if (trackBar_Fabrica.Value > trackBar_Maximo.Value)
            {
                trackBar_Fabrica.Value = trackBar_Maximo.Value - 1;
                return;
            }

            M = ((trackBar_Fabrica.Value % 10000) / 1000);
            C = ((trackBar_Fabrica.Value % 1000) / 100);
            D = ((trackBar_Fabrica.Value % 100) / 10);
            U = (trackBar_Fabrica.Value % 10);

            textBox1.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + " ";

            string stringM = M.ToString(); // converte int m em string
            string stringC = C.ToString();
            string stringD = D.ToString();
            string stringU = U.ToString();

            fabrica1 = Convert.ToChar(stringM); // converte a string m e char
            fabrica2 = Convert.ToChar(stringC);
            fabrica3 = Convert.ToChar(stringD);
            fabrica4 = Convert.ToChar(stringU);

        }

        private void trackBar_Maximo_Scroll(object sender, EventArgs e)
        {
            if (trackBar_Maximo.Value < trackBar_Fabrica.Value)
            {
                trackBar_Maximo.Value = trackBar_Fabrica.Value + 1;
                return;
            }
            if (trackBar_Maximo.Value >= 999)
            {
                trackBar_Maximo.Value = 999;
            }
            M = ((trackBar_Maximo.Value % 10000) / 1000);
            C = ((trackBar_Maximo.Value % 1000) / 100);
            D = ((trackBar_Maximo.Value % 100) / 10);
            U = (trackBar_Maximo.Value % 10);

            textBox2.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + " ";

            string stringM = M.ToString(); // converte int m em string
            string stringC = C.ToString();
            string stringD = D.ToString();
            string stringU = U.ToString();

            max1 = Convert.ToChar(stringM); // converte a string m e char
            max2 = Convert.ToChar(stringC);
            max3 = Convert.ToChar(stringD);
            max4 = Convert.ToChar(stringU);
        }

        private void trackBar_Minimo_Scroll(object sender, EventArgs e)
        {
            if (trackBar_Minimo.Value > trackBar_Fabrica.Value)
            {
                trackBar_Minimo.Value = trackBar_Fabrica.Value - 1;
                return;
            }
            if (trackBar_Minimo.Value <= 0)
            {
                trackBar_Minimo.Value = 0;
            }
            M = ((trackBar_Minimo.Value % 10000) / 1000);
            C = ((trackBar_Minimo.Value % 1000) / 100);
            D = ((trackBar_Minimo.Value % 100) / 10);
            U = (trackBar_Minimo.Value % 10);

            textBox3.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + " ";

            string MinM = M.ToString(); // converte int m em string
            string MinC = C.ToString();
            string MinD = D.ToString();
            string MinU = U.ToString();

            min1 = Convert.ToChar(MinM); // converte a string m e char
            min2 = Convert.ToChar(MinC);
            min3 = Convert.ToChar(MinD);
            min4 = Convert.ToChar(MinU);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisorCLP_CONTADOR visor = new VisorCLP_CONTADOR();
            visor.TopLevel = true;
            visor.Visible = true;
            visor.StartPosition = FormStartPosition.Manual;
            visor.Location = new Point(866, 78);

            visualizarTextbox = textBox1.Text.ToCharArray();

            visualizar_clicado = 1;
            passarMsg = textBox5.Text.ToCharArray();

            mostrar1 = visualizarTextbox[0];
            mostrar2 = visualizarTextbox[1];
            mostrar3 = visualizarTextbox[2];
            mostrar4 = visualizarTextbox[3];
            mostrar5 = visualizarTextbox[4];

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
                vetortemporario[0] = VisorCLP_CONTADOR.vetorvazio[0];
                vetortemporario[1] = VisorCLP_CONTADOR.vetorvazio[1];
                vetortemporario[2] = VisorCLP_CONTADOR.vetorvazio[2];
                vetortemporario[3] = VisorCLP_CONTADOR.vetorvazio[3];
                vetortemporario[4] = VisorCLP_CONTADOR.vetorvazio[4];
                vetortemporario[5] = VisorCLP_CONTADOR.vetorvazio[5];
                vetortemporario[6] = VisorCLP_CONTADOR.vetorvazio[6];
                vetortemporario[7] = VisorCLP_CONTADOR.vetorvazio[7];
                vetortemporario[8] = VisorCLP_CONTADOR.vetorvazio[8];
                vetortemporario[9] = VisorCLP_CONTADOR.vetorvazio[9];
                vetortemporario[10] = VisorCLP_CONTADOR.vetorvazio[10];
                vetortemporario[11] = VisorCLP_CONTADOR.vetorvazio[11];
                vetortemporario[12] = VisorCLP_CONTADOR.vetorvazio[12];
                vetortemporario[13] = VisorCLP_CONTADOR.vetorvazio[13];
                vetortemporario[14] = VisorCLP_CONTADOR.vetorvazio[14];
                vetortemporario[15] = VisorCLP_CONTADOR.vetorvazio[15];
                vetortemporario[16] = VisorCLP_CONTADOR.vetorvazio[16];
                vetortemporario[17] = VisorCLP_CONTADOR.vetorvazio[17];
                vetortemporario[18] = VisorCLP_CONTADOR.vetorvazio[18];
                vetortemporario[19] = VisorCLP_CONTADOR.vetorvazio[19];
                vetortemporario[20] = VisorCLP_CONTADOR.vetorvazio[20];
                vetortemporario[21] = VisorCLP_CONTADOR.vetorvazio[21];
                vetortemporario[22] = VisorCLP_CONTADOR.vetorvazio[22];
                vetortemporario[23] = VisorCLP_CONTADOR.vetorvazio[23];
                vetortemporario[24] = VisorCLP_CONTADOR.vetorvazio[24];
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
                if (arquivoContador == 1)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileC01.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoContador == 2)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileC02.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
            }

            if (radioButton1.Checked == true)
            {
                Form1.Linha68_CON01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha68_CON01. 
                string converter = new string(Form1.Linha68_CON01); // converte Linha68_CON01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[68] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha69 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha69.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha69.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton2.Checked == true)
            {
                Form1.Linha69_CON02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha69_CON02. 
                string converter = new string(Form1.Linha69_CON02); // converte Linha69_CON02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[69] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha70 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha70.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha70.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton3.Checked == true)
            {
                Form1.Linha114_CON01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha68_CON01. 
                string converter = new string(Form1.Linha114_CON01); // converte Linha68_CON01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[114] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha115 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha115.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha115.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton4.Checked == true)
            {
                Form1.Linha115_CON02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha69_CON02. 
                string converter = new string(Form1.Linha115_CON02); // converte Linha69_CON02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[115] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha116 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha116.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha116.Close(); //fecha o arquivo depois de salvar.
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
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.ico_contador.Handle);
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form1.click_selecionar[1] = 0;
            Form1.img = Properties.Resources.linhas_gridview;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;

            Close();
        }

        private void CONTADOR_Shown(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            trackBar_Fabrica.Enabled = false;
            trackBar_Maximo.Enabled = false;
            trackBar_Minimo.Enabled = false;
            button3.Enabled = false;
            tb_comentario.Clear();
        }


        private void btn_fabrica_incrementar_Click(object sender, EventArgs e)
        {
            if (trackBar_Fabrica.Value >= 998)
            {
                trackBar_Fabrica.Value = 998;
            }
            trackBar_Fabrica.Value = trackBar_Fabrica.Value += 1;

            if (trackBar_Fabrica.Value < trackBar_Minimo.Value)
            {
                trackBar_Fabrica.Value = trackBar_Minimo.Value + 1;
                return;
            }
            if (trackBar_Fabrica.Value > trackBar_Maximo.Value)
            {
                trackBar_Fabrica.Value = trackBar_Maximo.Value - 1;
                return;
            }
            M = ((trackBar_Fabrica.Value % 10000) / 1000);
            C = ((trackBar_Fabrica.Value % 1000) / 100);
            D = ((trackBar_Fabrica.Value % 100) / 10);
            U = (trackBar_Fabrica.Value % 10);

            textBox1.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";

            string stringM = M.ToString(); // converte int m em string
            string stringC = C.ToString();
            string stringD = D.ToString();
            string stringU = U.ToString();

            fabrica1 = Convert.ToChar(stringM); // converte a string m e char
            fabrica2 = Convert.ToChar(stringC);
            fabrica3 = Convert.ToChar(stringD);
            fabrica4 = Convert.ToChar(stringU);
        }

        private void btn_fabrica_decrementar_Click(object sender, EventArgs e)
        {
            trackBar_Fabrica.Value = trackBar_Fabrica.Value -= 1;
            if (trackBar_Fabrica.Value < trackBar_Minimo.Value)
            {
                trackBar_Fabrica.Value = trackBar_Minimo.Value + 1;
                return;
            }
            if (trackBar_Fabrica.Value > trackBar_Maximo.Value)
            {
                trackBar_Fabrica.Value = trackBar_Maximo.Value - 1;
                return;
            }
            if (trackBar_Fabrica.Value <= 1)
            {
                trackBar_Fabrica.Value = 1;
            }
            M = ((trackBar_Fabrica.Value % 10000) / 1000);
            C = ((trackBar_Fabrica.Value % 1000) / 100);
            D = ((trackBar_Fabrica.Value % 100) / 10);
            U = (trackBar_Fabrica.Value % 10);

            textBox1.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";

            string stringM = M.ToString(); // converte int m em string
            string stringC = C.ToString();
            string stringD = D.ToString();
            string stringU = U.ToString();

            fabrica1 = Convert.ToChar(stringM); // converte a string m e char
            fabrica2 = Convert.ToChar(stringC);
            fabrica3 = Convert.ToChar(stringD);
            fabrica4 = Convert.ToChar(stringU);
        }

        private void btn_maximo_incrementar_Click(object sender, EventArgs e)
        {
            trackBar_Maximo.Value = trackBar_Maximo.Value += 1;
            if (trackBar_Maximo.Value >= 999)
            {
                trackBar_Maximo.Value = 999;
            }

            M = ((trackBar_Maximo.Value % 10000) / 1000);
            C = ((trackBar_Maximo.Value % 1000) / 100);
            D = ((trackBar_Maximo.Value % 100) / 10);
            U = (trackBar_Maximo.Value % 10);
           
            textBox2.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";

            string stringM = M.ToString(); // converte int m em string
            string stringC = C.ToString();
            string stringD = D.ToString();
            string stringU = U.ToString();

            max1 = Convert.ToChar(stringM); // converte a string m e char
            max2 = Convert.ToChar(stringC);
            max3 = Convert.ToChar(stringD);
            max4 = Convert.ToChar(stringU);
        }

        private void btn_maximo_decrementar_Click(object sender, EventArgs e)
        {
            trackBar_Maximo.Value = trackBar_Maximo.Value -= 1;
            if (trackBar_Maximo.Value < trackBar_Fabrica.Value)
            {
                trackBar_Maximo.Value = trackBar_Fabrica.Value + 1;
                return;
            }
            M = ((trackBar_Maximo.Value % 10000) / 1000);
            C = ((trackBar_Maximo.Value % 1000) / 100);
            D = ((trackBar_Maximo.Value % 100) / 10);
            U = (trackBar_Maximo.Value % 10);

            textBox2.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";

            string stringM = M.ToString(); // converte int m em string
            string stringC = C.ToString();
            string stringD = D.ToString();
            string stringU = U.ToString();

            max1 = Convert.ToChar(stringM); // converte a string m e char
            max2 = Convert.ToChar(stringC);
            max3 = Convert.ToChar(stringD);
            max4 = Convert.ToChar(stringU);
        }

        private void btn_minimo_incrementar_Click(object sender, EventArgs e)
        {
            trackBar_Minimo.Value = trackBar_Minimo.Value += 1;
            if (trackBar_Minimo.Value > trackBar_Fabrica.Value)
            {
                trackBar_Minimo.Value = trackBar_Fabrica.Value - 1;
                return;
            }
            M = ((trackBar_Minimo.Value % 10000) / 1000);
            C = ((trackBar_Minimo.Value % 1000) / 100);
            D = ((trackBar_Minimo.Value % 100) / 10);
            U = (trackBar_Minimo.Value % 10);

            textBox3.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";

            string MinM = M.ToString(); // converte int m em string
            string MinC = C.ToString();
            string MinD = D.ToString();
            string MinU = U.ToString();

            min1 = Convert.ToChar(MinM); // converte a string m e char
            min2 = Convert.ToChar(MinC);
            min3 = Convert.ToChar(MinD);
            min4 = Convert.ToChar(MinU);
        }

        private void btn_minimo_decrementar_Click(object sender, EventArgs e)
        {
            trackBar_Minimo.Value = trackBar_Minimo.Value -= 1;
            if (trackBar_Minimo.Value <= 0)
            {
                trackBar_Minimo.Value = 0;
            }

            M = ((trackBar_Minimo.Value % 10000) / 1000);
            C = ((trackBar_Minimo.Value % 1000) / 100);
            D = ((trackBar_Minimo.Value % 100) / 10);
            U = (trackBar_Minimo.Value % 10);

            textBox3.Text = M.ToString() + C.ToString() + D.ToString() + U.ToString() + "s";

            string MinM = M.ToString(); // converte int m em string
            string MinC = C.ToString();
            string MinD = D.ToString();
            string MinU = U.ToString();

            min1 = Convert.ToChar(MinM); // converte a string m e char
            min2 = Convert.ToChar(MinC);
            min3 = Convert.ToChar(MinD);
            min4 = Convert.ToChar(MinU);
        }

        private void rb_parametroFixo_CheckedChanged(object sender, EventArgs e)
        {
            trackBar_Maximo.Visible = false;
            trackBar_Minimo.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            btn_maximo_decrementar.Visible = false;
            btn_maximo_incrementar.Visible = false;
            btn_minimo_decrementar.Visible = false;
            btn_minimo_incrementar.Visible = false;
            label8.Visible = false;
            label6.Visible = false;
        }

        private void rb_parametro2_CheckedChanged(object sender, EventArgs e)
        {
            trackBar_Maximo.Visible = true;
            trackBar_Minimo.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            btn_maximo_decrementar.Visible = true;
            btn_maximo_incrementar.Visible = true;
            btn_minimo_decrementar.Visible = true;
            btn_minimo_incrementar.Visible = true;
            label8.Visible = true;
            label6.Visible = true;
        }

        private void rb_parametro1_CheckedChanged(object sender, EventArgs e)
        {
            trackBar_Maximo.Visible = true;
            trackBar_Minimo.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            btn_maximo_decrementar.Visible = true;
            btn_maximo_incrementar.Visible = true;
            btn_minimo_decrementar.Visible = true;
            btn_minimo_incrementar.Visible = true;
            label8.Visible = true;
            label6.Visible = true;
        }

    }
}
