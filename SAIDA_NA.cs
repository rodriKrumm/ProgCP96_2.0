using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class SAIDA_NA : Form
    {
        public SAIDA_NA()
        {
            InitializeComponent();
        }
        int SNA_01 = 52;
        int SNA_02 = 54;
        int SNA_03 = 56;
        int SNA_04 = 58;
        int SNA_05 = 60;
        int SNA_06 = 62;
        int SNA_07 = 64;
        int SNA_08 = 66;

        private void br1_CheckedChanged(object sender, EventArgs e)
        {
            if (br1.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q08;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNA_01;
                Form1.img = Properties.Resources.SNA_E01;
                Form1.img2 = Properties.Resources.ESPECIAL_01;
                Form1.s01 = SNA_01;
                tb_comentario.Text = Form1.linha32.Trim();
            }
        }

        private void br2_CheckedChanged(object sender, EventArgs e)
        {
            if (br2.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q07;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNA_02;
                Form1.img = Properties.Resources.SNA_E02;
                Form1.s02 = SNA_02;
                tb_comentario.Text = Form1.linha33.Trim();
            }
        }

        private void br3_CheckedChanged(object sender, EventArgs e)
        {
            if (br3.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q06;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNA_03;
                Form1.img = Properties.Resources.SNA_E03;
                Form1.s03 = SNA_03;
                tb_comentario.Text = Form1.linha34.Trim();
            }
        }

        private void br4_CheckedChanged(object sender, EventArgs e)
        {
            if (br4.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q05;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNA_04;
                Form1.img = Properties.Resources.SNA_E04;
                Form1.s04 = SNA_04;
                tb_comentario.Text = Form1.linha35.Trim();
            }
        }

        private void br5_CheckedChanged(object sender, EventArgs e)
        {
            if (br5.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q04;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNA_05;
                Form1.img = Properties.Resources.SNA_E05;
                Form1.s05 = SNA_05;
                tb_comentario.Text = Form1.linha36.Trim();
            }
        }

        private void br6_CheckedChanged(object sender, EventArgs e)
        {
            if (br6.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q03;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNA_06;
                Form1.img = Properties.Resources.SNA_E06;
                Form1.s06 = SNA_06;
                tb_comentario.Text = Form1.linha37.Trim();
            }
        }

        private void br7_CheckedChanged(object sender, EventArgs e)
        {
            if (br7.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q02;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNA_07;
                Form1.img = Properties.Resources.SNA_E07;
                Form1.s07 = SNA_07;
                tb_comentario.Text = Form1.linha38.Trim();
            }
        }

        private void br8_CheckedChanged(object sender, EventArgs e)
        {
            if (br8.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.Q01;
                Form1.click_selecionar[0] = 0;
                Form1.click_selecionar[1] = SNA_08;
                Form1.img = Properties.Resources.SNA_E08;
                Form1.s08 = SNA_08;
                tb_comentario.Text = Form1.linha39.Trim();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (br1.Checked == true)
            {
                Form1.Linha32_SNA01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha32_SNA01. 
                string converter = new string(Form1.Linha32_SNA01); // converte Linha32_SNA01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[32] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha33 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha33.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha33.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (br2.Checked == true)
            {
                Form1.Linha33_SNA02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha33_SNA02. 
                string converter = new string(Form1.Linha33_SNA02); // converte Linha33_SNA02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[33] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha34 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha34.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha34.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (br3.Checked == true)
            {
                Form1.Linha34_SNA03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha34_SNA03. 
                string converter = new string(Form1.Linha34_SNA03); // converte Linha34_SNA03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[34] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha35 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha35.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha35.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (br4.Checked == true)
            {
                Form1.Linha35_SNA04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha35_SNA04. 
                string converter = new string(Form1.Linha35_SNA04); // converte Linha35_SNA04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[35] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha36 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha36.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha36.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (br5.Checked == true)
            {
                Form1.Linha36_SNA05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha36_SNA05. 
                string converter = new string(Form1.Linha36_SNA05); // converte Linha36_SNA05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[36] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha37 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha37.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha37.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (br6.Checked == true)
            {
                Form1.Linha37_SNA06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha37_SNA06. 
                string converter = new string(Form1.Linha37_SNA06); // converte Linha37_SNA06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[37] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha38 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha38.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha38.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (br7.Checked == true)
            {
                Form1.Linha38_SNA07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha38_SNA07. 
                string converter = new string(Form1.Linha38_SNA07); // converte Linha38_SNA07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[38] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha39 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha39.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha39.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (br8.Checked == true)
            {
                Form1.Linha39_SNA08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha39_SNA08. 
                string converter = new string(Form1.Linha39_SNA08); // converte Linha39_SNA08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[39] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha40 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha40.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha40.Close(); //fecha o arquivo depois de salvar.
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
            Form1.completarLinha = 1;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["Button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            ((Button)form.Controls["btn_aux"]).BackgroundImage = Form1.img2;
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["Button22"]).Cursor = new Cursor(Properties.Resources.icone_sna.Handle);

            Close();
        }

        private void SAIDA_NA_Load(object sender, EventArgs e)
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

        private void SAIDA_NA_Shown(object sender, EventArgs e)
        {
            br1.Checked = true;
            br2.Checked = false;
            br3.Checked = false;
            br4.Checked = false;
            br5.Checked = false;
            br6.Checked = false;
            br7.Checked = false;
            br8.Checked = false;
            //tb_comentario.Clear();
        }

        private void SAIDA_NA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }
    }
}
