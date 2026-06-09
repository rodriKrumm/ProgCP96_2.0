using System;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class MENSAGEM_DISPLAY : Form
    {
        public static char[] vetorVazio = new char[16];
        public static char[] vetorVazio2 = new char[16];
        public static char[] vetRecebe = new char[16];
        public static char[] vetRecebe2 = new char[16];

        public MENSAGEM_DISPLAY()
        {
            InitializeComponent();
        }

        private void MENSAGEM_DISPLAY_Shown(object sender, EventArgs e)
        {
            vetRecebe = DISPLAY.repassarMsg;
            for (int i = 0; i < 32; i++)
            {
                vetorVazio[i] = ' ';
            }
            for (int i = 0; i < vetRecebe.Length; i++)
            {
                vetorVazio[i] = vetRecebe[i];
            }

            vetRecebe2 = DISPLAY.repassarMsg2;
            for (int i = 0; i < 16; i++)
            {
                vetorVazio2[i] = ' ';
            }
            for (int i = 0; i < vetRecebe2.Length; i++)
            {
                vetorVazio2[i] = vetRecebe2[i];
            }

            lb_0.Text = vetorVazio[0].ToString();
            lb_1.Text = vetorVazio[1].ToString();
            lb_2.Text = vetorVazio[2].ToString();
            lb_3.Text = vetorVazio[3].ToString();
            lb_4.Text = vetorVazio[4].ToString();
            lb_5.Text = vetorVazio[5].ToString();
            lb_6.Text = vetorVazio[6].ToString();
            lb_7.Text = vetorVazio[7].ToString();
            lb_8.Text = vetorVazio[8].ToString();
            lb_9.Text = vetorVazio[9].ToString();
            lb_10.Text = vetorVazio[10].ToString();
            lb_11.Text = vetorVazio[11].ToString();
            lb_12.Text = vetorVazio[12].ToString();
            lb_13.Text = vetorVazio[13].ToString();
            lb_14.Text = vetorVazio[14].ToString();
            lb_15.Text = vetorVazio[15].ToString();
            lb_16.Text = vetorVazio[16].ToString();
            lb_17.Text = vetorVazio[17].ToString();
            lb_18.Text = vetorVazio[18].ToString();
            lb_19.Text = vetorVazio[19].ToString();
            lb_20.Text = vetorVazio[20].ToString();
            lb_21.Text = vetorVazio[21].ToString();
            lb_22.Text = vetorVazio[22].ToString();
            lb_23.Text = vetorVazio[23].ToString();
            lb_24.Text = vetorVazio[24].ToString();
            lb_25.Text = vetorVazio[25].ToString();
            lb_26.Text = vetorVazio[26].ToString();
            lb_27.Text = vetorVazio[27].ToString();
            lb_28.Text = vetorVazio[28].ToString();
            lb_29.Text = vetorVazio[29].ToString();
            lb_30.Text = vetorVazio[30].ToString();
            lb_31.Text = vetorVazio[31].ToString();
        }

        private void MENSAGEM_DISPLAY_Load(object sender, EventArgs e)
        {

        }
    }
}
