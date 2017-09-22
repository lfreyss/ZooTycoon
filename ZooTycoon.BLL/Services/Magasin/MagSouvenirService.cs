using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Magasins;
using ZooTycoon.BLL.Model.Personnes;

namespace ZooTycoon.BLL.Services.Magasin
{
    public class MagSouvenirService : BaseService<Mag_Souvenirs>
    {
        public MagSouvenirService() { }

        public Mag_Souvenirs Add(string name, string Localisation)
        {
            return EntiteGestionnaire<Mag_Souvenirs>.Add(new Mag_Souvenirs(name, Localisation,10));
        }

        public List<String> DescriptionAllProduit(Mag_Souvenirs item)
        {
            List<String> res = new List<String>();
            res.Add(item.Bienvenue());
            foreach (var x in item.listProd)
            {
                res.Add(x.Key.Description() + " Il en reste : " + x.Value);
            }

            return res;
        }

        public Prod_Souvenirs GetOneProduct(Mag_Souvenirs mag, int index)
        {
            return mag.listProd.Skip(index-1).First().Key;
        }

        public string VendreProduit(Mag_Souvenirs mag, Prod_Souvenirs item, Client client)
        {
            if (client.Bourse > item.Prix)
            {
                var res = mag.RemoveProduct(item);
                var clientHasBuy = client.BuyProduit(item);
                if (res)
                {
                    Zoo.getInstance().AddMoney(item.Prix);
                    return clientHasBuy;
                }
                else
                    return "L'achat de " + item.Nom + " n'a pas été possible.";
            }
            else
            {
                return client.Nom + " n'a pas assez d'argent pour acheter " + item.Nom;
            }

        }

        public string OpenMagasin(Mag_Souvenirs item,Client client)
        {
            Random random = new Random();
            //int randomClient = random.Next(0, Zoo.listClient.Count());
            int randomNbAchat = random.Next(0,3);
            var res = "";
            switch (randomNbAchat)
            {
                case 0:
                    res = "** " + client.getName() + " sort sans rien n'acheter. **";
                    break;
                case 1:
                    int randomProduit = random.Next(0, item.listProd.Count());
                    res = "** " + VendreProduit(item,GetOneProduct(item, randomProduit),client) + " **";
                    break;
                case 2:
                    for (int i = 0; i < 2; i++)
                    {
                        int randomProd = random.Next(0, item.listProd.Count());
                        res += "** " + VendreProduit(item, GetOneProduct(item, randomProd), client) + " **";
                    }
                    break;
                case 3:
                    for (int i = 0; i < 3; i++)
                    {
                        int randomProd = random.Next(0, item.listProd.Count());
                        res += "** " + VendreProduit(item, GetOneProduct(item, randomProd), client) + " **";
                    }
                    break;
                
                default:
                    res = "Fin du spectacle";
                    break;
            }
            return res;
        } 

    }
}
