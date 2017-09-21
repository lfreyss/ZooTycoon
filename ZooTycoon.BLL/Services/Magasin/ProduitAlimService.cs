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
    public class ProduitAlimService : BaseService<Prod_Alim>
    {
        public ProduitAlimService() { }

        public Prod_Alim Add(string name, string Type, int Prix, bool estMangeable, bool estSolide)
        {
            return EntiteGestionnaire<Prod_Alim>.Add(new Prod_Alim(name, Type, Prix, estMangeable, estSolide));
        }

        public List<String> DescriptionAllProduit(Enclos enclos)
        {
            List<String> res = new List<String>();
            enclos.listAnimaux.FirstOrDefault().listAlim.ForEach(x => res.Add(x.Description() + " Il en reste " + Stock.getStock().listStock.Where(p => p.Nom == x.Nom).Count() + " en stock."));
            return res;
        }
       
    }
}
