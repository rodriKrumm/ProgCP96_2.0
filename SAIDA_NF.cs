using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class SAIDA_NF : Form
    {
        public SAIDA_NF()
        {
            InitializeComponent();
        }
        int SNF_01 = 53;
        int SNF_02 = 55;
        int SNF_03 = 57;
        int SNF_04 = 59;
        int SNF_05 = 61;
        int SNF_06 = 63;
        int SNF_07 = 65;
        int SNF_08 = 67;

        private void radbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn1.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q08;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNF_01;
                Form1.img = Properties.Resources.SNF_E01;
                Form1.s01 = SNF_01;
                tb_comentario.Text = Form1.linha40.Trim();
            }
        }

        private void radbtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn2.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q07;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNF_02;
                Form1.img = Properties.Resources.SNF_E02;
                Form1.s02 = SNF_02;
                tb_comentario.Text = Form1.linha41.Trim();
            }
        }

        private void radbtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn3.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q06;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNF_03;
                Form1.img = Properties.Resources.SNF_E03;
                Form1.s03 = SNF_03;
                tb_comentario.Text = Form1.linha42.Trim();
            }
        }

        private void radbtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn4.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q05;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNF_04;
                Form1.img = Properties.Resources.SNF_E04;
                Form1.s04 = SNF_04;
                tb_comentario.Text = Form1.linha43.Trim();
            }
        }

        private void radbtn5_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn5.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q04;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNF_05;
                Form1.img = Properties.Resources.SNF_E05;
                Form1.s05 = SNF_05;
                tb_comentario.Text = Form1.linha44.Trim();
            }
        }

        private void radbtn6_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn6.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q03;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNF_06;
                Form1.img = Properties.Resources.SNF_E06;
                Form1.s06 = SNF_06;
                tb_comentario.Text = Form1.linha45.Trim();
            }
        }

        private void radbtn7_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn7.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q02;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNF_07;
                Form1.img = Properties.Resources.SNF_E07;
                Form1.s07 = SNF_07;
                tb_comentario.Text = Form1.linha46.Trim();
            }
        }

        private void radbtn8_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn8.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q01;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNF_08;
                Form1.img = Properties.Resources.SNF_E08;
                Form1.s08 = SNF_08;
                tb_comentario.Text = Form1.linha47.Trim();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (radbtn1.Checked == true)
            {
                Form1.Linha40_SNF01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha40_SNF01. 
                string converter = new string(Form1.Linha40_SNF01); // converte Linha40_SNF01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[40] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha41 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha41.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha41.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radbtn2.Checked == true)
            {
                Form1.Linha41_SNF02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha41_SNF02. 
                string converter = new string(Form1.Linha41_SNF02); // converte Linha41_SNF02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[41] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha42 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha42.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha42.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radbtn3.Checked == true)
            {
                Form1.Linha42_SNF03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha42_SNF03. 
                string converter = new string(Form1.Linha42_SNF03); // converte Linha42_SNF03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[42] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha43 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha43.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha43.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radbtn4.Checked == true)
            {
                Form1.Linha43_SNF04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha43_SNF04. 
                string converter = new string(Form1.Linha43_SNF04); // converte Linha43_SNF04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[43] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha44 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha44.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha44.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radbtn5.Checked == true)
            {
                Form1.Linha44_SNF05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha44_SNF05. 
                string converter = new string(Form1.Linha44_SNF05); // converte Linha44_SNF05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[44] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha45 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha45.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha45.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radbtn6.Checked == true)
            {
                Form1.Linha45_SNF06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha45_SNF06. 
                string converter = new string(Form1.Linha45_SNF06); // converte Linha45_SNF06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[45] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha46 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha46.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha46.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radbtn7.Checked == true)
            {
                Form1.Linha46_SNF07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha46_SNF07. 
                string converter = new string(Form1.Linha46_SNF07); // converte Linha46_SNF07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[46] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha47 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha47.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha47.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radbtn8.Checked == true)
            {
                Form1.Linha47_SNF08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha47_SNF08. 
                string converter = new string(Form1.Linha47_SNF08); // converte Linha47_SNF08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[47] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha48 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha48.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha48.Close(); //fecha o arquivo depois de salvar.
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
            Form1.completarLinha = 2;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            label10.Text = Form1.click_selecionar[1].ToString();
            Cursor = new Cursor(Handle);
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_snf.Handle);
            Close();
            Close();
        }

        private void SAIDA_NF_Load(object sender, EventArgs e)
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

        private void SAIDA_NF_Shown(object sender, EventArgs e)
        {
            radbtn1.Checked = true;
            radbtn2.Checked = false;
            radbtn3.Checked = false;
            radbtn4.Checked = false;
            radbtn5.Checked = false;
            radbtn6.Checked = false;
            radbtn7.Checked = false;
            radbtn8.Checked = false;
            //tb_comentario.Clear();
        }

        private void SAIDA_NF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }
    }
}
