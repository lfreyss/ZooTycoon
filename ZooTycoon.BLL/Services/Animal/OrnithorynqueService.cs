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
    public class OrnithorynqueService : BaseService<Ornithorynque>
    {
        public OrnithorynqueService() { }

        public Ornithorynque Add(string name, int age, string race, bool sexe, int tailleGriffes)
        {
            return EntiteGestionnaire<Ornithorynque>.Add(new Ornithorynque(name, age, race, sexe, tailleGriffes));
        }
        public Ornithorynque Buy(string name, int age, string race, bool sexe, int tailleGriffes)
        {
            var Animal = new Ornithorynque(name, age, race, sexe, tailleGriffes);
            if (Animal.Prix < Zoo.tresorerie)
            {
                Zoo.tresorerie -= Animal.Prix;
                return EntiteGestionnaire<Ornithorynque>.Add(Animal);
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
