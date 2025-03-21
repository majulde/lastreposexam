using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Gestion_d_ecole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern  static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hmd, int msg, int wparam,int lparam);


        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barretitolo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void abriformpanel1(object form)
        {
            // Supprimer les anciens contrôles s'ils existent
            this.panelContainer.Controls.Clear();

            // Convertir l'objet en Form
            Form fh = form as Form;
            if (fh != null)
            {
                fh.TopLevel = false; // Nécessaire pour intégrer un formulaire dans un panel
                fh.FormBorderStyle = FormBorderStyle.None; // Supprimer la bordure pour un affichage propre
                fh.Dock = DockStyle.Fill; // Adapter la taille au panel

                // Ajouter le formulaire au panel et l'afficher
                this.panelContainer.Controls.Add(fh);
                this.panelContainer.Tag = fh;
                fh.Show();
            }
        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            titre.Text = "Gestoion des Utilisateur";
            abriformpanel1(new FormInscriptionUser());
        }

        private void btnprofessuer_Click(object sender, EventArgs e)
        {
            titre.Text = "Gestoion des Professeur";
            abriformpanel1(new FormProfesseur());
        }

        private void btnclasse_Click(object sender, EventArgs e)
        {
            titre.Text = "Gestoion des Classe";
            abriformpanel1(new FormClasse());
        }

        private void btncours_Click(object sender, EventArgs e)
        {
            titre.Text = "Gestoion des Cours";
            abriformpanel1(new FormCours());
        }

        private void btnmatiere_Click(object sender, EventArgs e)
        {
            titre.Text = "Gestoion des Matière";
            abriformpanel1(new FormMatiere());
        }

        private void btnetudiant_Click(object sender, EventArgs e)
        {
            titre.Text = "Gestoion des Etudiant";
            abriformpanel1(new FormEtudiant());
        }
        
        private void btnnotes_Click(object sender, EventArgs e)
        {
            titre.Text = "Gestoion des Notes";
            abriformpanel1(new FormNotes());
        }
        public void desactiveDE()
        {
            btnUser.Enabled = false;
            btnetudiant.Enabled = false;
            btnnotes.Enabled = false;
        }
        public void desactiveAgent()
        {
            btnUser.Enabled = false;
            btnclasse.Enabled = false;
            btnmatiere.Enabled = false;
            btnprofessuer.Enabled = false;
            btnrapport.Enabled = false;
            btncours.Enabled = false;
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnrapport_Click(object sender, EventArgs e)
        {
            abriformpanel1(new FormRapport());
        }
    }
}
