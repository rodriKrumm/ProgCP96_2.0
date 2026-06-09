using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGCP96_V1._1_
{
    public partial class SIMULACAO : Form
    {
        Form1 principal;
        public SIMULACAO(Form1 referencia)
        {
            InitializeComponent();
            principal = referencia;

            inicia_matriz();
            carrega_parametros_da_flash();
            converte_dados();
            carrega_matriz();
            timer1.Enabled = true;
            timer2.Enabled = true;
            principal.dataGridView1.CurrentCell = null;
            D00IE = 1;
        }



        /* Private variables ---------------------------------------------------------*/
        int TSEGREP = 8; 		// 0,8S = 8 X 0,1S = TEMPO PRESSIONANDO TECLA APÓS O QUAL COMEÇA A REPETIR
        int TSEGREP2 = 20;		//; 2S =  20 X 0,1S = TEMPO PRESSIONANDO TECLA APÓS O QUAL ENTRA NO 2º ESTÁGIO DE REPETIÇÃO
        int TSEGREP3 = 50;		//; 5S =  50 X 0,1S = TEMPO PRESSIONANDO TECLA APÓS O QUAL ENTRA NO 3º ESTÁGIO DE REPETIÇÃO
        int T_INAT = 120;		//; 60S = 120 X 0,5S = TEMPO SEM PRESSIONAR TECLA APÓS O QUAL RETORNA AUTOMATICAMENTE À TELA DE FUNDO
        int MEDIA_ANALOGICAS = 50;		//; numeros de leituras para fazer a media
        int TEMPO_PULSO_BORDA = 10;		//; 10 x 0.01 TEMPO QUE BORDA FICA ACIONADA

        int TECLA_UP = 1;
        int TECLA_SIM = 2;
        int TECLA_NAO = 3;
        int TECLA_DOWN = 4;
        int TECLA_TEMPERATURA = 5;
        int TECLA_TEMPO = 6;
        int TECLA_P = 7;
        int TECLA_F1 = 8;
        int TECLA_F2 = 9;
        int TECLA_F3 = 10;


        bool LARGOU_TECLA_UP = false;
        bool LARGOU_TECLA_SIM = false;
        bool LARGOU_TECLA_NAO = false;
        bool LARGOU_TECLA_DOWN = false;
        bool LARGOU_TECLA_TEMPERATURA = false;
        bool LARGOU_TECLA_TEMPO = false;
        bool LARGOU_TECLA_F1 = false;
        bool LARGOU_TECLA_F2 = false;
        bool LARGOU_TECLA_F3 = false;
        bool LARGOU_TECLA_P = false;

        // FLAGS INDICADORES QUE TEMPO PASSOU
        bool P_10MS_SCAN = false;
        bool P_10MS = false;
        bool P_10MS_KBD = false;
        bool P_10MS_IN = false;
        bool P_10MS_IN_B = false;
        bool P_100MS_LCD = false;
        bool P_10MS_AN = false;
        bool P_100MS = false;
        bool P_300MS = false;
        bool P_500MS = false;
        bool P_1S = false;
        bool P_1MIN = false;
        bool P_1HORA = false;

        // DECLARAÇÃO DE VARIÁVEIS PARA USO DAS BASES DE TEMPO:
        int base_10ms = 0;
        int base_100ms = 0;
        int base_300ms = 0;
        int base_500ms = 0;
        int base_1s = 0;
        int base_2s = 0;
        int base_1m = 0;
        int base_1h = 0;

        // Para fazer efeito de piscar no ajuste//
        bool piscante = false;
        bool pisca = false;
        int tempo_inicializacao = 0;
        //////////////niveis dos processos////////////////////////
        //TECLAS
        int tecla = 0;
        int u_tecla = 0;
        int CTECINA = 0;
        int TSEGURA = 0;
        int tecla_tmp = 0;
        int base_kbd = 0;
        bool kb_rp = false;
        bool salva = false;
        bool segurou = false;
        bool repete1 = false;
        bool repete2 = false;
        bool repete3 = false;
        bool teclina = false;

        //////////////para leitura analogica
        int valor_A01 = 0;
        int valor_A02 = 0;
        int valor_A03 = 0;
        int valor_A04 = 0;
        int valor_ad_NTC = 0;
        int soma_valor_A01 = 0;
        int soma_valor_A02 = 0;
        int soma_valor_A03 = 0;
        int soma_valor_A04 = 0;
        int soma_valor_ad_NTC = 0;
        int contador_media = 0;
        bool leu_analogicas = false;
        int offset_A01 = 0;
        int histerese_A01 = 0;
        int aquecimento_refrigeracao_A01 = 0;
        int percentual_histerese_A01 = 0;
        int tempo_pwm_A01 = 0;
        int percentual_A01 = 0;
        int banda_pd_A01 = 0;
        int tempo_off_pwm_A01 = 0;
        int contador_tempo_off_pwm_A01 = 0;
        int tempo_on_pwm_A01 = 0;
        int contador_tempo_on_pwm_A01 = 0;
        int liga_pwm_A01 = 0;
        int pwm_A01 = 0;
        byte OUT_TEMPERATURA_A01 = 0;

        int offset_A02 = 0;
        int histerese_A02 = 0;
        int aquecimento_refrigeracao_A02 = 0;
        int percentual_histerese_A02 = 0;
        int tempo_pwm_A02 = 0;
        int percentual_A02 = 0;
        int banda_pd_A02 = 0;
        int tempo_off_pwm_A02 = 0;
        int contador_tempo_off_pwm_A02 = 0;
        int tempo_on_pwm_A02 = 0;
        int contador_tempo_on_pwm_A02 = 0;
        int liga_pwm_A02 = 0;
        int pwm_A02 = 0;
        byte OUT_TEMPERATURA_A02 = 0;

        int offset_A03 = 0;
        int histerese_A03 = 0;
        int aquecimento_refrigeracao_A03 = 0;
        int percentual_histerese_A03 = 0;
        int tempo_pwm_A03 = 0;
        int percentual_A03 = 0;
        int banda_pd_A03 = 0;
        int tempo_off_pwm_A03 = 0;
        int contador_tempo_off_pwm_A03 = 0;
        int tempo_on_pwm_A03 = 0;
        int contador_tempo_on_pwm_A03 = 0;
        int liga_pwm_A03 = 0;
        int pwm_A03 = 0;
        byte OUT_TEMPERATURA_A03 = 0;

        int offset_A04 = 0;
        int histerese_A04 = 0;
        int aquecimento_refrigeracao_A04 = 0;
        int percentual_histerese_A04 = 0;
        int tempo_pwm_A04 = 0;
        int percentual_A04 = 0;
        int banda_pd_A04 = 0;
        int tempo_off_pwm_A04 = 0;
        int contador_tempo_off_pwm_A04 = 0;
        int tempo_on_pwm_A04 = 0;
        int contador_tempo_on_pwm_A04 = 0;
        int liga_pwm_A04 = 0;
        int pwm_A04 = 0;
        byte OUT_TEMPERATURA_A04 = 0;

        ////////////// registradores para setup/////////////
        int valor_ajustado = 0;
        int flag_ajustado = 0;
        bool bit_modo_teste = false;

        //FLAGS PARA USO NA LADDER CONTADORES PARA LEITURA DAS ENTRADAS
        //verifica BIMANUAL
        int soma_msg = 0;

        int vazio = 0;
        int an_d = 1;  	    	// funcao AND = 0
        int or_bt = 200;  		// funcao OR para baixo e para traz
        int or_bt_mid = 201;  	// funcao OR para baixo e para traz final
        int or_bt_end = 202;  	// funcao OR para baixo e para frente
        int cont_t = 3;  // funcao CONTATO CONTINUO
        int col = 0;
        int lin = 0;
        byte var_funcao = 0;
        int funcao = 0;
        int contato = 0;
        int coluna = 0;
        int indice = 0;
        int par_impar = 0;
        int Aux_de_linha = 0;
        int prof = 0;
        int valor = 0;

        int linhas = 250;
        int colunas = 18;
        byte[] File_Ladder = new byte[4500];
        byte[,,] matriz = new byte[250, 18, 3];
        byte[] Matr_Entr_said_virtual = new byte[255];

        // ENTRADAS NA_NF
        byte E1 = 0;                   //
        byte E2 = 0;                   //
        byte E3 = 0;                   //
        byte E4 = 0;                   //
        byte E5 = 0;                   //
        byte E6 = 0;                   //
        byte E7 = 0;                   //
        byte E8 = 0;                   //
                                       // ENTRADAS DE BORDA POSITIVA


        int cont1_bp = 0;
        int cont2_bp = 0;
        int cont3_bp = 0;
        int cont4_bp = 0;
        int cont5_bp = 0;
        int cont6_bp = 0;
        int cont7_bp = 0;
        int cont8_bp = 0;

        int cont1_bn = 0;
        int cont2_bn = 0;
        int cont3_bn = 0;
        int cont4_bn = 0;
        int cont5_bn = 0;
        int cont6_bn = 0;
        int cont7_bn = 0;
        int cont8_bn = 0;


        byte E1_P = 0;                 //
        byte E2_P = 0;                 //
        byte E3_P = 0;                 //
        byte E4_P = 0;                 //
        byte E5_P = 0;                 //
        byte E6_P = 0;                 //
        byte E7_P = 0;                 //
        byte E8_P = 0;                 //
                                       //  ENTRADAS RESERVAS NEGATIVA
        byte E1_N = 0;                 //
        byte E2_N = 0;                 //
        byte E3_N = 0;                 //
        byte E4_N = 0;                 //
        byte E5_N = 0;                 //
        byte E6_N = 0;                 //
        byte E7_N = 0;                 //
        byte E8_N = 0;                 //

        // transição borda Positiva
        byte E1_T_P = 0;
        byte E2_T_P = 0;
        byte E3_T_P = 0;
        byte E4_T_P = 0;
        byte E5_T_P = 0;
        byte E6_T_P = 0;
        byte E7_T_P = 0;
        byte E8_T_P = 0;
        // transição borda Positiva
        byte E1_T_N = 0;
        byte E2_T_N = 0;
        byte E3_T_N = 0;
        byte E4_T_N = 0;
        byte E5_T_N = 0;
        byte E6_T_N = 0;
        byte E7_T_N = 0;
        byte E8_T_N = 0;


        byte bm_ok1 = 0;
        byte bm_ok2 = 0;

        /////SAIDAS NORMAIS NA_NF///
        byte Q1 = 0;                   //
        byte Q2 = 0;                   //
        byte Q3 = 0;                   //
        byte Q4 = 0;                   //
        byte Q5 = 0;                   //
        byte Q6 = 0;                   //
        byte Q7 = 0;                   //
        byte Q8 = 0;                   //

        byte OUT_S1 = 0;
        byte OUT_S2 = 0;
        byte OUT_S3 = 0;
        byte OUT_S4 = 0;
        byte OUT_S5 = 0;
        byte OUT_S6 = 0;
        byte OUT_S7 = 0;
        byte OUT_S8 = 0;


        ////////MEMORIA AUXILIA//////
        byte M01IE = 0;                    //
        byte M02IE = 0;                    //
        byte M03IE = 0;                    //
        byte M04IE = 0;                    //
        byte M05IE = 0;                    //
        byte M06IE = 0;                    //
        byte M07IE = 0;                    //
        byte M08IE = 0;                    //
        byte M09IE = 0;                    //
        byte M10IE = 0;                    //
        byte M11IE = 0;                    //
        byte M12IE = 0;                    //
        byte M13IE = 0;                    //
        byte M14IE = 0;                    //

        ////////CONTADORES//////////
        byte C01IE = 0;                    //
        byte C02IE = 0;                    //

        //////RETARDOS FIXOS////////
        byte R01IE = 0;                    //
        byte R02IE = 0;                    //
        byte R03IE = 0;                    //
        byte R04IE = 0;                    //
        byte R05IE = 0;                    //
        byte R06IE = 0;                    //
        byte R07IE = 0;                    //
        byte R08IE = 0;                    //

        //////TEMPORIZADORES DECIMOS////////
        byte T01IE = 0;                    //
        byte T02IE = 0;                    //
        byte T03IE = 0;                    //
        byte T04IE = 0;                    //
        byte T05IE = 0;                    //
        byte T06IE = 0;                    //
        byte T07IE = 0;                    //
        byte T08IE = 0;                    //

        byte T09IE = 0;                    //
        byte T10IE = 0;                    //
        byte T11IE = 0;                    //
        byte T12IE = 0;                    //
        byte T13IE = 0;                    //
        byte T14IE = 0;                    //
        byte T15IE = 0;                    //
        byte T16IE = 0;                    //

        byte T17IE = 0;                    //
        byte T18IE = 0;                    //
        byte T19IE = 0;                    //
        byte T20IE = 0;                    //
        byte T21IE = 0;                    //
        byte T22IE = 0;                    //
        byte T23IE = 0;                    //
        byte T24IE = 0;                    //

        //////////MENSAGENS////////
        byte D00IE = 0;                    //
        byte D01IE = 0;                    //
        byte D02IE = 0;                    //
        byte D03IE = 0;                    //
        byte D04IE = 0;                    //
        byte D05IE = 0;                    //
        byte D06IE = 0;                    //
        byte D07IE = 0;                    //
        byte D08IE = 0;                  //



        char[] PROPRIEDADES_T01 = new char[43];
        char[] PROPRIEDADES_T02 = new char[43];
        char[] PROPRIEDADES_T03 = new char[43];
        char[] PROPRIEDADES_T04 = new char[43];
        char[] PROPRIEDADES_T05 = new char[43];
        char[] PROPRIEDADES_T06 = new char[43];
        char[] PROPRIEDADES_T07 = new char[43];
        char[] PROPRIEDADES_T08 = new char[43];
        char[] PROPRIEDADES_T09 = new char[43];
        char[] PROPRIEDADES_T10 = new char[43];
        char[] PROPRIEDADES_T11 = new char[43];
        char[] PROPRIEDADES_T12 = new char[43];
        char[] PROPRIEDADES_T13 = new char[43];
        char[] PROPRIEDADES_T14 = new char[43];
        char[] PROPRIEDADES_T15 = new char[43];
        char[] PROPRIEDADES_T16 = new char[43];
        char[] PROPRIEDADES_T17 = new char[43];
        char[] PROPRIEDADES_T18 = new char[43];
        char[] PROPRIEDADES_T19 = new char[43];
        char[] PROPRIEDADES_T20 = new char[43];
        char[] PROPRIEDADES_T21 = new char[43];
        char[] PROPRIEDADES_T22 = new char[43];
        char[] PROPRIEDADES_T23 = new char[43];
        char[] PROPRIEDADES_T24 = new char[43];

        char[] PROPRIEDADES_C01 = new char[43];
        char[] PROPRIEDADES_C02 = new char[43];

        char[] PROPRIEDADES_B01 = new char[43];
        char[] PROPRIEDADES_B02 = new char[43];

        char[] PROPRIEDADES_BM1 = new char[43];
        char[] PROPRIEDADES_BM2 = new char[43];


        char[] PROPRIEDADES_R01 = new char[43];
        char[] PROPRIEDADES_R02 = new char[43];
        char[] PROPRIEDADES_R03 = new char[43];
        char[] PROPRIEDADES_R04 = new char[43];
        char[] PROPRIEDADES_R05 = new char[43];
        char[] PROPRIEDADES_R06 = new char[43];
        char[] PROPRIEDADES_R07 = new char[43];
        char[] PROPRIEDADES_R08 = new char[43];


        char[] PROPRIEDADES_A01 = new char[43];
        char[] PROPRIEDADES_A02 = new char[43];
        char[] PROPRIEDADES_A03 = new char[43];
        char[] PROPRIEDADES_A04 = new char[43];

        //    linha1      /   linha2
        char[] PROPRIEDADES_D00 = new char[64];
        char[] PROPRIEDADES_D01 = new char[64];
        char[] PROPRIEDADES_D02 = new char[64];
        char[] PROPRIEDADES_D03 = new char[64];
        char[] PROPRIEDADES_D04 = new char[64];
        char[] PROPRIEDADES_D05 = new char[64];
        char[] PROPRIEDADES_D06 = new char[64];
        char[] PROPRIEDADES_D07 = new char[64];
        char[] PROPRIEDADES_D08 = new char[64];

        char[] p = new char[64];

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T01 = 100;                                                      // valor default do temporizador
        int tempo_T01 = 100;                                                   // valor default do temporizador
        int max_T01 = 999;                                                     // valor máximo a ser ajustado
        int min_T01 = 1;                                                       // valor minimo a ser ajustado
        int adj_T01 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T01 = 0;                                                    // contador para fazer temporizacao
                                                                                       ////////////////////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T02 = 100;                                                      // valor default do temporizador
        int tempo_T02 = 100;                                                   // valor default do temporizador
        int max_T02 = 999;                                                     // valor máximo a ser ajustado
        int min_T02 = 1;                                                       // valor minimo a ser ajustado
        int adj_T02 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T02 = 0;                                                    // contador para fazer temporizacao
        int T02_run = 0;                                                    // indicacao de tempo ativo
                                                                            ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T03 = 100;                                                      // valor default do temporizador
        int tempo_T03 = 100;                                                   // valor default do temporizador
        int max_T03 = 999;                                                     // valor máximo a ser ajustado
        int min_T03 = 1;                                                       // valor minimo a ser ajustado
        int adj_T03 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T03 = 0;                                                    // contador para fazer temporizacao
        int T03_run = 0;                                                      // indicacao de tempo ativo
                                                                              ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T04 = 100;                                                      // valor default do temporizador
        int tempo_T04 = 100;                                                   // valor default do temporizador
        int max_T04 = 999;                                                     // valor máximo a ser ajustado
        int min_T04 = 1;                                                       // valor minimo a ser ajustado
        int adj_T04 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T04 = 0;                                                    // contador para fazer temporizacao
        int T04_run = 0;                                                      // indicacao de tempo ativo
                                                                              ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T05 = 100;                                                      // valor default do temporizador
        int tempo_T05 = 100;                                                   // valor default do temporizador
        int max_T05 = 999;                                                     // valor máximo a ser ajustado
        int min_T05 = 1;                                                       // valor minimo a ser ajustado
        int adj_T05 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T05 = 0;                                                    // contador para fazer temporizacao
        int T05_run = 0;                                                      // indicacao de tempo ativo
                                                                              ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T06 = 100;                                                      // valor default do temporizador
        int tempo_T06 = 100;                                                   // valor default do temporizador
        int max_T06 = 999;                                                     // valor máximo a ser ajustado
        int min_T06 = 1;                                                       // valor minimo a ser ajustado
        int adj_T06 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T06 = 0;                                                    // contador para fazer temporizacao
        int T06_run = 0;                                                      // indicacao de tempo ativo
                                                                              ////////////////////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T07 = 100;                                                      // valor default do temporizador
        int tempo_T07 = 100;                                                   // valor default do temporizador
        int max_T07 = 999;                                                     // valor máximo a ser ajustado
        int min_T07 = 1;                                                       // valor minimo a ser ajustado
        int adj_T07 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T07 = 0;                                                    // contador para fazer temporizacao
        int T07_run = 0;                                                      // indicacao de tempo ativo
                                                                              ////////////////////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T08 = 100;                                                      // valor default do temporizador
        int tempo_T08 = 100;                                                   // valor default do temporizador
        int max_T08 = 999;                                                     // valor máximo a ser ajustado
        int min_T08 = 1;                                                       // valor minimo a ser ajustado
        int adj_T08 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T08 = 0;                                                    // contador para fazer temporizacao
        int T08_run = 0;                                                      // indicacao de tempo ativo
                                                                              ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T09 = 100;                                                      // valor default do temporizador
        int tempo_T09 = 100;                                                   // valor default do temporizador
        int max_T09 = 999;                                                     // valor máximo a ser ajustado
        int min_T09 = 1;                                                           // valor minimo a ser ajustado
        int adj_T09 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T09 = 0;                                                        // contador para fazer temporizacao
        int T09_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T10 = 100;                                                      // valor default do temporizador
        int tempo_T10 = 100;                                                   // valor default do temporizador
        int max_T10 = 999;                                                     // valor máximo a ser ajustado
        int min_T10 = 1;                                                           // valor minimo a ser ajustado
        int adj_T10 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T10 = 0;                                                        // contador para fazer temporizacao
        int T10_run = 0;                                                          // indicacao de tempo ativo

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T11 = 100;                                                      // valor default do temporizador
        int tempo_T11 = 100;                                                   // valor default do temporizador
        int max_T11 = 999;                                                     // valor máximo a ser ajustado
        int min_T11 = 1;                                                           // valor minimo a ser ajustado
        int adj_T11 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T11 = 0;                                                        // contador para fazer temporizacao
        int T11_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T12 = 100;                                                      // valor default do temporizador
        int tempo_T12 = 100;                                                   // valor default do temporizador
        int max_T12 = 999;                                                     // valor máximo a ser ajustado
        int min_T12 = 1;                                                           // valor minimo a ser ajustado
        int adj_T12 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T12 = 0;                                                        // contador para fazer temporizacao
        int T12_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T13 = 100;                                                      // valor default do temporizador
        int tempo_T13 = 100;                                                   // valor default do temporizador
        int max_T13 = 999;                                                     // valor máximo a ser ajustado
        int min_T13 = 1;                                                           // valor minimo a ser ajustado
        int adj_T13 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T13 = 0;                                                        // contador para fazer temporizacao
        int T13_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T14 = 100;                                                      // valor default do temporizador
        int tempo_T14 = 100;                                                   // valor default do temporizador
        int max_T14 = 999;                                                     // valor máximo a ser ajustado
        int min_T14 = 1;                                                       // valor minimo a ser ajustado
        int adj_T14 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T14 = 0;                                                    // contador para fazer temporizacao
        int T14_run = 0;                                                      // indicacao de tempo ativo
                                                                              ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T15 = 100;                                                      // valor default do temporizador
        int tempo_T15 = 100;                                                   // valor default do temporizador
        int max_T15 = 999;                                                     // valor máximo a ser ajustado
        int min_T15 = 1;                                                       // valor minimo a ser ajustado
        int adj_T15 = 0;                                                    // ajuste normal ou avancado
        int contador_tempo_T15 = 0;                                                    // contador para fazer temporizacao
        int T15_run = 0;                                                      // indicacao de tempo ativo
                                                                              ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T16 = 100;                                                      // valor default do temporizador
        int tempo_T16 = 100;                                                   // valor default do temporizador
        int max_T16 = 999;                                                     // valor máximo a ser ajustado
        int min_T16 = 1;                                                           // valor minimo a ser ajustado
        int adj_T16 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T16 = 0;                                                        // contador para fazer temporizacao
        int T16_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T17 = 100;                                                      // valor default do temporizador
        int tempo_T17 = 100;                                                   // valor default do temporizador
        int max_T17 = 999;                                                     // valor máximo a ser ajustado
        int min_T17 = 1;                                                           // valor minimo a ser ajustado
        int adj_T17 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T17 = 0;                                                        // contador para fazer temporizacao
        int T17_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T18 = 100;                                                      // valor default do temporizador
        int tempo_T18 = 100;                                                   // valor default do temporizador
        int max_T18 = 999;                                                     // valor máximo a ser ajustado
        int min_T18 = 1;                                                           // valor minimo a ser ajustado
        int adj_T18 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T18 = 0;                                                        // contador para fazer temporizacao
        int T18_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T19 = 100;                                                      // valor default do temporizador
        int tempo_T19 = 100;                                                   // valor default do temporizador
        int max_T19 = 999;                                                     // valor máximo a ser ajustado
        int min_T19 = 1;                                                           // valor minimo a ser ajustado
        int adj_T19 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T19 = 0;                                                        // contador para fazer temporizacao
        int T19_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T20 = 100;                                                      // valor default do temporizador
        int tempo_T20 = 100;                                                   // valor default do temporizador
        int max_T20 = 999;                                                     // valor máximo a ser ajustado
        int min_T20 = 1;                                                           // valor minimo a ser ajustado
        int adj_T20 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T20 = 0;                                                        // contador para fazer temporizacao
        int T20_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T21 = 100;                                                      // valor default do temporizador
        int tempo_T21 = 100;                                                   // valor default do temporizador
        int max_T21 = 999;                                                     // valor máximo a ser ajustado
        int min_T21 = 1;                                                           // valor minimo a ser ajustado
        int adj_T21 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T21 = 0;                                                        // contador para fazer temporizacao
        int T21_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T22 = 100;                                                      // valor default do temporizador
        int tempo_T22 = 100;                                                   // valor default do temporizador
        int max_T22 = 999;                                                     // valor máximo a ser ajustado
        int min_T22 = 1;                                                           // valor minimo a ser ajustado
        int adj_T22 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T22 = 0;                                                        // contador para fazer temporizacao
        int T22_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T23 = 100;                                                      // valor default do temporizador
        int tempo_T23 = 100;                                                   // valor default do temporizador
        int max_T23 = 999;                                                     // valor máximo a ser ajustado
        int min_T23 = 1;                                                           // valor minimo a ser ajustado
        int adj_T23 = 0;                                                        // ajuste normal ou avancado
        int contador_tempo_T23 = 0;                                                        // contador para fazer temporizacao
        int T23_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_T24 = 100;                                                      // valor default do temporizador
        int tempo_T24 = 100;                                                   // valor default do temporizador
        int max_T24 = 999;                                                     // valor máximo a ser ajustado
        int min_T24 = 1;                                                           // valor minimo a ser ajustado
        int adj_T24 = 0;                                                            // ajuste normal ou avancado
        int contador_tempo_T24 = 0;                                                        // contador para fazer temporizacao
        int T24_run = 0;                                                          // indicacao de tempo ativo
                                                                                  ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_A01 = 100;
        int temperatura_controle_A01 = 100;
        int max_A01 = 999;
        int min_A01 = 50;
        int adj_A01 = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_A02 = 100;
        int temperatura_controle_A02 = 100;
        int max_A02 = 999;
        int min_A02 = 50;
        int adj_A02 = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_A03 = 100;
        int temperatura_controle_A03 = 100;
        int max_A03 = 999;
        int min_A03 = 50;
        int adj_A03 = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_A04 = 100;
        int temperatura_controle_A04 = 100;
        int max_A04 = 999;
        int min_A04 = 50;
        int adj_A04 = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_B01 = 0;
        int bit_B01 = 0;
        int max_B01 = 0;
        int min_B01 = 0;
        int adj_B01 = 0;
        byte OUT_B01 = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_B02 = 0;
        int bit_B02 = 0;
        int max_B02 = 0;
        int min_B02 = 0;
        int adj_B02 = 0;
        byte OUT_B02 = 0;
        ////////////////////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_BM1 = 0;
        int bit_BM1 = 0;
        int max_BM1 = 0;
        int min_BM1 = 0;
        int adj_BM1 = 0;
        int OUT_BM1 = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_BM2 = 0;
        int bit_BM2 = 0;
        int max_BM2 = 0;
        int min_BM2 = 0;
        int adj_BM2 = 0;
        int OUT_BM2 = 0;
        ////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_C01 = 100;
        int contador_C01 = 100;
        int max_C01 = 9999;
        int min_C01 = 0;
        int adj_C01 = 0;
        int contador_contador_C01 = 0;
        byte OUT_CONTADOR_C01 = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_C02 = 100;
        int contador_C02 = 100;
        int max_C02 = 9999;
        int min_C02 = 0;
        int adj_C02 = 0;
        int contador_contador_C02 = 0;
        byte OUT_CONTADOR_C02 = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////////////////
        int padrao_R01 = 100;
        int retardo_R01 = 100;
        int max_R01 = 999;
        int min_R01 = 1;
        int adj_R01 = 0;
        int contador_retardo_R01 = 0;
        byte R01_run = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_R02 = 100;
        int retardo_R02 = 100;
        int max_R02 = 999;
        int min_R02 = 1;
        int adj_R02 = 0;
        int contador_retardo_R02 = 0;
        byte R02_run = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_R03 = 100;
        int retardo_R03 = 100;
        int max_R03 = 999;
        int min_R03 = 1;
        int adj_R03 = 0;
        int contador_retardo_R03 = 0;
        byte R03_run = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_R04 = 100;
        int retardo_R04 = 100;
        int max_R04 = 999;
        int min_R04 = 1;
        int adj_R04 = 0;
        int contador_retardo_R04 = 0;
        byte R04_run = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_R05 = 100;
        int retardo_R05 = 100;
        int max_R05 = 999;
        int min_R05 = 1;
        int adj_R05 = 0;
        int contador_retardo_R05 = 0;
        byte R05_run = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_R06 = 100;
        int retardo_R06 = 100;
        int max_R06 = 999;
        int min_R06 = 1;
        int adj_R06 = 0;
        int contador_retardo_R06 = 0;
        byte R06_run = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_R07 = 100;
        int retardo_R07 = 100;
        int max_R07 = 999;
        int min_R07 = 1;
        int adj_R07 = 0;
        int contador_retardo_R07 = 0;
        byte R07_run = 0;
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        int padrao_R08 = 100;
        int retardo_R08 = 100;
        int max_R08 = 999;
        int min_R08 = 1;
        int adj_R08 = 0;
        int contador_retardo_R08 = 0;
        byte R08_run = 0;
        ////////////////////////////////////////////////////////////////////////////////////



        public void carrega_parametros_da_flash()
        {
            string FileT01 = "Configuracao do tempo 01:;0100;0999;0001;0;";
            string FileT02 = "Configuracao do Tempo 02:;0100;0999;0001;0;"; //todos as propriedades de T02 (default)
            string FileT03 = "Configuracao do Tempo 03:;0100;0999;0001;0;"; //todos as propriedades de T03 (default)
            string FileT04 = "Configuracao do Tempo 04:;0100;0999;0001;0;"; //todos as propriedades de T04 (default)
            string FileT05 = "Configuracao do Tempo 05:;0100;0999;0001;0;"; //todos as propriedades de T05 (default)
            string FileT06 = "Configuracao do Tempo 06:;0100;0999;0001;0;"; //todos as propriedades de T06 (default)
            string FileT07 = "Configuracao do Tempo 07:;0100;0999;0001;0;"; //todos as propriedades de T07 (default)
            string FileT08 = "Configuracao do Tempo 08:;0100;0999;0001;0;"; //todos as propriedades de T08 (default)
            string FileT09 = "Configuracao do Tempo 09:;0100;0999;0001;0;"; //todos as propriedades de T09 (default)
            string FileT10 = "Configuracao do Tempo 10:;0100;0999;0001;0;"; //todos as propriedades de T10 (default)
            string FileT11 = "Configuracao do Tempo 11:;0100;0999;0001;0;"; //todos as propriedades de T11 (default)
            string FileT12 = "Configuracao do Tempo 12:;0100;0999;0001;0;"; //todos as propriedades de T12 (default)
            string FileT13 = "Configuracao do Tempo 13:;0100;0999;0001;0;"; //todos as propriedades de T13 (default)
            string FileT14 = "Configuracao do Tempo 14:;0100;0999;0001;0;"; //todos as propriedades de T14 (default)
            string FileT15 = "Configuracao do Tempo 15:;0100;0999;0001;0;"; //todos as propriedades de T15 (default)
            string FileT16 = "Configuracao do Tempo 16:;0100;0999;0001;0;"; //todos as propriedades de T16 (default)
            string FileT17 = "Configuracao do Tempo 17:;0100;0999;0001;0;"; //todos as propriedades de T17 (default)
            string FileT18 = "Configuracao do Tempo 18:;0100;0999;0001;0;"; //todos as propriedades de T18 (default)
            string FileT19 = "Configuracao do Tempo 19:;0100;0999;0001;0;"; //todos as propriedades de T19 (default)
            string FileT20 = "Configuracao do Tempo 20:;0100;0999;0001;0;"; //todos as propriedades de T20 (default)
            string FileT21 = "Configuracao do Tempo 21:;0100;0999;0001;0;"; //todos as propriedades de T21 (default)
            string FileT22 = "Configuracao do Tempo 22:;0100;0999;0001;0;"; //todos as propriedades de T22 (default)
            string FileT23 = "Configuracao do Tempo 23:;0100;0999;0001;0;"; //todos as propriedades de T23 (default)
            string FileT24 = "Configuracao do Tempo 24:;0100;0999;0001;0;"; //todos as propriedades de T24 (default)

            string FileC01 = "Configuracao Contador  1:;0100;0999;0001;0;"; //todos as propriedades de C01 (default)
            string FileC02 = "Configuracao Contador  2:;0100;0999;0001;0;"; //todos as propriedades de C02 (default)

            string FileB01 = "Habilita funcao        1:;0000;0001;0000;0;"; //todos as propriedades de ADJ01 (default)
            string FileB02 = "Habilita funcao	     2:;0000;0001;0000;0;"; //todos as propriedades de ADJ02 (default)

            string FileBM1 = "Configuracao Bimanual1:1:;0001;0999;0001;0;"; //Bimanual1
            string FileBM2 = "Configuracao Bimanual1:2:;0001;0999;0001;0;"; //Bimanual2

            string FileR01 = "Configuracao Retardos 01:;0100;0999;0001;0;"; //todos as propriedades de R01 (default)
            string FileR02 = "Configuracao Retardos 02:;0100;0999;0001;0;"; //todos as propriedades de R02 (default)
            string FileR03 = "Configuracao Retardos 03:;0100;0999;0001;0;"; //todos as propriedades de R03 (default)
            string FileR04 = "Configuracao Retardos 04:;0100;0999;0001;0;"; //todos as propriedades de R04 (default)
            string FileR05 = "Configuracao Retardos 05:;0100;0999;0001;0;"; //todos as propriedades de R05 (default)
            string FileR06 = "Configuracao Retardos 06:;0100;0999;0001;0;"; //todos as propriedades de R06 (default)
            string FileR07 = "Configuracao Retardos 07:;0100;0999;0001;0;"; //todos as propriedades de R07 (default)
            string FileR08 = "Configuracao Retardos 08:;0100;0999;0001;0;"; //todos as propriedades de R08 (default)


            string FileA01 = "Configuracao Analogica 01;0100;0999;0001;1;"; //todos as propriedades de A01 (default)
            string FileA02 = "Configuracao Analogica 02;0100;0999;0001;1;"; //todos as propriedades de A01 (default)
            string FileA03 = "Configuracao Analogica 03;0100;0999;0001;1;"; //todos as propriedades de A01 (default)
            string FileA04 = "Configuracao Analogica 04;0100;0999;0001;1;"; //todos as propriedades de A01 (default)

            //    linha1      /   linha2
            string FileD00 = "Tela de trabalhoAguardando                                      ";
            string FileD01 = "1                                                               ";
            string FileD02 = "2                                                               ";
            string FileD03 = "3                                                               ";
            string FileD04 = "4                                                               ";
            string FileD05 = "5                                                               ";
            string FileD06 = "6                                                               ";
            string FileD07 = "7                                                               ";
            string FileD08 = "8                                                               ";

            File_Ladder = System.IO.File.ReadAllBytes(Form1.caminho + @"\FileLad.bin");

            PROPRIEDADES_T01 = FileT01.ToCharArray();
            PROPRIEDADES_T02 = FileT02.ToCharArray();
            PROPRIEDADES_T03 = FileT03.ToCharArray();
            PROPRIEDADES_T04 = FileT04.ToCharArray();
            PROPRIEDADES_T05 = FileT05.ToCharArray();
            PROPRIEDADES_T06 = FileT06.ToCharArray();
            PROPRIEDADES_T07 = FileT07.ToCharArray();
            PROPRIEDADES_T08 = FileT08.ToCharArray();
            PROPRIEDADES_T09 = FileT09.ToCharArray();
            PROPRIEDADES_T10 = FileT10.ToCharArray();
            PROPRIEDADES_T11 = FileT11.ToCharArray();
            PROPRIEDADES_T12 = FileT12.ToCharArray();
            PROPRIEDADES_T13 = FileT13.ToCharArray();
            PROPRIEDADES_T14 = FileT14.ToCharArray();
            PROPRIEDADES_T15 = FileT15.ToCharArray();
            PROPRIEDADES_T16 = FileT16.ToCharArray();
            PROPRIEDADES_T17 = FileT17.ToCharArray();
            PROPRIEDADES_T18 = FileT18.ToCharArray();
            PROPRIEDADES_T19 = FileT19.ToCharArray();
            PROPRIEDADES_T20 = FileT20.ToCharArray();
            PROPRIEDADES_T21 = FileT21.ToCharArray();
            PROPRIEDADES_T22 = FileT22.ToCharArray();
            PROPRIEDADES_T23 = FileT23.ToCharArray();
            PROPRIEDADES_T24 = FileT24.ToCharArray();

            PROPRIEDADES_C01 = FileC01.ToCharArray();
            PROPRIEDADES_C02 = FileC02.ToCharArray();

            PROPRIEDADES_B01 = FileB01.ToCharArray();
            PROPRIEDADES_B02 = FileB02.ToCharArray();

            PROPRIEDADES_R01 = FileR01.ToCharArray();
            PROPRIEDADES_R02 = FileR02.ToCharArray();
            PROPRIEDADES_R03 = FileR03.ToCharArray();
            PROPRIEDADES_R04 = FileR04.ToCharArray();
            PROPRIEDADES_R05 = FileR05.ToCharArray();
            PROPRIEDADES_R06 = FileR06.ToCharArray();
            PROPRIEDADES_R07 = FileR07.ToCharArray();
            PROPRIEDADES_R08 = FileR08.ToCharArray();

            PROPRIEDADES_A01 = FileA01.ToCharArray();
            PROPRIEDADES_A02 = FileA02.ToCharArray();
            PROPRIEDADES_A03 = FileA03.ToCharArray();
            PROPRIEDADES_A04 = FileA04.ToCharArray();

            PROPRIEDADES_D00 = FileD00.ToCharArray();
            PROPRIEDADES_D01 = FileD01.ToCharArray();
            PROPRIEDADES_D02 = FileD02.ToCharArray();
            PROPRIEDADES_D03 = FileD03.ToCharArray();
            PROPRIEDADES_D04 = FileD04.ToCharArray();
            PROPRIEDADES_D05 = FileD05.ToCharArray();
            PROPRIEDADES_D06 = FileD06.ToCharArray();
            PROPRIEDADES_D07 = FileD07.ToCharArray();
            PROPRIEDADES_D08 = FileD08.ToCharArray();

            PROPRIEDADES_BM1 = FileBM1.ToCharArray();
            PROPRIEDADES_BM2 = FileBM2.ToCharArray();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            PROPRIEDADES_T01 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT01.txt").ToCharArray();
            PROPRIEDADES_T02 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT02.txt").ToCharArray();
            PROPRIEDADES_T03 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT03.txt").ToCharArray();
            PROPRIEDADES_T04 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT04.txt").ToCharArray();
            PROPRIEDADES_T05 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT05.txt").ToCharArray();
            PROPRIEDADES_T06 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT06.txt").ToCharArray();
            PROPRIEDADES_T07 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT07.txt").ToCharArray();
            PROPRIEDADES_T08 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT08.txt").ToCharArray();
            PROPRIEDADES_T09 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT09.txt").ToCharArray();
            PROPRIEDADES_T10 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT10.txt").ToCharArray();
            PROPRIEDADES_T11 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT11.txt").ToCharArray();
            PROPRIEDADES_T12 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT12.txt").ToCharArray();
            PROPRIEDADES_T13 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT13.txt").ToCharArray();
            PROPRIEDADES_T14 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT14.txt").ToCharArray();
            PROPRIEDADES_T15 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT15.txt").ToCharArray();
            PROPRIEDADES_T16 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT16.txt").ToCharArray();
            PROPRIEDADES_T17 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT17.txt").ToCharArray();
            PROPRIEDADES_T18 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT18.txt").ToCharArray();
            PROPRIEDADES_T19 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT19.txt").ToCharArray();
            PROPRIEDADES_T20 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT20.txt").ToCharArray();
            PROPRIEDADES_T21 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT21.txt").ToCharArray();
            PROPRIEDADES_T22 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT22.txt").ToCharArray();
            PROPRIEDADES_T23 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT23.txt").ToCharArray();
            PROPRIEDADES_T24 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileT24.txt").ToCharArray();

            PROPRIEDADES_C01 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileC01.txt").ToCharArray();
            PROPRIEDADES_C02 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileC02.txt").ToCharArray();

            PROPRIEDADES_B01 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileB01.txt").ToCharArray();
            PROPRIEDADES_B02 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileB02.txt").ToCharArray();

            PROPRIEDADES_R01 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR01.txt").ToCharArray();
            PROPRIEDADES_R02 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR02.txt").ToCharArray();
            PROPRIEDADES_R03 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR03.txt").ToCharArray();
            PROPRIEDADES_R04 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR04.txt").ToCharArray();
            PROPRIEDADES_R05 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR05.txt").ToCharArray();
            PROPRIEDADES_R06 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR06.txt").ToCharArray();
            PROPRIEDADES_R07 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR07.txt").ToCharArray();
            PROPRIEDADES_R08 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileR08.txt").ToCharArray();

            PROPRIEDADES_A01 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileA01.txt").ToCharArray();
            PROPRIEDADES_A02 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileA02.txt").ToCharArray();
            PROPRIEDADES_A03 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileA03.txt").ToCharArray();
            PROPRIEDADES_A04 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileA04.txt").ToCharArray();

            PROPRIEDADES_D00 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD00.txt").ToCharArray();
            PROPRIEDADES_D01 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD01.txt").ToCharArray();
            PROPRIEDADES_D02 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD02.txt").ToCharArray(); 
            PROPRIEDADES_D03 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD03.txt").ToCharArray();
            PROPRIEDADES_D04 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD04.txt").ToCharArray();
            PROPRIEDADES_D05 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD05.txt").ToCharArray();
            PROPRIEDADES_D06 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD06.txt").ToCharArray();
            PROPRIEDADES_D07 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD07.txt").ToCharArray();
            PROPRIEDADES_D08 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileD08.txt").ToCharArray();

            PROPRIEDADES_BM1 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileBM1.txt").ToCharArray();
            PROPRIEDADES_BM2 = System.IO.File.ReadAllText(Form1.caminhoarq + @"\FileBM2.txt").ToCharArray();

        }



        public void converte_dados()
        {
            int M = 0;
            int C = 0;
            int D = 0;
            int U = 0;

            string ErrorDataT = "PROBLEMA DADOS OU ARQUVIO FileT";
            string ErrorDataC = "PROBLEMA DADOS OU ARQUVIO FileC";
            string ErrorDataR = "PROBLEMA DADOS OU ARQUVIO FileR";
            string ErrorDataA = "PROBLEMA DADOS OU ARQUVIO FileA";
            string ErrorDataB = "PROBLEMA DADOS OU ARQUVIO FileB";
            string ErrorDataBM = "PROBLEMA DADOS OU ARQUVIO FileBM";

            //	PROPRIEDADES_xXX[25] [30] [35] [40] [42] devem ser igual a ";"

            //	DEF=[26][27][28][29] - valor default carregado na usb
            //	MAX=[31][32][33][34] - valor maximo que pode ser ajustado
            //	MIN=[36][37][38][39] - valor mínimo que pode ser ajustado
            //	SET=[41]				 		 - tipo de ajuste no setup  (0-somente interno) (1-ajuste usuario) (2-Ajuste avançado)

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //				T E M P O R I Z A D O R E S    D E C I M O S
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T01[25] == ';' && PROPRIEDADES_T01[30] == ';' && PROPRIEDADES_T01[35] == ';' && PROPRIEDADES_T01[40] == ';' && PROPRIEDADES_T01[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T01[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T01[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T01[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T01[29] - 48;              // convete de ascii para inteiro

                tempo_T01 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T01 = tempo_T01;
                padrao_T01 = tempo_T01;

                M = (PROPRIEDADES_T01[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T01[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T01[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T01[34] - 48;              // convete de ascii para inteiro
                max_T01 = M + C + D + U;                                        // CARREGOU
                M = (PROPRIEDADES_T01[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T01[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T01[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T01[39] - 48;              // convete de ascii para inteiro
                min_T01 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T01[41] - 48;                  // convete de ascii para inteiro
                adj_T01 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T02[25] == ';' && PROPRIEDADES_T02[30] == ';' && PROPRIEDADES_T02[35] == ';' && PROPRIEDADES_T02[40] == ';' && PROPRIEDADES_T02[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T02[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T02[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T02[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T02[29] - 48;              // convete de ascii para inteiro
                tempo_T02 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T02 = tempo_T02;
                padrao_T02 = tempo_T02;
                M = (PROPRIEDADES_T02[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T02[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T02[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T02[34] - 48;              // convete de ascii para inteiro
                max_T02 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T02[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T02[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T02[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T02[39] - 48;              // convete de ascii para inteiro
                min_T02 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T02[41] - 48;                  // convete de ascii para inteiro
                adj_T02 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T03[25] == ';' && PROPRIEDADES_T03[30] == ';' && PROPRIEDADES_T03[35] == ';' && PROPRIEDADES_T03[40] == ';' && PROPRIEDADES_T03[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T03[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T03[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T03[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T03[29] - 48;              // convete de ascii para inteiro
                tempo_T03 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T03 = tempo_T03;
                padrao_T03 = tempo_T03;
                M = (PROPRIEDADES_T03[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T03[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T03[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T03[34] - 48;              // convete de ascii para inteiro
                max_T03 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T03[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T03[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T03[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T03[39] - 48;              // convete de ascii para inteiro
                min_T03 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T03[41] - 48;                  // convete de ascii para inteiro
                adj_T03 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T04[25] == ';' && PROPRIEDADES_T04[30] == ';' && PROPRIEDADES_T04[35] == ';' && PROPRIEDADES_T04[40] == ';' && PROPRIEDADES_T04[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T04[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T04[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T04[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T04[29] - 48;              // convete de ascii para inteiro
                tempo_T04 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T04 = tempo_T04;
                padrao_T04 = tempo_T04;
                M = (PROPRIEDADES_T04[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T04[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T04[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T04[34] - 48;              // convete de ascii para inteiro
                max_T04 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T04[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T04[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T04[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T04[39] - 48;              // convete de ascii para inteiro
                min_T04 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T04[41] - 48;                  // convete de ascii para inteiro
                adj_T04 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T05[25] == ';' && PROPRIEDADES_T05[30] == ';' && PROPRIEDADES_T05[35] == ';' && PROPRIEDADES_T05[40] == ';' && PROPRIEDADES_T05[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T05[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T05[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T05[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T05[29] - 48;              // convete de ascii para inteiro
                tempo_T05 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T05 = tempo_T05;
                padrao_T05 = tempo_T05;
                M = (PROPRIEDADES_T05[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T05[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T05[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T05[34] - 48;              // convete de ascii para inteiro
                max_T05 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T05[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T05[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T05[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T05[39] - 48;              // convete de ascii para inteiro
                min_T05 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T05[41] - 48;                  // convete de ascii para inteiro
                adj_T05 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T06[25] == ';' && PROPRIEDADES_T06[30] == ';' && PROPRIEDADES_T06[35] == ';' && PROPRIEDADES_T06[40] == ';' && PROPRIEDADES_T06[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T06[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T06[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T06[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T06[29] - 48;              // convete de ascii para inteiro
                tempo_T06 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T06 = tempo_T06;
                padrao_T06 = tempo_T06;
                M = (PROPRIEDADES_T06[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T06[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T06[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T06[34] - 48;              // convete de ascii para inteiro
                max_T06 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T06[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T06[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T06[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T06[39] - 48;              // convete de ascii para inteiro
                min_T06 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T06[41] - 48;                  // convete de ascii para inteiro
                adj_T06 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T07[25] == ';' && PROPRIEDADES_T07[30] == ';' && PROPRIEDADES_T07[35] == ';' && PROPRIEDADES_T07[40] == ';' && PROPRIEDADES_T07[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T07[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T07[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T07[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T07[29] - 48;              // convete de ascii para inteiro
                tempo_T07 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T07 = tempo_T07;
                padrao_T07 = tempo_T07;
                M = (PROPRIEDADES_T07[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T07[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T07[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T07[34] - 48;              // convete de ascii para inteiro
                max_T07 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T07[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T07[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T07[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T07[39] - 48;              // convete de ascii para inteiro
                min_T07 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T07[41] - 48;                  // convete de ascii para inteiro
                adj_T07 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T08[25] == ';' && PROPRIEDADES_T08[30] == ';' && PROPRIEDADES_T08[35] == ';' && PROPRIEDADES_T08[40] == ';' && PROPRIEDADES_T08[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T08[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T08[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T08[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T08[29] - 48;              // convete de ascii para inteiro
                tempo_T08 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T08 = tempo_T08;
                padrao_T08 = tempo_T08;
                M = (PROPRIEDADES_T08[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T08[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T08[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T08[34] - 48;              // convete de ascii para inteiro
                max_T08 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T08[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T08[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T08[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T08[39] - 48;              // convete de ascii para inteiro
                min_T08 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T08[41] - 48;                  // convete de ascii para inteiro
                adj_T08 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //				T E M P O R I Z A D O R E S    S E G U N D O S
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T09[25] == ';' && PROPRIEDADES_T09[30] == ';' && PROPRIEDADES_T09[35] == ';' && PROPRIEDADES_T09[40] == ';' && PROPRIEDADES_T09[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T09[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T09[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T09[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T09[29] - 48;              // convete de ascii para inteiro
                tempo_T09 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T09 = tempo_T09;
                padrao_T09 = tempo_T09;
                M = (PROPRIEDADES_T09[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T09[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T09[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T09[34] - 48;              // convete de ascii para inteiro
                max_T09 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T09[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T09[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T09[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T09[39] - 48;              // convete de ascii para inteiro
                min_T09 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T09[41] - 48;                  // convete de ascii para inteiro
                adj_T09 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T10[25] == ';' && PROPRIEDADES_T10[30] == ';' && PROPRIEDADES_T10[35] == ';' && PROPRIEDADES_T10[40] == ';' && PROPRIEDADES_T10[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T10[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T10[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T10[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T10[29] - 48;              // convete de ascii para inteiro
                tempo_T10 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T10 = tempo_T10;
                padrao_T10 = tempo_T10;
                M = (PROPRIEDADES_T10[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T10[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T10[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T10[34] - 48;              // convete de ascii para inteiro
                max_T10 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T10[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T10[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T10[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T10[39] - 48;              // convete de ascii para inteiro
                min_T10 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T10[41] - 48;                  // convete de ascii para inteiro
                adj_T10 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T11[25] == ';' && PROPRIEDADES_T11[30] == ';' && PROPRIEDADES_T11[35] == ';' && PROPRIEDADES_T11[40] == ';' && PROPRIEDADES_T11[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T11[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T11[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T11[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T11[29] - 48;              // convete de ascii para inteiro
                tempo_T11 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T11 = tempo_T11;
                padrao_T10 = tempo_T10;
                M = (PROPRIEDADES_T11[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T11[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T11[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T11[34] - 48;              // convete de ascii para inteiro
                max_T11 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T11[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T11[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T11[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T11[39] - 48;              // convete de ascii para inteiro
                min_T11 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T11[41] - 48;                  // convete de ascii para inteiro
                adj_T11 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T12[25] == ';' && PROPRIEDADES_T12[30] == ';' && PROPRIEDADES_T12[35] == ';' && PROPRIEDADES_T12[40] == ';' && PROPRIEDADES_T12[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T12[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T12[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T12[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T12[29] - 48;              // convete de ascii para inteiro
                tempo_T12 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T12 = tempo_T12;
                padrao_T12 = tempo_T12;
                M = (PROPRIEDADES_T12[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T12[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T12[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T12[34] - 48;              // convete de ascii para inteiro
                max_T12 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T12[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T12[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T12[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T12[39] - 48;              // convete de ascii para inteiro
                min_T12 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T12[41] - 48;                  // convete de ascii para inteiro
                adj_T12 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T13[25] == ';' && PROPRIEDADES_T13[30] == ';' && PROPRIEDADES_T13[35] == ';' && PROPRIEDADES_T13[40] == ';' && PROPRIEDADES_T13[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T13[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T13[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T13[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T13[29] - 48;              // convete de ascii para inteiro
                tempo_T13 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T13 = tempo_T13;
                padrao_T13 = tempo_T13;
                M = (PROPRIEDADES_T13[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T13[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T13[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T13[34] - 48;              // convete de ascii para inteiro
                max_T13 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T13[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T13[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T13[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T13[39] - 48;              // convete de ascii para inteiro
                min_T13 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T13[41] - 48;                  // convete de ascii para inteiro
                adj_T13 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T14[25] == ';' && PROPRIEDADES_T14[30] == ';' && PROPRIEDADES_T14[35] == ';' && PROPRIEDADES_T14[40] == ';' && PROPRIEDADES_T14[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T14[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T14[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T14[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T14[29] - 48;              // convete de ascii para inteiro
                tempo_T14 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T14 = tempo_T14;
                padrao_T14 = tempo_T14;
                M = (PROPRIEDADES_T14[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T14[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T14[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T14[34] - 48;              // convete de ascii para inteiro
                max_T14 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T14[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T14[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T14[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T14[39] - 48;              // convete de ascii para inteiro
                min_T14 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T14[41] - 48;                  // convete de ascii para inteiro
                adj_T14 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T15[25] == ';' && PROPRIEDADES_T15[30] == ';' && PROPRIEDADES_T15[35] == ';' && PROPRIEDADES_T15[40] == ';' && PROPRIEDADES_T15[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T15[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T15[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T15[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T15[29] - 48;              // convete de ascii para inteiro
                tempo_T15 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T15 = tempo_T15;
                padrao_T15 = tempo_T15;
                M = (PROPRIEDADES_T15[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T15[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T15[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T15[34] - 48;              // convete de ascii para inteiro
                max_T15 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T15[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T15[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T15[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T15[39] - 48;              // convete de ascii para inteiro
                min_T15 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T15[41] - 48;                  // convete de ascii para inteiro
                adj_T15 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T16[25] == ';' && PROPRIEDADES_T16[30] == ';' && PROPRIEDADES_T16[35] == ';' && PROPRIEDADES_T16[40] == ';' && PROPRIEDADES_T16[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T16[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T16[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T16[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T16[29] - 48;              // convete de ascii para inteiro
                tempo_T16 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T16 = tempo_T16;
                padrao_T16 = tempo_T16;
                M = (PROPRIEDADES_T16[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T16[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T16[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T16[34] - 48;              // convete de ascii para inteiro
                max_T16 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T16[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T16[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T16[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T16[39] - 48;              // convete de ascii para inteiro
                min_T16 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T16[41] - 48;                  // convete de ascii para inteiro
                adj_T16 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //				T E M P O R I Z A D O R E S    M I N U T O S
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T17[25] == ';' && PROPRIEDADES_T17[30] == ';' && PROPRIEDADES_T17[35] == ';' && PROPRIEDADES_T17[40] == ';' && PROPRIEDADES_T17[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T17[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T17[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T17[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T17[29] - 48;              // convete de ascii para inteiro
                tempo_T17 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T17 = tempo_T17;
                padrao_T17 = tempo_T17;
                M = (PROPRIEDADES_T17[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T17[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T17[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T17[34] - 48;              // convete de ascii para inteiro
                max_T17 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T17[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T17[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T17[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T17[39] - 48;              // convete de ascii para inteiro
                min_T17 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T17[41] - 48;                  // convete de ascii para inteiro
                adj_T17 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T18[25] == ';' && PROPRIEDADES_T18[30] == ';' && PROPRIEDADES_T18[35] == ';' && PROPRIEDADES_T18[40] == ';' && PROPRIEDADES_T18[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T18[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T18[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T18[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T18[29] - 48;              // convete de ascii para inteiro
                tempo_T18 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T18 = tempo_T18;
                padrao_T18 = tempo_T18;
                M = (PROPRIEDADES_T18[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T18[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T18[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T18[34] - 48;              // convete de ascii para inteiro
                max_T18 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T18[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T18[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T18[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T18[39] - 48;              // convete de ascii para inteiro
                min_T18 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T18[41] - 48;                  // convete de ascii para inteiro
                adj_T18 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T19[25] == ';' && PROPRIEDADES_T19[30] == ';' && PROPRIEDADES_T19[35] == ';' && PROPRIEDADES_T19[40] == ';' && PROPRIEDADES_T19[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T19[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T19[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T19[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T19[29] - 48;              // convete de ascii para inteiro
                tempo_T19 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T19 = tempo_T19;
                padrao_T19 = tempo_T19;
                M = (PROPRIEDADES_T19[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T19[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T19[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T19[34] - 48;              // convete de ascii para inteiro
                max_T19 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T19[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T19[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T19[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T19[39] - 48;              // convete de ascii para inteiro
                min_T19 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T19[41] - 48;                  // convete de ascii para inteiro
                adj_T19 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T20[25] == ';' && PROPRIEDADES_T20[30] == ';' && PROPRIEDADES_T20[35] == ';' && PROPRIEDADES_T20[40] == ';' && PROPRIEDADES_T20[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T20[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T20[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T20[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T20[29] - 48;              // convete de ascii para inteiro
                tempo_T20 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T20 = tempo_T20;
                padrao_T20 = tempo_T20;
                M = (PROPRIEDADES_T20[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T20[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T20[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T20[34] - 48;              // convete de ascii para inteiro
                max_T20 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T20[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T20[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T20[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T20[39] - 48;              // convete de ascii para inteiro
                min_T20 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T20[41] - 48;                  // convete de ascii para inteiro
                adj_T20 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T21[25] == ';' && PROPRIEDADES_T21[30] == ';' && PROPRIEDADES_T21[35] == ';' && PROPRIEDADES_T21[40] == ';' && PROPRIEDADES_T21[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T21[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T21[27] - 48) * 100;  // convete de ascii para inteiro
                D = (PROPRIEDADES_T21[28] - 48) * 10;   // convete de ascii para inteiro
                U = PROPRIEDADES_T21[29] - 48;      // convete de ascii para inteiro
                tempo_T21 = M + C + D + U;                  // CARREGOU
                contador_tempo_T21 = tempo_T21;
                padrao_T21 = tempo_T21;
                M = (PROPRIEDADES_T21[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T21[32] - 48) * 100;  // convete de ascii para inteiro
                D = (PROPRIEDADES_T21[33] - 48) * 10;   // convete de ascii para inteiro
                U = PROPRIEDADES_T21[34] - 48;      // convete de ascii para inteiro
                max_T21 = M + C + D + U;                    // CARREGOU

                M = (PROPRIEDADES_T21[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T21[37] - 48) * 100;  // convete de ascii para inteiro
                D = (PROPRIEDADES_T21[38] - 48) * 10;   // convete de ascii para inteiro
                U = PROPRIEDADES_T21[39] - 48;      // convete de ascii para inteiro
                min_T21 = M + C + D + U;                    // CARREGOU

                U = PROPRIEDADES_T21[41] - 48;          // convete de ascii para inteiro
                adj_T21 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T22[25] == ';' && PROPRIEDADES_T22[30] == ';' && PROPRIEDADES_T22[35] == ';' && PROPRIEDADES_T22[40] == ';' && PROPRIEDADES_T22[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T22[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T22[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T22[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T22[29] - 48;              // convete de ascii para inteiro
                tempo_T22 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T22 = tempo_T22;
                padrao_T22 = tempo_T22;
                M = (PROPRIEDADES_T22[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T22[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T22[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T22[34] - 48;              // convete de ascii para inteiro
                max_T22 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T22[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T22[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T22[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T22[39] - 48;              // convete de ascii para inteiro
                min_T22 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T22[41] - 48;                  // convete de ascii para inteiro
                adj_T22 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T23[25] == ';' && PROPRIEDADES_T23[30] == ';' && PROPRIEDADES_T23[35] == ';' && PROPRIEDADES_T23[40] == ';' && PROPRIEDADES_T23[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T23[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T23[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T23[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T23[29] - 48;              // convete de ascii para inteiro
                tempo_T23 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T23 = tempo_T23;
                padrao_T23 = tempo_T23;
                M = (PROPRIEDADES_T23[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T23[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T23[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T23[34] - 48;              // convete de ascii para inteiro
                max_T23 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T23[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T23[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T23[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T23[39] - 48;              // convete de ascii para inteiro
                min_T23 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T23[41] - 48;                  // convete de ascii para inteiro
                adj_T23 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_T24[25] == ';' && PROPRIEDADES_T24[30] == ';' && PROPRIEDADES_T24[35] == ';' && PROPRIEDADES_T24[40] == ';' && PROPRIEDADES_T24[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_T24[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T24[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T24[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T24[29] - 48;              // convete de ascii para inteiro
                tempo_T24 = M + C + D + U;                                  // CARREGOU
                contador_tempo_T24 = tempo_T24;
                padrao_T24 = tempo_T24;
                M = (PROPRIEDADES_T24[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T24[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T24[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T24[34] - 48;              // convete de ascii para inteiro
                max_T24 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_T24[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_T24[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_T24[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_T24[39] - 48;              // convete de ascii para inteiro
                min_T24 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_T24[41] - 48;                  // convete de ascii para inteiro
                adj_T24 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataT);
            }



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // B I T  A J U S T A V E L /////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_B01[25] == ';' && PROPRIEDADES_B01[30] == ';' && PROPRIEDADES_B01[35] == ';' && PROPRIEDADES_B01[40] == ';' && PROPRIEDADES_B01[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_B01[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_B01[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_B01[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_B01[29] - 48;          // convete de ascii para inteiro
                bit_B01 = M + C + D + U;                        // CARREGOU
                padrao_B01 = bit_B01;
                M = (PROPRIEDADES_B01[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_B01[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_B01[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_B01[34] - 48;              // convete de ascii para inteiro
                max_B01 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_B01[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_B01[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_B01[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_B01[39] - 48;              // convete de ascii para inteiro
                min_B01 = M + C + D + U;                                        // CARREGOU
                U = PROPRIEDADES_B01[41] - 48;                  // convete de ascii para inteiro
                adj_B01 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataB);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_B02[25] == ';' && PROPRIEDADES_B02[30] == ';' && PROPRIEDADES_B02[35] == ';' && PROPRIEDADES_B02[40] == ';' && PROPRIEDADES_B02[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_B02[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_B02[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_B02[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_B02[29] - 48;          // convete de ascii para inteiro
                bit_B02 = M + C + D + U;                        // CARREGOU
                padrao_B02 = bit_B02;
                M = (PROPRIEDADES_B02[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_B02[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_B02[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_B02[34] - 48;          // convete de ascii para inteiro
                max_B02 = M + C + D + U;                        // CARREGOU

                M = (PROPRIEDADES_B02[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_B02[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_B02[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_B02[39] - 48;          // convete de ascii para inteiro
                min_B02 = M + C + D + U;                        // CARREGOU
                U = PROPRIEDADES_B02[41] - 48;          // convete de ascii para inteiro
                adj_B02 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataB);
            }



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // B I M A N U A I S  A J U S T A V E L /////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_BM1[25] == ';' && PROPRIEDADES_BM1[30] == ';' && PROPRIEDADES_BM1[35] == ';' && PROPRIEDADES_BM1[40] == ';' && PROPRIEDADES_BM1[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_BM1[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_BM1[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_BM1[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_BM1[29] - 48;          // convete de ascii para inteiro
                bit_BM1 = M + C + D + U;                        // CARREGOU
                padrao_BM1 = bit_BM1;
                M = (PROPRIEDADES_BM1[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_BM1[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_BM1[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_BM1[34] - 48;              // convete de ascii para inteiro
                max_BM1 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_BM1[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_BM1[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_BM1[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_BM1[39] - 48;              // convete de ascii para inteiro
                min_BM1 = M + C + D + U;                                        // CARREGOU
                U = PROPRIEDADES_BM1[41] - 48;                  // convete de ascii para inteiro
                adj_BM1 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataBM);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_BM2[25] == ';' && PROPRIEDADES_BM2[30] == ';' && PROPRIEDADES_BM2[35] == ';' && PROPRIEDADES_BM2[40] == ';' && PROPRIEDADES_BM2[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_BM2[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_BM2[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_BM2[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_BM2[29] - 48;          // convete de ascii para inteiro
                bit_BM2 = M + C + D + U;                        // CARREGOU
                padrao_BM2 = bit_BM2;
                M = (PROPRIEDADES_BM2[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_BM2[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_BM2[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_BM2[34] - 48;          // convete de ascii para inteiro
                max_BM2 = M + C + D + U;                        // CARREGOU

                M = (PROPRIEDADES_BM2[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_BM2[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_BM2[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_BM2[39] - 48;          // convete de ascii para inteiro
                min_BM2 = M + C + D + U;                        // CARREGOU
                U = PROPRIEDADES_BM2[41] - 48;          // convete de ascii para inteiro
                adj_BM2 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataBM);
            }


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // C O N T A D O R E S /////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_C01[25] == ';' && PROPRIEDADES_C01[30] == ';' && PROPRIEDADES_C01[35] == ';' && PROPRIEDADES_C01[40] == ';' && PROPRIEDADES_C01[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_C01[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_C01[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_C01[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_C01[29] - 48;              // convete de ascii para inteiro
                contador_C01 = M + C + D + U;                                   // CARREGOU
                padrao_C01 = contador_C01;
                M = (PROPRIEDADES_C01[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_C01[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_C01[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_C01[34] - 48;              // convete de ascii para inteiro
                max_C01 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_C01[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_C01[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_C01[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_C01[39] - 48;              // convete de ascii para inteiro
                min_C01 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_C01[41] - 48;                  // convete de ascii para inteiro
                adj_C01 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataC);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_C02[25] == ';' && PROPRIEDADES_C02[30] == ';' && PROPRIEDADES_C02[35] == ';' && PROPRIEDADES_C02[40] == ';' && PROPRIEDADES_C02[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_C02[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_C02[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_C02[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_C02[29] - 48;              // convete de ascii para inteiro
                contador_C02 = M + C + D + U;                                   // CARREGOU
                padrao_C02 = contador_C02;
                M = (PROPRIEDADES_C02[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_C02[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_C02[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_C02[34] - 48;              // convete de ascii para inteiro
                max_C02 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_C02[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_C02[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_C02[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_C02[39] - 48;              // convete de ascii para inteiro
                min_C02 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_C02[41] - 48;                  // convete de ascii para inteiro
                adj_C02 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataC);
            }


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_A01[25] == ';' && PROPRIEDADES_A01[30] == ';' && PROPRIEDADES_A01[35] == ';' && PROPRIEDADES_A01[40] == ';' && PROPRIEDADES_A01[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {

                M = (PROPRIEDADES_A01[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A01[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A01[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A01[29] - 48;              // convete de ascii para inteiro
                temperatura_controle_A01 = M + C + D + U;
                padrao_A01 = temperatura_controle_A01;

                M = (PROPRIEDADES_A01[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A01[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A01[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A01[34] - 48;              // convete de ascii para inteiro
                max_A01 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_A01[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A01[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A01[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A01[39] - 48;              // convete de ascii para inteiro
                min_A01 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_A01[41] - 48;                  // convete de ascii para inteiro
                adj_A01 = U;

            }
            else
            {
                MessageBox.Show(ErrorDataA);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_A02[25] == ';' && PROPRIEDADES_A02[30] == ';' && PROPRIEDADES_A02[35] == ';' && PROPRIEDADES_A02[40] == ';' && PROPRIEDADES_A02[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {

                M = (PROPRIEDADES_A02[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A02[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A02[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A02[29] - 48;              // convete de ascii para inteiro
                temperatura_controle_A02 = M + C + D + U;
                padrao_A02 = temperatura_controle_A02;

                M = (PROPRIEDADES_A02[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A02[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A02[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A02[34] - 48;              // convete de ascii para inteiro
                max_A02 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_A02[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A02[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A02[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A02[39] - 48;              // convete de ascii para inteiro
                min_A02 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_A02[41] - 48;                  // convete de ascii para inteiro
                adj_A02 = U;

            }
            else
            {
                MessageBox.Show(ErrorDataA);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_A03[25] == ';' && PROPRIEDADES_A03[30] == ';' && PROPRIEDADES_A03[35] == ';' && PROPRIEDADES_A03[40] == ';' && PROPRIEDADES_A03[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {

                M = (PROPRIEDADES_A03[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A03[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A03[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A03[29] - 48;              // convete de ascii para inteiro
                temperatura_controle_A03 = M + C + D + U;
                padrao_A03 = temperatura_controle_A03;

                M = (PROPRIEDADES_A03[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A03[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A03[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A03[34] - 48;              // convete de ascii para inteiro
                max_A03 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_A03[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A03[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A03[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A03[39] - 48;              // convete de ascii para inteiro
                min_A03 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_A03[41] - 48;                  // convete de ascii para inteiro
                adj_A03 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataA);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_A04[25] == ';' && PROPRIEDADES_A04[30] == ';' && PROPRIEDADES_A04[35] == ';' && PROPRIEDADES_A04[40] == ';' && PROPRIEDADES_A04[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {

                M = (PROPRIEDADES_A04[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A04[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A04[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A04[29] - 48;              // convete de ascii para inteiro
                temperatura_controle_A04 = M + C + D + U;
                padrao_A04 = temperatura_controle_A04;

                M = (PROPRIEDADES_A04[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A04[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A04[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A04[34] - 48;              // convete de ascii para inteiro
                max_A04 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_A04[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_A04[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_A04[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_A04[39] - 48;              // convete de ascii para inteiro
                min_A04 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_A04[41] - 48;                  // convete de ascii para inteiro
                adj_A04 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataA);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_R01[25] == ';' && PROPRIEDADES_R01[30] == ';' && PROPRIEDADES_R01[35] == ';' && PROPRIEDADES_R01[40] == ';' && PROPRIEDADES_R01[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_R01[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R01[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R01[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R01[29] - 48;              // convete de ascii para inteiro
                retardo_R01 = M + C + D + U;                                    // CARREGOU
                contador_retardo_R01 = retardo_R01;
                padrao_R01 = retardo_R01;

                M = (PROPRIEDADES_R01[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R01[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R01[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R01[34] - 48;              // convete de ascii para inteiro
                max_R01 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_R01[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R01[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R01[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R01[39] - 48;              // convete de ascii para inteiro
                min_R01 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_R01[41] - 48;                  // convete de ascii para inteiro
                adj_R01 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataR);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_R02[25] == ';' && PROPRIEDADES_R02[30] == ';' && PROPRIEDADES_R02[35] == ';' && PROPRIEDADES_R02[40] == ';' && PROPRIEDADES_R02[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_R02[26] - 48) * 1000;      // convete de ascii para inteiro
                C = (PROPRIEDADES_R02[27] - 48) * 100;       // convete de ascii para inteiro
                D = (PROPRIEDADES_R02[28] - 48) * 10;        // convete de ascii para inteiro
                U = PROPRIEDADES_R02[29] - 48;               // convete de ascii para inteiro
                retardo_R02 = M + C + D + U;                                 // CARREGOU
                contador_retardo_R02 = retardo_R02;
                padrao_R02 = retardo_R02;

                M = (PROPRIEDADES_R02[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R02[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R02[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R02[34] - 48;              // convete de ascii para inteiro
                max_R02 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_R02[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R02[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R02[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R02[39] - 48;              // convete de ascii para inteiro
                min_R02 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_R02[41] - 48;                  // convete de ascii para inteiro
                adj_R02 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataR);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_R03[25] == ';' && PROPRIEDADES_R03[30] == ';' && PROPRIEDADES_R03[35] == ';' && PROPRIEDADES_R03[40] == ';' && PROPRIEDADES_R03[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_R03[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R03[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R03[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R03[29] - 48;              // convete de ascii para inteiro
                retardo_R03 = M + C + D + U;                                    // CARREGOU
                contador_retardo_R03 = retardo_R03;
                padrao_R02 = retardo_R02;

                M = (PROPRIEDADES_R03[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R03[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R03[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R03[34] - 48;              // convete de ascii para inteiro
                max_R03 = M + C + D + U;                                        // CARREGOU
                padrao_R03 = retardo_R03;

                M = (PROPRIEDADES_R03[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R03[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R03[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R03[39] - 48;              // convete de ascii para inteiro
                min_R03 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_R03[41] - 48;                  // convete de ascii para inteiro
                adj_R03 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataR);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_R04[25] == ';' && PROPRIEDADES_R04[30] == ';' && PROPRIEDADES_R04[35] == ';' && PROPRIEDADES_R04[40] == ';' && PROPRIEDADES_R04[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_R04[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R04[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R04[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R04[29] - 48;              // convete de ascii para inteiro
                retardo_R04 = M + C + D + U;                                    // CARREGOU
                contador_retardo_R04 = retardo_R04;
                padrao_R04 = retardo_R04;

                M = (PROPRIEDADES_R04[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R04[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R04[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R04[34] - 48;              // convete de ascii para inteiro
                max_R04 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_R04[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R04[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R04[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R04[39] - 48;              // convete de ascii para inteiro
                min_R04 = M + C + D + U;                                        // CARREGOU
                padrao_R04 = retardo_R04;
                U = PROPRIEDADES_R04[41] - 48;                  // convete de ascii para inteiro
                adj_R04 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataR);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_R05[25] == ';' && PROPRIEDADES_R05[30] == ';' && PROPRIEDADES_R05[35] == ';' && PROPRIEDADES_R05[40] == ';' && PROPRIEDADES_R05[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_R05[26] - 48) * 1000;         // convete de ascii para inteiro
                C = (PROPRIEDADES_R05[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R05[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R05[29] - 48;          // convete de ascii para inteiro
                retardo_R05 = M + C + D + U;                    // CARREGOU
                contador_retardo_R05 = retardo_R05;
                padrao_R04 = retardo_R04;

                M = (PROPRIEDADES_R05[31] - 48) * 1000;         // convete de ascii para inteiro
                C = (PROPRIEDADES_R05[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R05[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R05[34] - 48;              // convete de ascii para inteiro
                max_R05 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_R05[36] - 48) * 1000;         // convete de ascii para inteiro
                C = (PROPRIEDADES_R05[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R05[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R05[39] - 48;          // convete de ascii para inteiro
                min_R05 = M + C + D + U;                        // CARREGOU

                U = PROPRIEDADES_R05[41] - 48;              // convete de ascii para inteiro
                adj_R05 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataR);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_R06[25] == ';' && PROPRIEDADES_R06[30] == ';' && PROPRIEDADES_R06[35] == ';' && PROPRIEDADES_R06[40] == ';' && PROPRIEDADES_R06[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_R06[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R06[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R06[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R06[29] - 48;              // convete de ascii para inteiro
                retardo_R06 = M + C + D + U;                                    // CARREGOU
                contador_retardo_R06 = retardo_R06;
                padrao_R06 = retardo_R06;
                M = (PROPRIEDADES_R06[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R06[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R06[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R06[34] - 48;              // convete de ascii para inteiro
                max_R06 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_R06[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R06[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R06[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R06[39] - 48;              // convete de ascii para inteiro
                min_R06 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_R06[41] - 48;                  // convete de ascii para inteiro
                adj_R06 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataR);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_R07[25] == ';' && PROPRIEDADES_R07[30] == ';' && PROPRIEDADES_R07[35] == ';' && PROPRIEDADES_R07[40] == ';' && PROPRIEDADES_R07[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_R07[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R07[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R07[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R07[29] - 48;              // convete de ascii para inteiro
                retardo_R07 = M + C + D + U;                                    // CARREGOU
                contador_retardo_R07 = retardo_R07;
                padrao_R07 = retardo_R07;
                M = (PROPRIEDADES_R07[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R07[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R07[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R07[34] - 48;              // convete de ascii para inteiro
                max_R07 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_R07[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R07[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R07[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R07[39] - 48;              // convete de ascii para inteiro
                min_R07 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_R07[41] - 48;                  // convete de ascii para inteiro
                adj_R07 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataR);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PROPRIEDADES_R08[25] == ';' && PROPRIEDADES_R08[30] == ';' && PROPRIEDADES_R08[35] == ';' && PROPRIEDADES_R08[40] == ';' && PROPRIEDADES_R08[42] == ';') // Faz a verificacao de integridade de dados da USB//
            {
                M = (PROPRIEDADES_R08[26] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R08[27] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R08[28] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R08[29] - 48;              // convete de ascii para inteiro
                retardo_R08 = M + C + D + U;                // CARREGOU
                contador_retardo_R08 = retardo_R08;
                padrao_R08 = retardo_R08;
                M = (PROPRIEDADES_R08[31] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R08[32] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R08[33] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R08[34] - 48;              // convete de ascii para inteiro
                max_R08 = M + C + D + U;                                        // CARREGOU

                M = (PROPRIEDADES_R08[36] - 48) * 1000;     // convete de ascii para inteiro
                C = (PROPRIEDADES_R08[37] - 48) * 100;      // convete de ascii para inteiro
                D = (PROPRIEDADES_R08[38] - 48) * 10;       // convete de ascii para inteiro
                U = PROPRIEDADES_R08[39] - 48;              // convete de ascii para inteiro
                min_R08 = M + C + D + U;                                        // CARREGOU

                U = PROPRIEDADES_R08[41] - 48;                  // convete de ascii para inteiro
                adj_R08 = U;
            }
            else
            {
                MessageBox.Show(ErrorDataR);
            }
        }

        public void lcd_ihm_putc(char[] t)
        {
            char[] ch = new char[5];
            string str = "     ";

            int i;
            int k;
            int j;
            int x;
            int TECLA_EXIT = 0;
            char[] d = new char[35];


            for (i = 0; i < 64; i++)
            {
                p[i] = ' ';
            }

            j = t.Length;
            if (j > 64) j = 64;
            for (i = 0; i < j; i++)
            {
                p[i] = t[i];
            }
            j--;
            i = 0;
            k = 0;
            x = 0;
            TECLA_EXIT = 1;
            while (TECLA_EXIT == 1)
            {
                switch (p[i])
                {
                    case '\r':
                        d[k] = p[i];

                        if (i < j) { i++; }
                        if (k < 34) { k++; }

                        d[k] = p[i];
                        if (p[i] == '\n')
                        {
                            x++;
                            if (x == 2) TECLA_EXIT = 0;
                        }
                        break;

                    case '#':
                        if (i < j) { i++; }
                        ch[0] = p[i];
                        if (i < j) { i++; }
                        ch[1] = p[i];
                        if (i < j) { i++; }
                        ch[2] = p[i];
                        if (i < j) { i++; }
                        ch[3] = p[i];
                        if (i < j) { i++; }
                        ch[4] = p[i];



                        str = ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString();
                        if (i < (j + 1)) { i++; }
                        switch (str)
                        {
                            case "ALLIN": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ALLOU": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENA08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "ENF01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ENF08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "EBP01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBP08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "EBN01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "EBN08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "SNA01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNA08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "SNF01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SNF08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "SET01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "SET08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "RES01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "RES08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "CAX01": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX02": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX03": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX04": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX05": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX06": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX07": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX08": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "CAX09": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX10": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX11": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX12": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX13": d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CAX14": d[k] = 'X'; if (k < 34) { k++; } break;

                            case "CON01": d[k] = 'X'; if (k < 34) { if (k < 34) { k++; } } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "CON02": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            case "TMP01": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP02": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP03": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP04": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP05": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP06": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP07": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP08": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = '.'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            case "TMP09": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP10": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP11": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP12": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP13": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP14": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP15": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP16": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            case "TMP17": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP18": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP19": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP20": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP21": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP22": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP23": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "TMP24": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = ':'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            case "ANG01": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ANG02": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ANG03": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;
                            case "ANG04": d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } d[k] = 'X'; if (k < 34) { k++; } break;

                            default:
                                TECLA_EXIT = 0;
                                break;
                        }

                        ////verifica se não estourou limites da matriz ou do display
                        if (i >= 63 || k >= 34)
                        {
                            TECLA_EXIT = 0;
                        }
                        break;


                    default:
                        d[k] = p[i];
                        i++;
                        k++;
                        if (i >= 63 || k >= 34)
                        {
                            TECLA_EXIT = 0;
                        }
                        break;

                }
            }


            TECLA_EXIT = 1;
            i = 0;
            k = 0;
            while (TECLA_EXIT == 1)
            {

                ///////////////////////LINHA 1////////////////////////////
                switch (i)
                {
                    case 0:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_0.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 1:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_1.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 2:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_2.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 3:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_3.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 4:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_4.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 5:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_5.Text = d[k].ToString();
                            k++;
                        }
                        break;


                    case 6:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_6.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 7:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_7.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 8:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_8.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 9:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_9.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 10:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_10.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 11:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_11.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 12:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_12.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 13:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_13.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 14:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_14.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 15:
                        if (d[i] == '\r')
                        {
                            i = 15;
                            k = k + 2;
                        }
                        else
                        {
                            lb_15.Text = d[k].ToString();
                            k++;
                        }
                        break;
                    ///////////////////////LINHA 2////////////////////////////
                    case 16:
                        if (d[i] == '\r')
                        {
                            //TECLA_EXIT = 0;
                            k = k + 2;
                            lb_16.Text = d[k].ToString();
                            k++;
                        }
                        else
                        {
                            lb_16.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 17:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_17.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 18:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_18.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 19:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_19.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 20:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_20.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 21:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_21.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 22:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_22.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 23:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_23.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 24:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_24.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 25:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_25.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 26:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_26.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 27:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_27.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 28:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_28.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 29:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_29.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 30:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_30.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    case 31:
                        if (d[i] == '\r')
                        {
                            TECLA_EXIT = 0;
                        }
                        else
                        {
                            lb_31.Text = d[k].ToString();
                            k++;
                        }
                        break;

                    default:
                        TECLA_EXIT = 0;
                        break;
                }
                i++;

            }

        }

        void scan_IHM()
        {
            if (P_100MS_LCD)
            {
                P_100MS_LCD = false;

                if (D00IE == 1 && D01IE == 0 && D02IE == 0 && D03IE == 0 && D04IE == 0 && D05IE == 0 && D06IE == 0 && D07IE == 0 && D08IE == 0)
                {
                    D00IE = 0;
                    lcd_ihm_putc(PROPRIEDADES_D00);
                }

                if (D01IE == 1)
                {
                    D01IE = 0;
                    D00IE = 1;
                    lcd_ihm_putc(PROPRIEDADES_D01);
                }

                if (D02IE == 1)
                {
                    D02IE = 0;
                    D00IE = 1;
                    lcd_ihm_putc(PROPRIEDADES_D02);
                }

                if (D03IE == 1)
                {
                    D03IE = 0;
                    D00IE = 1;
                    lcd_ihm_putc(PROPRIEDADES_D03);
                }

                if (D04IE == 1)
                {
                    D04IE = 0;
                    D00IE = 1;
                    lcd_ihm_putc(PROPRIEDADES_D04);
                }

                if (D05IE == 1)
                {
                    D05IE = 0;
                    D00IE = 1;
                    lcd_ihm_putc(PROPRIEDADES_D05);
                }

                if (D06IE == 1)
                {
                    D06IE = 0;
                    D00IE = 1;
                    lcd_ihm_putc(PROPRIEDADES_D06);
                }

                if (D07IE == 1)
                {
                    D07IE = 0;
                    D00IE = 1;
                    lcd_ihm_putc(PROPRIEDADES_D07);
                }

                if (D08IE == 1)
                {
                    D08IE = 0;
                    D00IE = 1;
                    lcd_ihm_putc(PROPRIEDADES_D08);
                }

            }
        }

        public void carrega_matriz()// Carrega da matriz de edição para a matriz principal
        {
            int prof = 0;
            for (lin = 0; lin < linhas; lin++)
            {
                for (col = 0; col < colunas; col++)
                {
                    matriz[lin, col, 0] = File_Ladder[prof];
                    if (prof < 4500) prof++;
                }
            }
        }

        //inicia coluna de alimentação do ladder////
        void inicia_matriz()// Limpa a matriz file_ladder e matriz para adição de um novo programa
        {
            //////////coluna0 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 0, 0] = 0;
            }

            //////////coluna0 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 0, 0] = 1;
                matriz[lin, 0, 1] = 1;
                matriz[lin, 0, 2] = 1;
            }
            //////////coluna2 CONTATO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 1, 0] = 1;
                matriz[lin, 1, 1] = 0;
                matriz[lin, 1, 2] = 0;
            }

            //////////coluna3 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 2, 0] = 1;
                matriz[lin, 2, 1] = 0;
                matriz[lin, 2, 2] = 0;
            }

            //////////coluna4 CONTATO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 3, 0] = 1;
                matriz[lin, 3, 1] = 0;
                matriz[lin, 3, 2] = 0;
            }

            //////////coluna5 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 4, 0] = 1;
                matriz[lin, 4, 1] = 0;
                matriz[lin, 4, 2] = 0;
            }

            //////////coluna6 CONTATO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 5, 0] = 1;
                matriz[lin, 5, 1] = 0;
                matriz[lin, 5, 2] = 0;
            }

            //////////coluna7 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 6, 0] = 1;
                matriz[lin, 6, 1] = 0;
                matriz[lin, 6, 2] = 0;
            }

            //////////coluna8 CONTATO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 7, 0] = 1;
                matriz[lin, 7, 1] = 0;
                matriz[lin, 7, 2] = 0;
            }

            //////////coluna9 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 8, 0] = 1;
                matriz[lin, 8, 1] = 0;
                matriz[lin, 8, 2] = 0;
            }

            //////////coluna10 CONTATO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 9, 0] = 1;
                matriz[lin, 9, 1] = 0;
                matriz[lin, 9, 2] = 0;
            }

            //////////coluna11 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 10, 0] = 1;
                matriz[lin, 10, 1] = 0;
                matriz[lin, 10, 2] = 0;
            }

            //////////coluna12 CONTATO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 11, 0] = 1;
                matriz[lin, 11, 1] = 0;
                matriz[lin, 11, 2] = 0;
            }
            //////////coluna13 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 12, 0] = 1;
                matriz[lin, 12, 1] = 0;
                matriz[lin, 12, 2] = 0;
            }
            //////////coluna14 CONTATO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 13, 0] = 1;
                matriz[lin, 13, 1] = 0;
                matriz[lin, 13, 2] = 0;
            }
            //////////coluna15 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 14, 0] = 1;
                matriz[lin, 14, 1] = 0;
                matriz[lin, 14, 2] = 0;
            }
            //////////coluna16 CONTATO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 15, 0] = 1;
                matriz[lin, 15, 1] = 0;
                matriz[lin, 15, 2] = 0;
            }
            //////////coluna17 FUNCAO///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 16, 0] = 1;
                matriz[lin, 16, 1] = 0;
                matriz[lin, 16, 2] = 0;
            }
            //////////coluna18 SAIDA///
            for (lin = 0; lin < linhas; lin++)
            {
                matriz[lin, 17, 0] = 0;
                matriz[lin, 17, 1] = 0;
                matriz[lin, 17, 2] = 0;
            }


            return;
        }

        void scan_matriz()
        {

            col = 0;
            lin = 0;
            Aux_de_linha = 0;
            var_funcao = 0;
            funcao = 0;
            contato = 0;
            coluna = 0;
            indice = 0;
            par_impar = 0;

            for (lin = 0; lin < linhas; lin++)
            {
                for (col = 1; col < colunas; col++) // Parte de 1 porque a coluna 0 é a alimentação portanto já está energizada
                {
                    contato = (matriz[lin, col, 0]);
                    if (contato > vazio)                    // Testa se o contato existe e executa ou então pula a posição
                    {
                        coluna = (colunas - 1);
                        if (coluna == col)                  // Testa se é a coluna de acionamento das saídas
                        {
                            indice = matriz[lin, col - 1, 2];
                            if (indice == 1)            // Testa se o índice da coluna anterior tem tensão
                            {
                                //////////FAZ ACIONAMENTO DAS SAIDAS
                                funcao = matriz[lin, col, 0];
                                switch (funcao) // Separa e aciona os índices do timer ou dos outros tipos
                                {

                                    ///////////////SAIDAS///////////////
                                    case 52:// S1
                                        matriz[lin, col, 1] = 1;    // Aciona o índice da coluna atual
                                        Q1 = 1;
                                        OUT_S1 = 1;
                                        break;

                                    case 54:// S2
                                        matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        Q2 = 1;
                                        OUT_S2 = 1;
                                        break;

                                    case 56:// S3
                                        matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        Q3 = 1;
                                        OUT_S3 = 1;
                                        break;

                                    case 58:// S4
                                        matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        Q4 = 1;
                                        OUT_S4 = 1;
                                        break;

                                    case 60:// S5
                                        matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        Q5 = 1;
                                        OUT_S5 = 1;
                                        break;

                                    case 62:// S6
                                        matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        Q6 = 1;
                                        OUT_S6 = 1;
                                        break;

                                    case 64:// S7
                                        matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        Q7 = 1;
                                        OUT_S7 = 1;
                                        break;

                                    case 66:// S8
                                        matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        Q8 = 1;
                                        OUT_S8 = 1;
                                        break;

                                    /////////////// BOBINAS S1 SET = 0//////////////////////////////
                                    case 68:// SET_S1
                                        matriz[lin, col, 1] = 1;                                                        // Aciona o índice da coluna atual
                                        Q1 = 1;
                                        OUT_S1 = 1;
                                        break;

                                    case 69:// RESET_S1
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q1 = 0;
                                        OUT_S1 = 0;
                                        break;
                                    //////////////////////////////////////////////////////
                                    /////////////// BOBINAS S2 SET = 0//////////////////////////////
                                    case 70:// SET_S2
                                        matriz[lin, col, 1] = 1;                                                        // Aciona o índice da coluna atual
                                        Q2 = 1;
                                        OUT_S2 = 1;
                                        break;

                                    case 71:// RESET_S2
                                        matriz[lin, col, 1] = 0;                                                        // Aciona o índice da coluna atual
                                        Q2 = 0;
                                        OUT_S2 = 0;
                                        break;
                                    //////////////////////////////////////////////////////


                                    ////////////// BOBINAS S3 SET = 0//////////////////////////////
                                    case 72:// SET_S3
                                        matriz[lin, col, 1] = 1;                                                        // Aciona o índice da coluna atual
                                        Q3 = 1;
                                        OUT_S3 = 1;
                                        break;

                                    case 73:// RESET_S3
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q3 = 0;
                                        OUT_S3 = 0;
                                        break;
                                    //////////////////////////////////////////////////////


                                    ////////////// BOBINAS S4 SET = 0//////////////////////////////
                                    case 74:// SET_S4
                                        matriz[lin, col, 1] = 1;                                                        // Aciona o índice da coluna atual
                                        Q4 = 1;
                                        OUT_S4 = 1;
                                        break;

                                    case 75:// RESET_S4
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q4 = 0;
                                        OUT_S4 = 0;
                                        break;
                                    //////////////////////////////////////////////////////

                                    /////////////// BOBINAS S5 SET = 0//////////////////////////////
                                    case 76:// SET_S5
                                        matriz[lin, col, 1] = 1;                                                        // Aciona o índice da coluna atual
                                        Q5 = 1;
                                        OUT_S5 = 1;
                                        break;

                                    case 77:// RESET_S5
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q5 = 0;
                                        OUT_S5 = 0;
                                        break;
                                    //////////////////////////////////////////////////////

                                    /////////////// BOBINAS S6 SET = 0//////////////////////////////
                                    case 78:// SET_S6
                                        matriz[lin, col, 1] = 1;                                                        // Aciona o índice da coluna atual
                                        Q6 = 1;
                                        OUT_S6 = 1;
                                        break;

                                    case 79:// RESET_S6
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q6 = 0;
                                        OUT_S6 = 0;
                                        break;
                                    //////////////////////////////////////////////////////

                                    /////////////// BOBINAS S7 SET = 0//////////////////////////////
                                    case 80:// SET_S7
                                        matriz[lin, col, 1] = 1;                                                        // Aciona o índice da coluna atual
                                        Q7 = 1;
                                        OUT_S7 = 1;
                                        break;

                                    case 81:// RESET_S7
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q7 = 0;
                                        OUT_S7 = 0;
                                        break;
                                    //////////////////////////////////////////////////////

                                    /////////////// BOBINAS S8 SET = 0//////////////////////////////
                                    case 82:// SET_S8
                                        matriz[lin, col, 1] = 1;                                                        // Aciona o índice da coluna atual
                                        Q8 = 1;
                                        OUT_S8 = 1;
                                        break;

                                    case 83:// RESET_S8
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q7 = 0;
                                        OUT_S8 = 0;
                                        break;


                                    //  CONTATOS AUXILIARES
                                    //////////////////////////////////////////////////////
                                    case 100:// CONTATO AUX1 NA
                                        M01IE = 1;
                                        matriz[lin,col,1] = M01IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 102:// CONTATO AUX1 NA
                                        M02IE = 1;
                                        matriz[lin,col,1] = M02IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 104:// CONTATO AUX3
                                        M03IE = 1;
                                        matriz[lin,col,1] = M03IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 106:// CONTATO AUX4
                                        M04IE = 1;
                                        matriz[lin,col,1] = M04IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 108:// CONTATO AUX5
                                        M05IE = 1;
                                        matriz[lin,col,1] = M05IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 109:// CONTATO AUX6
                                        M06IE = 1;
                                        matriz[lin,col,1] = M06IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 110:// CONTATO AUX7
                                        M07IE = 1;
                                        matriz[lin,col,1] = M07IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 111:// CONTATO AUX8
                                        M08IE = 1;
                                        matriz[lin,col,1] = M08IE;// Aciona o índice da coluna atual
                                        break;


                                    ////////////////CONTATOS SET_RESET//////////////////////////////////

                                    ////// CONTATO AUX9 SET_RESET////////
                                    case 112:
                                        M09IE = 1;
                                        matriz[lin,col,1] = M09IE;// Aciona o índice da coluna atual
                                        break;
                                    case 113://
                                        M09IE = 0;
                                        matriz[lin,col,1] = M09IE;// Aciona o índice da coluna atual
                                        break;
                                    //////////////////////////////////////////////////////

                                    ////// CONTATO AUX10 SET_RESET////////
                                    case 40:
                                        M10IE = 1;
                                        matriz[lin,col,1] = M10IE;// Aciona o índice da coluna atual
                                        break;
                                    case 41:
                                        M10IE = 0;
                                        matriz[lin,col,1] = M10IE;// Aciona o índice da coluna atual
                                        break;

                                    ////////////CONTATO AUX11 SET_RESET//////////////////////////////////////////
                                    case 42://
                                        M11IE = 1;
                                        matriz[lin,col,1] = M11IE;// Aciona o índice da coluna atual
                                        break;
                                    case 43:// CONTATO AUX14
                                        M11IE = 0;
                                        matriz[lin,col,1] = M11IE;// Aciona o índice da coluna atual
                                        break;
                                    //////////////////////////////////////////////////////

                                    ////////////CONTATO AUX12 SET_RESET//////////////////////////////////////////
                                    case 44://
                                        M12IE = 1;
                                        matriz[lin,col,1] = M12IE;// Aciona o índice da coluna atual
                                        break;
                                    case 45:
                                        M12IE = 0;
                                        matriz[lin,col,1] = M12IE;// Aciona o índice da coluna atual
                                        break;
                                    //////////////////////////////////////////////////////

                                    ////////////CONTATO AUX13 SET_RESET//////////////////////////////////////////
                                    case 46://
                                        M13IE = 1;
                                        matriz[lin,col,1] = M13IE;// Aciona o índice da coluna atual
                                        break;
                                    case 47:
                                        M13IE = 0;
                                        matriz[lin,col,1] = M13IE;// Aciona o índice da coluna atual
                                        break;
                                    //////////////////////////////////////////////////////

                                    ////////////CONTATO AUX13 SET_RESET//////////////////////////////////////////
                                    case 48://
                                        M14IE = 1;
                                        matriz[lin,col,1] = M14IE;// Aciona o índice da coluna atual
                                        break;
                                    case 49:
                                        M14IE = 0;
                                        matriz[lin,col,1] = M14IE;// Aciona o índice da coluna atual
                                        break;
                                    //////////////////////////////////////////////////////

                                    //////////////////////////////////////////////////////
                                    case 114:
                                        if (C01IE == 0)
                                        {
                                            C01IE = 1;
                                            contador_contador_C01 = contador_contador_C01 + 1;
                                        }
                                        break;
                                    //////////////////////////////////////////////////////

                                    //////////////////////////////////////////////////////
                                    case 115:
                                        if (C02IE == 0)
                                        {
                                            C02IE = 1;
                                            contador_contador_C02 = contador_contador_C02 + 1;
                                        }
                                        break;
                                    //////////////////////////////////////////////////////


                                    ///////////////TIMERS///////////////
                                    //////////////Decimos///////////////
                                    case 124:// TMR1
                                        T01IE = 1;
                                        if (contador_tempo_T01 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                    break;

                                    case 125:// TMR2
                                        T02IE = 1;
                                        if (contador_tempo_T02 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 126:// TMR3
                                        T03IE = 1;
                                        if (contador_tempo_T03 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 127:// TMR4
                                        T04IE = 1;
                                        if (contador_tempo_T04 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 128:// TMR5
                                        T05IE = 1;
                                        if (contador_tempo_T05 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 129:// TMR6
                                        T06IE = 1;
                                        if (contador_tempo_T06 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 130:// TMR7
                                        T07IE = 1;
                                        if (contador_tempo_T07 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 131:// TMR8
                                        T08IE = 1;
                                        if (contador_tempo_T08 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }

                                        break;
                                    /////////////////////////////////
                                    //////////////segundos///////////////
                                    case 132: // TMR9
                                        T09IE = 1;
                                        if (contador_tempo_T09 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 133:// TMR10
                                        T10IE = 1;
                                        if (contador_tempo_T10 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 134:// TMR11
                                        T11IE = 1;
                                        if (contador_tempo_T11 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 135:// TMR12
                                        T12IE = 1;
                                        if (contador_tempo_T12 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 136:// TMR13
                                        T13IE = 1;
                                        if (contador_tempo_T13 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 137:// TMR14
                                        T14IE = 1;
                                        if (contador_tempo_T14 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 138:// TMR15
                                        T15IE = 1;
                                        if (contador_tempo_T15 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 139:// TMR16
                                        T16IE = 1;
                                        if (contador_tempo_T16 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;
                                    /////////////////////////////////

                                    //////////////segundos///////////////
                                    case 140:// TMR17
                                        T17IE = 1;
                                        if (contador_tempo_T17 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 141:// TMR18
                                        T18IE = 1;
                                        if (contador_tempo_T18 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 142:// TMR19
                                        T19IE = 1;
                                        if (contador_tempo_T19 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 143:// TMR20
                                        T20IE = 1;
                                        if (contador_tempo_T20 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 144:// TMR21
                                        T21IE = 1;
                                        if (contador_tempo_T21 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 145:// TMR22
                                        T22IE = 1;
                                        if (contador_tempo_T22 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 146:// TMR23
                                        T23IE = 1;
                                        if (contador_tempo_T23 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    case 147:// TMR24
                                        T24IE = 1;
                                        if (contador_tempo_T24 > 0)
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 1;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 1;// Aciona o índice da coluna atual
                                        }
                                        else
                                        {
                                            Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                            matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        }
                                        break;

                                    /////////MENSAGENS////////////////////////
                                    case 148: D01IE = 1; break;
                                    case 149: D02IE = 1; break;
                                    case 150: D03IE = 1; break;
                                    case 151: D04IE = 1; break;
                                    case 152: D05IE = 1; break;
                                    case 153: D06IE = 1; break;
                                    case 154: D07IE = 1; break;
                                    case 155: D08IE = 1; break;

                                    ///////////////////NAO ACHOU COMANDO VALIDO OU É VAZIO
                                    default:
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// Liga o índice na matriz virtual
                                        break;
                                }
                            }
                            else// Não tem tensão
                            {
                                funcao = matriz[lin, col, 0];
                                switch (funcao) //
                                {
                                    ///////////////SAIDAS///////////////
                                    case 52:// S1
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q1 = 0;
                                        OUT_S1 = 0;
                                        break;

                                    case 54:// S2
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q2 = 0;
                                        OUT_S2 = 0;
                                        break;

                                    case 56:// S3
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q3 = 0;
                                        OUT_S3 = 0;
                                        break;

                                    case 58:// S4
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q4 = 0;
                                        OUT_S4 = 0;
                                        break;

                                    case 60:// S5
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q5 = 0;
                                        OUT_S5 = 0;
                                        break;

                                    case 62:// S6
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q6 = 0;
                                        OUT_S6 = 0;
                                        break;

                                    case 64:// S7
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q7 = 0;
                                        OUT_S7 = 0;
                                        break;

                                    case 66:// S8
                                        matriz[lin, col, 1] = 0;// Aciona o índice da coluna atual
                                        Q8 = 0;
                                        OUT_S8 = 0;
                                        break;

                                    /////////TIMERS/////////////

                                    //  CONTATOS AUXILIARES
                                    //////////////////////////////////////////////////////
                                    case 100:// CONTATO AUX1
                                        M01IE = 0;
                                        matriz[lin, col, 1] = M01IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 101:// CONTATO AUX2
                                        M02IE = 0;
                                        matriz[lin, col, 1] = M02IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 102:// CONTATO AUX3
                                        M03IE = 0;
                                        matriz[lin, col, 1] = M03IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 103:// CONTATO AUX4
                                        M04IE = 0;
                                        matriz[lin, col, 1] = M04IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 104:// CONTATO AUX5
                                        M05IE = 0;
                                        matriz[lin, col, 1] = M05IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 105:// CONTATO AUX6
                                        M06IE = 0;
                                        matriz[lin, col, 1] = M06IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 106:// CONTATO AUX7
                                        M07IE = 0;
                                        matriz[lin, col, 1] = M07IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 107:// CONTATO AUX8
                                        M08IE = 0;
                                        matriz[lin, col, 1] = M08IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 108:// CONTATO AUX9
                                        M09IE = 0;
                                        matriz[lin, col, 1] = M09IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 109:// CONTATO AUX10
                                        M10IE = 0;
                                        matriz[lin, col, 1] = M10IE;// Aciona o índice da coluna atual
                                        break;
                                    //////////////////////////////////////////////////////
                                    case 110:// CONTATO AUX11
                                        M11IE = 0;
                                        matriz[lin, col, 1] = M11IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 111:// CONTATO AUX12
                                        M12IE = 0;
                                        matriz[lin, col, 1] = M12IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 112:// CONTATO AUX13
                                        M13IE = 0;
                                        matriz[lin, col, 1] = M13IE;// Aciona o índice da coluna atual
                                        break;

                                    //////////////////////////////////////////////////////
                                    case 113:// CONTATO AUX14
                                        M14IE = 0;
                                        matriz[lin, col, 1] = M14IE;// Aciona o índice da coluna atual
                                        break;
                                    //////////////////////////////////////////////////////


                                    //////////////////////////////////////////////////////
                                    case 114:
                                        C01IE = 0;
                                        break;
                                    //////////////////////////////////////////////////////

                                    //////////////////////////////////////////////////////
                                    case 115:
                                        C02IE = 0;
                                        break;
                                    //////////////////////////////////////////////////////


                                    /////////Decimos/////////////
                                    case 124:// TMR1
                                        T01IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T01 = tempo_T01;
                                        break;
                                    case 125:// TMR2
                                        T02IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T02 = tempo_T02;
                                        break;
                                    case 126:// TMR3
                                        T03IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T03 = tempo_T03;
                                        break;
                                    case 127:// TMR4
                                        T04IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T04 = tempo_T04;
                                        break;
                                    case 128:// TMR5
                                        T05IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T05 = tempo_T05;
                                        break;
                                    case 129:// TMR6
                                        T06IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T06 = tempo_T06;
                                        break;
                                    case 130:// TMR7
                                        T07IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T07 = tempo_T07;
                                        break;
                                    case 131:// TMR8
                                        T08IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T08 = tempo_T08;
                                        break;

                                    /////////////SEGUNDOS//////////////
                                    case 132:// TMR9
                                        T09IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T09 = tempo_T09;
                                        break;
                                    case 133:// TMR10
                                        T10IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T10 = tempo_T10;
                                        break;
                                    case 134:// TMR11
                                        T11IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T11 = tempo_T11;
                                        break;
                                    case 135:// TMR12
                                        T12IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T12 = tempo_T12;
                                        break;
                                    case 136:// TMR13
                                        T13IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T13 = tempo_T13;
                                        break;
                                    case 137:// TMR14
                                        T14IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T14 = tempo_T14;
                                        break;
                                    case 138:// TMR15
                                        T15IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T15 = tempo_T15;
                                        break;
                                    case 139:// TMR16
                                        T16IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T16 = tempo_T16;
                                        break;

                                    /////////////MINUTOS//////////////
                                    case 140:// TMR17
                                        T17IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T17 = tempo_T17;
                                        break;
                                    case 141:// TMR18
                                        T18IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T18 = tempo_T18;
                                        break;
                                    case 142:// TMR19
                                        T19IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T19 = tempo_T19;
                                        break;

                                    case 143:// TMR20
                                        T20IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T20 = tempo_T20;
                                        break;
                                    case 144:// TMR21
                                        T21IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T21 = tempo_T21;
                                        break;
                                    case 145:// TMR22
                                        T22IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T22 = tempo_T22;
                                        break;
                                    case 146:// TMR23
                                        T23IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T23 = tempo_T23;
                                        break;
                                    case 147:// TMR24
                                        T24IE = 0;
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;// desliga o índice na matriz virtual
                                        contador_tempo_T24 = tempo_T24;
                                        break;

                                    default:
                                        matriz[lin, col, 1] = 0;                                                            // Desaciona o índice da coluna atual
                                        Matr_Entr_said_virtual[matriz[lin, col, 0]] = 0;        // Desliga o índice na matriz virtual
                                        break;

                                }
                            }
                            matriz[lin, col, 2] = Matr_Entr_said_virtual[matriz[lin, col, 0]];// Liga ou desliga o indicador de tensão do índice
                        }
                        else// Não é saída e sim um contato ou função
                        {
                            par_impar = (col % 2);
                            if (par_impar == 1)// Testa se a coluna é impar e determina um contato
                            {

                                ////// ENTRADAS/////////
                                matriz[lin, col, 1] = Matr_Entr_said_virtual[matriz[lin, col, 0]];

                                if (matriz[lin, col, 1] == 1 && matriz[lin, col - 1, 2] == 1) matriz[lin, col, 2] = 1;
                                else matriz[lin, col, 2] = 0;


                                /////////////CONTINUIDADE OU AND//////////////////
                                if (matriz[lin, col, 0] == cont_t && matriz[lin, col - 1, 2] == 1) matriz[lin, col, 2] = 1;
                                if (matriz[lin, col, 0] == an_d && matriz[lin, col - 1, 2] == 1) matriz[lin, col, 2] = 1;

                                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                switch (matriz[lin, col, 0])
                                {
                                    case 116:
                                        if (matriz[lin, col - 1, 2] == 1)
                                        {
                                            R01IE = 1;
                                            if (contador_retardo_R01 > 0) matriz[lin, col, 2] = 0;
                                            else matriz[lin, col, 2] = 1;
                                        }
                                        else
                                        {
                                            R01IE = 0;
                                            contador_retardo_R01 = retardo_R01;
                                            matriz[lin, col, 2] = 0;
                                        }
                                        break;

                                    case 117:
                                        if (matriz[lin, col - 1, 2] == 1)
                                        {
                                            R02IE = 1;
                                            if (contador_retardo_R02 > 0) matriz[lin, col, 2] = 0;// Liga a tensão do índice da coluna atual
                                            else matriz[lin, col, 2] = 1;// Liga a tensão do índice da coluna atual
                                        }
                                        else
                                        {
                                            R02IE = 0;
                                            contador_retardo_R02 = retardo_R02;
                                            matriz[lin, col, 2] = 0;                                // desligaLiga a tensão do índice da coluna atual
                                        }
                                        break;

                                    case 118:
                                        if (matriz[lin, col - 1, 2] == 1)
                                        {
                                            R03IE = 1;
                                            if (contador_retardo_R03 > 0) matriz[lin, col, 2] = 0;// Liga a tensão do índice da coluna atual
                                            else matriz[lin, col, 2] = 1;// Liga a tensão do índice da coluna atual
                                        }
                                        else
                                        {
                                            R03IE = 0;
                                            contador_retardo_R03 = retardo_R03;
                                            matriz[lin, col, 2] = 0;                               // desligaLiga a tensão do índice da coluna atual
                                        }
                                        break;

                                    case 119:
                                        if (matriz[lin, col - 1, 2] == 1)
                                        {
                                            R04IE = 1;
                                            if (contador_retardo_R04 > 0) matriz[lin, col, 2] = 0;// Liga a tensão do índice da coluna atual
                                            else matriz[lin, col, 2] = 1;// Liga a tensão do índice da coluna atual
                                        }
                                        else
                                        {
                                            R04IE = 0;
                                            contador_retardo_R04 = retardo_R04;
                                            matriz[lin, col, 2] = 0;                            // desligaLiga a tensão do índice da coluna atual
                                        }
                                        break;

                                    case 120:
                                        if (matriz[lin, col - 1, 2] == 1)
                                        {
                                            R05IE = 1;
                                            if (contador_retardo_R05 > 0) matriz[lin, col, 2] = 0;      // Liga a tensão do índice da coluna atual
                                            else matriz[lin, col, 2] = 1;   // Liga a tensão do índice da coluna atual
                                        }
                                        else
                                        {
                                            R05IE = 0;
                                            contador_retardo_R05 = retardo_R05;
                                            matriz[lin, col, 2] = 0;                                                                // desligaLiga a tensão do índice da coluna atual
                                        }
                                        break;

                                    case 121:
                                        if (matriz[lin, col - 1, 2] == 1)
                                        {
                                            R06IE = 1;
                                            if (contador_retardo_R06 > 0) matriz[lin, col, 2] = 0;      // Liga a tensão do índice da coluna atual
                                            else matriz[lin, col, 2] = 1;   // Liga a tensão do índice da coluna atual
                                        }
                                        else
                                        {
                                            R06IE = 0;
                                            contador_retardo_R06 = retardo_R06;
                                            matriz[lin, col, 2] = 0;                                                                // desligaLiga a tensão do índice da coluna atual
                                        }
                                        break;

                                    case 122:
                                        if (matriz[lin, col - 1, 2] == 1)
                                        {
                                            R07IE = 1;
                                            if (contador_retardo_R07 > 0) matriz[lin, col, 2] = 0;      // Liga a tensão do índice da coluna atual
                                            else matriz[lin, col, 2] = 1;   // Liga a tensão do índice da coluna atual
                                        }
                                        else
                                        {
                                            R07IE = 0;
                                            contador_retardo_R07 = retardo_R07;
                                            matriz[lin, col, 2] = 0;                                                                // desligaLiga a tensão do índice da coluna atual
                                        }
                                        break;

                                    case 123:
                                        if (matriz[lin, col - 1, 2] == 1)
                                        {
                                            R08IE = 1;
                                            if (contador_retardo_R08 > 0) matriz[lin, col, 2] = 0;  // Liga a tensão do índice da coluna atual
                                            else matriz[lin, col, 2] = 1;   // Liga a tensão do índice da coluna atual
                                        }
                                        else
                                        {
                                            R08IE = 0;
                                            contador_retardo_R08 = retardo_R08;
                                            matriz[lin, col, 2] = 0;
                                        }
                                        break;
                                }
                            }
                            else// A coluna é par e portanto determina uma função
                            {

                                /////////////////// F U N C A O    A N D ////////////
                                if (matriz[lin, col, 0] == an_d)// Testa se o índice da coluna atual é uma and
                                {
                                    // Função And
                                    matriz[lin, col, 2] = matriz[lin, col - 1, 2];
                                }
                                /////////////////// F U N C A O    O R _ B T ////////////
                                valor = matriz[lin, col, 0];
                                // Função or para baixo e para traz////
                                // Função or para baixo e para traz////
                                if (matriz[lin,col,0] == or_bt)// O índice da linha seguinte é uma or
                                {
                                    // Função or
                                    Aux_de_linha = lin;
                                    var_funcao = 0;
                                    int testando = 1;

                                    while (testando == 1)
                                    {
                                        valor = matriz[Aux_de_linha,col,0];
                                        if (valor == or_bt || valor == or_bt_mid || valor == or_bt_end)
                                        {
                                            testando = 1;
                                            if (valor == or_bt)
                                            {
                                                if (matriz[Aux_de_linha,col - 1,2] == 1 || matriz[Aux_de_linha + 1,col - 1,2] == 1)
                                                {
                                                    var_funcao = 1;
                                                    testando = 0;
                                                }
                                            }
                                            if (valor == or_bt_mid)
                                            {
                                                if (matriz[Aux_de_linha,col - 1,2] == 1)
                                                {
                                                    var_funcao = 1;
                                                    testando = 0;
                                                }
                                            }


                                            if (valor == or_bt_end)
                                            {
                                                testando = 0;
                                                if (matriz[Aux_de_linha,col - 1,2] == 1 || var_funcao == 1)
                                                {
                                                    var_funcao = 1;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            testando = 0;
                                        }
                                        Aux_de_linha++;
                                    }

                                    matriz[lin,col,2] = var_funcao; // coloca o resultado na celula atual
                                }
                            } // Fim da fumção and e or
                        }
                    }
                    else // Desliga os indicadores dos índices inexistentes
                    {
                        matriz[lin, col, 1] = 0;
                        matriz[lin, col, 2] = 0;
                    }
                }
            }
        }

        void scan_entrada_saida()
        {
            int E1_INV = 0;
            int E2_INV = 0;
            int E3_INV = 0;
            int E4_INV = 0;
            int E5_INV = 0;
            int E6_INV = 0;
            int E7_INV = 0;
            int E8_INV = 0;

            int Q1_INV = 0;
            int Q2_INV = 0;
            int Q3_INV = 0;
            int Q4_INV = 0;
            int Q5_INV = 0;
            int Q6_INV = 0;
            int Q7_INV = 0;
            int Q8_INV = 0;

            int M01IE_INV = 0;
            int M02IE_INV = 0;
            int M03IE_INV = 0;
            int M04IE_INV = 0;

            le_entradas_borda();

            /*
            le_analogicas();
            le_entradas();
            
            le_bit1();
            le_bit2();
            le_bimanual1();
            controla_temperatura_A01();
            controla_temperatura_A02();
            controla_temperatura_A03();
            controla_temperatura_A04();
            controla_contador_C01();
            controla_contador_C02();
            */

            ////////ENTRADAS NORMAIS NA_NF////////////////////
            E1_INV = E1;
            E1_INV = 1 - E1_INV;
            E2_INV = E2;
            E2_INV = 1 - E2_INV;
            E3_INV = E3;
            E3_INV = 1 - E3_INV;
            E4_INV = E4;
            E4_INV = 1 - E4_INV;
            E5_INV = E5;
            E5_INV = 1 - E5_INV;
            E6_INV = E6;
            E6_INV = 1 - E6_INV;
            E7_INV = E7;
            E7_INV = 1 - E7_INV;
            E8_INV = E8;
            E8_INV = 1 - E8_INV;

            Matr_Entr_said_virtual[4] = E1;
            Matr_Entr_said_virtual[5] = (byte)E1_INV;
            Matr_Entr_said_virtual[6] = E2;
            Matr_Entr_said_virtual[7] = (byte)E2_INV;
            Matr_Entr_said_virtual[8] = E3;
            Matr_Entr_said_virtual[9] = (byte)E3_INV;
            Matr_Entr_said_virtual[10] = E4;
            Matr_Entr_said_virtual[11] = (byte)E4_INV;
            Matr_Entr_said_virtual[12] = E5;
            Matr_Entr_said_virtual[13] = (byte)E5_INV;
            Matr_Entr_said_virtual[14] = E6;
            Matr_Entr_said_virtual[15] = (byte)E6_INV;
            Matr_Entr_said_virtual[16] = E7;
            Matr_Entr_said_virtual[17] = (byte)E7_INV;
            Matr_Entr_said_virtual[18] = E8;
            Matr_Entr_said_virtual[19] = (byte)E8_INV;

            ////////ENTRADAS BORDA P: SUBIDA N:DESCIDA///////////
            Matr_Entr_said_virtual[20] = E1_N;
            Matr_Entr_said_virtual[21] = E1_P;
            Matr_Entr_said_virtual[22] = E2_N;
            Matr_Entr_said_virtual[23] = E2_P;
            Matr_Entr_said_virtual[24] = E3_N;
            Matr_Entr_said_virtual[25] = E3_P;
            Matr_Entr_said_virtual[26] = E4_N;
            Matr_Entr_said_virtual[27] = E4_P;
            Matr_Entr_said_virtual[28] = E5_N;
            Matr_Entr_said_virtual[29] = E5_P;
            Matr_Entr_said_virtual[30] = E6_N;
            Matr_Entr_said_virtual[31] = E6_P;
            Matr_Entr_said_virtual[32] = E7_N;
            Matr_Entr_said_virtual[33] = E7_P;
            Matr_Entr_said_virtual[34] = E8_N;
            Matr_Entr_said_virtual[35] = E8_P;
            Matr_Entr_said_virtual[36] = bm_ok1;
            Matr_Entr_said_virtual[37] = bm_ok2;
            Matr_Entr_said_virtual[38] = OUT_B01;
            Matr_Entr_said_virtual[39] = OUT_B02;

            ////////////SAIDAS NA_NF///////////
            Q1_INV = Q1;
            Q1_INV = 1 - Q1_INV;
            Q2_INV = Q2;
            Q2_INV = 1 - Q2_INV;
            Q3_INV = Q3;
            Q3_INV = 1 - Q3_INV;
            Q4_INV = Q4;
            Q4_INV = 1 - Q4_INV;
            Q5_INV = Q5;
            Q5_INV = 1 - Q5_INV;
            Q6_INV = Q6;
            Q6_INV = 1 - Q6_INV;
            Q7_INV = Q7;
            Q7_INV = 1 - Q7_INV;
            Q8_INV = Q8;
            Q8_INV = 1 - Q8_INV;
            Matr_Entr_said_virtual[52] = Q1;
            Matr_Entr_said_virtual[53] = (byte)Q1_INV;
            Matr_Entr_said_virtual[54] = Q2;
            Matr_Entr_said_virtual[55] = (byte)Q2_INV;
            Matr_Entr_said_virtual[56] = Q3;
            Matr_Entr_said_virtual[57] = (byte)Q3_INV;
            Matr_Entr_said_virtual[58] = Q4;
            Matr_Entr_said_virtual[59] = (byte)Q4_INV;
            Matr_Entr_said_virtual[60] = Q5;
            Matr_Entr_said_virtual[61] = (byte)Q5_INV;
            Matr_Entr_said_virtual[62] = Q6;
            Matr_Entr_said_virtual[63] = (byte)Q6_INV;
            Matr_Entr_said_virtual[64] = Q7;
            Matr_Entr_said_virtual[65] = (byte)Q7_INV;
            Matr_Entr_said_virtual[66] = Q8;
            Matr_Entr_said_virtual[67] = (byte)Q8_INV;


            ///MEMORIA AUXILIARES///
            M01IE_INV = M01IE;
            M01IE_INV = 1 - M01IE_INV;
            M02IE_INV = M02IE;
            M02IE_INV = 1 - M02IE_INV;
            M03IE_INV = M03IE;
            M03IE_INV = 1 - M03IE_INV;
            M04IE_INV = M04IE;
            M04IE_INV = 1 - M04IE_INV;

            ///MEMORIA AUXILIARES NA_NF///
            Matr_Entr_said_virtual[100] = M01IE;        //NA
            Matr_Entr_said_virtual[101] = (byte)M01IE_INV;  //NF

            Matr_Entr_said_virtual[102] = M02IE;        //NA
            Matr_Entr_said_virtual[103] = (byte)M02IE_INV;  //NF

            Matr_Entr_said_virtual[104] = M03IE;        //NA
            Matr_Entr_said_virtual[105] = (byte)M03IE_INV;  //NF

            Matr_Entr_said_virtual[106] = M04IE;        //NA
            Matr_Entr_said_virtual[107] = (byte)M04IE_INV;  //NF

            Matr_Entr_said_virtual[108] = M05IE;        //NA
            Matr_Entr_said_virtual[109] = M06IE;        //NA
            Matr_Entr_said_virtual[110] = M07IE;        //NA
            Matr_Entr_said_virtual[111] = M08IE;        //NA

            Matr_Entr_said_virtual[112] = M09IE;     // SET:112  RESET:113
            Matr_Entr_said_virtual[40] =  M10IE;     // SET:40   RESET:41
            Matr_Entr_said_virtual[42] =  M11IE;     // SET:42   RESET:43
            Matr_Entr_said_virtual[44] =  M12IE;     // SET:44   RESET:45
            Matr_Entr_said_virtual[46] =  M13IE;     // SET:46   RESET:47
            Matr_Entr_said_virtual[48] =  M14IE;	 // SET:48   RESET:49

            Matr_Entr_said_virtual[114] = OUT_CONTADOR_C01;
            Matr_Entr_said_virtual[115] = OUT_CONTADOR_C02;

            ///ANALOGICAS///
            Matr_Entr_said_virtual[156] = OUT_TEMPERATURA_A01;
            Matr_Entr_said_virtual[157] = OUT_TEMPERATURA_A02;
            Matr_Entr_said_virtual[158] = OUT_TEMPERATURA_A03;
            Matr_Entr_said_virtual[159] = OUT_TEMPERATURA_A04;
        }



        void le_entradas_borda()
        {
            // contadores para tempo de borda////
            //////////////////E1////////////////
            /////////////////ENTRADAS BORDA POSITIVA/////////////////
            if (E1 == 1)
            {
                if (E1_T_N == 0)
                {
                    E1_N = 1;
                    cont1_bn = TEMPO_PULSO_BORDA;
                    E1_T_N = 1;
                    E1_T_P = 0;
                }
            }
            else
            {
                if (E1_T_P == 0)
                {
                    E1_P = 1;
                    cont1_bp = TEMPO_PULSO_BORDA;
                    E1_T_N = 0;
                    E1_T_P = 1;
                }
            }
            ///////////////////////////////////////////////////////////////
            //////////////////E2////////////////
            /////////////////ENTRADAS BORDA POSITIVA/////////////////
            if (E2 == 1)
            {
                if (E2_T_N == 0)
                {
                    E2_N = 1;
                    cont2_bn = TEMPO_PULSO_BORDA;   //
                    E2_T_N = 1;
                    E2_T_P = 0;
                }

            }
            else
            {
                if (E2_T_P == 0)
                {
                    E2_P = 1;
                    cont2_bp = TEMPO_PULSO_BORDA;
                    E2_T_N = 0;
                    E2_T_P = 1;
                }
            }
            /////////////////////////////////////////////////////////
            /////////////////////////////E3/////////////////////////
            /////////////////ENTRADAS BORDA POSITIVA/////////////////
            if (E3 == 1)
            {
                if (E3_T_N == 0)
                {
                    E3_N = 1;
                    cont3_bn = TEMPO_PULSO_BORDA;   //
                    E3_T_N = 1;
                    E3_T_P = 0;
                }
            }
            else
            {
                if (E3_T_P == 0)    // VERIFICA SOMENTE A BORDA
                {
                    E3_P = 1;                                           // INDICA QUE FOR BORDA POSITIVA
                    cont3_bp = TEMPO_PULSO_BORDA;   // TEMPO DE PULSO PARA BORDA
                    E3_T_N = 0;                                     // HABILITA LEITURA DA BORDA NEGATIVA
                    E3_T_P = 1;                                     // TRAVA PARA NÃO PEGAR FORA DA BORDA
                }
            }
            ///////////////////////////////////////////////////////////////
            //////////////////E4////////////////
            /////////////////ENTRADAS BORDA POSITIVA/////////////////
            if (E4 == 1)
            {
                if (E4_T_N == 0)
                {
                    E4_N = 1;
                    cont4_bn = TEMPO_PULSO_BORDA;   //
                    E4_T_N = 1;
                    E4_T_P = 0;
                }
            }
            else
            {
                if (E4_T_P == 0)    // VERIFICA SOMENTE A BORDA
                {
                    E4_P = 1;                                           // INDICA QUE FOR BORDA POSITIVA
                    cont4_bp = TEMPO_PULSO_BORDA;   // TEMPO DE PULSO PARA BORDA
                    E4_T_N = 0;                                     // HABILITA LEITURA DA BORDA NEGATIVA
                    E4_T_P = 1;                                     // TRAVA PARA NÃO PEGAR FORA DA BORDA
                }
            }
            ///////////////////////////////////////////////////////////////
            //////////////////E5////////////////
            /////////////////ENTRADAS BORDA POSITIVA/////////////////
            if (E5 == 1)
            {
                if (E5_T_N == 0)
                {
                    E5_N = 1;
                    cont5_bn = TEMPO_PULSO_BORDA;   //
                    E5_T_N = 1;
                    E5_T_P = 0;
                }

            }
            else
            {
                if (E5_T_P == 0)    // VERIFICA SOMENTE A BORDA
                {
                    E5_P = 1;                                           // INDICA QUE FOR BORDA POSITIVA
                    cont5_bp = TEMPO_PULSO_BORDA;   // TEMPO DE PULSO PARA BORDA
                    E5_T_N = 0;                                     // HABILITA LEITURA DA BORDA NEGATIVA
                    E5_T_P = 1;                                     // TRAVA PARA NÃO PEGAR FORA DA BORDA
                }
            }
            ///////////////////////////////////////////////////////////////
            //////////////////E6////////////////
            /////////////////ENTRADAS BORDA POSITIVA/////////////////
            if (E6 == 1)
            {
                if (E6_T_N == 0)
                {
                    E6_N = 1;
                    cont6_bn = TEMPO_PULSO_BORDA;   //
                    E6_T_N = 1;
                    E6_T_P = 0;
                }
            }
            else
            {
                if (E6_T_P == 0)    // VERIFICA SOMENTE A BORDA
                {
                    E6_P = 1;                                           // INDICA QUE FOR BORDA POSITIVA
                    cont6_bp = TEMPO_PULSO_BORDA;   // TEMPO DE PULSO PARA BORDA
                    E6_T_N = 0;                                     // HABILITA LEITURA DA BORDA NEGATIVA
                    E6_T_P = 1;                                     // TRAVA PARA NÃO PEGAR FORA DA BORDA
                }
            }
            ///////////////////////////////////////////////////////////////
            //////////////////E7////////////////
            /////////////////ENTRADAS BORDA POSITIVA/////////////////
            if (E7 == 1)
            {
                if (E7_T_N == 0)
                {
                    E7_N = 1;
                    cont7_bn = TEMPO_PULSO_BORDA;   //
                    E7_T_N = 1;
                    E7_T_P = 0;
                }
            }
            else
            {
                if (E7_T_P == 0)    // VERIFICA SOMENTE A BORDA
                {
                    E7_P = 1;                                           // INDICA QUE FOR BORDA POSITIVA
                    cont7_bp = TEMPO_PULSO_BORDA;   // TEMPO DE PULSO PARA BORDA
                    E7_T_N = 0;                                     // HABILITA LEITURA DA BORDA NEGATIVA
                    E7_T_P = 1;                                     // TRAVA PARA NÃO PEGAR FORA DA BORDA
                }
            }
            ///////////////////////////////////////////////////////////////
            //////////////////E1////////////////
            /////////////////ENTRADAS BORDA POSITIVA/////////////////
            if (E8 == 1)
            {
                if (E8_T_N == 0)
                {
                    E8_N = 1;
                    cont8_bn = TEMPO_PULSO_BORDA;   //
                    E8_T_N = 1;
                    E8_T_P = 0;
                }
            }
            else
            {
                if (E8_T_P == 0)    // VERIFICA SOMENTE A BORDA
                {
                    E8_P = 1;                                           // INDICA QUE FOR BORDA POSITIVA
                    cont8_bp = TEMPO_PULSO_BORDA;   // TEMPO DE PULSO PARA BORDA
                    E8_T_N = 0;                                     // HABILITA LEITURA DA BORDA NEGATIVA
                    E8_T_P = 1;                                     // TRAVA PARA NÃO PEGAR FORA DA BORDA
                }
            }
            ///////////////////////////////////////////////////////////////



            ////////////////CONTADORES DE TEMPOS DE BORDA/////////////////////
            if (P_10MS_IN_B)
            {
                P_10MS_IN_B = false;

                ////////////////E1////////////////////////////
                if (E1_P == 1)
                {
                    if (cont1_bp > 0) cont1_bp--;
                    else E1_P = 0;
                }
                if (E1_N == 1)
                {
                    if (cont1_bn > 0) cont1_bn--;
                    else E1_N = 0;
                }
                ////////////////////////////////////////////

                ////////////////E2////////////////////////////
                if (E2_P == 1)
                {
                    if (cont2_bp > 0) cont2_bp--;
                    else E2_P = 0;
                }
                if (E2_N == 1)
                {
                    if (cont2_bn > 0) cont2_bn--;
                    else E2_N = 0;
                }
                ////////////////////////////////////////////

                ////////////////E3////////////////////////////
                if (E3_P == 1)
                {
                    if (cont3_bp > 0) cont3_bp--;
                    else E3_P = 0;
                }
                if (E3_N == 1)
                {
                    if (cont3_bn > 0) cont3_bn--;
                    else E3_N = 0;
                }
                ////////////////////////////////////////////

                ////////////////E4////////////////////////////
                if (E4_P == 1)
                {
                    if (cont4_bp > 0) cont4_bp--;
                    else E4_P = 0;
                }
                if (E4_N == 1)
                {
                    if (cont4_bn > 0) cont4_bn--;
                    else E4_N = 0;
                }
                ////////////////////////////////////////////
                ////////////////E5////////////////////////////
                if (E5_P == 1)
                {
                    if (cont5_bp > 0) cont5_bp--;
                    else E5_P = 0;
                }
                if (E5_N == 1)
                {
                    if (cont5_bn > 0) cont5_bn--;
                    else E5_N = 0;
                }
                ////////////////////////////////////////////
                ////////////////E6////////////////////////////
                if (E6_P == 1)
                {
                    if (cont6_bp > 0) cont6_bp--;
                    else E6_P = 0;
                }
                if (E6_N == 1)
                {
                    if (cont6_bn > 0) cont6_bn--;
                    else E6_N = 0;
                }
                ////////////////////////////////////////////
                ////////////////E7////////////////////////////
                if (E7_P == 1)
                {
                    if (cont7_bp > 0) cont7_bp--;
                    else E7_P = 0;
                }
                if (E7_N == 1)
                {
                    if (cont7_bn > 0) cont7_bn--;
                    else E7_N = 0;
                }
                ////////////////////////////////////////////

                ////////////////E7////////////////////////////
                if (E8_P == 1)
                {
                    if (cont8_bp > 0) cont8_bp--;
                    else E8_P = 0;
                }
                if (E8_N == 1)
                {
                    if (cont8_bn > 0) cont8_bn--;
                    else E8_N = 0;
                }
                ////////////////////////////////////////////
            }
            //////////////////////////////////////////////

        }


        void reseta_cores()
        {
            for (lin = 0; lin < linhas; lin++)
            {
                for (col = 1; col < colunas; col++)
                {
                    principal.dataGridView1.Rows[lin].Cells[col - 1].Style.BackColor = Color.Azure;
                }
            }
        }
        void atualiza_cores()
        {
            for (lin = 0; lin < linhas; lin++)
            {
                for (col = 1; col < colunas; col++)
                {
                    if (matriz[lin, col, 2] == 1)
                    {
                        principal.dataGridView1.Rows[lin].Cells[col - 1].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        principal.dataGridView1.Rows[lin].Cells[col - 1].Style.BackColor = Color.Azure;
                    }
                }
            }
            ///////////////////////////////////////////////
            if (Q1 == 1)
            {
                button9.BackColor = Color.LightGreen;
            }
            else
            {
                button9.BackColor = Color.LightGray;
            }
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            if (Q2 == 1)
            {
                button10.BackColor = Color.LightGreen;
            }
            else
            {
                button10.BackColor = Color.LightGray;
            }
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            if (Q3 == 1)
            {
                button11.BackColor = Color.LightGreen;
            }
            else
            {
                button11.BackColor = Color.LightGray;
            }
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            if (Q4 == 1)
            {
                button12.BackColor = Color.LightGreen;
            }
            else
            {
                button12.BackColor = Color.LightGray;
            }
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            if (Q5 == 1)
            {
                button13.BackColor = Color.LightGreen;
            }
            else
            {
                button13.BackColor = Color.LightGray;
            }
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            if (Q6 == 1)
            {
                button14.BackColor = Color.LightGreen;
            }
            else
            {
                button14.BackColor = Color.LightGray;
            }
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            if (Q7 == 1)
            {
                button15.BackColor = Color.LightGreen;
            }
            else
            {
                button15.BackColor = Color.LightGray;
            }
            ///////////////////////////////////////////////

            ///////////////////////////////////////////////
            if (Q8 == 1)
            {
                button16.BackColor = Color.LightGreen;
            }
            else
            {
                button16.BackColor = Color.LightGray;
            }
            ///////////////////////////////////////////////

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (E1 == 1)
            {
                E1 = 0;
                button1.BackColor = Color.LightGray;
            }
            else
            {
                E1 = 1;
                button1.BackColor = Color.LightGreen;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (E2 == 1)
            {
                E2 = 0;
                button2.BackColor = Color.LightGray;
            }
            else
            {
                E2 = 1;
                button2.BackColor = Color.LightGreen;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (E3 == 1)
            {
                E3 = 0;
                button3.BackColor = Color.LightGray;
            }
            else
            {
                E3 = 1;
                button3.BackColor = Color.LightGreen;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (E4 == 1)
            {
                E4 = 0;
                button4.BackColor = Color.LightGray;
            }
            else
            {
                E4 = 1;
                button4.BackColor = Color.LightGreen;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (E5 == 1)
            {
                E5 = 0;
                button5.BackColor = Color.LightGray;
            }
            else
            {
                E5 = 1;
                button5.BackColor = Color.LightGreen;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (E6 == 1)
            {
                E6 = 0;
                button6.BackColor = Color.LightGray;
            }
            else
            {
                E6 = 1;
                button6.BackColor = Color.LightGreen;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (E7 == 1)
            {
                E7 = 0;
                button7.BackColor = Color.LightGray;
            }
            else
            {
                E7 = 1;
                button7.BackColor = Color.LightGreen;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (E8 == 1)
            {
                E8 = 0;
                button8.BackColor = Color.LightGray;
            }
            else
            {
                E8 = 1;
                button8.BackColor = Color.LightGreen;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scan_entrada_saida();
            scan_matriz();
            atualiza_cores();
            scan_IHM();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            base_10ms++;

            //if (percentual_histerese_A01 == 1 && !bit_modo_teste) processo_pwm_A01();

            if (base_10ms == 1)
            {
                base_10ms = 0;
                base_100ms++;
                P_10MS = true;
                P_10MS_IN = true;
                P_10MS_SCAN = true;
                P_10MS_IN_B = true;
                P_10MS_AN = true;
                P_10MS_KBD = true;
                //BASE DE TEMPO DE 10ms para as repeticoes das teclax
                base_kbd++;
                if (tecla == 0) base_kbd = 0;
                if (base_kbd == 5 && repete3)
                {
                    base_kbd = 0;
                    kb_rp = !kb_rp;
                }
                if (base_kbd == 10 && repete2)
                {
                    base_kbd = 0;
                    kb_rp = !kb_rp;
                }
                if (base_kbd == 15 && repete1)
                {
                    base_kbd = 0;
                    kb_rp = !kb_rp;
                }
                if (base_kbd == 20 && segurou)
                {
                    base_kbd = 0;
                    kb_rp = !kb_rp;
                }

            }
            //BASE DE TEMPO DE 100ms:
            if (base_100ms == 10)
            {
                base_100ms = 0;
                base_500ms++;
                base_300ms++;
                P_100MS = true;
                P_100MS_LCD = true;
                if (TSEGURA != 0) TSEGURA--;        //contador de tempo para tempo de tecla pressionada


                if (R01IE == 1) { if (contador_retardo_R01 != 0) contador_retardo_R01--; }

                if (R02IE == 1) { if (contador_retardo_R02 != 0) contador_retardo_R02--; }
                if (R03IE == 1) { if (contador_retardo_R03 != 0) contador_retardo_R03--; }
                if (R04IE == 1) { if (contador_retardo_R04 != 0) contador_retardo_R04--; }
                if (R05IE == 1) { if (contador_retardo_R05 != 0) contador_retardo_R05--; }
                if (R06IE == 1) { if (contador_retardo_R06 != 0) contador_retardo_R06--; }
                if (R07IE == 1) { if (contador_retardo_R07 != 0) contador_retardo_R07--; }
                if (R08IE == 1) { if (contador_retardo_R08 != 0) contador_retardo_R08--; }

                if (T01IE == 1) { if (contador_tempo_T01 != 0) contador_tempo_T01--; }
                if (T02IE == 1) { if (contador_tempo_T02 != 0) contador_tempo_T02--; }
                if (T03IE == 1) { if (contador_tempo_T03 != 0) contador_tempo_T03--; }
                if (T04IE == 1) { if (contador_tempo_T04 != 0) contador_tempo_T04--; }
                if (T05IE == 1) { if (contador_tempo_T05 != 0) contador_tempo_T05--; }
                if (T06IE == 1) { if (contador_tempo_T06 != 0) contador_tempo_T06--; }
                if (T07IE == 1) { if (contador_tempo_T07 != 0) contador_tempo_T07--; }
                if (T08IE == 1) { if (contador_tempo_T08 != 0) contador_tempo_T08--; }
            }


            //BASE DE TEMPO DE 300ms:
            if (base_300ms == 4)
            {
                base_300ms = 0;
                P_300MS = true;
                if (piscante) pisca = !pisca;
            }

            //BASE DE TEMPO DE 500ms:
            if (base_500ms == 5)
            {
                base_500ms = 0;
                base_1s++;
                base_2s++;
                P_500MS = true;
                CTECINA++;      //   ; INCREMENTA TEMPO DE TECLADO INATIVO
            }
            //BASE DE TEMPO DE 1 SEGUNDO:
            if (base_1s == 2)
            {
                base_1s = 0;
                base_1m++;
                P_1S = true;
                if (tempo_inicializacao != 0) tempo_inicializacao--;

                if (T09IE == 1) { if (contador_tempo_T09 != 0) contador_tempo_T09--; }
                if (T10IE == 1) { if (contador_tempo_T10 != 0) contador_tempo_T10--; }
                if (T11IE == 1) { if (contador_tempo_T11 != 0) contador_tempo_T11--; }
                if (T12IE == 1) { if (contador_tempo_T12 != 0) contador_tempo_T12--; } 
                if (T13IE == 1) { if (contador_tempo_T13 != 0) contador_tempo_T13--; }
                if (T14IE == 1) { if (contador_tempo_T14 != 0) contador_tempo_T14--; }
                if (T15IE == 1) { if (contador_tempo_T15 != 0) contador_tempo_T15--; }
                if (T16IE == 1) { if (contador_tempo_T16 != 0) contador_tempo_T16--; }

            }

            //BASE DE TEMPO DE 1 MINUTO:
            if (base_1m == 60)
            {
                base_1m = 0;
                base_1h++;
                P_1MIN = true;

                if (T17IE == 1) { if (contador_tempo_T17 != 0) contador_tempo_T17--; }
                if (T18IE == 1) { if (contador_tempo_T18 != 0) contador_tempo_T18--; }
                if (T19IE == 1) { if (contador_tempo_T19 != 0) contador_tempo_T19--; }
                if (T20IE == 1) { if (contador_tempo_T20 != 0) contador_tempo_T20--; }
                if (T21IE == 1) { if (contador_tempo_T21 != 0) contador_tempo_T21--; }
                if (T22IE == 1) { if (contador_tempo_T22 != 0) contador_tempo_T22--; }
                if (T23IE == 1) { if (contador_tempo_T23 != 0) contador_tempo_T23--; }
                if (T24IE == 1) { if (contador_tempo_T24 != 0) contador_tempo_T24--; }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                
       
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            reseta_cores();
            Close();
        }

        private void SIMULACAO_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            reseta_cores();
            Close();
        }

        

        private void SIMULACAO_Shown(object sender, EventArgs e)
        {
          
        }

        private void SIMULACAO_Load(object sender, EventArgs e)
        {

        }
    }
}
