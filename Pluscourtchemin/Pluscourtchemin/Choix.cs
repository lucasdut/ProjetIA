using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluscourtchemin
{
    public partial class Choix : Form
    {
        public Choix()
        {
            InitializeComponent();
        }

        private void buttonQuestionsCours_Click(object sender, EventArgs e)
        {
            Application.Run(new Dijkstra());
        }

        private void buttonAlgoDijkstra_Click(object sender, EventArgs e)
        {
            Application.Run(new Arbre());
        }
    }
}
