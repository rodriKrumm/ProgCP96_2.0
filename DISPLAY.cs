using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class DISPLAY : Form
    {
        public static int tela_inicial = 0;
        public static string valor;
        public static string variavel;
        string tela_trab = " ";

        int display_d1 = 148;
        int display_d2 = 149;
        int display_d3 = 150;
        int display_d4 = 151;
        int display_d5 = 152;
        int display_d6 = 153;
        int display_d7 = 154;
        int display_d8 = 155;

        public static int visualizar1 = 0;
        public static int visualizar2 = 0;

        public static int arquivoDisplay;

        public static char[] vetorvazio = new char[64];
        public static char[] vetorvazio2 = new char[64];

        public static char[] vetorTemporario = new char[64];
        public static char[] vetorTemporario2;

        public static char[] vetorLinha1 = new char[32];
        public static char[] vetorLinha2 = new char[32];

        public static char[] repassarMsg;
        public static char[] repassarMsg2;

        public static char[] recebeMsg = new char[32];
        public static char[] recebeMsg2 = new char[32];

        public char[] repassarLabel_Display;

        public static char[] vetorSemVisualizar;

        public static string[] vetorVariaveis = new string[8];
        public char[] vetor_label_linha1 = new char[16];
        public char[] vetor_label_linha2 = new char[16];
        public char[] vetorArquivo;
        public char[] vetor_textbox;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public string index;
        public string passaTexto;

        char[] p = new char[64];

        public DISPLAY()
        {
            InitializeComponent();
        }

        private void DISPLAY_Load(object sender, EventArgs e)
        {
            //textBox2.Visible = false;
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                arquivoDisplay = 1;
                vetorTemporario = Form1.RecebendoconteudoMsg01.ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo  

                string converter = new string(vetorTemporario); // Converter de char[] para string

                txt_1.Text = converter.Trim(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();
            }
            Form1.click_selecionar[1] = display_d1;
            Form1.img = Properties.Resources.d01;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                arquivoDisplay = 2;
                vetorTemporario = Form1.RecebendoconteudoMsg02_2.ToCharArray();
                string converter = new string(vetorTemporario); //Converter de char[] para string
                txt_1.Text = converter.TrimEnd(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();
            }
            Form1.click_selecionar[1] = display_d2;
            Form1.img = Properties.Resources.d02;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                arquivoDisplay = 3;

                vetorTemporario = Form1.RecebendoconteudoMsg03.ToCharArray(); //vetor que pega os valores da escala de fabrica no arquivo
                string converter = new string(vetorTemporario); //Converter de char[] para string
                txt_1.Text = converter.TrimEnd(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();
            }

            Form1.click_selecionar[1] = display_d3;
            Form1.img = Properties.Resources.d03;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                arquivoDisplay = 4;

                vetorTemporario = Form1.RecebendoconteudoMsg04.ToCharArray(); //vetor que pega os valores da escala de fabrica no arquivo
                string converter = new string(vetorTemporario); //Converter de char[] para string
                txt_1.Text = converter.TrimEnd(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();

            }
            Form1.click_selecionar[1] = display_d4;
            Form1.img = Properties.Resources.d04;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                arquivoDisplay = 5;

                vetorTemporario = Form1.RecebendoconteudoMsg05.ToCharArray(); //vetor que pega os valores da escala de fabrica no arquivo
                string converter = new string(vetorTemporario); //Converter de char[] para string
                txt_1.Text = converter.TrimEnd(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();

            }
            Form1.click_selecionar[1] = display_d5;
            Form1.img = Properties.Resources.d05;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                vetorTemporario = Form1.RecebendoconteudoMsg06.ToCharArray(); //vetor que pega os valores da escala de fabrica no arquivo
                string converter = new string(vetorTemporario); //Converter de char[] para string
                txt_1.Text = converter.TrimEnd(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();
                arquivoDisplay = 6;
            }
            Form1.click_selecionar[1] = display_d6;
            Form1.img = Properties.Resources.d06;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                vetorTemporario = Form1.RecebendoconteudoMsg07.ToCharArray(); //vetor que pega os valores da escala de fabrica no arquivo
                string converter = new string(vetorTemporario); //Converter de char[] para string
                txt_1.Text = converter.TrimEnd(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();
                arquivoDisplay = 7;
            }
            Form1.click_selecionar[1] = display_d7;
            Form1.img = Properties.Resources.d07;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                vetorTemporario = Form1.RecebendoconteudoMsg08.ToCharArray(); //vetor que pega os valores da escala de fabrica no arquivo
                string converter = new string(vetorTemporario); //Converter de char[] para string
                txt_1.Text = converter.TrimEnd(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();
                arquivoDisplay = 8;

            }
            Form1.click_selecionar[1] = display_d8;
            Form1.img = Properties.Resources.d08;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                vetorTemporario = Form1.RecebendoconteudoMsg00.ToCharArray(); //vetor que pega os valores da escala de fabrica no arquivo
                string converter = new string(vetorTemporario); //Converter de char[] para string
                txt_1.Text = converter.TrimEnd(); // TrimEnd -- retira os espaços vazios 
                repassarMsg = txt_1.Text.ToCharArray();
                arquivoDisplay = 9;
                
                Form1.click_selecionar[1] = 0;
                Form1.img = Properties.Resources.linhas_gridview;
               
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Form1.saidaOuDisplay = 1;
            Form1.completarLinha = 5;
            if (txt_1.Text == string.Empty)
            {
                repassarMsg = "      ".ToCharArray();
            }
            else
            {
                repassarMsg = txt_1.Text.ToCharArray();
            }
           
            recebeMsg = repassarMsg;

            for (int i = 0; i < vetorvazio.Length; i++)
            {
                vetorvazio[i] = ' ';
            }
            for (int i = 0; i < recebeMsg.Length; i++)
            {                
                    vetorvazio[i] = recebeMsg[i];
                    vetorTemporario[0] = vetorvazio[0];
                    vetorTemporario[1] = vetorvazio[1];
                    vetorTemporario[2] = vetorvazio[2];
                    vetorTemporario[3] = vetorvazio[3];
                    vetorTemporario[4] = vetorvazio[4];
                    vetorTemporario[5] = vetorvazio[5];
                    vetorTemporario[6] = vetorvazio[6];
                    vetorTemporario[7] = vetorvazio[7];
                    vetorTemporario[8] = vetorvazio[8];
                    vetorTemporario[9] = vetorvazio[9];
                    vetorTemporario[10] = vetorvazio[10];
                    vetorTemporario[11] = vetorvazio[11];
                    vetorTemporario[12] = vetorvazio[12];
                    vetorTemporario[13] = vetorvazio[13];
                    vetorTemporario[14] = vetorvazio[14];
                    vetorTemporario[15] = vetorvazio[15];
                    vetorTemporario[16] = vetorvazio[16];
                    vetorTemporario[17] = vetorvazio[17];
                    vetorTemporario[18] = vetorvazio[18];
                    vetorTemporario[19] = vetorvazio[19];
                    vetorTemporario[20] = vetorvazio[20];
                    vetorTemporario[21] = vetorvazio[21];
                    vetorTemporario[22] = vetorvazio[22];
                    vetorTemporario[23] = vetorvazio[23];
                    vetorTemporario[24] = vetorvazio[24];
                    vetorTemporario[25] = vetorvazio[25];
                    vetorTemporario[26] = vetorvazio[26];
                    vetorTemporario[27] = vetorvazio[27];
                    vetorTemporario[28] = vetorvazio[28];
                    vetorTemporario[29] = vetorvazio[29];
                    vetorTemporario[30] = vetorvazio[30];
                    vetorTemporario[31] = vetorvazio[31];
                    vetorTemporario[32] = vetorvazio[32];
                    vetorTemporario[33] = vetorvazio[33];
                    vetorTemporario[34] = vetorvazio[34];
                    vetorTemporario[35] = vetorvazio[35];
                    vetorTemporario[36] = vetorvazio[36];
                    vetorTemporario[37] = vetorvazio[37];
                    vetorTemporario[38] = vetorvazio[38];
                    vetorTemporario[39] = vetorvazio[39];
                    vetorTemporario[40] = vetorvazio[40];
                    vetorTemporario[41] = vetorvazio[41];
                    vetorTemporario[42] = vetorvazio[42];                               
            }
          
            if (arquivoDisplay == 1)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD01.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            if (arquivoDisplay == 2)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD02.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            if (arquivoDisplay == 3)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD03.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            if (arquivoDisplay == 4)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD04.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            if (arquivoDisplay == 5)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD05.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            if (arquivoDisplay == 6)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD06.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            if (arquivoDisplay == 7)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD07.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            if (arquivoDisplay == 8)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD08.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            
            if (arquivoDisplay == 9)
            {
                StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileD00.txt");
                salvar.Write(vetorTemporario);
                salvar.Close();
            }
            

            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_display.Handle);

            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void lcd_ihm_putc(char[] t)
        {
            char[] ch = new char[5];
            string str = "     ";

            int i;
            int k;
            int j;
            int x;
            int TECLA_EXIT = 0;
            char[] d = new char[35];


            for (i = 0; i < 64; i++)
            {
                p[i] = ' ';
            }

            j = t.Length;
            if (j > 64) j = 64;
            for (i = 0; i < j; i++)
            {
                p[i] = t[i];
            }
            j--;
            i = 0;
            k = 0;
            x = 0;
            TECLA_EXIT = 1;
            while (TECLA_EXIT == 1)
            {
                switch (p[i])
                {
                    case '\r':
                        d[k] = p[i];

                        if (i < j) { i++; }
                        if (k < 34) { k++; }

                        d[k] = p[i];
                        if (p[i] == '\n')
                        {
                            x++;
                            if (x == 2) TECLA_EXIT = 0;
                        }
                        break;

                    case '#':
                        if (i < j) { i++; }
                        ch[0] = p[i];
                        if (i < j) { i++; }
                        ch[1] = p[i];
                        if (i < j) { i++; }
                        ch[2] = p[i];
                        if (i < j) { i++; }
                        ch[3] = p[i];
                        if (i < j) { i++; }
                        ch[4] = p[i];



                        str = ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString();
                        if (i < (j + 1)) { i++; }
                        switch (str)
                        {
                            case "ALLIN": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ALLOU": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "ENF01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "EBP01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "EBN01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "SNA01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "SNF01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "SET01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "RES01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "CAX01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "CAX09": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX10": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX11": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX12": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX13": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX14": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "CON01": d[k] = 'X'; if (k < 34) { if (k < 34) { k++; } } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CON02": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            case "TMP01": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP02": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP03": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP04": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP05": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP06": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP07": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP08": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            case "TMP09": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP10": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP11": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP12": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP13": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP14": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP15": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP16": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            case "TMP17": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP18": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP19": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP20": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP21": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP22": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP23": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP24": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            case "ANG01": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ANG02": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ANG03": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ANG04": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            default:
                                TECLA_EXIT = 0;
                                break;
                        }

                        ////verifica se não estourou limites da matriz ou do display
                        if (i >= 63 || k >= 34)
                        {
                            TECLA_EXIT = 0;
                        }
                        break;


                    default:
                        d[k] = p[i];
                        i++;
                        k++;
                        if (i >= 63 || k >= 34)
                        {
                            TECLA_EXIT = 0;
                        }
                        break;

                }
            }


            TECLA_EXIT = 1;
            i = 0;
            k = 0;
            while (TECLA_EXIT == 1)
            {

                ///////////////////////LINHA 1////////////////////////////
                switch (i)
                {
                    case 0:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_0.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 1:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_1.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 2:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_2.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 3:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_3.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 4:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_4.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 5:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_5.Text = d[k].ToString();
                            k++;
                        }
                        break;


                    case 6:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_6.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 7:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_7.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 8:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_8.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 9:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_9.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 10:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_10.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 11:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_11.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 12:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_12.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 13:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_13.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 14:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_14.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 15:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_15.Text = d[k].ToString();
                            k++;
                        }
                        break;
                    ///////////////////////LINHA 2////////////////////////////
                    case 16:
                        if (d[i] == '\r')
                        {
                            //TECLA_EXIT = 0;
                            k = k + 2;
                            lb_16.Text = d[k].ToString();
                            k++;
                        }
                        else
                        {
                            lb_16.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 17:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_17.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 18:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_18.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 19:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_19.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 20:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_20.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 21:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_21.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 22:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_22.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 23:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_23.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 24:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_24.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 25:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_25.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 26:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_26.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 27:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_27.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 28:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_28.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 29:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_29.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 30:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_30.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 31:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_31.Text = d[k].ToString();
                            k++;
                        }
                        break;
                        
                    default:
                        TECLA_EXIT = 0;
                        break;
                }
                i++;

            }
        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {
            char[] t = new char[64];
            int j = 64;
            t = txt_1.Text.ToCharArray();

            for (int i = 0; i < 64; i++)
            {
                p[i] = ' ';
            }

            j = t.Length;
            if (j > 64) j = 64;
            for (int i = 0; i < j; i++)
            {
                p[i] = t[i];
            }

            lcd_ihm_putc(txt_1.Text.ToCharArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + passaTexto; // inserir variavel
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            passaTexto = comboBox1.SelectedItem.ToString();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.click_selecionar[1] = 0;
            Form1.img = Properties.Resources.linhas_gridview;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            Close();
        }

        private void DISPLAY_Shown(object sender, EventArgs e)
        {
            string mensagem00 = Form1.caminhoarq + @"\FileD00.txt";
            string conteudoMsg00 = System.IO.File.ReadAllText(mensagem00);
            Form1.RecebendoconteudoMsg00 = conteudoMsg00;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem01 = Form1.caminhoarq + @"\FileD01.txt";
            string conteudoMsg01 = System.IO.File.ReadAllText(mensagem01);
            Form1.RecebendoconteudoMsg01 = conteudoMsg01;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem02 = Form1.caminhoarq + @"\FileD02.txt";
            string conteudoMsg02 = System.IO.File.ReadAllText(mensagem02);
            Form1.RecebendoconteudoMsg02_2 = conteudoMsg02;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem03 = Form1.caminhoarq + @"\FileD03.txt";
            string conteudoMsg03 = System.IO.File.ReadAllText(mensagem03);
            Form1.RecebendoconteudoMsg03 = conteudoMsg03;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem04 = Form1.caminhoarq + @"\FileD04.txt";
            string conteudoMsg04 = System.IO.File.ReadAllText(mensagem04);
            Form1.RecebendoconteudoMsg04 = conteudoMsg04;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem05 = Form1.caminhoarq + @"\FileD05.txt";
            string conteudoMsg05 = System.IO.File.ReadAllText(mensagem05);
            Form1.RecebendoconteudoMsg05 = conteudoMsg05;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem06 = Form1.caminhoarq + @"\FileD06.txt";
            string conteudoMsg06 = System.IO.File.ReadAllText(mensagem06);
            Form1.RecebendoconteudoMsg06 = conteudoMsg06;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem07 = Form1.caminhoarq + @"\FileD07.txt";
            string conteudoMsg07 = System.IO.File.ReadAllText(mensagem07);
            Form1.RecebendoconteudoMsg07 = conteudoMsg07;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem08 = Form1.caminhoarq + @"\FileD08.txt";
            string conteudoMsg08 = System.IO.File.ReadAllText(mensagem08);
            Form1.RecebendoconteudoMsg08 = conteudoMsg08;
        }     
    }
}
