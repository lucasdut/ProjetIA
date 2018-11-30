namespace Pluscourtchemin
{
    partial class Dijkstra
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("0");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("3");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.labelTreeviewAlaMain = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.button7 = new System.Windows.Forms.Button();
            this.textboxNoeudAjoute = new System.Windows.Forms.TextBox();
            this.buttonEdition = new System.Windows.Forms.Button();
            this.buttonVerif = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud initial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noeud final :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(135, 451);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 121);
            this.listBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Initialisation graphe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(30, 451);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxgraphe.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(424, 397);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(424, 426);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Entrez vos fermés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Entrez vos ouverts";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(424, 452);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Terminer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelTreeviewAlaMain
            // 
            this.labelTreeviewAlaMain.AutoSize = true;
            this.labelTreeviewAlaMain.Location = new System.Drawing.Point(562, 9);
            this.labelTreeviewAlaMain.Name = "labelTreeviewAlaMain";
            this.labelTreeviewAlaMain.Size = new System.Drawing.Size(102, 13);
            this.labelTreeviewAlaMain.TabIndex = 28;
            this.labelTreeviewAlaMain.Text = "Treeview à la main :";
            // 
            // treeView2
            // 
            this.treeView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView2.LabelEdit = true;
            this.treeView2.Location = new System.Drawing.Point(565, 51);
            this.treeView2.Name = "treeView2";
            treeNode9.Name = "";
            treeNode9.Text = "0";
            treeNode10.Name = "";
            treeNode10.Text = "1";
            treeNode11.Name = "";
            treeNode11.Text = "2";
            treeNode12.Name = "";
            treeNode12.Text = "3";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView2.Size = new System.Drawing.Size(172, 166);
            this.treeView2.TabIndex = 29;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(727, 264);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 31;
            this.button7.Text = "Enlever";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textboxNoeudAjoute
            // 
            this.textboxNoeudAjoute.Location = new System.Drawing.Point(565, 25);
            this.textboxNoeudAjoute.Name = "textboxNoeudAjoute";
            this.textboxNoeudAjoute.Size = new System.Drawing.Size(164, 20);
            this.textboxNoeudAjoute.TabIndex = 33;
            // 
            // buttonEdition
            // 
            this.buttonEdition.Location = new System.Drawing.Point(646, 264);
            this.buttonEdition.Name = "buttonEdition";
            this.buttonEdition.Size = new System.Drawing.Size(75, 23);
            this.buttonEdition.TabIndex = 34;
            this.buttonEdition.Text = "Edition";
            this.buttonEdition.UseVisualStyleBackColor = true;
            this.buttonEdition.Click += new System.EventHandler(this.buttonEdition_Click);
            // 
            // buttonVerif
            // 
            this.buttonVerif.Location = new System.Drawing.Point(788, 128);
            this.buttonVerif.Name = "buttonVerif";
            this.buttonVerif.Size = new System.Drawing.Size(75, 23);
            this.buttonVerif.TabIndex = 35;
            this.buttonVerif.Text = "Vérification";
            this.buttonVerif.UseVisualStyleBackColor = true;
            this.buttonVerif.Click += new System.EventHandler(this.buttonVerif_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(565, 264);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 37;
            this.button9.Text = "ajout";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(565, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(692, 237);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 23);
            this.button10.TabIndex = 40;
            this.button10.Text = "Ajout noeud fils";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(361, 38);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 191);
            this.treeView1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Treeview de l\'algo :";
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 585);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonVerif);
            this.Controls.Add(this.buttonEdition);
            this.Controls.Add(this.textboxNoeudAjoute);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.labelTreeviewAlaMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Dijkstra";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelTreeviewAlaMain;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textboxNoeudAjoute;
        private System.Windows.Forms.Button buttonEdition;
        private System.Windows.Forms.Button buttonVerif;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label5;
    }
}

