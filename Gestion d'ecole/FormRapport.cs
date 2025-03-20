using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

//using Gestion_d_ecole.Models;


namespace Gestion_d_ecole
{
    public partial class FormRapport : Form
    {
        public FormRapport()
        {
            InitializeComponent();
        }

        private void FormRapport_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            refreshclasse();
            //RefreshMatieres((int)txtclasse.SelectedValue);
            // refreshcours((int)txtclasse.SelectedValue);
            dataGridView1.DataSource = null;
            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Etudiants
                .Where(p => p.Classe.NomClasse == comboclasse.Text)
                .Select(p => new viewEtudiant
                {
                    Id = p.Id,
                    Matricule = p.Matricule,
                    Nom = p.Nom,
                    Prenom = p.Prenom,
                    Sexe = p.Sexe,
                    DateNaissance = p.DateNaissance,
                    Adresse = p.Adresse,
                    Classe = p.Classe.NomClasse
                }).OrderBy(p => p.Nom).ToList();

            }
        }
        private void refreshclasse()
        {
            using (var db = new DB())
            {
                comboclasse.DataSource = db.Classes.ToList();
                comboclasse.DisplayMember = "NomClasse";
                comboclasse.ValueMember = "Id";
            }
        }

        private void btngenerlisteetudiant_Click(object sender, EventArgs e)
        {
            
        }
       




      


       
        private void comboclasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear(); // Efface toutes les colonnes existantes

            using (var db = new DB())
            {
                dataGridView1.DataSource = db.Etudiants
                .Where(p => p.Classe.NomClasse == comboclasse.Text)
                .Select(p => new viewEtudiant
                {
                    Id = p.Id,
                    Matricule = p.Matricule,
                    Nom = p.Nom,
                    Prenom = p.Prenom,
                    Sexe = p.Sexe,
                    DateNaissance = p.DateNaissance,
                    Adresse = p.Adresse,
                    Classe = p.Classe.NomClasse
                }).OrderBy(p => p.Nom).ToList();
            }
        }


    }
}
