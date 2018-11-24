using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Partie_1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //créer des listes vide
            List<Question> listeQuestions = new List<Question>(); 
            List<Reponse> listeReponses = new List<Reponse>();
            List<BonneReponse> listeBonne = new List<BonneReponse>();

           //    listeQuestions.Add(new Question() { Intitule = "bla" });
           //    listeQuestions.Add(new Question() { Intitule = "Première question" }); //ajoute un élément dans la liste
           //    listeQuestions.Add(new Question() { Intitule = "Seconde question" });
            //   listeReponses.Add(new Reponse() { Rep = "" });
            //   listeReponses.Add(new Reponse() { Rep = "Bonne réponse question 1" });
            //   listeReponses.Add(new Reponse() { Rep = "réponse 2" }); 
            //   listeBonne.Add(new BonneReponse() { BonneRep = "" });
            //   listeBonne.Add(new BonneReponse() { BonneRep = "Bonne réponse question 1" });

            //permet de vérifier si la listeQuestion fonctionne
            /* foreach (Question q in listeQuestions)
                Console.WriteLine(q); 
            */

            //pour la sérialisation
           /* StreamWriter writerQuestion = new StreamWriter("questions.xml"); //créer un fichier xml
            new XmlSerializer(typeof(List<Question>)).Serialize(writerQuestion, listeQuestions); //entre la liste des questions dans le fichier xml
            writerQuestion.Close(); //arrête d'écrire dans le fichier xml

            StreamWriter writerReponse = new StreamWriter("reponses.xml");
            new XmlSerializer(typeof(List<Reponse>)).Serialize(writerReponse, listeReponses);
            writerReponse.Close();

            StreamWriter writerBonne = new StreamWriter("bonneReponses.xml"); 
            new XmlSerializer(typeof(List<BonneReponse>)).Serialize(writerBonne, listeBonne); 
            writerBonne.Close(); 
            */

            //pour la désérialisation 
            XmlSerializer xs = new XmlSerializer(typeof(List<Question>));
            using (Stream ins = File.Open("questions.xml", FileMode.Open))
                foreach (Question o in (List<Question>)xs.Deserialize(ins))
                    listeQuestions.Add(o);

            XmlSerializer xsRep = new XmlSerializer(typeof(List<Reponse>));
            using (Stream insRep = File.Open("reponses.xml", FileMode.Open))
                foreach (Reponse r in (List<Reponse>)xsRep.Deserialize(insRep))
                    listeReponses.Add(r);

            XmlSerializer xsBonne = new XmlSerializer(typeof(List<BonneReponse>));
            using (Stream insBonne = File.Open("bonneReponses.xml", FileMode.Open))
                foreach (BonneReponse b in (List<BonneReponse>)xsBonne.Deserialize(insBonne))
                    listeBonne.Add(b);

            //permet de vérifier que la désérialisation fonctionne
            /*
             foreach (Question q in listeQuestions)
                 Console.WriteLine(q);
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(listeQuestions, listeReponses, listeBonne));
        }
    }
}
