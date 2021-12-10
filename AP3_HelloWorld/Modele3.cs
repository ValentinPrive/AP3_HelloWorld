using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_HelloWorld
{
    public static class Modele3
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
        public static List<fichefrais> listefrais()
        {
            return maConnexion.fichefrais.ToList();
        }
        public static List<Visiteur> listevisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static List<FraisForfait> listeFF()
        {
            return maConnexion.FraisForfait.ToList();
        }
    }
}
