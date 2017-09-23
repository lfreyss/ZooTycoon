using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Magasins;
using ZooTycoon.BLL.Model.Personnes;
using ZooTycoon.BLL.Services;
using ZooTycoon.BLL.Services.Container;

namespace ZooTycoon.Controller
{
    public class HomeController
    {
        private UnitOfWork _uow = new UnitOfWork();

        public HomeController(UnitOfWork _uow)
        {
            this._uow = _uow;
        }
        
        public void initialisation()
        {
            initialize();
            initalizeEnclos();
        }

        public void initialize()
        {
            _uow.HuitreService().Add("H1", 1, "ocean", true, true);
            _uow.HuitreService().Add("H2", 4, "mer", false, false);
            _uow.HuitreService().Add("H3", 3, "ocean", true, false);
            _uow.HuitreService().Add("H4", 1, "mer", false, false);

            _uow.BaleineService().Add("B1", 1, "ocean", true, 2);
            _uow.BaleineService().Add("B2", 4, "mer", false, 2);
            _uow.BaleineService().Add("B3", 3, "ocean", true, 2);
            _uow.BaleineService().Add("B4", 1, "mer", false, 2);
        }

        public void initalizeEnclos()
        {
            List<Animal> listHuitre = new List<Animal>();
            List<Animal> listBaleine = new List<Animal>();

            var mag = _uow.MagAnimalService().Add("Pedigree", "Nord-Est");

            _uow.StockService().GetStock("StockAnimal", "SudOuest");
            var algue = _uow.ProduitAlimService().Add("Algue", "Plante", 300, false, true);
            var avoine = _uow.ProduitAlimService().Add("Avoine", "Céréale", 500, false, true);
            var viande = _uow.ProduitAlimService().Add("Viande", "Viande", 900, false, true);
            var ble = _uow.ProduitAlimService().Add("Blé", "Céréale", 400, false, true); 
            var herbe = _uow.ProduitAlimService().Add("Herbe", "Plante", 500, false, true);
            var plancton = _uow.ProduitAlimService().Add("Plancton", "Poisson", 700, false, true);
            var crustace = _uow.ProduitAlimService().Add("Petite crustacé", "Poisson", 500, false, true); 
            _uow.StockService().AddProdToStock(algue);
            mag.AddProduct(algue);
            mag.AddProduct(algue);
            mag.AddProduct(algue);
            mag.AddProduct(avoine);
            mag.AddProduct(avoine);
            mag.AddProduct(crustace);
            mag.AddProduct(crustace);
            mag.AddProduct(crustace);
            mag.AddProduct(crustace);
            mag.AddProduct(crustace);
            mag.AddProduct(plancton);
            mag.AddProduct(plancton);
            mag.AddProduct(plancton);
            mag.AddProduct(plancton);
            mag.AddProduct(plancton);
            mag.AddProduct(plancton);
            mag.AddProduct(herbe);
            mag.AddProduct(herbe);
            mag.AddProduct(herbe);
            mag.AddProduct(ble);
            mag.AddProduct(ble);
            mag.AddProduct(ble);
            mag.AddProduct(ble);
            mag.AddProduct(ble);
            mag.AddProduct(ble);
            mag.AddProduct(viande);
            mag.AddProduct(viande);
            mag.AddProduct(viande);

            _uow.HuitreService().GetAll().ForEach( x => {
                listHuitre.Add((Animal)x);
            });
            _uow.BaleineService().GetAll().ForEach(x =>
            {
                listBaleine.Add((Animal)x);
            });

            _uow.EnclosService().Add("EnclosHuitre", 100, "Habitation", listHuitre, null);
            var enclosBaleine = _uow.EnclosService().Add("EnclosBaleine", 1000, "Habitation", listBaleine, null);

            _uow.EnclosService().Add("EnclosSpectacleBaleine", 1000, "Spectacle", listBaleine, null);

            var anim1 = _uow.AnimateurService().Add("AnimateurBaleine", 25, 0000, false, _uow.BaleineService().GetOneById(5));
            var anim2 = _uow.AnimateurService().Add("AnimateurBaleineManager", 45, 0000, true, _uow.BaleineService().GetOneById(7));
            _uow.SoigneurService().Add("SoigneurBOB", 34, 0000, true, _uow.BaleineService().GetOneById(7));
            _uow.SoigneurService().Add("SoigneurDAB", 21, 0000, false, _uow.BaleineService().GetOneById(7));

            _uow.SpectacleService().Add("SpectacleHuitre", DateTime.Today, enclosBaleine, new List<Animateur>() { anim1, anim2 });
        }

        public Mag_Souvenirs GetMagasin()
        {
            var mag = _uow.MagSouvenirService().Add("ZooTycoonShop", "Ouest");
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Dino", "Jouet", 15, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Huitre", "Peluche", 10, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("CartePostale", "Carte", 2, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("TireBouchon", "Divers", 4, "Adulte"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            mag.AddProduct(_uow.ProduitSouvenirService().Add("Baleine", "Peluche", 30, "Enfant"));
            return mag;
        }
    }
}
