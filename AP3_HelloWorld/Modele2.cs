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

        public static void init()
        {
            maConnexion = new connectGSB1();
        }

        public static List<MEDECIN> listemedecin()
        {
            return maConnexion.MEDECIN.ToList();
        }

        public static List<RAPPORT> listerapportTest()
        {
            return maConnexion.RAPPORT.ToList();
        }
        public static object listerapport()
        {
            return maConnexion.RAPPORT.Where(x => x.idVisiteur == Modele.UtilisateurConnecte.idVisiteur).ToList().Select(x => new { x.idRapport, x.dateRapport, nomMedecin = x.MEDECIN.nom, x.MOTIF.libMotif, x.bilan }).OrderBy(x => x.dateRapport);
        }
    }
}
