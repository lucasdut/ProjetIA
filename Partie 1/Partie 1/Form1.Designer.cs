namespace Partie_1
{
    partial class Form1
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
            this.btnSuivant = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.rbRep1 = new System.Windows.Forms.RadioButton();
            this.rbRep2 = new System.Windows.Forms.RadioButton();
            this.BtnVerifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRep3 = new System.Windows.Forms.RadioButton();
            this.rbRep4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(224, 280);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 0;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.Btn_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(55, 19);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(391, 85);
            this.tbQuestion.TabIndex = 1;
            // 
            // rbRep1
            // 
            this.rbRep1.AutoSize = true;
            this.rbRep1.Location = new System.Drawing.Point(88, 146);
            this.rbRep1.Name = "rbRep1";
            this.rbRep1.Size = new System.Drawing.Size(14, 13);
            this.rbRep1.TabIndex = 2;
            this.rbRep1.TabStop = true;
            this.rbRep1.UseVisualStyleBackColor = true;
            // 
            // rbRep2
            // 
            this.rbRep2.AutoSize = true;
            this.rbRep2.Location = new System.Drawing.Point(303, 146);
            this.rbRep2.Name = "rbRep2";
            this.rbRep2.Size = new System.Drawing.Size(14, 13);
            this.rbRep2.TabIndex = 3;
            this.rbRep2.TabStop = true;
            this.rbRep2.UseVisualStyleBackColor = true;
            // 
            // BtnVerifier
            // 
            this.BtnVerifier.Location = new System.Drawing.Point(419, 280);
            this.BtnVerifier.Name = "BtnVerifier";
            this.BtnVerifier.Size = new System.Drawing.Size(75, 23);
            this.BtnVerifier.TabIndex = 4;
            this.BtnVerifier.Text = "Vérifier";
            this.BtnVerifier.UseVisualStyleBackColor = true;
            this.BtnVerifier.Click += new System.EventHandler(this.BtnVerifier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRep4);
            this.groupBox1.Controls.Add(this.rbRep3);
            this.groupBox1.Controls.Add(this.rbRep2);
            this.groupBox1.Controls.Add(this.rbRep1);
            this.groupBox1.Controls.Add(this.tbQuestion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
        
            // 
            // rbRep3
            // 
            this.rbRep3.AutoSize = true;
            this.rbRep3.Location = new System.Drawing.Point(88, 204);
            this.rbRep3.Name = "rbRep3";
            this.rbRep3.Size = new System.Drawing.Size(14, 13);
            this.rbRep3.TabIndex = 4;
            this.rbRep3.TabStop = true;
            this.rbRep3.UseVisualStyleBackColor = true;
            // 
            // rbRep4
            // 
            this.rbRep4.AutoSize = true;
            this.rbRep4.Location = new System.Drawing.Point(303, 204);
            this.rbRep4.Name = "rbRep4";
            this.rbRep4.Size = new System.Drawing.Size(14, 13);
            this.rbRep4.TabIndex = 5;
            this.rbRep4.TabStop = true;
            this.rbRep4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnVerifier);
            this.Controls.Add(this.btnSuivant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.RadioButton rbRep1;
        private System.Windows.Forms.RadioButton rbRep2;
        private System.Windows.Forms.Button BtnVerifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRep4;
        private System.Windows.Forms.RadioButton rbRep3;
    }
}

