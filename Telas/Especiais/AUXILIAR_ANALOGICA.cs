using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class AUXILIAR_ANALOGICA : Form
    {
        int ANG_1 = 156;
        int ANG_2 = 157;
        int ANG_3 = 158;
        int ANG_4 = 159;

        public static string pegandoCaminho;

        public static int visualizar1 = 0;
        public static int visualizar2 = 0;

        int arquivoDisplay;

        public static char[] vetorvazio = new char[32];
        public static char[] vetorvazio2 = new char[21];

        public static char[] vetorTemporario;
        public static char[] vetorTemporario2;

        public static char[] vetorLinha1 = new char[32];
        public static char[] vetorLinha2 = new char[21];

        public static char[] repassarMsg;
        public static char[] repassarMsg2;

        public static char[] recebeMsg = new char[32];
        public static char[] recebeMsg2 = new char[21];


        public AUXILIAR_ANALOGICA()
        {
            InitializeComponent();
        }

        private void AUXILIAR_ANALOGICA_Shown(object sender, EventArgs e)
        {
            //groupBox1.BackgroundImage = Properties.Resources._default;
            radioButton1.Checked = true;
            arb2.Checked = false;
            arb3.Checked = false;
            arb4.Checked = false;
            //tb_comentario.Clear();
            pegandoCaminho = Form1.repassandoCaminho;

        }

        private void arb2_CheckedChanged(object sender, EventArgs e)
        {
            if (arb2.Checked == true)
            {
                arquivoDisplay = 2;
                vetorTemporario = Form1.RecebendoconteudoA02.ToCharArray();
                string converter = new string(vetorTemporario); //Converter de char[] para string
                string pedaco = converter.Substring(0, 25);
                textbox_linha1.Text = pedaco.Trim(); // TrimEnd -- retira os espaços vazios 

                groupBox1.BackgroundImage = Properties.Resources.Aux02;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = ANG_2;
                Form1.img = Properties.Resources.ANG_E02;
                tb_comentario.Text = Form1.linha65.Trim();
            }
        }

        private void arb3_CheckedChanged(object sender, EventArgs e)
        {
            if (arb3.Checked == true)
            {
                arquivoDisplay = 3;
                vetorTemporario = Form1.RecebendoconteudoA03.ToCharArray();
                string converter = new string(vetorTemporario); //Converter de char[] para string
                string pedaco = converter.Substring(0, 25);
                textbox_linha1.Text = pedaco.Trim(); // TrimEnd -- retira os espaços vazios rm1.RecebendoconteudoA03.ToCharArray();
                groupBox1.BackgroundImage = Properties.Resources.Aux03;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = ANG_3;
                Form1.img = Properties.Resources.ANG_E03;
                tb_comentario.Text = Form1.linha66.Trim();
            }
        }

        private void arb4_CheckedChanged(object sender, EventArgs e)
        {
            if (arb4.Checked == true)
            {
                arquivoDisplay = 4;
                vetorTemporario = Form1.RecebendoconteudoA04.ToCharArray();
                string converter = new string(vetorTemporario); //Converter de char[] para string
                string pedaco = converter.Substring(0, 25);
                textbox_linha1.Text = pedaco.Trim(); // TrimEnd -- retira os espaços vazios 
                groupBox1.BackgroundImage = Properties.Resources.Aux04;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = ANG_4;
                Form1.img = Properties.Resources.ANG_E04;
                tb_comentario.Text = Form1.linha67.Trim();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Form1.saidaOuDisplay = 0;
            Form1.completarLinha = 0;
            repassarMsg = textbox_linha1.Text.ToCharArray();
            recebeMsg = repassarMsg;
            for (int i = 0; i < 32; i++)
            {
                vetorvazio[i] = ' ';
            }
            for (int i = 0; i < recebeMsg.Length; i++)
            {
                vetorvazio[i] = recebeMsg[i];
            }

            if (visualizar1 == 1)
            {
                vetorTemporario[0] = MENSAGEM_DISPLAY2.vetorVazio[0];
                vetorTemporario[1] = MENSAGEM_DISPLAY2.vetorVazio[1];
                vetorTemporario[2] = MENSAGEM_DISPLAY2.vetorVazio[2];
                vetorTemporario[3] = MENSAGEM_DISPLAY2.vetorVazio[3];
                vetorTemporario[4] = MENSAGEM_DISPLAY2.vetorVazio[4];
                vetorTemporario[5] = MENSAGEM_DISPLAY2.vetorVazio[5];
                vetorTemporario[6] = MENSAGEM_DISPLAY2.vetorVazio[6];
                vetorTemporario[7] = MENSAGEM_DISPLAY2.vetorVazio[7];
                vetorTemporario[8] = MENSAGEM_DISPLAY2.vetorVazio[8];
                vetorTemporario[9] = MENSAGEM_DISPLAY2.vetorVazio[9];
                vetorTemporario[10] = MENSAGEM_DISPLAY2.vetorVazio[10];
                vetorTemporario[11] = MENSAGEM_DISPLAY2.vetorVazio[11];
                vetorTemporario[12] = MENSAGEM_DISPLAY2.vetorVazio[12];
                vetorTemporario[13] = MENSAGEM_DISPLAY2.vetorVazio[13];
                vetorTemporario[14] = MENSAGEM_DISPLAY2.vetorVazio[14];
                vetorTemporario[15] = MENSAGEM_DISPLAY2.vetorVazio[15];
                vetorTemporario[16] = MENSAGEM_DISPLAY2.vetorVazio[16];
                vetorTemporario[17] = MENSAGEM_DISPLAY2.vetorVazio[17];
                vetorTemporario[18] = MENSAGEM_DISPLAY2.vetorVazio[18];
                vetorTemporario[19] = MENSAGEM_DISPLAY2.vetorVazio[19];
                vetorTemporario[20] = MENSAGEM_DISPLAY2.vetorVazio[20];
                vetorTemporario[21] = MENSAGEM_DISPLAY2.vetorVazio[21];
                vetorTemporario[22] = MENSAGEM_DISPLAY2.vetorVazio[22];
                vetorTemporario[23] = MENSAGEM_DISPLAY2.vetorVazio[23];
                vetorTemporario[24] = MENSAGEM_DISPLAY2.vetorVazio[24];
                vetorTemporario[25] = MENSAGEM_DISPLAY2.vetorVazio[25];
                vetorTemporario[26] = MENSAGEM_DISPLAY2.vetorVazio[26];
                vetorTemporario[27] = MENSAGEM_DISPLAY2.vetorVazio[27];
                vetorTemporario[28] = MENSAGEM_DISPLAY2.vetorVazio[28];
                vetorTemporario[29] = MENSAGEM_DISPLAY2.vetorVazio[29];
                vetorTemporario[30] = MENSAGEM_DISPLAY2.vetorVazio[30];
                vetorTemporario[31] = MENSAGEM_DISPLAY2.vetorVazio[31];
                vetorTemporario[32] = ' ';
                vetorTemporario[33] = ' ';
                vetorTemporario[34] = ' ';
                vetorTemporario[35] = ' ';
                vetorTemporario[36] = ' ';
                vetorTemporario[37] = ' ';
                vetorTemporario[38] = ' ';
                vetorTemporario[39] = ' ';
                vetorTemporario[40] = ' ';
                vetorTemporario[41] = ' ';
                vetorTemporario[42] = ';';
            }
            if (visualizar1 == 0)
            {
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
                vetorTemporario[32] = ' ';
                vetorTemporario[33] = ' ';
                vetorTemporario[34] = ' ';
                vetorTemporario[35] = ' ';
                vetorTemporario[36] = ' ';
                vetorTemporario[37] = ' ';
                vetorTemporario[38] = ' ';
                vetorTemporario[39] = ' ';
                vetorTemporario[40] = ' ';
                vetorTemporario[41] = ' ';
                vetorTemporario[42] = ';';
            }



            foreach (char letra in vetorTemporario)
            {
                if (arquivoDisplay == 1)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileA01.txt");
                    salvar.Write(vetorTemporario);
                    salvar.Close();
                }
                if (arquivoDisplay == 2)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileA02.txt");
                    salvar.Write(vetorTemporario);
                    salvar.Close();
                }
                if (arquivoDisplay == 3)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileA03.txt");
                    salvar.Write(vetorTemporario);
                    salvar.Close();
                }
                if (arquivoDisplay == 4)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileA04.txt");
                    salvar.Write(vetorTemporario);
                    salvar.Close();
                }

            }

            if (radioButton1.Checked == true)
            {
                Form1.Linha64_ANG01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha64_ANG01. 
                string converter = new string(Form1.Linha64_ANG01); // converte Linha64_ANG01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[64] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha65 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha65.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha65.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (arb2.Checked == true)
            {
                Form1.Linha65_ANG02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha65_ANG02. 
                string converter = new string(Form1.Linha65_ANG02); // converte Linha65_ANG02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[65] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha66 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha66.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha66.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (arb3.Checked == true)
            {
                Form1.Linha66_ANG03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha66_ANG03. 
                string converter = new string(Form1.Linha66_ANG03); // converte Linha66_ANG03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[66] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha67 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha67.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha67.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (arb4.Checked == true)
            {
                Form1.Linha67_ANG04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha67_ANG04. 
                string converter = new string(Form1.Linha67_ANG04); // converte Linha67_ANG04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[67] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha68 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha68.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha68.Close(); //fecha o arquivo depois de salvar.
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

            Form1.completarLinha = 0;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["Button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_ang.Handle);
            label5.Text = Form1.click_selecionar[1].ToString();
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

        private void btn_ok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }

        private void AUXILIAR_ANALOGICA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visualizar1 = 1;

            MENSAGEM_DISPLAY2 mensagem = new MENSAGEM_DISPLAY2();
            mensagem.TopLevel = true;
            mensagem.Visible = true;
            mensagem.StartPosition = FormStartPosition.Manual;
            mensagem.Location = new Point(866, 78);
            repassarMsg = textbox_linha1.Text.ToCharArray();
        }

        private void textbox_linha1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.() ";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString())) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textbox_linha2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.() ";


            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString())) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AUXILIAR_ANALOGICA_Load(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                arquivoDisplay = 1;

                vetorTemporario = Form1.RecebendoconteudoA01.Trim().ToCharArray();

                string converter = new string(vetorTemporario); //Converter de char[] para string
                string pedaco = converter.Substring(0, 25);
                textbox_linha1.Text = pedaco.Trim(); // TrimEnd -- retira os espaços vazios 

                groupBox1.BackgroundImage = Properties.Resources.Aux01;
                Form1.click_selecionar[1] = ANG_1;
                Form1.img = Properties.Resources.ANG_E01;
                tb_comentario.Text = Form1.linha64.Trim();
            }


        }
    }
}
