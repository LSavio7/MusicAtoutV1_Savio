using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MusicAtoutV1_Savio.Models;
using System.Security.Cryptography;
using System.Text;


namespace MusicAtoutV1_Savio
{
    public static class ModelProjet
    {
       

        private static MusicAtout_LSAVIOContext monModel;

        public static MusicAtout_LSAVIOContext MonModel
        {
            get => monModel;
            set => monModel = value;
        }

        public static void init()
        {
            monModel = new MusicAtout_LSAVIOContext();
        }

        public static List<Ville> listeVille()
        {
            return monModel.Villes.ToList();
        }

        public static List<Nationalite> listeNationalite()
        {
            return monModel.Nationalites
                .OrderBy(n => n.LibNation)
                .ToList();
        }

        public static List<Style> listeStyle()
        {
            return monModel.Styles
                .OrderBy(s => s.LibStyle)
                .ToList();
        }

        public static List<Compositeur> listeCompositeurs()
        {
            return monModel.Compositeurs
                .Include(c => c.IdNationNavigation)
                .Include(c => c.IdStyleNavigation)
                .Include(c => c.Oeuvres)
                .OrderBy(c => c.NomCompositeur)
                .ToList();
        }




        public static MusicAtout_LSAVIOContext Contexte => monModel;
        public static int actionGestionCompositeur { get; set; } // 1 = ajout, 2 = modif
        public static Compositeur compositeurChoisi { get; set; }

        private static Utilisateur utilisateurConnecte;
        private static bool connexionValide;

        public static Utilisateur UtilisateurConnecte => utilisateurConnecte;
        public static bool ConnexionValide => connexionValide;


        public static bool AjoutCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            try
            {
                Compositeur compositeur = new Compositeur
                {
                    NomCompositeur = nom,
                    PrenomCompositeur = prenom,
                    Remarque = remarque,
                    AnNais = anNais,
                    AnMort = anMort,
                    IdNation = idNation,
                    IdStyle = idStyle
                };

                monModel.Compositeurs.Add(compositeur);
                monModel.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ModifCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            try
            {
                compositeurChoisi.NomCompositeur = nom;
                compositeurChoisi.PrenomCompositeur = prenom;
                compositeurChoisi.Remarque = remarque;
                compositeurChoisi.AnNais = anNais;
                compositeurChoisi.AnMort = anMort;
                compositeurChoisi.IdNation = idNation;
                compositeurChoisi.IdStyle = idStyle;

                monModel.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SuppCompositeur()
        {
            try
            {
                monModel.Compositeurs.Remove(compositeurChoisi);
                monModel.SaveChanges();
                return true;
            }
            catch
            {
                monModel.Dispose(); // on libère le contexte si une erreur se produit
                init(); // on le réinitialise
                return false;
            }
        }

        public static string GetMd5Hash(string passwdSaisi)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(passwdSaisi);
            byte[] hash = MD5.Create().ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }

            return sb.ToString();
        }


        public static string ValidConnexion(string id, string mp)
        {
            string message = "";
            connexionValide = false;

            utilisateurConnecte = MonModel.Utilisateurs.FirstOrDefault(u => u.IdUtilisateur == id);

            if (utilisateurConnecte == null)
            {
                message = "Identifiant inconnu";
            }
            else if (utilisateurConnecte.Actif == false)
            {
                message = "Compte inactif";
            }
            else if (utilisateurConnecte.Passwd == "xx" + GetMd5Hash(utilisateurConnecte.IdUtilisateur))
            {
                message = "Mot de passe par défaut. Merci de le modifier.";
                connexionValide = true;
                utilisateurConnecte.Nbessais = 0;
                MonModel.SaveChanges();
            }
            else
            {
                string hash = GetMd5Hash(mp);
                if (utilisateurConnecte.Passwd.Substring(2).Equals(hash))
                {
                    utilisateurConnecte.Nbessais = 0;
                    connexionValide = true;
                    MonModel.SaveChanges();
                }
                else
                {
                    utilisateurConnecte.Nbessais += 1;
                    if (utilisateurConnecte.Nbessais >= 3)
                        utilisateurConnecte.Actif = false;

                    MonModel.SaveChanges();
                    message = "Mot de passe incorrect (" + utilisateurConnecte.Nbessais + "/3)";
                }
            }

            return message;
        }

        public static List<Utilisateur> listeUtilisateurs()
        {
            return MonModel.Utilisateurs
                .OrderBy(u => u.IdUtilisateur)
                .ToList();
        }









    }
}
