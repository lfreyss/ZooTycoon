using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Magasins
{
    public class Stock : Magasin
    {
        public List<Prod_Alim> listStock { get; set; }
        private static Stock _instance;

        public Stock(string Nom, string Localisation)
            : base(Nom, Localisation)
        {
            this.listStock = new List<Prod_Alim>();
        }

        public static Stock getStock(string Nom, string Localisation)
        {
            if (_instance == null)
                _instance = new Stock(Nom, Localisation);
            return _instance;
        }

        public static Stock getStock()
        {
            return _instance;
        }

        public bool RemoveProd(Prod_Alim item)
        {
            var index = this.listStock.First(x => x.Nom == item.Nom);
            if (index != null)
            {
                listStock.Remove(index);
                return true;
            }
            return false;
        }

        public override void VerifierStock()
        {

        }
    }
}
