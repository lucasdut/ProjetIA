using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FormPartie1
{
    public class Question
    {
        private static int compteur;
        private int id { get; set; }
        public string intitule { get; set; }
        public string rep1 { get; set; }
        public string rep2 { get; set; }

        public Question() { }
        public Question(string intitule, string rep1, string rep2)
        {
            compteur++;
            this.id=compteur;
            this.intitule = intitule;
            this.rep1 = rep1;
            this.rep2 = rep2;        
        }

        public void choixQuestion()
        {
            Random r = new Random();
            int n = r.Next(compteur);
        }
    }
}
