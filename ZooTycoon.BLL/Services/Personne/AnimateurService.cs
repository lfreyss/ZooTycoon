using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Personnes;

namespace ZooTycoon.BLL.Services.Personne
{
    public class AnimateurService : BaseService<Animateur>
    {
        public AnimateurService() { }

        public Animateur Add(string name, int age, int num, bool estManager, Animal animalFav)
        {
            return EntiteGestionnaire<Animateur>.Add(new Animateur(name, age,num,estManager,animalFav));
        }

    }
}
