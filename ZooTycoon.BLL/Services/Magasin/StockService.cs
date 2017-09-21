using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Services.Magasin
{
    public class StockService : BaseService<Stock>
    {
        public StockService() { }

        public Stock GetStock(string name, string localisation)
        {
            return Stock.getStock(name, localisation);
        }

        //public List<String> DescriptionAllStock()
        //{
        //    List<String> res = new List<String>();
        //    enclos.listAnimaux.FirstOrDefault().listAlim.ForEach(x => res.Add(x.Description()));
        //    return res;
        //}

        public bool hasProductInStock(Prod_Alim item)
        {
            if(Stock.getStock().listStock.Contains(item))
                return true;
            else 
                return false;
        }

        public string AddProdToStock(Prod_Alim item)
        {
            Stock.getStock().listStock.Add(item);
            return "Le " + item.Nom + " a été rajouté au stock.";
        }

        public int HowManyInStock(Prod_Alim item)
        {
            return Stock.getStock().listStock.Where(x => x.Nom == item.Nom).Count();
        }

    }
}
