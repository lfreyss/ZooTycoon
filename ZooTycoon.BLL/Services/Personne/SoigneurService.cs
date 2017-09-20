using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Magasins;
using ZooTycoon.BLL.Model.Personnes;

namespace ZooTycoon.BLL.Services.Personne
{
    public class SoigneurService : BaseService<Soigneur>
    {
        public SoigneurService() { }

        public Soigneur Add(string name, int age, int num, bool estManager, Animal animalFav)
        {
            return EntiteGestionnaire<Soigneur>.Add(new Soigneur(name, age, num, estManager, animalFav));
        }

        public string DonnerManger(Soigneur soigneur, Prod_Alim item, Enclos enclos)
        {
            soigneur.estDisponible = false;
            var res = "Le Soigneur " + soigneur.Nom + " donne " + item.Nom + " à manger dans l'enclos " + enclos.Nom + ".\n";
            enclos.listAnimaux.ForEach(x =>
            {
                res += x.Mange(item);
            });
            Stock.getStock().listStock.Remove(item);
            return res;
        }

        public Soigneur GetOneAvailable()
        {
            return GetAll().First(x => x.estDisponible);
        }
    }
}
