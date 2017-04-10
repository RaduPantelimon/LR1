using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Utils
{
    public class Helpers
    {
        //will return true if we found a lambda production accross
        public static bool getFirst(string text,
            //List<Regula> reguliFirst,
             bool[] folosit,
             List<string> terminale,
             GIC gram
            )
        {
            if (String.IsNullOrEmpty(text)) return true;
           
            string item = text[0].ToString();
            //daca primul este un terminal
            if (gram.terminale.Any(x => x == (item.ToString())))
            {
                //terminale.Add(r.productie[0].ToString());
                terminale.Add(item);
                return false;
            }

            List<Regula> newRules = gram.reguli_productie.Where(x => x.neterminal == item).ToList();
            bool gotLambda = false;
            for(int i=0;i<newRules.Count;i++)
            {
                if (newRules[i].productie == Constants.Lambda)
                {
                    bool foundLambda = getFirst(text.Substring(1), //ne uitam aici in continuare pentru first
                                                //reguliFirst,
                           folosit,
                           terminale,
                           gram);
                    if (foundLambda) gotLambda = true;
                }

                if (!folosit[newRules[i].parserIndex])
                {
                    folosit[newRules[i].parserIndex] = true;
                    if (newRules[i].productie != Constants.Lambda)
                    {
                        getFirst(newRules[i].productie, //ne uitam aici in continuare pentru first
                            //reguliFirst,
                            folosit,
                            terminale,
                            gram);
                    }
                    else
                    {
                        getFirst(text.Substring(1), //ne uitam aici in continuare pentru first
                            //reguliFirst,
                            folosit,
                            terminale,
                            gram);
                    }
                }
            }
            return;

        }
    }
}
