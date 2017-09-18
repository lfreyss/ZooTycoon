using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Magasins
{
    public class Prod_Alim : Produit
    {
        public bool EstMangeable { get; set; }
        public bool EstSolide { get; set; }

        public Prod_Alim(string Nom, string Type, int Prix, bool EstMangeable, bool EstSolide)
            : base(Nom, Type, Prix)
        {
            this.EstSolide = EstSolide;
            this.EstMangeable = EstMangeable;
        }

        public string Description()
        {
            return base.Description() + " destinnées aux  " + (EstMangeable ? "à la clientèle." : " animaux.");
        }
    }
}
