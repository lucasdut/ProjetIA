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


namespace Pluscourtchemin
{
    public partial class Dijkstra : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;
        static public SearchTree g = new SearchTree();
        static private int compteurCorrectsNodes;
        static private int compteurCorrectsNodesObjectif;
        static private bool check;
        static private List<string> fermesMain = new List<string>();
        static private List<string> ouvertsMain = new List<string>();
        static private int compteurEtapes = 0;
        
        public Dijkstra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            matrice[0, 1] = 3;   matrice[1, 0] = 3;
            matrice[0, 2] = 5;      matrice[2, 0] = 5;
            matrice[0, 3] = 7;      matrice[3, 0] = 7;
            matrice[1, 4] = 8;      matrice[4, 1] = 8;
            matrice[2, 4] = 3;      matrice[4, 2] = 3;
            matrice[4, 5] = 7;      matrice[5, 4] = 7;
            matrice[5, 6] = 4;      matrice[6, 5] = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);            
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);
            
            Node2 N1 = N0;
            //affichage
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBox1.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            g.GetSearchTree(treeView1);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length) { strnbnoeuds = strnbnoeuds + ligne[i];
                i++; 
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a la structure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] !=' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));            

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
        }
        //fonction qui transforme une liste de noeuds en liste de string
        private List<string> transfoListesNoeudsEnString(List<GenericNode> liste)
        {
            List < string > transfo = new List<string>();
            foreach(GenericNode node in liste)
            {
                transfo.Add(node.ToString());
            }
            return transfo;
        }
        
        //bouton pour enlever un noeud
        private void button7_Click(object sender, EventArgs e)
        {
            treeView2.SelectedNode.Remove();
        }
        //bouton qui change le texte d'un noeud
        private void buttonEdition_Click(object sender, EventArgs e)
        {
            treeView2.SelectedNode.Text = textboxNoeudAjoute.Text;
        }

        //bouton qui lance la comparaison des deux arbres
        private void buttonVerif_Click(object sender, EventArgs e)
        {
            CheckRecursive();
            if((compteurCorrectsNodes == compteurCorrectsNodesObjectif) && (compteurCorrectsNodes != 0))
            {
                MessageBox.Show("Bien joué!");
            }
        }
        //Fonction qui sert à comparer les deux arbres
        private void CheckRecursive()
        {
            TreeNodeCollection nodes = treeView1.Nodes;
            TreeNodeCollection nodesToCheck = treeView2.Nodes;
            if(treeView1.GetNodeCount(false) != treeView2.GetNodeCount(false))
            {
                MessageBox.Show("Erreur");
            }
            else
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    SubRecursive(nodes[i], nodesToCheck[i]);
                }
            }
            
        }

        /* Appelée par CheckRecursive */
        private void SubRecursive(TreeNode treeNodeAlgo, TreeNode treeNodeToCheck)
        {
            if (treeNodeAlgo.Text == treeNodeToCheck.Text) { compteurCorrectsNodes++; }
            compteurCorrectsNodesObjectif++;

            if (treeNodeAlgo.Nodes.Count== treeNodeToCheck.Nodes.Count)
            {
                for (int j = 0; j < treeNodeAlgo.Nodes.Count; j++)
                {
                    SubRecursive(treeNodeAlgo.Nodes[j], treeNodeToCheck.Nodes[j]);
                }
            }
            else
            {
                MessageBox.Show("Aie, je crois que tu t'es trompé3..");
            }
            
        }
        //ajouter un noeud à l'arbre
        private void button9_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(textboxNoeudAjoute.Text);
            treeView2.Nodes.Add(node);
        }
        //ajouter un noeud fils à un noeud
        private void button10_Click(object sender, EventArgs e)
        {
            string a = comboBox1.SelectedItem.ToString();
            TreeNode node = new TreeNode(a);

            if (a !="") {treeView2.SelectedNode.Nodes.Add(node); }
            else {treeView2.Nodes.Add("nouveau noeud");}
            
        }

       
        private void verificationListes(List<string> Liste1, List<string> Liste2) //mettre un "flag" ici pour checker

        {
            bool resultat = false; 
            if (Liste1.Count == Liste2.Count)
            {
                for(int i = 0; i < Liste1.Count; i++)
                {
                    if (Liste1[i] == Liste2[i])
                    {
                        resultat = true;
                    }
                    else
                    {
                        resultat = false;
                        break;
                    }
                }
            }
            if (resultat == true)
            {
                MessageBox.Show("C'est Ok!");
            }
            else
            {
                MessageBox.Show("Il y a des erreurs.");
            }
            
        }
        //bouton qui sert à lancer la comparaison
        private void button6_Click(object sender, EventArgs e)
        {
            //On remplit la liste de fermés
            string s = textBox3.Text;            
            string[] noeuds1 = s.Split(',');
            foreach (string noeud in noeuds1)
            {
                fermesMain.Add(noeud);
            }

            //On remplit la liste des ouverts
            string t = textBox4.Text;
            string[] noeuds2 = t.Split(',');
            foreach (string noeud in noeuds2)
            {
                ouvertsMain.Add(noeud);
            }
            List<string> ouvertsAlgoEnString = transfoListesNoeudsEnString(g.liste_Etapes[compteurEtapes]); 
            List<string> fermesAlgoEnString = transfoListesNoeudsEnString(g.liste_Etapes[compteurEtapes+1]);
            compteurEtapes = compteurEtapes + 2;
            
            verificationListes(ouvertsMain, ouvertsAlgoEnString);
            verificationListes(fermesMain, fermesAlgoEnString);
        }
    }
}
