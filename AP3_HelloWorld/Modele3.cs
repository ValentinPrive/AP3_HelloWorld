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
        public static fichefrais fichefraisC;
        private static bool connexionValide;

        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static fichefrais FichefraisC { get => fichefraisC; set => fichefraisC = value; }
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
        public static List<FraisForfait> listeFFA()
        {
            return maConnexion.FraisForfait.Where(x => x.libelle.Contains("Frais")).ToList();
        }
        public static bool AjoutficheFrais(string mois, int nbJustificatifs, double montantValide)
        {
            bool vretour = true;
            try
            {
                fichefraisC = new fichefrais();
                fichefraisC.idVisiteur = UtilisateurConnecte.idVisiteur;
                fichefraisC.mois = mois;
                fichefraisC.nbJustificatifs = nbJustificatifs;
                fichefraisC.montantValide = Convert.ToDecimal(montantValide);
                fichefraisC.idEtat = "CR";
                fichefraisC.dateModif = DateTime.Now;
                maConnexion.fichefrais.Add(fichefraisC);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }

            return vretour;
        }
    }
}
