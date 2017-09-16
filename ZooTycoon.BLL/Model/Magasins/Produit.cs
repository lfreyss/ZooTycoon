using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Magasins
{
    public abstract class Produit : BaseEntity
    {

        public string Nom { get; set; }
        public string Type { get; set; }
        public int Prix { get; set; }

        public Produit(string Nom, string Type, int Prix) : base() {
            this.Nom = Nom;
            this.Type = Type;
            this.Prix = Prix;
        }

    }
}
