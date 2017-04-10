using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Utils
{
    public class MultimeConfiguratii
    {
        public List<Configuratie> configurations;
        public int index;

        public MultimeConfiguratii(List<Configuratie> _configs, int _index)
        {
            this.configurations = _configs;
            this.index = _index;

        }
    }
}
