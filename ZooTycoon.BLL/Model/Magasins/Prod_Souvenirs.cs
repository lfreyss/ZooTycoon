using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Magasins
{
    public class Prod_Souvenirs : Produit
    {
        public string Gamme { get; set; }

        public Prod_Souvenirs(string Nom, string Type, int Prix, string Gamme) : base(Nom, Type, Prix)
        {
            this.Gamme = Gamme;
        }
    }
}
