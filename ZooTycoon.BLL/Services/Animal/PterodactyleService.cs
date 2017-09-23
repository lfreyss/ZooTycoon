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
    public class PterodactyleService : BaseService<Pterodactyle>
    {
        public PterodactyleService() { }

        public Pterodactyle Add(string name, int age, string race, bool sexe, int longueurBec)
        {
            return EntiteGestionnaire<Pterodactyle>.Add(new Pterodactyle(name, age, race, sexe, longueurBec));
        }
        public Pterodactyle Buy(string name, int age, string race, bool sexe, int longueurBec)
        {
            var Animal = new Pterodactyle(name, age, race, sexe, longueurBec);
            if (Animal.Prix < Zoo.tresorerie)
            {
                Zoo.tresorerie -= Animal.Prix;
                return EntiteGestionnaire<Pterodactyle>.Add(Animal);
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
