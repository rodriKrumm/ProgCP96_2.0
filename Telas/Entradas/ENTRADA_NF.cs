using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class ENTRADA_NF : Form
    {
        public static int NF_01 = 5;
        public static int NF_02 = 7;
        public static int NF_03 = 9;
        public static int NF_04 = 11;
        public static int NF_05 = 13;
        public static int NF_06 = 15;
        public static int NF_07 = 17;
        public static int NF_08 = 19;

        public ENTRADA_NF()
        {
            InitializeComponent();
        }

        private void ENTRADA_NF_Load(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I01;

                Form1.click_selecionar[1] = NF_01;
                Form1.img = Properties.Resources.ENF_E01;
                tb_comentario.Text = Form1.linha8.Trim();
            }
        }
        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I02;
                Form1.click_selecionar[1] = NF_02;
                Form1.img = Properties.Resources.ENF_E02;
                tb_comentario.Text = Form1.linha9.Trim();
            }
        }
        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I03;
                Form1.click_selecionar[1] = NF_03;
                Form1.img = Properties.Resources.ENF_E03;
                tb_comentario.Text = Form1.linha10.Trim();
            }
        }
        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I04;
                Form1.click_selecionar[1] = NF_04;
                Form1.img = Properties.Resources.ENF_E041;
                tb_comentario.Text =Form1.linha11.Trim();
               
            }
        }
        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb5.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I05;
                Form1.click_selecionar[1] = NF_05;
                Form1.img = Properties.Resources.ENF_E05;
                tb_comentario.Text = Form1.linha12.Trim();
            }
        }
        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            if (rb6.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I06;
                Form1.click_selecionar[1] = NF_06;
                Form1.img = Properties.Resources.ENF_E06;
                tb_comentario.Text = Form1.linha13.Trim();
            }
        }
        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            if (rb7.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I07;
                Form1.click_selecionar[1] = NF_07;
                Form1.img = Properties.Resources.ENF_E07;
                tb_comentario.Text = Form1.linha14.Trim();
            }
        }
        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            if (rb8.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I08;
                Form1.click_selecionar[1] = NF_08;
                Form1.img = Properties.Resources.ENF_E08;
                tb_comentario.Text = Form1.linha15.Trim();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {

                Form1.Linha8_ENF01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha8_ENF01. 
                string converter = new string(Form1.Linha8_ENF01); // converte Linha8_ENF01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[8] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha9 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha9.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha9.Close(); //fecha o arquivo depois de salvar.
                }
               
            }

            if (rb2.Checked == true)
            {
                Form1.Linha9_ENF02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha9_ENF02. 
                string converter = new string(Form1.Linha9_ENF02); // converte Linha9_ENF02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[9] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha10 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha10.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha10.Close(); //fecha o arquivo depois de salvar.
                   
                }
            }

            if (rb3.Checked == true)
            {
                Form1.Linha10_ENF03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha10_ENF03. 
                string converter = new string(Form1.Linha10_ENF03); // converte Linha10_ENF03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[10] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha11 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha11.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha11.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (rb4.Checked == true)
            {
                Form1.Linha11_ENF04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha11_ENF04. 
                string converter = new string(Form1.Linha11_ENF04); // converte Linha11_ENF04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[11] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha12 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha12.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha12.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (rb5.Checked == true)
            {
                Form1.Linha12_ENF05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha12_ENF05. 
                string converter = new string(Form1.Linha12_ENF05); // converte Linha11_ENF04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[12] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha13 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha13.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha13.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (rb6.Checked == true)
            {
                Form1.Linha13_ENF06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha13_ENF06. 
                string converter = new string(Form1.Linha13_ENF06); // converte Linha13_ENF06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[13] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha14 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha14.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha14.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (rb7.Checked == true)
            {
                Form1.Linha14_ENF07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha14_ENF07. 
                string converter = new string(Form1.Linha14_ENF07); // converte Linha14_ENF07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[14] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha15 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha15.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha15.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (rb8.Checked == true)
            {
                Form1.Linha15_ENF08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha15_ENF08. 
                string converter = new string(Form1.Linha15_ENF08); // converte Linha15_ENF08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[15] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha16 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha16.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha16.Close(); //fecha o arquivo depois de salvar.
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
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Cursor = new Cursor(Handle);
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_enf.Handle);
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form1.click_selecionar[1] = 0;
            Form1.img = Properties.Resources.linhas_gridview;
            Close();
        }

        private void ENTRADA_NF_Shown(object sender, EventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            rb5.Checked = false;
            rb6.Checked = false;
            rb7.Checked = false;
            rb8.Checked = false;

           
        }

        private void ENTRADA_NF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }
    }
}
