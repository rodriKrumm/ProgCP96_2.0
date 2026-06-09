using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class Habilitar_Funcoes : Form
    {
        int arquivoBit;

        public static char[] vetorSemVisualizar = new char[32];

        public static char[] visualizarTextbox;

        public static int visualizar_clicado;

        public static char[] passarMsg = new char[25];
        public static char[] vetortemporario;

        public static string receberMsg2;
        public static char[] vetorvazio2 = new char[32];
        public static char[] vetorMensagem2;

        public char rb_marcado; // verifica qual RadioButton está selecionado para salvar o ultimo valor do arquivo;

        int bit1 = 38;
        int bit2 = 39;

        public Habilitar_Funcoes()
        {
            InitializeComponent();
        }

        private void Habilitar_Funcoes_Load(object sender, EventArgs e)
        {

        }

        private void rb_bit1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_bit1.Checked == true)
            {
                Form1.click_selecionar[1] = bit1;
                tb_comentario.Text = Form1.linha102.Trim();
                arquivoBit = 1;
                rb_teclas.Text = "Tecla F1";

                rb_teclas.Enabled = true;

                rb_setup.Enabled = true;
                rb_teclas.Checked = true;

                checkBox1.Enabled = true;
                checkBox2.Enabled = true;

                char[] Bit1 = Form1.RecebendoconteudoADJ00.ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo


                for (int x = 0; x < Bit1.Length; x++)
                {
                    vetorSemVisualizar[0] = Bit1[0];
                    vetorSemVisualizar[1] = Bit1[1];
                    vetorSemVisualizar[2] = Bit1[2];
                    vetorSemVisualizar[3] = Bit1[3];
                    vetorSemVisualizar[4] = Bit1[4];
                    vetorSemVisualizar[5] = Bit1[5];
                    vetorSemVisualizar[6] = Bit1[6];
                    vetorSemVisualizar[7] = Bit1[7];
                    vetorSemVisualizar[8] = Bit1[8];
                    vetorSemVisualizar[9] = Bit1[9];
                    vetorSemVisualizar[10] = Bit1[10];
                    vetorSemVisualizar[11] = Bit1[11];
                    vetorSemVisualizar[12] = Bit1[12];
                    vetorSemVisualizar[13] = Bit1[13];
                    vetorSemVisualizar[14] = Bit1[14];
                    vetorSemVisualizar[15] = Bit1[15];
                    vetorSemVisualizar[16] = Bit1[16];
                    vetorSemVisualizar[17] = Bit1[17];
                    vetorSemVisualizar[18] = Bit1[18];
                    vetorSemVisualizar[19] = Bit1[19];
                    vetorSemVisualizar[20] = Bit1[20];
                    vetorSemVisualizar[21] = Bit1[21];
                    vetorSemVisualizar[22] = Bit1[22];
                    vetorSemVisualizar[23] = Bit1[23];
                    vetorSemVisualizar[24] = Bit1[24];
                }
                string existe4 = new string(vetorSemVisualizar);
                txb_mensagem.Text = existe4;

                passarMsg = txb_mensagem.Text.ToCharArray();

                vetortemporario = Form1.RecebendoconteudoADJ00.ToCharArray();
                vetorSemVisualizar = txb_mensagem.Text.ToCharArray();
            }
        }

        private void rb_bit2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_bit2.Checked == true)
            {
                Form1.click_selecionar[1] = bit2;
                Form1.img = Properties.Resources.HAB_F2;
                arquivoBit = 2;
                rb_teclas.Text = "Tecla F2";
                rb_teclas.Enabled = true;
                rb_setup.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                tb_comentario.Text = Form1.linha103.Trim();
                char[] Bit2 = Form1.RecebendoconteudoADJ01.ToCharArray(); // vetor que pega os valores da escala de fabrica no arquivo

                // pegando os valores de fabrica e passando para int e depois repassando o valor para a posicao da barra de escala
                for (int x = 0; x < Bit2.Length; x++)
                {
                    vetorSemVisualizar[0] = Bit2[0];
                    vetorSemVisualizar[1] = Bit2[1];
                    vetorSemVisualizar[2] = Bit2[2];
                    vetorSemVisualizar[3] = Bit2[3];
                    vetorSemVisualizar[4] = Bit2[4];
                    vetorSemVisualizar[5] = Bit2[5];
                    vetorSemVisualizar[6] = Bit2[6];
                    vetorSemVisualizar[7] = Bit2[7];
                    vetorSemVisualizar[8] = Bit2[8];
                    vetorSemVisualizar[9] = Bit2[9];
                    vetorSemVisualizar[10] = Bit2[10];
                    vetorSemVisualizar[11] = Bit2[11];
                    vetorSemVisualizar[12] = Bit2[12];
                    vetorSemVisualizar[13] = Bit2[13];
                    vetorSemVisualizar[14] = Bit2[14];
                    vetorSemVisualizar[15] = Bit2[15];
                    vetorSemVisualizar[16] = Bit2[16];
                    vetorSemVisualizar[17] = Bit2[17];
                    vetorSemVisualizar[18] = Bit2[18];
                    vetorSemVisualizar[19] = Bit2[19];
                    vetorSemVisualizar[20] = Bit2[20];
                    vetorSemVisualizar[21] = Bit2[21];
                    vetorSemVisualizar[22] = Bit2[22];
                    vetorSemVisualizar[23] = Bit2[23];
                    vetorSemVisualizar[24] = Bit2[24];
                }
                string existe4 = new string(vetorSemVisualizar);
                txb_mensagem.Text = existe4;

                passarMsg = txb_mensagem.Text.ToCharArray();

                vetortemporario = Form1.RecebendoconteudoADJ00.ToCharArray();
                vetorSemVisualizar = txb_mensagem.Text.ToCharArray();
            }
        }

        private void Habilitar_Funcoes_Shown(object sender, EventArgs e)
        {
            rb_bit1.Checked = false;
            rb_bit2.Checked = false;
            rb_teclas.Enabled = false;
            rb_nivel1.Enabled = false;
            rb_setup.Enabled = false;
            rb_nivel2.Enabled = false;

            rb_setup.Enabled = false;
            groupBox4.Enabled = false;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;

            tb_comentario.Clear();
        }

        private void rb_teclas_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_teclas.Checked == true)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                rb_setup.Enabled = false;
                rb_setup.Checked = false;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                if (rb_teclas.Text == "Tecla F1")
                {
                    Form1.img = Properties.Resources.HAB_F1;
                }
                if (rb_teclas.Text == "Tecla F2")
                {
                    Form1.img = Properties.Resources.HAB_F2;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                rb_marcado = '1';// tecla retenção
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                rb_marcado = '2'; // tecla  toggle
                checkBox1.Checked = false;
            }
        }

        private void rb_setup_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_setup.Checked == true)
            {
                rb_nivel1.Enabled = true;
                rb_nivel2.Enabled = true;
                rb_teclas.Enabled = false;
                groupBox4.Enabled = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
            {
                rb_nivel1.Enabled = false;
                rb_nivel2.Enabled = false;
                rb_teclas.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visor_HabilitarFuncao habilitar = new Visor_HabilitarFuncao();
            habilitar.TopLevel = true;
            habilitar.Visible = true;
            habilitar.StartPosition = FormStartPosition.Manual;
            habilitar.Location = new Point(866, 78);

            visualizarTextbox = txb_mensagem.Text.ToCharArray();

            visualizar_clicado = 1;
            passarMsg = txb_mensagem.Text.ToCharArray();
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
                vetortemporario[0] = Visor_HabilitarFuncao.vetorvazio[0];
                vetortemporario[1] = Visor_HabilitarFuncao.vetorvazio[1];
                vetortemporario[2] = Visor_HabilitarFuncao.vetorvazio[2];
                vetortemporario[3] = Visor_HabilitarFuncao.vetorvazio[3];
                vetortemporario[4] = Visor_HabilitarFuncao.vetorvazio[4];
                vetortemporario[5] = Visor_HabilitarFuncao.vetorvazio[5];
                vetortemporario[6] = Visor_HabilitarFuncao.vetorvazio[6];
                vetortemporario[7] = Visor_HabilitarFuncao.vetorvazio[7];
                vetortemporario[8] = Visor_HabilitarFuncao.vetorvazio[8];
                vetortemporario[9] = Visor_HabilitarFuncao.vetorvazio[9];
                vetortemporario[10] = Visor_HabilitarFuncao.vetorvazio[10];
                vetortemporario[11] = Visor_HabilitarFuncao.vetorvazio[11];
                vetortemporario[12] = Visor_HabilitarFuncao.vetorvazio[12];
                vetortemporario[13] = Visor_HabilitarFuncao.vetorvazio[13];
                vetortemporario[14] = Visor_HabilitarFuncao.vetorvazio[14];
                vetortemporario[15] = Visor_HabilitarFuncao.vetorvazio[15];
                vetortemporario[16] = Visor_HabilitarFuncao.vetorvazio[16];
                vetortemporario[17] = Visor_HabilitarFuncao.vetorvazio[17];
                vetortemporario[18] = Visor_HabilitarFuncao.vetorvazio[18];
                vetortemporario[19] = Visor_HabilitarFuncao.vetorvazio[19];
                vetortemporario[20] = Visor_HabilitarFuncao.vetorvazio[20];
                vetortemporario[21] = Visor_HabilitarFuncao.vetorvazio[21];
                vetortemporario[22] = Visor_HabilitarFuncao.vetorvazio[22];
                vetortemporario[23] = Visor_HabilitarFuncao.vetorvazio[23];
                vetortemporario[24] = Visor_HabilitarFuncao.vetorvazio[24];
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
                if (arquivoBit == 1)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileB01.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
                if (arquivoBit == 2)
                {
                    StreamWriter salvar = new StreamWriter(Form1.caminhoarq + @"\FileB02.txt");
                    salvar.Write(vetortemporario);
                    salvar.Close();
                }
            }
            if (rb_bit1.Checked == true)
            {
                Form1.linha102_BIT1 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor linha102_BIT1. 
                string converter = new string(Form1.linha102_BIT1); // converte linha102_BIT1 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[102] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha103 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha103.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha103.Close(); //fecha o arquivo depois de salvar.
                }

            }

            if (rb_bit2.Checked == true)
            {               
                Form1.linha103_BIT2 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor linha103_BIT2. 
                string converter = new string(Form1.linha103_BIT2); // converte linha103_BIT2 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[103] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha104 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha104.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha104.Close(); //fecha o arquivo depois de salvar.
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
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Cursor = new Cursor(Handle);
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_bit.Handle);
            Close();
        }

        private void rb_nivel1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nivel1.Checked == true)
            {
                rb_marcado = '5';
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void rb_nivel2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nivel2.Checked == true)
            {
                rb_marcado = '6';
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void rb_nivel1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rb_nivel1.Checked == true)
            {
                rb_marcado = '3';
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void rb_nivel2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rb_nivel2.Checked == true)
            {
                rb_marcado = '4';
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form1.click_selecionar[1] = 0;
            Form1.img = Properties.Resources.linhas_gridview;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;

            Close();
        }

        private void rb_bit1_Click(object sender, EventArgs e)
        {
            if (arquivoBit == 1)
            {
                rb_teclas.Enabled = true;
                rb_setup.Checked = false;
                rb_nivel1.Enabled = false;
                rb_nivel2.Enabled = false;
                groupBox4.Enabled = false;
                checkBox1.Checked = true;

            }

        }

        private void rb_bit2_Click(object sender, EventArgs e)
        {
            if (arquivoBit == 2)
            {
                rb_teclas.Enabled = true;
                rb_setup.Checked = false;
                rb_nivel1.Enabled = false;
                rb_nivel2.Enabled = false;
                groupBox4.Enabled = false;
                checkBox1.Checked = true;

            }
        }
    }
}
