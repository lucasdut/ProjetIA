using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Pluscourtchemin
{
    public class SearchTreeALaMain : SearchTree
    {        
        private void AjouterNoeudOuvert(GenericNode N2)
        {
            L_Ouverts.Add(N2);
        }
        private void EnleverNoeudOuvert(GenericNode N2)
        {
            L_Ouverts.Remove(N2);
        }
        private void AjouterNoeudFerme(GenericNode N2)
        {
            L_Fermes.Add(N2);
        }
        private void verificationOuverts(SearchTree s)
        {
            foreach (GenericNode noeud in s.L_Ouverts)
            {

            }
        }
        private void verificationFermes(SearchTree s)
        {
            foreach (GenericNode noeud in s.L_Fermes)
            {

            }
        }
          
    }
}
