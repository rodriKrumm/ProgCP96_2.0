using System;
using System.IO;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class CONTATO_AUXILIAR : Form
    {
        int CA_NA01 = 100; // Contato Auxiliar NA
        int CA_NA02 = 102; // Contato Auxiliar NA
        int CA_NA03 = 104; // Contato Auxiliar NA
        int CA_NA04 = 106; // Contato Auxiliar NA
        int CA_NA05 = 108; // Contato Auxiliar NA
        int CA_NA06 = 109; // Contato Auxiliar NF///
        int CA_NA07 = 110; // Contato Auxiliar NA
        int CA_NA08 = 111; // Contato Auxiliar NF///
        int CA_NF09 = 101; // Contato Auxiliar NF
        int CA_NF10 = 103; // Contato Auxiliar NF
        int CA_NF11 = 105; // Contato Auxiliar NF
        int CA_NF12 = 107; // Contato Auxiliar NF
        int CA_SET_9 = 112; // Contato Auxiliar SET
        int CA_SET_10 = 40;  // Contato Auxiliar SET
        int CA_SET_11 = 42;  // Contato Auxiliar SET
        int CA_SET_12 = 44;  // Contato Auxiliar SET
        int CA_SET_13 = 46;  // Contato Auxiliar SET
        int CA_SET_14 = 48;  // Contato Auxiliar SET
        int CA_RESET_9 = 113; // Contato Auxiliar RESET
        int CA_RESET_10 = 41;  // Contato Auxiliar RESET
        int CA_RESET_11 = 43;  // Contato Auxiliar RESET
        int CA_RESET_12 = 45;  // Contato Auxiliar RESET
        int CA_RESET_13 = 47;  // Contato Auxiliar RESET
        int CA_RESET_14 = 49;  // Contato Auxiliar RESET

        public CONTATO_AUXILIAR()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NA01; 
                Form1.img = Properties.Resources.CONTATO_01_NA;
                tb_comentario.Text = Form1.linha86.Trim();

                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NA02; //102
                Form1.img = Properties.Resources.CONTATO_02_NA;
                tb_comentario.Text = Form1.linha88.Trim();

                radioButton9.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NA03; //104 
                Form1.img = Properties.Resources.CONTATO_03_NA;
                tb_comentario.Text = Form1.linha90.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NA04; // 106
                Form1.img = Properties.Resources.CONTATO_04_NA;
                tb_comentario.Text = Form1.linha92.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NA05; // 108
                Form1.img = Properties.Resources.CONTATO_05_NA;
                tb_comentario.Text = Form1.linha94.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NA06; //109
                Form1.img = Properties.Resources.CONTATO_06_NA;
                tb_comentario.Text = Form1.linha95.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NA07; // 110
                Form1.img = Properties.Resources.CONTATO_07_NA;
                tb_comentario.Text = Form1.linha96.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NA08; //111
                Form1.img = Properties.Resources.CONTATO_08_NA;
                tb_comentario.Text = Form1.linha97.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NF09; //101
                Form1.img = Properties.Resources.CONTATO_01_NF;
                tb_comentario.Text = Form1.linha87.Trim();

                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NF10; // 103
                Form1.img = Properties.Resources.CONTATO_02_NF;
                tb_comentario.Text = Form1.linha89.Trim();

                radioButton9.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NF11; // 105
                Form1.img = Properties.Resources.CONTATO_03_NF;
                tb_comentario.Text = Form1.linha91.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                Form1.click_selecionar[1] = CA_NF12; //107
                Form1.img = Properties.Resources.CONTATO_04_NF;
                tb_comentario.Text = Form1.linha93.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                Form1.click_selecionar[1] = CA_SET_9; // 112
                Form1.img = Properties.Resources.CONTATO_09_SET;
                tb_comentario.Text = Form1.linha98.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                Form1.click_selecionar[1] = CA_SET_10; // 40
                Form1.img = Properties.Resources.CONTATO_10_SET;
                tb_comentario.Text = Form1.linha104.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton13.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)  //CA_NA01 = 100; // Contato Auxiliar NA
            {
                Form1.Linha86_CAX01 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha86_CAX01. 
                string converter = new string(Form1.Linha86_CAX01); // converte Linha86_CAX01 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt"); // vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[86] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha87 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha87.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha87.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton2.Checked == true)  //CA_NA02 102; // Contato Auxiliar NA
            {
                Form1.linha88_CAX03 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha87_CAX02. 
                string converter = new string(Form1.linha88_CAX03); // converte Linha87_CAX02 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[88] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha88 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha88.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha88.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton3.Checked == true) //CA_NA03= 104; // Contato Auxiliar NA
            {
                Form1.linha90_CAX05 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor linha88_CAX03. 
                string converter = new string(Form1.linha90_CAX05); // converte linha88_CAX03 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[90] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha89 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha89.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha89.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton4.Checked == true) //CA_NA04 = 106; // Contato Auxiliar NA
            {
                Form1.Linha92_CAX07 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor linha89_CAX04. 
                string converter = new string(Form1.Linha92_CAX07); // converte linha89_CAX04 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[92] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha90 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha90.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha90.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton5.Checked == true) //CA_NA05 = 108; // Contato Auxiliar NA
            {
                Form1.Linha94_CAX09 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor linha90_CAX05. 
                string converter = new string(Form1.Linha94_CAX09); // converte linha90_CAX05 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[94] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha91 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha91.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha91.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton6.Checked == true) //CA_NA06 = 109; // Contato Auxiliar NA
            {
                Form1.Linha95_CAX10 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha91_CAX06. 
                string converter = new string(Form1.Linha95_CAX10); // converte Linha91_CAX06 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[95] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha92 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha92.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha92.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton7.Checked == true) //CA_NA07 = 110; // Contato Auxiliar NA
            {
                Form1.Linha96_CAX11 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha92_CAX07. 
                string converter = new string(Form1.Linha96_CAX11); // converte Linha92_CAX07 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[96] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha93 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha93.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha93.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton8.Checked == true) //CA_NA08 = 111; // Contato Auxiliar NA
            {
                Form1.Linha97_CAX12 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha93_CAX08. 
                string converter = new string(Form1.Linha97_CAX12); // converte Linha93_CAX08 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[97] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha94 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha94.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha94.Close(); //fecha o arquivo depois de salvar.
                }

            }
            if (radioButton9.Checked == true)  //CA_NF01 = 101; // Contato Auxiliar NF
            {
                Form1.Linha87_CAX02 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha94_CAX09. 
                string converter = new string(Form1.Linha87_CAX02); // converte Linha94_CAX09 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[87] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha95 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha95.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha95.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton10.Checked == true) //CA_NF02 = 103; // Contato Auxiliar NF
            {
                Form1.linha89_CAX04 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha95_CAX10. 
                string converter = new string(Form1.linha89_CAX04); // converte Linha95_CAX10 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[89] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha96 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha96.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha96.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton11.Checked == true) //CA_NF03 = 105; // Contato Auxiliar NF
            {
                Form1.Linha91_CAX06 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha96_CAX11. 
                string converter = new string(Form1.Linha91_CAX06); // converte Linha96_CAX11 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[91] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha97 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha97.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha97.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton12.Checked == true) //CA_NF04 = 107; // Contato Auxiliar NF
            {
                Form1.Linha93_CAX08 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha97_CAX12. 
                string converter = new string(Form1.Linha93_CAX08); // converte Linha97_CAX12 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[93] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha98 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha98.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha98.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton13.Checked == true) //SET01 = 112; // Contato Auxiliar SET
            {
                Form1.Linha98_CAX13 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha98_CAX13. 
                string converter = new string(Form1.Linha98_CAX13); // converte Linha98_CAX13 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[98] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha99 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha99.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha99.Close(); //fecha o arquivo depois de salvar.
                }
            }
            if (radioButton14.Checked == true) //SET02 = 40; // Contato Auxiliar SET
            {
                Form1.linha104_CAX15 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha104_CAX15); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[104] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }
            }
             
            if (radioButton15.Checked == true) //set03 = 42; // Contato Auxiliar SET
            {
                Form1.linha106_CAX17 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha106_CAX17);
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[106] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton16.Checked == true) //set04 = 44; // Contato Auxiliar SET
            {
                Form1.linha112_CAX23 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha112_CAX23); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[112] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton17.Checked == true) //set05 = 46; // Contato Auxiliar SET
            {
                Form1.linha108_CAX19 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha108_CAX19); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[108] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton18.Checked == true) //SET06 = 48; // Contato Auxiliar SET
            {
                Form1.linha110_CAX21 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha110_CAX21); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[110] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton19.Checked == true) //reset01= 113; // Contato Auxiliar RESET
            {
                Form1.Linha99_CAX14 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.Linha99_CAX14); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[99] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }
            }

            if (radioButton20.Checked == true) //reset02= 41; // Contato Auxiliar RESET
            {
                Form1.linha105_CAX16 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha105_CAX16); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[105] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.

                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }

            }

            if (radioButton21.Checked == true) //reset03= 43; // Contato Auxiliar RESET
            {
                Form1.linha107_CAX18 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha107_CAX18); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[107] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }

            }

            if (radioButton22.Checked == true) //reset04= 45; // Contato Auxiliar RESET
            {
                Form1.linha109_CAX20 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha109_CAX20); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[109] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }

            }

            if (radioButton23.Checked == true) //reset05= 47; // Contato Auxiliar RESET
            {
                Form1.linha111_CAX22 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha111_CAX22); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[111] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
                }

            }

            if (radioButton24.Checked == true) //reset06= 49; // Contato Auxiliar RESET
            {
                Form1.linha113_CAX24 = tb_comentario.Text.ToCharArray(); // carrega o comentario no vetor Linha99_CAX14. 
                string converter = new string(Form1.linha113_CAX24); // converte Linha99_CAX14 para string
                string[] linhas = File.ReadAllLines(Form1.caminhoarq + @"\Comentarios.txt");// vetor Linhas recebe todo o conteudo do arquivo Comentarios
                for (int i = 0; i < linhas.Length; i++)
                {
                    linhas[113] = converter; // Quinta linha do arquivo Comentarios recebe o comentario convertido para string
                    StreamWriter SalvarLinha100 = new StreamWriter(Form1.caminhoarq + @"\Comentarios.txt");
                    foreach (var linha in linhas) //para cada linha do vetor linhas
                    {
                        SalvarLinha100.WriteLine(linha); //escreve a linha especificada no no arquivo.
                    }
                    SalvarLinha100.Close(); //fecha o arquivo depois de salvar.
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
            Form1.completarLinha = 6;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["Button22"]).BackgroundImage = Form1.img;
            ((Button)form.Controls["Button22"]).Text = tb_comentario.Text;
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_contAux.Handle);
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

        private void CONTATO_AUXILIAR_Shown(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                Form1.click_selecionar[1] = CA_SET_11; // 42
                Form1.img = Properties.Resources.CONTATO_11_SET;
                tb_comentario.Text = Form1.linha106.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                Form1.click_selecionar[1] = CA_SET_14; //44
                Form1.img = Properties.Resources.CONTATO_14_SET;
                tb_comentario.Text = Form1.linha112.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton23.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked == true)
            {
                Form1.click_selecionar[1] = CA_SET_12; //44
                Form1.img = Properties.Resources.CONTATO_12_SET;
                tb_comentario.Text = Form1.linha108.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton16.Checked = false;
                radioButton21.Checked = false;
                radioButton18.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
            {
                Form1.click_selecionar[1] = CA_SET_13; //48
                Form1.img = Properties.Resources.CONTATO_13_SET;
                tb_comentario.Text = Form1.linha110.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton16.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton17.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                Form1.click_selecionar[1] = CA_RESET_9; // 113
                Form1.img = Properties.Resources.CONTATO_09_RES;
                tb_comentario.Text = Form1.linha99.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton13.Checked = false;
                radioButton20.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked == true)
            {
                Form1.click_selecionar[1] = CA_RESET_10; // 41
                Form1.img = Properties.Resources.CONTATO_10_RESET;
                tb_comentario.Text = Form1.linha105.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked == true)
            {
                Form1.click_selecionar[1] = CA_RESET_11; // 43
                Form1.img = Properties.Resources.CONTATO_11_RESET;
                tb_comentario.Text = Form1.linha107.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton16.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton22.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked == true)
            {
                Form1.click_selecionar[1] = CA_RESET_12; // 45
                Form1.img = Properties.Resources.CONTATO_12_RESET;
                tb_comentario.Text = Form1.linha109.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton16.Checked = false;
                radioButton21.Checked = false;
                radioButton18.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton17.Checked = false;
                radioButton23.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked == true)
            {
                Form1.click_selecionar[1] = CA_RESET_13; // 47
                Form1.img = Properties.Resources.CONTATO_13_RESET;
                tb_comentario.Text = Form1.linha111.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton16.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton24.Checked = false;
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
            {
                Form1.click_selecionar[1] = CA_RESET_14; // 49
                Form1.img = Properties.Resources.CONTATO_14_RESET;
                tb_comentario.Text = Form1.linha113.Trim();

                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton5.Checked = false;
                radioButton4.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton8.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton23.Checked = false;
                radioButton21.Checked = false;
                radioButton22.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton16.Checked = false;

            }
        }      
    }
}
