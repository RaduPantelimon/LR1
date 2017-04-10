using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Utils
{
    public class GIC
    {
        public List<string> terminale;
        public List<string> neterminale;
        public string Start;
        public List<Regula> reguli_productie;

        public GIC(List<string> _terminale,
            List<string> _neterminale,
            string _Start,
            List<Regula> _reguli_productie)
        {
            terminale = _terminale;
            neterminale = _neterminale;
            Start = _Start;
            reguli_productie = _reguli_productie;
        }
        public GIC()
        {
            terminale = null;
            neterminale = null;
            Start = "";
            reguli_productie = null;
        }

        public static GIC extinde(GIC original)
        {
            GIC gramExtinsa = new Utils.GIC();

           
           
            gramExtinsa.Start = Constants.Start;

            gramExtinsa.neterminale = new List<String>(original.neterminale);
            gramExtinsa.neterminale.Add(Constants.Start);

            gramExtinsa.reguli_productie = new List<Regula>(original.reguli_productie);
            gramExtinsa.reguli_productie.Add(new Regula(    Constants.Start, original.Start + Constants.Finish));

            gramExtinsa.terminale = new List<String>(original.terminale);
            gramExtinsa.terminale.Add(Constants.Finish);



            return gramExtinsa;
        }


       
    }
}
