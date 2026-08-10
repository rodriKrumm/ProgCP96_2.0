using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class SAIDA_SET : Form
    {
        public SAIDA_SET()
        {
            InitializeComponent();
        }

        int SET_01 = 68;
        int SET_02 = 70;
        int SET_03 = 72;
        int SET_04 = 74;
        int SET_05 = 76;
        int SET_06 = 78;
        int SET_07 = 80;
        int SET_08 = 82;

        private void b1_CheckedChanged(object sender, EventArgs e)
        {
            if (b1.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q08;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SET_01;
                Form1.img = Properties.Resources.SET_E01;
                Form1.s01 = SET_01;
                tb_comentario.Text = Form1.linha48.Trim();
            }
        }

        private void b2_CheckedChanged(object sender, EventArgs e)
        {
            if (b2.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q07;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SET_02;
                Form1.img = Properties.Resources.SET_E02;
                Form1.s02 = SET_02;
                tb_comentario.Text = Form1.linha49.Trim();
            }
        }

        private void b3_CheckedChanged(object sender, EventArgs e)
        {
            if (b3.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q06;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SET_03;
                Form1.img = Properties.Resources.SET_E03;
                Form1.s03 = SET_03;
                tb_comentario.Text = Form1.linha50.Trim();
            }
        }

        private void b4_CheckedChanged(object sender, EventArgs e)
        {
            if (b4.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q05;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SET_04;
                Form1.img = Properties.Resources.SET_E04;
                Form1.s04 = SET_04;
                tb_comentario.Text = Form1.linha51.Trim();
            }
        }

        private void b5_CheckedChanged(object sender, EventArgs e)
        {
            if (b5.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q04;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SET_05;
                Form1.img = Properties.Resources.SET_E05;
                Form1.s05 = SET_05;
                tb_comentario.Text = Form1.linha52.Trim();
            }
        }

        private void b6_CheckedChanged(object sender, EventArgs e)
        {
            if (b6.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q03;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SET_06;
                Form1.img = Properties.Resources.SET_E06;
                Form1.s06 = SET_06;
                tb_comentario.Text = Form1.linha53.Trim();
            }
        }

        private void b7_CheckedChanged(object sender, EventArgs e)
        {
            if (b7.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q02;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SET_07;
                Form1.img = Properties.Resources.SET_E07;
                Form1.s07 = SET_07;
                tb_comentario.Text = Form1.linha54.Trim();
            }
        }

        private void b8_CheckedChanged(object sender, EventArgs e)
        {
            if (b8.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q01;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SET_08;
                Form1.img = Properties.Resources.SET_E08;
                Form1.s08 = SET_08;
                tb_comentario.Text = Form1.linha55.Trim();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (b1.Checked == true)
            {
                Form1.Linha48_SET01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha48_SET01. 
                string converter = new string(Form1.Linha48_SET01); // converte Linha48_SET01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[48] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha49 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha49.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha49.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (b2.Checked == true)
            {
                Form1.Linha49_SET02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha49_SET02. 
                string converter = new string(Form1.Linha49_SET02); // converte Linha49_SET02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[49] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha50 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha50.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha50.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (b3.Checked == true)
            {
                Form1.Linha50_SET03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha50_SET03. 
                string converter = new string(Form1.Linha50_SET03); // converte Linha50_SET03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[50] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha51 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha51.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha51.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (b4.Checked == true)
            {
                Form1.Linha51_SET04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha51_SET04. 
                string converter = new string(Form1.Linha51_SET04); // converte Linha51_SET04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[51] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha52 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha52.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha52.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (b5.Checked == true)
            {
                Form1.Linha52_SET05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha52_SET05. 
                string converter = new string(Form1.Linha52_SET05); // converte Linha52_SET05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[52] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha53 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha53.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha53.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (b6.Checked == true)
            {
                Form1.Linha53_SET06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha53_SET06. 
                string converter = new string(Form1.Linha53_SET06); // converte Linha53_SET06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[53] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha54 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha54.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha54.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (b7.Checked == true)
            {
                Form1.Linha54_SET07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha54_SET07. 
                string converter = new string(Form1.Linha54_SET07); // converte Linha54_SET07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[54] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha55 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha55.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha55.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (b8.Checked == true)
            {
                Form1.Linha55_SET08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha55_SET08. 
                string converter = new string(Form1.Linha55_SET08); // converte Linha55_SET08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[55] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha56 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha56.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha56.Close(); //fecha o arquivo depois de salvar.
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
            Form1.completarLinha = 4;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_set.Handle);
            Close();
        }

        private void SAIDA_SET_Load(object sender, EventArgs e)
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

        private void SAIDA_SET_Shown(object sender, EventArgs e)
        {
            b1.Checked = true;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;
            b5.Checked = false;
            b6.Checked = false;
            b7.Checked = false;
            b8.Checked = false;
            //tb_comentario.Clear();
        }

        private void SAIDA_SET_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
