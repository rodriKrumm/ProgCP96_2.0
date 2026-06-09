using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class BORDA_DESCIDA : Form
    {

        public BORDA_DESCIDA()
        {
            InitializeComponent();
        }

        int BN_01 = 21;
        int BN_02 = 23;
        int BN_03 = 25;
        int BN_04 = 27;
        int BN_05 = 29;
        int BN_06 = 31;
        int BN_07 = 33;
        int BN_08 = 35;

        string caminho = Form1.caminhoarq;

        private void BORDA_DESCIDA_Load(object sender, EventArgs e)
        {

        }

        private void radb1_CheckedChanged(object sender, EventArgs e)
        {
            if (radb1.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I01;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BN_01;
                Form1.img = Properties.Resources.BN_E01;
                tb_comentario.Text = Form1.linha16.Trim();
            }
        }

        private void radb2_CheckedChanged(object sender, EventArgs e)
        {
            if (radb2.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I02;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BN_02;
                Form1.img = Properties.Resources.BN_E02;
                tb_comentario.Text = Form1.linha17.Trim();
            }
        }

        private void radb3_CheckedChanged(object sender, EventArgs e)
        {
            if (radb3.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I03;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BN_03;
                Form1.img = Properties.Resources.BN_E03;
                tb_comentario.Text = Form1.linha18.Trim();
            }
        }

        private void radb4_CheckedChanged(object sender, EventArgs e)
        {
            if (radb4.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I04;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BN_04;
                Form1.img = Properties.Resources.BN_E04;
                tb_comentario.Text = Form1.linha19.Trim();
            }
        }

        private void radb5_CheckedChanged(object sender, EventArgs e)
        {
            if (radb5.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I05;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BN_05;
                Form1.img = Properties.Resources.BN_E05;
                tb_comentario.Text = Form1.linha20.Trim();
            }
        }

        private void radb6_CheckedChanged(object sender, EventArgs e)
        {
            if (radb6.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I06;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BN_06;
                Form1.img = Properties.Resources.BN_E06;
                tb_comentario.Text = Form1.linha21.Trim();
            }
        }

        private void radb7_CheckedChanged(object sender, EventArgs e)
        {
            if (radb7.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I07;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BN_07;
                Form1.img = Properties.Resources.BN_E07;
                tb_comentario.Text = Form1.linha22.Trim();
            }
        }

        private void radb8_CheckedChanged(object sender, EventArgs e)
        {
            if (radb8.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I08;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BN_08;
                Form1.img = Properties.Resources.BN_E08;
                tb_comentario.Text = Form1.linha23.Trim();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (radb1.Checked == true)
            {
                Form1.Linha16_EBN01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha16_EBN01. 
                string converter = new string(Form1.Linha16_EBN01); // converte Linha16_EBN01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[16] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha17 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha17.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha17.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radb2.Checked == true)
            {
                Form1.Linha17_EBN02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha17_EBN02. 
                string converter = new string(Form1.Linha17_EBN02); // converte Linha17_EBN02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[17] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha18 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha18.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha18.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radb3.Checked == true)
            {
                Form1.Linha18_EBN03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha18_EBN03. 
                string converter = new string(Form1.Linha18_EBN03); // converte Linha18_EBN03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[18] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha19 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha19.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha19.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radb4.Checked == true)
            {
                Form1.Linha19_EBN04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha19_EBN04. 
                string converter = new string(Form1.Linha19_EBN04); // converte Linha19_EBN04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[19] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha20 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha20.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha20.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radb5.Checked == true)
            {
                Form1.Linha20_EBN05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha20_EBN05. 
                string converter = new string(Form1.Linha20_EBN05); // converte Linha20_EBN05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[20] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha21 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha21.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha21.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radb6.Checked == true)
            {
                Form1.Linha21_EBN06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha21_EBN06. 
                string converter = new string(Form1.Linha21_EBN06); // converte Linha21_EBN06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[21] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha22 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha22.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha22.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radb7.Checked == true)
            {
                Form1.Linha22_EBN07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha22_EBN07. 
                string converter = new string(Form1.Linha22_EBN07); // converte Linha22_EBN07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[22] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha23 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha23.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha23.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radb8.Checked == true)
            {
                Form1.Linha23_EBN08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha23_EBN08. 
                string converter = new string(Form1.Linha23_EBN08); // converte Linha23_EBN08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[23] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha24 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha24.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha24.Close(); //fecha o arquivo depois de salvar.
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
            ((Button)form.Controls["Button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle);
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

        private void BORDA_DESCIDA_Shown(object sender, EventArgs e)
        {
            radb1.Checked = true;
            radb2.Checked = false;
            radb3.Checked = false;
            radb4.Checked = false;
            radb5.Checked = false;
            radb6.Checked = false;
            radb7.Checked = false;
            radb8.Checked = false;
            //tb_comentario.Clear();
        }

        private void BORDA_DESCIDA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }
    }
}
