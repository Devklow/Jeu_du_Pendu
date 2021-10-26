using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGraphique
{
    public partial class Form1 : Form
    {
        //public string[] alphabet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R","S","T","U","V","W","X","Y","Z"];
        public string alphabet1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string alphabet2 = "abcdefghijklmnopqrstuvwxyz";
        public bool Nightmode = true;
        public int phase, viePerdu;
        public string motChoisit, motAfficher, lettreChoisit, lettreDonnees, nmode;
        public Form1()
        {
            InitializeComponent();
            nmode = "d";
            resetfunc();
            AcceptButton = btnValidate;
        }
        /// <summary>
        /// Permet de réinitialiser tout les valeurs et afficher la phase 1
        /// </summary>
        private void resetfunc()
        {
            viePerdu = 0;
            Image monImage = (Image)Properties.Resources.ResourceManager.GetObject(nmode + "pendu" + viePerdu);
            pbxPendu.Image = monImage;
            lettreDonnees = "";
            lblGG.Text = "";
            lblGG.Visible = false;
            phase = 1;
            lblInfo.Text = "Entrez le mot :";
            tbxEntry.Text = "";
            tbxEntry.MaxLength = 15;
            motAfficher = "";
            lblWTF.Text = motAfficher;
            lblWTF.Visible = false;
            lblWordToFind.Visible = false;
            lblAGL.Text = "";
            lblAGL.Visible = false;
            btnValidate.Visible = true;
            tbxEntry.Visible = true;
            lblInfo.Visible = true;
            lblAlreadyGivenLetters.Visible = false;
        }
        /// <summary>
        /// Permet d'iniatialiser la phase 2
        /// </summary>
        private void phaseInit()
        {
            phase = 2;
            lblInfo.Text = "Entrez une lettre :";
            tbxEntry.Text = "";
            tbxEntry.MaxLength = 1;
            int i = 0;
            while (i < motChoisit.Length)
            {
                motAfficher = motAfficher + "_ ";
                i += 1 ;
            }
            lblWTF.Text = motAfficher;
            lblWTF.Visible = true;
            lblWordToFind.Visible = true;
            lblAGL.Text = "";
            lblAGL.Visible = true;
            lblAlreadyGivenLetters.Visible = true;
        }
        private void btnMode_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    /// <summary>
    /// Permet de regarder si la lettre donnée correspond ou non à une lettre du mot
    /// Elle change aussi l'image du pendu et fait perdre une vie
    /// Elle actualise aussi l'affichage du mot a trouver et les lettres déjà essayée
    /// </summary>
    private void checkLetter()
        {
            int a, i;
            string lemot = "";
            a = motChoisit.IndexOf(lettreChoisit);
            if(a > -1)
            {
                i = 0;
                while (i < motChoisit.Length)
                {
                    if (motChoisit.ElementAt(i) == lettreChoisit.ElementAt(0))
                    {
                        lemot = lemot + lettreChoisit +" ";
                    }
                    else if(motAfficher.ElementAt(i*2) == '_')
                    {
                        lemot = lemot + "_ ";
                    }
                    else
                    {
                        lemot = lemot + motAfficher.ElementAt(i * 2) + " ";
                    }
                    i += 1;
                }
                motAfficher = lemot;
            }
            else
            {
                viePerdu += 1;
                Image monImage = (Image)Properties.Resources.ResourceManager.GetObject(nmode+"pendu" + viePerdu);
                pbxPendu.Image = monImage;
            }
            if(lettreDonnees.Length>0)
            {
                lettreDonnees = lettreDonnees + ", " + lettreChoisit;
            }
            else
            {
                lettreDonnees = lettreChoisit;

            }
            lblWTF.Text = motAfficher;
            lblAGL.Text = lettreDonnees;

        }
        /// <summary>
        /// Fonction permettant de passer du mode jour au mode nuit
        /// change la couleur du fond, le couleur d'écriture et l'image du pendu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMode_Click_1(object sender, EventArgs e)
        {
            if (Nightmode)
            {
                Nightmode = false;
                nmode = "";
                Image monImage = (Image)Properties.Resources.ResourceManager.GetObject(nmode + "pendu" + viePerdu);
                pbxPendu.Image = monImage;
                monImage = (Image)Properties.Resources.ResourceManager.GetObject(nmode + "reset");
                btnReset.Image = monImage;
                monImage = (Image)Properties.Resources.ResourceManager.GetObject("nightmode");
                btnMode.Image = monImage;
                BackColor = Color.Black;
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
            else
            {
                Nightmode = true;
                nmode = "d";
                Image monImage = (Image)Properties.Resources.ResourceManager.GetObject(nmode + "pendu" + viePerdu);
                pbxPendu.Image = monImage;
                monImage = (Image)Properties.Resources.ResourceManager.GetObject(nmode + "reset");
                btnReset.Image = monImage;
                monImage = (Image)Properties.Resources.ResourceManager.GetObject("lightmode");
                btnMode.Image = monImage;
                BackColor = Color.Black;
                ForeColor = Color.LightSalmon;
            }
            

        }

        /// <summary>
        /// Permet a chaque entrée de character de vérifier si celui ci est présent dans notre alphabet 
        /// Si la lettre rentrée est une minuscule elle est remplacé par une majuscule
        /// Si le caractère n'est pas compris dans l'alphabet celui ci n'est pas pris en compte
        /// Pour la phase 2 si notre caractere appartient a l'alphabet mais a deja été proposé, il n'est pas pris en compte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char lettre = 'a';
            int i = 0, a, b, c;
            string letext = "";
            while (i < tbxEntry.Text.Length)
            {
                try
                {
                    lettre = tbxEntry.Text[i];
                }
                catch { }
                a = alphabet1.IndexOf(lettre);
                b = alphabet2.IndexOf(lettre);
                c = lettreDonnees.IndexOf(lettre);
                if (a > -1 && c == -1)
                {
                    letext = letext + lettre;
                }
                if (b > -1 && c == -1)
                {
                    letext = letext + (char)alphabet1.ElementAt(b);
                }
                i += 1;
            }
            tbxEntry.Text = letext;
        }
        private void validate()
        {
            if (phase == 1 && tbxEntry.Text != "")
            {
                motChoisit = tbxEntry.Text;
                phaseInit();
            }
            if (phase == 2 && tbxEntry.Text != "")
            {
                lettreChoisit = tbxEntry.Text;
                tbxEntry.Text = "";
                checkLetter();
                checkWin();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
            {
                resetfunc();
            }
        /// <summary>
        /// Permet de vérifier si le joueur a Gagner ou Perdu
        /// </summary>
        private void checkWin()
        {
            string motTrouver;
            motTrouver = motAfficher.Replace(" ", String.Empty);
            if (motTrouver == motChoisit)
            {
                lblGG.Text = "GAGNÉ !";
                lblGG.Visible = true;
                lblWTF.Text = motChoisit;
                tbxEntry.Visible = false;
                lblInfo.Visible = false;
                btnValidate.Visible = false;
            }
            else if(viePerdu >= 10)
            {
                lblGG.Text = "PERDU !";
                lblGG.Visible = true;
                lblWTF.Text = motChoisit;
                tbxEntry.Visible = false;
                lblInfo.Visible = false;
                btnValidate.Visible = false;
            }
        }
        /// <summary>
        /// Fonction du bouton valider qui appelle d'autre fonction en fonction de la phase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            validate();
        }
    }
}
