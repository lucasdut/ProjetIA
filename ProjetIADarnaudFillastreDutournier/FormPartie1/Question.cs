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
    class Question
    {
        private static int compteur;
        private int id;
        private string intitule;
        private string rep1;
        private string rep2;
        private string rep3;
        private string rep4;
        private string rep5;
        private string rep6;
        public static StreamWriter wr = new StreamWriter("questions.xml");
        public static StreamReader re = new StreamReader("questions.xml");
        public static XmlSerializer xs = new XmlSerializer(typeof(Question));



        public Question(string intitule, string rep1, string rep2, string rep3,string rep4, string rep5, string rep6)
        {
            compteur++;
            this.id=compteur;
            this.intitule = intitule;
            this.rep1 = rep1;
            this.rep2 = rep2;
            this.rep3 = rep3;
            this.rep4 = rep4;
            this.rep5 = rep5;
            this.rep6 = rep6;            
        }

        public void SerializeQuestion()
        {            
            using (wr)
            {
                xs.Serialize(wr, this);
            }
        }
        public void DeserializeQuestion()
        {
            
            using (re)
            {
                Question q = xs.Deserialize(re) as Question ;
            }
        }
        public void choixQuestion()
        {
            Random r = new Random();
            int n = r.Next(compteur);

        }
    }
}
