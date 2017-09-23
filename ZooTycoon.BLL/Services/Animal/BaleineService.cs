using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Services
{
    public class BaleineService : BaseService<Baleine>
    {
        public BaleineService() { }

        public Baleine Add(string name, int age, string race, bool sexe, int nbNageoire)
        {
            return EntiteGestionnaire<Baleine>.Add(new Baleine(name, age, race, sexe, nbNageoire));
        }

        public Baleine Buy(string name, int age, string race, bool sexe, int nbNageoire)
        {
            var Animal = new Baleine(name, age, race, sexe, nbNageoire);
            if (Animal.Prix < Zoo.tresorerie)
            {
                Zoo.tresorerie -= Animal.Prix;
                return EntiteGestionnaire<Baleine>.Add(Animal);
            } else
            {
                return null;
            }
        }

        public void AddAlim(Animal item, Prod_Alim prod)
        {
            item.listAlim.Add(prod);
        }
    }
}
