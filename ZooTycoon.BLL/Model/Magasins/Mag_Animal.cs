using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Magasins
{
    public class Mag_Animal : Magasin
    {
        public Dictionary<Prod_Alim,int> listProd { get; set; }
        public Mag_Animal(string Nom, string Localisation)
            : base(Nom, Localisation)
        {
            listProd = new Dictionary<Prod_Alim,int>();
        }

        public string Bienvenue()
        {
            return Nom + " vous souhaite la bienvenue, ci-dessous notre vitrine :";
        }

        public override string Description()
        {
           return base.Description();
        }

        public void AddProduct(Prod_Alim item) {
            if (listProd.ContainsKey(item))
            {
                listProd[item]++ ;
            }
            else
                listProd.Add(item, 1);

        }

        public bool RemoveProduct(Prod_Alim item)
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
    }
}
