using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Magasins
{
    public class Mag_Souvenirs : Magasin
    {
        public int Pourcentage_Reduc { get; set; }
        public Dictionary<Prod_Souvenirs, int> listProd { get; set; }
        public Mag_Souvenirs(string Nom, string Localisation, int Pourcentage_Reduc) : base(Nom, Localisation) {
            this.Pourcentage_Reduc = Pourcentage_Reduc;
            listProd = new Dictionary<Prod_Souvenirs, int>();
        }

        public string Bienvenue()
        {
            return Nom + " vous souhaite la bienvenue, ci-dessous notre vitrine :";
        }

        public override string Description()
        {
            return base.Description() + ". Une réduction de " + Pourcentage_Reduc + "% est appliqué toute les 10 ventes de produit.";
        }

        public void AddProduct(Prod_Souvenirs item)
        {
            if (listProd.ContainsKey(item))
            {
                listProd[item]++;
            }
            else
                listProd.Add(item, 1);

        }

        public bool RemoveProduct(Prod_Souvenirs item)
        {
            if (listProd.ContainsKey(item))
            {
                if (listProd[item] == 0)
                {
                    return false;
                }
                else
                {
                    listProd[item]--;
                    return true;
                }
            }
            return false;
        }

        public override void VerifierStock()
        {
            throw new NotImplementedException();
        }

        public void DonnerCadeau()
        {

        }

        public void AppliquerReduction()
        {

        }
    }
}
