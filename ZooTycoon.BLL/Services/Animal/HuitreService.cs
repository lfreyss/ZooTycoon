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
    public class HuitreService : BaseService<Huitre>
    {
        public HuitreService() { }

        public Huitre Add(string name, int age, string race, bool sexe, bool aPerle)
        {
            return EntiteGestionnaire<Huitre>.Add(new Huitre(name, age, race, sexe, aPerle));
        }
        public Huitre Buy(string name, int age, string race, bool sexe, bool aPerle)
        {
            var Animal = new Huitre(name, age, race, sexe, aPerle);
            if (Animal.Prix < Zoo.tresorerie)
            {
                Zoo.tresorerie -= Animal.Prix;
                return EntiteGestionnaire<Huitre>.Add(Animal);
            }
            else
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
