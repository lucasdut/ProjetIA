namespace FormPartie1
{
    partial class QuestionForm
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
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_envoyer = new System.Windows.Forms.Button();
            this.lb_question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(166, 276);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(75, 23);
            this.btn_suivant.TabIndex = 0;
            this.btn_suivant.Text = "Suivant";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(30, 276);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(75, 23);
            this.btn_precedent.TabIndex = 1;
            this.btn_precedent.Text = "Précedent";
            this.btn_precedent.UseVisualStyleBackColor = true;
            // 
            // btn_envoyer
            // 
            this.btn_envoyer.Location = new System.Drawing.Point(294, 276);
            this.btn_envoyer.Name = "btn_envoyer";
            this.btn_envoyer.Size = new System.Drawing.Size(75, 23);
            this.btn_envoyer.TabIndex = 2;
            this.btn_envoyer.Text = "Envoyer";
            this.btn_envoyer.UseVisualStyleBackColor = true;
            this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.Location = new System.Drawing.Point(144, 26);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(49, 13);
            this.lb_question.TabIndex = 3;
            this.lb_question.Text = "Question";
            // 
            // FPartie1
            // 
            this.ClientSize = new System.Drawing.Size(427, 321);
            this.Controls.Add(this.lb_question);
            this.Controls.Add(this.btn_envoyer);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_suivant);
            this.Name = "FPartie1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSuivant;
        private System.Windows.Forms.Label LQuestion1;
        private System.Windows.Forms.RadioButton rb_rep1;
        private System.Windows.Forms.RadioButton rb_rep2;
        private System.Windows.Forms.Label lb_questions;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_envoyer;
        private System.Windows.Forms.Label lb_question;
    }
}

