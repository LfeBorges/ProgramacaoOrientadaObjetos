using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private int dtValidade;  
        private int dtFabricacao;
        private int lote;

        public int DtValidade
        {
            get { return dtvalidade; }
            set { dtvalidade = value; }
        }
        public int DtFabricacao
        {
            get { return dtfabricacao; }
            set { dtfabricacao = value; }
        }
        
        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        
        
    }
}