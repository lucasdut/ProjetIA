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
    public partial class FPartie1 : Form
    {
        public static int compteurQ = 1;
        public static int cptPage = 1;

        public FPartie1()
        {
            InitializeComponent();
        }
        
        
        private void EcritureQuestion()
        {
            string name = "LQuestion" + compteurQ.ToString();

            this.LQuestion1.Text = name;

            compteurQ++;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BSuivant_Click(object sender, EventArgs e)
        {
            cptPage++;
            //mettre les questions suivantes
            if (cptPage == 7)
            {
                this.BSuivant.Text = "Terminer";
            }

        }
    }
}
