using System;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class visorCLP_ESPERA : Form
    {

        public static string receberMsg;
        public static char[] vetorvazio = new char[32];
        public static char[] vetorMensagem;

        public visorCLP_ESPERA()
        {
            InitializeComponent();
        }

        private void visorCLP_ESPERA_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 32; i++)
            {
                vetorvazio[i] = ' ';
            }

            vetorMensagem = ESPERA.passarMsg; // vetor que recebe a mensagem do display 

            for (int i = 0; i < vetorMensagem.Length; i++)
            {
                vetorvazio[i] = vetorMensagem[i];
            }

            lb_0.Text = vetorvazio[0].ToString();
            lb_1.Text = vetorvazio[1].ToString();
            lb_2.Text = vetorvazio[2].ToString();
            lb_3.Text = vetorvazio[3].ToString();
            lb_4.Text = vetorvazio[4].ToString();
            lb_5.Text = vetorvazio[5].ToString();
            lb_6.Text = vetorvazio[6].ToString();
            lb_7.Text = vetorvazio[7].ToString();
            lb_8.Text = vetorvazio[8].ToString();
            lb_9.Text = vetorvazio[9].ToString();
            lb_10.Text = vetorvazio[10].ToString();
            lb_11.Text = vetorvazio[11].ToString();
            lb_12.Text = vetorvazio[12].ToString();
            lb_13.Text = vetorvazio[13].ToString();
            lb_14.Text = vetorvazio[14].ToString();
            lb_15.Text = vetorvazio[15].ToString();
            lb_16.Text = vetorvazio[16].ToString();
            lb_17.Text = vetorvazio[17].ToString();
            lb_18.Text = vetorvazio[18].ToString();
            lb_19.Text = vetorvazio[19].ToString();
            lb_20.Text = vetorvazio[20].ToString();
            lb_21.Text = vetorvazio[21].ToString();
            lb_22.Text = vetorvazio[22].ToString();
            lb_23.Text = vetorvazio[23].ToString();
            lb_24.Text = vetorvazio[24].ToString();
            lb_25.Text = string.Empty;
            lb_26.Text = string.Empty;
            lb_27.Text = ESPERA.mostrar1.ToString();
            lb_28.Text = ESPERA.mostrar2.ToString();
            lb_29.Text = ESPERA.mostrar3.ToString();
            lb_30.Text = ESPERA.mostrar4.ToString();
            lb_31.Text = ESPERA.mostrar5.ToString();
            ESPERA.mostrar7 = ' ';
            ESPERA.mostrar6 = ' ';
        }
    }
}
