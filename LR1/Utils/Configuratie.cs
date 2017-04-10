using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Utils
{
    public class Configuratie
    {
        string neterminal;
        string left;
        string right;
        string lookAhead;

        public Configuratie(string _left,
            string _right,
            string _lookahead)
        {

            this.left = _left;
            this.right = _right;
            this.lookAhead = _lookahead;
        }
    }
}
