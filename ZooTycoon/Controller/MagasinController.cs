using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model.Magasins;
using ZooTycoon.BLL.Model.Personnes;
using ZooTycoon.BLL.Services.Container;

namespace ZooTycoon.Controller
{
    public class MagasinController
    {
        private UnitOfWork _uow { get; set; }

        public MagasinController(UnitOfWork _uow)
        {
            this._uow = _uow;
        }

        public Mag_Animal AddMagasinAnimal(string name, string localisation)
        {
            return _uow.MagAnimalService().Add(name, localisation);
        }

        public List<Mag_Animal> GetAllMagAnimal()
        {
            return _uow.MagAnimalService().GetAll();
        }

        public List<string> GetAllProdMagAnimal(Mag_Animal item)
        {
            return _uow.MagAnimalService().DescriptionAllProduit(item);
        }

        public Mag_Animal GetMagasinById(int id)
        {
            return _uow.MagAnimalService().GetOneById(id);
        }

        public string VendreProduit(int magasinId, int id)
        {
            return _uow.MagAnimalService().VendreProduit(_uow.MagAnimalService().GetOneById(magasinId),_uow.ProduitAlimService().GetOneById(id));
        }

        public string getTresorerieZoo()
        {
            return _uow.ZooService().GetTresorerie().ToString();
        }
    }
}
