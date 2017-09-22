using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Services.Magasin
{
    public class ProduitSouvenirService : BaseService<Prod_Souvenirs>
    {
        public ProduitSouvenirService() { }

        public Prod_Souvenirs Add(string name, string Type, int Prix, string Gamme)
        {
            return EntiteGestionnaire<Prod_Souvenirs>.Add(new Prod_Souvenirs(name, Type, Prix, Gamme));
        }
    }
}
