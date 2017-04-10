using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Utils
{
    public class Parser
    {
        GIC gram;

        public Parser(GIC _gram) {
            gram = _gram;

            //numerotam regulile
            for(int i=0; i< gram.reguli_productie.Count;i++)
            {
                gram.reguli_productie[i].parserIndex = i;
            }
        }

        public MultimeConfiguratii closure(MultimeConfiguratii J)
        {

            return J;
        }

        //primeste un sir apartinand (Vt reunit Vn)* , intoarce first de el
        public List<string> First(string configuratie)
        {
            //initializing variables
            List<string> terminale = new List<String>();
            bool[] folosit = new bool[this.gram.reguli_productie.Count];

            //executing method
            /*Helpers.getFirst(configuratie,
                folosit,
                terminale,
                this.gram);
            */
            //scoatem duplicatele
            return terminale.Distinct().ToList();
        }


    }
}


/*
if (!String.IsNullOrEmpty(configuratie) && this.gram.reguli_productie.Count > 0)
{
    for(int i=0;i<configuratie.Length;i++)
    {
        //daca este neterminal
        if(this.gram.terminale.Any(x => x ==( configuratie[i].ToString() )) )
        {
            terminale.Add(configuratie[i].ToString() );
            break;
        }
        else
        {
            //vedem daca este necesar sa mergem si la urmatorul caracter
            bool lambdaProdExistent = false;
                        
            //memoram productiile prin care am mai trecut
            bool[] folosit = new bool[this.gram.reguli_productie.Count];

            //selectam toate productiile care pleaca de la neterminalul curent
            List<Regula> reguliFirst = this.gram.reguli_productie.Where(x =>
                                                    x.neterminal == configuratie[i].ToString()).ToList();
            int index = 0;

            foreach( Regula r in reguliFirst)
            {
                r.firstIndex = 0;
                folosit[r.parserIndex] = false;
            }

            while (index < reguliFirst.Count)
            {
                Regula r = reguliFirst[index];

                //daca primul este un terminal
                if(gram.terminale.Any(x => x == (r.productie[0].ToString())))
                {
                    terminale.Add(r.productie[0].ToString());
                }
                else
                {

                }

            }
        }
    }
}
*/
