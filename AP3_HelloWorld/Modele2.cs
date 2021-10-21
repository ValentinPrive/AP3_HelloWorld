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
            init();
            return maConnexion.MEDECIN.ToList();
        }
    }
}
