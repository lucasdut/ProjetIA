using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Question
    {
        public string Intitule { get; set; }
        public Question() { }
        public override string ToString()
        {
            return Intitule.ToString();
        }
    }
}
