namespace Pluscourtchemin
{
    partial class Choix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQuestionsCours = new System.Windows.Forms.Button();
            this.buttonAlgoDijkstra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuestionsCours
            // 
            this.buttonQuestionsCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuestionsCours.Location = new System.Drawing.Point(202, 100);
            this.buttonQuestionsCours.Name = "buttonQuestionsCours";
            this.buttonQuestionsCours.Size = new System.Drawing.Size(237, 151);
            this.buttonQuestionsCours.TabIndex = 0;
            this.buttonQuestionsCours.Text = "Questions de cours";
            this.buttonQuestionsCours.UseVisualStyleBackColor = true;
            this.buttonQuestionsCours.Click += new System.EventHandler(this.buttonQuestionsCours_Click);
            // 
            // buttonAlgoDijkstra
            // 
            this.buttonAlgoDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlgoDijkstra.Location = new System.Drawing.Point(202, 301);
            this.buttonAlgoDijkstra.Name = "buttonAlgoDijkstra";
            this.buttonAlgoDijkstra.Size = new System.Drawing.Size(239, 167);
            this.buttonAlgoDijkstra.TabIndex = 1;
            this.buttonAlgoDijkstra.Text = "Algorithme de Dijkstra";
            this.buttonAlgoDijkstra.UseVisualStyleBackColor = true;
            this.buttonAlgoDijkstra.Click += new System.EventHandler(this.buttonAlgoDijkstra_Click);
            // 
            // Choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 570);
            this.Controls.Add(this.buttonAlgoDijkstra);
            this.Controls.Add(this.buttonQuestionsCours);
            this.Name = "Choix";
            this.Text = "Choix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuestionsCours;
        private System.Windows.Forms.Button buttonAlgoDijkstra;
    }
}