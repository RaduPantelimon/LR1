using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Utils
{
    public class Helpers
    {

        public static List<ElementFirst> getFirstsForGIC(GIC gic)
        {
            //initializare variabile
            List<ElementFirst> rezultat = new List<ElementFirst>();

            //adaugare rezultate pt terminale
            foreach(string term in gic.terminale)
            {
                rezultat.Add(new ElementFirst(term, new List<string> { term }));
            }
            //adaugare rezultate pt neterminale
            foreach (string neterm in gic.neterminale)
            {
                rezultat.Add(new ElementFirst(neterm, new List<string>()));
            }

            //adaugam rez pt lambda
            rezultat.Add(new ElementFirst(Constants.Lambda, new List<string> { Constants.Lambda }));

            bool actualizare = true;

            //cat timp inca actualizam matricea
            while(actualizare)
            {

                actualizare = false;
                foreach (Regula r in gic.reguli_productie)
                {

                }

            }

            return rezultat;
        }

        public static void getFirstsForString(string ip,
                                         List<ElementFirst> rezPrecedente,
                                         ElementFirst rezPartial)
        {
            if (String.IsNullOrEmpty(ip)) return;

            bool containsLambda = rezPartial.rezultat.Any(x => x == Constants.Lambda);
            bool isEmpty = rezPartial.rezultat.Count == 0;

            if(!isEmpty && !containsLambda)
            {
                //we found all possible solutions for First(1)
                return;
            }
            if(isEmpty || containsLambda)
            {
                //we can still add new elements to this solution
                string currentElement = ip.Substring(0, 1);
                ElementFirst rezultatCurent = rezPrecedente.Where(x => x.x_string == currentElement).FirstOrDefault();
                if(rezultatCurent != null && rezultatCurent.rezultat.Count > 0)
                {
                    //removing lambda
                    rezPartial.rezultat.Remove(Constants.Lambda);
                    //adding mewly found results
                    rezPartial.rezultat.AddRange(rezultatCurent.rezultat);

                    //getting the values for the next element
                    getFirstsForString(ip.Substring(1), rezPrecedente, rezPartial);

                }
            }
        }
    }
}
