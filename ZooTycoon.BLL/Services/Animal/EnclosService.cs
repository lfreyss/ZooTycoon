using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Model.Animaux;

namespace ZooTycoon.BLL.Services
{
    public class EnclosService : BaseService<Enclos>
    {
        public EnclosService() { }

        public Enclos Add(string name, int taille, string type, List<Animal> listAnimaux, List<Spectacle> listSpectacles)
        {
            return EntiteGestionnaire<Enclos>.Add(new Enclos(name,taille,type, listAnimaux, listSpectacles));
        }

        public string BuyAnimal(Animal item, Enclos enclos)
        {
            if((enclos.listAnimaux.Count != 0 && enclos.listAnimaux[0].GetType().Name.ToString() == item.GetType().Name.ToString()) || enclos.listAnimaux.Count == 0)
            {
                var tailleOccupe = 0;
                enclos.listAnimaux.ForEach(x => tailleOccupe += x.EspaceNecessaire);
                if (enclos.Taille > tailleOccupe + item.EspaceNecessaire)
                {
                    enclos.listAnimaux.Add(item);
                    Zoo.tresorerie -= item.Prix;
                    return item.Nom + " a été rajouté à l'enclos " + enclos.Nom;
                }
                else
                {
                    return enclos.Nom + " n'a pas l'espace nécessaire pour acceuillir un animal supplémentaire";
                }
            } else
            {
                return "On ne peut pas mélanger les espèces dans un même enclos...";
            }
          
        }

        public string Description(Enclos item)
        {
           return item.Description();   
        }
    }
}
