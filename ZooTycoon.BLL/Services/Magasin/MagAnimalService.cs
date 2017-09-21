using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Services.Magasin
{
    public class MagAnimalService : BaseService<Mag_Animal>
    {
        public MagAnimalService() { }

        public Mag_Animal Add(string name, string Localisation)
        {
            return EntiteGestionnaire<Mag_Animal>.Add(new Mag_Animal(name, Localisation));
        }

        public List<String> DescriptionAllProduit(Mag_Animal item)
        {
            List<String> res = new List<String>();
            res.Add(item.Bienvenue());
            foreach (var x in item.listProd)
            {
                res.Add(x.Key.Description() + " Il en reste : " + x.Value);
            }

            return res;
        }

        public string VendreProduit(Mag_Animal mag, Prod_Alim item)
        {
            if (Zoo.tresorerie > item.Prix)
            {
                var res = mag.RemoveProduct(item);
                Stock.getStock().listStock.Add(item);
                if (res) {
                    Zoo.getInstance().RemoveMoney(item.Prix);
                    return "Vous avez acheté " + item.Nom;
                }
                else
                    return "L'achat de " + item.Nom + " n'a pas été possible.";
            }
            else
            {
                return "Le zoo n'a pas assez de trésorerie.";
            }
            
        }

    }
}
