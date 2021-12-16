using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_HelloWorld
{
    public static class Modele2
    {
        private static connectGSB1 maConnexion;
        public static int actionGestionRapport;
        public static RAPPORT rapportChoisi;

        public static int ActionGestionRapport { get => actionGestionRapport; set => actionGestionRapport = value; }
        public static RAPPORT RapportChoisi { get => rapportChoisi; set => rapportChoisi = value; }

        public static void init()
        {
            maConnexion = new connectGSB1();
        }

        public static object listemedecin()
        {
            return maConnexion.MEDECIN.ToList().OrderBy(x => x.nom);
        }

        public static List<RAPPORT> listerapportTest()
        {
            return maConnexion.RAPPORT.ToList();
        }
        public static object listerapport()
        {
            return maConnexion.RAPPORT.Where(x => x.idVisiteur == Modele.UtilisateurConnecte.idVisiteur).ToList().Select(x => new { x.idRapport, x.dateRapport, nomMedecin = x.MEDECIN.nom, x.MEDECIN.prenom, x.MOTIF.libMotif, x.bilan }).OrderBy(x => x.dateRapport);
        }

        public static List<MOTIF> listemotif()
        {
            return maConnexion.MOTIF.ToList();
        }

        public static List<MEDICAMENT> listemedicament()
        {
            return maConnexion.MEDICAMENT.ToList();
        }

        public static RAPPORT RapportDepuisId(int id)
        {
            RAPPORT vretour = maConnexion.RAPPORT.Where(x => x.idRapport == id).ToList()[0];
            return vretour;
        }
    }
}
