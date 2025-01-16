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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.pctPendu = new System.Windows.Forms.PictureBox();
            this.lblDejaUtilisees = new System.Windows.Forms.Label();
            this.cboLettres = new System.Windows.Forms.ComboBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotSecret = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(327, 259);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Location = new System.Drawing.Point(327, 325);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(75, 23);
            this.btnRejouer.TabIndex = 1;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Visible = false;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // pctPendu
            // 
            this.pctPendu.Image = global::JeuDuPendu.Properties.Resources.pendu0;
            this.pctPendu.Location = new System.Drawing.Point(482, 158);
            this.pctPendu.Name = "pctPendu";
            this.pctPendu.Size = new System.Drawing.Size(253, 236);
            this.pctPendu.TabIndex = 2;
            this.pctPendu.TabStop = false;
            this.pctPendu.Visible = false;
            // 
            // lblDejaUtilisees
            // 
            this.lblDejaUtilisees.AutoSize = true;
            this.lblDejaUtilisees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDejaUtilisees.Location = new System.Drawing.Point(50, 377);
            this.lblDejaUtilisees.Name = "lblDejaUtilisees";
            this.lblDejaUtilisees.Size = new System.Drawing.Size(115, 20);
            this.lblDejaUtilisees.TabIndex = 3;
            this.lblDejaUtilisees.Text = "Déjà utilisées : ";
            this.lblDejaUtilisees.Visible = false;
            // 
            // cboLettres
            // 
            this.cboLettres.FormattingEnabled = true;
            this.cboLettres.Location = new System.Drawing.Point(54, 146);
            this.cboLettres.Name = "cboLettres";
            this.cboLettres.Size = new System.Drawing.Size(121, 21);
            this.cboLettres.TabIndex = 4;
            this.cboLettres.Visible = false;
            // 
            // txtMot
            // 
            this.txtMot.Location = new System.Drawing.Point(327, 146);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(100, 20);
            this.txtMot.TabIndex = 5;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jeu du pendu";
            // 
            // txtMotSecret
            // 
            this.txtMotSecret.Enabled = false;
            this.txtMotSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotSecret.Location = new System.Drawing.Point(327, 205);
            this.txtMotSecret.Name = "txtMotSecret";
            this.txtMotSecret.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMotSecret.Size = new System.Drawing.Size(140, 40);
            this.txtMotSecret.TabIndex = 7;
            this.txtMotSecret.Visible = false;
            // 
            // FenetrePendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.txtMotSecret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMot);
            this.Controls.Add(this.cboLettres);
            this.Controls.Add(this.lblDejaUtilisees);
            this.Controls.Add(this.pctPendu);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.btnTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FenetrePendu";
            this.Text = "Pendu";
            this.Load += new System.EventHandler(this.FenetrePendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.PictureBox pctPendu;
        private System.Windows.Forms.Label lblDejaUtilisees;
        private System.Windows.Forms.ComboBox cboLettres;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotSecret;
    }
}

