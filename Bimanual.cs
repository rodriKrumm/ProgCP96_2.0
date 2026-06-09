using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class Bimanual : Form
    {
        int Bimanual1 = 36;
        // int Bimanual2 = 37;

        int arquivoBim;

        public static char[] vetorSemVisualizar = new char[32];

        public static char[] visualizarTextbox;

        public static int visualizar_clicado;

        public static char[] passarMsg = new char[25];
        public static char[] vetortemporario;

        public static string receberMsg2;
        public static char[] vetorvazio2 = new char[32];
        public static char[] vetorMensagem2;
        public char rb_marcado;
        public Bimanual()
        {
            InitializeComponent();
        }

        private void Bimanual_Shown(object sender, EventArgs e)
        {
            rb_ajusteTempo.Checked = true; // RadioButton do ajuste de tempo fica marcado
            rb_nivel1.Checked = true; // RadioButton nivel 1 fica marcado
            gb_ajusteTempo.Enabled = false; // GroupBox do ajuste de tempo fica desabilitado para mexer
            gb_mensagem.Enabled = false; // GroupBox da mensagem fica desabilitado para mexer
            tb_comentario.Clear();
        }

        private void cb_retencao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_retencao.Checked == true)
            {
                cb_pulsoFixo.Checked = false;
                gb_ajusteTempo.Enabled = true;
                gb_mensagem.Enabled = true;
                Form1.img = Properties.Resources.bimanual_E7_E8;
            }
        }

        private void cb_pulsoFixo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pulsoFixo.Checked == true)
            {
                rb_marcado = '0';
                cb_retencao.Checked = false;
                gb_ajusteTempo.Enabled = false;
                gb_mensagem.Enabled = false;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 32; i++)
            {
                vetorvazio2[i] = ' ';
            }

            passarMsg = txb_mensagem.Text.ToArray();
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

            if (visualizar_clicado == 1) // se foi clicado em visualizar antes de ok
            {
                vetortemporario[0] = Visor_Bimanual.vetorvazio[0];
                vetortemporario[1] = Visor_Bimanual.vetorvazio[1];
                vetortemporario[2] = Visor_Bimanual.vetorvazio[2];
                vetortemporario[3] = Visor_Bimanual.vetorvazio[3];
                vetortemporario[4] = Visor_Bimanual.vetorvazio[4];
                vetortemporario[5] = Visor_Bimanual.vetorvazio[5];
                vetortemporario[6] = Visor_Bimanual.vetorvazio[6];
                vetortemporario[7] = Visor_Bimanual.vetorvazio[7];
                vetortemporario[8] = Visor_Bimanual.vetorvazio[8];
                vetortemporario[9] = Visor_Bimanual.vetorvazio[9];
                vetortemporario[10] = Visor_Bimanual.vetorvazio[10];
                vetortemporario[11] = Visor_Bimanual.vetorvazio[11];
                vetortemporario[12] = Visor_Bimanual.vetorvazio[12];
                vetortemporario[13] = Visor_Bimanual.vetorvazio[13];
                vetortemporario[14] = Visor_Bimanual.vetorvazio[14];
                vetortemporario[15] = Visor_Bimanual.vetorvazio[15];
                vetortemporario[16] = Visor_Bimanual.vetorvazio[16];
                vetortemporario[17] = Visor_Bimanual.vetorvazio[17];
                vetortemporario[18] = Visor_Bimanual.vetorvazio[18];
                vetortemporario[19] = Visor_Bimanual.vetorvazio[19];
                vetortemporario[20] = Visor_Bimanual.vetorvazio[20];
                vetortemporario[21] = Visor_Bimanual.vetorvazio[21];
                vetortemporario[22] = Visor_Bimanual.vetorvazio[22];
                vetortemporario[23] = Visor_Bimanual.vetorvazio[23];
                vetortemporario[24] = Visor_Bimanual.vetorvazio[24];
                vetortemporario[25] = ';';

                vetortemporario[26] = '0';
                vetortemporario[27] = '0';
                vetortemporario[28] = '0';
                vetortemporario[29] = '0';

                vetortemporario[30] = ';';

                vetortemporario[31] = '0';
                vetortemporario[32] = '0';
                vetortemporario[33] = '0';
                vetortemporario[34] = '1';

                vetortemporario[35] = ';';

                vetortemporario[36] = '0';
                vetortemporario[37] = '0';
                vetortemporario[38] = '0';
                vetortemporario[39] = '0';
                vetortemporario[40] = ';';
                vetortemporario[42] = ';';
                vetortemporario[41] = rb_marcado;

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

                vetortemporario[26] = '0';
                vetortemporario[27] = '0';
                vetortemporario[28] = '0';
                vetortemporario[29] = '0';

                vetortemporario[30] = ';';

                vetortemporario[31] = '0';
                vetortemporario[32] = '0';
                vetortemporario[33] = '0';
                vetortemporario[34] = '1';

                vetortemporario[35] = ';';

                vetortemporario[36] = '0';
                vetortemporario[37] = '0';
                vetortemporario[38] = '0';
                vetortemporario[39] = '0';
                vetortemporario[40] = ';';
                vetortemporario[42] = ';';

                vetortemporario[41] = rb_marcado;
            }



            foreach (char letra in vetortemporario)
            {
                if (arquivoBim == 1)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileBM1.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoBim == 2)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileBM2.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
            }

            if (cb_retencao.Checked == true)
            {
                Form1.Linha100_BIM1 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha100_BIM1. 
                string converter = new string(Form1.Linha100_BIM1); // converte Linha100_BIM1 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[100] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha101 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha101.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha101.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (cb_pulsoFixo.Checked == true)
            {
                Form1.Linha101_BIM2 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha101_BIM2. 
                string converter = new string(Form1.Linha101_BIM2); // converte Linha101_BIM2 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[101] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha102 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha102.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha102.Close(); //fecha o arquivo depois de salvar.
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
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_bimanual.Handle);
            Form1.click_selecionar[1] = Bimanual1;
            Form1.saidaOuDisplay = 0;
            Close();

        }

        private void rb_nivel1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nivel1.Checked == true)
            {
                arquivoBim = 1;
                rb_marcado = '1';

                char[] Bim1 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileBM1.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo
                tb_comentario.Text = Form1.linha100.Trim();
                // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                for (int x = 0; x < Bim1.Length; x++)
                {
                    vetorSemVisualizar[0] = Bim1[0];
                    vetorSemVisualizar[1] = Bim1[1];
                    vetorSemVisualizar[2] = Bim1[2];
                    vetorSemVisualizar[3] = Bim1[3];
                    vetorSemVisualizar[4] = Bim1[4];
                    vetorSemVisualizar[5] = Bim1[5];
                    vetorSemVisualizar[6] = Bim1[6];
                    vetorSemVisualizar[7] = Bim1[7];
                    vetorSemVisualizar[8] = Bim1[8];
                    vetorSemVisualizar[9] = Bim1[9];
                    vetorSemVisualizar[10] = Bim1[10];
                    vetorSemVisualizar[11] = Bim1[11];
                    vetorSemVisualizar[12] = Bim1[12];
                    vetorSemVisualizar[13] = Bim1[13];
                    vetorSemVisualizar[14] = Bim1[14];
                    vetorSemVisualizar[15] = Bim1[15];
                    vetorSemVisualizar[16] = Bim1[16];
                    vetorSemVisualizar[17] = Bim1[17];
                    vetorSemVisualizar[18] = Bim1[18];
                    vetorSemVisualizar[19] = Bim1[19];
                    vetorSemVisualizar[20] = Bim1[20];
                    vetorSemVisualizar[21] = Bim1[21];
                    vetorSemVisualizar[22] = Bim1[22];
                    vetorSemVisualizar[23] = Bim1[23];
                    vetorSemVisualizar[24] = Bim1[24];
                }
                string existe4 = new string(vetorSemVisualizar);
                txb_mensagem.Text = existe4;

                passarMsg = txb_mensagem.Text.ToCharArray();

                vetortemporario = Form1.RecebendoconteudoBM1.ToCharArray();
                vetorSemVisualizar = txb_mensagem.Text.ToCharArray();
            }
        }

        private void rb_nivel2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nivel2.Checked == true)
            {
                rb_marcado = '2';
                arquivoBim = 2;
                tb_comentario.Text = Form1.linha101.Trim();
                char[] Bim2 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileBM2.txt").ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

                // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                for (int x = 0; x < Bim2.Length; x++)
                {
                    vetorSemVisualizar[0] = Bim2[0];
                    vetorSemVisualizar[1] = Bim2[1];
                    vetorSemVisualizar[2] = Bim2[2];
                    vetorSemVisualizar[3] = Bim2[3];
                    vetorSemVisualizar[4] = Bim2[4];
                    vetorSemVisualizar[5] = Bim2[5];
                    vetorSemVisualizar[6] = Bim2[6];
                    vetorSemVisualizar[7] = Bim2[7];
                    vetorSemVisualizar[8] = Bim2[8];
                    vetorSemVisualizar[9] = Bim2[9];
                    vetorSemVisualizar[10] = Bim2[10];
                    vetorSemVisualizar[11] = Bim2[11];
                    vetorSemVisualizar[12] = Bim2[12];
                    vetorSemVisualizar[13] = Bim2[13];
                    vetorSemVisualizar[14] = Bim2[14];
                    vetorSemVisualizar[15] = Bim2[15];
                    vetorSemVisualizar[16] = Bim2[16];
                    vetorSemVisualizar[17] = Bim2[17];
                    vetorSemVisualizar[18] = Bim2[18];
                    vetorSemVisualizar[19] = Bim2[19];
                    vetorSemVisualizar[20] = Bim2[20];
                    vetorSemVisualizar[21] = Bim2[21];
                    vetorSemVisualizar[22] = Bim2[22];
                    vetorSemVisualizar[23] = Bim2[23];
                    vetorSemVisualizar[24] = Bim2[24];
                }
                string existe5 = new string(vetorSemVisualizar);
                txb_mensagem.Text = existe5;

                passarMsg = txb_mensagem.Text.ToCharArray();

                vetortemporario = Form1.RecebendoconteudoBM2.ToCharArray();
                vetorSemVisualizar = txb_mensagem.Text.ToCharArray();
            }
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            Visor_Bimanual visorBim = new Visor_Bimanual();
            visorBim.TopLevel = true;
            visorBim.Visible = true;
            visorBim.StartPosition = FormStartPosition.Manual;
            visorBim.Location = new Point(866, 78);

            visualizarTextbox = txb_mensagem.Text.ToCharArray();

            visualizar_clicado = 1;
            passarMsg = txb_mensagem.Text.ToCharArray();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form1.click_selecionar[1] = 0;
            Form1.img = Properties.Resources.linhas_gridview;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;

            Close();
        }

        private void Bimanual_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
