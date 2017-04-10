using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Utils
{
    public class Regula
    {
        public string neterminal;
        public string productie;


        //variabila folosita in algoritmul de calcul first
        public int firstIndex;

        //index folosit pt nr de ordine al regulii in cadrul parserului
        public int parserIndex;

        //neterminal Index
        public int neterminalIndex;

        public Regula (string _neterminal, string _productie)
        {
            this.neterminal = _neterminal;
            this.productie = _productie;

        }
    }
}
