using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie_1
{
    public partial class Form1 : Form
    {
        private List<Question> _questions;
        private List<Reponse> _reponses;
        private List<BonneReponse> _bonnes;
        private int points;
      //  public bool Checked { get; set; }
        public Form1() { }
        public Form1(List<Question> questions, List<Reponse> reponses, List<BonneReponse> bonnes)
        {
            InitializeComponent();
            _questions = questions;
            _reponses = reponses;
            _bonnes = bonnes;
            //tbQuestion.Text = "Bienvenue sur votre test d'IA !!";     
        }

        private void groupBox1_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Click(object sender, EventArgs e)
        {
           /* foreach (Question q in _questions)
            {*/
            for(int i=0; i<6; i++)
            { 
                tbQuestion.Text = _questions[i].ToString();
                for(int j=0; j<8; j=j+4)
                {
                    rbRep1.Text = _reponses[j].ToString();
                    rbRep2.Text = _reponses[j+1].ToString();
                    rbRep3.Text = _reponses[j+2].ToString();
                    rbRep4.Text = _reponses[j+3].ToString();
                }
            }
          //  tbQuestion.Text = _questions[1].ToString();
          //  rbRep1.Text = _reponses[1].ToString();
          //  rbRep2.Text = _reponses[2].ToString();
          //  rbRep3.Text = _reponses[3].ToString();
          //  rbRep4.Text = _reponses[4].ToString();
        }
        private void BtnVerifier_Click(object sender, EventArgs e)
        {
            string repFinale = (rbRep1.Checked) ? rbRep1.Text : rbRep2.Text;
            if (repFinale == _bonnes[0].ToString())
            {
                MessageBox.Show("Bonne réponse ! ");
                points++;
            }
            
        }

   
        /*  private void rbRep1_CheckedChanged(object sender, EventArgs e)
 {
     // Executed when any radio button is changed.
     // ... It is wired up to every single radio button.
     // Search for first radio button in GroupBox.
     string result1 = null;
     foreach (Control control in this.groupBox1.Controls)
     {
         if (control is RadioButton)
         {
             RadioButton radio = control as RadioButton;
             if (radio.Checked)
             {
                 result1 = radio.Text;
             }
         }
     }
     this.Text = result1;
 }*/
    }
}
