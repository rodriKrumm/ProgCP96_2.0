using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class BORDA_SUBIDA : Form
    {
        public BORDA_SUBIDA()
        {
            InitializeComponent();
        }

        int BP_01 = 20;
        int BP_02 = 22;
        int BP_03 = 24;
        int BP_04 = 26;
        int BP_05 = 28;
        int BP_06 = 30;
        int BP_07 = 32;
        int BP_08 = 34;

        private void BORDA_SUBIDA_Load(object sender, EventArgs e)
        {

        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            if (r1.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I01;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BP_01;
                Form1.img = Properties.Resources.BP_E01;
                tb_comentario.Text = Form1.linha24.Trim();

            }
        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {
            if (r2.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I02;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BP_02;
                Form1.img = Properties.Resources.BP_E02;
                tb_comentario.Text = Form1.linha25.Trim();
            }
        }

        private void r3_CheckedChanged(object sender, EventArgs e)
        {
            if (r3.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I03;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BP_03;
                Form1.img = Properties.Resources.BP_E03;
                tb_comentario.Text = Form1.linha26.Trim();
            }
        }

        private void r4_CheckedChanged(object sender, EventArgs e)
        {
            if (r4.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I04;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BP_04;
                Form1.img = Properties.Resources.BP_E04;
                tb_comentario.Text = Form1.linha27.Trim();
            }
        }

        private void r5_CheckedChanged(object sender, EventArgs e)
        {
            if (r5.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I05;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BP_05;
                Form1.img = Properties.Resources.BP_E05;
                tb_comentario.Text = Form1.linha28.Trim();
            }
        }

        private void r6_CheckedChanged(object sender, EventArgs e)
        {
            if (r6.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I06;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BP_06;
                Form1.img = Properties.Resources.BP_E06;
                tb_comentario.Text = Form1.linha29.Trim();
            }
        }

        private void r7_CheckedChanged(object sender, EventArgs e)
        {
            if (r7.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I07;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BP_07;
                Form1.img = Properties.Resources.BP_E07;
                tb_comentario.Text = Form1.linha30.Trim();
            }
        }

        private void r8_CheckedChanged(object sender, EventArgs e)
        {
            if (r8.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I08;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = BP_08;
                Form1.img = Properties.Resources.BP_E08;
                tb_comentario.Text = Form1.linha18.Trim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (r1.Checked == true)
            {
                Form1.Linha24_EBP01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha24_EBP01. 
                string converter = new string(Form1.Linha24_EBP01); // converte Linha24_EBP01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[24] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha25 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha25.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha25.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (r2.Checked == true)
            {
                Form1.Linha25_EBP02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha25_EBP02. 
                string converter = new string(Form1.Linha25_EBP02); // converte Linha25_EBP02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[25] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha26 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha26.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha26.Close(); //fecha o arquivo depois de salvar.
                }
              
            }

            if (r3.Checked == true)
            {
                Form1.Linha26_EBP03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha26_EBP03. 
                string converter = new string(Form1.Linha26_EBP03); // converte Linha26_EBP03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[26] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha27 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha27.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha27.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (r4.Checked == true)
            {
                Form1.Linha27_EBP04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha27_EBP04. 
                string converter = new string(Form1.Linha27_EBP04); // converte Linha27_EBP04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[27] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha28 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha28.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha28.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (r5.Checked == true)
            {
                Form1.Linha28_EBP05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha28_EBP05. 
                string converter = new string(Form1.Linha28_EBP05); // converte Linha28_EBP05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[28] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha29 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha29.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha29.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (r6.Checked == true)
            {
                Form1.Linha29_EBP06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha29_EBP06. 
                string converter = new string(Form1.Linha29_EBP06); // converte Linha29_EBP06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[29] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha30 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha30.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha30.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (r7.Checked == true)
            {
                Form1.Linha30_EBP07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha30_EBP07. 
                string converter = new string(Form1.Linha30_EBP07); // converte Linha30_EBP07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[30] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha31 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha31.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha31.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (r8.Checked == true)
            {
                Form1.Linha31_EBP08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha31_EBP08. 
                string converter = new string(Form1.Linha31_EBP08); // converte Linha31_EBP08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[31] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha32 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha32.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha32.Close(); //fecha o arquivo depois de salvar.
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
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle);
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

        private void BORDA_SUBIDA_Shown(object sender, EventArgs e)
        {
            r1.Checked = true;
            r2.Checked = false;
            r3.Checked = false;
            r4.Checked = false;
            r5.Checked = false;
            r6.Checked = false;
            r7.Checked = false;
            r8.Checked = false;
            //tb_comentario.Clear();
        }

        private void BORDA_SUBIDA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }
    }
}
