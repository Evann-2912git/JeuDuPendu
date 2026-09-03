namespace JeuDuPendu
{
    partial class FenetrePendu
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
            this.txtMot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotSecret = new System.Windows.Forms.TextBox();
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.grpSecret = new System.Windows.Forms.GroupBox();
            this.pctPendu = new System.Windows.Forms.PictureBox();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.grpSecret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMot
            // 
            this.txtMot.Location = new System.Drawing.Point(358, 153);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(100, 20);
            this.txtMot.TabIndex = 5;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jeu du pendu";
            // 
            // txtMotSecret
            // 
            this.txtMotSecret.Enabled = false;
            this.txtMotSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotSecret.Location = new System.Drawing.Point(6, 36);
            this.txtMotSecret.Name = "txtMotSecret";
            this.txtMotSecret.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMotSecret.Size = new System.Drawing.Size(342, 40);
            this.txtMotSecret.TabIndex = 7;
            this.txtMotSecret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMotSecret.Visible = false;
            // 
            // grpTest
            // 
            this.grpTest.Location = new System.Drawing.Point(12, 79);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(301, 189);
            this.grpTest.TabIndex = 8;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Lettres à tester";
            this.grpTest.Visible = false;
            // 
            // grpSecret
            // 
            this.grpSecret.Controls.Add(this.txtMotSecret);
            this.grpSecret.Location = new System.Drawing.Point(12, 286);
            this.grpSecret.Name = "grpSecret";
            this.grpSecret.Size = new System.Drawing.Size(354, 100);
            this.grpSecret.TabIndex = 9;
            this.grpSecret.TabStop = false;
            this.grpSecret.Text = "Mot à chercher";
            this.grpSecret.Visible = false;
            // 
            // pctPendu
            // 
            this.pctPendu.Image = global::JeuDuPendu.Properties.Resources.pendu0;
            this.pctPendu.Location = new System.Drawing.Point(513, 153);
            this.pctPendu.Name = "pctPendu";
            this.pctPendu.Size = new System.Drawing.Size(249, 248);
            this.pctPendu.TabIndex = 2;
            this.pctPendu.TabStop = false;
            this.pctPendu.Visible = false;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::JeuDuPendu.Properties.Resources.playagain;
            this.btnRejouer.Location = new System.Drawing.Point(358, 199);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(59, 56);
            this.btnRejouer.TabIndex = 1;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Visible = false;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(332, 79);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 55);
            this.lblResultat.TabIndex = 10;
            this.lblResultat.Visible = false;
            // 
            // FenetrePendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 409);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.grpSecret);
            this.Controls.Add(this.grpTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMot);
            this.Controls.Add(this.pctPendu);
            this.Controls.Add(this.btnRejouer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FenetrePendu";
            this.Text = "Pendu";
            this.Load += new System.EventHandler(this.FenetrePendu_Load);
            this.grpSecret.ResumeLayout(false);
            this.grpSecret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.PictureBox pctPendu;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotSecret;
        private System.Windows.Forms.GroupBox grpTest;
        private System.Windows.Forms.GroupBox grpSecret;
        private System.Windows.Forms.Label lblResultat;
    }
}

