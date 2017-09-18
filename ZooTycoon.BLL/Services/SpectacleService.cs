using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Personnes;

namespace ZooTycoon.BLL.Services
{
    public class SpectacleService : BaseService<Spectacle>
    {
        public SpectacleService() { }

        public Spectacle Add(string name, DateTime Horraire, Enclos enclos, List<Animateur> listAnimateur)
        {
            return EntiteGestionnaire<Spectacle>.Add(new Spectacle(name, Horraire, enclos, listAnimateur));
        }

        public string Description(Spectacle item)
        {
            return item.Description();   
        }

        public string DescriptionAnimateur(Spectacle item)
        {
            return item.DescriptionAnimateur();
        }

        public void AddSpectateur(Spectacle item)
        {
            item.AddSpectateur();
        }

        public string DoTheSpectacle(Spectacle item)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            int randomAnimal = random.Next(0, item.Enclos.listAnimaux.Count);
            var res = "";
            switch (randomNumber)
            {
                case 0:
                    res = "** " + item.Enclos.listAnimaux[randomAnimal].Nom + " Eclabouse sur le public**";
                    break;
                case 1:
                    res = "** " + item.Enclos.listAnimaux[randomAnimal].Nom + " Fait une pirouette**";
                    break;
                case 2:
                    res = "** " + item.Enclos.listAnimaux[randomAnimal].Nom + " Joue avec un cerceau**";
                    break;
                case 3:
                    res = "** " + item.Enclos.listAnimaux[randomAnimal].Nom + " Marche en reculons**";
                    break;
                case 4:
                    res = "** " + item.Enclos.listAnimaux[randomAnimal].Nom + " Refuse et fait la tête**";
                    break;
                default:
                    res = "Fin du spectacle";
                    break;
            }
            return res;
        } 
    }
}
