using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Magasins
{
    public class Mag_Boissons : Magasin
    {
        public bool VenteAlcohol { get; set; }

        public Mag_Boissons(string Nom, string Localisation, bool VenteAlcohol) : base(Nom, Localisation)
        {
            this.VenteAlcohol = VenteAlcohol;
        }

        public override void VerifierStock()
        {

        }
    }
}
