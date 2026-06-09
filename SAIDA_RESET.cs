using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class SAIDA_RESET : Form
    {
        public SAIDA_RESET()
        {
            InitializeComponent();
        }

        int RES_01 = 69;
        int RES_02 = 71;
        int RES_03 = 73;
        int RES_04 = 75;
        int RES_05 = 77;
        int RES_06 = 79;
        int RES_07 = 81;
        int RES_08 = 83;

        private void reb1_CheckedChanged(object sender, EventArgs e)
        {
            if (reb1.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q08;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = RES_01;
                Form1.img = Properties.Resources.RES_E01;
                Form1.s01 = RES_01;
                tb_comentario.Text = Form1.linha56.Trim();
            }
        }

        private void reb2_CheckedChanged(object sender, EventArgs e)
        {
            if (reb2.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q07;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = RES_02;
                Form1.img = Properties.Resources.RES_E02;
                Form1.s02 = RES_02;
                tb_comentario.Text = Form1.linha57.Trim();
            }
        }

        private void reb3_CheckedChanged(object sender, EventArgs e)
        {
            if (reb3.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q06;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = RES_03;
                Form1.img = Properties.Resources.RES_E03;
                Form1.s03 = RES_03;
                tb_comentario.Text = Form1.linha58.Trim();
            }
        }

        private void reb4_CheckedChanged(object sender, EventArgs e)
        {
            if (reb4.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q05;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = RES_04;
                Form1.img = Properties.Resources.RES_E04;
                Form1.s04 = RES_04;
                tb_comentario.Text = Form1.linha59.Trim();
            }
        }

        private void reb5_CheckedChanged(object sender, EventArgs e)
        {
            if (reb5.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q04;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = RES_05;
                Form1.img = Properties.Resources.RES_E05;
                Form1.s05 = RES_05;
                tb_comentario.Text = Form1.linha60.Trim();
            }
        }

        private void reb6_CheckedChanged(object sender, EventArgs e)
        {
            if (reb6.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q03;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = RES_06;
                Form1.img = Properties.Resources.RES_E06;
                Form1.s06 = RES_06;
                tb_comentario.Text = Form1.linha61.Trim();
            }
        }

        private void reb7_CheckedChanged(object sender, EventArgs e)
        {
            if (reb7.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q02;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = RES_07;
                Form1.img = Properties.Resources.RES_E07;
                Form1.s07 = RES_07;
                tb_comentario.Text = Form1.linha62.Trim();
            }
        }

        private void reb8_CheckedChanged(object sender, EventArgs e)
        {
            if (reb8.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q01;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = RES_08;
                Form1.img = Properties.Resources.RES_E08;
                Form1.s08 = RES_08;
                tb_comentario.Text = Form1.linha63.Trim();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (reb1.Checked == true)
            {
                Form1.Linha56_RES01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha56_RES01. 
                string converter = new string(Form1.Linha56_RES01); // converte Linha56_RES01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[56] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha57 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha57.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha57.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (reb2.Checked == true)
            {
                Form1.Linha57_RES02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha57_RES02. 
                string converter = new string(Form1.Linha57_RES02); // converte Linha57_RES02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[57] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha58 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha58.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha58.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (reb3.Checked == true)
            {
                Form1.Linha58_RES03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha58_RES03. 
                string converter = new string(Form1.Linha58_RES03); // converte Linha58_RES03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[58] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha59 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha59.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha59.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (reb4.Checked == true)
            {
                Form1.Linha59_RES04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha59_RES04. 
                string converter = new string(Form1.Linha59_RES04); // converte Linha59_RES04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[59] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha60 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha60.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha60.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (reb5.Checked == true)
            {
                Form1.Linha60_RES05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha60_RES05. 
                string converter = new string(Form1.Linha60_RES05); // converte Linha60_RES05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[60] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha61 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha61.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha61.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (reb6.Checked == true)
            {
                Form1.Linha61_RES06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha61_RES06. 
                string converter = new string(Form1.Linha61_RES06); // converte Linha61_RES06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[61] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha62 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha62.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha62.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (reb7.Checked == true)
            {
                Form1.Linha62_RES07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha62_RES07. 
                string converter = new string(Form1.Linha62_RES07); // converte Linha62_RES07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[62] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha63 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha63.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha63.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (reb8.Checked == true)
            {
                Form1.Linha63_RES08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha63_RES08. 
                string converter = new string(Form1.Linha63_RES08); // converte Linha63_RES08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[63] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha64 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha64.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha64.Close(); //fecha o arquivo depois de salvar.
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

            Form1.saidaOuDisplay = 1;
            Form1.completarLinha = 3;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_res.Handle);
            Close();
        }

        private void SAIDA_RESET_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form1.click_selecionar[1] = 0;
            Form1.img = Properties.Resources.linhas_gridview;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;

            Close();
        }

        private void SAIDA_RESET_Shown(object sender, EventArgs e)
        {
            reb1.Checked = true;
            reb2.Checked = false;
            reb3.Checked = false;
            reb4.Checked = false;
            reb5.Checked = false;
            reb6.Checked = false;
            reb7.Checked = false;
            reb8.Checked = false;
            //tb_comentario.Clear();
        }

        private void SAIDA_RESET_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }
    }
}
