using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Model.Animaux;
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

            _uow.StockService().GetStock("StockAnimal", "SudOuest");
            var algue = _uow.ProduitAlimService().Add("Algue", "Plante", 30, false, true);
            _uow.StockService().AddProdToStock(algue);

            _uow.HuitreService().GetAll().ForEach( x => {
                x.listAlim.Add(algue);
                listHuitre.Add((Animal)x);
            });
            _uow.BaleineService().GetAll().ForEach(x =>
            {
                x.listAlim.Add(_uow.ProduitAlimService().Add("Avoine", "Céréale", 50, false, true));
                listBaleine.Add((Animal)x);
            });

            _uow.EnclosService().Add("EnclosHuitre", 100, "Habitation", listHuitre, null);
            _uow.EnclosService().Add("EnclosBaleine", 1000, "Habitation", listBaleine, null);

            _uow.EnclosService().Add("EnclosSpectacleBaleine", 1000, "Spectacle", listBaleine, null);

            _uow.AnimateurService().Add("AnimateurBaleine", 25, 0000, false, _uow.BaleineService().GetOneById(5));
            _uow.AnimateurService().Add("AnimateurBaleineManager", 45, 0000, true, _uow.BaleineService().GetOneById(7));
            _uow.SoigneurService().Add("SoigneurBOB", 34, 0000, true, _uow.BaleineService().GetOneById(7));
            _uow.SoigneurService().Add("SoigneurDAB", 21, 0000, false, _uow.BaleineService().GetOneById(7));

            _uow.SpectacleService().Add("SpectacleHuitre", DateTime.Today, _uow.EnclosService().GetOneById(10), new List<Animateur>() { _uow.AnimateurService().GetOneById(11), _uow.AnimateurService().GetOneById(12) });

            

        }
    }
}
