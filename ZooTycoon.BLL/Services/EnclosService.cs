using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Animaux;

namespace ZooTycoon.BLL.Services
{
    public class EnclosService : BaseService<Enclos>
    {
        public EnclosService() { }

        public Enclos Add(string name, int taille, string type, List<Animal> listAnimaux, List<Spectacle> listSpectacles)
        {
            return EntiteGestionnaire<Enclos>.Add(new Enclos(name,taille,type, listAnimaux, listSpectacles));
        }

        public string Description(Enclos item)
        {
           return item.Description();   
        }
    }
}
