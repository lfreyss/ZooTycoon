using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Magasins
{
    public abstract class Magasin : BaseEntity
    {

        public string Nom { get; set; }
        public string Localisation { get; set; }

        public Magasin(string Nom, string Localisation) : base() {
            this.Nom = Nom;
            this.Localisation = Localisation;
        }

        public abstract void VerifierStock();

    }
}
