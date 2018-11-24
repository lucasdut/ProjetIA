using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1
{
    public class BonneReponse
    {
        public string BonneRep { get; set; }
        public BonneReponse() { }
        public override string ToString()
        {
            return BonneRep.ToString();
        }
    }
}
