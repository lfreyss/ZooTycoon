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
        public List<Prod_Souvenirs> listProd { get; set; }
        public Mag_Souvenirs(string Nom, string Localisation, int Pourcentage_Reduc) : base(Nom, Localisation) {
            this.Pourcentage_Reduc = Pourcentage_Reduc;
            listProd = new List<Prod_Souvenirs>();
        }

        public override void VerifierStock()
        {

        }

        public void DonnerCadeau()
        {

        }

        public void AppliquerReduction()
        {

        }
    }
}
