using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_d_ecole
{
    public partial class FormInscriptionUser : Form
    {
        public FormInscriptionUser()
        {
            InitializeComponent();
        }

        private void btnEnregistrerIns_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomUtilisateurIns.Text) ||
            string.IsNullOrWhiteSpace(txtPasswordIns.Text) ||
            string.IsNullOrWhiteSpace(txtTelephone.Text) ||
            cmbRole.SelectedIndex == -1) // Vérifie si un rôle a été sélectionné
            {
                MessageBox.Show("Tous les champs sont obligatoires et vous devez choisir un rôle valide.");
                return;
            }
            using (var db = new DB())
            {
                try
                {
                    // Vérifier si l'utilisateur existe déjà
                    if (db.Utilisateurs.Any(u => u.NomUtilisateur == txtNomUtilisateurIns.Text))
                    {
                        MessageBox.Show("Ce nom d'utilisateur est déjà pris. Veuillez en choisir un autre.");
                        return;
                    }


                    Utilisateur utilisateur = new Utilisateur
                    {
                        NomUtilisateur = txtNomUtilisateurIns.Text,
                        MotDePasse = BCrypt.Net.BCrypt.HashPassword(txtPasswordIns.Text), // Hachage du mot de passe
                        Telephone = txtTelephone.Text,
                        Role = cmbRole.Text
                    };

                    db.Utilisateurs.Add(utilisateur);
                    db.SaveChanges();
                    MessageBox.Show("Utilisateur ajouté avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ajout de l'utilisateur : {ex.Message}");
                }
            }

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_Validating(object sender, CancelEventArgs e)
        {
            if (!cmbRole.Items.Contains(cmbRole.Text))
            {
                MessageBox.Show("Rôle invalide. Veuillez en sélectionner un dans la liste.");
                cmbRole.Focus();
                e.Cancel = true; // Annule la validation
            }
        }

        private void txtPasswordIns_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormInscriptionUser_Load(object sender, EventArgs e)
        {
            refresh();
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void cmbRole_Validated(object sender, EventArgs e)
        {
           
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string recherche = txtNomUtilisateurIns.Text.Trim().ToLower(); // Supprime les espaces et met en minuscules

            using (var db = new DB())
            {
                var utilisateurs = db.Utilisateurs
                    .Where(u => u.NomUtilisateur.ToLower().Contains(recherche) ||
                                u.Telephone.Contains(recherche) ||
                                u.Role.ToLower().Contains(recherche))
                    .Select(u => new
                    {
                        u.NomUtilisateur,
                        u.Telephone,
                        u.Role
                    })
                    .ToList();

                dataGridViewIns.DataSource = utilisateurs;

                if (utilisateurs.Count == 0)
                {
                    MessageBox.Show("Aucun utilisateur trouvé !");
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            using (var db = new DB())
            {
                try
                {
                    var utilisateur = db.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == txtNomUtilisateurIns.Text);
                    if (utilisateur == null)
                    {
                        MessageBox.Show("Utilisateur introuvable !");
                        return;
                    }

                    // Vérification si le nouveau nom d'utilisateur existe déjà chez un autre utilisateur
                    if (utilisateur.NomUtilisateur != txtNomUtilisateurIns.Text &&
                        db.Utilisateurs.Any(u => u.NomUtilisateur == txtNomUtilisateurIns.Text))
                    {
                        MessageBox.Show("Ce nom d'utilisateur est déjà pris. Veuillez en choisir un autre.");
                        return;
                    }

                    // Mise à jour des informations
                    utilisateur.NomUtilisateur = txtNomUtilisateurIns.Text;
                    utilisateur.Telephone = txtTelephone.Text;
                    utilisateur.Role = cmbRole.Text;

                    // Mettre à jour le mot de passe uniquement si un nouveau est saisi
                    if (!string.IsNullOrWhiteSpace(txtPasswordIns.Text))
                    {
                        utilisateur.MotDePasse = BCrypt.Net.BCrypt.HashPassword(txtPasswordIns.Text);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Utilisateur modifié avec succès !");
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
                }
            }
        }
        public void refresh()
        {
            using (var db = new DB())
            {
                dataGridViewIns.DataSource = db.Utilisateurs.Select(u => new
                {
                    u.Id,
                    u.NomUtilisateur,
                    u.Telephone,
                    u.Role
                })
                    .ToList(); ;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomUtilisateurIns.Text))
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer !");
                return;
            }

            DialogResult confirm = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (var db = new DB())
                {
                    try
                    {
                        var utilisateur = db.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == txtNomUtilisateurIns.Text);
                        if (utilisateur == null)
                        {
                            MessageBox.Show("Utilisateur introuvable !");
                            return;
                        }

                        db.Utilisateurs.Remove(utilisateur);
                        db.SaveChanges();

                        MessageBox.Show("Utilisateur supprimé avec succès !");
                        refresh(); // Met à jour le DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression : {ex.Message}");
                    }
                }
            }
        }

        private void dataGridViewIns_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            if (e.RowIndex >= 0) // Vérifier qu'on ne clique pas sur l'en-tête
            {
                DataGridViewRow row = dataGridViewIns.Rows[e.RowIndex];

                // Remplir les champs avec les valeurs de la ligne sélectionnée
                txtNomUtilisateurIns.Text = row.Cells["NomUtilisateur"].Value.ToString();
                txtTelephone.Text = row.Cells["Telephone"].Value.ToString();
                cmbRole.Text = row.Cells["Role"].Value.ToString();

                // Ne pas afficher le mot de passe pour la sécurité
                txtPasswordIns.Text = "";
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
            }
        }
    }

}
