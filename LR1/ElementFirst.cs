using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{

    //folosit in calculul a First(1)
    public class ElementFirst
    {
        public ElementFirst(string _x_string, List<string> _rezultat)
        {
            x_string = _x_string;
            rezultat = _rezultat;
        }

        public string x_string;

        //o sa fie o multime de terminale
        public List<string> rezultat;
    }
}
