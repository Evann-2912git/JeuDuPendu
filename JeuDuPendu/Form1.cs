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
        void RemplirCombo()
        {
            cboLettres.Items.Clear();
            for(int i = 0; i < 26; i++)
            {
                cboLettres.Items.Add((char)('A' + i));
            }
        }
        private void FenetrePendu_Load(object sender, EventArgs e)
        {
            RemplirCombo();
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
                        cboLettres.Visible = true;
                        lblDejaUtilisees.Visible = true;
                        btnRejouer.Visible = true;
                        btnTest.Visible = true;
                        pctPendu.Visible = true;
                        txtMotSecret.Visible = true;
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
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (cboLettres.SelectedIndex >= 0)
            {
                int longueurMot = txtMot.Text.Count();
                char lettre = (char)cboLettres.SelectedItem;
                bool trouve = false;
                for(int i=0;i<longueurMot;i++)
                {
                    if (lettre == txtMot.Text[i])
                    {
                        trouve = true;
                        char[]message=txtMotSecret.Text.ToCharArray();
                        message[i] = lettre;
                        txtMotSecret.Text = new string(message);
                        lettresTrouvees++;
                    }   
                }
                if (!trouve)
                {
                    nbEchec++;
                    pctPendu.Image = Image.FromFile("C:/Users/compteadmin/Documents/images_pendu/images_pendu/pendu"+nbEchec+".png");
                    if (nbEchec == 10)
                    {
                        cboLettres.Enabled = false;
                        btnTest.Enabled = false;
                    }
                }
                if (lettresTrouvees == longueurMot)
                {
                    cboLettres.Enabled = false;
                    btnTest.Enabled = false;
                }
                lblDejaUtilisees.Text += " " + lettre+" ;";
                cboLettres.Items.Remove(lettre);
            }
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            cboLettres.Enabled = true;
            btnTest.Enabled = true;
            cboLettres.Visible = false;
            lblDejaUtilisees.Visible = false;
            btnRejouer.Visible = false;
            btnTest.Visible = false;
            pctPendu.Visible = false;
            txtMotSecret.Visible = false;
            txtMot.Visible = true;
            txtMot.Clear();
            txtMotSecret.Clear();
            pctPendu.Image = Image.FromFile("C:/Users/compteadmin/Documents/images_pendu/images_pendu/pendu0.png");
            lblDejaUtilisees.Text = "Déjà utilisées : ";
            RemplirCombo();
        }
    }
}
