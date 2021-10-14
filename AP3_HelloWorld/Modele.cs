using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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


        //Vérification que l'utilisateur existe
        public static bool userexists(string id)
        {
            bool vretour = false;
            if(maConnexion.Visiteur.Where (x=> x.identifiant == id).ToList().Count ==1)
            {
                vretour = true;
                UtilisateurConnecte = maConnexion.Visiteur.Where(x => x.identifiant == id).ToList()[0];
                maConnexion.SaveChanges();
            }
            return vretour;
        }
        //---------------


    }
}
