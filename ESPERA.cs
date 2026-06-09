using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class ESPERA : Form
    {
        int espera_E1 = 116; // retardo passa a ter o nome de "espera"
        int espera_E2 = 117;
        int espera_E3 = 118;
        int espera_E4 = 119;
        int espera_E5 = 120;
        int espera_E6 = 121;
        int espera_E7 = 122;
        int espera_E8 = 123;

        public static int M;
        public static int C;
        public static int D;
        public static int U;

        public static int arquivoEspera;

        public static char[] vetorSemVisualizar = new char[32];

        public static char[] visualizarTextbox;

        public static int value;
        public static int value1;
        public static int value2;
        public static int value3;
        public static int value4;




        public static char fabrica1;
        public static char fabrica2;
        public static char fabrica3;
        public static char fabrica4;
        public static char fabrica5;
        public static char fabrica6;



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

        public ESPERA()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                arquivoEspera = 1;

                trackBar_Fabrica.Enabled = true;
                button3.Enabled = true;

                tb_comentario.Text = Form1.linha70.Trim();

                char[] Espera01 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR01.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

                // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                for (int x = 0; x < Espera01.Length; x++)
                {
                    vetorSemVisualizar[0] = Espera01[0];
                    vetorSemVisualizar[1] = Espera01[1];
                    vetorSemVisualizar[2] = Espera01[2];
                    vetorSemVisualizar[3] = Espera01[3];
                    vetorSemVisualizar[4] = Espera01[4];
                    vetorSemVisualizar[5] = Espera01[5];
                    vetorSemVisualizar[6] = Espera01[6];
                    vetorSemVisualizar[7] = Espera01[7];
                    vetorSemVisualizar[8] = Espera01[8];
                    vetorSemVisualizar[9] = Espera01[9];
                    vetorSemVisualizar[10] = Espera01[10];
                    vetorSemVisualizar[11] = Espera01[11];
                    vetorSemVisualizar[12] = Espera01[12];
                    vetorSemVisualizar[13] = Espera01[13];
                    vetorSemVisualizar[14] = Espera01[14];
                    vetorSemVisualizar[15] = Espera01[15];
                    vetorSemVisualizar[16] = Espera01[16];
                    vetorSemVisualizar[17] = Espera01[17];
                    vetorSemVisualizar[18] = Espera01[18];
                    vetorSemVisualizar[19] = Espera01[19];
                    vetorSemVisualizar[20] = Espera01[20];
                    vetorSemVisualizar[21] = Espera01[21];
                    vetorSemVisualizar[22] = Espera01[22];
                    vetorSemVisualizar[23] = Espera01[23];
                    vetorSemVisualizar[24] = Espera01[24];

                    value1 = int.Parse(Espera01[26].ToString()) * 1000;
                    value2 = int.Parse(Espera01[27].ToString()) * 100;
                    value3 = int.Parse(Espera01[28].ToString()) * 10;
                    value4 = int.Parse(Espera01[29].ToString()) * 1;

                    value = value1 + value2 + value3 + value4;

                    fabrica1 = Espera01[26];
                    fabrica2 = Espera01[27];
                    fabrica3 = Espera01[28];
                    fabrica4 = Espera01[29];

                    trackBar_Fabrica.Value = value;

                    textBox1.Text = Espera01[26].ToString() + Espera01[27].ToString() + Espera01[28].ToString() + "." + Espera01[29].ToString() + "s";
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                string existe4 = new string(vetorSemVisualizar);
                textBox5.Text = existe4;

                passarMsg = textBox5.Text.ToCharArray();

                vetortemporario = Form1.RecebendoconteudoRet01.ToCharArray();
                vetorSemVisualizar = textBox5.Text.ToCharArray();

                Form1.click_selecionar[1] = espera_E1;
                Form1.img = Properties.Resources.espera01;

            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            arquivoEspera = 2;

            trackBar_Fabrica.Enabled = true;

            button3.Enabled = true;
            tb_comentario.Text = Form1.linha71.Trim();
            char[] Espera02 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR02.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

            // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
            for (int x = 0; x < Espera02.Length; x++)
            {
                vetorSemVisualizar[0] = Espera02[0];
                vetorSemVisualizar[1] = Espera02[1];
                vetorSemVisualizar[2] = Espera02[2];
                vetorSemVisualizar[3] = Espera02[3];
                vetorSemVisualizar[4] = Espera02[4];
                vetorSemVisualizar[5] = Espera02[5];
                vetorSemVisualizar[6] = Espera02[6];
                vetorSemVisualizar[7] = Espera02[7];
                vetorSemVisualizar[8] = Espera02[8];
                vetorSemVisualizar[9] = Espera02[9];
                vetorSemVisualizar[10] = Espera02[10];
                vetorSemVisualizar[11] = Espera02[11];
                vetorSemVisualizar[12] = Espera02[12];
                vetorSemVisualizar[13] = Espera02[13];
                vetorSemVisualizar[14] = Espera02[14];
                vetorSemVisualizar[15] = Espera02[15];
                vetorSemVisualizar[16] = Espera02[16];
                vetorSemVisualizar[17] = Espera02[17];
                vetorSemVisualizar[18] = Espera02[18];
                vetorSemVisualizar[19] = Espera02[19];
                vetorSemVisualizar[20] = Espera02[20];
                vetorSemVisualizar[21] = Espera02[21];
                vetorSemVisualizar[22] = Espera02[22];
                vetorSemVisualizar[23] = Espera02[23];
                vetorSemVisualizar[24] = Espera02[24];

                value1 = int.Parse(Espera02[26].ToString()) * 1000;
                value2 = int.Parse(Espera02[27].ToString()) * 100;
                value3 = int.Parse(Espera02[28].ToString()) * 10;
                value4 = int.Parse(Espera02[29].ToString()) * 1;

                value = value1 + value2 + value3 + value4;

                fabrica1 = Espera02[26];
                fabrica2 = Espera02[27];
                fabrica3 = Espera02[28];
                fabrica4 = Espera02[29];

                trackBar_Fabrica.Value = value;

                textBox1.Text = Espera02[26].ToString() + Espera02[27].ToString() + Espera02[28].ToString() + "." + Espera02[29].ToString() + "s";
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();

            vetortemporario = Form1.RecebendoconteudoRet02.ToCharArray();
            vetorSemVisualizar = textBox5.Text.ToCharArray();

            Form1.click_selecionar[1] = espera_E2;
            Form1.img = Properties.Resources.espera02;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            arquivoEspera = 3;

            trackBar_Fabrica.Enabled = true;

            button3.Enabled = true;
            tb_comentario.Text = Form1.linha72.Trim();
            char[] Espera03 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR03.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

            // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
            for (int x = 0; x < Espera03.Length; x++)
            {
                vetorSemVisualizar[0] = Espera03[0];
                vetorSemVisualizar[1] = Espera03[1];
                vetorSemVisualizar[2] = Espera03[2];
                vetorSemVisualizar[3] = Espera03[3];
                vetorSemVisualizar[4] = Espera03[4];
                vetorSemVisualizar[5] = Espera03[5];
                vetorSemVisualizar[6] = Espera03[6];
                vetorSemVisualizar[7] = Espera03[7];
                vetorSemVisualizar[8] = Espera03[8];
                vetorSemVisualizar[9] = Espera03[9];
                vetorSemVisualizar[10] = Espera03[10];
                vetorSemVisualizar[11] = Espera03[11];
                vetorSemVisualizar[12] = Espera03[12];
                vetorSemVisualizar[13] = Espera03[13];
                vetorSemVisualizar[14] = Espera03[14];
                vetorSemVisualizar[15] = Espera03[15];
                vetorSemVisualizar[16] = Espera03[16];
                vetorSemVisualizar[17] = Espera03[17];
                vetorSemVisualizar[18] = Espera03[18];
                vetorSemVisualizar[19] = Espera03[19];
                vetorSemVisualizar[20] = Espera03[20];
                vetorSemVisualizar[21] = Espera03[21];
                vetorSemVisualizar[22] = Espera03[22];
                vetorSemVisualizar[23] = Espera03[23];
                vetorSemVisualizar[24] = Espera03[24];

                value1 = int.Parse(Espera03[26].ToString()) * 1000;
                value2 = int.Parse(Espera03[27].ToString()) * 100;
                value3 = int.Parse(Espera03[28].ToString()) * 10;
                value4 = int.Parse(Espera03[29].ToString()) * 1;

                value = value1 + value2 + value3 + value4;

                fabrica1 = Espera03[26];
                fabrica2 = Espera03[27];
                fabrica3 = Espera03[28];
                fabrica4 = Espera03[29];

                trackBar_Fabrica.Value = value;

                textBox1.Text = Espera03[26].ToString() + Espera03[27].ToString() + Espera03[28].ToString() + "." + Espera03[29].ToString() + "s";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();

            vetortemporario = Form1.RecebendoconteudoRet03.ToCharArray();
            vetorSemVisualizar = textBox5.Text.ToCharArray();

            Form1.click_selecionar[1] = espera_E3;
            Form1.img = Properties.Resources.espera03;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            arquivoEspera = 4;

            trackBar_Fabrica.Enabled = true;

            button3.Enabled = true;
            tb_comentario.Text = Form1.linha73.Trim();
            char[] Espera04 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR04.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

            // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
            for (int x = 0; x < Espera04.Length; x++)
            {
                vetorSemVisualizar[0] = Espera04[0];
                vetorSemVisualizar[1] = Espera04[1];
                vetorSemVisualizar[2] = Espera04[2];
                vetorSemVisualizar[3] = Espera04[3];
                vetorSemVisualizar[4] = Espera04[4];
                vetorSemVisualizar[5] = Espera04[5];
                vetorSemVisualizar[6] = Espera04[6];
                vetorSemVisualizar[7] = Espera04[7];
                vetorSemVisualizar[8] = Espera04[8];
                vetorSemVisualizar[9] = Espera04[9];
                vetorSemVisualizar[10] = Espera04[10];
                vetorSemVisualizar[11] = Espera04[11];
                vetorSemVisualizar[12] = Espera04[12];
                vetorSemVisualizar[13] = Espera04[13];
                vetorSemVisualizar[14] = Espera04[14];
                vetorSemVisualizar[15] = Espera04[15];
                vetorSemVisualizar[16] = Espera04[16];
                vetorSemVisualizar[17] = Espera04[17];
                vetorSemVisualizar[18] = Espera04[18];
                vetorSemVisualizar[19] = Espera04[19];
                vetorSemVisualizar[20] = Espera04[20];
                vetorSemVisualizar[21] = Espera04[21];
                vetorSemVisualizar[22] = Espera04[22];
                vetorSemVisualizar[23] = Espera04[23];
                vetorSemVisualizar[24] = Espera04[24];

                value1 = int.Parse(Espera04[26].ToString()) * 1000;
                value2 = int.Parse(Espera04[27].ToString()) * 100;
                value3 = int.Parse(Espera04[28].ToString()) * 10;
                value4 = int.Parse(Espera04[29].ToString()) * 1;

                value = value1 + value2 + value3 + value4;

                fabrica1 = Espera04[26];
                fabrica2 = Espera04[27];
                fabrica3 = Espera04[28];
                fabrica4 = Espera04[29];

                trackBar_Fabrica.Value = value;

                textBox1.Text = Espera04[26].ToString() + Espera04[27].ToString() + Espera04[28].ToString() + "." + Espera04[29].ToString() + "s";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();

            vetortemporario = Form1.RecebendoconteudoRet04.ToCharArray();
            vetorSemVisualizar = textBox5.Text.ToCharArray();

            Form1.click_selecionar[1] = espera_E4;
            Form1.img = Properties.Resources.espera04;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            arquivoEspera = 5;

            trackBar_Fabrica.Enabled = true;
            button3.Enabled = true;
            tb_comentario.Text = Form1.linha74.Trim();
            char[] Espera05 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR05.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

            // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
            for (int x = 0; x < Espera05.Length; x++)
            {
                vetorSemVisualizar[0] = Espera05[0];
                vetorSemVisualizar[1] = Espera05[1];
                vetorSemVisualizar[2] = Espera05[2];
                vetorSemVisualizar[3] = Espera05[3];
                vetorSemVisualizar[4] = Espera05[4];
                vetorSemVisualizar[5] = Espera05[5];
                vetorSemVisualizar[6] = Espera05[6];
                vetorSemVisualizar[7] = Espera05[7];
                vetorSemVisualizar[8] = Espera05[8];
                vetorSemVisualizar[9] = Espera05[9];
                vetorSemVisualizar[10] = Espera05[10];
                vetorSemVisualizar[11] = Espera05[11];
                vetorSemVisualizar[12] = Espera05[12];
                vetorSemVisualizar[13] = Espera05[13];
                vetorSemVisualizar[14] = Espera05[14];
                vetorSemVisualizar[15] = Espera05[15];
                vetorSemVisualizar[16] = Espera05[16];
                vetorSemVisualizar[17] = Espera05[17];
                vetorSemVisualizar[18] = Espera05[18];
                vetorSemVisualizar[19] = Espera05[19];
                vetorSemVisualizar[20] = Espera05[20];
                vetorSemVisualizar[21] = Espera05[21];
                vetorSemVisualizar[22] = Espera05[22];
                vetorSemVisualizar[23] = Espera05[23];
                vetorSemVisualizar[24] = Espera05[24];

                value1 = int.Parse(Espera05[26].ToString()) * 1000;
                value2 = int.Parse(Espera05[27].ToString()) * 100;
                value3 = int.Parse(Espera05[28].ToString()) * 10;
                value4 = int.Parse(Espera05[29].ToString()) * 1;

                value = value1 + value2 + value3 + value4;

                fabrica1 = Espera05[26];
                fabrica2 = Espera05[27];
                fabrica3 = Espera05[28];
                fabrica4 = Espera05[29];

                trackBar_Fabrica.Value = value;

                textBox1.Text = Espera05[26].ToString() + Espera05[27].ToString() + Espera05[28].ToString() + "." + Espera05[29].ToString() + "s";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();

            vetortemporario = Form1.RecebendoconteudoRet05.ToCharArray();
            vetorSemVisualizar = textBox5.Text.ToCharArray();

            Form1.click_selecionar[1] = espera_E5;
            Form1.img = Properties.Resources.espera05;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            arquivoEspera = 6;

            trackBar_Fabrica.Enabled = true;

            button3.Enabled = true;
            tb_comentario.Text = Form1.linha75.Trim();
            char[] Espera06 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR06.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

            // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
            for (int x = 0; x < Espera06.Length; x++)
            {
                vetorSemVisualizar[0] = Espera06[0];
                vetorSemVisualizar[1] = Espera06[1];
                vetorSemVisualizar[2] = Espera06[2];
                vetorSemVisualizar[3] = Espera06[3];
                vetorSemVisualizar[4] = Espera06[4];
                vetorSemVisualizar[5] = Espera06[5];
                vetorSemVisualizar[6] = Espera06[6];
                vetorSemVisualizar[7] = Espera06[7];
                vetorSemVisualizar[8] = Espera06[8];
                vetorSemVisualizar[9] = Espera06[9];
                vetorSemVisualizar[10] = Espera06[10];
                vetorSemVisualizar[11] = Espera06[11];
                vetorSemVisualizar[12] = Espera06[12];
                vetorSemVisualizar[13] = Espera06[13];
                vetorSemVisualizar[14] = Espera06[14];
                vetorSemVisualizar[15] = Espera06[15];
                vetorSemVisualizar[16] = Espera06[16];
                vetorSemVisualizar[17] = Espera06[17];
                vetorSemVisualizar[18] = Espera06[18];
                vetorSemVisualizar[19] = Espera06[19];
                vetorSemVisualizar[20] = Espera06[20];
                vetorSemVisualizar[21] = Espera06[21];
                vetorSemVisualizar[22] = Espera06[22];
                vetorSemVisualizar[23] = Espera06[23];
                vetorSemVisualizar[24] = Espera06[24];

                value1 = int.Parse(Espera06[26].ToString()) * 1000;
                value2 = int.Parse(Espera06[27].ToString()) * 100;
                value3 = int.Parse(Espera06[28].ToString()) * 10;
                value4 = int.Parse(Espera06[29].ToString()) * 1;

                value = value1 + value2 + value3 + value4;

                fabrica1 = Espera06[26];
                fabrica2 = Espera06[27];
                fabrica3 = Espera06[28];
                fabrica4 = Espera06[29];

                trackBar_Fabrica.Value = value;

                textBox1.Text = Espera06[26].ToString() + Espera06[27].ToString() + Espera06[28].ToString() + "." + Espera06[29].ToString() + "s";
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();

            vetortemporario = Form1.RecebendoconteudoRet06.ToCharArray();
            vetorSemVisualizar = textBox5.Text.ToCharArray();

            Form1.click_selecionar[1] = espera_E6;
            Form1.img = Properties.Resources.espera06;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            arquivoEspera = 7;

            trackBar_Fabrica.Enabled = true;
            button3.Enabled = true;

            char[] Espera07 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR07.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo
            tb_comentario.Text = Form1.linha76.Trim();
            // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
            for (int x = 0; x < Espera07.Length; x++)
            {
                vetorSemVisualizar[0] = Espera07[0];
                vetorSemVisualizar[1] = Espera07[1];
                vetorSemVisualizar[2] = Espera07[2];
                vetorSemVisualizar[3] = Espera07[3];
                vetorSemVisualizar[4] = Espera07[4];
                vetorSemVisualizar[5] = Espera07[5];
                vetorSemVisualizar[6] = Espera07[6];
                vetorSemVisualizar[7] = Espera07[7];
                vetorSemVisualizar[8] = Espera07[8];
                vetorSemVisualizar[9] = Espera07[9];
                vetorSemVisualizar[10] = Espera07[10];
                vetorSemVisualizar[11] = Espera07[11];
                vetorSemVisualizar[12] = Espera07[12];
                vetorSemVisualizar[13] = Espera07[13];
                vetorSemVisualizar[14] = Espera07[14];
                vetorSemVisualizar[15] = Espera07[15];
                vetorSemVisualizar[16] = Espera07[16];
                vetorSemVisualizar[17] = Espera07[17];
                vetorSemVisualizar[18] = Espera07[18];
                vetorSemVisualizar[19] = Espera07[19];
                vetorSemVisualizar[20] = Espera07[20];
                vetorSemVisualizar[21] = Espera07[21];
                vetorSemVisualizar[22] = Espera07[22];
                vetorSemVisualizar[23] = Espera07[23];
                vetorSemVisualizar[24] = Espera07[24];

                value1 = int.Parse(Espera07[26].ToString()) * 1000;
                value2 = int.Parse(Espera07[27].ToString()) * 100;
                value3 = int.Parse(Espera07[28].ToString()) * 10;
                value4 = int.Parse(Espera07[29].ToString()) * 1;

                value = value1 + value2 + value3 + value4;

                fabrica1 = Espera07[26];
                fabrica2 = Espera07[27];
                fabrica3 = Espera07[28];
                fabrica4 = Espera07[29];

                trackBar_Fabrica.Value = value;

                textBox1.Text = Espera07[26].ToString() + Espera07[27].ToString() + Espera07[28].ToString() + "." + Espera07[29].ToString() + "s";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();

            vetortemporario = Form1.RecebendoconteudoRet07.ToCharArray();
            vetorSemVisualizar = textBox5.Text.ToCharArray();

            Form1.click_selecionar[1] = espera_E7;
            Form1.img = Properties.Resources.espera07;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            arquivoEspera = 8;

            trackBar_Fabrica.Enabled = true;
            button3.Enabled = true;

            char[] Espera08 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR08.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo
            tb_comentario.Text = Form1.linha77.Trim();
            // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
            for (int x = 0; x < Espera08.Length; x++)
            {
                vetorSemVisualizar[0] = Espera08[0];
                vetorSemVisualizar[1] = Espera08[1];
                vetorSemVisualizar[2] = Espera08[2];
                vetorSemVisualizar[3] = Espera08[3];
                vetorSemVisualizar[4] = Espera08[4];
                vetorSemVisualizar[5] = Espera08[5];
                vetorSemVisualizar[6] = Espera08[6];
                vetorSemVisualizar[7] = Espera08[7];
                vetorSemVisualizar[8] = Espera08[8];
                vetorSemVisualizar[9] = Espera08[9];
                vetorSemVisualizar[10] = Espera08[10];
                vetorSemVisualizar[11] = Espera08[11];
                vetorSemVisualizar[12] = Espera08[12];
                vetorSemVisualizar[13] = Espera08[13];
                vetorSemVisualizar[14] = Espera08[14];
                vetorSemVisualizar[15] = Espera08[15];
                vetorSemVisualizar[16] = Espera08[16];
                vetorSemVisualizar[17] = Espera08[17];
                vetorSemVisualizar[18] = Espera08[18];
                vetorSemVisualizar[19] = Espera08[19];
                vetorSemVisualizar[20] = Espera08[20];
                vetorSemVisualizar[21] = Espera08[21];
                vetorSemVisualizar[22] = Espera08[22];
                vetorSemVisualizar[23] = Espera08[23];
                vetorSemVisualizar[24] = Espera08[24];

                value1 = int.Parse(Espera08[26].ToString()) * 1000;
                value2 = int.Parse(Espera08[27].ToString()) * 100;
                value3 = int.Parse(Espera08[28].ToString()) * 10;
                value4 = int.Parse(Espera08[29].ToString()) * 1;

                value = value1 + value2 + value3 + value4;

                fabrica1 = Espera08[26];
                fabrica2 = Espera08[27];
                fabrica3 = Espera08[28];
                fabrica4 = Espera08[29];

                trackBar_Fabrica.Value = value;

                textBox1.Text = Espera08[26].ToString() + Espera08[27].ToString() + Espera08[28].ToString() + "." + Espera08[29].ToString() + "s";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////           

            string existe4 = new string(vetorSemVisualizar);
            textBox5.Text = existe4;

            passarMsg = textBox5.Text.ToCharArray();

            vetortemporario = Form1.RecebendoconteudoRet08.ToCharArray();
            vetorSemVisualizar = textBox5.Text.ToCharArray();

            Form1.click_selecionar[1] = espera_E8;
            Form1.img = Properties.Resources.espera08;
        }

        private void trackBar_Fabrica_Scroll(object sender, EventArgs e)
        {
            if (trackBar_Fabrica.Value >= 999)
            {
                trackBar_Fabrica.Value = 999;
            }
            if (trackBar_Fabrica.Value <= 0)
            {
                trackBar_Fabrica.Value = 0;
            }

            M = ((trackBar_Fabrica.Value % 10000) / 1000);
            C = ((trackBar_Fabrica.Value % 1000) / 100);
            D = ((trackBar_Fabrica.Value % 100) / 10);
            U = (trackBar_Fabrica.Value % 10);

            textBox1.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";

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

        }

        private void trackBar_Minimo_Scroll(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            visorCLP_ESPERA visor = new visorCLP_ESPERA();
            visor.TopLevel = true;
            visor.Visible = true;
            visor.StartPosition = FormStartPosition.Manual;
            visor.Location = new Point(866, 78);

            visualizarTextbox = textBox1.Text.ToCharArray();
            mostrar1 = visualizarTextbox[0];
            mostrar2 = visualizarTextbox[1];
            mostrar3 = visualizarTextbox[2];
            mostrar4 = visualizarTextbox[3];
            mostrar5 = visualizarTextbox[4];

            visualizar_clicado = 1;
            passarMsg = textBox5.Text.ToCharArray();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form1.Linha70_ESP01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha70_ESP01. 
                string converter = new string(Form1.Linha70_ESP01); // converte Linha70_ESP01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[70] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha71 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha71.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha71.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton2.Checked == true)
            {
                Form1.Linha71_ESP02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha71_ESP02. 
                string converter = new string(Form1.Linha71_ESP02); // converte Linha71_ESP02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[71] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha72 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha72.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha72.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton3.Checked == true)
            {
                Form1.Linha72_ESP03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha72_ESP03. 
                string converter = new string(Form1.Linha72_ESP03); // converte Linha72_ESP03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[72] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha73 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha73.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha73.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton4.Checked == true)
            {
                Form1.Linha73_ESP04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha73_ESP04. 
                string converter = new string(Form1.Linha73_ESP04); // converte Linha73_ESP04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[73] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha74 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha74.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha74.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton5.Checked == true)
            {
                Form1.Linha74_ESP05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha74_ESP05. 
                string converter = new string(Form1.Linha74_ESP05); // converte Linha74_ESP05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[74] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha75 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha75.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha75.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton6.Checked == true)
            {
                Form1.Linha75_ESP06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha75_ESP06. 
                string converter = new string(Form1.Linha75_ESP06); // converte Linha75_ESP06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[75] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha76 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha76.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha76.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton7.Checked == true)
            {
                Form1.Linha76_ESP07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha76_ESP07. 
                string converter = new string(Form1.Linha76_ESP07); // converte Linha76_ESP07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[76] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha77 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha77.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha77.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton8.Checked == true)
            {
                Form1.Linha77_ESP08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha77_ESP08. 
                string converter = new string(Form1.Linha77_ESP08); // converte Linha77_ESP08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[77] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha78 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha78.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha78.Close(); //fecha o arquivo depois de salvar.
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

            Form1.saidaOuDisplay = 0;
            Form1.completarLinha = 0;
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
                vetortemporario[0] = visorCLP_ESPERA.vetorvazio[0];
                vetortemporario[1] = visorCLP_ESPERA.vetorvazio[1];
                vetortemporario[2] = visorCLP_ESPERA.vetorvazio[2];
                vetortemporario[3] = visorCLP_ESPERA.vetorvazio[3];
                vetortemporario[4] = visorCLP_ESPERA.vetorvazio[4];
                vetortemporario[5] = visorCLP_ESPERA.vetorvazio[5];
                vetortemporario[6] = visorCLP_ESPERA.vetorvazio[6];
                vetortemporario[7] = visorCLP_ESPERA.vetorvazio[7];
                vetortemporario[8] = visorCLP_ESPERA.vetorvazio[8];
                vetortemporario[9] = visorCLP_ESPERA.vetorvazio[9];
                vetortemporario[10] = visorCLP_ESPERA.vetorvazio[10];
                vetortemporario[11] = visorCLP_ESPERA.vetorvazio[11];
                vetortemporario[12] = visorCLP_ESPERA.vetorvazio[12];
                vetortemporario[13] = visorCLP_ESPERA.vetorvazio[13];
                vetortemporario[14] = visorCLP_ESPERA.vetorvazio[14];
                vetortemporario[15] = visorCLP_ESPERA.vetorvazio[15];
                vetortemporario[16] = visorCLP_ESPERA.vetorvazio[16];
                vetortemporario[17] = visorCLP_ESPERA.vetorvazio[17];
                vetortemporario[18] = visorCLP_ESPERA.vetorvazio[18];
                vetortemporario[19] = visorCLP_ESPERA.vetorvazio[19];
                vetortemporario[20] = visorCLP_ESPERA.vetorvazio[20];
                vetortemporario[21] = visorCLP_ESPERA.vetorvazio[21];
                vetortemporario[22] = visorCLP_ESPERA.vetorvazio[22];
                vetortemporario[23] = visorCLP_ESPERA.vetorvazio[23];
                vetortemporario[24] = visorCLP_ESPERA.vetorvazio[24];
                vetortemporario[25] = ';';

                vetortemporario[26] = fabrica1;
                vetortemporario[27] = fabrica2;
                vetortemporario[28] = fabrica3;
                vetortemporario[29] = fabrica4;

                vetortemporario[30] = ';';

                vetortemporario[31] = '0';
                vetortemporario[32] = '9';
                vetortemporario[33] = '9';
                vetortemporario[34] = '9';

                vetortemporario[35] = ';';

                vetortemporario[36] = '0';
                vetortemporario[37] = '0';
                vetortemporario[38] = '0';
                vetortemporario[39] = '1';
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

                vetortemporario[31] = '0';
                vetortemporario[32] = '9';
                vetortemporario[33] = '9';
                vetortemporario[34] = '9';

                vetortemporario[35] = ';';

                vetortemporario[36] = '0';
                vetortemporario[37] = '0';
                vetortemporario[38] = '0';
                vetortemporario[39] = '1';
                vetortemporario[40] = ';';
                vetortemporario[42] = ';';

            }

            if (rb_parametro1.Checked == true) { vetortemporario[41] = '1'; }
            if (rb_parametro2.Checked == true) { vetortemporario[41] = '2'; }
            if (rb_parametroFixo.Checked == true) { vetortemporario[41] = '3'; }

            foreach (char letra in vetortemporario)
            {
                if (arquivoEspera == 1)
                {

                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileR01.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoEspera == 2)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileR02.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoEspera == 3)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileR03.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoEspera == 4)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileR04.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoEspera == 5)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileR05.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoEspera == 6)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileR06.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoEspera == 7)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileR07.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoEspera == 8)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileR08.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
            }
            Form1.completarLinha = 1;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Cursor = new Cursor(Handle);
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_espera.Handle);
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

        private void ESPERA_Shown(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            trackBar_Fabrica.Enabled = true;
            button3.Enabled = true;
            tb_comentario.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ESPERA_Load(object sender, EventArgs e)
        {

        }

        private void btn_incrementar_Click(object sender, EventArgs e)
        {
            trackBar_Fabrica.Value = trackBar_Fabrica.Value += 1;
            if (trackBar_Fabrica.Value >= 999)
            {
                trackBar_Fabrica.Value = 999;
            }
            M = ((trackBar_Fabrica.Value % 10000) / 1000);
            C = ((trackBar_Fabrica.Value % 1000) / 100);
            D = ((trackBar_Fabrica.Value % 100) / 10);
            U = (trackBar_Fabrica.Value % 10);

            textBox1.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";

            string stringM = M.ToString(); // converte int m em string
            string stringC = C.ToString();
            string stringD = D.ToString();
            string stringU = U.ToString();

            fabrica1 = Convert.ToChar(stringM); // converte a string m e char
            fabrica2 = Convert.ToChar(stringC);
            fabrica3 = Convert.ToChar(stringD);
            fabrica4 = Convert.ToChar(stringU);
        }

        private void btn_decrementar_Click(object sender, EventArgs e)
        {
            trackBar_Fabrica.Value = trackBar_Fabrica.Value -= 1;
            if (trackBar_Fabrica.Value <= 0)
            {
                trackBar_Fabrica.Value = 0;
            }
            M = ((trackBar_Fabrica.Value % 10000) / 1000);
            C = ((trackBar_Fabrica.Value % 1000) / 100);
            D = ((trackBar_Fabrica.Value % 100) / 10);
            U = (trackBar_Fabrica.Value % 10);

            textBox1.Text = M.ToString() + C.ToString() + D.ToString() + "." + U.ToString() + "s";

            string stringM = M.ToString(); // converte int m em string
            string stringC = C.ToString();
            string stringD = D.ToString();
            string stringU = U.ToString();

            fabrica1 = Convert.ToChar(stringM); // converte a string m e char
            fabrica2 = Convert.ToChar(stringC);
            fabrica3 = Convert.ToChar(stringD);
            fabrica4 = Convert.ToChar(stringU);
        }
    }

}
