using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGCP96_V1._1_.Domain
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao()
        {
            
        }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }
    }
}
