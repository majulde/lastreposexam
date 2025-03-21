using System;
using System.Windows.Forms;

namespace Gestion_d_ecole
{
    public partial class FormConnexion : System.Windows.Forms.Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) 
        {

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            using (var db = new DB())
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNomUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnecter_Click_1(object sender, EventArgs e)
        {
            using (var db = new DB())
            {
                // Récupérer les valeurs des TextBox
                string nomUtilisateur = txtNomUtilisateur.Text;
                string motDePasse = txtPassword.Text.Trim(); ;

                // Appeler la méthode d'authentification qui compare les mots de passe hachés
                Utilisateur utilisateur = UtilisateurService.Authentifier(nomUtilisateur, motDePasse);

                // Vérifier si l'utilisateur existe
                if (utilisateur != null)
                {
                    // Si l'utilisateur est trouvé, afficher son rôle ou une autre action
                    MessageBox.Show($"Bienvenue {utilisateur.NomUtilisateur}, vous êtes un {utilisateur.Role}");
                    Form1 form1 = new Form1();
                    if (utilisateur.Role == "DE")
                    {
                        form1.desactiveDE();
                    }
                    if (utilisateur.Role == "Agent")
                    {
                        form1.desactiveAgent();
                    }
                    form1.ShowDialog();
                    // Fermer le formulaire de connexion (FormLogin)
                    
                    // this.Close(); // Fermer le formulaire de connexion après ouverture de Form1
                    //form1.Show(); // Ouvrir Form1 avant de fermer le formulaire de connexion
                    //this.Hide(); // Utilise Hide() pour garder la possibilité de revenir si nécessaire
                    
                }
                else
                {
                    // Si l'authentification échoue
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
        }
    }
}
