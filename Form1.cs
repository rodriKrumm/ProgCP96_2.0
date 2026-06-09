using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Security.Permissions;
using System.Drawing.Drawing2D;

namespace PROGCP96_V1._1_
{
    public partial class Form1 : Form
    {     
        public int salvar = 0;
        public int completar = 0;
        public int linha_or;
        public int coluna_or;
        public static int pos;
        public static string caminho_usb;
        public static string USB;
        public static int btn_fechar_clicado;
        public static int btn_transfer_Clicado;
        public static string NomeArquivo;
        public static string caminho;
        public static int saidaOuDisplay = 0;
        public static string caminhoAntigo;
        public static int[] click_selecionar = new int[2]; // Vetor que recebe as variaveis de entrada, saída, auxiliares 
        public static string repassandoCaminho;

        // Matriz que recebe os valores das entradas 
        public int[,] mat = new int[250, 17];
        int[,] matriz_temp = new int[250, 17]; // matriz temporaria para nova linha
        int LT;
        public static int Linha;

        public int linha_dg;
        public int coluna_dg;


        public static string[] allLines;

        //Vetor para transitar valores das funções
        public static int[] funcao = new int[2];

        //Vetor que transforma a matriz principal em um vetor para salvar no arquivo
        public static byte[] vetor = new byte[4250];

        public static byte[] newVetor = new byte[4500];
        //matriz para colocar 1 no inicio de cada linha
        public static int[,] MAT_MAIOR = new int[250, 18];
        public static int coluna = 0;
        // Variavel de transição de valores de entradas
        int valor;
        public static string caminhoarq;
        // Variavel para auxiliar na manipulação de arquivos 
        public string arquivo;

        public static int completarLinha = 0;
        public static string comentario;

        //Variavel que recebe imagens de entradas, saida e outros
        public static Image img;
        public static Image img2;

        public string diretorio;

        public static string btn_txt;
        public static string tooltip;

        //Valor para carregar um botao no modo invivel **visible=false**
        public int botao_invisivel = 250;

        //FUNÇÕES
        int and = 1;

        //Entrada Contínuo
        int continuo = 1;

        public static string RecebendoconteudoTempo01;
        public static string RecebendoconteudoTempo02;
        public static string RecebendoconteudoTempo03;
        public static string RecebendoconteudoTempo04;
        public static string RecebendoconteudoTempo05;
        public static string RecebendoconteudoTempo06;
        public static string RecebendoconteudoTempo07;
        public static string RecebendoconteudoTempo08;
        public static string RecebendoconteudoTempo09;
        public static string RecebendoconteudoTempo10;
        public static string RecebendoconteudoTempo11;
        public static string RecebendoconteudoTempo12;
        public static string RecebendoconteudoTempo13;
        public static string RecebendoconteudoTempo14;
        public static string RecebendoconteudoTempo15;
        public static string RecebendoconteudoTempo16;
        public static string RecebendoconteudoTempo17;
        public static string RecebendoconteudoTempo18;
        public static string RecebendoconteudoTempo19;
        public static string RecebendoconteudoTempo20;
        public static string RecebendoconteudoTempo21;
        public static string RecebendoconteudoTempo22;
        public static string RecebendoconteudoTempo23;
        public static string RecebendoconteudoTempo24;

        public static string RecebendoconteudoCont01;
        public static string RecebendoconteudoCont02;
        public static string RecebendoconteudoZCont01;
        public static string RecebendoconteudoZCont02;


        public static string RecebendoconteudoADJ00;
        public static string RecebendoconteudoADJ01;

        public static string RecebendoconteudoBM1;
        public static string RecebendoconteudoBM2;

        public static string RecebendoconteudoMsg00;
        public static string RecebendoconteudoMsg01;
        public static string RecebendoconteudoMsg02_2;
        public static string RecebendoconteudoMsg03;
        public static string RecebendoconteudoMsg04;
        public static string RecebendoconteudoMsg05;
        public static string RecebendoconteudoMsg06;
        public static string RecebendoconteudoMsg07;
        public static string RecebendoconteudoMsg08;

        public static string RecebendoconteudoA01;
        public static string RecebendoconteudoA02;
        public static string RecebendoconteudoA03;
        public static string RecebendoconteudoA04;

        public static string RecebendoconteudoRet01;
        public static string RecebendoconteudoRet02;
        public static string RecebendoconteudoRet03;
        public static string RecebendoconteudoRet04;
        public static string RecebendoconteudoRet05;
        public static string RecebendoconteudoRet06;
        public static string RecebendoconteudoRet07;
        public static string RecebendoconteudoRet08;

        public static string RecebendoComentario;

        public static string passando;

        public static int or = 200;
        public static int incrementar = 0;

        public int apagar;
        public int inserir;

        public static int s01;
        public static int s02;
        public static int s03;
        public static int s04;
        public static int s05;
        public static int s06;
        public static int s07;
        public static int s08;

        /////////////// Vetores para salvar comentarios no arquivo ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // ENTRADA NORMALMENTE ABERTA
        public static char[] Linha0_ENA01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha1_ENA02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha2_ENA03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha3_ENA04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha4_ENA05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha5_ENA06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha6_ENA07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha7_ENA08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //ENTRADA NORMALMENTE FECHADA
        public static char[] Linha8_ENF01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha9_ENF02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha10_ENF03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha11_ENF04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha12_ENF05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha13_ENF06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha14_ENF07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha15_ENF08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //ENTRADA BORDA NEGATIVA
        public static char[] Linha16_EBN01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha17_EBN02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha18_EBN03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha19_EBN04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha20_EBN05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha21_EBN06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha22_EBN07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha23_EBN08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //ENTRADA BORDA POSITIVA
        public static char[] Linha24_EBP01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha25_EBP02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha26_EBP03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha27_EBP04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha28_EBP05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha29_EBP06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha30_EBP07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha31_EBP08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //SAIDA NORMALMENTE ABERTA
        public static char[] Linha32_SNA01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha33_SNA02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha34_SNA03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha35_SNA04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha36_SNA05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha37_SNA06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha38_SNA07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha39_SNA08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //SAIDA NORMALMENTE FECHADA
        public static char[] Linha40_SNF01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha41_SNF02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha42_SNF03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha43_SNF04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha44_SNF05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha45_SNF06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha46_SNF07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha47_SNF08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //SAIDA SET 
        public static char[] Linha48_SET01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha49_SET02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha50_SET03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha51_SET04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha52_SET05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha53_SET06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha54_SET07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha55_SET08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        // SAIDA RESET
        public static char[] Linha56_RES01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha57_RES02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha58_RES03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha59_RES04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha60_RES05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha61_RES06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha62_RES07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha63_RES08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        // FUNÇÃO ANALOGICA
        public static char[] Linha64_ANG01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha65_ANG02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha66_ANG03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha67_ANG04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        // FUNÇÃO CONTADOR 
        public static char[] Linha68_CON01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha69_CON02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha114_CON01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha115_CON02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        // FUNÇÃO ESPERA (RETARDO)
        public static char[] Linha70_ESP01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha71_ESP02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha72_ESP03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha73_ESP04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha74_ESP05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha75_ESP06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha76_ESP07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha77_ESP08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        // FUNÇÃO TEMPORIZADOR
        public static char[] Linha78_TEM01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha79_TEM02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha80_TEM03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha81_TEM04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha82_TEM05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha83_TEM06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha84_TEM07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha85_TEM08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        // FUNÇÃO  CONTATO AUXILIAR
        public static char[] Linha86_CAX01 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha87_CAX02 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha88_CAX03 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha89_CAX04 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha90_CAX05 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha91_CAX06 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha92_CAX07 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha93_CAX08 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha94_CAX09 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha95_CAX10 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha96_CAX11 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha97_CAX12 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha98_CAX13 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha99_CAX14 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha104_CAX15 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha105_CAX16 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha106_CAX17 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha107_CAX18 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha108_CAX19 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha109_CAX20 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha110_CAX21 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha111_CAX22 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha112_CAX23 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha113_CAX24 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        //BIMANUAL  
        public static char[] Linha100_BIM1 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] Linha101_BIM2 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        //bit
        public static char[] linha102_BIT1 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static char[] linha103_BIT2 = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };


        public static string linha0;
        public static string linha1;
        public static string linha2;
        public static string linha3;
        public static string linha4;
        public static string linha5;
        public static string linha6;
        public static string linha7;

        public static string linha8;
        public static string linha9;
        public static string linha10;
        public static string linha11;
        public static string linha12;
        public static string linha13;
        public static string linha14;
        public static string linha15;

        public static string linha16;
        public static string linha17;
        public static string linha18;
        public static string linha19;
        public static string linha20;
        public static string linha21;
        public static string linha22;
        public static string linha23;

        public static string linha24;
        public static string linha25;
        public static string linha26;
        public static string linha27;
        public static string linha28;
        public static string linha29;
        public static string linha30;
        public static string linha31;

        public static string linha32;
        public static string linha33;
        public static string linha34;
        public static string linha35;
        public static string linha36;
        public static string linha37;
        public static string linha38;
        public static string linha39;

        public static string linha40;
        public static string linha41;
        public static string linha42;
        public static string linha43;
        public static string linha44;
        public static string linha45;
        public static string linha46;
        public static string linha47;

        public static string linha48;
        public static string linha49;
        public static string linha50;
        public static string linha51;
        public static string linha52;
        public static string linha53;
        public static string linha54;
        public static string linha55;

        public static string linha56;
        public static string linha57;
        public static string linha58;
        public static string linha59;
        public static string linha60;
        public static string linha61;
        public static string linha62;
        public static string linha63;

        public static string linha64;
        public static string linha65;
        public static string linha66;
        public static string linha67;
        public static string linha68;
        public static string linha69;
        public static string linha70;
        public static string linha71;

        public static string linha72;
        public static string linha73;
        public static string linha74;
        public static string linha75;
        public static string linha76;
        public static string linha77;
        public static string linha78;
        public static string linha79;

        public static string linha80;
        public static string linha81;
        public static string linha82;
        public static string linha83;
        public static string linha84;
        public static string linha85;

        public static string linha86;
        public static string linha87;

        public static string linha88;
        public static string linha89;
        public static string linha90;
        public static string linha91;
        public static string linha92;
        public static string linha93;
        public static string linha94;
        public static string linha95;
        public static string linha96;
        public static string linha97;
        public static string linha98;

        public static string linha99;
        public static string linha100;
        public static string linha101;
        public static string linha102;
        public static string linha103;

        public static string linha104;
        public static string linha105;
        public static string linha106;
        public static string linha107;
        public static string linha108;
        public static string linha109;
        public static string linha110;
        public static string linha111;
        public static string linha112;
        public static string linha113;

        public static string linha114;
        public static string linha115;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
            button1.MouseMove += button1_Move;
        }

        /// <summary>
        /// Bloco de métodos
        /// </summary>
        /// <param name="ValorClick"></param>
        /// <param name="posicaoEntrada"></param>
        /// <returns></returns>

        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;

            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))

            collection = searcher.Get();

            DriveInfo[] d = DriveInfo.GetDrives();
            if (d.Length == 1)
            {
                //Mensagem de erro ao compilar
                MessageBoxIcon icone2 = MessageBoxIcon.Error;
                string mensagem2 = "Não existe pendrive conectado!";
                string titulo2 = "Erro!";
                MessageBoxButtons botao2 = MessageBoxButtons.OK;
                MessageBox.Show(mensagem2, titulo2, botao2, icone2);          
            }

            else
            {
                Dispositivos dispositivo = new Dispositivos();              
                dispositivo.StartPosition = FormStartPosition.CenterScreen;
                dispositivo.ShowDialog();       
            }

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("PNPDeviceID"),
                (string)device.GetPropertyValue("Description")
                ));
            }
            collection.Dispose();
            return devices;
        }

        public int RecebeContato(int ValorClick, object sender)
        {
            int Linha;
            int Coluna;

            Linha = ((DataGridView)sender).CurrentCell.RowIndex;

            Coluna = ((DataGridView)sender).CurrentCell.ColumnIndex;

            mat[Linha, Coluna] = ValorClick;

            return 0;
        }
        public void Funcao_Or_valor(object sender, EventArgs e)
        {
            int linha = ((DataGridView)sender).CurrentCell.RowIndex;
            int coluna = ((DataGridView)sender).CurrentCell.ColumnIndex;

            if (or == 200)
            {
                ((DataGridView)sender).CurrentCell.Value = Properties.Resources.new_OR_T;
                mat[linha, coluna] = 200;
                or = 201;

                int cell_linha = ((DataGridView)sender).CurrentCell.RowIndex;
                int cell_coluna = ((DataGridView)sender).CurrentCell.ColumnIndex + 1;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = cell_coluna; j < dataGridView1.Columns.Count; j++)
                    {                      
                            dataGridView1.Rows[cell_linha].Cells[cell_coluna].Value = Properties.Resources.linhas_gridview;
                            mat[cell_linha, cell_coluna] = 0;
 
                        if (mat[cell_linha, cell_coluna] != 0)
                        {
                            ((DataGridView)sender).CurrentCell.Value = Properties.Resources.new_OR_T; 
                            mat[cell_linha, cell_coluna] = or;
                        }
                        cell_coluna++;
                    }
                }      
            }
            else if (or == 201)
            {
                if (linha == 0)
                {
                    ((DataGridView)sender).CurrentCell.Value = Properties.Resources.new_OR_L;
                    mat[linha, coluna] = 202;
                }
                else
                {
                    if (mat[linha, coluna] == 0)
                    {
                        ((DataGridView)sender).CurrentCell.Value = Properties.Resources.new_OR_H;
                        mat[linha, coluna] = 201;

                        int cell_linha = ((DataGridView)sender).CurrentCell.RowIndex;
                        int cell_coluna = ((DataGridView)sender).CurrentCell.ColumnIndex + 1;

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = cell_coluna; j < dataGridView1.Columns.Count; j++)
                            {
                                dataGridView1.Rows[cell_linha].Cells[cell_coluna].Value = Properties.Resources.botao_invisivel;
                                mat[cell_linha, cell_coluna] = botao_invisivel;
                                cell_coluna++;
                            }
                        }
                    }
                    else
                    {
                        or = 202;
                        if (linha == 0)
                        {
                            ((DataGridView)sender).CurrentCell.Value = Properties.Resources.new_OR_T;
                            mat[linha, coluna] = 200;
                        }
                        else
                        {
                            ((DataGridView)sender).CurrentCell.Value = Properties.Resources.new_OR_L;
                            mat[linha, coluna] = 202;
                            or = 200;

                            int cell_linha = ((DataGridView)sender).CurrentCell.RowIndex;
                            int cell_coluna = ((DataGridView)sender).CurrentCell.ColumnIndex + 1;

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = cell_coluna; j < dataGridView1.Columns.Count; j++)
                                {
                                    dataGridView1.Rows[cell_linha].Cells[cell_coluna].Value = Properties.Resources.botao_invisivel;
                                    mat[cell_linha, cell_coluna] = botao_invisivel;
                                    cell_coluna++;
                                }
                            }
                        }
                    }
                }
            }
        
            else if (or == 202)
            {        
                mat[linha, coluna] = 202;
                or = 201;
            }
            click_selecionar[1] = or;
        }
        public void BotaoVazio(object sender, EventArgs e)
        {
            if (click_selecionar[1] == 0)
            {
                button22.BackgroundImage = Properties.Resources.linha_grande;
                button22.Text = string.Empty;
                toolTip1.SetToolTip(((Button)sender), string.Empty);
            }
        }
        public void FuncaoAnd_Imagem(object sender, EventArgs e)
        {
            switch (click_selecionar[1])
            {
                case 1:button22.BackgroundImage = Properties.Resources.CONTINUO; break;
                case 200: button22.BackgroundImage = Properties.Resources.new_OR_T ; break;
                case 201: button22.BackgroundImage = Properties.Resources.new_OR_H; break;
                case 202: button22.BackgroundImage = Properties.Resources.new_OR_L; break;
            }
        }
        public void FuncaoAnd_Valor(object sender, EventArgs e)
        {
            switch (click_selecionar[1])
            {
                case 1: click_selecionar[1] = 1; break;
                case 200: click_selecionar[1] = 200; break;
                case 201: click_selecionar[1] = 201; break;
                case 202: click_selecionar[1] = 202; break;
            }
        }
        public void Saidas(object sender, EventArgs e)
        {
            int l = ((DataGridView)sender).CurrentCell.RowIndex; // linha
            int c = ((DataGridView)sender).CurrentCell.ColumnIndex; // coluna

            switch (click_selecionar[1])
            {
                //////////////////////////////// ENA //////////////////////////////////////////////
                case 4:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                      

                    }
                    else
                    {
                        mat[l, c] = 4;                       
                        button22.BackgroundImage = Properties.Resources.ENA_E01;
                        var g1 = Graphics.FromImage(button22.BackgroundImage);
                        g1.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 6:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 6;
                        button22.BackgroundImage = Properties.Resources.ENA_E02;
                        var g2 = Graphics.FromImage(button22.BackgroundImage);
                        g2.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 8:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 8;
                        button22.BackgroundImage = Properties.Resources.ENA_E03;
                        var g3 = Graphics.FromImage(button22.BackgroundImage);
                        g3.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 10:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 10;
                        button22.BackgroundImage = Properties.Resources.ENA_E04;
                        var g4 = Graphics.FromImage(button22.BackgroundImage);
                        g4.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 12:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 12;
                        button22.BackgroundImage = Properties.Resources.ENA_E05;
                        var g55 = Graphics.FromImage(button22.BackgroundImage);
                        g55.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 14:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 14;
                        button22.BackgroundImage = Properties.Resources.ENA_E06;
                        var g6 = Graphics.FromImage(button22.BackgroundImage);
                        g6.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 16:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 16;
                        button22.BackgroundImage = Properties.Resources.ENA_E07;
                        var g7 = Graphics.FromImage(button22.BackgroundImage);
                        g7.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 18:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 18;
                        button22.BackgroundImage = Properties.Resources.ENA_E08;
                        var g8 = Graphics.FromImage(button22.BackgroundImage);
                        g8.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                //////////////////////////////// ENF //////////////////////////////////////////////
                case 5:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 5;
                        button22.BackgroundImage = Properties.Resources.ENF_E01;
                        var g9 = Graphics.FromImage(button22.BackgroundImage);
                        g9.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 7:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 7;
                        button22.BackgroundImage = Properties.Resources.ENF_E02;
                        var g10 = Graphics.FromImage(button22.BackgroundImage);
                        g10.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 9:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 9;
                        button22.BackgroundImage = Properties.Resources.ENF_E03;
                        var g11 = Graphics.FromImage(button22.BackgroundImage);
                        g11.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 11:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 11;
                        button22.BackgroundImage = Properties.Resources.ENF_E041;
                        var g12 = Graphics.FromImage(button22.BackgroundImage);
                        g12.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 13:
                    if (c == 16)
                    {
                        
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 13;
                        button22.BackgroundImage = Properties.Resources.ENF_E05;
                        var g13 = Graphics.FromImage(button22.BackgroundImage);
                        g13.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 15:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 15;
                        button22.BackgroundImage = Properties.Resources.ENF_E06;
                        var g14 = Graphics.FromImage(button22.BackgroundImage);
                        g14.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 17:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 17;
                        button22.BackgroundImage = Properties.Resources.ENF_E07;
                        var g15 = Graphics.FromImage(button22.BackgroundImage);
                        g15.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 19:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 19;
                        button22.BackgroundImage = Properties.Resources.ENF_E08;
                        var g16 = Graphics.FromImage(button22.BackgroundImage);
                        g16.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                //////////////////////////////// EBP //////////////////////////////////////////////
                case 20:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 20;
                        button22.BackgroundImage = Properties.Resources.BP_E01;
                        var g17 = Graphics.FromImage(button22.BackgroundImage);
                        g17.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 22:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 22;
                        button22.BackgroundImage = Properties.Resources.BP_E02;
                        var g18 = Graphics.FromImage(button22.BackgroundImage);
                        g18.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 24:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 24;
                        button22.BackgroundImage = Properties.Resources.BP_E03;
                        var g19 = Graphics.FromImage(button22.BackgroundImage);
                        g19.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 26:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 26;
                        button22.BackgroundImage = Properties.Resources.BP_E04;
                        var g20 = Graphics.FromImage(button22.BackgroundImage);
                        g20.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 28:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 28;
                        button22.BackgroundImage = Properties.Resources.BP_E05;
                        var g21 = Graphics.FromImage(button22.BackgroundImage);
                        g21.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 30:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 30;
                        button22.BackgroundImage = Properties.Resources.BP_E06;
                        var g22 = Graphics.FromImage(button22.BackgroundImage);
                        g22.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 32:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 32;
                        button22.BackgroundImage = Properties.Resources.BP_E07;
                        var g23 = Graphics.FromImage(button22.BackgroundImage);
                        g23.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 34:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 34;
                        button22.BackgroundImage = Properties.Resources.BP_E08;
                        var g24 = Graphics.FromImage(button22.BackgroundImage);
                        g24.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;


                //////////////////////////////// EBN //////////////////////////////////////////////
                case 21:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 21;
                        button22.BackgroundImage = Properties.Resources.BN_E01;
                        var g25 = Graphics.FromImage(button22.BackgroundImage);
                        g25.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 23:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 23;
                        button22.BackgroundImage = Properties.Resources.BN_E02;
                        var g26 = Graphics.FromImage(button22.BackgroundImage);
                        g26.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 25:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 25;
                        button22.BackgroundImage = Properties.Resources.BN_E03;
                        var g27 = Graphics.FromImage(button22.BackgroundImage);
                        g27.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 27:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 27;
                        button22.BackgroundImage = Properties.Resources.BN_E04;
                        var g28 = Graphics.FromImage(button22.BackgroundImage);
                        g28.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 29:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 29;
                        button22.BackgroundImage = Properties.Resources.BN_E05;
                        var g29 = Graphics.FromImage(button22.BackgroundImage);
                        g29.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 31:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 31;
                        button22.BackgroundImage = Properties.Resources.BN_E06;
                        var g30 = Graphics.FromImage(button22.BackgroundImage);
                        g30.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 33:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 33;
                        button22.BackgroundImage = Properties.Resources.BN_E07;
                        var g31 = Graphics.FromImage(button22.BackgroundImage);
                        g31.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
                case 35:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 35;
                        button22.BackgroundImage = Properties.Resources.BN_E08;
                        var g32 = Graphics.FromImage(button22.BackgroundImage);
                        g32.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                //////////////////////////////// DISPLAY //////////////////////////////////////////
                case 148:
                    if(c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 148;
                        button22.BackgroundImage = Properties.Resources.d01;
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    
                    break;

                case 149:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 149;
                        button22.BackgroundImage = Properties.Resources.d02;
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;

                case 150:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 150;
                        button22.BackgroundImage = Properties.Resources.d03;
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;

                case 151:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 151;
                        button22.BackgroundImage = Properties.Resources.d04;
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;

                case 152:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 152;
                        button22.BackgroundImage = Properties.Resources.d05;
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;

                case 153:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 153;
                        button22.BackgroundImage = Properties.Resources.d06;
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;

                case 154:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 154;
                        button22.BackgroundImage = Properties.Resources.d07;
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;

                case 155:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 149;
                        button22.BackgroundImage = Properties.Resources.d08;
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;
                    
                    //////////////////////////////// SNA //////////////////////////////////////////
                    
                case 52:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 52;
                        button22.BackgroundImage = Properties.Resources.SNA_E01;
                        var g33 = Graphics.FromImage(button22.BackgroundImage);
                        g33.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 52;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_01;
                        var g34 = Graphics.FromImage(button22.BackgroundImage);
                        g34.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 54:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 54;
                        button22.BackgroundImage = Properties.Resources.SNA_E02;
                        var g35 = Graphics.FromImage(button22.BackgroundImage);
                        g35.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 54;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_02;
                        var g36 = Graphics.FromImage(button22.BackgroundImage);
                        g36.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 56:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 56;
                        button22.BackgroundImage = Properties.Resources.SNA_E03;
                        var g37 = Graphics.FromImage(button22.BackgroundImage);
                        g37.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 56;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_03;
                        var g38 = Graphics.FromImage(button22.BackgroundImage);
                        g38.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 58:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 58;
                        button22.BackgroundImage = Properties.Resources.SNA_E04;
                        var g39 = Graphics.FromImage(button22.BackgroundImage);
                        g39.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 58;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_04;
                        var g40 = Graphics.FromImage(button22.BackgroundImage);
                        g40.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 60:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 60;
                        button22.BackgroundImage = Properties.Resources.SNA_E05;
                        var g41 = Graphics.FromImage(button22.BackgroundImage);
                        g41.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 60;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_05;
                        var g42 = Graphics.FromImage(button22.BackgroundImage);
                        g42.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 62:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 62;
                        button22.BackgroundImage = Properties.Resources.SNA_E06;
                        var g43 = Graphics.FromImage(button22.BackgroundImage);
                        g43.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 62;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_06;
                        var g44 = Graphics.FromImage(button22.BackgroundImage);
                        g44.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 64:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 64;
                        button22.BackgroundImage = Properties.Resources.SNA_E07;
                        var g45 = Graphics.FromImage(button22.BackgroundImage);
                        g45.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 64;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_07;
                        var g46 = Graphics.FromImage(button22.BackgroundImage);
                        g46.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 66:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 66;
                        button22.BackgroundImage = Properties.Resources.SNA_E08;
                        var g47 = Graphics.FromImage(button22.BackgroundImage);
                        g47.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 66;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_08;
                        var g48 = Graphics.FromImage(button22.BackgroundImage);
                        g48.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                //////////////////////////////// SNF //////////////////////////////////////////

                case 53:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 53;
                        button22.BackgroundImage = Properties.Resources.SNF_E01;
                        var g49 = Graphics.FromImage(button22.BackgroundImage);
                        g49.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 53;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_NF;
                        var g50 = Graphics.FromImage(button22.BackgroundImage);
                        g50.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 55:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 55;
                        button22.BackgroundImage = Properties.Resources.SNF_E02;
                        var g51 = Graphics.FromImage(button22.BackgroundImage);
                        g51.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 55;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_NF_2;
                        var g52 = Graphics.FromImage(button22.BackgroundImage);
                        g52.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 57:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 57;
                        button22.BackgroundImage = Properties.Resources.SNF_E03;
                        var g53 = Graphics.FromImage(button22.BackgroundImage);
                        g53.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 57;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_NF_3;
                        var g54 = Graphics.FromImage(button22.BackgroundImage);
                        g54.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 59:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 59;
                        button22.BackgroundImage = Properties.Resources.SNF_E04;
                        var g55 = Graphics.FromImage(button22.BackgroundImage);
                        g55.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 59;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_NF_4;
                        var g56 = Graphics.FromImage(button22.BackgroundImage);
                        g56.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 61:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 61;
                        button22.BackgroundImage = Properties.Resources.SNF_E05;
                        var g57 = Graphics.FromImage(button22.BackgroundImage);
                        g57.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 61;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_NF_5;
                        var g58 = Graphics.FromImage(button22.BackgroundImage);
                        g58.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 63:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 63;
                        button22.BackgroundImage = Properties.Resources.SNF_E06;
                        var g59 = Graphics.FromImage(button22.BackgroundImage);
                        g59.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 63;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_NF_6;
                        var g60 = Graphics.FromImage(button22.BackgroundImage);
                        g60.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 65:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 65;
                        button22.BackgroundImage = Properties.Resources.SNF_E07;
                        var g61 = Graphics.FromImage(button22.BackgroundImage);
                        g61.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 65;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_NF_7;
                        var g62 = Graphics.FromImage(button22.BackgroundImage);
                        g62.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 67:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 67;
                        button22.BackgroundImage = Properties.Resources.SNF_E08;
                        var g63 = Graphics.FromImage(button22.BackgroundImage);
                        g63.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 67;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_NF_8;
                        var g64 = Graphics.FromImage(button22.BackgroundImage);
                        g64.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;


                //////////////////////////////// Set //////////////////////////////////////////

                case 68:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 68;
                        button22.BackgroundImage = Properties.Resources.SET_E01;
                        var g65 = Graphics.FromImage(button22.BackgroundImage);
                        g65.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 68;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_SET;
                        var g66 = Graphics.FromImage(button22.BackgroundImage);
                        g66.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 70:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 70;
                        button22.BackgroundImage = Properties.Resources.SET_E02;
                        var g67 = Graphics.FromImage(button22.BackgroundImage);
                        g67.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 70;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_SET_2;
                        var g68 = Graphics.FromImage(button22.BackgroundImage);
                        g68.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 72:
                    if (c == 16)
                    { completar = 0;
                        mat[l, c] = 72;
                        button22.BackgroundImage = Properties.Resources.SET_E03;
                        var g69 = Graphics.FromImage(button22.BackgroundImage);
                        g69.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 72;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_SET_3;
                        var g70 = Graphics.FromImage(button22.BackgroundImage);
                        g70.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 74:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 74;
                        button22.BackgroundImage = Properties.Resources.SET_E04;
                        var g71 = Graphics.FromImage(button22.BackgroundImage);
                        g71.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 74;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_SET_4;
                        var g72 = Graphics.FromImage(button22.BackgroundImage);
                        g72.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 76:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 76;
                        button22.BackgroundImage = Properties.Resources.SET_E05;
                        var g73 = Graphics.FromImage(button22.BackgroundImage);
                        g73.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 76;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_SET_5;
                        var g74 = Graphics.FromImage(button22.BackgroundImage);
                        g74.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 78:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 78;
                        button22.BackgroundImage = Properties.Resources.SET_E06;
                        var g75 = Graphics.FromImage(button22.BackgroundImage);
                        g75.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 78;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_SET_6;
                        var g76 = Graphics.FromImage(button22.BackgroundImage);
                        g76.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 80:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 80;
                        button22.BackgroundImage = Properties.Resources.SET_E07;
                        var g77 = Graphics.FromImage(button22.BackgroundImage);
                        g77.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 80;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_SET_7;
                        var g78 = Graphics.FromImage(button22.BackgroundImage);
                        g78.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;


                case 82:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 82;
                        button22.BackgroundImage = Properties.Resources.SET_E08;
                        var g79 = Graphics.FromImage(button22.BackgroundImage);
                        g79.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 82;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_SET_8;
                        var g80 = Graphics.FromImage(button22.BackgroundImage);
                        g80.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                //////////////////////////////// RESET //////////////////////////////////////////

                case 69:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 69;
                        button22.BackgroundImage = Properties.Resources.RES_E01;
                        var g81 = Graphics.FromImage(button22.BackgroundImage);
                        g81.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 69;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_RES;
                        var g82 = Graphics.FromImage(button22.BackgroundImage);
                        g82.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 71:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 71;
                        button22.BackgroundImage = Properties.Resources.RES_E02;
                        var g83 = Graphics.FromImage(button22.BackgroundImage);
                        g83.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 71;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_RES_2;
                        var g84 = Graphics.FromImage(button22.BackgroundImage);
                        g84.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 73:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 73;
                        button22.BackgroundImage = Properties.Resources.RES_E03;
                        var g85 = Graphics.FromImage(button22.BackgroundImage);
                        g85.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 73;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_RES_3;
                        var g86 = Graphics.FromImage(button22.BackgroundImage);
                        g86.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 75:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 75;
                        button22.BackgroundImage = Properties.Resources.RES_E04;
                        var g87 = Graphics.FromImage(button22.BackgroundImage);
                        g87.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 75;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_RES_4;
                        var g88 = Graphics.FromImage(button22.BackgroundImage);
                        g88.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 77:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 77;
                        button22.BackgroundImage = Properties.Resources.RES_E05;
                        var g89 = Graphics.FromImage(button22.BackgroundImage);
                        g89.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 77;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_RES_5;
                        var g90 = Graphics.FromImage(button22.BackgroundImage);
                        g90.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 79:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 79;
                        button22.BackgroundImage = Properties.Resources.RES_E06;
                        var g91 = Graphics.FromImage(button22.BackgroundImage);
                        g91.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 79;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_RES_6;
                        var g92 = Graphics.FromImage(button22.BackgroundImage);
                        g92.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 81:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 81;
                        button22.BackgroundImage = Properties.Resources.RES_E07;
                        var g93 = Graphics.FromImage(button22.BackgroundImage);
                        g93.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 81;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_RES_7;
                        var g94 = Graphics.FromImage(button22.BackgroundImage);
                        g94.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 83:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 83;
                        button22.BackgroundImage = Properties.Resources.RES_E08;
                        var g95 = Graphics.FromImage(button22.BackgroundImage);
                        g95.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 83;
                        button22.BackgroundImage = Properties.Resources.ESPECIAL_RES_8;
                        var g96 = Graphics.FromImage(button22.BackgroundImage);
                        g96.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                //////////////////////////////// CONTATO AUXILIAR //////////////////////////////////////////

                case 100:
                    completar = 0;
                    mat[l, c] = 100;
                        button22.BackgroundImage = Properties.Resources.CONTATO_01_NA;
                    var g97 = Graphics.FromImage(button22.BackgroundImage);
                    g97.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 101:
                    completar = 0;
                    mat[l, c] = 101;
                    button22.BackgroundImage = Properties.Resources.CONTATO_01_NF;
                    var g98 = Graphics.FromImage(button22.BackgroundImage);
                    g98.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 102:
                    completar = 0;
                    mat[l, c] = 102;
                    button22.BackgroundImage = Properties.Resources.CONTATO_02_NA;
                    var g99 = Graphics.FromImage(button22.BackgroundImage);
                    g99.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 103:
                    completar = 0;
                    mat[l, c] = 103;
                    button22.BackgroundImage = Properties.Resources.CONTATO_02_NF;
                    var g100 = Graphics.FromImage(button22.BackgroundImage);
                    g100.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 104:
                    completar = 0;
                    mat[l, c] = 104;
                    button22.BackgroundImage = Properties.Resources.CONTATO_03_NA;
                    var g101 = Graphics.FromImage(button22.BackgroundImage);
                    g101.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 105:
                    completar = 0;
                    mat[l, c] = 105;
                    button22.BackgroundImage = Properties.Resources.CONTATO_03_NF;
                    var g102 = Graphics.FromImage(button22.BackgroundImage);
                    g102.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 106:
                    completar = 0;
                    mat[l, c] = 106;
                    button22.BackgroundImage = Properties.Resources.CONTATO_04_NA;
                    var g103 = Graphics.FromImage(button22.BackgroundImage);
                    g103.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 107:
                    completar = 0;
                    mat[l, c] = 107;
                    button22.BackgroundImage = Properties.Resources.CONTATO_04_NF;
                    var g104 = Graphics.FromImage(button22.BackgroundImage);
                    g104.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 108:
                    completar = 0;
                    mat[l, c] = 108;
                    button22.BackgroundImage = Properties.Resources.CONTATO_05_NA;
                    var g105 = Graphics.FromImage(button22.BackgroundImage);
                    g105.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 109:
                    completar = 0;
                    mat[l, c] = 109;
                    button22.BackgroundImage = Properties.Resources.CONTATO_06_NA;
                    var g106 = Graphics.FromImage(button22.BackgroundImage);
                    g106.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 110:
                    completar = 0;
                    mat[l, c] = 110;
                    button22.BackgroundImage = Properties.Resources.CONTATO_07_NA;
                    var g107 = Graphics.FromImage(button22.BackgroundImage);
                    g107.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 111:
                    completar = 0;
                    mat[l, c] = 111;
                    button22.BackgroundImage = Properties.Resources.CONTATO_08_NA;
                    var g108 = Graphics.FromImage(button22.BackgroundImage);
                    g108.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 112:
                    completar = 0;
                    mat[l, c] = 112;
                    button22.BackgroundImage = Properties.Resources.CONTATO_09_SET;
                    var g109 = Graphics.FromImage(button22.BackgroundImage);
                    g109.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 113:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 113;
                        button22.BackgroundImage = Properties.Resources.CONTATO_09_RES;
                        var g110 = Graphics.FromImage(button22.BackgroundImage);
                        g110.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;
                case 40:
                    completar = 0;
                    mat[l, c] = 40;
                    button22.BackgroundImage = Properties.Resources.CONTATO_10_SET;
                    var g111 = Graphics.FromImage(button22.BackgroundImage);
                    g111.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 41:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 41;
                        button22.BackgroundImage = Properties.Resources.CONTATO_10_RESET;
                        var g112 = Graphics.FromImage(button22.BackgroundImage);
                        g112.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;
                case 42:
                    completar = 0;
                    mat[l, c] = 42;
                    button22.BackgroundImage = Properties.Resources.CONTATO_11_SET;
                    var g113 = Graphics.FromImage(button22.BackgroundImage);
                    g113.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 43:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 43;
                        button22.BackgroundImage = Properties.Resources.CONTATO_11_RESET;
                        var g114 = Graphics.FromImage(button22.BackgroundImage);
                        g114.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;
                case 44:
                    completar = 0;
                    mat[l, c] = 44;
                    button22.BackgroundImage = Properties.Resources.CONTATO_12_SET;
                    var g115 = Graphics.FromImage(button22.BackgroundImage);
                    g115.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;

                case 45:                 
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 45;
                        button22.BackgroundImage = Properties.Resources.CONTATO_12_RESET;
                        var g116 = Graphics.FromImage(button22.BackgroundImage);
                        g116.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;
                case 46:
                    completar = 0;
                    mat[l, c] = 46;
                    button22.BackgroundImage = Properties.Resources.CONTATO_13_SET;
                    var g117 = Graphics.FromImage(button22.BackgroundImage);
                    g117.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 47:
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 47;
                        button22.BackgroundImage = Properties.Resources.CONTATO_13_RESET;
                        var g118 = Graphics.FromImage(button22.BackgroundImage);
                        g118.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;
                case 48:
                    completar = 0;
                    mat[l, c] = 48;
                    button22.BackgroundImage = Properties.Resources.CONTATO_14_SET;
                    var g119 = Graphics.FromImage(button22.BackgroundImage);
                    g119.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 49:                                       
                    if (c == 16)
                    {
                        completar = 0;
                        mat[l, c] = 49;
                        button22.BackgroundImage = Properties.Resources.CONTATO_14_RESET;
                        var g120 = Graphics.FromImage(button22.BackgroundImage);
                        g120.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    break;
                //////////////////////////////// ANALOGICAS //////////////////////////////////////////

                case 156:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 156;
                        button22.BackgroundImage = Properties.Resources.ANG_E01;
                        var g121 = Graphics.FromImage(button22.BackgroundImage);
                        g121.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 157:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 157;
                        button22.BackgroundImage = Properties.Resources.ANG_E02;
                        var g122 = Graphics.FromImage(button22.BackgroundImage);
                        g122.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 158:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 158;
                        button22.BackgroundImage = Properties.Resources.ANG_E03;
                        var g123 = Graphics.FromImage(button22.BackgroundImage);
                        g123.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 159:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 159;
                        button22.BackgroundImage = Properties.Resources.ANG_E04;
                        var g124 = Graphics.FromImage(button22.BackgroundImage);
                        g124.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                //////////////////////////////// CONTADOR //////////////////////////////////////////

                case 114:
                    completar = 0;
                    mat[l, c] = 114;
                        button22.BackgroundImage = Properties.Resources.contador01;
                    var g125 = Graphics.FromImage(button22.BackgroundImage);
                    g125.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;

                case 115:
                    completar = 0;
                    mat[l, c] = 115;
                        button22.BackgroundImage = Properties.Resources.contador02;
                    var g126 = Graphics.FromImage(button22.BackgroundImage);
                    g126.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;

                //////////////////////////////// RETARDO / ESPERA //////////////////////////////////////////

                case 116:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        completar = 0;
                        mat[l, c] = 116;
                        button22.BackgroundImage = Properties.Resources.espera01;
                        var g127 = Graphics.FromImage(button22.BackgroundImage);
                        g127.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                        
                    }
                    break;
                case 117:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        completar = 0;
                        mat[l, c] = 117;
                        button22.BackgroundImage = Properties.Resources.espera02;
                        var g128 = Graphics.FromImage(button22.BackgroundImage);
                        g128.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }                 
                    break;
                case 118:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        completar = 0;
                        mat[l, c] = 118;
                        button22.BackgroundImage = Properties.Resources.espera03;
                        var g129 = Graphics.FromImage(button22.BackgroundImage);
                        g129.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                       
                    }
                    break;
                case 119:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        completar = 0;
                        mat[l, c] = 119;
                        button22.BackgroundImage = Properties.Resources.espera04;
                        var g130 = Graphics.FromImage(button22.BackgroundImage);
                        g130.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }         
                    break;
                case 120:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;

                    }
                    else
                    {
                        completar = 0;
                        mat[l, c] = 120;
                        button22.BackgroundImage = Properties.Resources.espera05;
                        var g131 = Graphics.FromImage(button22.BackgroundImage);
                        g131.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }                
                    break;
                case 121:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;

                    }
                    else
                    {
                        completar = 0;
                        mat[l, c] = 121;
                        button22.BackgroundImage = Properties.Resources.espera06;
                        var g132 = Graphics.FromImage(button22.BackgroundImage);
                        g132.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }      
                    break;
                case 122:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;

                    }
                    else
                    {
                        completar = 0;
                        mat[l, c] = 122;
                        button22.BackgroundImage = Properties.Resources.espera07;
                        var g133 = Graphics.FromImage(button22.BackgroundImage);
                        g133.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }               
                    break;
                case 123:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;

                    }
                    else
                    {
                        completar = 0;
                        mat[l, c] = 123;
                        button22.BackgroundImage = Properties.Resources.espera08;
                        var g134 = Graphics.FromImage(button22.BackgroundImage);
                        g134.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }                 
                    break;

                //////////////////////////////// TEMPORIZADOR ///////////////////////////////////////////////

                case 124:
                    completar = 0;
                    mat[l, c] = 124;
                    button22.BackgroundImage = Properties.Resources.temporizador_01;
                    var g135 = Graphics.FromImage(button22.BackgroundImage);
                    g135.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 125:
                    completar = 0;
                    mat[l, c] = 125;
                    button22.BackgroundImage = Properties.Resources.temporizador_02;
                    var g136 = Graphics.FromImage(button22.BackgroundImage);
                    g136.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 126:
                    completar = 0;
                    mat[l, c] = 126;
                    button22.BackgroundImage = Properties.Resources.temporizador_03;
                    var g137 = Graphics.FromImage(button22.BackgroundImage);
                    g137.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 127:
                    completar = 0;
                    mat[l, c] = 127;
                    button22.BackgroundImage = Properties.Resources.temporizador_04;
                    var g138 = Graphics.FromImage(button22.BackgroundImage);
                    g138.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 128:
                    completar = 0;
                    mat[l, c] = 128;
                    button22.BackgroundImage = Properties.Resources.temporizador_05;
                    var g139 = Graphics.FromImage(button22.BackgroundImage);
                    g139.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 129:
                    completar = 0;
                    mat[l, c] = 129;
                    button22.BackgroundImage = Properties.Resources.temporizador_06;
                    var g140 = Graphics.FromImage(button22.BackgroundImage);
                    g140.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 130:
                    completar = 0;
                    mat[l, c] = 130;
                    button22.BackgroundImage = Properties.Resources.temporizador_07;
                    var g141 = Graphics.FromImage(button22.BackgroundImage);
                    g141.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 131:
                    completar = 0;
                    mat[l, c] = 131;
                    button22.BackgroundImage = Properties.Resources.temporizador_08;
                    var g142 = Graphics.FromImage(button22.BackgroundImage);
                    g142.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 132:
                    completar = 0;
                    mat[l, c] = 132;
                    button22.BackgroundImage = Properties.Resources.temporizador_09;
                    var g143 = Graphics.FromImage(button22.BackgroundImage);
                    g143.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 133:
                    completar = 0;
                    mat[l, c] = 133;
                    button22.BackgroundImage = Properties.Resources.temporizador_10;
                    var g144 = Graphics.FromImage(button22.BackgroundImage);
                    g144.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 134:
                    completar = 0;
                    mat[l, c] = 134;
                    button22.BackgroundImage = Properties.Resources.temporizador_11;
                    var g145 = Graphics.FromImage(button22.BackgroundImage);
                    g145.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 135:
                    completar = 0;
                    mat[l, c] = 135;
                    button22.BackgroundImage = Properties.Resources.temporizador_12;
                    var g146 = Graphics.FromImage(button22.BackgroundImage);
                    g146.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 136:
                    completar = 0;
                    mat[l, c] = 136;
                    button22.BackgroundImage = Properties.Resources.temporizador_13;
                    var g147 = Graphics.FromImage(button22.BackgroundImage);
                    g147.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 137:
                    completar = 0;
                    mat[l, c] = 137;
                    button22.BackgroundImage = Properties.Resources.temporizador_14;
                    var g148 = Graphics.FromImage(button22.BackgroundImage);
                    g148.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 138:
                    completar = 0;
                    mat[l, c] = 138;
                    button22.BackgroundImage = Properties.Resources.temporizador_15;
                    var g149 = Graphics.FromImage(button22.BackgroundImage);
                    g149.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 139:
                    completar = 0;
                    mat[l, c] = 139;
                    button22.BackgroundImage = Properties.Resources.temporizador_16;
                    var g150 = Graphics.FromImage(button22.BackgroundImage);
                    g150.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 140:
                    completar = 0;
                    mat[l, c] = 140;
                    button22.BackgroundImage = Properties.Resources.temporizador_17;
                    var g151 = Graphics.FromImage(button22.BackgroundImage);
                    g151.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 141:
                    completar = 0;
                    mat[l, c] = 141;
                    button22.BackgroundImage = Properties.Resources.temporizador_18;
                    var g152 = Graphics.FromImage(button22.BackgroundImage);
                    g152.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 142:
                    completar = 0;
                    mat[l, c] = 142;
                    button22.BackgroundImage = Properties.Resources.temporizador_19;
                    var g153 = Graphics.FromImage(button22.BackgroundImage);
                    g153.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 143:
                    completar = 0;
                    mat[l, c] = 143;
                    button22.BackgroundImage = Properties.Resources.temporizador_20;
                    var g154 = Graphics.FromImage(button22.BackgroundImage);
                    g154.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 144:
                    completar = 0;
                    mat[l, c] = 144;
                    button22.BackgroundImage = Properties.Resources.temporizador_21;
                    var g155 = Graphics.FromImage(button22.BackgroundImage);
                    g155.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 145:
                    completar = 0;
                    mat[l, c] = 145;
                    button22.BackgroundImage = Properties.Resources.temporizador_22;
                    var g156 = Graphics.FromImage(button22.BackgroundImage);
                    g156.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 146:
                    completar = 0;
                    mat[l, c] = 146;
                    button22.BackgroundImage = Properties.Resources.temporizador_23;
                    var g157 = Graphics.FromImage(button22.BackgroundImage);
                    g157.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;
                case 147:                   
                    completar = 0;
                    mat[l, c] = 147;
                    button22.BackgroundImage = Properties.Resources.temporizador_24;
                    var g158 = Graphics.FromImage(button22.BackgroundImage);
                    g158.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    break;

                ////////////////////////////////// BIMANUAL ////////////////////////////////////////////////////////

                case 36:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                        var g159 = Graphics.FromImage(button22.BackgroundImage);
                        g159.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    else
                    {
                        mat[l, c] = 36;
                        button22.BackgroundImage = Properties.Resources.bimanual_E7_E8;
                        var g160 = Graphics.FromImage(button22.BackgroundImage);
                        g160.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;

                case 37:
                     if (c == 16)
                     {
                        completar = 1;
                        mat[l, c] = 0;
                         button22.BackgroundImage = Properties.Resources.linhas_gridview;                        
                     }
                     else
                     {
                         mat[l, c] = 37;
                         button22.BackgroundImage = Properties.Resources.bimanual_E7_E8;
                        var g161 = Graphics.FromImage(button22.BackgroundImage);
                        g161.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                     break;

                //////////////////////////////// BIT / HABILITAR FUNÇÕES //////////////////////////////////////////

                case 38:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;
                    }
                    else
                    {
                        mat[l, c] = 38;
                        button22.BackgroundImage = Properties.Resources.BIT_E1;
                        var g162 = Graphics.FromImage(button22.BackgroundImage);
                        g162.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }

                    break;

                case 39:
                    if (c == 16)
                    {
                        completar = 1;
                        mat[l, c] = 0;
                        button22.BackgroundImage = Properties.Resources.linhas_gridview;                      
                    }
                    else
                    {
                        mat[l, c] = 39;
                        button22.BackgroundImage = Properties.Resources.BIT_E2;
                        var g163 = Graphics.FromImage(button22.BackgroundImage);
                        g163.DrawString(btn_txt, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                    }
                    break;
            }
        }
        public void Mostrarcursor(object sender, EventArgs e)
        {
            switch (click_selecionar[1])
            {

                case 4: button22.Cursor = new Cursor(Properties.Resources.icone_ena.Handle); break;
                case 6: button22.Cursor = new Cursor(Properties.Resources.icone_ena.Handle); break;
                case 8: button22.Cursor = new Cursor(Properties.Resources.icone_ena.Handle); break;
                case 10: button22.Cursor = new Cursor(Properties.Resources.icone_ena.Handle); break;
                case 12: button22.Cursor = new Cursor(Properties.Resources.icone_ena.Handle); break;
                case 14: button22.Cursor = new Cursor(Properties.Resources.icone_ena.Handle); break;
                case 16: button22.Cursor = new Cursor(Properties.Resources.icone_ena.Handle); break;
                case 18: button22.Cursor = new Cursor(Properties.Resources.icone_ena.Handle); break;

                case 5: button22.Cursor = new Cursor(Properties.Resources.icone_enf.Handle); break;
                case 7: button22.Cursor = new Cursor(Properties.Resources.icone_enf.Handle); break;
                case 9: button22.Cursor = new Cursor(Properties.Resources.icone_enf.Handle); break;
                case 11: button22.Cursor = new Cursor(Properties.Resources.icone_enf.Handle); break;
                case 13: button22.Cursor = new Cursor(Properties.Resources.icone_enf.Handle); break;
                case 15: button22.Cursor = new Cursor(Properties.Resources.icone_enf.Handle); break;
                case 17: button22.Cursor = new Cursor(Properties.Resources.icone_enf.Handle); break;
                case 19: button22.Cursor = new Cursor(Properties.Resources.icone_enf.Handle); break;

                case 20: button22.Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle); break;
                case 22: button22.Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle); break;
                case 24: button22.Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle); break;
                case 26: button22.Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle); break;
                case 28: button22.Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle); break;
                case 30: button22.Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle); break;
                case 32: button22.Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle); break;
                case 34: button22.Cursor = new Cursor(Properties.Resources.icone_bordaP.Handle); break;

                case 21: button22.Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle); break;
                case 23: button22.Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle); break;
                case 25: button22.Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle); break;
                case 27: button22.Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle); break;
                case 29: button22.Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle); break;
                case 31: button22.Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle); break;
                case 33: button22.Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle); break;
                case 35: button22.Cursor = new Cursor(Properties.Resources.icone_bordaN.Handle); break;

                case 52: button22.Cursor = new Cursor(Properties.Resources.icone_sna.Handle); break;
                case 54: button22.Cursor = new Cursor(Properties.Resources.icone_sna.Handle); break;
                case 56: button22.Cursor = new Cursor(Properties.Resources.icone_sna.Handle); break;
                case 58: button22.Cursor = new Cursor(Properties.Resources.icone_sna.Handle); break;
                case 60: button22.Cursor = new Cursor(Properties.Resources.icone_sna.Handle); break;
                case 62: button22.Cursor = new Cursor(Properties.Resources.icone_sna.Handle); break;
                case 64: button22.Cursor = new Cursor(Properties.Resources.icone_sna.Handle); break;
                case 66: button22.Cursor = new Cursor(Properties.Resources.icone_sna.Handle); break;

                case 53: button22.Cursor = new Cursor(Properties.Resources.icone_snf.Handle); break;
                case 55: button22.Cursor = new Cursor(Properties.Resources.icone_snf.Handle); break;
                case 57: button22.Cursor = new Cursor(Properties.Resources.icone_snf.Handle); break;
                case 59: button22.Cursor = new Cursor(Properties.Resources.icone_snf.Handle); break;
                case 61: button22.Cursor = new Cursor(Properties.Resources.icone_snf.Handle); break;
                case 63: button22.Cursor = new Cursor(Properties.Resources.icone_snf.Handle); break;
                case 65: button22.Cursor = new Cursor(Properties.Resources.icone_snf.Handle); break;
                case 67: button22.Cursor = new Cursor(Properties.Resources.icone_snf.Handle); break;

                case 68: button22.Cursor = new Cursor(Properties.Resources.icone_set.Handle); break;
                case 70: button22.Cursor = new Cursor(Properties.Resources.icone_set.Handle); break;
                case 72: button22.Cursor = new Cursor(Properties.Resources.icone_set.Handle); break;
                case 74: button22.Cursor = new Cursor(Properties.Resources.icone_set.Handle); break;
                case 76: button22.Cursor = new Cursor(Properties.Resources.icone_set.Handle); break;
                case 78: button22.Cursor = new Cursor(Properties.Resources.icone_set.Handle); break;
                case 80: button22.Cursor = new Cursor(Properties.Resources.icone_set.Handle); break;
                case 82: button22.Cursor = new Cursor(Properties.Resources.icone_set.Handle); break;

                case 69: button22.Cursor = new Cursor(Properties.Resources.icone_res.Handle); break;
                case 71: button22.Cursor = new Cursor(Properties.Resources.icone_res.Handle); break;
                case 73: button22.Cursor = new Cursor(Properties.Resources.icone_res.Handle); break;
                case 75: button22.Cursor = new Cursor(Properties.Resources.icone_res.Handle); break;
                case 77: button22.Cursor = new Cursor(Properties.Resources.icone_res.Handle); break;
                case 79: button22.Cursor = new Cursor(Properties.Resources.icone_res.Handle); break;
                case 81: button22.Cursor = new Cursor(Properties.Resources.icone_res.Handle); break;
                case 83: button22.Cursor = new Cursor(Properties.Resources.icone_res.Handle); break;

                case 100: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 101: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 102: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 103: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 104: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 105: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 106: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 107: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 108: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 109: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 110: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 111: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 112: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;
                case 113: button22.Cursor = new Cursor(Properties.Resources.icone_contAux.Handle); break;

                case 114: button22.Cursor = new Cursor(Properties.Resources.icone_contador1.Handle); break;
                case 115: button22.Cursor = new Cursor(Properties.Resources.icone_contador1.Handle); break;

                case 116: button22.Cursor = new Cursor(Properties.Resources.icone_espera.Handle); break;
                case 117: button22.Cursor = new Cursor(Properties.Resources.icone_espera.Handle); break;
                case 118: button22.Cursor = new Cursor(Properties.Resources.icone_espera.Handle); break;
                case 119: button22.Cursor = new Cursor(Properties.Resources.icone_espera.Handle); break;
                case 120: button22.Cursor = new Cursor(Properties.Resources.icone_espera.Handle); break;
                case 121: button22.Cursor = new Cursor(Properties.Resources.icone_espera.Handle); break;
                case 122: button22.Cursor = new Cursor(Properties.Resources.icone_espera.Handle); break;
                case 123: button22.Cursor = new Cursor(Properties.Resources.icone_espera.Handle); break;

                case 124: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 125: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 126: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 127: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 128: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 129: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 130: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 131: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 132: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 133: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 134: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 135: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 136: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 137: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 138: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 139: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 140: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 141: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 142: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 143: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 144: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 145: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 146: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;
                case 147: button22.Cursor = new Cursor(Properties.Resources.icone_tempo.Handle); break;

                case 148: button22.Cursor = new Cursor(Properties.Resources.icone_display.Handle); break;
                case 149: button22.Cursor = new Cursor(Properties.Resources.icone_display.Handle); break;
                case 150: button22.Cursor = new Cursor(Properties.Resources.icone_display.Handle); break;
                case 151: button22.Cursor = new Cursor(Properties.Resources.icone_display.Handle); break;
                case 152: button22.Cursor = new Cursor(Properties.Resources.icone_display.Handle); break;
                case 153: button22.Cursor = new Cursor(Properties.Resources.icone_display.Handle); break;
                case 154: button22.Cursor = new Cursor(Properties.Resources.icone_display.Handle); break;
                case 155: button22.Cursor = new Cursor(Properties.Resources.icone_display.Handle); break;

                case 156: button22.Cursor = new Cursor(Properties.Resources.icone_ang.Handle); break;
                case 157: button22.Cursor = new Cursor(Properties.Resources.icone_ang.Handle); break;
                case 158: button22.Cursor = new Cursor(Properties.Resources.icone_ang.Handle); break;
                case 159: button22.Cursor = new Cursor(Properties.Resources.icone_ang.Handle); break;

                case 36: button22.Cursor = new Cursor(Properties.Resources.icone_bimanual.Handle); break;
                case 37: button22.Cursor = new Cursor(Properties.Resources.icone_bimanual.Handle); break;

                case 38: button22.Cursor = new Cursor(Properties.Resources.icone_bit.Handle); break;
                case 39: button22.Cursor = new Cursor(Properties.Resources.icone_bit.Handle); break;
                
                default: button22.Cursor = Cursors.Arrow; break;
            }
        }
        private void Completar(object sender, DataGridViewCellEventArgs e)
        {
            int Cell_select = ((DataGridView)sender).CurrentCell.RowIndex;
            if(completar != 1)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (mat[Cell_select, j] == 0)
                        {
                            dataGridView1.Rows[Cell_select].Cells[j].Value = Properties.Resources.CONTINUO;
                            mat[Cell_select, j] = 1;
                        }
                    }
                }
            }
            
        }
        public void BotaoInvisivel(object sender, DataGridViewCellEventArgs e)
        {
            int cell_linha = ((DataGridView)sender).CurrentCell.RowIndex;
            int cell_coluna = ((DataGridView)sender).CurrentCell.ColumnIndex + 1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = cell_coluna; j < dataGridView1.Columns.Count; j++)
                {
                    if (click_selecionar[1] == 202 || click_selecionar[1] == 201 )
                    {
                        dataGridView1.Rows[cell_linha].Cells[cell_coluna].Value = Properties.Resources.botao_invisivel;
                        mat[cell_linha, cell_coluna] = botao_invisivel;
                        cell_coluna++;
                    }

                    else
                    {
                        dataGridView1.Rows[cell_linha].Cells[cell_coluna].Value = Properties.Resources.linhas_gridview;
                        mat[cell_linha, cell_coluna] = 0;
                        if (mat[cell_linha, cell_coluna] != 0)
                        {
                            ((DataGridView)sender).CurrentCell.Value = button22.BackgroundImage;
                            mat[cell_linha, cell_coluna] = or;
                        }                      
                        cell_coluna++;
                    }
                }
            }
        }
        public void excluir_invisivel(object sender, DataGridViewCellEventArgs e)
        {
            int cell_linha = ((DataGridView)sender).CurrentCell.RowIndex;
            int cell_coluna = ((DataGridView)sender).CurrentCell.ColumnIndex + 1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = cell_coluna; j < dataGridView1.Columns.Count; j++)
                {
                    if (click_selecionar[1] == 0)
                    {
                        dataGridView1.Rows[cell_linha].Cells[cell_coluna].Value = Properties.Resources.linhas_gridview;
                        mat[cell_linha, cell_coluna] = 0;
                        cell_coluna++;
                    }
                }
            }
        }
        public void ProibirEntradasNaSaidas_valor(object sender, EventArgs e)
        {
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (j == 16)
                    {
                        switch (click_selecionar[1])
                        {
                            case 4: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 5: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 6: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 7: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 8: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 9: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 10: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 11: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 12: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 13: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 14: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 15: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 16: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 17: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 18: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 19: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 20: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 21: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 22: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 23: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 24: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 25: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 26: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 27: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 28: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 29: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 30: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 31: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 32: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 33: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 156: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 157: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 158: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;
                            case 159: mat[i, j] = 0; completar = 1; ((DataGridView)sender).CurrentCell.Value = Properties.Resources.linhas_gridview; break;

                        }
                    }
                }
            }
        }
        public void ProibirEntradasNaSaidas_imagem(object sender, EventArgs e)
        {
            switch (click_selecionar[1])
            {
                case 52: button22.BackgroundImage = Properties.Resources.SNA_E01; break;
                case 54: button22.BackgroundImage = Properties.Resources.SNA_E02; break;
                case 56: button22.BackgroundImage = Properties.Resources.SNA_E03; break;
                case 58: button22.BackgroundImage = Properties.Resources.SNA_E04; break;
                case 60: button22.BackgroundImage = Properties.Resources.SNA_E05; break;
                case 62: button22.BackgroundImage = Properties.Resources.SNA_E06; break;
                case 64: button22.BackgroundImage = Properties.Resources.SNA_E07; break;
                case 66: button22.BackgroundImage = Properties.Resources.SNA_E08; break;

                case 53: button22.BackgroundImage = Properties.Resources.SNF_E01; break;
                case 55: button22.BackgroundImage = Properties.Resources.SNF_E02; break;
                case 57: button22.BackgroundImage = Properties.Resources.SNF_E03; break;
                case 59: button22.BackgroundImage = Properties.Resources.SNF_E04; break;
                case 61: button22.BackgroundImage = Properties.Resources.SNF_E05; break;
                case 63: button22.BackgroundImage = Properties.Resources.SNF_E06; break;
                case 65: button22.BackgroundImage = Properties.Resources.SNF_E07; break;
                case 67: button22.BackgroundImage = Properties.Resources.SNF_E08; break;

                case 68: button22.BackgroundImage = Properties.Resources.SET_E01; break;
                case 70: button22.BackgroundImage = Properties.Resources.SET_E02; break;
                case 72: button22.BackgroundImage = Properties.Resources.SET_E03; break;
                case 74: button22.BackgroundImage = Properties.Resources.SET_E04; break;
                case 76: button22.BackgroundImage = Properties.Resources.SET_E05; break;
                case 78: button22.BackgroundImage = Properties.Resources.SET_E06; break;
                case 80: button22.BackgroundImage = Properties.Resources.SET_E07; break;
                case 82: button22.BackgroundImage = Properties.Resources.SET_E08; break;

                case 69: button22.BackgroundImage = Properties.Resources.RES_E01; break;
                case 71: button22.BackgroundImage = Properties.Resources.RES_E02; break;
                case 73: button22.BackgroundImage = Properties.Resources.RES_E03; break;
                case 75: button22.BackgroundImage = Properties.Resources.RES_E04; break;
                case 77: button22.BackgroundImage = Properties.Resources.RES_E05; break;
                case 79: button22.BackgroundImage = Properties.Resources.RES_E06; break;
                case 81: button22.BackgroundImage = Properties.Resources.RES_E07; break;
                case 83: button22.BackgroundImage = Properties.Resources.RES_E08; break;

                case 148: button22.BackgroundImage = Properties.Resources.d01; break;
                case 149: button22.BackgroundImage = Properties.Resources.d02; break;
                case 150: button22.BackgroundImage = Properties.Resources.d03; break;
                case 151: button22.BackgroundImage = Properties.Resources.d04; break;
                case 152: button22.BackgroundImage = Properties.Resources.d05; break;
                case 153: button22.BackgroundImage = Properties.Resources.d06; break;
                case 154: button22.BackgroundImage = Properties.Resources.d07; break;
                case 155: button22.BackgroundImage = Properties.Resources.d08; break;

                case 100: button22.BackgroundImage = Properties.Resources.cont_aux01; break;
                case 101: button22.BackgroundImage = Properties.Resources.cont_aux02; break;
                case 102: button22.BackgroundImage = Properties.Resources.cont_aux03; break;
                case 103: button22.BackgroundImage = Properties.Resources.cont_aux04; break;
                case 104: button22.BackgroundImage = Properties.Resources.cont_aux05; break;
                case 105: button22.BackgroundImage = Properties.Resources.cont_aux06; break;
                case 106: button22.BackgroundImage = Properties.Resources.cont_aux07; break;
                case 107: button22.BackgroundImage = Properties.Resources.cont_aux08; break;
                case 108: button22.BackgroundImage = Properties.Resources.cont_aux09; break;
                case 109: button22.BackgroundImage = Properties.Resources.cont_aux10; break;
                case 110: button22.BackgroundImage = Properties.Resources.cont_aux11; break;
                case 111: button22.BackgroundImage = Properties.Resources.cont_aux12; break;
                case 112: button22.BackgroundImage = Properties.Resources.cont_aux13; break;
                case 113: button22.BackgroundImage = Properties.Resources.cont_aux14; break;

                case 114: button22.BackgroundImage = Properties.Resources.contador01; break;
                case 115: button22.BackgroundImage = Properties.Resources.contador02; break;

                case 116: button22.BackgroundImage = Properties.Resources.espera01; break;
                case 117: button22.BackgroundImage = Properties.Resources.espera02; break;
                case 118: button22.BackgroundImage = Properties.Resources.espera03; break;
                case 119: button22.BackgroundImage = Properties.Resources.espera04; break;
                case 120: button22.BackgroundImage = Properties.Resources.espera05; break;
                case 121: button22.BackgroundImage = Properties.Resources.espera06; break;
                case 122: button22.BackgroundImage = Properties.Resources.espera07; break;
                case 123: button22.BackgroundImage = Properties.Resources.espera08; break;

                case 124: button22.BackgroundImage = Properties.Resources.temporizador_01; break;
                case 125: button22.BackgroundImage = Properties.Resources.temporizador_02; break;
                case 126: button22.BackgroundImage = Properties.Resources.temporizador_03; break;
                case 127: button22.BackgroundImage = Properties.Resources.temporizador_04; break;
                case 128: button22.BackgroundImage = Properties.Resources.temporizador_05; break;
                case 129: button22.BackgroundImage = Properties.Resources.temporizador_06; break;
                case 130: button22.BackgroundImage = Properties.Resources.temporizador_07; break;
                case 131: button22.BackgroundImage = Properties.Resources.temporizador_08; break;
                case 132: button22.BackgroundImage = Properties.Resources.temporizador_09; break;
                case 133: button22.BackgroundImage = Properties.Resources.temporizador_10; break;
                case 134: button22.BackgroundImage = Properties.Resources.temporizador_11; break;
                case 135: button22.BackgroundImage = Properties.Resources.temporizador_12; break;
                case 136: button22.BackgroundImage = Properties.Resources.temporizador_13; break;
                case 137: button22.BackgroundImage = Properties.Resources.temporizador_14; break;
                case 138: button22.BackgroundImage = Properties.Resources.temporizador_15; break;
                case 139: button22.BackgroundImage = Properties.Resources.temporizador_16; break;
                case 140: button22.BackgroundImage = Properties.Resources.temporizador_17; break;
                case 141: button22.BackgroundImage = Properties.Resources.temporizador_18; break;
                case 142: button22.BackgroundImage = Properties.Resources.temporizador_19; break;
                case 143: button22.BackgroundImage = Properties.Resources.temporizador_20; break;
                case 144: button22.BackgroundImage = Properties.Resources.temporizador_21; break;
                case 145: button22.BackgroundImage = Properties.Resources.temporizador_22; break;
                case 146: button22.BackgroundImage = Properties.Resources.temporizador_23; break;
                case 147: button22.BackgroundImage = Properties.Resources.temporizador_24; break;

                default: button22.BackgroundImage = Properties.Resources.linhas_gridview; break;
            }
        }
        
       
        private void Form1_Load(object sender, EventArgs e)
        {      
            // Desenhar a forma de um botao
           /* GraphicsPath forma = new GraphicsPath();
            forma.AddPie(0, 0, button115.Width, button115.Height);           
            button115.Region = new Region(forma);*/

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            button22.Image = Properties.Resources.linhas_gridview;
            click_selecionar[1] = 0;
            button2.Visible = false;
            groupBox13.Visible = false;
            groupBox12.Visible = false;
            gb_tabela.Visible = false;
            btn_salvar.Visible = false;
            btn_fechar.Visible = false;
            btn_aux.Visible = false;
            button1.Visible = false;
            dataGridView1.Visible = false;
            btn_simulacao.Visible = false;
            btn_transferir.Visible = false;
            salvar = 1;
            dataGridView1.Rows.Add(250);
            
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {              
                if (linha.Index <= 9)
                {
                    linha.HeaderCell.Value = ("L00" + linha.Index).ToString();
                }
                if (linha.Index <= 99)
                {
                    linha.HeaderCell.Value = ("L0" + linha.Index).ToString();
                }
                else
                {
                    linha.HeaderCell.Value = ("L" + linha.Index).ToString();
                }
            }

            this.Text = "PROGCP96_V1.0";          
            Cursor = button22.Cursor;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = button22.Cursor;
        }

        private void btn_EntradaContinuo_Click_1(object sender, EventArgs e)
        {
            click_selecionar[1] = continuo;
            button22.BackgroundImage = Properties.Resources.CONTINUO;
            Form form2 = Application.OpenForms["Form1"];
            ((Button)form2.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_or.Handle);
        }
        /// <BLOCO CÓDIGO DE OPÇOES DE ENTRADAS SAIDAS E AUXILIARES (GROUPBOX 13)>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary> BLOCO DE OPÇOES DE ENTRADAS,SAIDAS E AUXILIARES (GROUPBOX 13)
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        /// 
        /// 
        /// Abre o form para escolher as ENTRADAS NA 
        private void btn_entradaNA_Click(object sender, EventArgs e)
        {
            ENTRADA_NA formNA = new ENTRADA_NA();
            caminhoarq = this.Text;
            valor = click_selecionar[1];
            formNA.ShowDialog();
         
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.LightGray;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }
        // Abre o form para escolher as ENTRADAS NF 
        private void btn_entradaNF_Click(object sender, EventArgs e)
        {
            ENTRADA_NF janelaNF = new ENTRADA_NF();         
            caminhoarq = this.Text;
            valor = click_selecionar[1];
            janelaNF.ShowDialog();
            

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.LightGray;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }

        // Abre o form para escolher as ENTRADAS BORDA POSITIVA/SUBIDA 
        private void btn_BordaDescida_Click(object sender, EventArgs e)
        {
            BORDA_DESCIDA janelaBorda = new BORDA_DESCIDA();           
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            janelaBorda.ShowDialog();
            

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.LightGray;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }
        // Abre o form para escolher as ENTRADAS BORDA SUBIDA/DESCIDA
        private void btn_BordaSubida_Click(object sender, EventArgs e)
        {
            BORDA_SUBIDA janelaBS = new BORDA_SUBIDA();                   
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            janelaBS.ShowDialog();
            
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.LightGray;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }
        // Abre o form para escolher as SAÍDAS NA 
        private void button115_Click(object sender, EventArgs e)
        {
            SAIDA_NA janelaJNA = new SAIDA_NA();            
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            janelaJNA.ShowDialog();
            

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.LightGray;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;


        }
        // Abre o form para escolher as SAIDAS NF
        private void btn_saidaNF_Click(object sender, EventArgs e)
        {
            SAIDA_NF janelaJNF = new SAIDA_NF();           
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            janelaJNF.ShowDialog();
           

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.LightGray;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }
        // Abre o form para escolher as SAIDAS SET
        private void btn_saidaSet_Click(object sender, EventArgs e)
        {
            SAIDA_SET janelaSset = new SAIDA_SET();           
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            janelaSset.ShowDialog();
           
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.LightGray;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }
        // Abre o form para escolher as SAIDAS RESET
        private void btn_saidaReset_Click(object sender, EventArgs e)
        {
            SAIDA_RESET janelaSRE = new SAIDA_RESET();         
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            janelaSRE.ShowDialog();
          

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.LightGray;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }
        // Abre o form para escolher as SAIDAS ANALOGICAS
        private void btn_Aux_Analogicas_Click(object sender, EventArgs e)
        {
            AUXILIAR_ANALOGICA janelaAUX = new AUXILIAR_ANALOGICA();           
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            janelaAUX.ShowDialog();
            

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.LightGray;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;

            repassandoCaminho = this.Text;
        }
        // Abre a opção "OR"
        private void btn_OR_Click(object sender, EventArgs e)
        {          
            click_selecionar[1] = or;
            Form form4 = Application.OpenForms["Form1"];
            ((Button)form4.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_or.Handle);

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.LightGray;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;

        }
        // Abre a opção "DELETE"
        private void btn_FDelete_Click(object sender, EventArgs e)
        {
            click_selecionar[1] = 0;
            button22.BackgroundImage = Properties.Resources.linhas_gridview;
            img = Properties.Resources.linhas_gridview;
            Form form4 = Application.OpenForms["Form1"];
            ((Button)form4.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_del.Handle);
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = img;
            ((Button)form4.Controls["button22"]).Text = null;

            valor = click_selecionar[1];

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.LightGray;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
        }

        //Abre a opção "AND"
        private void btn_FContinuo_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.CONTINUO;
            click_selecionar[1] = 1;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = img;
            Form form9 = Application.OpenForms["Form1"];
            ((Button)form9.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_continuo.Handle);

            btn_FContinuo.BackColor = Color.LightGray;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
        }
        //Abre a opção "Continuo"
        private void button26_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.CONTINUO;
            click_selecionar[1] = 3;
            Form form = Application.OpenForms["Form1"];
            ((Button)form.Controls["button22"]).BackgroundImage = img;
            Form form9 = Application.OpenForms["Form1"];
            ((Button)form9.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_continuo.Handle);
            ((Button)form9.Controls["button22"]).Text = null;
            valor = click_selecionar[1];

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
        }
        /// <BLOCO CÓDIGO DE ÍCONES>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary> BLOCO CÓDIGO DE ÍCONES
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        //Ícone "novo Projeto"
        public void btn_novo_Click(object sender, EventArgs e)
        { 
            FolderBrowserDialog diretorio = new FolderBrowserDialog();
            diretorio.Description = "Selecionar diretorio";
          
            if (diretorio.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(diretorio.SelectedPath);

                FileInfo[] TXTFiles = di.GetFiles("*.prj");
                    if (TXTFiles.Length > 0)
                    {
                        MessageBox.Show("Já existe projeto nesse diretório.Selecione outro diretório");
                        btn_novo_Click(sender, e);
                    }
                    else
                    {
                        SaveFileDialog arquivoSalvo = new SaveFileDialog();
                        arquivoSalvo.InitialDirectory = diretorio.SelectedPath;
                        arquivoSalvo.Filter = "*.prj | *.prj";
                        arquivoSalvo.Title = "Novo Projeto";

                        if (arquivoSalvo.ShowDialog() == DialogResult.OK)
                        {
                            NomeArquivo = arquivoSalvo.FileName;
                            arquivo = arquivoSalvo.FileName;

                            // transforma a matriz[8x17] para um vet[136]
                            int indice = 0;
                            for (int i = 0; i < 11; i++)
                            {
                                for (int j = 0; j < 17; j++)
                                {
                                    vetor[indice] = (byte)mat[i, j];
                                    indice++;
                                }
                            }
                            try
                            {
                                using (var fs = new FileStream(arquivoSalvo.FileName, FileMode.Create, FileAccess.Write))
                                {
                                    fs.Write(vetor, 0, vetor.Length);                                 
                                    groupBox13.Visible = true;
                                    groupBox12.Visible = true;
                                    arquivo = arquivoSalvo.FileName;
                                }

                                using (var fs2 = new FileStream(arquivo, FileMode.Create, FileAccess.Write))
                                {
                                    fs2.Write(vetor, 0, vetor.Length);                                
                                    groupBox13.Visible = true;
                                    groupBox12.Visible = true;
                                }

                            }
                            catch (Exception ex)
                            {

                            }

                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
                            if (File.Exists(arquivo))
                            {
                                FileInfo fileInfo = new FileInfo(arquivo);
                                caminho = fileInfo.DirectoryName; // verifica qual o diretorio do arquivo e escreve no text do forms(cabeçalho)
                                this.Text = caminho;
                                caminhoAntigo = this.Text;
                                btn_salvar.Visible = true;
                                btn_fechar.Visible = true;
                                btn_novo.Visible = false;
                                dataGridView1.Visible = true;
                                button1.Visible = true;               
                                btn_abrir.Visible = false;
                            }
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string BM1 = this.Text + @"\FileBM1.txt";
                            caminhoarq = this.Text;
                            StreamWriter BIM = new StreamWriter(BM1);
                            string fraseBM1 = "Configuracao Bimanual 01:;0000;0001;0000;0;";
                            char[] vetCharBM1 = fraseBM1.ToCharArray();
                            foreach (char letra in vetCharBM1)
                                BIM.Write(letra);
                            BIM.Close();
                            RecebendoconteudoBM1 = fraseBM1;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////               
                            string BM2 = this.Text + @"\FileBM2.txt";
                            caminhoarq = this.Text;
                            StreamWriter BIM2 = new StreamWriter(BM2);
                            string fraseBM2 = "Configuracao Bimanual 02:;0000;0001;0000;0;";
                            char[] vetCharBM2 = fraseBM2.ToCharArray();
                            foreach (char letra in vetCharBM2)
                                BIM2.Write(letra);
                            BIM2.Close();
                            RecebendoconteudoBM2 = fraseBM2;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string adj1 = this.Text + @"\FileB01.txt";
                            caminhoarq = this.Text;
                            StreamWriter ad = new StreamWriter(adj1);
                            string fraseADJ = "Habilitar funcao 01:     ;0000;0001;0000;0;";//bit
                            char[] vetCharADJ = fraseADJ.ToCharArray();
                            foreach (char letra in vetCharADJ)
                                ad.Write(letra);
                            ad.Close();
                            RecebendoconteudoADJ00 = fraseADJ;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string adj2 = this.Text + @"\FileB02.txt";
                            caminhoarq = this.Text;
                            StreamWriter ad2 = new StreamWriter(adj2);
                            string fraseADJ2 = "Habilitar funcao 02:     ;0000;0001;0000;0;";//bit
                            char[] vetCharADJ2 = fraseADJ2.ToCharArray();
                            foreach (char letra in vetCharADJ2)
                                ad2.Write(letra);
                            ad2.Close();
                            RecebendoconteudoADJ01 = fraseADJ2;
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string comentarios = this.Text + @"\Comentarios.txt";
                            caminhoarq = this.Text;
                            StreamWriter coment = new StreamWriter(comentarios);
                            string conteudo =
                              " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                              " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                              " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                              " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                              " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                              " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " ";

                            char[] vetConteudo = conteudo.ToCharArray();
                            foreach (char letra in vetConteudo)
                                coment.WriteLine(letra);
                            coment.Close();
                            RecebendoComentario = conteudo;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string contador1 = this.Text + @"\FileC01.txt";
                            caminhoarq = this.Text;
                            StreamWriter c = new StreamWriter(contador1);
                            string frase = "Configuracao Contador 01:;0100;0999;0001;0;";
                            char[] vetChar = frase.ToCharArray();
                            foreach (char letra in vetChar)
                                c.Write(letra);
                            c.Close();
                            RecebendoconteudoCont01 = frase;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string contador2 = this.Text + @"\FileC02.txt";
                            StreamWriter c2 = new StreamWriter(contador2);
                            string frase2 = "Configuracao Contador 02:;0100;0999;0001;0;";
                            char[] vetChar2 = frase2.ToCharArray();
                            foreach (char letra2 in vetChar2)
                                c2.Write(letra2);
                            c2.Close();
                            RecebendoconteudoCont02 = frase2;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////           
                            string display1 = this.Text + @"\FileD01.txt";
                            StreamWriter d1 = new StreamWriter(display1);
                            string frase9 = "                                                                ";
                            char[] vetChar9 = frase9.ToCharArray();
                            foreach (char letra9 in vetChar9)
                                d1.Write(letra9);
                            d1.Close();
                            RecebendoconteudoMsg01 = frase9;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string display2 = this.Text + @"\FileD02.txt";
                            StreamWriter d2 = new StreamWriter(display2);
                            string frase10 = "                                                                ";
                            char[] vetChar10 = frase10.ToCharArray();
                            foreach (char letra10 in vetChar10)
                                d2.Write(letra10);
                            d2.Close();
                            RecebendoconteudoMsg02_2 = frase10;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string display3 = this.Text + @"\FileD03.txt";
                            StreamWriter d3 = new StreamWriter(display3);
                            string frase11 = "                                                                ";
                            char[] vetChar11 = frase11.ToCharArray();
                            foreach (char letra11 in vetChar11)
                                d3.Write(letra11);
                            d3.Close();
                            RecebendoconteudoMsg03 = frase11;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string display4 = this.Text + @"\FileD04.txt";
                            StreamWriter d4 = new StreamWriter(display4);
                            string frase12 = "                                                                ";
                            char[] vetChar12 = frase12.ToCharArray();
                            foreach (char letra12 in vetChar12)
                                d4.Write(letra12);
                            d4.Close();
                            RecebendoconteudoMsg04 = frase12;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string display5 = this.Text + @"\FileD05.txt";
                            StreamWriter d5 = new StreamWriter(display5);
                            string frase13 = "                                                                ";
                            char[] vetChar13 = frase13.ToCharArray();
                            foreach (char letra13 in vetChar13)
                                d5.Write(letra13);
                            d5.Close();
                            RecebendoconteudoMsg05 = frase13;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string display6 = this.Text + @"\FileD06.txt";
                            StreamWriter d6 = new StreamWriter(display6);
                            string frase14 = "                                                                ";
                            char[] vetChar14 = frase14.ToCharArray();
                            foreach (char letra14 in vetChar14)
                                d6.Write(letra14);
                            d6.Close();
                            RecebendoconteudoMsg06 = frase14;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string display7 = this.Text + @"\FileD07.txt";
                            StreamWriter d7 = new StreamWriter(display7);
                            string frase15 = "                                                                ";
                            char[] vetChar15 = frase15.ToCharArray();
                            foreach (char letra15 in vetChar15)
                                d7.Write(letra15);
                            d7.Close();
                            RecebendoconteudoMsg07 = frase15;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string display8 = this.Text + @"\FileD08.txt";
                            StreamWriter d8 = new StreamWriter(display8);
                            string frase16 = "                                                                ";
                            char[] vetChar16 = frase16.ToCharArray();
                            foreach (char letra16 in vetChar16)
                                d8.Write(letra16);
                            d8.Close();
                            RecebendoconteudoMsg08 = frase16;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string display00 = this.Text + @"\FileD00.txt";
                            StreamWriter d0 = new StreamWriter(display00);
                            string telazero = "Tela de Trabalho Aguardando...                                 ";
                            char[] vetChar00 = telazero.ToCharArray();
                            foreach (char letra16 in vetChar00)
                                d0.Write(letra16);
                            d0.Close();
                            RecebendoconteudoMsg00 = telazero;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo1 = this.Text + @"\FileR01.txt";
                            StreamWriter r1 = new StreamWriter(retardo1);
                            string frase17 = "Configuracao Espera   01:;0100;0999;0001;0;";
                            char[] vetChar17 = frase17.ToCharArray();
                            foreach (char letra17 in vetChar17)
                                r1.Write(letra17);
                            r1.Close();
                            RecebendoconteudoRet01 = frase17;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo2 = this.Text + @"\FileR02.txt";
                            StreamWriter r2 = new StreamWriter(retardo2);
                            string frase18 = "Configuracao Espera   02:;0100;0999;0001;0;";
                            char[] vetChar18 = frase18.ToCharArray();
                            foreach (char letra18 in vetChar18)
                                r2.Write(letra18);
                            r2.Close();
                            RecebendoconteudoRet02 = frase18;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo3 = this.Text + @"\FileR03.txt";
                            StreamWriter r3 = new StreamWriter(retardo3);
                            string frase19 = "Configuracao Espera   03:;0100;0999;0001;0;";
                            char[] vetChar19 = frase19.ToCharArray();
                            foreach (char letra19 in vetChar19)
                                r3.Write(letra19);
                            r3.Close();
                            RecebendoconteudoRet03 = frase19;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo4 = this.Text + @"\FileR04.txt";
                            StreamWriter r4 = new StreamWriter(retardo4);
                            string frase20 = "Configuracao Espera   04:;0100;0999;0001;0;";
                            char[] vetChar20 = frase20.ToCharArray();
                            foreach (char letra20 in vetChar20)
                                r4.Write(letra20);
                            r4.Close();
                            RecebendoconteudoRet04 = frase20;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo5 = this.Text + @"\FileR05.txt";
                            StreamWriter r5 = new StreamWriter(retardo5);
                            string frase21 = "Configuracao Espera   05:;0100;0999;0001;0;";
                            char[] vetChar21 = frase21.ToCharArray();
                            foreach (char letra21 in vetChar21)
                                r5.Write(letra21);
                            r5.Close();
                            RecebendoconteudoRet05 = frase21;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo6 = this.Text + @"\FileR06.txt";
                            StreamWriter r6 = new StreamWriter(retardo6);
                            string frase22 = "Configuracao Espera   06:;0100;0999;0001;0;";
                            char[] vetChar22 = frase22.ToCharArray();
                            foreach (char letra22 in vetChar22)
                                r6.Write(letra22);
                            r6.Close();
                            RecebendoconteudoRet06 = frase22;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo7 = this.Text + @"\FileR07.txt";
                            StreamWriter r7 = new StreamWriter(retardo7);
                            string frase23 = "Configuracao Espera   07:;0100;0999;0001;0;";
                            char[] vetChar23 = frase23.ToCharArray();
                            foreach (char letra23 in vetChar23)
                                r7.Write(letra23);
                            r7.Close();
                            RecebendoconteudoRet07 = frase23;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo8 = this.Text + @"\FileR08.txt";
                            StreamWriter r8 = new StreamWriter(retardo8);
                            string frase24 = "Configuracao Espera   08:;0100;0999;0001;0;";
                            char[] vetChar24 = frase24.ToCharArray();
                            foreach (char letra24 in vetChar24)
                                r8.Write(letra24);
                            r8.Close();
                            RecebendoconteudoRet08 = frase24;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo1 = this.Text + @"\FileT01.txt";
                            StreamWriter t1 = new StreamWriter(tempo1);
                            frase = "Configuracao do tempo 01:;0100;0999;0001;0;";
                            char[] vetChar25 = frase.ToCharArray();
                            foreach (char letra25 in vetChar25)
                                t1.Write(letra25);
                            t1.Close();
                            RecebendoconteudoTempo01 = frase;

                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo2 = this.Text + @"\FileT02.txt";
                            StreamWriter t2 = new StreamWriter(tempo2);
                            string frase26 = "Configuracao do tempo 02:;0100;0999;0001;0;";
                            char[] vetChar26 = frase26.ToCharArray();
                            foreach (char letra26 in vetChar26)
                                t2.Write(letra26);
                            t2.Close();
                            RecebendoconteudoTempo02 = frase26;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo3 = this.Text + @"\FileT03.txt";
                            StreamWriter t3 = new StreamWriter(tempo3);
                            string frase27 = "Configuracao do tempo 03:;0100;0999;0001;0;";
                            char[] vetChar27 = frase27.ToCharArray();
                            foreach (char letra27 in vetChar27)
                                t3.Write(letra27);
                            t3.Close();
                            RecebendoconteudoTempo03 = frase27;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo4 = this.Text + @"\FileT04.txt";
                            StreamWriter t4 = new StreamWriter(tempo4);
                            string frase28 = "Configuracao do tempo 04:;0100;0999;0001;0;";
                            char[] vetChar28 = frase28.ToCharArray();
                            foreach (char letra28 in vetChar28)
                                t4.Write(letra28);
                            t4.Close();
                            RecebendoconteudoTempo04 = frase28;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo5 = this.Text + @"\FileT05.txt";
                            StreamWriter t5 = new StreamWriter(tempo5);
                            string frase29 = "Configuracao do tempo 05:;0100;0999;0001;0;";
                            char[] vetChar29 = frase29.ToCharArray();
                            foreach (char letra29 in vetChar29)
                                t5.Write(letra29);
                            t5.Close();
                            RecebendoconteudoTempo05 = frase29;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo6 = this.Text + @"\FileT06.txt";
                            StreamWriter t6 = new StreamWriter(tempo6);
                            string frase30 = "Configuracao do tempo 06:;0100;0999;0001;0;";
                            char[] vetChar30 = frase30.ToCharArray();
                            foreach (char letra30 in vetChar30)
                                t6.Write(letra30);
                            t6.Close();
                            RecebendoconteudoTempo06 = frase30;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo7 = this.Text + @"\FileT07.txt";
                            StreamWriter t7 = new StreamWriter(tempo7);
                            string frase31 = "Configuracao do tempo 07:;0100;0999;0001;0;";
                            char[] vetChar31 = frase31.ToCharArray();
                            foreach (char letra31 in vetChar31)
                                t7.Write(letra31);
                            t7.Close();
                            RecebendoconteudoTempo07 = frase31;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo8 = this.Text + @"\FileT08.txt";
                            StreamWriter t8 = new StreamWriter(tempo8);
                            string frase32 = "Configuracao do tempo 08:;0100;0999;0001;0;";
                            char[] vetChar32 = frase32.ToCharArray();
                            foreach (char letra32 in vetChar32)
                                t8.Write(letra32);
                            t8.Close();
                            RecebendoconteudoTempo08 = frase32;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo9 = this.Text + @"\FileT09.txt";
                            StreamWriter t9 = new StreamWriter(tempo9);
                            string frase33 = "Configuracao do tempo 09:;0100;0999;0001;0;";
                            char[] vetChar33 = frase33.ToCharArray();
                            foreach (char letra33 in vetChar33)
                                t9.Write(letra33);
                            t9.Close();
                            RecebendoconteudoTempo09 = frase33;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo10 = this.Text + @"\FileT10.txt";
                            StreamWriter t10 = new StreamWriter(tempo10);
                            string frase34 = "Configuracao do tempo 10:;0100;0999;0001;0;";
                            char[] vetChar34 = frase34.ToCharArray();
                            foreach (char letra34 in vetChar34)
                                t10.Write(letra34);
                            t10.Close();
                            RecebendoconteudoTempo10 = frase34;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo11 = this.Text + @"\FileT11.txt";
                            StreamWriter t11 = new StreamWriter(tempo11);
                            string frase35 = "Configuracao do tempo 11:;0100;0999;0001;0;";
                            char[] vetChar35 = frase35.ToCharArray();
                            foreach (char letra35 in vetChar35)
                                t11.Write(letra35);
                            t11.Close();
                            RecebendoconteudoTempo11 = frase35;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo12 = this.Text + @"\FileT12.txt";
                            StreamWriter t12 = new StreamWriter(tempo12);
                            string frase36 = "Configuracao do tempo 12:;0100;0999;0001;0;";
                            char[] vetChar36 = frase36.ToCharArray();
                            foreach (char letra36 in vetChar36)
                                t12.Write(letra36);
                            t12.Close();
                            RecebendoconteudoTempo12 = frase36;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo13 = this.Text + @"\FileT13.txt";
                            StreamWriter t13 = new StreamWriter(tempo13);
                            string frase37 = "Configuracao do tempo 13:;0100;0999;0001;0;";
                            char[] vetChar37 = frase37.ToCharArray();
                            foreach (char letra37 in vetChar37)
                                t13.Write(letra37);
                            t13.Close();
                            RecebendoconteudoTempo13 = frase37;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo14 = this.Text + @"\FileT14.txt";
                            StreamWriter t14 = new StreamWriter(tempo14);
                            string frase38 = "Configuracao do tempo 14:;0100;0999;0001;0;";
                            char[] vetChar38 = frase38.ToCharArray();
                            foreach (char letra38 in vetChar38)
                                t14.Write(letra38);
                            t14.Close();
                            RecebendoconteudoTempo14 = frase38;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo15 = this.Text + @"\FileT15.txt";
                            StreamWriter t15 = new StreamWriter(tempo15);
                            string frase39 = "Configuracao do tempo 15:;0100;0999;0001;0;";
                            char[] vetChar39 = frase39.ToCharArray();
                            foreach (char letra39 in vetChar39)
                                t15.Write(letra39);
                            t15.Close();
                            RecebendoconteudoTempo15 = frase39;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo16 = this.Text + @"\FileT16.txt";
                            StreamWriter t16 = new StreamWriter(tempo16);
                            string frase40 = "Configuracao do tempo 16:;0100;0999;0001;0;";
                            char[] vetChar40 = frase40.ToCharArray();
                            foreach (char letra40 in vetChar40)
                                t16.Write(letra40);
                            t16.Close();
                            RecebendoconteudoTempo16 = frase40;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo17 = this.Text + @"\FileT17.txt";
                            StreamWriter t17 = new StreamWriter(tempo17);
                            string frase41 = "Configuracao do tempo 17:;0100;0999;0001;0;";
                            char[] vetChar41 = frase41.ToCharArray();
                            foreach (char letra41 in vetChar41)
                                t17.Write(letra41);
                            t17.Close();
                            RecebendoconteudoTempo17 = frase41;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo18 = this.Text + @"\FileT18.txt";
                            StreamWriter t18 = new StreamWriter(tempo18);
                            string frase42 = "Configuracao do tempo 18:;0100;9099;0001;0;";
                            char[] vetChar42 = frase42.ToCharArray();
                            foreach (char letra42 in vetChar42)
                                t18.Write(letra42);
                            t18.Close();
                            RecebendoconteudoTempo18 = frase42;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo19 = this.Text + @"\FileT19.txt";
                            StreamWriter t19 = new StreamWriter(tempo19);
                            string frase43 = "Configuracao do tempo 19:;0100;0999;0001;0;";
                            char[] vetChar43 = frase43.ToCharArray();
                            foreach (char letra43 in vetChar43)
                                t19.Write(letra43);
                            t19.Close();
                            RecebendoconteudoTempo19 = frase43;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo20 = this.Text + @"\FileT20.txt";
                            StreamWriter t20 = new StreamWriter(tempo20);
                            string frase44 = "Configuracao do tempo 20:;0100;0999;0001;0;";
                            char[] vetChar44 = frase44.ToCharArray();
                            foreach (char letra44 in vetChar44)
                                t20.Write(letra44);
                            t20.Close();
                            RecebendoconteudoTempo20 = frase44;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo21 = this.Text + @"\FileT21.txt";
                            StreamWriter t21 = new StreamWriter(tempo21);
                            string frase45 = "Configuracao do tempo 21:;0100;0999;0001;0;";
                            char[] vetChar45 = frase45.ToCharArray();
                            foreach (char letra45 in vetChar45)
                                t21.Write(letra45);
                            t21.Close();
                            RecebendoconteudoTempo21 = frase45;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo22 = this.Text + @"\FileT22.txt";
                            StreamWriter t22 = new StreamWriter(tempo22);
                            string frase46 = "Configuracao do tempo 22:;0100;0999;0001;0;";
                            char[] vetChar46 = frase46.ToCharArray();
                            foreach (char letra46 in vetChar46)
                                t22.Write(letra46);
                            t22.Close();
                            RecebendoconteudoTempo22 = frase46;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo23 = this.Text + @"\FileT23.txt";
                            StreamWriter t23 = new StreamWriter(tempo23);
                            string frase47 = "Configuracao do tempo 23:;0100;0999;0001;0;";
                            char[] vetChar47 = frase47.ToCharArray();
                            foreach (char letra47 in vetChar47)
                                t23.Write(letra47);
                            t23.Close();
                            RecebendoconteudoTempo23 = frase47;
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo24 = this.Text + @"\FileT24.txt";
                            StreamWriter t24 = new StreamWriter(tempo24);
                            string frase48 = "Configuracao do tempo 24:;0100;0999;0001;0;";
                            char[] vetChar48 = frase48.ToCharArray();
                            foreach (char letra48 in vetChar48)
                                t24.Write(letra48);
                            t24.Close();
                            RecebendoconteudoTempo24 = frase48;
                            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////              
                            string analogica1 = this.Text + @"\FileA01.txt";
                            caminhoarq = this.Text;
                            StreamWriter A01 = new StreamWriter(analogica1);
                            string frase49 = "Configuracao Analogica 01;0100;0999;0001;0;";
                            char[] vetChar49 = frase49.ToCharArray();
                            foreach (char letra3 in vetChar49)
                                A01.Write(letra3);
                            A01.Close();
                            RecebendoconteudoA01 = frase49;
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string analogica2 = this.Text + @"\FileA02.txt";
                            caminhoarq = this.Text;
                            StreamWriter A02 = new StreamWriter(analogica2);
                            string frase50 = "Configuracao Analogica 02;0100;0999;0001;0;";
                            char[] vetChar50 = frase50.ToCharArray();
                            foreach (char letra50 in vetChar50)
                                A02.Write(letra50);
                            A02.Close();
                            RecebendoconteudoA02 = frase50;
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string analogica3 = this.Text + @"\FileA03.txt";
                            caminhoarq = this.Text;
                            StreamWriter A03 = new StreamWriter(analogica3);
                            string frase51 = "Configuracao Analogica 03;0100;0999;0001;0;";
                            char[] vetChar51 = frase51.ToCharArray();
                            foreach (char letra51 in vetChar51)
                                A03.Write(letra51);
                            A03.Close();
                            RecebendoconteudoA03 = frase51;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string analogica4 = this.Text + @"\FileA04.txt";
                            caminhoarq = this.Text;
                            StreamWriter A04 = new StreamWriter(analogica4);
                            string frase52 = "Configuracao Analogica 04;0100;0999;0001;0;";
                            char[] vetChar52 = frase52.ToCharArray();
                            foreach (char letra52 in vetChar52)
                                A04.Write(letra52);
                            A04.Close();
                            RecebendoconteudoA04 = frase52;

                            string coment2 = this.Text + @"\Comentarios.txt";

                            allLines = File.ReadAllLines(coment2);

                            for (int i = 0; i < allLines.Length; i++)
                            {

                            if (allLines[i].Length < 1)
                            {
                                allLines[i] = allLines[i] + "     ";
                            }
                            if (allLines[i].Length < 2)
                            {
                                allLines[i] = allLines[i] + "    ";
                            }
                            else if (allLines[i].Length < 3)
                            {
                                allLines[i] = allLines[i] + "   ";
                            }
                            else if (allLines[i].Length < 4)
                            {
                                allLines[i] = allLines[i] + "  ";
                            }
                            else if (allLines[i].Length < 5)
                            {
                                allLines[i] = allLines[i] + " ";
                            }
                        }


                            linha0  = allLines[0];
                            linha1  = allLines[1];
                            linha2  = allLines[2];
                            linha3  = allLines[3];
                            linha4  = allLines[4];
                            linha5  = allLines[5];
                            linha6  = allLines[6];
                            linha7  = allLines[7];

                            linha8  = allLines[8];
                            linha9  = allLines[9];
                            linha10 = allLines[10];
                            linha11 = allLines[11];
                            linha12 = allLines[12];
                            linha13 = allLines[13];
                            linha14 = allLines[14];
                            linha15 = allLines[15];

                            linha16 = allLines[16];
                            linha17 = allLines[17];
                            linha18 = allLines[18];
                            linha19 = allLines[19];
                            linha20 = allLines[20];
                            linha21 = allLines[21];
                            linha22 = allLines[22];
                            linha23 = allLines[23];

                            linha24 = allLines[24];
                            linha25 = allLines[25];
                            linha26 = allLines[26];
                            linha27 = allLines[27];
                            linha28 = allLines[28];
                            linha29 = allLines[29];
                            linha30 = allLines[30];
                            linha31 = allLines[31];

                            linha32 = allLines[32];
                            linha33 = allLines[33];
                            linha34 = allLines[34];
                            linha35 = allLines[35];
                            linha36 = allLines[36];
                            linha37 = allLines[37];
                            linha38 = allLines[38];
                            linha39 = allLines[39];
    
                            linha40 = allLines[40];
                            linha41 = allLines[41];
                            linha42 = allLines[42];
                            linha43 = allLines[43];
                            linha44 = allLines[44];
                            linha45 = allLines[45];
                            linha46 = allLines[46];
                            linha47 = allLines[47];

                            linha48 = allLines[48];
                            linha49 = allLines[49];
                            linha50 = allLines[50];
                            linha51 = allLines[51];
                            linha52 = allLines[52];
                            linha53 = allLines[53];
                            linha54 = allLines[54];
                            linha55 = allLines[55];
    
                            linha56 = allLines[56];
                            linha57 = allLines[57];
                            linha58 = allLines[58];
                            linha59 = allLines[59];
                            linha60 = allLines[60];
                            linha61 = allLines[61];
                            linha62 = allLines[62];
                            linha63 = allLines[63];
    
                            linha64 = allLines[64];
                            linha65 = allLines[65];
                            linha66 = allLines[66];
                            linha67 = allLines[67];
                            linha68 = allLines[68];
                            linha69 = allLines[69];
                            linha70 = allLines[70];
                            linha71 = allLines[71];

                            linha72 = allLines[72];
                            linha73 = allLines[73];
                            linha74 = allLines[74];
                            linha75 = allLines[75];
                            linha76 = allLines[76];
                            linha77 = allLines[77];
                            linha78 = allLines[78];
                            linha79 = allLines[79];

                            linha80 = allLines[80];
                            linha81 = allLines[81];
                            linha82 = allLines[82];
                            linha83 = allLines[83];
                            linha84 = allLines[84];
                            linha85 = allLines[85];

                            linha86 = allLines[86];
                            linha87 = allLines[87];

                            linha88 = allLines[88];
                            linha89 = allLines[89];
                            linha90 = allLines[90];
                            linha91 = allLines[91];
                            linha92 = allLines[92];
                            linha93 = allLines[93];
                            linha94 = allLines[94];
                            linha95 = allLines[95];
                            linha96 = allLines[96];
                            linha97 = allLines[97];
                            linha98 = allLines[98];
    
                            linha99 = allLines[99];
                            linha100 = allLines[100];
                            linha101 = allLines[101];
                            linha102 = allLines[102];
                            linha103 = allLines[103];
                            
                            linha104 = allLines[104];
                            linha105 = allLines[105];
                            linha106 = allLines[106];
                            linha107 = allLines[107];
                            linha108 = allLines[108];
                            linha109 = allLines[109];
                            linha110 = allLines[110];
                            linha111 = allLines[111];
                            linha112 = allLines[112];
                            linha113 = allLines[113];

                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                         
                            repassandoCaminho = caminho;

                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo01 = this.Text + @"\FileT01.txt";
                            string conteudoTempo01 = System.IO.File.ReadAllText(tempoo01);
                            RecebendoconteudoTempo01 = conteudoTempo01;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo02 = this.Text + @"\FileT02.txt";
                            string conteudoTempo02 = System.IO.File.ReadAllText(tempoo02);
                            RecebendoconteudoTempo02 = conteudoTempo02;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo03 = this.Text + @"\FileT03.txt";
                            string conteudoTempo03 = System.IO.File.ReadAllText(tempoo03);
                            RecebendoconteudoTempo03 = conteudoTempo03;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo04 = this.Text + @"\FileT04.txt";
                            string conteudoTempo04 = System.IO.File.ReadAllText(tempoo04);
                            RecebendoconteudoTempo04 = conteudoTempo04;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempo05 = this.Text + @"\FileT05.txt";
                            string conteudoTempo05 = System.IO.File.ReadAllText(tempo05);
                            RecebendoconteudoTempo05 = conteudoTempo05;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo06 = this.Text + @"\FileT06.txt";
                            string conteudoTempo06 = System.IO.File.ReadAllText(tempoo06);
                            RecebendoconteudoTempo06 = conteudoTempo06;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo07 = this.Text + @"\FileT07.txt";
                            string conteudoTempo07 = System.IO.File.ReadAllText(tempoo07);
                            RecebendoconteudoTempo07 = conteudoTempo07;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo08 = this.Text + @"\FileT08.txt";
                            string conteudoTempo08 = System.IO.File.ReadAllText(tempoo08);
                            RecebendoconteudoTempo08 = conteudoTempo08;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo09 = this.Text + @"\FileT09.txt";
                            string conteudoTempo09 = System.IO.File.ReadAllText(tempoo09);
                            RecebendoconteudoTempo09 = conteudoTempo09;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo10 = this.Text + @"\FileT10.txt";
                            string conteudoTempo10 = System.IO.File.ReadAllText(tempoo10);
                            RecebendoconteudoTempo10 = conteudoTempo10;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo11 = this.Text + @"\FileT11.txt";
                            string conteudoTempo11 = System.IO.File.ReadAllText(tempoo11);
                            RecebendoconteudoTempo11 = conteudoTempo11;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo12 = this.Text + @"\FileT12.txt";
                            string conteudoTempo12 = System.IO.File.ReadAllText(tempoo12);
                            RecebendoconteudoTempo12 = conteudoTempo12;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo13 = this.Text + @"\FileT13.txt";
                            string conteudoTempo13 = System.IO.File.ReadAllText(tempoo13);
                            RecebendoconteudoTempo13 = conteudoTempo13;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo14 = this.Text + @"\FileT14.txt";
                            string conteudoTempo14 = System.IO.File.ReadAllText(tempoo14);
                            RecebendoconteudoTempo14 = conteudoTempo14;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo15 = this.Text + @"\FileT15.txt";
                            string conteudoTempo15 = System.IO.File.ReadAllText(tempoo15);
                            RecebendoconteudoTempo15 = conteudoTempo15;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo16 = this.Text + @"\FileT16.txt";
                            string conteudoTempo16 = System.IO.File.ReadAllText(tempoo16);
                            RecebendoconteudoTempo16 = conteudoTempo16;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo17 = this.Text + @"\FileT17.txt";
                            string conteudoTempo17 = System.IO.File.ReadAllText(tempoo17);
                            RecebendoconteudoTempo17 = conteudoTempo17;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo18 = this.Text + @"\FileT18.txt";
                            string conteudoTempo18 = System.IO.File.ReadAllText(tempoo18);
                            RecebendoconteudoTempo18 = conteudoTempo18;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo19 = this.Text + @"\FileT19.txt";
                            string conteudoTempo19 = System.IO.File.ReadAllText(tempoo19);
                            RecebendoconteudoTempo19 = conteudoTempo19;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo20 = this.Text + @"\FileT20.txt";
                            string conteudoTempo20 = System.IO.File.ReadAllText(tempoo20);
                            RecebendoconteudoTempo20 = conteudoTempo20;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo21 = this.Text + @"\FileT21.txt";
                            string conteudoTempo21 = System.IO.File.ReadAllText(tempoo21);
                            RecebendoconteudoTempo21 = conteudoTempo21;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo22 = this.Text + @"\FileT22.txt";
                            string conteudoTempo22 = System.IO.File.ReadAllText(tempoo22);
                            RecebendoconteudoTempo22 = conteudoTempo22;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo23 = this.Text + @"\FileT23.txt";
                            string conteudoTempo23 = System.IO.File.ReadAllText(tempoo23);
                            RecebendoconteudoTempo23 = conteudoTempo23;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string tempoo24 = this.Text + @"\FileT24.txt";
                            string conteudoTempo24 = System.IO.File.ReadAllText(tempoo24);
                            RecebendoconteudoTempo24 = conteudoTempo24;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string contador01 = this.Text + @"\FileC01.txt";
                            string conteudoCont01 = System.IO.File.ReadAllText(contador01);
                            RecebendoconteudoCont01 = conteudoCont01;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string contador02 = this.Text + @"\FileC02.txt";
                            string conteudoCont02 = System.IO.File.ReadAllText(contador02);
                            RecebendoconteudoCont02 = conteudoCont02;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string mensagem00 = this.Text + @"\FileD00.txt";
                            string conteudoMsg00 = System.IO.File.ReadAllText(mensagem00);
                            RecebendoconteudoMsg00 = conteudoMsg00;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
                            string retardo01 = this.Text + @"\FileR01.txt";
                            string conteudoRet01 = System.IO.File.ReadAllText(retardo01);
                            RecebendoconteudoRet01 = conteudoRet01;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo02 = this.Text + @"\FileR02.txt";
                            string conteudoRet02 = System.IO.File.ReadAllText(retardo02);
                            RecebendoconteudoRet02 = conteudoRet02;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo03 = this.Text + @"\FileR03.txt";
                            string conteudoRet03 = System.IO.File.ReadAllText(retardo03);
                            RecebendoconteudoRet03 = conteudoRet03;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo04 = this.Text + @"\FileR04.txt";
                            string conteudoRet04 = System.IO.File.ReadAllText(retardo04);
                            RecebendoconteudoRet04 = conteudoRet04;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo05 = this.Text + @"\FileR05.txt";
                            string conteudoRet05 = System.IO.File.ReadAllText(retardo05);
                            RecebendoconteudoRet05 = conteudoRet05;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo06 = this.Text + @"\FileR06.txt";
                            string conteudoRet06 = System.IO.File.ReadAllText(retardo06);
                            RecebendoconteudoRet06 = conteudoRet06;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo07 = this.Text + @"\FileR07.txt";
                            string conteudoRet07 = System.IO.File.ReadAllText(retardo07);
                            RecebendoconteudoRet07 = conteudoRet07;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string retardo08 = this.Text + @"\FileR08.txt";
                            string conteudoRet08 = System.IO.File.ReadAllText(retardo08);
                            RecebendoconteudoRet08 = conteudoRet08;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string analogicaa1 = caminho + @"\FileA01.txt";
                            string conteudoAng01 = System.IO.File.ReadAllText(analogicaa1);
                            Form1.RecebendoconteudoA01 = conteudoAng01;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string analogicaa2 = caminho + @"\FileA02.txt";
                            string conteudoAng02 = System.IO.File.ReadAllText(analogicaa2);
                            Form1.RecebendoconteudoA02 = conteudoAng02;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string analogicaa3 = caminho + @"\FileA03.txt";
                            string conteudoAng03 = System.IO.File.ReadAllText(analogicaa3);
                            Form1.RecebendoconteudoA03 = conteudoAng03;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string analogicaa4 = caminho + @"\FileA04.txt";
                            string conteudoAng04 = System.IO.File.ReadAllText(analogicaa4);
                            Form1.RecebendoconteudoA04 = conteudoAng04;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string habiltarFuncao = caminho + @"\FileB01.txt";
                            string conteudoHab00 = System.IO.File.ReadAllText(habiltarFuncao);
                            Form1.RecebendoconteudoADJ00 = conteudoHab00;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string habiltarFuncao2 = caminho + @"\FileB02.txt";
                            string conteudoHab01 = System.IO.File.ReadAllText(habiltarFuncao2);
                            Form1.RecebendoconteudoADJ01 = conteudoHab01;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string Bimanual1 = caminho + @"\FileBM1.txt";
                            string conteudoBim1 = System.IO.File.ReadAllText(Bimanual1);
                            RecebendoconteudoBM1 = conteudoBim1;
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            string Bimanual2 = caminho + @"\FileBM2.txt";
                            string conteudoBim2 = System.IO.File.ReadAllText(Bimanual2);
                            RecebendoconteudoBM2 = conteudoBim2;
                        }
                    }
               gb_tabela.Visible = true;
            }
        }

        // Ícone "Abrir Projeto"
        private void btn_abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.CheckFileExists = true;
            abrir.Filter = "*.prj | *.prj";
            abrir.Multiselect = true;
         
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                arquivo = abrir.FileName; // variavel recebe o arquivo escolhido para abrir, para depois ser tratado como caminho na hora de salvar
                FileInfo fileInfo = new FileInfo(abrir.FileName);
                caminho = fileInfo.DirectoryName;
                this.Text = caminho;
                caminhoAntigo = this.Text;
                btn_salvar.Visible = true;
                btn_fechar.Visible = true;
                btn_novo.Visible = false;

                string coment = this.Text + @"\Comentarios.txt";

                allLines = File.ReadAllLines(coment);

                for (int i = 0; i < allLines.Length; i++)
                {
                    if (allLines[i].Length < 1)
                    {
                        allLines[i] = allLines[i] + "        ";
                    }
                    if (allLines[i].Length < 2)
                    {
                        allLines[i] = allLines[i] + "       ";
                    }
                    else if (allLines[i].Length < 3)
                    {
                        allLines[i] = allLines[i] + "      ";
                    }
                    else if (allLines[i].Length < 4)
                    {
                        allLines[i] = allLines[i] + "     ";
                    }
                    else if (allLines[i].Length < 5)
                    {
                        allLines[i] = allLines[i] + "    ";
                    }
                    else if (allLines[i].Length < 6)
                    {
                        allLines[i] = allLines[i] + "   ";
                    }
                    else if (allLines[i].Length < 7)
                    {
                        allLines[i] = allLines[i] + "  ";
                    }
                    else if (allLines[i].Length < 8)
                    {
                        allLines[i] = allLines[i] + " ";
                    }
                }


                 linha0 = allLines[0];
                 linha1 = allLines[1];
                 linha2 = allLines[2];
                 linha3 = allLines[3];
                 linha4 = allLines[4];
                 linha5 = allLines[5];
                 linha6 = allLines[6];
                 linha7 = allLines[7];

                 linha8 = allLines[8];
                 linha9 = allLines[9];
                 linha10 = allLines[10];
                 linha11 = allLines[11];
                 linha12 = allLines[12];
                 linha13 = allLines[13];
                 linha14 = allLines[14];
                 linha15 = allLines[15];

                 linha16 = allLines[16];
                 linha17 = allLines[17];
                 linha18 = allLines[18];
                 linha19 = allLines[19];
                 linha20 = allLines[20];
                 linha21 = allLines[21];
                 linha22 = allLines[22];
                 linha23 = allLines[23];

                 linha24 = allLines[24];
                 linha25 = allLines[25];
                 linha26 = allLines[26];
                 linha27 = allLines[27];
                 linha28 = allLines[28];
                 linha29 = allLines[29];
                 linha30 = allLines[30];
                 linha31 = allLines[31];

                 linha32 = allLines[32];
                 linha33 = allLines[33];
                 linha34 = allLines[34];
                 linha35 = allLines[35];
                 linha36 = allLines[36];
                 linha37 = allLines[37];
                 linha38 = allLines[38];
                 linha39 = allLines[39];

                 linha40 = allLines[40];
                 linha41 = allLines[41];
                 linha42 = allLines[42];
                 linha43 = allLines[43];
                 linha44 = allLines[44];
                 linha45 = allLines[45];
                 linha46 = allLines[46];
                 linha47 = allLines[47];

                 linha48 = allLines[48];
                 linha49 = allLines[49];
                 linha50 = allLines[50];
                 linha51 = allLines[51];
                 linha52 = allLines[52];
                 linha53 = allLines[53];
                 linha54 = allLines[54];
                 linha55 = allLines[55];

                 linha56 = allLines[56];
                 linha57 = allLines[57];
                 linha58 = allLines[58];
                 linha59 = allLines[59];
                 linha60 = allLines[60];
                 linha61 = allLines[61];
                 linha62 = allLines[62];
                 linha63 = allLines[63];

                 linha64 = allLines[64];
                 linha65 = allLines[65];
                 linha66 = allLines[66];
                 linha67 = allLines[67];
                 linha68 = allLines[68];
                 linha69 = allLines[69];
                 linha70 = allLines[70];
                 linha71 = allLines[71];

                 linha72 = allLines[72];
                 linha73 = allLines[73];
                 linha74 = allLines[74];
                 linha75 = allLines[75];
                 linha76 = allLines[76];
                 linha77 = allLines[77];
                 linha78 = allLines[78];
                 linha79 = allLines[79];

                 linha80 = allLines[80];
                 linha81 = allLines[81];
                 linha82 = allLines[82];
                 linha83 = allLines[83];
                 linha84 = allLines[84];
                 linha85 = allLines[85];

                 linha86 = allLines[86];
                 linha87 = allLines[87];

                 linha88 = allLines[88];
                 linha89 = allLines[89];
                 linha90 = allLines[90];
                 linha91 = allLines[91];
                 linha92 = allLines[92];
                 linha93 = allLines[93];
                 linha94 = allLines[94];
                 linha95 = allLines[95];
                 linha96 = allLines[96];
                 linha97 = allLines[97];
                 linha98 = allLines[98];

                 linha99 = allLines[99];
                 linha100 = allLines[100];
                 linha101 = allLines[101];
                 linha102 = allLines[102];
                 linha103 = allLines[103];

                linha104 = allLines[104];
                linha105 = allLines[105];
                linha106 = allLines[106];
                linha107 = allLines[107];
                linha108 = allLines[108];
                linha109 = allLines[109];
                linha110 = allLines[110];
                linha111 = allLines[111];
                linha112 = allLines[112];
                linha113 = allLines[113];

                linha114 = allLines[114];
                linha115 = allLines[115];

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                string text0 = linha0.Substring(0, 8);
                string text1 = linha1.Substring(0, 8);
                string text2 = linha2.Substring(0, 8);
                string text3 = linha3.Substring(0, 8);
                string text4 = linha4.Substring(0, 8);
                string text5 = linha5.Substring(0, 8);
                string text6 = linha6.Substring(0, 8);
                string text7 = linha7.Substring(0, 8);

                string text8 = linha8.Substring(0, 8);
                string text9 = linha9.Substring(0, 8);
                string text10 = linha10.Substring(0, 8);
                string text11 = linha11.Substring(0, 8);
                string text12 = linha12.Substring(0, 8);
                string text13 = linha13.Substring(0, 8);
                string text14 = linha14.Substring(0, 8);
                string text15 = linha15.Substring(0, 8);

                string text16 = linha16.Substring(0, 8);
                string text17 = linha17.Substring(0, 8);
                string text18 = linha18.Substring(0, 8);
                string text19 = linha19.Substring(0, 8);
                string text20 = linha20.Substring(0, 8);
                string text21 = linha21.Substring(0, 8);
                string text22 = linha22.Substring(0, 8);
                string text23 = linha23.Substring(0, 8);

                string text24 = linha24.Substring(0, 8);
                string text25 = linha25.Substring(0, 8);
                string text26 = linha26.Substring(0, 8);
                string text27 = linha27.Substring(0, 8);
                string text28 = linha28.Substring(0, 8);
                string text29 = linha29.Substring(0, 8);
                string text30 = linha30.Substring(0, 8);
                string text31 = linha31.Substring(0, 8);

                string text32 = linha32.Substring(0, 8);
                string text33 = linha33.Substring(0, 8);
                string text34 = linha34.Substring(0, 8);
                string text35 = linha35.Substring(0, 8);
                string text36 = linha36.Substring(0, 8);
                string text37 = linha37.Substring(0, 8);
                string text38 = linha38.Substring(0, 8);
                string text39 = linha39.Substring(0, 8);

                string text40 = linha40.Substring(0, 8);
                string text41 = linha41.Substring(0, 8);
                string text42 = linha42.Substring(0, 8);
                string text43 = linha43.Substring(0, 8);
                string text44 = linha44.Substring(0, 8);
                string text45 = linha45.Substring(0, 8);
                string text46 = linha46.Substring(0, 8);
                string text47 = linha47.Substring(0, 8);

                string text48 = linha48.Substring(0, 8);
                string text49 = linha49.Substring(0, 8);
                string text50 = linha50.Substring(0, 8);
                string text51 = linha51.Substring(0, 8);
                string text52 = linha52.Substring(0, 8);
                string text53 = linha53.Substring(0, 8);
                string text54 = linha54.Substring(0, 8);
                string text55 = linha55.Substring(0, 8);

                string text56 = linha56.Substring(0, 8);
                string text57 = linha57.Substring(0, 8);
                string text58 = linha58.Substring(0, 8);
                string text59 = linha59.Substring(0, 8);
                string text60 = linha60.Substring(0, 8);
                string text61 = linha61.Substring(0, 8);
                string text62 = linha62.Substring(0, 8);
                string text63 = linha63.Substring(0, 8);

                string text64 = linha64.Substring(0, 8);
                string text65 = linha65.Substring(0, 8);
                string text66 = linha66.Substring(0, 8);
                string text67 = linha67.Substring(0, 8);
                string text68 = linha68.Substring(0, 8);
                string text69 = linha69.Substring(0, 8);
                string text70 = linha70.Substring(0, 8);
                string text71 = linha71.Substring(0, 8);

                string text72 = linha72.Substring(0, 8);
                string text73 = linha73.Substring(0, 8);
                string text74 = linha74.Substring(0, 8);
                string text75 = linha75.Substring(0, 8);
                string text76 = linha76.Substring(0, 8);
                string text77 = linha77.Substring(0, 8);
                string text78 = linha78.Substring(0, 8);
                string text79 = linha79.Substring(0, 8);

                string text80 = linha80.Substring(0, 8);
                string text81 = linha81.Substring(0, 8);
                string text82 = linha82.Substring(0, 8);
                string text83 = linha83.Substring(0, 8);
                string text84 = linha84.Substring(0, 8);
                string text85 = linha85.Substring(0, 8);

                string text86 = linha86.Substring(0, 8);
                string text87 = linha87.Substring(0, 8);
                string text88 = linha87.Substring(0, 8);

                string text89 = linha88.Substring(0, 8);
                string text90 = linha89.Substring(0, 8);
                string text91 = linha91.Substring(0, 8);
                string text92 = linha92.Substring(0, 8);
                string text93 = linha93.Substring(0, 8);
                string text94 = linha94.Substring(0, 8);
                string text95 = linha95.Substring(0, 8);
                string text96 = linha96.Substring(0, 8);
                string text97 = linha97.Substring(0, 8);
                string text98 = linha98.Substring(0, 8);

                string text99 =  linha99.Substring(0, 8);
                string text100 = linha100.Substring(0, 8);
                string text101 = linha101.Substring(0, 8);
                string text102 = linha102.Substring(0, 8);
                string text103 = linha103.Substring(0, 8);

                string text104 = linha104.Substring(0, 8);
                string text105 = linha105.Substring(0, 8);
                string text106 = linha106.Substring(0, 8);
                string text107 = linha107.Substring(0, 8);
                string text108 = linha108.Substring(0, 8);
                string text109 = linha109.Substring(0, 8);
                string text110 = linha110.Substring(0, 8);
                string text111 = linha111.Substring(0, 8);
                string text112 = linha112.Substring(0, 8);
                string text113 = linha113.Substring(0, 8);

                string text114 = linha114.Substring(0, 8);
                string text115 = linha115.Substring(0, 8);

                repassandoCaminho = caminho;

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo01 = this.Text + @"\FileT01.txt";
                string conteudoTempo01 = System.IO.File.ReadAllText(tempo01);
                RecebendoconteudoTempo01 = conteudoTempo01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo02 = this.Text + @"\FileT02.txt";
                string conteudoTempo02 = System.IO.File.ReadAllText(tempo02);
                RecebendoconteudoTempo02 = conteudoTempo02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo03 = this.Text + @"\FileT03.txt";
                string conteudoTempo03 = System.IO.File.ReadAllText(tempo03);
                RecebendoconteudoTempo03 = conteudoTempo03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo04 = this.Text + @"\FileT04.txt";
                string conteudoTempo04 = System.IO.File.ReadAllText(tempo04);
                RecebendoconteudoTempo04 = conteudoTempo04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo05 = this.Text + @"\FileT05.txt";
                string conteudoTempo05 = System.IO.File.ReadAllText(tempo05);
                RecebendoconteudoTempo05 = conteudoTempo05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo06 = this.Text + @"\FileT06.txt";
                string conteudoTempo06 = System.IO.File.ReadAllText(tempo06);
                RecebendoconteudoTempo06 = conteudoTempo06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo07 = this.Text + @"\FileT07.txt";
                string conteudoTempo07 = System.IO.File.ReadAllText(tempo07);
                RecebendoconteudoTempo07 = conteudoTempo07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo08 = this.Text + @"\FileT08.txt";
                string conteudoTempo08 = System.IO.File.ReadAllText(tempo08);
                RecebendoconteudoTempo08 = conteudoTempo08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo09 = this.Text + @"\FileT09.txt";
                string conteudoTempo09 = System.IO.File.ReadAllText(tempo09);
                RecebendoconteudoTempo09 = conteudoTempo09;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo10 = this.Text + @"\FileT10.txt";
                string conteudoTempo10 = System.IO.File.ReadAllText(tempo10);
                RecebendoconteudoTempo10 = conteudoTempo10;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo11 = this.Text + @"\FileT11.txt";
                string conteudoTempo11 = System.IO.File.ReadAllText(tempo11);
                RecebendoconteudoTempo11 = conteudoTempo11;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo12 = this.Text + @"\FileT12.txt";
                string conteudoTempo12 = System.IO.File.ReadAllText(tempo12);
                RecebendoconteudoTempo12 = conteudoTempo12;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo13 = this.Text + @"\FileT13.txt";
                string conteudoTempo13 = System.IO.File.ReadAllText(tempo13);
                RecebendoconteudoTempo13 = conteudoTempo13;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo14 = this.Text + @"\FileT14.txt";
                string conteudoTempo14 = System.IO.File.ReadAllText(tempo14);
                RecebendoconteudoTempo14 = conteudoTempo14;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo15 = this.Text + @"\FileT15.txt";
                string conteudoTempo15 = System.IO.File.ReadAllText(tempo15);
                RecebendoconteudoTempo15 = conteudoTempo15;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo16 = this.Text + @"\FileT16.txt";
                string conteudoTempo16 = System.IO.File.ReadAllText(tempo16);
                RecebendoconteudoTempo16 = conteudoTempo16;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo17 = this.Text + @"\FileT17.txt";
                string conteudoTempo17 = System.IO.File.ReadAllText(tempo17);
                RecebendoconteudoTempo17 = conteudoTempo17;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo18 = this.Text + @"\FileT18.txt";
                string conteudoTempo18 = System.IO.File.ReadAllText(tempo18);
                RecebendoconteudoTempo18 = conteudoTempo18;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo19 = this.Text + @"\FileT19.txt";
                string conteudoTempo19 = System.IO.File.ReadAllText(tempo19);
                RecebendoconteudoTempo19 = conteudoTempo19;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo20 = this.Text + @"\FileT20.txt";
                string conteudoTempo20 = System.IO.File.ReadAllText(tempo20);
                RecebendoconteudoTempo20 = conteudoTempo20;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo21 = this.Text + @"\FileT21.txt";
                string conteudoTempo21 = System.IO.File.ReadAllText(tempo21);
                RecebendoconteudoTempo21 = conteudoTempo21;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo22 = this.Text + @"\FileT22.txt";
                string conteudoTempo22 = System.IO.File.ReadAllText(tempo22);
                RecebendoconteudoTempo22 = conteudoTempo22;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo23 = this.Text + @"\FileT23.txt";
                string conteudoTempo23 = System.IO.File.ReadAllText(tempo23);
                RecebendoconteudoTempo23 = conteudoTempo23;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo24 = this.Text + @"\FileT24.txt";
                string conteudoTempo24 = System.IO.File.ReadAllText(tempo24);
                RecebendoconteudoTempo24 = conteudoTempo24;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string contador01 = this.Text + @"\FileC01.txt";
                string conteudoCont01 = System.IO.File.ReadAllText(contador01);
                RecebendoconteudoCont01 = conteudoCont01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string contador02 = this.Text + @"\FileC02.txt";
                string conteudoCont02 = System.IO.File.ReadAllText(contador02);
                RecebendoconteudoCont02 = conteudoCont02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem00 = this.Text + @"\FileD00.txt";
                string conteudoMsg00 = System.IO.File.ReadAllText(mensagem00);
                RecebendoconteudoMsg00 = conteudoMsg00;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
                string mensagem01 = this.Text + @"\FileD01.txt";
                string conteudoMsg01 = System.IO.File.ReadAllText(mensagem01);
                RecebendoconteudoMsg01 = conteudoMsg01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
                string mensagem02 = this.Text + @"\FileD02.txt";
                string conteudoMsg02 = System.IO.File.ReadAllText(mensagem02);
                RecebendoconteudoMsg02_2 = conteudoMsg02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
                string mensagem03 = this.Text + @"\FileD03.txt";
                string conteudoMsg03 = System.IO.File.ReadAllText(mensagem03);
                RecebendoconteudoMsg03 = conteudoMsg03;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
                string mensagem04 = this.Text + @"\FileD04.txt";
                string conteudoMsg04 = System.IO.File.ReadAllText(mensagem04);
                RecebendoconteudoMsg04 = conteudoMsg04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem05 = this.Text + @"\FileD05.txt";
                string conteudoMsg05 = System.IO.File.ReadAllText(mensagem05);
                RecebendoconteudoMsg05 = conteudoMsg05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem06 = this.Text + @"\FileD06.txt";
                string conteudoMsg06 = System.IO.File.ReadAllText(mensagem06);
                RecebendoconteudoMsg06 = conteudoMsg06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem07 = this.Text + @"\FileD07.txt";
                string conteudoMsg07 = System.IO.File.ReadAllText(mensagem07);
                RecebendoconteudoMsg07 = conteudoMsg07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem08 = this.Text + @"\FileD08.txt";
                string conteudoMsg08 = System.IO.File.ReadAllText(mensagem08);
                RecebendoconteudoMsg08 = conteudoMsg08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo01 = this.Text + @"\FileR01.txt";
                string conteudoRet01 = System.IO.File.ReadAllText(retardo01);
                RecebendoconteudoRet01 = conteudoRet01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo02 = this.Text + @"\FileR02.txt";
                string conteudoRet02 = System.IO.File.ReadAllText(retardo02);
                RecebendoconteudoRet02 = conteudoRet02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo03 = this.Text + @"\FileR03.txt";
                string conteudoRet03 = System.IO.File.ReadAllText(retardo03);
                RecebendoconteudoRet03 = conteudoRet03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo04 = this.Text + @"\FileR04.txt";
                string conteudoRet04 = System.IO.File.ReadAllText(retardo04);
                RecebendoconteudoRet04 = conteudoRet04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo05 = this.Text + @"\FileR05.txt";
                string conteudoRet05 = System.IO.File.ReadAllText(retardo05);
                RecebendoconteudoRet05 = conteudoRet05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo06 = this.Text + @"\FileR06.txt";
                string conteudoRet06 = System.IO.File.ReadAllText(retardo06);
                RecebendoconteudoRet06 = conteudoRet06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo07 = this.Text + @"\FileR07.txt";
                string conteudoRet07 = System.IO.File.ReadAllText(retardo07);
                RecebendoconteudoRet07 = conteudoRet07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo08 = this.Text + @"\FileR08.txt";
                string conteudoRet08 = System.IO.File.ReadAllText(retardo08);
                RecebendoconteudoRet08 = conteudoRet08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica1 = caminho + @"\FileA01.txt";
                string conteudoAng01 = System.IO.File.ReadAllText(analogica1);
                Form1.RecebendoconteudoA01 = conteudoAng01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica2 = caminho + @"\FileA02.txt";
                string conteudoAng02 = System.IO.File.ReadAllText(analogica2);
                Form1.RecebendoconteudoA02 = conteudoAng02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica3 = caminho + @"\FileA03.txt";
                string conteudoAng03 = System.IO.File.ReadAllText(analogica3);
                Form1.RecebendoconteudoA03 = conteudoAng03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica4 = caminho + @"\FileA04.txt";
                string conteudoAng04 = System.IO.File.ReadAllText(analogica4);
                Form1.RecebendoconteudoA04 = conteudoAng04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string habiltarFuncao = caminho + @"\FileB01.txt";
                string conteudoHab00 = System.IO.File.ReadAllText(habiltarFuncao);
                Form1.RecebendoconteudoADJ00 = conteudoHab00;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string habiltarFuncao2 = caminho + @"\FileB02.txt";
                string conteudoHab01 = System.IO.File.ReadAllText(habiltarFuncao2);
                Form1.RecebendoconteudoADJ01 = conteudoHab01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string Bimanual1 = caminho + @"\FileBM1.txt";
                string conteudoBim1 = System.IO.File.ReadAllText(Bimanual1);
                RecebendoconteudoBM1 = conteudoBim1;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string Bimanual2 = caminho + @"\FileBM2.txt";
                string conteudoBim2 = System.IO.File.ReadAllText(Bimanual2);
                RecebendoconteudoBM2 = conteudoBim2;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                using (var fs4 = new FileStream(abrir.FileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs4.Read(vetor, 0, vetor.Length);

                    int indice = 0;
                    for (int i = 0; i < 250; i++)
                    {
                        for (int j = 0; j < 17; j++)
                        {
                            mat[i, j] = vetor[indice];
                            indice++;                         
                            switch (mat[i, j])
                            {
                                case 36:                                   
                                    btn_aux.Image = Properties.Resources.bimanual_E7_E8;
                                    var g_100 = Graphics.FromImage(btn_aux.Image);
                                    g_100.DrawString(text100, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha100;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 250: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.botao_invisivel; break;

                                case 200: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_T; break;

                                case 201: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_H; break;
                                                               
                                case 202: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_L; break;
                                                                   
                                case 0: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.linhas_gridview; break;
                                case 1: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.CONTINUO; break;
                                   
                                case 3: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.CONTINUO; break;
                                   
                                case 4:
                                    btn_aux.Image = Properties.Resources.ENA_E01;
                                    var g0 = Graphics.FromImage(btn_aux.Image);
                                    g0.DrawString(text0, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha0;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;                                 
                                    break;

                                case 6:
                                    btn_aux.Image = Properties.Resources.ENA_E02;
                                    var g1 = Graphics.FromImage(btn_aux.Image);
                                    g1.DrawString(text1, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha1;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 8:
                                    btn_aux.Image = Properties.Resources.ENA_E03;
                                    var g2 = Graphics.FromImage(btn_aux.Image);
                                    g2.DrawString(text2, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha2;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 10:
                                    btn_aux.Image = Properties.Resources.ENA_E04;
                                    var g3 = Graphics.FromImage(btn_aux.Image);
                                    g3.DrawString(text3, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha3;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 12:
                                    btn_aux.Image = Properties.Resources.ENA_E05;
                                    var g4 = Graphics.FromImage(btn_aux.Image);
                                    g4.DrawString(text4, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha4;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 14:
                                    btn_aux.Image = Properties.Resources.ENA_E06;
                                    var g5 = Graphics.FromImage(btn_aux.Image);
                                    g5.DrawString(text5, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha5;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 16:
                                    btn_aux.Image = Properties.Resources.ENA_E07;
                                    var g6= Graphics.FromImage(btn_aux.Image);
                                    g6.DrawString(text6, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha6;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 18:
                                    btn_aux.Image = Properties.Resources.ENA_E08;
                                    var g7 = Graphics.FromImage(btn_aux.Image);
                                    g7.DrawString(text7, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha7;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 5:
                                    btn_aux.Image = Properties.Resources.ENF_E01;
                                    var g8 = Graphics.FromImage(btn_aux.Image);
                                    g8.DrawString(text8, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha8;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 7:
                                    btn_aux.Image = Properties.Resources.ENF_E02;
                                    var g9 = Graphics.FromImage(btn_aux.Image);
                                    g9.DrawString(text9, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha9;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                               
                                case 9:
                                    btn_aux.Image = Properties.Resources.ENF_E03;
                                    var g10 = Graphics.FromImage(btn_aux.Image);
                                    g10.DrawString(text10, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha10;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 11:
                                    btn_aux.Image = Properties.Resources.ENF_E041;
                                    var g11 = Graphics.FromImage(btn_aux.Image);
                                    g11.DrawString(text11, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha11;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 13:
                                    btn_aux.Image = Properties.Resources.ENF_E05;
                                    var g12 = Graphics.FromImage(btn_aux.Image);
                                    g12.DrawString(text12, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha12;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                
                                case 15:
                                    btn_aux.Image = Properties.Resources.ENF_E06;
                                    var g13 = Graphics.FromImage(btn_aux.Image);
                                    g13.DrawString(text13, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha13;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 17:
                                    btn_aux.Image = Properties.Resources.ENF_E07;
                                    var g14 = Graphics.FromImage(btn_aux.Image);
                                    g14.DrawString(text14, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha14;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 19:
                                    btn_aux.Image = Properties.Resources.ENF_E08;
                                    var g15 = Graphics.FromImage(btn_aux.Image);
                                    g15.DrawString(text15, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha15;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 20:
                                    btn_aux.Image = Properties.Resources.BP_E01;
                                    var g24 = Graphics.FromImage(btn_aux.Image);
                                    g24.DrawString(text24, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha24;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 22:
                                    btn_aux.Image = Properties.Resources.BP_E02;
                                    var g25 = Graphics.FromImage(btn_aux.Image);
                                    g25.DrawString(text25, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha25;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                
                                case 24:
                                    btn_aux.Image = Properties.Resources.BP_E03;
                                    var g26 = Graphics.FromImage(btn_aux.Image);
                                    g26.DrawString(text26, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha26;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 26:
                                    btn_aux.Image = Properties.Resources.BP_E04;
                                    var g27 = Graphics.FromImage(btn_aux.Image);
                                    g27.DrawString(text27, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha27;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                
                                case 28:
                                    btn_aux.Image = Properties.Resources.BP_E05;
                                    var g28 = Graphics.FromImage(btn_aux.Image);
                                    g28.DrawString(text28, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha28;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 30:
                                    btn_aux.Image = Properties.Resources.BP_E06;
                                    var g29 = Graphics.FromImage(btn_aux.Image);
                                    g29.DrawString(text29, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha29;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                              
                                case 32:
                                    btn_aux.Image = Properties.Resources.BP_E07;
                                    var g30 = Graphics.FromImage(btn_aux.Image);
                                    g30.DrawString(text30, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha30;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 34:
                                    btn_aux.Image = Properties.Resources.BP_E08;
                                    var g31 = Graphics.FromImage(btn_aux.Image);
                                    g31.DrawString(text31, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha31;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 21:
                                    btn_aux.Image = Properties.Resources.BN_E01;
                                    var g16 = Graphics.FromImage(btn_aux.Image);
                                    g16.DrawString(text16, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha16;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 23:
                                    btn_aux.Image = Properties.Resources.BN_E02;
                                    var g17 = Graphics.FromImage(btn_aux.Image);
                                    g17.DrawString(text17, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha17;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 25:
                                    btn_aux.Image = Properties.Resources.BN_E03;
                                    var g18 = Graphics.FromImage(btn_aux.Image);
                                    g18.DrawString(text18, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha18;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 27:
                                    btn_aux.Image = Properties.Resources.BN_E04;
                                    var g19 = Graphics.FromImage(btn_aux.Image);
                                    g19.DrawString(text19, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha19;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                    
                                case 29:
                                    btn_aux.Image = Properties.Resources.BN_E05;
                                    var g20 = Graphics.FromImage(btn_aux.Image);
                                    g20.DrawString(text20, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha20;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 31:
                                    btn_aux.Image = Properties.Resources.BN_E06;
                                    var g21 = Graphics.FromImage(btn_aux.Image);
                                    g21.DrawString(text21, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha21;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 33:
                                    btn_aux.Image = Properties.Resources.BN_E07;
                                    var g22 = Graphics.FromImage(btn_aux.Image);
                                    g22.DrawString(text22, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha22;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 35:
                                    btn_aux.Image = Properties.Resources.BN_E08;
                                    var g23 = Graphics.FromImage(btn_aux.Image);
                                    g23.DrawString(text23, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha23;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                
                                case 114:
                                    btn_aux.Image = Properties.Resources.contador01;
                                    var g68 = Graphics.FromImage(btn_aux.Image);
                                    g68.DrawString(text68, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha68;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 115:
                                    btn_aux.Image = Properties.Resources.contador02;
                                    var g69 = Graphics.FromImage(btn_aux.Image);
                                    g69.DrawString(text69, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha69;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 98:
                                    btn_aux.Image = Properties.Resources.contador01;
                                    var gz68 = Graphics.FromImage(btn_aux.Image);
                                    gz68.DrawString(text98, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha114;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 99:
                                    btn_aux.Image = Properties.Resources.contador02;
                                    var gz69 = Graphics.FromImage(btn_aux.Image);
                                    gz69.DrawString(text99, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha115;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;


                                case 148: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d01; break;
                                                        
                                case 149: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d02; break;
                                  
                                case 150: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d03; break;
                      
                                case 151: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d04; break;
                                  
                                case 152: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d05; break;
                                 
                                case 153: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d06; break;
                                                       
                                case 154: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d07; break;
                                                                 
                                case 155: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d08; break;
                                 
                                case 116:
                                    btn_aux.Image = Properties.Resources.espera01;
                                    var g70 = Graphics.FromImage(btn_aux.Image);
                                    g70.DrawString(text70, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha70;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
        
                                case 117:
                                    btn_aux.Image = Properties.Resources.espera02;
                                    var g71 = Graphics.FromImage(btn_aux.Image);
                                    g71.DrawString(text71, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha71;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                
                                case 118:
                                    btn_aux.Image = Properties.Resources.espera03;
                                    var g72 = Graphics.FromImage(btn_aux.Image);
                                    g72.DrawString(text72, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha72;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 119:
                                    btn_aux.Image = Properties.Resources.espera04;
                                    var g73 = Graphics.FromImage(btn_aux.Image);
                                    g73.DrawString(text73, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha73;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 120:
                                    btn_aux.Image = Properties.Resources.espera05;
                                    var g74 = Graphics.FromImage(btn_aux.Image);
                                    g74.DrawString(text74, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha74;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 121:
                                    btn_aux.Image = Properties.Resources.espera06;
                                    var g75 = Graphics.FromImage(btn_aux.Image);
                                    g75.DrawString(text75, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha75;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                
                                case 122:
                                    btn_aux.Image = Properties.Resources.espera07;
                                    var g76 = Graphics.FromImage(btn_aux.Image);
                                    g76.DrawString(text76, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha76;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 123:
                                    btn_aux.Image = Properties.Resources.espera08;
                                    var g77 = Graphics.FromImage(btn_aux.Image);
                                    g77.DrawString(text77, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha77;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                
                                case 124:
                                    btn_aux.Image = Properties.Resources.temporizador_01;
                                    var g78 = Graphics.FromImage(btn_aux.Image);
                                    g78.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 125:
                                    btn_aux.Image = Properties.Resources.temporizador_02;
                                    var g79 = Graphics.FromImage(btn_aux.Image);
                                    g79.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 126:
                                    btn_aux.Image = Properties.Resources.temporizador_03;
                                    var g80 = Graphics.FromImage(btn_aux.Image);
                                    g80.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 127:
                                    btn_aux.Image = Properties.Resources.temporizador_04;
                                    var g81 = Graphics.FromImage(btn_aux.Image);
                                    g81.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 128:
                                    btn_aux.Image = Properties.Resources.temporizador_05;
                                    var g82= Graphics.FromImage(btn_aux.Image);
                                    g82.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 129:
                                    btn_aux.Image = Properties.Resources.temporizador_06;
                                    var g83 = Graphics.FromImage(btn_aux.Image);
                                    g83.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 130:
                                    btn_aux.Image = Properties.Resources.temporizador_07;
                                    var g84 = Graphics.FromImage(btn_aux.Image);
                                    g84.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 131:
                                    btn_aux.Image = Properties.Resources.temporizador_08;
                                    var g85 = Graphics.FromImage(btn_aux.Image);
                                    g85.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 132:
                                    btn_aux.Image = Properties.Resources.temporizador_09;
                                    var g78_2 = Graphics.FromImage(btn_aux.Image);
                                    g78_2.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                    
                                case 133:
                                    btn_aux.Image = Properties.Resources.temporizador_10;
                                    var g79_2 = Graphics.FromImage(btn_aux.Image);
                                    g79_2.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 134:
                                    btn_aux.Image = Properties.Resources.temporizador_11;
                                    var g80_2 = Graphics.FromImage(btn_aux.Image);
                                    g80_2.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 135:
                                    btn_aux.Image = Properties.Resources.temporizador_12;
                                    var g81_2 = Graphics.FromImage(btn_aux.Image);
                                    g81_2.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 136:
                                    btn_aux.Image = Properties.Resources.temporizador_13;
                                    var g82_2 = Graphics.FromImage(btn_aux.Image);
                                    g82_2.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 137:
                                    btn_aux.Image = Properties.Resources.temporizador_14;
                                    var g83_2 = Graphics.FromImage(btn_aux.Image);
                                    g83_2.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 138:
                                    btn_aux.Image = Properties.Resources.temporizador_15;   
                                    var g84_2 = Graphics.FromImage(btn_aux.Image);
                                    g84_2.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                    
                                case 139:
                                    btn_aux.Image = Properties.Resources.temporizador_16;
                                    var g85_2 = Graphics.FromImage(btn_aux.Image);
                                    g85_2.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                    
                                case 140:
                                    btn_aux.Image = Properties.Resources.temporizador_17;
                                    var g78_3 = Graphics.FromImage(btn_aux.Image);
                                    g78_3.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 141:
                                    btn_aux.Image = Properties.Resources.temporizador_18;
                                    var g79_3 = Graphics.FromImage(btn_aux.Image);
                                    g79_3.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 142:
                                    btn_aux.Image = Properties.Resources.temporizador_19;
                                    var g80_3 = Graphics.FromImage(btn_aux.Image);
                                    g80_3.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 143:
                                    btn_aux.Image = Properties.Resources.temporizador_20;
                                    var g81_3 = Graphics.FromImage(btn_aux.Image);
                                    g81_3.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 144:
                                    btn_aux.Image = Properties.Resources.temporizador_21;
                                    var g82_3 = Graphics.FromImage(btn_aux.Image);
                                    g82_3.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                               
                                case 145:
                                    btn_aux.Image = Properties.Resources.temporizador_22;
                                    var g83_3 = Graphics.FromImage(btn_aux.Image);
                                    g83_3.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 146:
                                    btn_aux.Image = Properties.Resources.temporizador_23;
                                    var g84_3 = Graphics.FromImage(btn_aux.Image);
                                    g84_3.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                    
                                case 147:
                                    btn_aux.Image = Properties.Resources.temporizador_24;
                                    var g85_3 = Graphics.FromImage(btn_aux.Image);
                                    g85_3.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                               
                                case 52:
                                    if(j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E01;
                                       
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_01;
                                        
                                    }                                    
                                    var g32 = Graphics.FromImage(btn_aux.Image);
                                    g32.DrawString(text32, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));                           
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha32;                           
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 54:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_02;
                                    }                                    
                                    var g33 = Graphics.FromImage(btn_aux.Image);
                                    g33.DrawString(text33, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha33;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 56:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_03;
                                    }
                                   
                                    var g34 = Graphics.FromImage(btn_aux.Image);
                                    g34.DrawString(text34, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha34;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 58:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_04;
                                    }
                                   
                                    var g35 = Graphics.FromImage(btn_aux.Image);
                                    g35.DrawString(text35, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha35;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 60:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_05;
                                    }
                                    var g36 = Graphics.FromImage(btn_aux.Image);
                                    g36.DrawString(text36, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha36;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 62:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_06;
                                    }
                                    var g37 = Graphics.FromImage(btn_aux.Image);
                                    g37.DrawString(text37, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha37;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 64:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_07;
                                    }
                                    var g38 = Graphics.FromImage(btn_aux.Image);
                                    g38.DrawString(text38, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha38;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 66:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_08;
                                    }
                                    var g39 = Graphics.FromImage(btn_aux.Image);
                                    g39.DrawString(text39, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha39;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 53:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_1;
                                    }
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_1;
                                    var g40 = Graphics.FromImage(btn_aux.Image);
                                    g40.DrawString(text40, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha40;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 55:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_2;
                                    }
                                    var g41= Graphics.FromImage(btn_aux.Image);
                                    g41.DrawString(text41, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha41;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 57:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_3;
                                    }
                                    var g42 = Graphics.FromImage(btn_aux.Image);
                                    g42.DrawString(text42, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha42;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 59:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_4;
                                    }
                                    var g43 = Graphics.FromImage(btn_aux.Image);
                                    g43.DrawString(text43, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha43;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 61:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_5;
                                    }
                                    var g44 = Graphics.FromImage(btn_aux.Image);
                                    g44.DrawString(text44, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha44;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 63:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_6;
                                    }
                                    var g45 = Graphics.FromImage(btn_aux.Image);
                                    g45.DrawString(text45, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha45;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 65:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_7;
                                    }
                                    var g46 = Graphics.FromImage(btn_aux.Image);
                                    g46.DrawString(text46, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha46;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 67:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_8;
                                    }
                                    var g47 = Graphics.FromImage(btn_aux.Image);
                                    g47.DrawString(text47, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha47;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 68:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET;
                                    }
                                    var g48 = Graphics.FromImage(btn_aux.Image);
                                    g48.DrawString(text48, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha48;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 70:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_2;
                                    }
                                    var g49 = Graphics.FromImage(btn_aux.Image);
                                    g49.DrawString(text49, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha49;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 72:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_3;
                                    }
                                    var g50 = Graphics.FromImage(btn_aux.Image);
                                    g50.DrawString(text50, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha50;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 74:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_4;
                                    }
                                    var g51 = Graphics.FromImage(btn_aux.Image);
                                    g51.DrawString(text51, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha51;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 76:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_5;
                                    }
                                    var g52 = Graphics.FromImage(btn_aux.Image);
                                    g52.DrawString(text52, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha52;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 78:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_6;
                                    }
                                    var g53 = Graphics.FromImage(btn_aux.Image);
                                    g53.DrawString(text53, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha53;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 80:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_7;
                                    }
                                    var g54 = Graphics.FromImage(btn_aux.Image);
                                    g54.DrawString(text54, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha54;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 82:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_8;
                                    }
                                    var g55 = Graphics.FromImage(btn_aux.Image);
                                    g55.DrawString(text55, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha55;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 69:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES;
                                    }
                                    var g56 = Graphics.FromImage(btn_aux.Image);
                                    g56.DrawString(text56, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha56;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 71:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_2;
                                    }
                                    var g57 = Graphics.FromImage(btn_aux.Image);
                                    g57.DrawString(text57, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha57;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 73:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_3;
                                    }
                                    var g58 = Graphics.FromImage(btn_aux.Image);
                                    g58.DrawString(text58, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha58;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 75:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_4;
                                    }
                                    var g59 = Graphics.FromImage(btn_aux.Image);
                                    g59.DrawString(text59, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha59;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 77:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_5;
                                    }
                                    var g60 = Graphics.FromImage(btn_aux.Image);
                                    g60.DrawString(text60, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha60;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 79:

                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_6;
                                    }
                                    var g61 = Graphics.FromImage(btn_aux.Image);
                                    g61.DrawString(text61, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha61;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 81:

                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_7;
                                    }
                                    var g62 = Graphics.FromImage(btn_aux.Image);
                                    g62.DrawString(text62, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha62;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 83:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_8;
                                    }
                                    var g63 = Graphics.FromImage(btn_aux.Image);
                                    g63.DrawString(text63, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha63;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                               
                                case 100: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_01_NA;
                                    var g86 = Graphics.FromImage(btn_aux.Image);
                                    g86.DrawString(text86, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha86;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 101: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_01_NF;
                                    var g87 = Graphics.FromImage(btn_aux.Image);
                                    g87.DrawString(text87, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha87;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 102: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_02_NA;
                                    var g88 = Graphics.FromImage(btn_aux.Image);
                                    g88.DrawString(text88, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha88;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 103: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_02_NF;
                                    var g89 = Graphics.FromImage(btn_aux.Image);
                                    g89.DrawString(text89, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha89;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 104: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_03_NA;
                                    var g90 = Graphics.FromImage(btn_aux.Image);
                                    g90.DrawString(text90, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha90;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 105: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_03_NF;
                                    var g91 = Graphics.FromImage(btn_aux.Image);
                                    g91.DrawString(text91, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha91;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 106: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_04_NA;
                                    var g92 = Graphics.FromImage(btn_aux.Image);
                                    g92.DrawString(text92, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha92;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 107: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_04_NF;
                                    var g93 = Graphics.FromImage(btn_aux.Image);
                                    g93.DrawString(text93, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha93;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 108: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_05_NA;
                                    var g94 = Graphics.FromImage(btn_aux.Image);
                                    g94.DrawString(text94, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha94;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 109: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_06_NA;
                                    var g95 = Graphics.FromImage(btn_aux.Image);
                                    g95.DrawString(text95, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha95;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 110: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_07_NA;
                                    var g96 = Graphics.FromImage(btn_aux.Image);
                                    g96.DrawString(text96, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha96;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                   
                                case 111: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_08_NA;
                                    var g97 = Graphics.FromImage(btn_aux.Image);
                                    g97.DrawString(text97, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha97;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                               
                                case 112: // CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_09_SET;
                                    var g98 = Graphics.FromImage(btn_aux.Image);
                                    g98.DrawString(text98, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha98;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                 
                                case 113:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_09_RES;
                                    var g99 = Graphics.FromImage(btn_aux.Image);
                                    g99.DrawString(text99, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha99;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 40:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_10_SET;
                                    var g104 = Graphics.FromImage(btn_aux.Image);
                                    g104.DrawString(text104, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha104;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 41:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_10_RESET;
                                    var g105 = Graphics.FromImage(btn_aux.Image);
                                    g105.DrawString(text105, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha105;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 42:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_11_SET;
                                    var g106 = Graphics.FromImage(btn_aux.Image);
                                    g106.DrawString(text106, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha106;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 43:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_11_RESET;
                                    var g107 = Graphics.FromImage(btn_aux.Image);
                                    g107.DrawString(text107, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha107;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 44:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_12_SET;
                                    var g108 = Graphics.FromImage(btn_aux.Image);
                                    g108.DrawString(text108, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha108;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 45:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_12_RESET;
                                    var g109 = Graphics.FromImage(btn_aux.Image);
                                    g109.DrawString(text109, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha109;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 46:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_13_SET;
                                    var g110= Graphics.FromImage(btn_aux.Image);
                                    g110.DrawString(text110, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha110;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 47:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_13_RESET;
                                    var g111 = Graphics.FromImage(btn_aux.Image);
                                    g111.DrawString(text111, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha111;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 48:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_14_SET;
                                    var g112 = Graphics.FromImage(btn_aux.Image);
                                    g112.DrawString(text112, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha112;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 49:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_14_RESET;
                                    var g113 = Graphics.FromImage(btn_aux.Image);
                                    g113.DrawString(text113, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha113;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 156:
                                    btn_aux.Image = Properties.Resources.ANG_E01;
                                    var g64 = Graphics.FromImage(btn_aux.Image);
                                    g64.DrawString(text64, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha64;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 157:
                                    btn_aux.Image = Properties.Resources.ANG_E02;
                                    var g65 = Graphics.FromImage(btn_aux.Image);
                                    g65.DrawString(text65, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha65;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                  
                                    break;
                                case 158:
                                    btn_aux.Image = Properties.Resources.ANG_E03;
                                    var g66 = Graphics.FromImage(btn_aux.Image);
                                    g66.DrawString(text66, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha66;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                
                                case 159:
                                    btn_aux.Image = Properties.Resources.ANG_E04;
                                    var g67 = Graphics.FromImage(btn_aux.Image);
                                    g67.DrawString(text67, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha67;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 38:
                                    btn_aux.Image = Properties.Resources.HAB_F1;
                                    var g102 = Graphics.FromImage(btn_aux.Image);
                                    g102.DrawString(text102, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha102;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                                  
                                case 39:
                                    btn_aux.Image = Properties.Resources.HAB_F2;
                                    var g103 = Graphics.FromImage(btn_aux.Image);
                                    g103.DrawString(text103, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha103;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;                                  
                            }                           
                        }
                    }
                }
                dataGridView1.Visible = true;
                groupBox13.Visible = true;
                groupBox12.Visible = true;
                button1.Visible = true;
                gb_tabela.Visible = true;
                btn_abrir.Visible = false;
            }
        }
               
        //Ícone "Compilar"
        private void btn_compilar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    if (j == 0)
                    {
                        MAT_MAIOR[i, j] = 1;
                    }
                    else
                    {
                        MAT_MAIOR[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < 250; i++)
            {

                coluna = 0;
                for (int j = 1; j < 18; j++)
                {
                    MAT_MAIOR[i, j] = mat[i, coluna];
                    coluna++;
                }
            }

            int indice = 0;
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    newVetor[indice] = (byte)MAT_MAIOR[i, j];
                    indice++;
                }
            }
            try
            {
                // Gera o arquivo FileLad.bin(para gravação)
                using (var fs = new FileStream(this.Text + @"\FileLad.bin", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(newVetor, 0, newVetor.Length);
                   
                    groupBox13.Visible = true;
                    groupBox12.Visible = true;
                   
                    salvar = 1;
                    caminhoarq = this.Text;
                }
                if (btn_transfer_Clicado == 0)
                {
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    string mensagem = "Compilado com sucesso!";
                    string titulo = "Compilado";
                    DialogResult resultado;
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    resultado = MessageBox.Show(mensagem, titulo, botao, icone);

                    if(resultado == DialogResult.OK)
                    {
                        btn_simulacao.Visible = true;
                        btn_transferir.Visible = true;
                    }
                }
                else 
                {
                    
                }
                salvar = 1;
                int indice2 = 0;
                for (int i = 0; i < 250; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        vetor[indice2] = (byte)mat[i, j];
                        indice2++;
                    }
                }

                using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.Write))
                {
                    fs4.Write(vetor, 0, vetor.Length);
                    /*if (btn_transfer_Clicado == 0)
                    {
                        MessageBoxIcon icone4 = MessageBoxIcon.Information;
                        string mensagem4 = "Projeto salvo com sucesso";
                        string titulo4 = "Salvar";
                        MessageBoxButtons botao4 = MessageBoxButtons.OK;
                        MessageBox.Show(mensagem4, titulo4, botao4, icone4);
                    }
                    else { }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //Mensagem de erro ao compilar
                MessageBoxIcon icone2 = MessageBoxIcon.Error;
                string mensagem2 = "Não foi possível compilar";
                string titulo2 = "Erro!";
                MessageBoxButtons botao2 = MessageBoxButtons.OK;
                MessageBox.Show(mensagem2, titulo2, botao2, icone2);
            }
        }
        //Ícone "Salvar"
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            salvar = 1;
            int indice = 0;
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    vetor[indice] = (byte)mat[i, j];
                    indice++;
                }
            }
            
            using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.Write))
            {
                fs4.Write(vetor, 0, vetor.Length);
                if (btn_transfer_Clicado == 0)
                {
                    MessageBoxIcon icone4 = MessageBoxIcon.Information;
                    string mensagem4 = "Projeto salvo com sucesso";
                    string titulo4 = "Salvar";
                    MessageBoxButtons botao4 = MessageBoxButtons.OK;
                    MessageBox.Show(mensagem4, titulo4, botao4, icone4);
                }
                else { }
            }
        }
        // Ícone "Salvar Como"
        private void btn_salvarComo_Click(object sender, EventArgs e)
        {
          
        }
        /// <BLOCO CÓDIGO MENU STRIP>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary> BLOCO CÓDIGO MENU STRIP
        /// <param name="sender"></param>
        /// <param name="e"></param>               
        // Menu "Abrir Projeto"
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.CheckFileExists = true;
            abrir.Filter = "*.prj | *.prj";
            abrir.Multiselect = true;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                arquivo = abrir.FileName; // variavel recebe o arquivo escolhido para abrir, para depois ser tratado como caminho na hora de salvar
                FileInfo fileInfo = new FileInfo(abrir.FileName);
                caminho = fileInfo.DirectoryName;
                this.Text = caminho;
                caminhoAntigo = this.Text;
                btn_salvar.Visible = true;
                btn_fechar.Visible = true;
                btn_novo.Visible = false;

                string coment = this.Text + @"\Comentarios.txt";

                allLines = File.ReadAllLines(coment);

                for (int i = 0; i < allLines.Length; i++)
                {
                    if (allLines[i].Length < 1)
                    {
                        allLines[i] = allLines[i] + "        ";
                    }
                    if (allLines[i].Length < 2)
                    {
                        allLines[i] = allLines[i] + "       ";
                    }
                    else if (allLines[i].Length < 3)
                    {
                        allLines[i] = allLines[i] + "      ";
                    }
                    else if (allLines[i].Length < 4)
                    {
                        allLines[i] = allLines[i] + "     ";
                    }
                    else if (allLines[i].Length < 5)
                    {
                        allLines[i] = allLines[i] + "    ";
                    }
                    else if (allLines[i].Length < 6)
                    {
                        allLines[i] = allLines[i] + "   ";
                    }
                    else if (allLines[i].Length < 7)
                    {
                        allLines[i] = allLines[i] + "  ";
                    }
                    else if (allLines[i].Length < 8)
                    {
                        allLines[i] = allLines[i] + " ";
                    }
                }


                linha0 = allLines[0];
                linha1 = allLines[1];
                linha2 = allLines[2];
                linha3 = allLines[3];
                linha4 = allLines[4];
                linha5 = allLines[5];
                linha6 = allLines[6];
                linha7 = allLines[7];

                linha8 = allLines[8];
                linha9 = allLines[9];
                linha10 = allLines[10];
                linha11 = allLines[11];
                linha12 = allLines[12];
                linha13 = allLines[13];
                linha14 = allLines[14];
                linha15 = allLines[15];

                linha16 = allLines[16];
                linha17 = allLines[17];
                linha18 = allLines[18];
                linha19 = allLines[19];
                linha20 = allLines[20];
                linha21 = allLines[21];
                linha22 = allLines[22];
                linha23 = allLines[23];

                linha24 = allLines[24];
                linha25 = allLines[25];
                linha26 = allLines[26];
                linha27 = allLines[27];
                linha28 = allLines[28];
                linha29 = allLines[29];
                linha30 = allLines[30];
                linha31 = allLines[31];

                linha32 = allLines[32];
                linha33 = allLines[33];
                linha34 = allLines[34];
                linha35 = allLines[35];
                linha36 = allLines[36];
                linha37 = allLines[37];
                linha38 = allLines[38];
                linha39 = allLines[39];

                linha40 = allLines[40];
                linha41 = allLines[41];
                linha42 = allLines[42];
                linha43 = allLines[43];
                linha44 = allLines[44];
                linha45 = allLines[45];
                linha46 = allLines[46];
                linha47 = allLines[47];

                linha48 = allLines[48];
                linha49 = allLines[49];
                linha50 = allLines[50];
                linha51 = allLines[51];
                linha52 = allLines[52];
                linha53 = allLines[53];
                linha54 = allLines[54];
                linha55 = allLines[55];

                linha56 = allLines[56];
                linha57 = allLines[57];
                linha58 = allLines[58];
                linha59 = allLines[59];
                linha60 = allLines[60];
                linha61 = allLines[61];
                linha62 = allLines[62];
                linha63 = allLines[63];

                linha64 = allLines[64];
                linha65 = allLines[65];
                linha66 = allLines[66];
                linha67 = allLines[67];
                linha68 = allLines[68];
                linha69 = allLines[69];
                linha70 = allLines[70];
                linha71 = allLines[71];

                linha72 = allLines[72];
                linha73 = allLines[73];
                linha74 = allLines[74];
                linha75 = allLines[75];
                linha76 = allLines[76];
                linha77 = allLines[77];
                linha78 = allLines[78];
                linha79 = allLines[79];

                linha80 = allLines[80];
                linha81 = allLines[81];
                linha82 = allLines[82];
                linha83 = allLines[83];
                linha84 = allLines[84];
                linha85 = allLines[85];

                linha86 = allLines[86];
                linha87 = allLines[87];

                linha88 = allLines[88];
                linha89 = allLines[89];
                linha90 = allLines[90];
                linha91 = allLines[91];
                linha92 = allLines[92];
                linha93 = allLines[93];
                linha94 = allLines[94];
                linha95 = allLines[95];
                linha96 = allLines[96];
                linha97 = allLines[97];
                linha98 = allLines[98];

                linha99 = allLines[99];
                linha100 = allLines[100];
                linha101 = allLines[101];
                linha102 = allLines[102];
                linha103 = allLines[103];

                linha104 = allLines[104];
                linha105 = allLines[105];
                linha106 = allLines[106];
                linha107 = allLines[107];
                linha108 = allLines[108];
                linha109 = allLines[109];
                linha110 = allLines[110];
                linha111 = allLines[111];
                linha112 = allLines[112];
                linha113 = allLines[113];

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                string text0 = linha0.Substring(0, 8);
                string text1 = linha1.Substring(0, 8);
                string text2 = linha2.Substring(0, 8);
                string text3 = linha3.Substring(0, 8);
                string text4 = linha4.Substring(0, 8);
                string text5 = linha5.Substring(0, 8);
                string text6 = linha6.Substring(0, 8);
                string text7 = linha7.Substring(0, 8);

                string text8 = linha8.Substring(0, 8);
                string text9 = linha9.Substring(0, 8);
                string text10 = linha10.Substring(0, 8);
                string text11 = linha11.Substring(0, 8);
                string text12 = linha12.Substring(0, 8);
                string text13 = linha13.Substring(0, 8);
                string text14 = linha14.Substring(0, 8);
                string text15 = linha15.Substring(0, 8);

                string text16 = linha16.Substring(0, 8);
                string text17 = linha17.Substring(0, 8);
                string text18 = linha18.Substring(0, 8);
                string text19 = linha19.Substring(0, 8);
                string text20 = linha20.Substring(0, 8);
                string text21 = linha21.Substring(0, 8);
                string text22 = linha22.Substring(0, 8);
                string text23 = linha23.Substring(0, 8);

                string text24 = linha24.Substring(0, 8);
                string text25 = linha25.Substring(0, 8);
                string text26 = linha26.Substring(0, 8);
                string text27 = linha27.Substring(0, 8);
                string text28 = linha28.Substring(0, 8);
                string text29 = linha29.Substring(0, 8);
                string text30 = linha30.Substring(0, 8);
                string text31 = linha31.Substring(0, 8);

                string text32 = linha32.Substring(0, 8);
                string text33 = linha33.Substring(0, 8);
                string text34 = linha34.Substring(0, 8);
                string text35 = linha35.Substring(0, 8);
                string text36 = linha36.Substring(0, 8);
                string text37 = linha37.Substring(0, 8);
                string text38 = linha38.Substring(0, 8);
                string text39 = linha39.Substring(0, 8);

                string text40 = linha40.Substring(0, 8);
                string text41 = linha41.Substring(0, 8);
                string text42 = linha42.Substring(0, 8);
                string text43 = linha43.Substring(0, 8);
                string text44 = linha44.Substring(0, 8);
                string text45 = linha45.Substring(0, 8);
                string text46 = linha46.Substring(0, 8);
                string text47 = linha47.Substring(0, 8);

                string text48 = linha48.Substring(0, 8);
                string text49 = linha49.Substring(0, 8);
                string text50 = linha50.Substring(0, 8);
                string text51 = linha51.Substring(0, 8);
                string text52 = linha52.Substring(0, 8);
                string text53 = linha53.Substring(0, 8);
                string text54 = linha54.Substring(0, 8);
                string text55 = linha55.Substring(0, 8);

                string text56 = linha56.Substring(0, 8);
                string text57 = linha57.Substring(0, 8);
                string text58 = linha58.Substring(0, 8);
                string text59 = linha59.Substring(0, 8);
                string text60 = linha60.Substring(0, 8);
                string text61 = linha61.Substring(0, 8);
                string text62 = linha62.Substring(0, 8);
                string text63 = linha63.Substring(0, 8);

                string text64 = linha64.Substring(0, 8);
                string text65 = linha65.Substring(0, 8);
                string text66 = linha66.Substring(0, 8);
                string text67 = linha67.Substring(0, 8);
                string text68 = linha68.Substring(0, 8);
                string text69 = linha69.Substring(0, 8);
                string text70 = linha70.Substring(0, 8);
                string text71 = linha71.Substring(0, 8);

                string text72 = linha72.Substring(0, 8);
                string text73 = linha73.Substring(0, 8);
                string text74 = linha74.Substring(0, 8);
                string text75 = linha75.Substring(0, 8);
                string text76 = linha76.Substring(0, 8);
                string text77 = linha77.Substring(0, 8);
                string text78 = linha78.Substring(0, 8);
                string text79 = linha79.Substring(0, 8);

                string text80 = linha80.Substring(0, 8);
                string text81 = linha81.Substring(0, 8);
                string text82 = linha82.Substring(0, 8);
                string text83 = linha83.Substring(0, 8);
                string text84 = linha84.Substring(0, 8);
                string text85 = linha85.Substring(0, 8);

                string text86 = linha86.Substring(0, 8);
                string text87 = linha87.Substring(0, 8);
                string text88 = linha87.Substring(0, 8);

                string text89 = linha88.Substring(0, 8);
                string text90 = linha89.Substring(0, 8);
                string text91 = linha91.Substring(0, 8);
                string text92 = linha92.Substring(0, 8);
                string text93 = linha93.Substring(0, 8);
                string text94 = linha94.Substring(0, 8);
                string text95 = linha95.Substring(0, 8);
                string text96 = linha96.Substring(0, 8);
                string text97 = linha97.Substring(0, 8);
                string text98 = linha98.Substring(0, 8);

                string text99 = linha99.Substring(0, 8);
                string text100 = linha100.Substring(0, 8);
                string text101 = linha101.Substring(0, 8);
                string text102 = linha102.Substring(0, 8);
                string text103 = linha103.Substring(0, 8);

                string text104 = linha104.Substring(0, 8);
                string text105 = linha105.Substring(0, 8);
                string text106 = linha106.Substring(0, 8);
                string text107 = linha107.Substring(0, 8);
                string text108 = linha108.Substring(0, 8);
                string text109 = linha109.Substring(0, 8);
                string text110 = linha110.Substring(0, 8);
                string text111 = linha111.Substring(0, 8);
                string text112 = linha112.Substring(0, 8);
                string text113 = linha113.Substring(0, 8);

                repassandoCaminho = caminho;

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo01 = this.Text + @"\FileT01.txt";
                string conteudoTempo01 = System.IO.File.ReadAllText(tempo01);
                RecebendoconteudoTempo01 = conteudoTempo01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo02 = this.Text + @"\FileT02.txt";
                string conteudoTempo02 = System.IO.File.ReadAllText(tempo02);
                RecebendoconteudoTempo02 = conteudoTempo02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo03 = this.Text + @"\FileT03.txt";
                string conteudoTempo03 = System.IO.File.ReadAllText(tempo03);
                RecebendoconteudoTempo03 = conteudoTempo03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo04 = this.Text + @"\FileT04.txt";
                string conteudoTempo04 = System.IO.File.ReadAllText(tempo04);
                RecebendoconteudoTempo04 = conteudoTempo04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo05 = this.Text + @"\FileT05.txt";
                string conteudoTempo05 = System.IO.File.ReadAllText(tempo05);
                RecebendoconteudoTempo05 = conteudoTempo05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo06 = this.Text + @"\FileT06.txt";
                string conteudoTempo06 = System.IO.File.ReadAllText(tempo06);
                RecebendoconteudoTempo06 = conteudoTempo06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo07 = this.Text + @"\FileT07.txt";
                string conteudoTempo07 = System.IO.File.ReadAllText(tempo07);
                RecebendoconteudoTempo07 = conteudoTempo07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo08 = this.Text + @"\FileT08.txt";
                string conteudoTempo08 = System.IO.File.ReadAllText(tempo08);
                RecebendoconteudoTempo08 = conteudoTempo08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo09 = this.Text + @"\FileT09.txt";
                string conteudoTempo09 = System.IO.File.ReadAllText(tempo09);
                RecebendoconteudoTempo09 = conteudoTempo09;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo10 = this.Text + @"\FileT10.txt";
                string conteudoTempo10 = System.IO.File.ReadAllText(tempo10);
                RecebendoconteudoTempo10 = conteudoTempo10;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo11 = this.Text + @"\FileT11.txt";
                string conteudoTempo11 = System.IO.File.ReadAllText(tempo11);
                RecebendoconteudoTempo11 = conteudoTempo11;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo12 = this.Text + @"\FileT12.txt";
                string conteudoTempo12 = System.IO.File.ReadAllText(tempo12);
                RecebendoconteudoTempo12 = conteudoTempo12;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo13 = this.Text + @"\FileT13.txt";
                string conteudoTempo13 = System.IO.File.ReadAllText(tempo13);
                RecebendoconteudoTempo13 = conteudoTempo13;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo14 = this.Text + @"\FileT14.txt";
                string conteudoTempo14 = System.IO.File.ReadAllText(tempo14);
                RecebendoconteudoTempo14 = conteudoTempo14;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo15 = this.Text + @"\FileT15.txt";
                string conteudoTempo15 = System.IO.File.ReadAllText(tempo15);
                RecebendoconteudoTempo15 = conteudoTempo15;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo16 = this.Text + @"\FileT16.txt";
                string conteudoTempo16 = System.IO.File.ReadAllText(tempo16);
                RecebendoconteudoTempo16 = conteudoTempo16;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo17 = this.Text + @"\FileT17.txt";
                string conteudoTempo17 = System.IO.File.ReadAllText(tempo17);
                RecebendoconteudoTempo17 = conteudoTempo17;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo18 = this.Text + @"\FileT18.txt";
                string conteudoTempo18 = System.IO.File.ReadAllText(tempo18);
                RecebendoconteudoTempo18 = conteudoTempo18;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo19 = this.Text + @"\FileT19.txt";
                string conteudoTempo19 = System.IO.File.ReadAllText(tempo19);
                RecebendoconteudoTempo19 = conteudoTempo19;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo20 = this.Text + @"\FileT20.txt";
                string conteudoTempo20 = System.IO.File.ReadAllText(tempo20);
                RecebendoconteudoTempo20 = conteudoTempo20;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo21 = this.Text + @"\FileT21.txt";
                string conteudoTempo21 = System.IO.File.ReadAllText(tempo21);
                RecebendoconteudoTempo21 = conteudoTempo21;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo22 = this.Text + @"\FileT22.txt";
                string conteudoTempo22 = System.IO.File.ReadAllText(tempo22);
                RecebendoconteudoTempo22 = conteudoTempo22;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo23 = this.Text + @"\FileT23.txt";
                string conteudoTempo23 = System.IO.File.ReadAllText(tempo23);
                RecebendoconteudoTempo23 = conteudoTempo23;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo24 = this.Text + @"\FileT24.txt";
                string conteudoTempo24 = System.IO.File.ReadAllText(tempo24);
                RecebendoconteudoTempo24 = conteudoTempo24;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string contador01 = this.Text + @"\FileC01.txt";
                string conteudoCont01 = System.IO.File.ReadAllText(contador01);
                RecebendoconteudoCont01 = conteudoCont01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string contador02 = this.Text + @"\FileC02.txt";
                string conteudoCont02 = System.IO.File.ReadAllText(contador02);
                RecebendoconteudoCont02 = conteudoCont02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem00 = this.Text + @"\FileD00.txt";
                string conteudoMsg00 = System.IO.File.ReadAllText(mensagem00);
                RecebendoconteudoMsg00 = conteudoMsg00;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
                string mensagem01 = this.Text + @"\FileD01.txt";
                string conteudoMsg01 = System.IO.File.ReadAllText(mensagem01);
                RecebendoconteudoMsg01 = conteudoMsg01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
                string mensagem02 = this.Text + @"\FileD02.txt";
                string conteudoMsg02 = System.IO.File.ReadAllText(mensagem02);
                RecebendoconteudoMsg02_2 = conteudoMsg02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
                string mensagem03 = this.Text + @"\FileD03.txt";
                string conteudoMsg03 = System.IO.File.ReadAllText(mensagem03);
                RecebendoconteudoMsg03 = conteudoMsg03;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
                string mensagem04 = this.Text + @"\FileD04.txt";
                string conteudoMsg04 = System.IO.File.ReadAllText(mensagem04);
                RecebendoconteudoMsg04 = conteudoMsg04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem05 = this.Text + @"\FileD05.txt";
                string conteudoMsg05 = System.IO.File.ReadAllText(mensagem05);
                RecebendoconteudoMsg05 = conteudoMsg05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem06 = this.Text + @"\FileD06.txt";
                string conteudoMsg06 = System.IO.File.ReadAllText(mensagem06);
                RecebendoconteudoMsg06 = conteudoMsg06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem07 = this.Text + @"\FileD07.txt";
                string conteudoMsg07 = System.IO.File.ReadAllText(mensagem07);
                RecebendoconteudoMsg07 = conteudoMsg07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem08 = this.Text + @"\FileD08.txt";
                string conteudoMsg08 = System.IO.File.ReadAllText(mensagem08);
                RecebendoconteudoMsg08 = conteudoMsg08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo01 = this.Text + @"\FileR01.txt";
                string conteudoRet01 = System.IO.File.ReadAllText(retardo01);
                RecebendoconteudoRet01 = conteudoRet01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo02 = this.Text + @"\FileR02.txt";
                string conteudoRet02 = System.IO.File.ReadAllText(retardo02);
                RecebendoconteudoRet02 = conteudoRet02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo03 = this.Text + @"\FileR03.txt";
                string conteudoRet03 = System.IO.File.ReadAllText(retardo03);
                RecebendoconteudoRet03 = conteudoRet03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo04 = this.Text + @"\FileR04.txt";
                string conteudoRet04 = System.IO.File.ReadAllText(retardo04);
                RecebendoconteudoRet04 = conteudoRet04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo05 = this.Text + @"\FileR05.txt";
                string conteudoRet05 = System.IO.File.ReadAllText(retardo05);
                RecebendoconteudoRet05 = conteudoRet05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo06 = this.Text + @"\FileR06.txt";
                string conteudoRet06 = System.IO.File.ReadAllText(retardo06);
                RecebendoconteudoRet06 = conteudoRet06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo07 = this.Text + @"\FileR07.txt";
                string conteudoRet07 = System.IO.File.ReadAllText(retardo07);
                RecebendoconteudoRet07 = conteudoRet07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo08 = this.Text + @"\FileR08.txt";
                string conteudoRet08 = System.IO.File.ReadAllText(retardo08);
                RecebendoconteudoRet08 = conteudoRet08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica1 = caminho + @"\FileA01.txt";
                string conteudoAng01 = System.IO.File.ReadAllText(analogica1);
                Form1.RecebendoconteudoA01 = conteudoAng01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica2 = caminho + @"\FileA02.txt";
                string conteudoAng02 = System.IO.File.ReadAllText(analogica2);
                Form1.RecebendoconteudoA02 = conteudoAng02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica3 = caminho + @"\FileA03.txt";
                string conteudoAng03 = System.IO.File.ReadAllText(analogica3);
                Form1.RecebendoconteudoA03 = conteudoAng03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica4 = caminho + @"\FileA04.txt";
                string conteudoAng04 = System.IO.File.ReadAllText(analogica4);
                Form1.RecebendoconteudoA04 = conteudoAng04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string habiltarFuncao = caminho + @"\FileB01.txt";
                string conteudoHab00 = System.IO.File.ReadAllText(habiltarFuncao);
                Form1.RecebendoconteudoADJ00 = conteudoHab00;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string habiltarFuncao2 = caminho + @"\FileB02.txt";
                string conteudoHab01 = System.IO.File.ReadAllText(habiltarFuncao2);
                Form1.RecebendoconteudoADJ01 = conteudoHab01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string Bimanual1 = caminho + @"\FileBM1.txt";
                string conteudoBim1 = System.IO.File.ReadAllText(Bimanual1);
                RecebendoconteudoBM1 = conteudoBim1;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string Bimanual2 = caminho + @"\FileBM2.txt";
                string conteudoBim2 = System.IO.File.ReadAllText(Bimanual2);
                RecebendoconteudoBM2 = conteudoBim2;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                using (var fs4 = new FileStream(abrir.FileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs4.Read(vetor, 0, vetor.Length);

                    int indice = 0;
                    for (int i = 0; i < 250; i++)
                    {
                        for (int j = 0; j < 17; j++)
                        {
                            mat[i, j] = vetor[indice];
                            indice++;
                            switch (mat[i, j])
                            {
                                case 36:
                                    btn_aux.Image = Properties.Resources.bimanual_E7_E8;
                                    var g_100 = Graphics.FromImage(btn_aux.Image);
                                    g_100.DrawString(text100, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha100;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 250: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.botao_invisivel; break;

                                case 200: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_T; break;

                                case 201: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_H; break;

                                case 202: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_L; break;

                                case 0: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.linhas_gridview; break;
                                case 1: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.CONTINUO; break;

                                case 3: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.CONTINUO; break;

                                case 4:
                                    btn_aux.Image = Properties.Resources.ENA_E01;
                                    var g0 = Graphics.FromImage(btn_aux.Image);
                                    g0.DrawString(text0, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha0;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 6:
                                    btn_aux.Image = Properties.Resources.ENA_E02;
                                    var g1 = Graphics.FromImage(btn_aux.Image);
                                    g1.DrawString(text1, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha1;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 8:
                                    btn_aux.Image = Properties.Resources.ENA_E03;
                                    var g2 = Graphics.FromImage(btn_aux.Image);
                                    g2.DrawString(text2, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha2;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 10:
                                    btn_aux.Image = Properties.Resources.ENA_E04;
                                    var g3 = Graphics.FromImage(btn_aux.Image);
                                    g3.DrawString(text3, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha3;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 12:
                                    btn_aux.Image = Properties.Resources.ENA_E05;
                                    var g4 = Graphics.FromImage(btn_aux.Image);
                                    g4.DrawString(text4, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha4;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 14:
                                    btn_aux.Image = Properties.Resources.ENA_E06;
                                    var g5 = Graphics.FromImage(btn_aux.Image);
                                    g5.DrawString(text5, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha5;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 16:
                                    btn_aux.Image = Properties.Resources.ENA_E07;
                                    var g6 = Graphics.FromImage(btn_aux.Image);
                                    g6.DrawString(text6, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha6;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 18:
                                    btn_aux.Image = Properties.Resources.ENA_E08;
                                    var g7 = Graphics.FromImage(btn_aux.Image);
                                    g7.DrawString(text7, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha7;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 5:
                                    btn_aux.Image = Properties.Resources.ENF_E01;
                                    var g8 = Graphics.FromImage(btn_aux.Image);
                                    g8.DrawString(text8, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha8;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 7:
                                    btn_aux.Image = Properties.Resources.ENF_E02;
                                    var g9 = Graphics.FromImage(btn_aux.Image);
                                    g9.DrawString(text9, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha9;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 9:
                                    btn_aux.Image = Properties.Resources.ENF_E03;
                                    var g10 = Graphics.FromImage(btn_aux.Image);
                                    g10.DrawString(text10, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha10;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 11:
                                    btn_aux.Image = Properties.Resources.ENF_E041;
                                    var g11 = Graphics.FromImage(btn_aux.Image);
                                    g11.DrawString(text11, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha11;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 13:
                                    btn_aux.Image = Properties.Resources.ENF_E05;
                                    var g12 = Graphics.FromImage(btn_aux.Image);
                                    g12.DrawString(text12, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha12;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 15:
                                    btn_aux.Image = Properties.Resources.ENF_E06;
                                    var g13 = Graphics.FromImage(btn_aux.Image);
                                    g13.DrawString(text13, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha13;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 17:
                                    btn_aux.Image = Properties.Resources.ENF_E07;
                                    var g14 = Graphics.FromImage(btn_aux.Image);
                                    g14.DrawString(text14, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha14;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 19:
                                    btn_aux.Image = Properties.Resources.ENF_E08;
                                    var g15 = Graphics.FromImage(btn_aux.Image);
                                    g15.DrawString(text15, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha15;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 20:
                                    btn_aux.Image = Properties.Resources.BP_E01;
                                    var g24 = Graphics.FromImage(btn_aux.Image);
                                    g24.DrawString(text24, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha24;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 22:
                                    btn_aux.Image = Properties.Resources.BP_E02;
                                    var g25 = Graphics.FromImage(btn_aux.Image);
                                    g25.DrawString(text25, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha25;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 24:
                                    btn_aux.Image = Properties.Resources.BP_E03;
                                    var g26 = Graphics.FromImage(btn_aux.Image);
                                    g26.DrawString(text26, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha26;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 26:
                                    btn_aux.Image = Properties.Resources.BP_E04;
                                    var g27 = Graphics.FromImage(btn_aux.Image);
                                    g27.DrawString(text27, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha27;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 28:
                                    btn_aux.Image = Properties.Resources.BP_E05;
                                    var g28 = Graphics.FromImage(btn_aux.Image);
                                    g28.DrawString(text28, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha28;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 30:
                                    btn_aux.Image = Properties.Resources.BP_E06;
                                    var g29 = Graphics.FromImage(btn_aux.Image);
                                    g29.DrawString(text29, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha29;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 32:
                                    btn_aux.Image = Properties.Resources.BP_E07;
                                    var g30 = Graphics.FromImage(btn_aux.Image);
                                    g30.DrawString(text30, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha30;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 34:
                                    btn_aux.Image = Properties.Resources.BP_E08;
                                    var g31 = Graphics.FromImage(btn_aux.Image);
                                    g31.DrawString(text31, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha31;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 21:
                                    btn_aux.Image = Properties.Resources.BN_E01;
                                    var g16 = Graphics.FromImage(btn_aux.Image);
                                    g16.DrawString(text16, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha16;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 23:
                                    btn_aux.Image = Properties.Resources.BN_E02;
                                    var g17 = Graphics.FromImage(btn_aux.Image);
                                    g17.DrawString(text17, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha17;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 25:
                                    btn_aux.Image = Properties.Resources.BN_E03;
                                    var g18 = Graphics.FromImage(btn_aux.Image);
                                    g18.DrawString(text18, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha18;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 27:
                                    btn_aux.Image = Properties.Resources.BN_E04;
                                    var g19 = Graphics.FromImage(btn_aux.Image);
                                    g19.DrawString(text19, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha19;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 29:
                                    btn_aux.Image = Properties.Resources.BN_E05;
                                    var g20 = Graphics.FromImage(btn_aux.Image);
                                    g20.DrawString(text20, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha20;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 31:
                                    btn_aux.Image = Properties.Resources.BN_E06;
                                    var g21 = Graphics.FromImage(btn_aux.Image);
                                    g21.DrawString(text21, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha21;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 33:
                                    btn_aux.Image = Properties.Resources.BN_E07;
                                    var g22 = Graphics.FromImage(btn_aux.Image);
                                    g22.DrawString(text22, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha22;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 35:
                                    btn_aux.Image = Properties.Resources.BN_E08;
                                    var g23 = Graphics.FromImage(btn_aux.Image);
                                    g23.DrawString(text23, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha23;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 114:
                                    btn_aux.Image = Properties.Resources.contador01;
                                    var g68 = Graphics.FromImage(btn_aux.Image);
                                    g68.DrawString(text68, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha68;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 115:
                                    btn_aux.Image = Properties.Resources.contador02;
                                    var g69 = Graphics.FromImage(btn_aux.Image);
                                    g69.DrawString(text69, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha69;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 148: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d01; break;

                                case 149: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d02; break;

                                case 150: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d03; break;

                                case 151: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d04; break;

                                case 152: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d05; break;

                                case 153: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d06; break;

                                case 154: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d07; break;


                                case 155: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d08; break;

                                case 116:
                                    btn_aux.Image = Properties.Resources.espera01;
                                    var g70 = Graphics.FromImage(btn_aux.Image);
                                    g70.DrawString(text70, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha70;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 117:
                                    btn_aux.Image = Properties.Resources.espera02;
                                    var g71 = Graphics.FromImage(btn_aux.Image);
                                    g71.DrawString(text71, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha71;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 118:
                                    btn_aux.Image = Properties.Resources.espera03;
                                    var g72 = Graphics.FromImage(btn_aux.Image);
                                    g72.DrawString(text72, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha72;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 119:
                                    btn_aux.Image = Properties.Resources.espera04;
                                    var g73 = Graphics.FromImage(btn_aux.Image);
                                    g73.DrawString(text73, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha73;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 120:
                                    btn_aux.Image = Properties.Resources.espera05;
                                    var g74 = Graphics.FromImage(btn_aux.Image);
                                    g74.DrawString(text74, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha74;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 121:
                                    btn_aux.Image = Properties.Resources.espera06;
                                    var g75 = Graphics.FromImage(btn_aux.Image);
                                    g75.DrawString(text75, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha75;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 122:
                                    btn_aux.Image = Properties.Resources.espera07;
                                    var g76 = Graphics.FromImage(btn_aux.Image);
                                    g76.DrawString(text76, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha76;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 123:
                                    btn_aux.Image = Properties.Resources.espera08;
                                    var g77 = Graphics.FromImage(btn_aux.Image);
                                    g77.DrawString(text77, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha77;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 124:
                                    btn_aux.Image = Properties.Resources.temporizador_01;
                                    var g78 = Graphics.FromImage(btn_aux.Image);
                                    g78.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 125:
                                    btn_aux.Image = Properties.Resources.temporizador_02;
                                    var g79 = Graphics.FromImage(btn_aux.Image);
                                    g79.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 126:
                                    btn_aux.Image = Properties.Resources.temporizador_03;
                                    var g80 = Graphics.FromImage(btn_aux.Image);
                                    g80.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 127:
                                    btn_aux.Image = Properties.Resources.temporizador_04;
                                    var g81 = Graphics.FromImage(btn_aux.Image);
                                    g81.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 128:
                                    btn_aux.Image = Properties.Resources.temporizador_05;
                                    var g82 = Graphics.FromImage(btn_aux.Image);
                                    g82.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 129:
                                    btn_aux.Image = Properties.Resources.temporizador_06;
                                    var g83 = Graphics.FromImage(btn_aux.Image);
                                    g83.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 130:
                                    btn_aux.Image = Properties.Resources.temporizador_07;
                                    var g84 = Graphics.FromImage(btn_aux.Image);
                                    g84.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 131:
                                    btn_aux.Image = Properties.Resources.temporizador_08;
                                    var g85 = Graphics.FromImage(btn_aux.Image);
                                    g85.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 132:
                                    btn_aux.Image = Properties.Resources.temporizador_09;
                                    var g78_2 = Graphics.FromImage(btn_aux.Image);
                                    g78_2.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 133:
                                    btn_aux.Image = Properties.Resources.temporizador_10;
                                    var g79_2 = Graphics.FromImage(btn_aux.Image);
                                    g79_2.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 134:
                                    btn_aux.Image = Properties.Resources.temporizador_11;
                                    var g80_2 = Graphics.FromImage(btn_aux.Image);
                                    g80_2.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 135:
                                    btn_aux.Image = Properties.Resources.temporizador_12;
                                    var g81_2 = Graphics.FromImage(btn_aux.Image);
                                    g81_2.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 136:
                                    btn_aux.Image = Properties.Resources.temporizador_13;
                                    var g82_2 = Graphics.FromImage(btn_aux.Image);
                                    g82_2.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 137:
                                    btn_aux.Image = Properties.Resources.temporizador_14;
                                    var g83_2 = Graphics.FromImage(btn_aux.Image);
                                    g83_2.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 138:
                                    btn_aux.Image = Properties.Resources.temporizador_15;
                                    var g84_2 = Graphics.FromImage(btn_aux.Image);
                                    g84_2.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 139:
                                    btn_aux.Image = Properties.Resources.temporizador_16;
                                    var g85_2 = Graphics.FromImage(btn_aux.Image);
                                    g85_2.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 140:
                                    btn_aux.Image = Properties.Resources.temporizador_17;
                                    var g78_3 = Graphics.FromImage(btn_aux.Image);
                                    g78_3.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 141:
                                    btn_aux.Image = Properties.Resources.temporizador_18;
                                    var g79_3 = Graphics.FromImage(btn_aux.Image);
                                    g79_3.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 142:
                                    btn_aux.Image = Properties.Resources.temporizador_19;
                                    var g80_3 = Graphics.FromImage(btn_aux.Image);
                                    g80_3.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 143:
                                    btn_aux.Image = Properties.Resources.temporizador_20;
                                    var g81_3 = Graphics.FromImage(btn_aux.Image);
                                    g81_3.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 144:
                                    btn_aux.Image = Properties.Resources.temporizador_21;
                                    var g82_3 = Graphics.FromImage(btn_aux.Image);
                                    g82_3.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 145:
                                    btn_aux.Image = Properties.Resources.temporizador_22;
                                    var g83_3 = Graphics.FromImage(btn_aux.Image);
                                    g83_3.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 146:
                                    btn_aux.Image = Properties.Resources.temporizador_23;
                                    var g84_3 = Graphics.FromImage(btn_aux.Image);
                                    g84_3.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 147:
                                    btn_aux.Image = Properties.Resources.temporizador_24;
                                    var g85_3 = Graphics.FromImage(btn_aux.Image);
                                    g85_3.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 52:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E01;

                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_01;

                                    }
                                    var g32 = Graphics.FromImage(btn_aux.Image);
                                    g32.DrawString(text32, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha32;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 54:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_02;
                                    }
                                    var g33 = Graphics.FromImage(btn_aux.Image);
                                    g33.DrawString(text33, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha33;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 56:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_03;
                                    }

                                    var g34 = Graphics.FromImage(btn_aux.Image);
                                    g34.DrawString(text34, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha34;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 58:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_04;
                                    }

                                    var g35 = Graphics.FromImage(btn_aux.Image);
                                    g35.DrawString(text35, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha35;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 60:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_05;
                                    }
                                    var g36 = Graphics.FromImage(btn_aux.Image);
                                    g36.DrawString(text36, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha36;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 62:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_06;
                                    }
                                    var g37 = Graphics.FromImage(btn_aux.Image);
                                    g37.DrawString(text37, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha37;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 64:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_07;
                                    }
                                    var g38 = Graphics.FromImage(btn_aux.Image);
                                    g38.DrawString(text38, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha38;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 66:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_08;
                                    }
                                    var g39 = Graphics.FromImage(btn_aux.Image);
                                    g39.DrawString(text39, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha39;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 53:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_1;
                                    }
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_1;
                                    var g40 = Graphics.FromImage(btn_aux.Image);
                                    g40.DrawString(text40, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha40;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 55:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_2;
                                    }
                                    var g41 = Graphics.FromImage(btn_aux.Image);
                                    g41.DrawString(text41, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha41;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 57:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_3;
                                    }
                                    var g42 = Graphics.FromImage(btn_aux.Image);
                                    g42.DrawString(text42, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha42;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 59:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_4;
                                    }
                                    var g43 = Graphics.FromImage(btn_aux.Image);
                                    g43.DrawString(text43, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha43;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 61:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_5;
                                    }
                                    var g44 = Graphics.FromImage(btn_aux.Image);
                                    g44.DrawString(text44, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha44;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 63:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_6;
                                    }
                                    var g45 = Graphics.FromImage(btn_aux.Image);
                                    g45.DrawString(text45, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha45;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 65:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_7;
                                    }
                                    var g46 = Graphics.FromImage(btn_aux.Image);
                                    g46.DrawString(text46, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha46;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 67:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_8;
                                    }
                                    var g47 = Graphics.FromImage(btn_aux.Image);
                                    g47.DrawString(text47, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha47;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 68:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET;
                                    }
                                    var g48 = Graphics.FromImage(btn_aux.Image);
                                    g48.DrawString(text48, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha48;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 70:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_2;
                                    }
                                    var g49 = Graphics.FromImage(btn_aux.Image);
                                    g49.DrawString(text49, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha49;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 72:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_3;
                                    }
                                    var g50 = Graphics.FromImage(btn_aux.Image);
                                    g50.DrawString(text50, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha50;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 74:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_4;
                                    }
                                    var g51 = Graphics.FromImage(btn_aux.Image);
                                    g51.DrawString(text51, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha51;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 76:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_5;
                                    }
                                    var g52 = Graphics.FromImage(btn_aux.Image);
                                    g52.DrawString(text52, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha52;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 78:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_6;
                                    }
                                    var g53 = Graphics.FromImage(btn_aux.Image);
                                    g53.DrawString(text53, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha53;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 80:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_7;
                                    }
                                    var g54 = Graphics.FromImage(btn_aux.Image);
                                    g54.DrawString(text54, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha54;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 82:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_8;
                                    }
                                    var g55 = Graphics.FromImage(btn_aux.Image);
                                    g55.DrawString(text55, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha55;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 69:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES;
                                    }
                                    var g56 = Graphics.FromImage(btn_aux.Image);
                                    g56.DrawString(text56, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha56;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 71:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_2;
                                    }
                                    var g57 = Graphics.FromImage(btn_aux.Image);
                                    g57.DrawString(text57, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha57;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 73:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_3;
                                    }
                                    var g58 = Graphics.FromImage(btn_aux.Image);
                                    g58.DrawString(text58, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha58;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 75:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_4;
                                    }
                                    var g59 = Graphics.FromImage(btn_aux.Image);
                                    g59.DrawString(text59, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha59;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 77:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_5;
                                    }
                                    var g60 = Graphics.FromImage(btn_aux.Image);
                                    g60.DrawString(text60, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha60;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 79:

                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_6;
                                    }
                                    var g61 = Graphics.FromImage(btn_aux.Image);
                                    g61.DrawString(text61, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha61;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 81:

                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_7;
                                    }
                                    var g62 = Graphics.FromImage(btn_aux.Image);
                                    g62.DrawString(text62, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha62;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 83:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_8;
                                    }
                                    var g63 = Graphics.FromImage(btn_aux.Image);
                                    g63.DrawString(text63, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha63;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 100: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_01_NA;
                                    var g86 = Graphics.FromImage(btn_aux.Image);
                                    g86.DrawString(text86, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha86;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 101: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_01_NF;
                                    var g87 = Graphics.FromImage(btn_aux.Image);
                                    g87.DrawString(text87, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha87;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 102: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_02_NA;
                                    var g88 = Graphics.FromImage(btn_aux.Image);
                                    g88.DrawString(text88, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha88;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 103: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_02_NF;
                                    var g89 = Graphics.FromImage(btn_aux.Image);
                                    g89.DrawString(text89, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha89;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 104: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_03_NA;
                                    var g90 = Graphics.FromImage(btn_aux.Image);
                                    g90.DrawString(text90, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha90;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 105: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_03_NF;
                                    var g91 = Graphics.FromImage(btn_aux.Image);
                                    g91.DrawString(text91, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha91;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 106: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_04_NA;
                                    var g92 = Graphics.FromImage(btn_aux.Image);
                                    g92.DrawString(text92, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha92;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 107: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_04_NF;
                                    var g93 = Graphics.FromImage(btn_aux.Image);
                                    g93.DrawString(text93, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha93;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 108: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_05_NA;
                                    var g94 = Graphics.FromImage(btn_aux.Image);
                                    g94.DrawString(text94, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha94;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 109: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_06_NA;
                                    var g95 = Graphics.FromImage(btn_aux.Image);
                                    g95.DrawString(text95, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha95;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 110: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_07_NA;
                                    var g96 = Graphics.FromImage(btn_aux.Image);
                                    g96.DrawString(text96, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha96;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 111: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_08_NA;
                                    var g97 = Graphics.FromImage(btn_aux.Image);
                                    g97.DrawString(text97, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha97;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 112: // CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_09_SET;
                                    var g98 = Graphics.FromImage(btn_aux.Image);
                                    g98.DrawString(text98, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha98;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 113:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_09_RES;
                                    var g99 = Graphics.FromImage(btn_aux.Image);
                                    g99.DrawString(text99, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha99;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 40:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_10_SET;
                                    var g104 = Graphics.FromImage(btn_aux.Image);
                                    g104.DrawString(text104, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha104;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 41:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_10_RESET;
                                    var g105 = Graphics.FromImage(btn_aux.Image);
                                    g105.DrawString(text105, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha105;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 42:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_11_SET;
                                    var g106 = Graphics.FromImage(btn_aux.Image);
                                    g106.DrawString(text106, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha106;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 43:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_11_RESET;
                                    var g107 = Graphics.FromImage(btn_aux.Image);
                                    g107.DrawString(text107, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha107;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 44:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_12_SET;
                                    var g108 = Graphics.FromImage(btn_aux.Image);
                                    g108.DrawString(text108, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha108;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 45:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_12_RESET;
                                    var g109 = Graphics.FromImage(btn_aux.Image);
                                    g109.DrawString(text109, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha109;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 46:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_13_SET;
                                    var g110 = Graphics.FromImage(btn_aux.Image);
                                    g110.DrawString(text110, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha110;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 47:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_13_RESET;
                                    var g111 = Graphics.FromImage(btn_aux.Image);
                                    g111.DrawString(text111, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha111;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 48:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_14_SET;
                                    var g112 = Graphics.FromImage(btn_aux.Image);
                                    g112.DrawString(text112, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha112;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 49:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_14_RESET;
                                    var g113 = Graphics.FromImage(btn_aux.Image);
                                    g113.DrawString(text113, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha113;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 156:
                                    btn_aux.Image = Properties.Resources.ANG_E01;
                                    var g64 = Graphics.FromImage(btn_aux.Image);
                                    g64.DrawString(text64, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha64;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 157:
                                    btn_aux.Image = Properties.Resources.ANG_E02;
                                    var g65 = Graphics.FromImage(btn_aux.Image);
                                    g65.DrawString(text65, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha65;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;

                                    break;
                                case 158:
                                    btn_aux.Image = Properties.Resources.ANG_E03;
                                    var g66 = Graphics.FromImage(btn_aux.Image);
                                    g66.DrawString(text66, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha66;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 159:
                                    btn_aux.Image = Properties.Resources.ANG_E04;
                                    var g67 = Graphics.FromImage(btn_aux.Image);
                                    g67.DrawString(text67, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha67;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 38:
                                    btn_aux.Image = Properties.Resources.HAB_F1;
                                    var g102 = Graphics.FromImage(btn_aux.Image);
                                    g102.DrawString(text102, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha102;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 39:
                                    btn_aux.Image = Properties.Resources.HAB_F2;
                                    var g103 = Graphics.FromImage(btn_aux.Image);
                                    g103.DrawString(text103, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha103;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                            }
                        }
                    }
                }
                dataGridView1.Visible = true;
                groupBox13.Visible = true;
                groupBox12.Visible = true;
                button1.Visible = true;
                gb_tabela.Visible = true;
                btn_abrir.Visible = false;
            }

        }
        private void menusStrip_Novo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diretorio = new FolderBrowserDialog();
            diretorio.Description = "Selecionar diretorio";

            if (diretorio.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(diretorio.SelectedPath);

                FileInfo[] TXTFiles = di.GetFiles("*.prj");
                if (TXTFiles.Length > 0)
                {
                    MessageBox.Show("Já existe projeto nesse diretório.Selecione outro diretório");
                    btn_novo_Click(sender, e);
                }
                else
                {
                    SaveFileDialog arquivoSalvo = new SaveFileDialog();
                    arquivoSalvo.InitialDirectory = diretorio.SelectedPath;
                    arquivoSalvo.Filter = "*.prj | *.prj";
                    arquivoSalvo.Title = "Novo Projeto";

                    if (arquivoSalvo.ShowDialog() == DialogResult.OK)
                    {
                        NomeArquivo = arquivoSalvo.FileName;
                        arquivo = arquivoSalvo.FileName;

                        // transforma a matriz[8x17] para um vet[136]          
                        int indice = 0;
                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 17; j++)
                            {
                                vetor[indice] = (byte)mat[i, j];
                                indice++;
                            }
                        }
                        try
                        {
                            using (var fs = new FileStream(arquivoSalvo.FileName, FileMode.Create, FileAccess.Write))
                            {
                                fs.Write(vetor, 0, vetor.Length);
                                groupBox13.Visible = true;
                                groupBox12.Visible = true;
                                arquivo = arquivoSalvo.FileName;
                            }

                            using (var fs2 = new FileStream(arquivo, FileMode.Create, FileAccess.Write))
                            {
                                fs2.Write(vetor, 0, vetor.Length);
                                groupBox13.Visible = true;
                                groupBox12.Visible = true;
                            }

                        }
                        catch (Exception ex)
                        {

                        }

                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
                        if (File.Exists(arquivo))
                        {
                            FileInfo fileInfo = new FileInfo(arquivo);
                            caminho = fileInfo.DirectoryName; // verifica qual o diretorio do arquivo e escreve no text do forms(cabeçalho)
                            this.Text = caminho;
                            caminhoAntigo = this.Text;
                            btn_salvar.Visible = true;
                            btn_fechar.Visible = true;
                            btn_novo.Visible = false;
                            dataGridView1.Visible = true;
                            button1.Visible = true;
                            btn_abrir.Visible = false;
                        }
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string BM1 = this.Text + @"\FileBM1.txt";
                        caminhoarq = this.Text;
                        StreamWriter BIM = new StreamWriter(BM1);
                        string fraseBM1 = "Configuracao Bimanual 01:;0000;0001;0000;0;";
                        char[] vetCharBM1 = fraseBM1.ToCharArray();
                        foreach (char letra in vetCharBM1)
                            BIM.Write(letra);
                        BIM.Close();
                        RecebendoconteudoBM1 = fraseBM1;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////               
                        string BM2 = this.Text + @"\FileBM2.txt";
                        caminhoarq = this.Text;
                        StreamWriter BIM2 = new StreamWriter(BM2);
                        string fraseBM2 = "Configuracao Bimanual 02:;0000;0001;0000;0;";
                        char[] vetCharBM2 = fraseBM2.ToCharArray();
                        foreach (char letra in vetCharBM2)
                            BIM2.Write(letra);
                        BIM2.Close();
                        RecebendoconteudoBM2 = fraseBM2;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string adj1 = this.Text + @"\FileB01.txt";
                        caminhoarq = this.Text;
                        StreamWriter ad = new StreamWriter(adj1);
                        string fraseADJ = "Habilitar funcao 01:     ;0000;0001;0000;0;";//bit
                        char[] vetCharADJ = fraseADJ.ToCharArray();
                        foreach (char letra in vetCharADJ)
                            ad.Write(letra);
                        ad.Close();
                        RecebendoconteudoADJ00 = fraseADJ;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string adj2 = this.Text + @"\FileB02.txt";
                        caminhoarq = this.Text;
                        StreamWriter ad2 = new StreamWriter(adj2);
                        string fraseADJ2 = "Habilitar funcao 02:     ;0000;0001;0000;0;";//bit
                        char[] vetCharADJ2 = fraseADJ2.ToCharArray();
                        foreach (char letra in vetCharADJ2)
                            ad2.Write(letra);
                        ad2.Close();
                        RecebendoconteudoADJ01 = fraseADJ2;
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string comentarios = this.Text + @"\Comentarios.txt";
                        caminhoarq = this.Text;
                        StreamWriter coment = new StreamWriter(comentarios);
                        string conteudo =
                          " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                          " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                          " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                          " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                          " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +
                          " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " ";

                        char[] vetConteudo = conteudo.ToCharArray();
                        foreach (char letra in vetConteudo)
                            coment.WriteLine(letra);
                        coment.Close();
                        RecebendoComentario = conteudo;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string contador1 = this.Text + @"\FileC01.txt";
                        caminhoarq = this.Text;
                        StreamWriter c = new StreamWriter(contador1);
                        string frase = "Configuracao Contador 01:;0100;0999;0001;0;";
                        char[] vetChar = frase.ToCharArray();
                        foreach (char letra in vetChar)
                            c.Write(letra);
                        c.Close();
                        RecebendoconteudoCont01 = frase;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string contador2 = this.Text + @"\FileC02.txt";
                        StreamWriter c2 = new StreamWriter(contador2);
                        string frase2 = "Configuracao Contador 02:;0100;0999;0001;0;";
                        char[] vetChar2 = frase2.ToCharArray();
                        foreach (char letra2 in vetChar2)
                            c2.Write(letra2);
                        c2.Close();
                        RecebendoconteudoCont02 = frase2;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////           
                        string display1 = this.Text + @"\FileD01.txt";
                        StreamWriter d1 = new StreamWriter(display1);
                        string frase9 = "                                                                ";
                        char[] vetChar9 = frase9.ToCharArray();
                        foreach (char letra9 in vetChar9)
                            d1.Write(letra9);
                        d1.Close();
                        RecebendoconteudoMsg01 = frase9;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string display2 = this.Text + @"\FileD02.txt";
                        StreamWriter d2 = new StreamWriter(display2);
                        string frase10 = "                                                                ";
                        char[] vetChar10 = frase10.ToCharArray();
                        foreach (char letra10 in vetChar10)
                            d2.Write(letra10);
                        d2.Close();
                        RecebendoconteudoMsg02_2 = frase10;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string display3 = this.Text + @"\FileD03.txt";
                        StreamWriter d3 = new StreamWriter(display3);
                        string frase11 = "                                                                ";
                        char[] vetChar11 = frase11.ToCharArray();
                        foreach (char letra11 in vetChar11)
                            d3.Write(letra11);
                        d3.Close();
                        RecebendoconteudoMsg03 = frase11;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string display4 = this.Text + @"\FileD04.txt";
                        StreamWriter d4 = new StreamWriter(display4);
                        string frase12 = "                                                                ";
                        char[] vetChar12 = frase12.ToCharArray();
                        foreach (char letra12 in vetChar12)
                            d4.Write(letra12);
                        d4.Close();
                        RecebendoconteudoMsg04 = frase12;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string display5 = this.Text + @"\FileD05.txt";
                        StreamWriter d5 = new StreamWriter(display5);
                        string frase13 = "                                                                ";
                        char[] vetChar13 = frase13.ToCharArray();
                        foreach (char letra13 in vetChar13)
                            d5.Write(letra13);
                        d5.Close();
                        RecebendoconteudoMsg05 = frase13;
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string display6 = this.Text + @"\FileD06.txt";
                        StreamWriter d6 = new StreamWriter(display6);
                        string frase14 = "                                                                ";
                        char[] vetChar14 = frase14.ToCharArray();
                        foreach (char letra14 in vetChar14)
                            d6.Write(letra14);
                        d6.Close();
                        RecebendoconteudoMsg06 = frase14;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string display7 = this.Text + @"\FileD07.txt";
                        StreamWriter d7 = new StreamWriter(display7);
                        string frase15 = "                                                                ";
                        char[] vetChar15 = frase15.ToCharArray();
                        foreach (char letra15 in vetChar15)
                            d7.Write(letra15);
                        d7.Close();
                        RecebendoconteudoMsg07 = frase15;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string display8 = this.Text + @"\FileD08.txt";
                        StreamWriter d8 = new StreamWriter(display8);
                        string frase16 = "                                                                ";
                        char[] vetChar16 = frase16.ToCharArray();
                        foreach (char letra16 in vetChar16)
                            d8.Write(letra16);
                        d8.Close();
                        RecebendoconteudoMsg08 = frase16;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string display00 = this.Text + @"\FileD00.txt";
                        StreamWriter d0 = new StreamWriter(display00);
                        string telazero = "Tela de Trabalho Aguardando...                                 ";
                        char[] vetChar00 = telazero.ToCharArray();
                        foreach (char letra16 in vetChar00)
                            d0.Write(letra16);
                        d0.Close();
                        RecebendoconteudoMsg00 = telazero;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo1 = this.Text + @"\FileR01.txt";
                        StreamWriter r1 = new StreamWriter(retardo1);
                        string frase17 = "Configuracao Espera   01:;0100;0999;0001;0;";
                        char[] vetChar17 = frase17.ToCharArray();
                        foreach (char letra17 in vetChar17)
                            r1.Write(letra17);
                        r1.Close();
                        RecebendoconteudoRet01 = frase17;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo2 = this.Text + @"\FileR02.txt";
                        StreamWriter r2 = new StreamWriter(retardo2);
                        string frase18 = "Configuracao Espera   02:;0100;0999;0001;0;";
                        char[] vetChar18 = frase18.ToCharArray();
                        foreach (char letra18 in vetChar18)
                            r2.Write(letra18);
                        r2.Close();
                        RecebendoconteudoRet02 = frase18;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo3 = this.Text + @"\FileR03.txt";
                        StreamWriter r3 = new StreamWriter(retardo3);
                        string frase19 = "Configuracao Espera   03:;0100;0999;0001;0;";
                        char[] vetChar19 = frase19.ToCharArray();
                        foreach (char letra19 in vetChar19)
                            r3.Write(letra19);
                        r3.Close();
                        RecebendoconteudoRet03 = frase19;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo4 = this.Text + @"\FileR04.txt";
                        StreamWriter r4 = new StreamWriter(retardo4);
                        string frase20 = "Configuracao Espera   04:;0100;0999;0001;0;";
                        char[] vetChar20 = frase20.ToCharArray();
                        foreach (char letra20 in vetChar20)
                            r4.Write(letra20);
                        r4.Close();
                        RecebendoconteudoRet04 = frase20;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo5 = this.Text + @"\FileR05.txt";
                        StreamWriter r5 = new StreamWriter(retardo5);
                        string frase21 = "Configuracao Espera   05:;0100;0999;0001;0;";
                        char[] vetChar21 = frase21.ToCharArray();
                        foreach (char letra21 in vetChar21)
                            r5.Write(letra21);
                        r5.Close();
                        RecebendoconteudoRet05 = frase21;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo6 = this.Text + @"\FileR06.txt";
                        StreamWriter r6 = new StreamWriter(retardo6);
                        string frase22 = "Configuracao Espera   06:;0100;0999;0001;0;";
                        char[] vetChar22 = frase22.ToCharArray();
                        foreach (char letra22 in vetChar22)
                            r6.Write(letra22);
                        r6.Close();
                        RecebendoconteudoRet06 = frase22;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo7 = this.Text + @"\FileR07.txt";
                        StreamWriter r7 = new StreamWriter(retardo7);
                        string frase23 = "Configuracao Espera   07:;0100;0999;0001;0;";
                        char[] vetChar23 = frase23.ToCharArray();
                        foreach (char letra23 in vetChar23)
                            r7.Write(letra23);
                        r7.Close();
                        RecebendoconteudoRet07 = frase23;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo8 = this.Text + @"\FileR08.txt";
                        StreamWriter r8 = new StreamWriter(retardo8);
                        string frase24 = "Configuracao Espera   08:;0100;0999;0001;0;";
                        char[] vetChar24 = frase24.ToCharArray();
                        foreach (char letra24 in vetChar24)
                            r8.Write(letra24);
                        r8.Close();
                        RecebendoconteudoRet08 = frase24;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo1 = this.Text + @"\FileT01.txt";
                        StreamWriter t1 = new StreamWriter(tempo1);
                        frase = "Configuracao do tempo 01:;0100;0999;0001;0;";
                        char[] vetChar25 = frase.ToCharArray();
                        foreach (char letra25 in vetChar25)
                            t1.Write(letra25);
                        t1.Close();
                        RecebendoconteudoTempo01 = frase;

                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo2 = this.Text + @"\FileT02.txt";
                        StreamWriter t2 = new StreamWriter(tempo2);
                        string frase26 = "Configuracao do tempo 02:;0100;0999;0001;0;";
                        char[] vetChar26 = frase26.ToCharArray();
                        foreach (char letra26 in vetChar26)
                            t2.Write(letra26);
                        t2.Close();
                        RecebendoconteudoTempo02 = frase26;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo3 = this.Text + @"\FileT03.txt";
                        StreamWriter t3 = new StreamWriter(tempo3);
                        string frase27 = "Configuracao do tempo 03:;0100;0999;0001;0;";
                        char[] vetChar27 = frase27.ToCharArray();
                        foreach (char letra27 in vetChar27)
                            t3.Write(letra27);
                        t3.Close();
                        RecebendoconteudoTempo03 = frase27;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo4 = this.Text + @"\FileT04.txt";
                        StreamWriter t4 = new StreamWriter(tempo4);
                        string frase28 = "Configuracao do tempo 04:;0100;0999;0001;0;";
                        char[] vetChar28 = frase28.ToCharArray();
                        foreach (char letra28 in vetChar28)
                            t4.Write(letra28);
                        t4.Close();
                        RecebendoconteudoTempo04 = frase28;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo5 = this.Text + @"\FileT05.txt";
                        StreamWriter t5 = new StreamWriter(tempo5);
                        string frase29 = "Configuracao do tempo 05:;0100;0999;0001;0;";
                        char[] vetChar29 = frase29.ToCharArray();
                        foreach (char letra29 in vetChar29)
                            t5.Write(letra29);
                        t5.Close();
                        RecebendoconteudoTempo05 = frase29;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo6 = this.Text + @"\FileT06.txt";
                        StreamWriter t6 = new StreamWriter(tempo6);
                        string frase30 = "Configuracao do tempo 06:;0100;0999;0001;0;";
                        char[] vetChar30 = frase30.ToCharArray();
                        foreach (char letra30 in vetChar30)
                            t6.Write(letra30);
                        t6.Close();
                        RecebendoconteudoTempo06 = frase30;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo7 = this.Text + @"\FileT07.txt";
                        StreamWriter t7 = new StreamWriter(tempo7);
                        string frase31 = "Configuracao do tempo 07:;0100;0999;0001;0;";
                        char[] vetChar31 = frase31.ToCharArray();
                        foreach (char letra31 in vetChar31)
                            t7.Write(letra31);
                        t7.Close();
                        RecebendoconteudoTempo07 = frase31;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo8 = this.Text + @"\FileT08.txt";
                        StreamWriter t8 = new StreamWriter(tempo8);
                        string frase32 = "Configuracao do tempo 08:;0100;0999;0001;0;";
                        char[] vetChar32 = frase32.ToCharArray();
                        foreach (char letra32 in vetChar32)
                            t8.Write(letra32);
                        t8.Close();
                        RecebendoconteudoTempo08 = frase32;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo9 = this.Text + @"\FileT09.txt";
                        StreamWriter t9 = new StreamWriter(tempo9);
                        string frase33 = "Configuracao do tempo 09:;0100;0999;0001;0;";
                        char[] vetChar33 = frase33.ToCharArray();
                        foreach (char letra33 in vetChar33)
                            t9.Write(letra33);
                        t9.Close();
                        RecebendoconteudoTempo09 = frase33;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo10 = this.Text + @"\FileT10.txt";
                        StreamWriter t10 = new StreamWriter(tempo10);
                        string frase34 = "Configuracao do tempo 10:;0100;0999;0001;0;";
                        char[] vetChar34 = frase34.ToCharArray();
                        foreach (char letra34 in vetChar34)
                            t10.Write(letra34);
                        t10.Close();
                        RecebendoconteudoTempo10 = frase34;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo11 = this.Text + @"\FileT11.txt";
                        StreamWriter t11 = new StreamWriter(tempo11);
                        string frase35 = "Configuracao do tempo 11:;0100;0999;0001;0;";
                        char[] vetChar35 = frase35.ToCharArray();
                        foreach (char letra35 in vetChar35)
                            t11.Write(letra35);
                        t11.Close();
                        RecebendoconteudoTempo11 = frase35;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo12 = this.Text + @"\FileT12.txt";
                        StreamWriter t12 = new StreamWriter(tempo12);
                        string frase36 = "Configuracao do tempo 12:;0100;0999;0001;0;";
                        char[] vetChar36 = frase36.ToCharArray();
                        foreach (char letra36 in vetChar36)
                            t12.Write(letra36);
                        t12.Close();
                        RecebendoconteudoTempo12 = frase36;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo13 = this.Text + @"\FileT13.txt";
                        StreamWriter t13 = new StreamWriter(tempo13);
                        string frase37 = "Configuracao do tempo 13:;0100;0999;0001;0;";
                        char[] vetChar37 = frase37.ToCharArray();
                        foreach (char letra37 in vetChar37)
                            t13.Write(letra37);
                        t13.Close();
                        RecebendoconteudoTempo13 = frase37;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo14 = this.Text + @"\FileT14.txt";
                        StreamWriter t14 = new StreamWriter(tempo14);
                        string frase38 = "Configuracao do tempo 14:;0100;0999;0001;0;";
                        char[] vetChar38 = frase38.ToCharArray();
                        foreach (char letra38 in vetChar38)
                            t14.Write(letra38);
                        t14.Close();
                        RecebendoconteudoTempo14 = frase38;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo15 = this.Text + @"\FileT15.txt";
                        StreamWriter t15 = new StreamWriter(tempo15);
                        string frase39 = "Configuracao do tempo 15:;0100;0999;0001;0;";
                        char[] vetChar39 = frase39.ToCharArray();
                        foreach (char letra39 in vetChar39)
                            t15.Write(letra39);
                        t15.Close();
                        RecebendoconteudoTempo15 = frase39;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo16 = this.Text + @"\FileT16.txt";
                        StreamWriter t16 = new StreamWriter(tempo16);
                        string frase40 = "Configuracao do tempo 16:;0100;0999;0001;0;";
                        char[] vetChar40 = frase40.ToCharArray();
                        foreach (char letra40 in vetChar40)
                            t16.Write(letra40);
                        t16.Close();
                        RecebendoconteudoTempo16 = frase40;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo17 = this.Text + @"\FileT17.txt";
                        StreamWriter t17 = new StreamWriter(tempo17);
                        string frase41 = "Configuracao do tempo 17:;0100;0999;0001;0;";
                        char[] vetChar41 = frase41.ToCharArray();
                        foreach (char letra41 in vetChar41)
                            t17.Write(letra41);
                        t17.Close();
                        RecebendoconteudoTempo17 = frase41;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo18 = this.Text + @"\FileT18.txt";
                        StreamWriter t18 = new StreamWriter(tempo18);
                        string frase42 = "Configuracao do tempo 18:;0100;9099;0001;0;";
                        char[] vetChar42 = frase42.ToCharArray();
                        foreach (char letra42 in vetChar42)
                            t18.Write(letra42);
                        t18.Close();
                        RecebendoconteudoTempo18 = frase42;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo19 = this.Text + @"\FileT19.txt";
                        StreamWriter t19 = new StreamWriter(tempo19);
                        string frase43 = "Configuracao do tempo 19:;0100;0999;0001;0;";
                        char[] vetChar43 = frase43.ToCharArray();
                        foreach (char letra43 in vetChar43)
                            t19.Write(letra43);
                        t19.Close();
                        RecebendoconteudoTempo19 = frase43;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo20 = this.Text + @"\FileT20.txt";
                        StreamWriter t20 = new StreamWriter(tempo20);
                        string frase44 = "Configuracao do tempo 20:;0100;0999;0001;0;";
                        char[] vetChar44 = frase44.ToCharArray();
                        foreach (char letra44 in vetChar44)
                            t20.Write(letra44);
                        t20.Close();
                        RecebendoconteudoTempo20 = frase44;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo21 = this.Text + @"\FileT21.txt";
                        StreamWriter t21 = new StreamWriter(tempo21);
                        string frase45 = "Configuracao do tempo 21:;0100;0999;0001;0;";
                        char[] vetChar45 = frase45.ToCharArray();
                        foreach (char letra45 in vetChar45)
                            t21.Write(letra45);
                        t21.Close();
                        RecebendoconteudoTempo21 = frase45;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo22 = this.Text + @"\FileT22.txt";
                        StreamWriter t22 = new StreamWriter(tempo22);
                        string frase46 = "Configuracao do tempo 22:;0100;0999;0001;0;";
                        char[] vetChar46 = frase46.ToCharArray();
                        foreach (char letra46 in vetChar46)
                            t22.Write(letra46);
                        t22.Close();
                        RecebendoconteudoTempo22 = frase46;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo23 = this.Text + @"\FileT23.txt";
                        StreamWriter t23 = new StreamWriter(tempo23);
                        string frase47 = "Configuracao do tempo 23:;0100;0999;0001;0;";
                        char[] vetChar47 = frase47.ToCharArray();
                        foreach (char letra47 in vetChar47)
                            t23.Write(letra47);
                        t23.Close();
                        RecebendoconteudoTempo23 = frase47;
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo24 = this.Text + @"\FileT24.txt";
                        StreamWriter t24 = new StreamWriter(tempo24);
                        string frase48 = "Configuracao do tempo 24:;0100;0999;0001;0;";
                        char[] vetChar48 = frase48.ToCharArray();
                        foreach (char letra48 in vetChar48)
                            t24.Write(letra48);
                        t24.Close();
                        RecebendoconteudoTempo24 = frase48;
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////              
                        string analogica1 = this.Text + @"\FileA01.txt";
                        caminhoarq = this.Text;
                        StreamWriter A01 = new StreamWriter(analogica1);
                        string frase49 = "Configuracao Analogica 01;0100;0999;0001;0;";
                        char[] vetChar49 = frase49.ToCharArray();
                        foreach (char letra3 in vetChar49)
                            A01.Write(letra3);
                        A01.Close();
                        RecebendoconteudoA01 = frase49;
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string analogica2 = this.Text + @"\FileA02.txt";
                        caminhoarq = this.Text;
                        StreamWriter A02 = new StreamWriter(analogica2);
                        string frase50 = "Configuracao Analogica 02;0100;0999;0001;0;";
                        char[] vetChar50 = frase50.ToCharArray();
                        foreach (char letra50 in vetChar50)
                            A02.Write(letra50);
                        A02.Close();
                        RecebendoconteudoA02 = frase50;
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string analogica3 = this.Text + @"\FileA03.txt";
                        caminhoarq = this.Text;
                        StreamWriter A03 = new StreamWriter(analogica3);
                        string frase51 = "Configuracao Analogica 03;0100;0999;0001;0;";
                        char[] vetChar51 = frase51.ToCharArray();
                        foreach (char letra51 in vetChar51)
                            A03.Write(letra51);
                        A03.Close();
                        RecebendoconteudoA03 = frase51;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string analogica4 = this.Text + @"\FileA04.txt";
                        caminhoarq = this.Text;
                        StreamWriter A04 = new StreamWriter(analogica4);
                        string frase52 = "Configuracao Analogica 04;0100;0999;0001;0;";
                        char[] vetChar52 = frase52.ToCharArray();
                        foreach (char letra52 in vetChar52)
                            A04.Write(letra52);
                        A04.Close();
                        RecebendoconteudoA04 = frase52;

                        string coment2 = this.Text + @"\Comentarios.txt";

                        allLines = File.ReadAllLines(coment2);

                        for (int i = 0; i < allLines.Length; i++)
                        {

                            if (allLines[i].Length < 1)
                            {
                                allLines[i] = allLines[i] + "     ";
                            }
                            if (allLines[i].Length < 2)
                            {
                                allLines[i] = allLines[i] + "    ";
                            }
                            else if (allLines[i].Length < 3)
                            {
                                allLines[i] = allLines[i] + "   ";
                            }
                            else if (allLines[i].Length < 4)
                            {
                                allLines[i] = allLines[i] + "  ";
                            }
                            else if (allLines[i].Length < 5)
                            {
                                allLines[i] = allLines[i] + " ";
                            }
                        }


                        linha0 = allLines[0];
                        linha1 = allLines[1];
                        linha2 = allLines[2];
                        linha3 = allLines[3];
                        linha4 = allLines[4];
                        linha5 = allLines[5];
                        linha6 = allLines[6];
                        linha7 = allLines[7];

                        linha8 = allLines[8];
                        linha9 = allLines[9];
                        linha10 = allLines[10];
                        linha11 = allLines[11];
                        linha12 = allLines[12];
                        linha13 = allLines[13];
                        linha14 = allLines[14];
                        linha15 = allLines[15];

                        linha16 = allLines[16];
                        linha17 = allLines[17];
                        linha18 = allLines[18];
                        linha19 = allLines[19];
                        linha20 = allLines[20];
                        linha21 = allLines[21];
                        linha22 = allLines[22];
                        linha23 = allLines[23];

                        linha24 = allLines[24];
                        linha25 = allLines[25];
                        linha26 = allLines[26];
                        linha27 = allLines[27];
                        linha28 = allLines[28];
                        linha29 = allLines[29];
                        linha30 = allLines[30];
                        linha31 = allLines[31];

                        linha32 = allLines[32];
                        linha33 = allLines[33];
                        linha34 = allLines[34];
                        linha35 = allLines[35];
                        linha36 = allLines[36];
                        linha37 = allLines[37];
                        linha38 = allLines[38];
                        linha39 = allLines[39];

                        linha40 = allLines[40];
                        linha41 = allLines[41];
                        linha42 = allLines[42];
                        linha43 = allLines[43];
                        linha44 = allLines[44];
                        linha45 = allLines[45];
                        linha46 = allLines[46];
                        linha47 = allLines[47];

                        linha48 = allLines[48];
                        linha49 = allLines[49];
                        linha50 = allLines[50];
                        linha51 = allLines[51];
                        linha52 = allLines[52];
                        linha53 = allLines[53];
                        linha54 = allLines[54];
                        linha55 = allLines[55];

                        linha56 = allLines[56];
                        linha57 = allLines[57];
                        linha58 = allLines[58];
                        linha59 = allLines[59];
                        linha60 = allLines[60];
                        linha61 = allLines[61];
                        linha62 = allLines[62];
                        linha63 = allLines[63];

                        linha64 = allLines[64];
                        linha65 = allLines[65];
                        linha66 = allLines[66];
                        linha67 = allLines[67];
                        linha68 = allLines[68];
                        linha69 = allLines[69];
                        linha70 = allLines[70];
                        linha71 = allLines[71];

                        linha72 = allLines[72];
                        linha73 = allLines[73];
                        linha74 = allLines[74];
                        linha75 = allLines[75];
                        linha76 = allLines[76];
                        linha77 = allLines[77];
                        linha78 = allLines[78];
                        linha79 = allLines[79];

                        linha80 = allLines[80];
                        linha81 = allLines[81];
                        linha82 = allLines[82];
                        linha83 = allLines[83];
                        linha84 = allLines[84];
                        linha85 = allLines[85];

                        linha86 = allLines[86];
                        linha87 = allLines[87];

                        linha88 = allLines[88];
                        linha89 = allLines[89];
                        linha90 = allLines[90];
                        linha91 = allLines[91];
                        linha92 = allLines[92];
                        linha93 = allLines[93];
                        linha94 = allLines[94];
                        linha95 = allLines[95];
                        linha96 = allLines[96];
                        linha97 = allLines[97];
                        linha98 = allLines[98];

                        linha99 = allLines[99];
                        linha100 = allLines[100];
                        linha101 = allLines[101];
                        linha102 = allLines[102];
                        linha103 = allLines[103];

                        linha104 = allLines[104];
                        linha105 = allLines[105];
                        linha106 = allLines[106];
                        linha107 = allLines[107];
                        linha108 = allLines[108];
                        linha109 = allLines[109];
                        linha110 = allLines[110];
                        linha111 = allLines[111];
                        linha112 = allLines[112];
                        linha113 = allLines[113];

                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        repassandoCaminho = caminho;

                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo01 = this.Text + @"\FileT01.txt";
                        string conteudoTempo01 = System.IO.File.ReadAllText(tempoo01);
                        RecebendoconteudoTempo01 = conteudoTempo01;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo02 = this.Text + @"\FileT02.txt";
                        string conteudoTempo02 = System.IO.File.ReadAllText(tempoo02);
                        RecebendoconteudoTempo02 = conteudoTempo02;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo03 = this.Text + @"\FileT03.txt";
                        string conteudoTempo03 = System.IO.File.ReadAllText(tempoo03);
                        RecebendoconteudoTempo03 = conteudoTempo03;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo04 = this.Text + @"\FileT04.txt";
                        string conteudoTempo04 = System.IO.File.ReadAllText(tempoo04);
                        RecebendoconteudoTempo04 = conteudoTempo04;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempo05 = this.Text + @"\FileT05.txt";
                        string conteudoTempo05 = System.IO.File.ReadAllText(tempo05);
                        RecebendoconteudoTempo05 = conteudoTempo05;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo06 = this.Text + @"\FileT06.txt";
                        string conteudoTempo06 = System.IO.File.ReadAllText(tempoo06);
                        RecebendoconteudoTempo06 = conteudoTempo06;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo07 = this.Text + @"\FileT07.txt";
                        string conteudoTempo07 = System.IO.File.ReadAllText(tempoo07);
                        RecebendoconteudoTempo07 = conteudoTempo07;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo08 = this.Text + @"\FileT08.txt";
                        string conteudoTempo08 = System.IO.File.ReadAllText(tempoo08);
                        RecebendoconteudoTempo08 = conteudoTempo08;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo09 = this.Text + @"\FileT09.txt";
                        string conteudoTempo09 = System.IO.File.ReadAllText(tempoo09);
                        RecebendoconteudoTempo09 = conteudoTempo09;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo10 = this.Text + @"\FileT10.txt";
                        string conteudoTempo10 = System.IO.File.ReadAllText(tempoo10);
                        RecebendoconteudoTempo10 = conteudoTempo10;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo11 = this.Text + @"\FileT11.txt";
                        string conteudoTempo11 = System.IO.File.ReadAllText(tempoo11);
                        RecebendoconteudoTempo11 = conteudoTempo11;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo12 = this.Text + @"\FileT12.txt";
                        string conteudoTempo12 = System.IO.File.ReadAllText(tempoo12);
                        RecebendoconteudoTempo12 = conteudoTempo12;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo13 = this.Text + @"\FileT13.txt";
                        string conteudoTempo13 = System.IO.File.ReadAllText(tempoo13);
                        RecebendoconteudoTempo13 = conteudoTempo13;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo14 = this.Text + @"\FileT14.txt";
                        string conteudoTempo14 = System.IO.File.ReadAllText(tempoo14);
                        RecebendoconteudoTempo14 = conteudoTempo14;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo15 = this.Text + @"\FileT15.txt";
                        string conteudoTempo15 = System.IO.File.ReadAllText(tempoo15);
                        RecebendoconteudoTempo15 = conteudoTempo15;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo16 = this.Text + @"\FileT16.txt";
                        string conteudoTempo16 = System.IO.File.ReadAllText(tempoo16);
                        RecebendoconteudoTempo16 = conteudoTempo16;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo17 = this.Text + @"\FileT17.txt";
                        string conteudoTempo17 = System.IO.File.ReadAllText(tempoo17);
                        RecebendoconteudoTempo17 = conteudoTempo17;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo18 = this.Text + @"\FileT18.txt";
                        string conteudoTempo18 = System.IO.File.ReadAllText(tempoo18);
                        RecebendoconteudoTempo18 = conteudoTempo18;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo19 = this.Text + @"\FileT19.txt";
                        string conteudoTempo19 = System.IO.File.ReadAllText(tempoo19);
                        RecebendoconteudoTempo19 = conteudoTempo19;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo20 = this.Text + @"\FileT20.txt";
                        string conteudoTempo20 = System.IO.File.ReadAllText(tempoo20);
                        RecebendoconteudoTempo20 = conteudoTempo20;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo21 = this.Text + @"\FileT21.txt";
                        string conteudoTempo21 = System.IO.File.ReadAllText(tempoo21);
                        RecebendoconteudoTempo21 = conteudoTempo21;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo22 = this.Text + @"\FileT22.txt";
                        string conteudoTempo22 = System.IO.File.ReadAllText(tempoo22);
                        RecebendoconteudoTempo22 = conteudoTempo22;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo23 = this.Text + @"\FileT23.txt";
                        string conteudoTempo23 = System.IO.File.ReadAllText(tempoo23);
                        RecebendoconteudoTempo23 = conteudoTempo23;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string tempoo24 = this.Text + @"\FileT24.txt";
                        string conteudoTempo24 = System.IO.File.ReadAllText(tempoo24);
                        RecebendoconteudoTempo24 = conteudoTempo24;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string contador01 = this.Text + @"\FileC01.txt";
                        string conteudoCont01 = System.IO.File.ReadAllText(contador01);
                        RecebendoconteudoCont01 = conteudoCont01;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string contador02 = this.Text + @"\FileC02.txt";
                        string conteudoCont02 = System.IO.File.ReadAllText(contador02);
                        RecebendoconteudoCont02 = conteudoCont02;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string mensagem00 = this.Text + @"\FileD00.txt";
                        string conteudoMsg00 = System.IO.File.ReadAllText(mensagem00);
                        RecebendoconteudoMsg00 = conteudoMsg00;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
                        string retardo01 = this.Text + @"\FileR01.txt";
                        string conteudoRet01 = System.IO.File.ReadAllText(retardo01);
                        RecebendoconteudoRet01 = conteudoRet01;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo02 = this.Text + @"\FileR02.txt";
                        string conteudoRet02 = System.IO.File.ReadAllText(retardo02);
                        RecebendoconteudoRet02 = conteudoRet02;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo03 = this.Text + @"\FileR03.txt";
                        string conteudoRet03 = System.IO.File.ReadAllText(retardo03);
                        RecebendoconteudoRet03 = conteudoRet03;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo04 = this.Text + @"\FileR04.txt";
                        string conteudoRet04 = System.IO.File.ReadAllText(retardo04);
                        RecebendoconteudoRet04 = conteudoRet04;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo05 = this.Text + @"\FileR05.txt";
                        string conteudoRet05 = System.IO.File.ReadAllText(retardo05);
                        RecebendoconteudoRet05 = conteudoRet05;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo06 = this.Text + @"\FileR06.txt";
                        string conteudoRet06 = System.IO.File.ReadAllText(retardo06);
                        RecebendoconteudoRet06 = conteudoRet06;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo07 = this.Text + @"\FileR07.txt";
                        string conteudoRet07 = System.IO.File.ReadAllText(retardo07);
                        RecebendoconteudoRet07 = conteudoRet07;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string retardo08 = this.Text + @"\FileR08.txt";
                        string conteudoRet08 = System.IO.File.ReadAllText(retardo08);
                        RecebendoconteudoRet08 = conteudoRet08;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string analogicaa1 = caminho + @"\FileA01.txt";
                        string conteudoAng01 = System.IO.File.ReadAllText(analogicaa1);
                        Form1.RecebendoconteudoA01 = conteudoAng01;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string analogicaa2 = caminho + @"\FileA02.txt";
                        string conteudoAng02 = System.IO.File.ReadAllText(analogicaa2);
                        Form1.RecebendoconteudoA02 = conteudoAng02;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string analogicaa3 = caminho + @"\FileA03.txt";
                        string conteudoAng03 = System.IO.File.ReadAllText(analogicaa3);
                        Form1.RecebendoconteudoA03 = conteudoAng03;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string analogicaa4 = caminho + @"\FileA04.txt";
                        string conteudoAng04 = System.IO.File.ReadAllText(analogicaa4);
                        Form1.RecebendoconteudoA04 = conteudoAng04;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string habiltarFuncao = caminho + @"\FileB01.txt";
                        string conteudoHab00 = System.IO.File.ReadAllText(habiltarFuncao);
                        Form1.RecebendoconteudoADJ00 = conteudoHab00;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string habiltarFuncao2 = caminho + @"\FileB02.txt";
                        string conteudoHab01 = System.IO.File.ReadAllText(habiltarFuncao2);
                        Form1.RecebendoconteudoADJ01 = conteudoHab01;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string Bimanual1 = caminho + @"\FileBM1.txt";
                        string conteudoBim1 = System.IO.File.ReadAllText(Bimanual1);
                        RecebendoconteudoBM1 = conteudoBim1;
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        string Bimanual2 = caminho + @"\FileBM2.txt";
                        string conteudoBim2 = System.IO.File.ReadAllText(Bimanual2);
                        RecebendoconteudoBM2 = conteudoBim2;
                    }
                }
                gb_tabela.Visible = true;
            }
        }
        /// <BLOCO CODIGO SALVAR ANTES DE FECHAR>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arquivo == null)
            {
                
            }
            else
            {
                if(salvar == 1)
                {
                    string mensagem = "           Fechando PROGCLP96";
                    string titulo = " ";
                    MessageBoxButtons botao = MessageBoxButtons.OKCancel;
                    DialogResult resultado2;
                    resultado2 = MessageBox.Show(mensagem, titulo, botao);
                    if (resultado2 == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    MessageBoxIcon icone5 = MessageBoxIcon.Question;
                    string mensagem5 = "Salvar alterações?";
                    string titulo5 = "Salvar";
                    MessageBoxButtons botao5 = MessageBoxButtons.YesNoCancel;
                    DialogResult resultado;
                    resultado = MessageBox.Show(mensagem5, titulo5, botao5, icone5);

                    SaveFileDialog caminhoSalvo = new SaveFileDialog();
                    caminhoSalvo.FileName = arquivo;

                    if (resultado == DialogResult.Yes)
                    {

                        int indice = 0;

                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 17; j++)
                            {
                                vetor[indice] = (byte)mat[i, j];
                                indice++;
                            }
                        }

                        using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.Write))
                        {
                            fs4.Write(vetor, 0, vetor.Length);
                        }

                        MessageBoxIcon icone4 = MessageBoxIcon.Information;
                        string mensagem4 = "Projeto salvo com sucesso";
                        string titulo4 = "Salvar";
                        MessageBoxButtons botao4 = MessageBoxButtons.OK;
                        MessageBox.Show(mensagem4, titulo4, botao4, icone4);
                        btn_novo.Visible = true;
                    }
                    else if (resultado == DialogResult.No)
                    {

                    }
                    if (resultado == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
                
            }
        }

        /// <sBloco de codigo atalhos usando as teclasummary>/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.J)
            {
                ENTRADA_NA formNA = new ENTRADA_NA();
                formNA.TopLevel = true;
                formNA.Visible = true;
                formNA.StartPosition = FormStartPosition.Manual;
                formNA.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.K)
            {
                ENTRADA_NF janelaNF = new ENTRADA_NF();
                janelaNF.TopLevel = true;
                janelaNF.Visible = true;
                janelaNF.StartPosition = FormStartPosition.Manual;
                janelaNF.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.N)
            {
                BORDA_DESCIDA janelaBorda = new BORDA_DESCIDA();
                janelaBorda.TopLevel = true;
                janelaBorda.Visible = true;
                janelaBorda.StartPosition = FormStartPosition.Manual;
                janelaBorda.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.P)
            {
                BORDA_SUBIDA janelaBS = new BORDA_SUBIDA();
                janelaBS.TopLevel = true;
                janelaBS.Visible = true;
                janelaBS.StartPosition = FormStartPosition.Manual;
                janelaBS.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.W)
            {
                SAIDA_NA janelaJNA = new SAIDA_NA();
                janelaJNA.TopLevel = true;
                janelaJNA.Visible = true;
                janelaJNA.StartPosition = FormStartPosition.Manual;
                janelaJNA.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.X)
            {
                SAIDA_NF janelaJNF = new SAIDA_NF();
                janelaJNF.TopLevel = true;
                janelaJNF.Visible = true;
                janelaJNF.StartPosition = FormStartPosition.Manual;
                janelaJNF.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.S)
            {
                SAIDA_SET janelaSset = new SAIDA_SET();
                janelaSset.TopLevel = true;
                janelaSset.Visible = true;
                janelaSset.StartPosition = FormStartPosition.Manual;
                janelaSset.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.R)
            {
                SAIDA_RESET janelaSRE = new SAIDA_RESET();
                janelaSRE.TopLevel = true;
                janelaSRE.Visible = true;
                janelaSRE.StartPosition = FormStartPosition.Manual;
                janelaSRE.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.C)
            {
                CONTADOR ctn = new CONTADOR();
                ctn.TopLevel = true;
                ctn.Visible = true;
                ctn.StartPosition = FormStartPosition.Manual;
                ctn.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.E)
            {
                ESPERA and = new ESPERA();
                and.TopLevel = true;
                and.Visible = true;
                and.StartPosition = FormStartPosition.Manual;
                and.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.A)
            {
                AUXILIAR_ANALOGICA janelaAUX = new AUXILIAR_ANALOGICA();
                janelaAUX.TopLevel = true;
                janelaAUX.Visible = true;
                janelaAUX.StartPosition = FormStartPosition.Manual;
                janelaAUX.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.B)
            {
                Bimanual bimanual = new Bimanual();
                bimanual.TopLevel = true;
                bimanual.Visible = true;
                bimanual.StartPosition = FormStartPosition.Manual;
                bimanual.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.D)
            {
                DISPLAY display = new DISPLAY();
                display.TopLevel = true;
                display.Visible = true;
                display.StartPosition = FormStartPosition.Manual;
                display.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.H)
            {
                Habilitar_Funcoes bit = new Habilitar_Funcoes();
                bit.TopLevel = true;
                bit.Visible = true;
                bit.StartPosition = FormStartPosition.Manual;
                bit.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.M)
            {
                CONTATO_AUXILIAR contAux = new CONTATO_AUXILIAR();
                contAux.TopLevel = true;
                contAux.Visible = true;
                contAux.StartPosition = FormStartPosition.Manual;
                contAux.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.T)
            {
                Temporizador tempo = new Temporizador();
                tempo.TopLevel = true;
                tempo.Visible = true;
                tempo.StartPosition = FormStartPosition.Manual;
                tempo.Location = new Point(866, 78);
                valor = click_selecionar[1];
            }
            if (e.KeyCode == Keys.Escape)
            {
                button22.Cursor = Cursors.Arrow;
                click_selecionar[1] = 0;
                btn_aux.BackgroundImage = Properties.Resources.linha_grande;
                button22.BackgroundImage = Properties.Resources.linha_grande;

                s01 = 0;
                s02 = 0;
                s03 = 0;
                s04 = 0;
                s05 = 0;
                s06 = 0;
                s07 = 0;
                s08 = 0;

                btn_FContinuo.BackColor = Color.Azure;
                btn_OR.BackColor = Color.Azure;
                btn_FDelete.BackColor = Color.Azure;
                btn_entradaNA.BackColor = Color.Azure;
                btn_entradaNF.BackColor = Color.Azure;
                btn_BordaDescida.BackColor = Color.Azure;
                btn_BordaSubida.BackColor = Color.Azure;
                button115.BackColor = Color.Azure;
                btn_saidaNF.BackColor = Color.Azure;
                btn_saidaSet.BackColor = Color.Azure;
                btn_saidaReset.BackColor = Color.Azure;
                btn_Aux_Analogicas.BackColor = Color.Azure;
                btn_Aux_Contador.BackColor = Color.Azure;
                btn_espera.BackColor = Color.Azure;
                btn_Aux_Temporizador.BackColor = Color.Azure;
                btn_display.BackColor = Color.Azure;
                btn_aux_Contato_Aux.BackColor = Color.Azure;

            }
            if (e.KeyCode == Keys.Delete)
            {
                apagar = 1;
            }
            if (e.KeyCode == Keys.Insert)
            {
                inserir = 1;
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Delete)
            {
                click_selecionar[1] = 0;
                button22.BackgroundImage = Properties.Resources.linhas_gridview;
                img = Properties.Resources.linhas_gridview;
                Form form4 = Application.OpenForms["Form1"];
                ((Button)form4.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_del.Handle);
                Form form = Application.OpenForms["Form1"];
                ((Button)form.Controls["button22"]).BackgroundImage = img;
                ((Button)form4.Controls["button22"]).Text = null;

                valor = click_selecionar[1];

                btn_FContinuo.BackColor = Color.Azure;
                btn_OR.BackColor = Color.Azure;
                btn_FDelete.BackColor = Color.LightGray;
                btn_entradaNA.BackColor = Color.Azure;
                btn_entradaNF.BackColor = Color.Azure;
                btn_BordaDescida.BackColor = Color.Azure;
                btn_BordaSubida.BackColor = Color.Azure;
                button115.BackColor = Color.Azure;
                btn_saidaNF.BackColor = Color.Azure;
                btn_saidaSet.BackColor = Color.Azure;
                btn_saidaReset.BackColor = Color.Azure;
                btn_Aux_Analogicas.BackColor = Color.Azure;
                btn_Aux_Contador.BackColor = Color.Azure;
                btn_espera.BackColor = Color.Azure;
                btn_Aux_Temporizador.BackColor = Color.Azure;
                btn_display.BackColor = Color.Azure;
                btn_aux_Contato_Aux.BackColor = Color.Azure;
            }
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Insert)
            {
                img = Properties.Resources.CONTINUO;
                click_selecionar[1] = 1;
                Form form = Application.OpenForms["Form1"];
                ((Button)form.Controls["button22"]).BackgroundImage = img;
                Form form9 = Application.OpenForms["Form1"];
                ((Button)form9.Controls["button22"]).Cursor = new Cursor(Properties.Resources.icone_continuo.Handle);

                btn_FContinuo.BackColor = Color.LightGray;
                btn_OR.BackColor = Color.Azure;
                btn_FDelete.BackColor = Color.Azure;
                btn_entradaNA.BackColor = Color.Azure;
                btn_entradaNF.BackColor = Color.Azure;
                btn_BordaDescida.BackColor = Color.Azure;
                btn_BordaSubida.BackColor = Color.Azure;
                button115.BackColor = Color.Azure;
                btn_saidaNF.BackColor = Color.Azure;
                btn_saidaSet.BackColor = Color.Azure;
                btn_saidaReset.BackColor = Color.Azure;
                btn_Aux_Analogicas.BackColor = Color.Azure;
                btn_Aux_Contador.BackColor = Color.Azure;
                btn_espera.BackColor = Color.Azure;
                btn_Aux_Temporizador.BackColor = Color.Azure;
                btn_display.BackColor = Color.Azure;
                btn_aux_Contato_Aux.BackColor = Color.Azure;
            }
        }

        private void btn_Aux_Temporizador_Click(object sender, EventArgs e)
        {
            Temporizador temporizador = new Temporizador();          
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            temporizador.ShowDialog();
  
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.LightGray;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }

        private void btn_Aux_Contador_Click(object sender, EventArgs e)
        {
            CONTADOR contador = new CONTADOR();           
            caminhoarq = this.Text;
            contador.ShowDialog();
           
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.LightGray;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            DISPLAY display = new DISPLAY();           
            caminhoarq = this.Text;
            display.ShowDialog();
           
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.LightGray;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }
        private void btn_espera_Click(object sender, EventArgs e)
        {
            ESPERA espera = new ESPERA();           
            caminhoarq = this.Text;
            espera.ShowDialog();
            
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.LightGray;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }

        private void btn_bimanual_Click(object sender, EventArgs e)
        {
            Bimanual bimanual = new Bimanual();                  
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            bimanual.ShowDialog();
           
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.LightGray;
            btn_habilitar.BackColor = Color.Azure;
        }

        private void btn_aux_Contato_Aux_Click(object sender, EventArgs e)
        {
            CONTATO_AUXILIAR contato_aux = new CONTATO_AUXILIAR();                    
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            contato_aux.ShowDialog();
            

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.LightGray;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.Azure;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                apagar = 0;
            }
            if (e.KeyCode == Keys.Insert)
            {
                inserir = 0;
            }
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            Habilitar_Funcoes habilitar_fun = new Habilitar_Funcoes();         
            valor = click_selecionar[1];
            caminhoarq = this.Text;
            habilitar_fun.ShowDialog();
          
            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;
            btn_bimanual.BackColor = Color.Azure;
            btn_habilitar.BackColor = Color.LightGray;
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre_PROGCP96 sobre = new Sobre_PROGCP96();
            sobre.TopLevel = true;
            sobre.Visible = true;
            sobre.StartPosition = FormStartPosition.Manual;
            sobre.Location = new Point(866, 78);
        }

        private void exibirAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.TopLevel = true;
            ajuda.Visible = true;
            ajuda.StartPosition = FormStartPosition.CenterScreen;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar = 1;
            int indice = 0;
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    vetor[indice] = (byte)mat[i, j];
                    indice++;
                }
            }

            using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.Write))
            {
                fs4.Write(vetor, 0, vetor.Length);
                if (btn_transfer_Clicado == 0)
                {
                    MessageBoxIcon icone4 = MessageBoxIcon.Information;
                    string mensagem4 = "Projeto salvo com sucesso";
                    string titulo4 = "Salvar";
                    MessageBoxButtons botao4 = MessageBoxButtons.OK;
                    MessageBox.Show(mensagem4, titulo4, botao4, icone4);
                }
                else { }
            }
        }

        private void compilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    if (j == 0)
                    {
                        MAT_MAIOR[i, j] = 1;
                    }
                    else
                    {
                        MAT_MAIOR[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < 250; i++)
            {

                coluna = 0;
                for (int j = 1; j < 18; j++)
                {
                    MAT_MAIOR[i, j] = mat[i, coluna];
                    coluna++;
                }
            }

            int indice = 0;
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    newVetor[indice] = (byte)MAT_MAIOR[i, j];
                    indice++;
                }
            }
            try
            {
                // Gera o arquivo FileLad.bin(para gravação)
                using (var fs = new FileStream(this.Text + @"\FileLad.bin", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(newVetor, 0, newVetor.Length);

                    groupBox13.Visible = true;
                    groupBox12.Visible = true;

                    salvar = 1;
                    caminhoarq = this.Text;
                }
                if (btn_transfer_Clicado == 0)
                {
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    string mensagem = "Compilado com sucesso!";
                    string titulo = "Compilado";
                    DialogResult resultado;
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    resultado = MessageBox.Show(mensagem, titulo, botao, icone);

                    if (resultado == DialogResult.OK)
                    {
                        btn_simulacao.Visible = true;
                        btn_transferir.Visible = true;
                    }
                }
                else
                {

                }
                salvar = 1;
                int indice2 = 0;
                for (int i = 0; i < 250; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        vetor[indice2] = (byte)mat[i, j];
                        indice2++;
                    }
                }

                using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.Write))
                {
                    fs4.Write(vetor, 0, vetor.Length);                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //Mensagem de erro ao compilar
                MessageBoxIcon icone2 = MessageBoxIcon.Error;
                string mensagem2 = "Não foi possível compilar";
                string titulo2 = "Erro!";
                MessageBoxButtons botao2 = MessageBoxButtons.OK;
                MessageBox.Show(mensagem2, titulo2, botao2, icone2);
            }
        }

        private void fecharProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_fechar_clicado = 1;
            salvar = 0;
            this.Close();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            btn_fechar_clicado = 1;
            salvar = 0;
            this.Close();               
        }

   
 
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {        
            int linha = ((DataGridView)sender).CurrentCell.RowIndex;
            int coluna = ((DataGridView)sender).CurrentCell.ColumnIndex;
       
            linha_dg = ((DataGridView)sender).CurrentCell.RowIndex;
            coluna_dg = ((DataGridView)sender).CurrentCell.ColumnIndex;
            
            salvar = 0;

            linha_or = linha;
            coluna_or = coluna;

            if (click_selecionar[1] != 0 && mat[linha, coluna] != botao_invisivel)
            {               
                btn_simulacao.Visible = false;
               
                if (click_selecionar[1] != or)
                {
                     if (e.ColumnIndex % 2 == 0)
                     {
                        ((DataGridView)sender).CurrentCell.Value = button22.BackgroundImage;
                        ((DataGridView)sender).CurrentCell.ToolTipText = tooltip;
                                            
                         RecebeContato(click_selecionar[1], sender);  
                         
                         if (e.ColumnIndex == dataGridView1.Columns["C16"].Index)
                         {                           
                            if (click_selecionar[1] != 0)
                            {
                                Saidas(sender, e);
                                ((DataGridView)sender).CurrentCell.Value = button22.BackgroundImage;
                               
                                if (completar == 0)
                                {                                    
                                    ProibirEntradasNaSaidas_valor(sender, e);
                                    ProibirEntradasNaSaidas_valor(sender, e);
                                    Completar(sender, e);
                                   
                                    ((DataGridView)sender).CurrentCell.ToolTipText = tooltip;
                                }
                                else { }                             
                            }
                         }

                         else
                         {                          
                            Saidas(sender, e);
                            ((DataGridView)sender).CurrentCell.Value = button22.BackgroundImage;
                         }
                     }
                }
                if (click_selecionar[1] == or)
                {
                    if (mat[linha, coluna] == botao_invisivel)
                    {

                    }
                    else
                    {
                        if (e.ColumnIndex % 2 != 0)
                        {
                            Funcao_Or_valor(sender, e);                         
                        }
                    }
                }               
                if (click_selecionar[1] == and)
                {
                    if (e.ColumnIndex % 2 != 0)
                    {
                        FuncaoAnd_Valor(sender, e);
                        FuncaoAnd_Imagem(sender, e);
                        RecebeContato(click_selecionar[1], sender);
                        ((DataGridView)sender).CurrentCell.Value = button22.BackgroundImage;
                    }
                }              
                if (click_selecionar[1] == 0)
                {
                    int l = ((DataGridView)sender).CurrentCell.RowIndex;
                    int c = ((DataGridView)sender).CurrentCell.ColumnIndex;

                    if (mat[l, c] != 0)
                    {
                        excluir_invisivel(sender, e);               
                    }
                    ((DataGridView)sender).CurrentCell.Value = button22.BackgroundImage;
                    RecebeContato(click_selecionar[1], sender);
                    ((DataGridView)sender).CurrentCell.ToolTipText = string.Empty;
                }
            }     
        }
        
        private void button1_Move(object sender, MouseEventArgs e)
        {         
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                gb_tabela.Location = new Point(Control.MousePosition.X -1 , Control.MousePosition.Y - 50);                        
            }             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gb_tabela.Location = new Point(13, 176);
            button1.Location = new Point(4, 16);
            button2.Visible = false;
         
        }

        private void dataGridView1_CellMouseMove_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Mostrarcursor(sender, e);
            int cell_linha = e.RowIndex;
            int cell_coluna = e.ColumnIndex;

            if (e.RowIndex < 0 || e.ColumnIndex < 0 )
            {
              
            }
            else
            {
                if(mat[e.RowIndex, e.ColumnIndex] == 250)
                {
                    apagar = 0;
                    inserir = 0;
                }   
                
                if (apagar == 1)
                {
                    if (mat[cell_linha, cell_coluna] == 201 || mat[cell_linha, cell_coluna] == 202)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = cell_coluna; j < dataGridView1.Columns.Count; j++)
                            {
                                dataGridView1.Rows[cell_linha].Cells[cell_coluna].Value = Properties.Resources.linhas_gridview;
                                mat[cell_linha, cell_coluna] = 0;
                                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = string.Empty;
                                cell_coluna++;
                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.linhas_gridview;
                        mat[e.RowIndex, e.ColumnIndex] = 0;
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = string.Empty;
                    }
                }

                else
                {
                   if (inserir == 1)
                   {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.CONTINUO;
                        mat[e.RowIndex, e.ColumnIndex] = 1;
                   }
                }                                 
            }
            
            dataGridView1.Cursor = new Cursor(button22.Cursor.Handle);
            this.Cursor = new Cursor(button22.Cursor.Handle);
        }
        
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {           
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(click_selecionar[1].ToString());
        }
        
        private void btn_simulacao_Click(object sender, EventArgs e)
        {
            //EQUIVALENTE AO ESC
            
            button22.Cursor = Cursors.Arrow;
            click_selecionar[1] = 0;
            btn_aux.BackgroundImage = Properties.Resources.linha_grande;
            button22.BackgroundImage = Properties.Resources.linha_grande;
            
            s01 = 0;
            s02 = 0;
            s03 = 0;
            s04 = 0;
            s05 = 0;
            s06 = 0;
            s07 = 0;
            s08 = 0;

            btn_FContinuo.BackColor = Color.Azure;
            btn_OR.BackColor = Color.Azure;
            btn_FDelete.BackColor = Color.Azure;
            btn_entradaNA.BackColor = Color.Azure;
            btn_entradaNF.BackColor = Color.Azure;
            btn_BordaDescida.BackColor = Color.Azure;
            btn_BordaSubida.BackColor = Color.Azure;
            button115.BackColor = Color.Azure;
            btn_saidaNF.BackColor = Color.Azure;
            btn_saidaSet.BackColor = Color.Azure;
            btn_saidaReset.BackColor = Color.Azure;
            btn_Aux_Analogicas.BackColor = Color.Azure;
            btn_Aux_Contador.BackColor = Color.Azure;
            btn_espera.BackColor = Color.Azure;
            btn_Aux_Temporizador.BackColor = Color.Azure;
            btn_display.BackColor = Color.Azure;
            btn_aux_Contato_Aux.BackColor = Color.Azure;

            SIMULACAO form_simulacao = new SIMULACAO(this);
            caminhoarq = this.Text;
            valor = click_selecionar[1];
            form_simulacao.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btn_fechar_clicado == 1)
            {
                Application.Restart();
            }
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {

            var usbDevices = GetUSBDevices();
            
            // copiar e colar usando prompt de comando  * nao acessava pastas com restriçao de administrador
            /*// MessageBox.Show(cont.ToString());
             ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
             processStartInfo.RedirectStandardInput = true;
             processStartInfo.RedirectStandardOutput = true;
             processStartInfo.UseShellExecute = false;
             processStartInfo.WindowStyle = ProcessWindowStyle.Minimized;
             Process process = Process.Start(processStartInfo);
             string robocopy = "Robocopy ";
             string projeto = " " + caminho;
             string pendrive = " " + USB;
             string comando = robocopy + projeto + pendrive;
             process.StandardInput.WriteLine(comando);
             process.StandardInput.WriteLine(@"exit");
             process.StandardInput.WriteLine(@"exit");*/
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_fechar_clicado = 1;
            salvar = 0;
            this.Close();
        }

        private void transferirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usbDevices = GetUSBDevices();
        }

        private void ts_novaLinha_Click(object sender, EventArgs e)
        {
            // copia matriz principal para matriz temporaria a partir da linha selecionada

            LT = 0;

            for (int L = Linha; L < 250; L++)
            {
                for (int C = 0; C < 17; C++)
                {
                    matriz_temp[LT, C] = mat[L, C];
                }
                if (LT < 250) LT++;
            }

            // ZERA LINHA SELECIONADA

            for (int C = 0; C < 17; C++)
            {
                mat[Linha, C] = 0;
            }

            // copia matriz temporaria (somente valores apartira da linha selecionada) de volta para matriz principal deslocando 1 linha

            LT = 0;

            for (int L = Linha + 1; L < 250; L++)
            {
                for (int C = 0; C < 17; C++)
                {
                    mat[L, C] = matriz_temp[LT, C];
                }
                if (LT < 250) LT++;
            }

            int indice = 0;
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    vetor[indice] = (byte)mat[i, j];
                    indice++;
                }
            }

            using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.Write))
            {
                fs4.Write(vetor, 0, vetor.Length);
            }
            
            FileInfo fileInfo = new FileInfo(arquivo);
            caminho = fileInfo.DirectoryName;
            this.Text = caminho;
            caminhoAntigo = this.Text;
            btn_salvar.Visible = true;
            btn_fechar.Visible = true;
            btn_novo.Visible = false;

            string coment = this.Text + @"\Comentarios.txt";

            allLines = File.ReadAllLines(coment);

            for (int i = 0; i < allLines.Length; i++)
            {
                if (allLines[i].Length < 1)
                {
                    allLines[i] = allLines[i] + "        ";
                }
                if (allLines[i].Length < 2)
                {
                    allLines[i] = allLines[i] + "       ";
                }
                else if (allLines[i].Length < 3)
                {
                    allLines[i] = allLines[i] + "      ";
                }
                else if (allLines[i].Length < 4)
                {
                    allLines[i] = allLines[i] + "     ";
                }
                else if (allLines[i].Length < 5)
                {
                    allLines[i] = allLines[i] + "    ";
                }
                else if (allLines[i].Length < 6)
                {
                    allLines[i] = allLines[i] + "   ";
                }
                else if (allLines[i].Length < 7)
                {
                    allLines[i] = allLines[i] + "  ";
                }
                else if (allLines[i].Length < 8)
                {
                    allLines[i] = allLines[i] + " ";
                }
            }


            linha0 = allLines[0];
            linha1 = allLines[1];
            linha2 = allLines[2];
            linha3 = allLines[3];
            linha4 = allLines[4];
            linha5 = allLines[5];
            linha6 = allLines[6];
            linha7 = allLines[7];

            linha8 = allLines[8];
            linha9 = allLines[9];
            linha10 = allLines[10];
            linha11 = allLines[11];
            linha12 = allLines[12];
            linha13 = allLines[13];
            linha14 = allLines[14];
            linha15 = allLines[15];

            linha16 = allLines[16];
            linha17 = allLines[17];
            linha18 = allLines[18];
            linha19 = allLines[19];
            linha20 = allLines[20];
            linha21 = allLines[21];
            linha22 = allLines[22];
            linha23 = allLines[23];

            linha24 = allLines[24];
            linha25 = allLines[25];
            linha26 = allLines[26];
            linha27 = allLines[27];
            linha28 = allLines[28];
            linha29 = allLines[29];
            linha30 = allLines[30];
            linha31 = allLines[31];

            linha32 = allLines[32];
            linha33 = allLines[33];
            linha34 = allLines[34];
            linha35 = allLines[35];
            linha36 = allLines[36];
            linha37 = allLines[37];
            linha38 = allLines[38];
            linha39 = allLines[39];

            linha40 = allLines[40];
            linha41 = allLines[41];
            linha42 = allLines[42];
            linha43 = allLines[43];
            linha44 = allLines[44];
            linha45 = allLines[45];
            linha46 = allLines[46];
            linha47 = allLines[47];

            linha48 = allLines[48];
            linha49 = allLines[49];
            linha50 = allLines[50];
            linha51 = allLines[51];
            linha52 = allLines[52];
            linha53 = allLines[53];
            linha54 = allLines[54];
            linha55 = allLines[55];

            linha56 = allLines[56];
            linha57 = allLines[57];
            linha58 = allLines[58];
            linha59 = allLines[59];
            linha60 = allLines[60];
            linha61 = allLines[61];
            linha62 = allLines[62];
            linha63 = allLines[63];

            linha64 = allLines[64];
            linha65 = allLines[65];
            linha66 = allLines[66];
            linha67 = allLines[67];
            linha68 = allLines[68];
            linha69 = allLines[69];
            linha70 = allLines[70];
            linha71 = allLines[71];

            linha72 = allLines[72];
            linha73 = allLines[73];
            linha74 = allLines[74];
            linha75 = allLines[75];
            linha76 = allLines[76];
            linha77 = allLines[77];
            linha78 = allLines[78];
            linha79 = allLines[79];

            linha80 = allLines[80];
            linha81 = allLines[81];
            linha82 = allLines[82];
            linha83 = allLines[83];
            linha84 = allLines[84];
            linha85 = allLines[85];

            linha86 = allLines[86];
            linha87 = allLines[87];

            linha88 = allLines[88];
            linha89 = allLines[89];
            linha90 = allLines[90];
            linha91 = allLines[91];
            linha92 = allLines[92];
            linha93 = allLines[93];
            linha94 = allLines[94];
            linha95 = allLines[95];
            linha96 = allLines[96];
            linha97 = allLines[97];
            linha98 = allLines[98];

            linha99 = allLines[99];
            linha100 = allLines[100];
            linha101 = allLines[101];
            linha102 = allLines[102];
            linha103 = allLines[103];

            linha104 = allLines[104];
            linha105 = allLines[105];
            linha106 = allLines[106];
            linha107 = allLines[107];
            linha108 = allLines[108];
            linha109 = allLines[109];
            linha110 = allLines[110];
            linha111 = allLines[111];
            linha112 = allLines[112];
            linha113 = allLines[113];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string text0 = linha0.Substring(0, 8);
            string text1 = linha1.Substring(0, 8);
            string text2 = linha2.Substring(0, 8);
            string text3 = linha3.Substring(0, 8);
            string text4 = linha4.Substring(0, 8);
            string text5 = linha5.Substring(0, 8);
            string text6 = linha6.Substring(0, 8);
            string text7 = linha7.Substring(0, 8);

            string text8 = linha8.Substring(0, 8);
            string text9 = linha9.Substring(0, 8);
            string text10 = linha10.Substring(0, 8);
            string text11 = linha11.Substring(0, 8);
            string text12 = linha12.Substring(0, 8);
            string text13 = linha13.Substring(0, 8);
            string text14 = linha14.Substring(0, 8);
            string text15 = linha15.Substring(0, 8);

            string text16 = linha16.Substring(0, 8);
            string text17 = linha17.Substring(0, 8);
            string text18 = linha18.Substring(0, 8);
            string text19 = linha19.Substring(0, 8);
            string text20 = linha20.Substring(0, 8);
            string text21 = linha21.Substring(0, 8);
            string text22 = linha22.Substring(0, 8);
            string text23 = linha23.Substring(0, 8);

            string text24 = linha24.Substring(0, 8);
            string text25 = linha25.Substring(0, 8);
            string text26 = linha26.Substring(0, 8);
            string text27 = linha27.Substring(0, 8);
            string text28 = linha28.Substring(0, 8);
            string text29 = linha29.Substring(0, 8);
            string text30 = linha30.Substring(0, 8);
            string text31 = linha31.Substring(0, 8);

            string text32 = linha32.Substring(0, 8);
            string text33 = linha33.Substring(0, 8);
            string text34 = linha34.Substring(0, 8);
            string text35 = linha35.Substring(0, 8);
            string text36 = linha36.Substring(0, 8);
            string text37 = linha37.Substring(0, 8);
            string text38 = linha38.Substring(0, 8);
            string text39 = linha39.Substring(0, 8);

            string text40 = linha40.Substring(0, 8);
            string text41 = linha41.Substring(0, 8);
            string text42 = linha42.Substring(0, 8);
            string text43 = linha43.Substring(0, 8);
            string text44 = linha44.Substring(0, 8);
            string text45 = linha45.Substring(0, 8);
            string text46 = linha46.Substring(0, 8);
            string text47 = linha47.Substring(0, 8);

            string text48 = linha48.Substring(0, 8);
            string text49 = linha49.Substring(0, 8);
            string text50 = linha50.Substring(0, 8);
            string text51 = linha51.Substring(0, 8);
            string text52 = linha52.Substring(0, 8);
            string text53 = linha53.Substring(0, 8);
            string text54 = linha54.Substring(0, 8);
            string text55 = linha55.Substring(0, 8);

            string text56 = linha56.Substring(0, 8);
            string text57 = linha57.Substring(0, 8);
            string text58 = linha58.Substring(0, 8);
            string text59 = linha59.Substring(0, 8);
            string text60 = linha60.Substring(0, 8);
            string text61 = linha61.Substring(0, 8);
            string text62 = linha62.Substring(0, 8);
            string text63 = linha63.Substring(0, 8);

            string text64 = linha64.Substring(0, 8);
            string text65 = linha65.Substring(0, 8);
            string text66 = linha66.Substring(0, 8);
            string text67 = linha67.Substring(0, 8);
            string text68 = linha68.Substring(0, 8);
            string text69 = linha69.Substring(0, 8);
            string text70 = linha70.Substring(0, 8);
            string text71 = linha71.Substring(0, 8);

            string text72 = linha72.Substring(0, 8);
            string text73 = linha73.Substring(0, 8);
            string text74 = linha74.Substring(0, 8);
            string text75 = linha75.Substring(0, 8);
            string text76 = linha76.Substring(0, 8);
            string text77 = linha77.Substring(0, 8);
            string text78 = linha78.Substring(0, 8);
            string text79 = linha79.Substring(0, 8);

            string text80 = linha80.Substring(0, 8);
            string text81 = linha81.Substring(0, 8);
            string text82 = linha82.Substring(0, 8);
            string text83 = linha83.Substring(0, 8);
            string text84 = linha84.Substring(0, 8);
            string text85 = linha85.Substring(0, 8);

            string text86 = linha86.Substring(0, 8);
            string text87 = linha87.Substring(0, 8);
            string text88 = linha87.Substring(0, 8);

            string text89 = linha88.Substring(0, 8);
            string text90 = linha89.Substring(0, 8);
            string text91 = linha91.Substring(0, 8);
            string text92 = linha92.Substring(0, 8);
            string text93 = linha93.Substring(0, 8);
            string text94 = linha94.Substring(0, 8);
            string text95 = linha95.Substring(0, 8);
            string text96 = linha96.Substring(0, 8);
            string text97 = linha97.Substring(0, 8);
            string text98 = linha98.Substring(0, 8);

            string text99 = linha99.Substring(0, 8);
            string text100 = linha100.Substring(0, 8);
            string text101 = linha101.Substring(0, 8);
            string text102 = linha102.Substring(0, 8);
            string text103 = linha103.Substring(0, 8);

            string text104 = linha104.Substring(0, 8);
            string text105 = linha105.Substring(0, 8);
            string text106 = linha106.Substring(0, 8);
            string text107 = linha107.Substring(0, 8);
            string text108 = linha108.Substring(0, 8);
            string text109 = linha109.Substring(0, 8);
            string text110 = linha110.Substring(0, 8);
            string text111 = linha111.Substring(0, 8);
            string text112 = linha112.Substring(0, 8);
            string text113 = linha113.Substring(0, 8);

            repassandoCaminho = caminho;

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo01 = this.Text + @"\FileT01.txt";
            string conteudoTempo01 = System.IO.File.ReadAllText(tempo01);
            RecebendoconteudoTempo01 = conteudoTempo01;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo02 = this.Text + @"\FileT02.txt";
            string conteudoTempo02 = System.IO.File.ReadAllText(tempo02);
            RecebendoconteudoTempo02 = conteudoTempo02;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo03 = this.Text + @"\FileT03.txt";
            string conteudoTempo03 = System.IO.File.ReadAllText(tempo03);
            RecebendoconteudoTempo03 = conteudoTempo03;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo04 = this.Text + @"\FileT04.txt";
            string conteudoTempo04 = System.IO.File.ReadAllText(tempo04);
            RecebendoconteudoTempo04 = conteudoTempo04;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo05 = this.Text + @"\FileT05.txt";
            string conteudoTempo05 = System.IO.File.ReadAllText(tempo05);
            RecebendoconteudoTempo05 = conteudoTempo05;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo06 = this.Text + @"\FileT06.txt";
            string conteudoTempo06 = System.IO.File.ReadAllText(tempo06);
            RecebendoconteudoTempo06 = conteudoTempo06;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo07 = this.Text + @"\FileT07.txt";
            string conteudoTempo07 = System.IO.File.ReadAllText(tempo07);
            RecebendoconteudoTempo07 = conteudoTempo07;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo08 = this.Text + @"\FileT08.txt";
            string conteudoTempo08 = System.IO.File.ReadAllText(tempo08);
            RecebendoconteudoTempo08 = conteudoTempo08;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo09 = this.Text + @"\FileT09.txt";
            string conteudoTempo09 = System.IO.File.ReadAllText(tempo09);
            RecebendoconteudoTempo09 = conteudoTempo09;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo10 = this.Text + @"\FileT10.txt";
            string conteudoTempo10 = System.IO.File.ReadAllText(tempo10);
            RecebendoconteudoTempo10 = conteudoTempo10;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo11 = this.Text + @"\FileT11.txt";
            string conteudoTempo11 = System.IO.File.ReadAllText(tempo11);
            RecebendoconteudoTempo11 = conteudoTempo11;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo12 = this.Text + @"\FileT12.txt";
            string conteudoTempo12 = System.IO.File.ReadAllText(tempo12);
            RecebendoconteudoTempo12 = conteudoTempo12;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo13 = this.Text + @"\FileT13.txt";
            string conteudoTempo13 = System.IO.File.ReadAllText(tempo13);
            RecebendoconteudoTempo13 = conteudoTempo13;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo14 = this.Text + @"\FileT14.txt";
            string conteudoTempo14 = System.IO.File.ReadAllText(tempo14);
            RecebendoconteudoTempo14 = conteudoTempo14;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo15 = this.Text + @"\FileT15.txt";
            string conteudoTempo15 = System.IO.File.ReadAllText(tempo15);
            RecebendoconteudoTempo15 = conteudoTempo15;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo16 = this.Text + @"\FileT16.txt";
            string conteudoTempo16 = System.IO.File.ReadAllText(tempo16);
            RecebendoconteudoTempo16 = conteudoTempo16;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo17 = this.Text + @"\FileT17.txt";
            string conteudoTempo17 = System.IO.File.ReadAllText(tempo17);
            RecebendoconteudoTempo17 = conteudoTempo17;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo18 = this.Text + @"\FileT18.txt";
            string conteudoTempo18 = System.IO.File.ReadAllText(tempo18);
            RecebendoconteudoTempo18 = conteudoTempo18;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo19 = this.Text + @"\FileT19.txt";
            string conteudoTempo19 = System.IO.File.ReadAllText(tempo19);
            RecebendoconteudoTempo19 = conteudoTempo19;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo20 = this.Text + @"\FileT20.txt";
            string conteudoTempo20 = System.IO.File.ReadAllText(tempo20);
            RecebendoconteudoTempo20 = conteudoTempo20;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo21 = this.Text + @"\FileT21.txt";
            string conteudoTempo21 = System.IO.File.ReadAllText(tempo21);
            RecebendoconteudoTempo21 = conteudoTempo21;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo22 = this.Text + @"\FileT22.txt";
            string conteudoTempo22 = System.IO.File.ReadAllText(tempo22);
            RecebendoconteudoTempo22 = conteudoTempo22;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo23 = this.Text + @"\FileT23.txt";
            string conteudoTempo23 = System.IO.File.ReadAllText(tempo23);
            RecebendoconteudoTempo23 = conteudoTempo23;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string tempo24 = this.Text + @"\FileT24.txt";
            string conteudoTempo24 = System.IO.File.ReadAllText(tempo24);
            RecebendoconteudoTempo24 = conteudoTempo24;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string contador01 = this.Text + @"\FileC01.txt";
            string conteudoCont01 = System.IO.File.ReadAllText(contador01);
            RecebendoconteudoCont01 = conteudoCont01;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string contador02 = this.Text + @"\FileC02.txt";
            string conteudoCont02 = System.IO.File.ReadAllText(contador02);
            RecebendoconteudoCont02 = conteudoCont02;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem00 = this.Text + @"\FileD00.txt";
            string conteudoMsg00 = System.IO.File.ReadAllText(mensagem00);
            RecebendoconteudoMsg00 = conteudoMsg00;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
            string mensagem01 = this.Text + @"\FileD01.txt";
            string conteudoMsg01 = System.IO.File.ReadAllText(mensagem01);
            RecebendoconteudoMsg01 = conteudoMsg01;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
            string mensagem02 = this.Text + @"\FileD02.txt";
            string conteudoMsg02 = System.IO.File.ReadAllText(mensagem02);
            RecebendoconteudoMsg02_2 = conteudoMsg02;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
            string mensagem03 = this.Text + @"\FileD03.txt";
            string conteudoMsg03 = System.IO.File.ReadAllText(mensagem03);
            RecebendoconteudoMsg03 = conteudoMsg03;
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
            string mensagem04 = this.Text + @"\FileD04.txt";
            string conteudoMsg04 = System.IO.File.ReadAllText(mensagem04);
            RecebendoconteudoMsg04 = conteudoMsg04;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem05 = this.Text + @"\FileD05.txt";
            string conteudoMsg05 = System.IO.File.ReadAllText(mensagem05);
            RecebendoconteudoMsg05 = conteudoMsg05;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem06 = this.Text + @"\FileD06.txt";
            string conteudoMsg06 = System.IO.File.ReadAllText(mensagem06);
            RecebendoconteudoMsg06 = conteudoMsg06;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem07 = this.Text + @"\FileD07.txt";
            string conteudoMsg07 = System.IO.File.ReadAllText(mensagem07);
            RecebendoconteudoMsg07 = conteudoMsg07;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string mensagem08 = this.Text + @"\FileD08.txt";
            string conteudoMsg08 = System.IO.File.ReadAllText(mensagem08);
            RecebendoconteudoMsg08 = conteudoMsg08;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string retardo01 = this.Text + @"\FileR01.txt";
            string conteudoRet01 = System.IO.File.ReadAllText(retardo01);
            RecebendoconteudoRet01 = conteudoRet01;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string retardo02 = this.Text + @"\FileR02.txt";
            string conteudoRet02 = System.IO.File.ReadAllText(retardo02);
            RecebendoconteudoRet02 = conteudoRet02;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string retardo03 = this.Text + @"\FileR03.txt";
            string conteudoRet03 = System.IO.File.ReadAllText(retardo03);
            RecebendoconteudoRet03 = conteudoRet03;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string retardo04 = this.Text + @"\FileR04.txt";
            string conteudoRet04 = System.IO.File.ReadAllText(retardo04);
            RecebendoconteudoRet04 = conteudoRet04;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string retardo05 = this.Text + @"\FileR05.txt";
            string conteudoRet05 = System.IO.File.ReadAllText(retardo05);
            RecebendoconteudoRet05 = conteudoRet05;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string retardo06 = this.Text + @"\FileR06.txt";
            string conteudoRet06 = System.IO.File.ReadAllText(retardo06);
            RecebendoconteudoRet06 = conteudoRet06;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string retardo07 = this.Text + @"\FileR07.txt";
            string conteudoRet07 = System.IO.File.ReadAllText(retardo07);
            RecebendoconteudoRet07 = conteudoRet07;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string retardo08 = this.Text + @"\FileR08.txt";
            string conteudoRet08 = System.IO.File.ReadAllText(retardo08);
            RecebendoconteudoRet08 = conteudoRet08;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string analogica1 = caminho + @"\FileA01.txt";
            string conteudoAng01 = System.IO.File.ReadAllText(analogica1);
            Form1.RecebendoconteudoA01 = conteudoAng01;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string analogica2 = caminho + @"\FileA02.txt";
            string conteudoAng02 = System.IO.File.ReadAllText(analogica2);
            Form1.RecebendoconteudoA02 = conteudoAng02;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string analogica3 = caminho + @"\FileA03.txt";
            string conteudoAng03 = System.IO.File.ReadAllText(analogica3);
            Form1.RecebendoconteudoA03 = conteudoAng03;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string analogica4 = caminho + @"\FileA04.txt";
            string conteudoAng04 = System.IO.File.ReadAllText(analogica4);
            Form1.RecebendoconteudoA04 = conteudoAng04;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string habiltarFuncao = caminho + @"\FileB01.txt";
            string conteudoHab00 = System.IO.File.ReadAllText(habiltarFuncao);
            Form1.RecebendoconteudoADJ00 = conteudoHab00;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string habiltarFuncao2 = caminho + @"\FileB02.txt";
            string conteudoHab01 = System.IO.File.ReadAllText(habiltarFuncao2);
            Form1.RecebendoconteudoADJ01 = conteudoHab01;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string Bimanual1 = caminho + @"\FileBM1.txt";
            string conteudoBim1 = System.IO.File.ReadAllText(Bimanual1);
            RecebendoconteudoBM1 = conteudoBim1;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string Bimanual2 = caminho + @"\FileBM2.txt";
            string conteudoBim2 = System.IO.File.ReadAllText(Bimanual2);
            RecebendoconteudoBM2 = conteudoBim2;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.ReadWrite))
            {
                fs4.Read(vetor, 0, vetor.Length);

                int indice2 = 0;
                for (int i = 0; i < 250; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        mat[i, j] = vetor[indice2];
                        indice2++;
                        switch (mat[i, j])
                        {
                            case 36:
                                btn_aux.Image = Properties.Resources.bimanual_E7_E8;
                                var g_100 = Graphics.FromImage(btn_aux.Image);
                                g_100.DrawString(text100, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha100;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 250: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.botao_invisivel; break;

                            case 200: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_T; break;

                            case 201: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_H; break;

                            case 202: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_L; break;

                            case 0: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.linhas_gridview; break;
                            case 1: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.CONTINUO; break;

                            case 3: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.CONTINUO; break;

                            case 4:
                                btn_aux.Image = Properties.Resources.ENA_E01;
                                var g0 = Graphics.FromImage(btn_aux.Image);
                                g0.DrawString(text0, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha0;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 6:
                                btn_aux.Image = Properties.Resources.ENA_E02;
                                var g1 = Graphics.FromImage(btn_aux.Image);
                                g1.DrawString(text1, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha1;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 8:
                                btn_aux.Image = Properties.Resources.ENA_E03;
                                var g2 = Graphics.FromImage(btn_aux.Image);
                                g2.DrawString(text2, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha2;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 10:
                                btn_aux.Image = Properties.Resources.ENA_E04;
                                var g3 = Graphics.FromImage(btn_aux.Image);
                                g3.DrawString(text3, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha3;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 12:
                                btn_aux.Image = Properties.Resources.ENA_E05;
                                var g4 = Graphics.FromImage(btn_aux.Image);
                                g4.DrawString(text4, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha4;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 14:
                                btn_aux.Image = Properties.Resources.ENA_E06;
                                var g5 = Graphics.FromImage(btn_aux.Image);
                                g5.DrawString(text5, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha5;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 16:
                                btn_aux.Image = Properties.Resources.ENA_E07;
                                var g6 = Graphics.FromImage(btn_aux.Image);
                                g6.DrawString(text6, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha6;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 18:
                                btn_aux.Image = Properties.Resources.ENA_E08;
                                var g7 = Graphics.FromImage(btn_aux.Image);
                                g7.DrawString(text7, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha7;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 5:
                                btn_aux.Image = Properties.Resources.ENF_E01;
                                var g8 = Graphics.FromImage(btn_aux.Image);
                                g8.DrawString(text8, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha8;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 7:
                                btn_aux.Image = Properties.Resources.ENF_E02;
                                var g9 = Graphics.FromImage(btn_aux.Image);
                                g9.DrawString(text9, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha9;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 9:
                                btn_aux.Image = Properties.Resources.ENF_E03;
                                var g10 = Graphics.FromImage(btn_aux.Image);
                                g10.DrawString(text10, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha10;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 11:
                                btn_aux.Image = Properties.Resources.ENF_E041;
                                var g11 = Graphics.FromImage(btn_aux.Image);
                                g11.DrawString(text11, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha11;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 13:
                                btn_aux.Image = Properties.Resources.ENF_E05;
                                var g12 = Graphics.FromImage(btn_aux.Image);
                                g12.DrawString(text12, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha12;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 15:
                                btn_aux.Image = Properties.Resources.ENF_E06;
                                var g13 = Graphics.FromImage(btn_aux.Image);
                                g13.DrawString(text13, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha13;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 17:
                                btn_aux.Image = Properties.Resources.ENF_E07;
                                var g14 = Graphics.FromImage(btn_aux.Image);
                                g14.DrawString(text14, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha14;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 19:
                                btn_aux.Image = Properties.Resources.ENF_E08;
                                var g15 = Graphics.FromImage(btn_aux.Image);
                                g15.DrawString(text15, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha15;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 20:
                                btn_aux.Image = Properties.Resources.BP_E01;
                                var g24 = Graphics.FromImage(btn_aux.Image);
                                g24.DrawString(text24, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha24;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 22:
                                btn_aux.Image = Properties.Resources.BP_E02;
                                var g25 = Graphics.FromImage(btn_aux.Image);
                                g25.DrawString(text25, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha25;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 24:
                                btn_aux.Image = Properties.Resources.BP_E03;
                                var g26 = Graphics.FromImage(btn_aux.Image);
                                g26.DrawString(text26, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha26;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 26:
                                btn_aux.Image = Properties.Resources.BP_E04;
                                var g27 = Graphics.FromImage(btn_aux.Image);
                                g27.DrawString(text27, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha27;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 28:
                                btn_aux.Image = Properties.Resources.BP_E05;
                                var g28 = Graphics.FromImage(btn_aux.Image);
                                g28.DrawString(text28, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha28;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 30:
                                btn_aux.Image = Properties.Resources.BP_E06;
                                var g29 = Graphics.FromImage(btn_aux.Image);
                                g29.DrawString(text29, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha29;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 32:
                                btn_aux.Image = Properties.Resources.BP_E07;
                                var g30 = Graphics.FromImage(btn_aux.Image);
                                g30.DrawString(text30, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha30;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 34:
                                btn_aux.Image = Properties.Resources.BP_E08;
                                var g31 = Graphics.FromImage(btn_aux.Image);
                                g31.DrawString(text31, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha31;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 21:
                                btn_aux.Image = Properties.Resources.BN_E01;
                                var g16 = Graphics.FromImage(btn_aux.Image);
                                g16.DrawString(text16, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha16;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 23:
                                btn_aux.Image = Properties.Resources.BN_E02;
                                var g17 = Graphics.FromImage(btn_aux.Image);
                                g17.DrawString(text17, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha17;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 25:
                                btn_aux.Image = Properties.Resources.BN_E03;
                                var g18 = Graphics.FromImage(btn_aux.Image);
                                g18.DrawString(text18, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha18;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 27:
                                btn_aux.Image = Properties.Resources.BN_E04;
                                var g19 = Graphics.FromImage(btn_aux.Image);
                                g19.DrawString(text19, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha19;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 29:
                                btn_aux.Image = Properties.Resources.BN_E05;
                                var g20 = Graphics.FromImage(btn_aux.Image);
                                g20.DrawString(text20, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha20;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 31:
                                btn_aux.Image = Properties.Resources.BN_E06;
                                var g21 = Graphics.FromImage(btn_aux.Image);
                                g21.DrawString(text21, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha21;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 33:
                                btn_aux.Image = Properties.Resources.BN_E07;
                                var g22 = Graphics.FromImage(btn_aux.Image);
                                g22.DrawString(text22, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha22;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 35:
                                btn_aux.Image = Properties.Resources.BN_E08;
                                var g23 = Graphics.FromImage(btn_aux.Image);
                                g23.DrawString(text23, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha23;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 114:
                                btn_aux.Image = Properties.Resources.contador01;
                                var g68 = Graphics.FromImage(btn_aux.Image);
                                g68.DrawString(text68, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha68;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 115:
                                btn_aux.Image = Properties.Resources.contador02;
                                var g69 = Graphics.FromImage(btn_aux.Image);
                                g69.DrawString(text69, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha69;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 148: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d01; break;

                            case 149: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d02; break;

                            case 150: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d03; break;

                            case 151: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d04; break;

                            case 152: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d05; break;

                            case 153: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d06; break;

                            case 154: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d07; break;


                            case 155: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d08; break;

                            case 116:
                                btn_aux.Image = Properties.Resources.espera01;
                                var g70 = Graphics.FromImage(btn_aux.Image);
                                g70.DrawString(text70, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha70;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 117:
                                btn_aux.Image = Properties.Resources.espera02;
                                var g71 = Graphics.FromImage(btn_aux.Image);
                                g71.DrawString(text71, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha71;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 118:
                                btn_aux.Image = Properties.Resources.espera03;
                                var g72 = Graphics.FromImage(btn_aux.Image);
                                g72.DrawString(text72, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha72;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 119:
                                btn_aux.Image = Properties.Resources.espera04;
                                var g73 = Graphics.FromImage(btn_aux.Image);
                                g73.DrawString(text73, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha73;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 120:
                                btn_aux.Image = Properties.Resources.espera05;
                                var g74 = Graphics.FromImage(btn_aux.Image);
                                g74.DrawString(text74, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha74;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 121:
                                btn_aux.Image = Properties.Resources.espera06;
                                var g75 = Graphics.FromImage(btn_aux.Image);
                                g75.DrawString(text75, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha75;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 122:
                                btn_aux.Image = Properties.Resources.espera07;
                                var g76 = Graphics.FromImage(btn_aux.Image);
                                g76.DrawString(text76, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha76;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 123:
                                btn_aux.Image = Properties.Resources.espera08;
                                var g77 = Graphics.FromImage(btn_aux.Image);
                                g77.DrawString(text77, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha77;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 124:
                                btn_aux.Image = Properties.Resources.temporizador_01;
                                var g78 = Graphics.FromImage(btn_aux.Image);
                                g78.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 125:
                                btn_aux.Image = Properties.Resources.temporizador_02;
                                var g79 = Graphics.FromImage(btn_aux.Image);
                                g79.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 126:
                                btn_aux.Image = Properties.Resources.temporizador_03;
                                var g80 = Graphics.FromImage(btn_aux.Image);
                                g80.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 127:
                                btn_aux.Image = Properties.Resources.temporizador_04;
                                var g81 = Graphics.FromImage(btn_aux.Image);
                                g81.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 128:
                                btn_aux.Image = Properties.Resources.temporizador_05;
                                var g82 = Graphics.FromImage(btn_aux.Image);
                                g82.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 129:
                                btn_aux.Image = Properties.Resources.temporizador_06;
                                var g83 = Graphics.FromImage(btn_aux.Image);
                                g83.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 130:
                                btn_aux.Image = Properties.Resources.temporizador_07;
                                var g84 = Graphics.FromImage(btn_aux.Image);
                                g84.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 131:
                                btn_aux.Image = Properties.Resources.temporizador_08;
                                var g85 = Graphics.FromImage(btn_aux.Image);
                                g85.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 132:
                                btn_aux.Image = Properties.Resources.temporizador_09;
                                var g78_2 = Graphics.FromImage(btn_aux.Image);
                                g78_2.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 133:
                                btn_aux.Image = Properties.Resources.temporizador_10;
                                var g79_2 = Graphics.FromImage(btn_aux.Image);
                                g79_2.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 134:
                                btn_aux.Image = Properties.Resources.temporizador_11;
                                var g80_2 = Graphics.FromImage(btn_aux.Image);
                                g80_2.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 135:
                                btn_aux.Image = Properties.Resources.temporizador_12;
                                var g81_2 = Graphics.FromImage(btn_aux.Image);
                                g81_2.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 136:
                                btn_aux.Image = Properties.Resources.temporizador_13;
                                var g82_2 = Graphics.FromImage(btn_aux.Image);
                                g82_2.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 137:
                                btn_aux.Image = Properties.Resources.temporizador_14;
                                var g83_2 = Graphics.FromImage(btn_aux.Image);
                                g83_2.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 138:
                                btn_aux.Image = Properties.Resources.temporizador_15;
                                var g84_2 = Graphics.FromImage(btn_aux.Image);
                                g84_2.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 139:
                                btn_aux.Image = Properties.Resources.temporizador_16;
                                var g85_2 = Graphics.FromImage(btn_aux.Image);
                                g85_2.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 140:
                                btn_aux.Image = Properties.Resources.temporizador_17;
                                var g78_3 = Graphics.FromImage(btn_aux.Image);
                                g78_3.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 141:
                                btn_aux.Image = Properties.Resources.temporizador_18;
                                var g79_3 = Graphics.FromImage(btn_aux.Image);
                                g79_3.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 142:
                                btn_aux.Image = Properties.Resources.temporizador_19;
                                var g80_3 = Graphics.FromImage(btn_aux.Image);
                                g80_3.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 143:
                                btn_aux.Image = Properties.Resources.temporizador_20;
                                var g81_3 = Graphics.FromImage(btn_aux.Image);
                                g81_3.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 144:
                                btn_aux.Image = Properties.Resources.temporizador_21;
                                var g82_3 = Graphics.FromImage(btn_aux.Image);
                                g82_3.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 145:
                                btn_aux.Image = Properties.Resources.temporizador_22;
                                var g83_3 = Graphics.FromImage(btn_aux.Image);
                                g83_3.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 146:
                                btn_aux.Image = Properties.Resources.temporizador_23;
                                var g84_3 = Graphics.FromImage(btn_aux.Image);
                                g84_3.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 147:
                                btn_aux.Image = Properties.Resources.temporizador_24;
                                var g85_3 = Graphics.FromImage(btn_aux.Image);
                                g85_3.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 52:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNA_E01;

                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_01;

                                }
                                var g32 = Graphics.FromImage(btn_aux.Image);
                                g32.DrawString(text32, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha32;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 54:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNA_E02;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_02;
                                }
                                var g33 = Graphics.FromImage(btn_aux.Image);
                                g33.DrawString(text33, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha33;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 56:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNA_E03;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_03;
                                }

                                var g34 = Graphics.FromImage(btn_aux.Image);
                                g34.DrawString(text34, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha34;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 58:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNA_E04;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_04;
                                }

                                var g35 = Graphics.FromImage(btn_aux.Image);
                                g35.DrawString(text35, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha35;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 60:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNA_E05;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_05;
                                }
                                var g36 = Graphics.FromImage(btn_aux.Image);
                                g36.DrawString(text36, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha36;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 62:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNA_E06;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_06;
                                }
                                var g37 = Graphics.FromImage(btn_aux.Image);
                                g37.DrawString(text37, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha37;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 64:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNA_E07;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_07;
                                }
                                var g38 = Graphics.FromImage(btn_aux.Image);
                                g38.DrawString(text38, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha38;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 66:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNA_E08;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_08;
                                }
                                var g39 = Graphics.FromImage(btn_aux.Image);
                                g39.DrawString(text39, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha39;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 53:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNF_E01;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_1;
                                }
                                btn_aux.Image = Properties.Resources.ESPECIAL_NF_1;
                                var g40 = Graphics.FromImage(btn_aux.Image);
                                g40.DrawString(text40, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha40;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 55:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNF_E02;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_2;
                                }
                                var g41 = Graphics.FromImage(btn_aux.Image);
                                g41.DrawString(text41, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha41;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 57:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNF_E03;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_3;
                                }
                                var g42 = Graphics.FromImage(btn_aux.Image);
                                g42.DrawString(text42, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha42;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 59:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNF_E04;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_4;
                                }
                                var g43 = Graphics.FromImage(btn_aux.Image);
                                g43.DrawString(text43, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha43;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 61:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNF_E05;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_5;
                                }
                                var g44 = Graphics.FromImage(btn_aux.Image);
                                g44.DrawString(text44, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha44;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 63:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNF_E06;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_6;
                                }
                                var g45 = Graphics.FromImage(btn_aux.Image);
                                g45.DrawString(text45, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha45;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 65:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNF_E07;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_7;
                                }
                                var g46 = Graphics.FromImage(btn_aux.Image);
                                g46.DrawString(text46, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha46;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 67:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SNF_E08;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_8;
                                }
                                var g47 = Graphics.FromImage(btn_aux.Image);
                                g47.DrawString(text47, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha47;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 68:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SET_E01;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_SET;
                                }
                                var g48 = Graphics.FromImage(btn_aux.Image);
                                g48.DrawString(text48, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha48;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 70:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SET_E02;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_SET_2;
                                }
                                var g49 = Graphics.FromImage(btn_aux.Image);
                                g49.DrawString(text49, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha49;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 72:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SET_E03;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_SET_3;
                                }
                                var g50 = Graphics.FromImage(btn_aux.Image);
                                g50.DrawString(text50, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha50;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 74:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SET_E04;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_SET_4;
                                }
                                var g51 = Graphics.FromImage(btn_aux.Image);
                                g51.DrawString(text51, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha51;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 76:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SET_E05;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_SET_5;
                                }
                                var g52 = Graphics.FromImage(btn_aux.Image);
                                g52.DrawString(text52, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha52;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 78:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SET_E06;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_SET_6;
                                }
                                var g53 = Graphics.FromImage(btn_aux.Image);
                                g53.DrawString(text53, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha53;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 80:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SET_E07;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_SET_7;
                                }
                                var g54 = Graphics.FromImage(btn_aux.Image);
                                g54.DrawString(text54, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha54;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 82:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.SET_E08;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_SET_8;
                                }
                                var g55 = Graphics.FromImage(btn_aux.Image);
                                g55.DrawString(text55, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha55;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 69:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.RES_E01;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_RES;
                                }
                                var g56 = Graphics.FromImage(btn_aux.Image);
                                g56.DrawString(text56, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha56;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 71:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.RES_E02;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_RES_2;
                                }
                                var g57 = Graphics.FromImage(btn_aux.Image);
                                g57.DrawString(text57, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha57;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 73:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.RES_E03;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_RES_3;
                                }
                                var g58 = Graphics.FromImage(btn_aux.Image);
                                g58.DrawString(text58, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha58;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 75:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.RES_E04;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_RES_4;
                                }
                                var g59 = Graphics.FromImage(btn_aux.Image);
                                g59.DrawString(text59, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha59;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 77:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.RES_E05;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_RES_5;
                                }
                                var g60 = Graphics.FromImage(btn_aux.Image);
                                g60.DrawString(text60, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha60;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 79:

                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.RES_E06;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_RES_6;
                                }
                                var g61 = Graphics.FromImage(btn_aux.Image);
                                g61.DrawString(text61, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha61;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 81:

                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.RES_E07;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_RES_7;
                                }
                                var g62 = Graphics.FromImage(btn_aux.Image);
                                g62.DrawString(text62, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha62;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 83:
                                if (j == 16)
                                {
                                    btn_aux.Image = Properties.Resources.RES_E08;
                                }
                                else
                                {
                                    btn_aux.Image = Properties.Resources.ESPECIAL_RES_8;
                                }
                                var g63 = Graphics.FromImage(btn_aux.Image);
                                g63.DrawString(text63, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha63;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 100: // CA NA
                                btn_aux.Image = Properties.Resources.CONTATO_01_NA;
                                var g86 = Graphics.FromImage(btn_aux.Image);
                                g86.DrawString(text86, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha86;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 101: // CA NF
                                btn_aux.Image = Properties.Resources.CONTATO_01_NF;
                                var g87 = Graphics.FromImage(btn_aux.Image);
                                g87.DrawString(text87, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha87;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 102: // CA NA
                                btn_aux.Image = Properties.Resources.CONTATO_02_NA;
                                var g88 = Graphics.FromImage(btn_aux.Image);
                                g88.DrawString(text88, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha88;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 103: // CA NF
                                btn_aux.Image = Properties.Resources.CONTATO_02_NF;
                                var g89 = Graphics.FromImage(btn_aux.Image);
                                g89.DrawString(text89, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha89;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 104: // CA NA
                                btn_aux.Image = Properties.Resources.CONTATO_03_NA;
                                var g90 = Graphics.FromImage(btn_aux.Image);
                                g90.DrawString(text90, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha90;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 105: // CA NF
                                btn_aux.Image = Properties.Resources.CONTATO_03_NF;
                                var g91 = Graphics.FromImage(btn_aux.Image);
                                g91.DrawString(text91, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha91;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 106: // CA NA
                                btn_aux.Image = Properties.Resources.CONTATO_04_NA;
                                var g92 = Graphics.FromImage(btn_aux.Image);
                                g92.DrawString(text92, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha92;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 107: // CA NF
                                btn_aux.Image = Properties.Resources.CONTATO_04_NF;
                                var g93 = Graphics.FromImage(btn_aux.Image);
                                g93.DrawString(text93, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha93;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 108: // CA NA
                                btn_aux.Image = Properties.Resources.CONTATO_05_NA;
                                var g94 = Graphics.FromImage(btn_aux.Image);
                                g94.DrawString(text94, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha94;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 109: // CA NA
                                btn_aux.Image = Properties.Resources.CONTATO_06_NA;
                                var g95 = Graphics.FromImage(btn_aux.Image);
                                g95.DrawString(text95, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha95;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 110: // CA NA
                                btn_aux.Image = Properties.Resources.CONTATO_07_NA;
                                var g96 = Graphics.FromImage(btn_aux.Image);
                                g96.DrawString(text96, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha96;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 111: // CA NA
                                btn_aux.Image = Properties.Resources.CONTATO_08_NA;
                                var g97 = Graphics.FromImage(btn_aux.Image);
                                g97.DrawString(text97, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha97;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 112: // CA SET
                                btn_aux.Image = Properties.Resources.CONTATO_09_SET;
                                var g98 = Graphics.FromImage(btn_aux.Image);
                                g98.DrawString(text98, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha98;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 113:// CA RESET
                                btn_aux.Image = Properties.Resources.CONTATO_09_RES;
                                var g99 = Graphics.FromImage(btn_aux.Image);
                                g99.DrawString(text99, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha99;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 40:// CA SET
                                btn_aux.Image = Properties.Resources.CONTATO_10_SET;
                                var g104 = Graphics.FromImage(btn_aux.Image);
                                g104.DrawString(text104, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha104;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 41:// CA RESET
                                btn_aux.Image = Properties.Resources.CONTATO_10_RESET;
                                var g105 = Graphics.FromImage(btn_aux.Image);
                                g105.DrawString(text105, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha105;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 42:// CA SET
                                btn_aux.Image = Properties.Resources.CONTATO_11_SET;
                                var g106 = Graphics.FromImage(btn_aux.Image);
                                g106.DrawString(text106, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha106;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 43:// CA RESET
                                btn_aux.Image = Properties.Resources.CONTATO_11_RESET;
                                var g107 = Graphics.FromImage(btn_aux.Image);
                                g107.DrawString(text107, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha107;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 44:// CA SET
                                btn_aux.Image = Properties.Resources.CONTATO_12_SET;
                                var g108 = Graphics.FromImage(btn_aux.Image);
                                g108.DrawString(text108, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha108;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 45:// CA RESET
                                btn_aux.Image = Properties.Resources.CONTATO_12_RESET;
                                var g109 = Graphics.FromImage(btn_aux.Image);
                                g109.DrawString(text109, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha109;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 46:// CA SET
                                btn_aux.Image = Properties.Resources.CONTATO_13_SET;
                                var g110 = Graphics.FromImage(btn_aux.Image);
                                g110.DrawString(text110, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha110;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 47:// CA RESET
                                btn_aux.Image = Properties.Resources.CONTATO_13_RESET;
                                var g111 = Graphics.FromImage(btn_aux.Image);
                                g111.DrawString(text111, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha111;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 48:// CA SET
                                btn_aux.Image = Properties.Resources.CONTATO_14_SET;
                                var g112 = Graphics.FromImage(btn_aux.Image);
                                g112.DrawString(text112, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha112;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 49:// CA RESET
                                btn_aux.Image = Properties.Resources.CONTATO_14_RESET;
                                var g113 = Graphics.FromImage(btn_aux.Image);
                                g113.DrawString(text113, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha113;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 156:
                                btn_aux.Image = Properties.Resources.ANG_E01;
                                var g64 = Graphics.FromImage(btn_aux.Image);
                                g64.DrawString(text64, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha64;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 157:
                                btn_aux.Image = Properties.Resources.ANG_E02;
                                var g65 = Graphics.FromImage(btn_aux.Image);
                                g65.DrawString(text65, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha65;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;

                                break;
                            case 158:
                                btn_aux.Image = Properties.Resources.ANG_E03;
                                var g66 = Graphics.FromImage(btn_aux.Image);
                                g66.DrawString(text66, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha66;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 159:
                                btn_aux.Image = Properties.Resources.ANG_E04;
                                var g67 = Graphics.FromImage(btn_aux.Image);
                                g67.DrawString(text67, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha67;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 38:
                                btn_aux.Image = Properties.Resources.HAB_F1;
                                var g102 = Graphics.FromImage(btn_aux.Image);
                                g102.DrawString(text102, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha102;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;

                            case 39:
                                btn_aux.Image = Properties.Resources.HAB_F2;
                                var g103 = Graphics.FromImage(btn_aux.Image);
                                g103.DrawString(text103, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                dataGridView1.Rows[i].Cells[j].ToolTipText = linha103;
                                dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                break;
                        }
                    }
                }
            }
            dataGridView1.Visible = true;
            groupBox13.Visible = true;
            groupBox12.Visible = true;
            button1.Visible = true;
            gb_tabela.Visible = true;
            btn_abrir.Visible = false;

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void ts_apagarLinha_Click(object sender, EventArgs e)
        {         
            // copia matriz principal para matriz temporaria a partir da linha selecionada+1
            LT = 0;
            for (int L = Linha + 1; L < 250; L++)
            {
                for (int C = 0; C < 17; C++)
                {
                    matriz_temp[LT, C] = mat[L, C];
                }
                if (LT < 250) LT++;
            }

            // copia matriz temporaria(somente valores apartira da linha selecionada) de volta para matriz principal deslocando 1 linha
            LT = 0;
            for (int L = Linha; L < 250; L++)
            {
                for (int C = 0; C < 17; C++)
                {
                    mat[L, C] = matriz_temp[LT, C];
                }
                if (LT < 250) LT++;
            }


            //// salvando matriz
            salvar = 1;
            int indice = 0;
            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    vetor[indice] = (byte)mat[i, j];
                    indice++;
                }
            }

            using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.Write))
            {
                fs4.Write(vetor, 0, vetor.Length);
            }

                ///// abrir matriz

           
                FileInfo fileInfo = new FileInfo(arquivo);
                caminho = fileInfo.DirectoryName;
                this.Text = caminho;
                caminhoAntigo = this.Text;
                btn_salvar.Visible = true;
                btn_fechar.Visible = true;
                btn_novo.Visible = false;

                string coment = this.Text + @"\Comentarios.txt";

                allLines = File.ReadAllLines(coment);

                for (int i = 0; i < allLines.Length; i++)
                {
                    if (allLines[i].Length < 1)
                    {
                        allLines[i] = allLines[i] + "        ";
                    }
                    if (allLines[i].Length < 2)
                    {
                        allLines[i] = allLines[i] + "       ";
                    }
                    else if (allLines[i].Length < 3)
                    {
                        allLines[i] = allLines[i] + "      ";
                    }
                    else if (allLines[i].Length < 4)
                    {
                        allLines[i] = allLines[i] + "     ";
                    }
                    else if (allLines[i].Length < 5)
                    {
                        allLines[i] = allLines[i] + "    ";
                    }
                    else if (allLines[i].Length < 6)
                    {
                        allLines[i] = allLines[i] + "   ";
                    }
                    else if (allLines[i].Length < 7)
                    {
                        allLines[i] = allLines[i] + "  ";
                    }
                    else if (allLines[i].Length < 8)
                    {
                        allLines[i] = allLines[i] + " ";
                    }
                }


                linha0 = allLines[0];
                linha1 = allLines[1];
                linha2 = allLines[2];
                linha3 = allLines[3];
                linha4 = allLines[4];
                linha5 = allLines[5];
                linha6 = allLines[6];
                linha7 = allLines[7];

                linha8 = allLines[8];
                linha9 = allLines[9];
                linha10 = allLines[10];
                linha11 = allLines[11];
                linha12 = allLines[12];
                linha13 = allLines[13];
                linha14 = allLines[14];
                linha15 = allLines[15];

                linha16 = allLines[16];
                linha17 = allLines[17];
                linha18 = allLines[18];
                linha19 = allLines[19];
                linha20 = allLines[20];
                linha21 = allLines[21];
                linha22 = allLines[22];
                linha23 = allLines[23];

                linha24 = allLines[24];
                linha25 = allLines[25];
                linha26 = allLines[26];
                linha27 = allLines[27];
                linha28 = allLines[28];
                linha29 = allLines[29];
                linha30 = allLines[30];
                linha31 = allLines[31];

                linha32 = allLines[32];
                linha33 = allLines[33];
                linha34 = allLines[34];
                linha35 = allLines[35];
                linha36 = allLines[36];
                linha37 = allLines[37];
                linha38 = allLines[38];
                linha39 = allLines[39];

                linha40 = allLines[40];
                linha41 = allLines[41];
                linha42 = allLines[42];
                linha43 = allLines[43];
                linha44 = allLines[44];
                linha45 = allLines[45];
                linha46 = allLines[46];
                linha47 = allLines[47];

                linha48 = allLines[48];
                linha49 = allLines[49];
                linha50 = allLines[50];
                linha51 = allLines[51];
                linha52 = allLines[52];
                linha53 = allLines[53];
                linha54 = allLines[54];
                linha55 = allLines[55];

                linha56 = allLines[56];
                linha57 = allLines[57];
                linha58 = allLines[58];
                linha59 = allLines[59];
                linha60 = allLines[60];
                linha61 = allLines[61];
                linha62 = allLines[62];
                linha63 = allLines[63];

                linha64 = allLines[64];
                linha65 = allLines[65];
                linha66 = allLines[66];
                linha67 = allLines[67];
                linha68 = allLines[68];
                linha69 = allLines[69];
                linha70 = allLines[70];
                linha71 = allLines[71];

                linha72 = allLines[72];
                linha73 = allLines[73];
                linha74 = allLines[74];
                linha75 = allLines[75];
                linha76 = allLines[76];
                linha77 = allLines[77];
                linha78 = allLines[78];
                linha79 = allLines[79];

                linha80 = allLines[80];
                linha81 = allLines[81];
                linha82 = allLines[82];
                linha83 = allLines[83];
                linha84 = allLines[84];
                linha85 = allLines[85];

                linha86 = allLines[86];
                linha87 = allLines[87];

                linha88 = allLines[88];
                linha89 = allLines[89];
                linha90 = allLines[90];
                linha91 = allLines[91];
                linha92 = allLines[92];
                linha93 = allLines[93];
                linha94 = allLines[94];
                linha95 = allLines[95];
                linha96 = allLines[96];
                linha97 = allLines[97];
                linha98 = allLines[98];

                linha99 = allLines[99];
                linha100 = allLines[100];
                linha101 = allLines[101];
                linha102 = allLines[102];
                linha103 = allLines[103];

                linha104 = allLines[104];
                linha105 = allLines[105];
                linha106 = allLines[106];
                linha107 = allLines[107];
                linha108 = allLines[108];
                linha109 = allLines[109];
                linha110 = allLines[110];
                linha111 = allLines[111];
                linha112 = allLines[112];
                linha113 = allLines[113];

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                string text0 = linha0.Substring(0, 8);
                string text1 = linha1.Substring(0, 8);
                string text2 = linha2.Substring(0, 8);
                string text3 = linha3.Substring(0, 8);
                string text4 = linha4.Substring(0, 8);
                string text5 = linha5.Substring(0, 8);
                string text6 = linha6.Substring(0, 8);
                string text7 = linha7.Substring(0, 8);

                string text8 = linha8.Substring(0, 8);
                string text9 = linha9.Substring(0, 8);
                string text10 = linha10.Substring(0, 8);
                string text11 = linha11.Substring(0, 8);
                string text12 = linha12.Substring(0, 8);
                string text13 = linha13.Substring(0, 8);
                string text14 = linha14.Substring(0, 8);
                string text15 = linha15.Substring(0, 8);

                string text16 = linha16.Substring(0, 8);
                string text17 = linha17.Substring(0, 8);
                string text18 = linha18.Substring(0, 8);
                string text19 = linha19.Substring(0, 8);
                string text20 = linha20.Substring(0, 8);
                string text21 = linha21.Substring(0, 8);
                string text22 = linha22.Substring(0, 8);
                string text23 = linha23.Substring(0, 8);

                string text24 = linha24.Substring(0, 8);
                string text25 = linha25.Substring(0, 8);
                string text26 = linha26.Substring(0, 8);
                string text27 = linha27.Substring(0, 8);
                string text28 = linha28.Substring(0, 8);
                string text29 = linha29.Substring(0, 8);
                string text30 = linha30.Substring(0, 8);
                string text31 = linha31.Substring(0, 8);

                string text32 = linha32.Substring(0, 8);
                string text33 = linha33.Substring(0, 8);
                string text34 = linha34.Substring(0, 8);
                string text35 = linha35.Substring(0, 8);
                string text36 = linha36.Substring(0, 8);
                string text37 = linha37.Substring(0, 8);
                string text38 = linha38.Substring(0, 8);
                string text39 = linha39.Substring(0, 8);

                string text40 = linha40.Substring(0, 8);
                string text41 = linha41.Substring(0, 8);
                string text42 = linha42.Substring(0, 8);
                string text43 = linha43.Substring(0, 8);
                string text44 = linha44.Substring(0, 8);
                string text45 = linha45.Substring(0, 8);
                string text46 = linha46.Substring(0, 8);
                string text47 = linha47.Substring(0, 8);

                string text48 = linha48.Substring(0, 8);
                string text49 = linha49.Substring(0, 8);
                string text50 = linha50.Substring(0, 8);
                string text51 = linha51.Substring(0, 8);
                string text52 = linha52.Substring(0, 8);
                string text53 = linha53.Substring(0, 8);
                string text54 = linha54.Substring(0, 8);
                string text55 = linha55.Substring(0, 8);

                string text56 = linha56.Substring(0, 8);
                string text57 = linha57.Substring(0, 8);
                string text58 = linha58.Substring(0, 8);
                string text59 = linha59.Substring(0, 8);
                string text60 = linha60.Substring(0, 8);
                string text61 = linha61.Substring(0, 8);
                string text62 = linha62.Substring(0, 8);
                string text63 = linha63.Substring(0, 8);

                string text64 = linha64.Substring(0, 8);
                string text65 = linha65.Substring(0, 8);
                string text66 = linha66.Substring(0, 8);
                string text67 = linha67.Substring(0, 8);
                string text68 = linha68.Substring(0, 8);
                string text69 = linha69.Substring(0, 8);
                string text70 = linha70.Substring(0, 8);
                string text71 = linha71.Substring(0, 8);

                string text72 = linha72.Substring(0, 8);
                string text73 = linha73.Substring(0, 8);
                string text74 = linha74.Substring(0, 8);
                string text75 = linha75.Substring(0, 8);
                string text76 = linha76.Substring(0, 8);
                string text77 = linha77.Substring(0, 8);
                string text78 = linha78.Substring(0, 8);
                string text79 = linha79.Substring(0, 8);

                string text80 = linha80.Substring(0, 8);
                string text81 = linha81.Substring(0, 8);
                string text82 = linha82.Substring(0, 8);
                string text83 = linha83.Substring(0, 8);
                string text84 = linha84.Substring(0, 8);
                string text85 = linha85.Substring(0, 8);

                string text86 = linha86.Substring(0, 8);
                string text87 = linha87.Substring(0, 8);
                string text88 = linha87.Substring(0, 8);

                string text89 = linha88.Substring(0, 8);
                string text90 = linha89.Substring(0, 8);
                string text91 = linha91.Substring(0, 8);
                string text92 = linha92.Substring(0, 8);
                string text93 = linha93.Substring(0, 8);
                string text94 = linha94.Substring(0, 8);
                string text95 = linha95.Substring(0, 8);
                string text96 = linha96.Substring(0, 8);
                string text97 = linha97.Substring(0, 8);
                string text98 = linha98.Substring(0, 8);

                string text99 = linha99.Substring(0, 8);
                string text100 = linha100.Substring(0, 8);
                string text101 = linha101.Substring(0, 8);
                string text102 = linha102.Substring(0, 8);
                string text103 = linha103.Substring(0, 8);

                string text104 = linha104.Substring(0, 8);
                string text105 = linha105.Substring(0, 8);
                string text106 = linha106.Substring(0, 8);
                string text107 = linha107.Substring(0, 8);
                string text108 = linha108.Substring(0, 8);
                string text109 = linha109.Substring(0, 8);
                string text110 = linha110.Substring(0, 8);
                string text111 = linha111.Substring(0, 8);
                string text112 = linha112.Substring(0, 8);
                string text113 = linha113.Substring(0, 8);

                repassandoCaminho = caminho;

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo01 = this.Text + @"\FileT01.txt";
                string conteudoTempo01 = System.IO.File.ReadAllText(tempo01);
                RecebendoconteudoTempo01 = conteudoTempo01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo02 = this.Text + @"\FileT02.txt";
                string conteudoTempo02 = System.IO.File.ReadAllText(tempo02);
                RecebendoconteudoTempo02 = conteudoTempo02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo03 = this.Text + @"\FileT03.txt";
                string conteudoTempo03 = System.IO.File.ReadAllText(tempo03);
                RecebendoconteudoTempo03 = conteudoTempo03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo04 = this.Text + @"\FileT04.txt";
                string conteudoTempo04 = System.IO.File.ReadAllText(tempo04);
                RecebendoconteudoTempo04 = conteudoTempo04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo05 = this.Text + @"\FileT05.txt";
                string conteudoTempo05 = System.IO.File.ReadAllText(tempo05);
                RecebendoconteudoTempo05 = conteudoTempo05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo06 = this.Text + @"\FileT06.txt";
                string conteudoTempo06 = System.IO.File.ReadAllText(tempo06);
                RecebendoconteudoTempo06 = conteudoTempo06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo07 = this.Text + @"\FileT07.txt";
                string conteudoTempo07 = System.IO.File.ReadAllText(tempo07);
                RecebendoconteudoTempo07 = conteudoTempo07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo08 = this.Text + @"\FileT08.txt";
                string conteudoTempo08 = System.IO.File.ReadAllText(tempo08);
                RecebendoconteudoTempo08 = conteudoTempo08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo09 = this.Text + @"\FileT09.txt";
                string conteudoTempo09 = System.IO.File.ReadAllText(tempo09);
                RecebendoconteudoTempo09 = conteudoTempo09;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo10 = this.Text + @"\FileT10.txt";
                string conteudoTempo10 = System.IO.File.ReadAllText(tempo10);
                RecebendoconteudoTempo10 = conteudoTempo10;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo11 = this.Text + @"\FileT11.txt";
                string conteudoTempo11 = System.IO.File.ReadAllText(tempo11);
                RecebendoconteudoTempo11 = conteudoTempo11;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo12 = this.Text + @"\FileT12.txt";
                string conteudoTempo12 = System.IO.File.ReadAllText(tempo12);
                RecebendoconteudoTempo12 = conteudoTempo12;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo13 = this.Text + @"\FileT13.txt";
                string conteudoTempo13 = System.IO.File.ReadAllText(tempo13);
                RecebendoconteudoTempo13 = conteudoTempo13;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo14 = this.Text + @"\FileT14.txt";
                string conteudoTempo14 = System.IO.File.ReadAllText(tempo14);
                RecebendoconteudoTempo14 = conteudoTempo14;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo15 = this.Text + @"\FileT15.txt";
                string conteudoTempo15 = System.IO.File.ReadAllText(tempo15);
                RecebendoconteudoTempo15 = conteudoTempo15;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo16 = this.Text + @"\FileT16.txt";
                string conteudoTempo16 = System.IO.File.ReadAllText(tempo16);
                RecebendoconteudoTempo16 = conteudoTempo16;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo17 = this.Text + @"\FileT17.txt";
                string conteudoTempo17 = System.IO.File.ReadAllText(tempo17);
                RecebendoconteudoTempo17 = conteudoTempo17;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo18 = this.Text + @"\FileT18.txt";
                string conteudoTempo18 = System.IO.File.ReadAllText(tempo18);
                RecebendoconteudoTempo18 = conteudoTempo18;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo19 = this.Text + @"\FileT19.txt";
                string conteudoTempo19 = System.IO.File.ReadAllText(tempo19);
                RecebendoconteudoTempo19 = conteudoTempo19;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo20 = this.Text + @"\FileT20.txt";
                string conteudoTempo20 = System.IO.File.ReadAllText(tempo20);
                RecebendoconteudoTempo20 = conteudoTempo20;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo21 = this.Text + @"\FileT21.txt";
                string conteudoTempo21 = System.IO.File.ReadAllText(tempo21);
                RecebendoconteudoTempo21 = conteudoTempo21;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo22 = this.Text + @"\FileT22.txt";
                string conteudoTempo22 = System.IO.File.ReadAllText(tempo22);
                RecebendoconteudoTempo22 = conteudoTempo22;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo23 = this.Text + @"\FileT23.txt";
                string conteudoTempo23 = System.IO.File.ReadAllText(tempo23);
                RecebendoconteudoTempo23 = conteudoTempo23;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string tempo24 = this.Text + @"\FileT24.txt";
                string conteudoTempo24 = System.IO.File.ReadAllText(tempo24);
                RecebendoconteudoTempo24 = conteudoTempo24;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string contador01 = this.Text + @"\FileC01.txt";
                string conteudoCont01 = System.IO.File.ReadAllText(contador01);
                RecebendoconteudoCont01 = conteudoCont01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string contador02 = this.Text + @"\FileC02.txt";
                string conteudoCont02 = System.IO.File.ReadAllText(contador02);
                RecebendoconteudoCont02 = conteudoCont02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem00 = this.Text + @"\FileD00.txt";
                string conteudoMsg00 = System.IO.File.ReadAllText(mensagem00);
                RecebendoconteudoMsg00 = conteudoMsg00;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
                string mensagem01 = this.Text + @"\FileD01.txt";
                string conteudoMsg01 = System.IO.File.ReadAllText(mensagem01);
                RecebendoconteudoMsg01 = conteudoMsg01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
                string mensagem02 = this.Text + @"\FileD02.txt";
                string conteudoMsg02 = System.IO.File.ReadAllText(mensagem02);
                RecebendoconteudoMsg02_2 = conteudoMsg02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
                string mensagem03 = this.Text + @"\FileD03.txt";
                string conteudoMsg03 = System.IO.File.ReadAllText(mensagem03);
                RecebendoconteudoMsg03 = conteudoMsg03;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
                string mensagem04 = this.Text + @"\FileD04.txt";
                string conteudoMsg04 = System.IO.File.ReadAllText(mensagem04);
                RecebendoconteudoMsg04 = conteudoMsg04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem05 = this.Text + @"\FileD05.txt";
                string conteudoMsg05 = System.IO.File.ReadAllText(mensagem05);
                RecebendoconteudoMsg05 = conteudoMsg05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem06 = this.Text + @"\FileD06.txt";
                string conteudoMsg06 = System.IO.File.ReadAllText(mensagem06);
                RecebendoconteudoMsg06 = conteudoMsg06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem07 = this.Text + @"\FileD07.txt";
                string conteudoMsg07 = System.IO.File.ReadAllText(mensagem07);
                RecebendoconteudoMsg07 = conteudoMsg07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string mensagem08 = this.Text + @"\FileD08.txt";
                string conteudoMsg08 = System.IO.File.ReadAllText(mensagem08);
                RecebendoconteudoMsg08 = conteudoMsg08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo01 = this.Text + @"\FileR01.txt";
                string conteudoRet01 = System.IO.File.ReadAllText(retardo01);
                RecebendoconteudoRet01 = conteudoRet01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo02 = this.Text + @"\FileR02.txt";
                string conteudoRet02 = System.IO.File.ReadAllText(retardo02);
                RecebendoconteudoRet02 = conteudoRet02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo03 = this.Text + @"\FileR03.txt";
                string conteudoRet03 = System.IO.File.ReadAllText(retardo03);
                RecebendoconteudoRet03 = conteudoRet03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo04 = this.Text + @"\FileR04.txt";
                string conteudoRet04 = System.IO.File.ReadAllText(retardo04);
                RecebendoconteudoRet04 = conteudoRet04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo05 = this.Text + @"\FileR05.txt";
                string conteudoRet05 = System.IO.File.ReadAllText(retardo05);
                RecebendoconteudoRet05 = conteudoRet05;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo06 = this.Text + @"\FileR06.txt";
                string conteudoRet06 = System.IO.File.ReadAllText(retardo06);
                RecebendoconteudoRet06 = conteudoRet06;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo07 = this.Text + @"\FileR07.txt";
                string conteudoRet07 = System.IO.File.ReadAllText(retardo07);
                RecebendoconteudoRet07 = conteudoRet07;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string retardo08 = this.Text + @"\FileR08.txt";
                string conteudoRet08 = System.IO.File.ReadAllText(retardo08);
                RecebendoconteudoRet08 = conteudoRet08;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica1 = caminho + @"\FileA01.txt";
                string conteudoAng01 = System.IO.File.ReadAllText(analogica1);
                Form1.RecebendoconteudoA01 = conteudoAng01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica2 = caminho + @"\FileA02.txt";
                string conteudoAng02 = System.IO.File.ReadAllText(analogica2);
                Form1.RecebendoconteudoA02 = conteudoAng02;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica3 = caminho + @"\FileA03.txt";
                string conteudoAng03 = System.IO.File.ReadAllText(analogica3);
                Form1.RecebendoconteudoA03 = conteudoAng03;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string analogica4 = caminho + @"\FileA04.txt";
                string conteudoAng04 = System.IO.File.ReadAllText(analogica4);
                Form1.RecebendoconteudoA04 = conteudoAng04;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string habiltarFuncao = caminho + @"\FileB01.txt";
                string conteudoHab00 = System.IO.File.ReadAllText(habiltarFuncao);
                Form1.RecebendoconteudoADJ00 = conteudoHab00;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string habiltarFuncao2 = caminho + @"\FileB02.txt";
                string conteudoHab01 = System.IO.File.ReadAllText(habiltarFuncao2);
                Form1.RecebendoconteudoADJ01 = conteudoHab01;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string Bimanual1 = caminho + @"\FileBM1.txt";
                string conteudoBim1 = System.IO.File.ReadAllText(Bimanual1);
                RecebendoconteudoBM1 = conteudoBim1;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string Bimanual2 = caminho + @"\FileBM2.txt";
                string conteudoBim2 = System.IO.File.ReadAllText(Bimanual2);
                RecebendoconteudoBM2 = conteudoBim2;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                using (var fs4 = new FileStream(arquivo, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs4.Read(vetor, 0, vetor.Length);

                    int indice3 = 0;
                    for (int i = 0; i < 250; i++)
                    {
                        for (int j = 0; j < 17; j++)
                        {
                            mat[i, j] = vetor[indice3];
                            indice3++;
                            switch (mat[i, j])
                            {
                                case 36:
                                    btn_aux.Image = Properties.Resources.bimanual_E7_E8;
                                    var g_100 = Graphics.FromImage(btn_aux.Image);
                                    g_100.DrawString(text100, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha100;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 250: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.botao_invisivel; break;

                                case 200: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_T; break;

                                case 201: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_H; break;

                                case 202: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.new_OR_L; break;

                                case 0: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.linhas_gridview; break;
                                case 1: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.CONTINUO; break;

                                case 3: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.CONTINUO; break;

                                case 4:
                                    btn_aux.Image = Properties.Resources.ENA_E01;
                                    var g0 = Graphics.FromImage(btn_aux.Image);
                                    g0.DrawString(text0, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha0;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 6:
                                    btn_aux.Image = Properties.Resources.ENA_E02;
                                    var g1 = Graphics.FromImage(btn_aux.Image);
                                    g1.DrawString(text1, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha1;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 8:
                                    btn_aux.Image = Properties.Resources.ENA_E03;
                                    var g2 = Graphics.FromImage(btn_aux.Image);
                                    g2.DrawString(text2, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha2;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 10:
                                    btn_aux.Image = Properties.Resources.ENA_E04;
                                    var g3 = Graphics.FromImage(btn_aux.Image);
                                    g3.DrawString(text3, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha3;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 12:
                                    btn_aux.Image = Properties.Resources.ENA_E05;
                                    var g4 = Graphics.FromImage(btn_aux.Image);
                                    g4.DrawString(text4, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha4;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 14:
                                    btn_aux.Image = Properties.Resources.ENA_E06;
                                    var g5 = Graphics.FromImage(btn_aux.Image);
                                    g5.DrawString(text5, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha5;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 16:
                                    btn_aux.Image = Properties.Resources.ENA_E07;
                                    var g6 = Graphics.FromImage(btn_aux.Image);
                                    g6.DrawString(text6, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha6;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 18:
                                    btn_aux.Image = Properties.Resources.ENA_E08;
                                    var g7 = Graphics.FromImage(btn_aux.Image);
                                    g7.DrawString(text7, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha7;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 5:
                                    btn_aux.Image = Properties.Resources.ENF_E01;
                                    var g8 = Graphics.FromImage(btn_aux.Image);
                                    g8.DrawString(text8, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha8;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 7:
                                    btn_aux.Image = Properties.Resources.ENF_E02;
                                    var g9 = Graphics.FromImage(btn_aux.Image);
                                    g9.DrawString(text9, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha9;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 9:
                                    btn_aux.Image = Properties.Resources.ENF_E03;
                                    var g10 = Graphics.FromImage(btn_aux.Image);
                                    g10.DrawString(text10, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha10;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 11:
                                    btn_aux.Image = Properties.Resources.ENF_E041;
                                    var g11 = Graphics.FromImage(btn_aux.Image);
                                    g11.DrawString(text11, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha11;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 13:
                                    btn_aux.Image = Properties.Resources.ENF_E05;
                                    var g12 = Graphics.FromImage(btn_aux.Image);
                                    g12.DrawString(text12, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha12;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 15:
                                    btn_aux.Image = Properties.Resources.ENF_E06;
                                    var g13 = Graphics.FromImage(btn_aux.Image);
                                    g13.DrawString(text13, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha13;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 17:
                                    btn_aux.Image = Properties.Resources.ENF_E07;
                                    var g14 = Graphics.FromImage(btn_aux.Image);
                                    g14.DrawString(text14, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha14;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 19:
                                    btn_aux.Image = Properties.Resources.ENF_E08;
                                    var g15 = Graphics.FromImage(btn_aux.Image);
                                    g15.DrawString(text15, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha15;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 20:
                                    btn_aux.Image = Properties.Resources.BP_E01;
                                    var g24 = Graphics.FromImage(btn_aux.Image);
                                    g24.DrawString(text24, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha24;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 22:
                                    btn_aux.Image = Properties.Resources.BP_E02;
                                    var g25 = Graphics.FromImage(btn_aux.Image);
                                    g25.DrawString(text25, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha25;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 24:
                                    btn_aux.Image = Properties.Resources.BP_E03;
                                    var g26 = Graphics.FromImage(btn_aux.Image);
                                    g26.DrawString(text26, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha26;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 26:
                                    btn_aux.Image = Properties.Resources.BP_E04;
                                    var g27 = Graphics.FromImage(btn_aux.Image);
                                    g27.DrawString(text27, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha27;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 28:
                                    btn_aux.Image = Properties.Resources.BP_E05;
                                    var g28 = Graphics.FromImage(btn_aux.Image);
                                    g28.DrawString(text28, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha28;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 30:
                                    btn_aux.Image = Properties.Resources.BP_E06;
                                    var g29 = Graphics.FromImage(btn_aux.Image);
                                    g29.DrawString(text29, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha29;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 32:
                                    btn_aux.Image = Properties.Resources.BP_E07;
                                    var g30 = Graphics.FromImage(btn_aux.Image);
                                    g30.DrawString(text30, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha30;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 34:
                                    btn_aux.Image = Properties.Resources.BP_E08;
                                    var g31 = Graphics.FromImage(btn_aux.Image);
                                    g31.DrawString(text31, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha31;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 21:
                                    btn_aux.Image = Properties.Resources.BN_E01;
                                    var g16 = Graphics.FromImage(btn_aux.Image);
                                    g16.DrawString(text16, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha16;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 23:
                                    btn_aux.Image = Properties.Resources.BN_E02;
                                    var g17 = Graphics.FromImage(btn_aux.Image);
                                    g17.DrawString(text17, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha17;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 25:
                                    btn_aux.Image = Properties.Resources.BN_E03;
                                    var g18 = Graphics.FromImage(btn_aux.Image);
                                    g18.DrawString(text18, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha18;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 27:
                                    btn_aux.Image = Properties.Resources.BN_E04;
                                    var g19 = Graphics.FromImage(btn_aux.Image);
                                    g19.DrawString(text19, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha19;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 29:
                                    btn_aux.Image = Properties.Resources.BN_E05;
                                    var g20 = Graphics.FromImage(btn_aux.Image);
                                    g20.DrawString(text20, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha20;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 31:
                                    btn_aux.Image = Properties.Resources.BN_E06;
                                    var g21 = Graphics.FromImage(btn_aux.Image);
                                    g21.DrawString(text21, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha21;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 33:
                                    btn_aux.Image = Properties.Resources.BN_E07;
                                    var g22 = Graphics.FromImage(btn_aux.Image);
                                    g22.DrawString(text22, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha22;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 35:
                                    btn_aux.Image = Properties.Resources.BN_E08;
                                    var g23 = Graphics.FromImage(btn_aux.Image);
                                    g23.DrawString(text23, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha23;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 114:
                                    btn_aux.Image = Properties.Resources.contador01;
                                    var g68 = Graphics.FromImage(btn_aux.Image);
                                    g68.DrawString(text68, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha68;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 115:
                                    btn_aux.Image = Properties.Resources.contador02;
                                    var g69 = Graphics.FromImage(btn_aux.Image);
                                    g69.DrawString(text69, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha69;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 148: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d01; break;

                                case 149: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d02; break;

                                case 150: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d03; break;

                                case 151: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d04; break;

                                case 152: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d05; break;

                                case 153: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d06; break;

                                case 154: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d07; break;


                                case 155: dataGridView1.Rows[i].Cells[j].Value = Properties.Resources.d08; break;

                                case 116:
                                    btn_aux.Image = Properties.Resources.espera01;
                                    var g70 = Graphics.FromImage(btn_aux.Image);
                                    g70.DrawString(text70, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha70;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 117:
                                    btn_aux.Image = Properties.Resources.espera02;
                                    var g71 = Graphics.FromImage(btn_aux.Image);
                                    g71.DrawString(text71, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha71;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 118:
                                    btn_aux.Image = Properties.Resources.espera03;
                                    var g72 = Graphics.FromImage(btn_aux.Image);
                                    g72.DrawString(text72, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha72;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 119:
                                    btn_aux.Image = Properties.Resources.espera04;
                                    var g73 = Graphics.FromImage(btn_aux.Image);
                                    g73.DrawString(text73, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha73;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 120:
                                    btn_aux.Image = Properties.Resources.espera05;
                                    var g74 = Graphics.FromImage(btn_aux.Image);
                                    g74.DrawString(text74, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha74;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 121:
                                    btn_aux.Image = Properties.Resources.espera06;
                                    var g75 = Graphics.FromImage(btn_aux.Image);
                                    g75.DrawString(text75, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha75;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 122:
                                    btn_aux.Image = Properties.Resources.espera07;
                                    var g76 = Graphics.FromImage(btn_aux.Image);
                                    g76.DrawString(text76, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha76;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 123:
                                    btn_aux.Image = Properties.Resources.espera08;
                                    var g77 = Graphics.FromImage(btn_aux.Image);
                                    g77.DrawString(text77, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha77;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 124:
                                    btn_aux.Image = Properties.Resources.temporizador_01;
                                    var g78 = Graphics.FromImage(btn_aux.Image);
                                    g78.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 125:
                                    btn_aux.Image = Properties.Resources.temporizador_02;
                                    var g79 = Graphics.FromImage(btn_aux.Image);
                                    g79.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 126:
                                    btn_aux.Image = Properties.Resources.temporizador_03;
                                    var g80 = Graphics.FromImage(btn_aux.Image);
                                    g80.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 127:
                                    btn_aux.Image = Properties.Resources.temporizador_04;
                                    var g81 = Graphics.FromImage(btn_aux.Image);
                                    g81.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 128:
                                    btn_aux.Image = Properties.Resources.temporizador_05;
                                    var g82 = Graphics.FromImage(btn_aux.Image);
                                    g82.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 129:
                                    btn_aux.Image = Properties.Resources.temporizador_06;
                                    var g83 = Graphics.FromImage(btn_aux.Image);
                                    g83.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 130:
                                    btn_aux.Image = Properties.Resources.temporizador_07;
                                    var g84 = Graphics.FromImage(btn_aux.Image);
                                    g84.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 131:
                                    btn_aux.Image = Properties.Resources.temporizador_08;
                                    var g85 = Graphics.FromImage(btn_aux.Image);
                                    g85.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 132:
                                    btn_aux.Image = Properties.Resources.temporizador_09;
                                    var g78_2 = Graphics.FromImage(btn_aux.Image);
                                    g78_2.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 133:
                                    btn_aux.Image = Properties.Resources.temporizador_10;
                                    var g79_2 = Graphics.FromImage(btn_aux.Image);
                                    g79_2.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 134:
                                    btn_aux.Image = Properties.Resources.temporizador_11;
                                    var g80_2 = Graphics.FromImage(btn_aux.Image);
                                    g80_2.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 135:
                                    btn_aux.Image = Properties.Resources.temporizador_12;
                                    var g81_2 = Graphics.FromImage(btn_aux.Image);
                                    g81_2.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 136:
                                    btn_aux.Image = Properties.Resources.temporizador_13;
                                    var g82_2 = Graphics.FromImage(btn_aux.Image);
                                    g82_2.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 137:
                                    btn_aux.Image = Properties.Resources.temporizador_14;
                                    var g83_2 = Graphics.FromImage(btn_aux.Image);
                                    g83_2.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 138:
                                    btn_aux.Image = Properties.Resources.temporizador_15;
                                    var g84_2 = Graphics.FromImage(btn_aux.Image);
                                    g84_2.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 139:
                                    btn_aux.Image = Properties.Resources.temporizador_16;
                                    var g85_2 = Graphics.FromImage(btn_aux.Image);
                                    g85_2.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 140:
                                    btn_aux.Image = Properties.Resources.temporizador_17;
                                    var g78_3 = Graphics.FromImage(btn_aux.Image);
                                    g78_3.DrawString(text78, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha78;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 141:
                                    btn_aux.Image = Properties.Resources.temporizador_18;
                                    var g79_3 = Graphics.FromImage(btn_aux.Image);
                                    g79_3.DrawString(text79, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha79;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 142:
                                    btn_aux.Image = Properties.Resources.temporizador_19;
                                    var g80_3 = Graphics.FromImage(btn_aux.Image);
                                    g80_3.DrawString(text80, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha80;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 143:
                                    btn_aux.Image = Properties.Resources.temporizador_20;
                                    var g81_3 = Graphics.FromImage(btn_aux.Image);
                                    g81_3.DrawString(text81, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha81;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 144:
                                    btn_aux.Image = Properties.Resources.temporizador_21;
                                    var g82_3 = Graphics.FromImage(btn_aux.Image);
                                    g82_3.DrawString(text82, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha82;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 145:
                                    btn_aux.Image = Properties.Resources.temporizador_22;
                                    var g83_3 = Graphics.FromImage(btn_aux.Image);
                                    g83_3.DrawString(text83, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha83;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 146:
                                    btn_aux.Image = Properties.Resources.temporizador_23;
                                    var g84_3 = Graphics.FromImage(btn_aux.Image);
                                    g84_3.DrawString(text84, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha84;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 147:
                                    btn_aux.Image = Properties.Resources.temporizador_24;
                                    var g85_3 = Graphics.FromImage(btn_aux.Image);
                                    g85_3.DrawString(text85, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha85;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 52:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E01;

                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_01;

                                    }
                                    var g32 = Graphics.FromImage(btn_aux.Image);
                                    g32.DrawString(text32, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha32;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 54:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_02;
                                    }
                                    var g33 = Graphics.FromImage(btn_aux.Image);
                                    g33.DrawString(text33, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha33;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 56:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_03;
                                    }

                                    var g34 = Graphics.FromImage(btn_aux.Image);
                                    g34.DrawString(text34, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha34;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 58:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_04;
                                    }

                                    var g35 = Graphics.FromImage(btn_aux.Image);
                                    g35.DrawString(text35, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha35;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 60:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_05;
                                    }
                                    var g36 = Graphics.FromImage(btn_aux.Image);
                                    g36.DrawString(text36, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha36;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 62:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_06;
                                    }
                                    var g37 = Graphics.FromImage(btn_aux.Image);
                                    g37.DrawString(text37, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha37;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 64:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_07;
                                    }
                                    var g38 = Graphics.FromImage(btn_aux.Image);
                                    g38.DrawString(text38, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha38;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 66:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNA_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_08;
                                    }
                                    var g39 = Graphics.FromImage(btn_aux.Image);
                                    g39.DrawString(text39, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha39;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 53:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_1;
                                    }
                                    btn_aux.Image = Properties.Resources.ESPECIAL_NF_1;
                                    var g40 = Graphics.FromImage(btn_aux.Image);
                                    g40.DrawString(text40, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha40;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 55:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_2;
                                    }
                                    var g41 = Graphics.FromImage(btn_aux.Image);
                                    g41.DrawString(text41, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha41;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 57:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_3;
                                    }
                                    var g42 = Graphics.FromImage(btn_aux.Image);
                                    g42.DrawString(text42, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha42;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 59:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_4;
                                    }
                                    var g43 = Graphics.FromImage(btn_aux.Image);
                                    g43.DrawString(text43, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha43;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 61:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_5;
                                    }
                                    var g44 = Graphics.FromImage(btn_aux.Image);
                                    g44.DrawString(text44, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha44;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 63:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_6;
                                    }
                                    var g45 = Graphics.FromImage(btn_aux.Image);
                                    g45.DrawString(text45, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha45;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 65:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_7;
                                    }
                                    var g46 = Graphics.FromImage(btn_aux.Image);
                                    g46.DrawString(text46, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha46;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 67:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SNF_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_NF_8;
                                    }
                                    var g47 = Graphics.FromImage(btn_aux.Image);
                                    g47.DrawString(text47, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha47;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 68:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET;
                                    }
                                    var g48 = Graphics.FromImage(btn_aux.Image);
                                    g48.DrawString(text48, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha48;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 70:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_2;
                                    }
                                    var g49 = Graphics.FromImage(btn_aux.Image);
                                    g49.DrawString(text49, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha49;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 72:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_3;
                                    }
                                    var g50 = Graphics.FromImage(btn_aux.Image);
                                    g50.DrawString(text50, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha50;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 74:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_4;
                                    }
                                    var g51 = Graphics.FromImage(btn_aux.Image);
                                    g51.DrawString(text51, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha51;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 76:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_5;
                                    }
                                    var g52 = Graphics.FromImage(btn_aux.Image);
                                    g52.DrawString(text52, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha52;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 78:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_6;
                                    }
                                    var g53 = Graphics.FromImage(btn_aux.Image);
                                    g53.DrawString(text53, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha53;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 80:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_7;
                                    }
                                    var g54 = Graphics.FromImage(btn_aux.Image);
                                    g54.DrawString(text54, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha54;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 82:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.SET_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_SET_8;
                                    }
                                    var g55 = Graphics.FromImage(btn_aux.Image);
                                    g55.DrawString(text55, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha55;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 69:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E01;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES;
                                    }
                                    var g56 = Graphics.FromImage(btn_aux.Image);
                                    g56.DrawString(text56, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha56;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 71:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E02;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_2;
                                    }
                                    var g57 = Graphics.FromImage(btn_aux.Image);
                                    g57.DrawString(text57, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha57;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 73:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E03;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_3;
                                    }
                                    var g58 = Graphics.FromImage(btn_aux.Image);
                                    g58.DrawString(text58, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha58;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 75:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E04;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_4;
                                    }
                                    var g59 = Graphics.FromImage(btn_aux.Image);
                                    g59.DrawString(text59, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha59;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 77:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E05;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_5;
                                    }
                                    var g60 = Graphics.FromImage(btn_aux.Image);
                                    g60.DrawString(text60, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha60;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 79:

                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E06;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_6;
                                    }
                                    var g61 = Graphics.FromImage(btn_aux.Image);
                                    g61.DrawString(text61, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha61;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 81:

                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E07;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_7;
                                    }
                                    var g62 = Graphics.FromImage(btn_aux.Image);
                                    g62.DrawString(text62, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha62;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 83:
                                    if (j == 16)
                                    {
                                        btn_aux.Image = Properties.Resources.RES_E08;
                                    }
                                    else
                                    {
                                        btn_aux.Image = Properties.Resources.ESPECIAL_RES_8;
                                    }
                                    var g63 = Graphics.FromImage(btn_aux.Image);
                                    g63.DrawString(text63, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha63;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 100: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_01_NA;
                                    var g86 = Graphics.FromImage(btn_aux.Image);
                                    g86.DrawString(text86, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha86;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 101: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_01_NF;
                                    var g87 = Graphics.FromImage(btn_aux.Image);
                                    g87.DrawString(text87, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha87;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 102: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_02_NA;
                                    var g88 = Graphics.FromImage(btn_aux.Image);
                                    g88.DrawString(text88, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha88;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 103: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_02_NF;
                                    var g89 = Graphics.FromImage(btn_aux.Image);
                                    g89.DrawString(text89, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha89;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 104: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_03_NA;
                                    var g90 = Graphics.FromImage(btn_aux.Image);
                                    g90.DrawString(text90, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha90;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 105: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_03_NF;
                                    var g91 = Graphics.FromImage(btn_aux.Image);
                                    g91.DrawString(text91, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha91;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 106: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_04_NA;
                                    var g92 = Graphics.FromImage(btn_aux.Image);
                                    g92.DrawString(text92, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha92;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 107: // CA NF
                                    btn_aux.Image = Properties.Resources.CONTATO_04_NF;
                                    var g93 = Graphics.FromImage(btn_aux.Image);
                                    g93.DrawString(text93, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha93;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 108: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_05_NA;
                                    var g94 = Graphics.FromImage(btn_aux.Image);
                                    g94.DrawString(text94, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha94;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 109: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_06_NA;
                                    var g95 = Graphics.FromImage(btn_aux.Image);
                                    g95.DrawString(text95, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha95;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 110: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_07_NA;
                                    var g96 = Graphics.FromImage(btn_aux.Image);
                                    g96.DrawString(text96, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha96;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 111: // CA NA
                                    btn_aux.Image = Properties.Resources.CONTATO_08_NA;
                                    var g97 = Graphics.FromImage(btn_aux.Image);
                                    g97.DrawString(text97, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha97;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 112: // CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_09_SET;
                                    var g98 = Graphics.FromImage(btn_aux.Image);
                                    g98.DrawString(text98, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha98;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 113:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_09_RES;
                                    var g99 = Graphics.FromImage(btn_aux.Image);
                                    g99.DrawString(text99, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha99;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 40:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_10_SET;
                                    var g104 = Graphics.FromImage(btn_aux.Image);
                                    g104.DrawString(text104, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha104;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 41:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_10_RESET;
                                    var g105 = Graphics.FromImage(btn_aux.Image);
                                    g105.DrawString(text105, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha105;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 42:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_11_SET;
                                    var g106 = Graphics.FromImage(btn_aux.Image);
                                    g106.DrawString(text106, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha106;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 43:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_11_RESET;
                                    var g107 = Graphics.FromImage(btn_aux.Image);
                                    g107.DrawString(text107, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha107;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 44:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_12_SET;
                                    var g108 = Graphics.FromImage(btn_aux.Image);
                                    g108.DrawString(text108, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha108;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 45:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_12_RESET;
                                    var g109 = Graphics.FromImage(btn_aux.Image);
                                    g109.DrawString(text109, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha109;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 46:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_13_SET;
                                    var g110 = Graphics.FromImage(btn_aux.Image);
                                    g110.DrawString(text110, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha110;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 47:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_13_RESET;
                                    var g111 = Graphics.FromImage(btn_aux.Image);
                                    g111.DrawString(text111, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha111;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 48:// CA SET
                                    btn_aux.Image = Properties.Resources.CONTATO_14_SET;
                                    var g112 = Graphics.FromImage(btn_aux.Image);
                                    g112.DrawString(text112, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha112;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 49:// CA RESET
                                    btn_aux.Image = Properties.Resources.CONTATO_14_RESET;
                                    var g113 = Graphics.FromImage(btn_aux.Image);
                                    g113.DrawString(text113, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha113;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 156:
                                    btn_aux.Image = Properties.Resources.ANG_E01;
                                    var g64 = Graphics.FromImage(btn_aux.Image);
                                    g64.DrawString(text64, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha64;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 157:
                                    btn_aux.Image = Properties.Resources.ANG_E02;
                                    var g65 = Graphics.FromImage(btn_aux.Image);
                                    g65.DrawString(text65, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha65;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;

                                    break;
                                case 158:
                                    btn_aux.Image = Properties.Resources.ANG_E03;
                                    var g66 = Graphics.FromImage(btn_aux.Image);
                                    g66.DrawString(text66, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha66;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 159:
                                    btn_aux.Image = Properties.Resources.ANG_E04;
                                    var g67 = Graphics.FromImage(btn_aux.Image);
                                    g67.DrawString(text67, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha67;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 38:
                                    btn_aux.Image = Properties.Resources.HAB_F1;
                                    var g102 = Graphics.FromImage(btn_aux.Image);
                                    g102.DrawString(text102, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha102;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;

                                case 39:
                                    btn_aux.Image = Properties.Resources.HAB_F2;
                                    var g103 = Graphics.FromImage(btn_aux.Image);
                                    g103.DrawString(text103, new Font("Calibri", 3, FontStyle.Bold), Brushes.DarkSlateGray, new PointF(0, -3));
                                    dataGridView1.Rows[i].Cells[j].ToolTipText = linha103;
                                    dataGridView1.Rows[i].Cells[j].Value = btn_aux.Image;
                                    break;
                            }
                        }
                    }
                }
                dataGridView1.Visible = true;
                groupBox13.Visible = true;
                groupBox12.Visible = true;
                button1.Visible = true;
                gb_tabela.Visible = true;
                btn_abrir.Visible = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Linha = e.RowIndex;
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                linha.HeaderCell.ContextMenuStrip = contextMenuStrip1;
            }
        }

    }
}