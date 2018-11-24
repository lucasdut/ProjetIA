using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1
{
    public class Reponse
    {
        public string Rep { get; set; }
        public Reponse() { }
        public override string ToString()
        {
            return Rep.ToString();
        }
    }

}
