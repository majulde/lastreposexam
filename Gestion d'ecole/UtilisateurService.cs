using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class UtilisateurService
    {

        private static DB context = new DB();
        // Méthode d'authentification qui vérifie le mot de passe haché avec BCrypt
        public static Utilisateur Authentifier(string nomUtilisateur, string motDePasse)
        {
            // Chercher l'utilisateur dans la base de données
            Utilisateur utilisateur = context.Utilisateurs
                .Where(u => u.NomUtilisateur == nomUtilisateur)
                .FirstOrDefault();

            if (utilisateur != null)
            {

                // Comparer les mots de passe
                bool verification = BCrypt.Net.BCrypt.Verify(motDePasse, utilisateur.MotDePasse);

                if (verification)
                {
                    return utilisateur;
                }
            }

            return null; // Si l'utilisateur n'existe pas ou si la vérification échoue
        }
    }
}
