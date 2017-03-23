using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP1
{
    class SalarieException:Exception
    {
        public SalarieException(Salarie salaire) : base(salaire.ToString())
        {

        }
        public override string ToString()
        {
            return "AAAAAAAaaaaaaarGgggggghh";
        }
    }
}
