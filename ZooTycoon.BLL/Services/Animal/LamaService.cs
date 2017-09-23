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
    public class LamaService : BaseService<Lama>
    {
        public LamaService() { }

        public Lama Add(string name, int age, string race, bool sexe,string pelages)
        {
            return EntiteGestionnaire<Lama>.Add(new Lama(name, age, race, sexe, pelages));
        }
        public Lama Buy(string name, int age, string race, bool sexe, string pelages)
        {
            var Animal = new Lama(name, age, race, sexe, pelages);
            if (Animal.Prix < Zoo.tresorerie)
            {
                Zoo.tresorerie -= Animal.Prix;
                return EntiteGestionnaire<Lama>.Add(Animal);
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
