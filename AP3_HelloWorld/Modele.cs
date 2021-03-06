using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AP3_HelloWorld
{
    public static class Modele
    {
        private static connectGSB1 maConnexion;
        private static Visiteur utilisateurConnecte; 
        private static bool connexionValide;

        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }

        public static void init()
        {
            maConnexion = new connectGSB1();
        }
        public static List<Visiteur> listevisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }

        //CONNEXION
        //Vérification que l'utilisateur existe
        public static bool utilVerif(string id)
        {
            bool vretour = false;
            if(maConnexion.Visiteur.Where (x=> x.identifiant == id).ToList().Count ==1)
            {
                vretour = true;
                UtilisateurConnecte = maConnexion.Visiteur.Where(x => x.identifiant == id).ToList()[0];
            }
            return vretour;
        }
        //---------------

        //Vérification que le mot de passe existe

        public static bool mdpVerif(string mdp)
        {
            bool vretour = false;
            if (utilisateurConnecte.password.Equals(getMdpMD5(mdp)))
            {
                vretour = true;
            }
            return vretour;
        }
        //--------------

        //Cryptage de mot de passe
        private static string getMdpMD5(string pwdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pwdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        //--------------

        
        public static bool changepass(string nouveaumdp)
        {
            bool vretour = false;
            UtilisateurConnecte.password = getMdpMD5(nouveaumdp);
            maConnexion.SaveChanges();
            return vretour;
        }

        public static bool changeNom(string nouvNom)
        {
            bool vretour = false;
            UtilisateurConnecte.nom = nouvNom;
            maConnexion.SaveChanges();
            return vretour;
        }

        public static bool changeRue(string nouvRue)
        {
            bool vretour = false;
            UtilisateurConnecte.rue = nouvRue;
            maConnexion.SaveChanges();
            return vretour;
        }
        public static bool changePrenom(string nouvPrenom)
        {
            bool vretour = false;
            UtilisateurConnecte.prenom = nouvPrenom;
            maConnexion.SaveChanges();
            return vretour;
        }
        public static bool changeVille(string nouvVille)
        {
            bool vretour = false;
            UtilisateurConnecte.ville = nouvVille;
            maConnexion.SaveChanges();
            return vretour;
        }
        public static bool changeCP(string nouvCP)
        {
            bool vretour = false;
            UtilisateurConnecte.cp = nouvCP;
            maConnexion.SaveChanges();
            return vretour;
        }
        //---------------------------------------------------------------------------------------------



    }
}
