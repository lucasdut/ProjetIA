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
    public partial class MainForm : Form
    {
        private List<Question> _questions;
        public MainForm()
        {
            InitializeComponent();
            _questions = new List<Question>();
            _questions.Add(new Question("Q1", "Matt", "Québec"));
        }
        private void btn_commencer_Click(object sender, EventArgs e)
        {
            QuestionForm f2 = new QuestionForm(_questions);
            f2.Show();
        }

    }
}
