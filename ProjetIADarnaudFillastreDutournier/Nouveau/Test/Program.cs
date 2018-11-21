using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Question> listeQuestions = new List<Question>(); //créer une liste de question vide
            listeQuestions.Add(new Question() { Intitule = "Première question" }); //ajoute un élément dans la liste
            //permet de vérifier si la listeQuestion fonctionne
            /* foreach (Question q in listeQuestions)
                Console.WriteLine(q); 
            */
            //pour la sérialisation
           /* StreamWriter writer = new StreamWriter("questions.xml"); //créer un fichier xml
            new XmlSerializer(typeof(List<Question>)).Serialize(writer, listeQuestions); //entre la liste des questions dans le fichier xml
            writer.Close(); //arrête d'écrire dans le fichier xml
            */
            //pour la désérialisation 
            XmlSerializer xs = new XmlSerializer(typeof(List<Question>));
            using (Stream ins = File.Open("questions.xml", FileMode.Open))
            foreach (Question o in (List<Question>)xs.Deserialize(ins))
                  listeQuestions.Add(o);
            //permet de vérifier que la désérialisation fonctionne
            /*
             foreach (Question q in listeQuestions)
                 Console.WriteLine(q);
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(listeQuestions));

        }
    }
}
