using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JeuDuPendu
{
    public partial class FenetrePendu : Form
    {
        public FenetrePendu()
        {
            InitializeComponent();
        }
        int nbEchec;
        int lettresTrouvees;
        private void FenetrePendu_Load(object sender, EventArgs e)
        {
            int x = 15, y = 20;
            for(int i = 0; i < 26; i++)
            {
                if (x> grpTest.Size.Width-25)
                {
                    x = 15;
                    y += 35;
                }
                Button btnLettre = new Button();
                grpTest.Controls.Add(btnLettre);
                btnLettre.Size = new Size(35, 35);
                btnLettre.Location = new Point(x,y);
                btnLettre.Text = ((char)('A' + i)).ToString();
                btnLettre.Click += new EventHandler(btnLettre_Click);
                x += 35;
            }
        }
        private void btnLettre_Click(object sender,EventArgs e)
        {
            Button btnValide = (Button)sender;
            char lettre = btnValide.Text.ToCharArray()[0];
            btnValide.Enabled = false;
            int longueurMot = txtMot.Text.Count();
            bool trouve = false;
            for (int i = 0; i < longueurMot; i++)
            {
                if (lettre == txtMot.Text[i])
                {
                    trouve = true;
                    char[] message = txtMotSecret.Text.ToCharArray();
                    message[i] = lettre;
                    txtMotSecret.Text = new string(message);
                    lettresTrouvees++;
                }
            }
            if (!trouve)
            {
                nbEchec++;
                pctPendu.Image = Image.FromFile("JeuDuPendu/Resources/pendu" + nbEchec + ".png");
                if (nbEchec == 7)
                {
                    grpTest.Enabled = false;
                    lblResultat.Visible = true;
                    lblResultat.Text = "Perdu!";
                    lblResultat.ForeColor = Color.Red;
                }
            }
            if (lettresTrouvees == longueurMot)
            {
                grpTest.Enabled = false;
                lblResultat.Visible = true;
                lblResultat.Text = "Gagné!";
                lblResultat.ForeColor = Color.Green;
            }
        }
        private void txtMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int longueurMot = txtMot.Text.Count();
                if(longueurMot>0 && longueurMot <= 15)
                {
                    int compteur = 0;
                    bool carValide = true;
                    while (carValide && compteur < longueurMot)
                    {
                        char lettre = txtMot.Text[compteur];
                        if (lettre<'A' || lettre>'Z'&& lettre<'a' || lettre>'z')
                        {
                            carValide = false;
                        }
                        compteur++;
                    }
                    if (!carValide)
                    {
                        txtMot.Clear();
                    }
                    else
                    {
                        txtMot.Visible = false;
                        btnRejouer.Visible = true;
                        pctPendu.Visible = true;
                        txtMotSecret.Visible = true;
                        grpSecret.Visible = true;
                        grpTest.Visible = true;
                        for(int i = 0; i < longueurMot; i++)
                        {
                            txtMotSecret.Text += "-";
                        }
                        txtMot.Text=txtMot.Text.ToUpper();
                        nbEchec = 0;
                        lettresTrouvees = 0;
                    }
                }
                else
                {
                    txtMot.Clear();
                }
            }
        }
        private void btnRejouer_Click(object sender, EventArgs e)
        {
            grpTest.Enabled = true;
            lblResultat.Visible = false;
            btnRejouer.Visible = false;
            pctPendu.Visible = false;
            txtMotSecret.Visible = false;
            txtMot.Visible = true;
            grpSecret.Visible = false;
            grpTest.Visible = false;
            grpTest.Controls.Clear();
            txtMot.Clear();
            txtMotSecret.Clear();
            lblResultat.Text = "";
            pctPendu.Image = Image.FromFile("pendu0.png");
            FenetrePendu_Load(null, null);
        }
    }
}
