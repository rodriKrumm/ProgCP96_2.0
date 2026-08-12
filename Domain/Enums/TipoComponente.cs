using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGCP96_V1._1_.Domain.Enums
{
    internal enum TipoComponente
    {
          //EntradaNA         //EntradaNF          //BordaPosi         //BordaNega
        ContatoNA01 = 4,      ContatoNF01 = 5,     BordaP01 = 20,      BordaN01 = 21,
        ContatoNA02 = 6,      ContatoNF02 = 7,     BordaP02 = 22,      BordaN02 = 23,
        ContatoNA03 = 8,      ContatoNF03 = 9,     BordaP03 = 24,      BordaN03 = 25,
        ContatoNA04 = 10,     ContatoNF04 = 11,    BordaP04 = 26,      BordaN04 = 27,
        ContatoNA05 = 12,     ContatoNF05 = 13,    BordaP05 = 28,      BordaN05 = 29,
        ContatoNA06 = 14,     ContatoNF06 = 15,    BordaP06 = 30,      BordaN06 = 31,
        ContatoNA07 = 16,     ContatoNF07 = 17,    BordaP07 = 32,      BordaN07 = 33,
        ContatoNA08 = 18,     ContatoNF08 = 19,    BordaP08 = 34,      BordaN08 = 35,


        //SaídaNA           //SaídaNF           //SET               //RESET
        SaidaNA01 = 52,     SaidaNF01 = 53,     SET_01 = 68,        RES_01 = 69,
        SaidaNA02 = 54,     SaidaNF02 = 55,     SET_02 = 70,        RES_02 = 71,
        SaidaNA03 = 56,     SaidaNF03 = 57,     SET_03 = 72,        RES_03 = 73,
        SaidaNA04 = 58,     SaidaNF04 = 59,     SET_04 = 74,        RES_04 = 75,
        SaidaNA05 = 60,     SaidaNF05 = 61,     SET_05 = 76,        RES_05 = 77,
        SaidaNA06 = 62,     SaidaNF06 = 63,     SET_06 = 78,        RES_06 = 79,
        SaidaNA07 = 64,     SaidaNF07 = 65,     SET_07 = 80,        RES_07 = 81,
        SaidaNA08 = 66,     SaidaNF08 = 67,     SET_08 = 82,        RES_08 = 83,


        //Aux.Analo             //Aux.Conta            //Espera            
        Analogica01 = 156,      Contador01 = 114,      Espera01 = 116,      
        Analogica02 = 157,      Contador02 = 115,      Espera02 = 117,      
        Analogica03 = 158,      ZerarCont01 = 98,      Espera03 = 118,      
        Analogica04 = 159,      ZerarCont02 = 99,      Espera04 = 119,      
                                                       Espera05 = 120,      
                                                       Espera06 = 121, 
                                                       Espera07 = 122, 
                                                       Espera08 = 123,


        //TemporizadorDecimos     //TemporizadorSegundos    //TemporizadorMinutos                 
        Temporizador01 = 124,     Temporizador09 = 132,     Temporizador17 = 140,       
        Temporizador02 = 125,     Temporizador10 = 133,     Temporizador18 = 141,       
        Temporizador03 = 126,     Temporizador11 = 134,     Temporizador19 = 142,       
        Temporizador04 = 127,     Temporizador12 = 135,     Temporizador20 = 143,       
        Temporizador05 = 128,     Temporizador13 = 136,     Temporizador21 = 144,       
        Temporizador06 = 129,     Temporizador14 = 137,     Temporizador22 = 145,       
        Temporizador07 = 130,     Temporizador15 = 138,     Temporizador23 = 146,       
        Temporizador08 = 131,     Temporizador16 = 139,     Temporizador24 = 147,


        //Display           //ContatAuxiliar      //ContatAuxiliar    //ContatAuxiliar
        Dispay01 = 148,    ContatoAuxNA01 = 100,   ContatoAuxNF01 = 101,   ContatoAuxSet01 = 112,
        Dispay02 = 149,    ContatoAuxNA02 = 102,   ContatoAuxNF02 = 103,   ContatoAuxSet02 = 40,
        Dispay03 = 150,    ContatoAuxNA03 = 104,   ContatoAuxNF03 = 105,   ContatoAuxSet03 = 42,
        Dispay04 = 151,    ContatoAuxNA04 = 106,   ContatoAuxNF04 = 107,   ContatoAuxSet04 = 44,
        Dispay05 = 152,    ContatoAuxNA05 = 108,   ContatoAuxNF05 = 109,   ContatoAuxSet05 = 46,
        Dispay06 = 153,    ContatoAuxNA06 = 110,   ContatoAuxNF06 = 111,   ContatoAuxSet06 = 48,
        Dispay07 = 154,                           
        Dispay08 = 155,     


        //contato
        ContatoAuxRes01 = 113,   Bimanual01 = 36,      Habilitar01 = 38,
        ContatoAuxRes02 = 41,    Bimanual02 = 37,      Habilitar02 = 39,
        ContatoAuxRes03 = 43,
        ContatoAuxRes04 = 45,
        ContatoAuxRes05 = 47,
        ContatoAuxRes06 = 49,
    }

}
