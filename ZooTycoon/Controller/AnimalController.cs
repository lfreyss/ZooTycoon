using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Services;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Services.Container;
using System.Threading;

namespace ZooTycoon.Controller
{
    public class AnimalController
    {
        private UnitOfWork _uow { get; set; }

        public AnimalController(UnitOfWork _uow)
        {
            this._uow = _uow;
        }

        public Huitre AddHuitre(string name, int age, string race, bool sexe, bool aPerle)
        {
            return _uow.HuitreService().Add(name, age, race, sexe, aPerle);
        }

        public Baleine AddBaleine(string name, int age, string race, bool sexe, int nbNageoire)
        {
            return _uow.BaleineService().Add(name, age, race, sexe, nbNageoire);
        }

        public List<Huitre> GetAllHuitre()
        {
            return _uow.HuitreService().GetAll();
        }
        public List<Baleine> GetAllBaleine()
        {
            return _uow.BaleineService().GetAll();
        }
        public List<Enclos> GetAllEnclos()
        {
            return _uow.EnclosService().GetAll();
        }
        public List<Spectacle> GetAllSpectacles()
        {
            return _uow.SpectacleService().GetAll();
        }
        public void DescriptionEnclos(Enclos item)
        {
            Console.WriteLine(_uow.EnclosService().Description(item));
        }
        public void DescriptionSpectacle(Spectacle item)
        {
            Console.WriteLine(_uow.SpectacleService().Description(item));
        }
        public string DescriptionAnimateur(Spectacle item)
        {
            return _uow.SpectacleService().DescriptionAnimateur(item);
        }

        public string StartSpectacle(Spectacle spectacle)
        {
            Thread.Sleep(1000);
            return _uow.SpectacleService().DoTheSpectacle();
        }
    }
}
