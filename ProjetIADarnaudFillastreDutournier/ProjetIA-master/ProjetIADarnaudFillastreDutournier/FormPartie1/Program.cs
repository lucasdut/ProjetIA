using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace FormPartie1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Question q = new Question("titre", "rep1", "rep2");

            XmlSerializer xs = new XmlSerializer(typeof(Question));
            using (StreamWriter wr = new StreamWriter("question.xml"))
            {
                xs.Serialize(wr, q);
            }*/
            
            //liste des questions et leurs réponses associées
            List<Question> questions = new List<Question>();
            questions.Add(new Question("Enoncé 1", " ", " "));
            questions.Add(new Question("Enoncé 2", " ", " " ));
            
            //pour la sérialisation
            StreamWriter writer = new StreamWriter("questions.xml");
            new XmlSerializer(typeof(List<Question>)).Serialize(writer, questions);
            writer.Close();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
