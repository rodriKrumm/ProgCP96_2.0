using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class ENTRADA_NA : Form
    {
       
        public ENTRADA_NA()
        {
            InitializeComponent();
        }


        public static int NA_01 = 4;
        public static int NA_02 = 6;
        public static int NA_03 = 8;
        public static int NA_04 = 10;
        public static int NA_05 = 12;
        public static int NA_06 = 14;
        public static int NA_07 = 16;
        public static int NA_08 = 18;

        public static string frase;

        public static string[] vetFrase;

        private void ENTRADA_NA_Load(object sender, EventArgs e)
        {
            
           
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio1.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I01;
                Form1.click_selecionar[1] = NA_01;
                Form1.img = Properties.Resources.ENA_E01;               
                tb_comentario.Text = Form1.linha0.Trim();               
            }
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I02;
                Form1.click_selecionar[1] = NA_02;
                Form1.img = Properties.Resources.ENA_E02;
                tb_comentario.Text = Form1.linha1.Trim();
            }
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio3.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I03;
                Form1.click_selecionar[1] = NA_03;
                Form1.img = Properties.Resources.ENA_E03;
                tb_comentario.Text = Form1.linha2.Trim();
            }
        }

        private void radio4_CheckedChanged(object sender, EventArgs e)
        {
            if (radio4.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I04;
                Form1.click_selecionar[1] = NA_04;
                Form1.img = Properties.Resources.ENA_E04;
                tb_comentario.Text = Form1.linha3.Trim();
            }
        }

        private void radio5_CheckedChanged(object sender, EventArgs e)
        {
            if (radio5.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I05;
                Form1.click_selecionar[1] = NA_05;
                Form1.img = Properties.Resources.ENA_E05;
                tb_comentario.Text = Form1.linha4.Trim();
            }
        }

        private void radio6_CheckedChanged(object sender, EventArgs e)
        {
            if (radio6.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I06;

                Form1.click_selecionar[1] = NA_06;
                Form1.img = Properties.Resources.ENA_E06;
                tb_comentario.Text = Form1.linha5.Trim();
            }
        }

        private void radio7_CheckedChanged(object sender, EventArgs e)
        {
            if (radio7.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I07;
                Form1.click_selecionar[1] = NA_07;
                Form1.img = Properties.Resources.ENA_E07;
                tb_comentario.Text = Form1.linha6.Trim();
            }
        }

        private void radio8_CheckedChanged(object sender, EventArgs e)
        {
            if (radio8.Checked == true)
            {
                groupBox1.BackgroundImage = Properties.Resources.I08;
                Form1.click_selecionar[1] = NA_08;
                Form1.img = Properties.Resources.ENA_E08;
                tb_comentario.Text = Form1.linha7.Trim();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (radio1.Checked == true)
            {
                Form1.Linha0_ENA01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha0_ENA01. 
                string converter = new string(Form1.Linha0_ENA01); // converte Linha0_ENA01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[0] = converter; // primeira linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha0 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) // para cada linha do vetor linhas
                    {
                        SalvarLinha0.WriteLine(linha); // escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha0.Close(); // fecha o arquivo depois de salvar.
                }
            }

            if (radio2.Checked == true)
            {
                Form1.Linha1_ENA02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha0_ENA01. 
                string converter = new string(Form1.Linha1_ENA02); // converte Linha0_ENA02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[1] = converter; // segunda linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha1 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha1.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha1.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radio3.Checked == true)
            {
                Form1.Linha2_ENA03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha2_ENA03. 
                string converter = new string(Form1.Linha2_ENA03); // converte Linha2_ENA03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[2] = converter; // segunda linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha3 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha3.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha3.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radio4.Checked == true)
            {
                Form1.Linha3_ENA04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha3_ENA04. 
                string converter = new string(Form1.Linha3_ENA04); // converte Linha3_ENA04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[3] = converter; // segunda linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha4 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha4.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha4.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radio5.Checked == true)
            {
                Form1.Linha4_ENA05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha4_ENA05. 
                string converter = new string(Form1.Linha4_ENA05); // converte Linha4_ENA05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[4] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha5 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha5.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha5.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radio6.Checked == true)
            {
                Form1.Linha5_ENA06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha5_ENA06. 
                string converter = new string(Form1.Linha5_ENA06); // converte Linha5_ENA06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[5] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha6 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha6.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha6.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radio7.Checked == true)
            {
                Form1.Linha6_ENA07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha6_ENA07. 
                string converter = new string(Form1.Linha6_ENA07); // converte Linha6_ENA07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[6] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha7 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha7.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha7.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radio8.Checked == true)
            {
                Form1.Linha7_ENA08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha7_ENA08. 
                string converter = new string(Form1.Linha7_ENA08); // converte Linha7_ENA08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[7] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha8 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha8.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha8.Close(); //fecha o arquivo depois de salvar.
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
            ((Button)form.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_ena.Handle);

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.click_selecionar[1] = 0;
            Form1.img = Properties.Resources.linhas_gridview;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = Form1.img;
           
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENTRADA_NA_Shown(object sender, EventArgs e)
        {
            radio1.Checked = true;
            radio2.Checked = false;
            radio3.Checked = false;
            radio4.Checked = false;
            radio5.Checked = false;
            radio6.Checked = false;
            radio7.Checked = false;
            radio8.Checked = false;

           
        }

        private void ENTRADA_NA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.click_selecionar[1] = 0;
                Close();
            }
        }

        
    }
}
