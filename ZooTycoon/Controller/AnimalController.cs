using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Services;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Services.Container;
using System.Threading;
using ZooTycoon.BLL.Model.Personnes;
using ZooTycoon.BLL.Model.Magasins;
using ZooTycoon.BLL.Model;

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

        public Enclos GetEnclosById(int Id) 
        {
            return _uow.EnclosService().GetOneById(Id);
        }

        public Prod_Alim GetProduitById(int Id)
        {
            return _uow.ProduitAlimService().GetOneById(Id);
        }

        public string DescriptionEnclos(Enclos item)
        {
            return _uow.EnclosService().Description(item);
        }
        public string DescriptionSpectacle(Spectacle item)
        {
            return _uow.SpectacleService().Description(item);
        }
        public string DescriptionAnimateur(Spectacle item)
        {
            return _uow.SpectacleService().DescriptionAnimateur(item);
        }

        public List<string> DescriptionAllProduct(Enclos enclos)
        {
            return _uow.ProduitAlimService().DescriptionAllProduit(enclos);
        }

        public string StartSpectacle(Spectacle spectacle)
        {
            Thread.Sleep(1000);
            return _uow.SpectacleService().DoTheSpectacle(spectacle);
        }

        public string DonnerManger(Prod_Alim item, Enclos enclos)
        {
            var soigneur = _uow.SoigneurService().GetOneAvailable();
            if (!_uow.StockService().hasProductInStock(item))
                return "Le " + item.Nom + " n'est plus en stock, veuillez en racheter en magasin.";
            if (soigneur == null)
                return "Il n'y a pas de soigneur disponible";
            return _uow.SoigneurService().DonnerManger(soigneur, item, enclos);
        }

        public string AcheterEnclos(string nom, int taille, string type)
        {
            if (taille * 2 < Zoo.tresorerie)
                return "Vous venez de construire un nouvelle enclos : " + _uow.EnclosService().Add(nom, taille, type, new List<Animal>(), new List<Spectacle>()).Description();
            else
                return "Vous n'avez pas les fonds financiers suffisants pour construire cet enclos...";
        }

        public string AcheterAnimal(string nom, int age, string race, string sexe, string animal, Enclos enclos) 
        {
            Animal item = null;
            switch (animal) {
                case "1":
                     item = (Animal)_uow.BaleineService().Add(nom, age, race, (sexe == "M") ? true : false, 2);
                    break;
                case "2":
                    item = (Animal)_uow.LamaService().Add(nom, age, race, (sexe == "M") ? true : false, "brun");
                    break;
                case "3":
                    item = (Animal)_uow.HuitreService().Add(nom, age, race, (sexe == "M") ? true : false, true);
                    break;
                case "4":
                    item = (Animal)_uow.PterodactyleService().Add(nom, age, race, (sexe == "M") ? true : false, 10);
                    break;
                case "5":
                    item = (Animal)_uow.OrnithorynqueService().Add(nom, age, race, (sexe == "M") ? true : false, 10);
                    break;
                default : 
                        break;

            }
            return _uow.EnclosService().BuyAnimal(item, enclos);

        }
    }
}
