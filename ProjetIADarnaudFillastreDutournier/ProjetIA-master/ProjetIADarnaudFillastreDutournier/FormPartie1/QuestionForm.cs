using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPartie1
{
    public partial class QuestionForm : Form
    {
        public static int compteurQ = 1;
        public static int cptPage = 1;


        private List<Question> _questions;

        public QuestionForm(List<Question> questions)
        {
            InitializeComponent();
            _questions = questions;
        }
               
        private void EcritureQuestion() //cette fonction doit être dans la classe Question, puis on l'appelle dans
            //le Click suivant et dans initialise components
        {
            string name = "LQuestion" + compteurQ.ToString();
            this.LQuestion1.Text = name;
            compteurQ++;
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            cptPage--;
            //retourner à la question précedente
        }
        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment Valider et Quitter ?";
            if (MessageBox.Show(message, "Application Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //envoyer les infos pour les sérialiser
                Application.Exit();
            }
        }
        private void btn_suivant_Click(object sender, EventArgs e)
        {
            cptPage++;
            //mettre les questions suivantes
            if (cptPage == 4)
            {
                btn_suivant.Text = "Fini!";
            }
         }

      }
}
