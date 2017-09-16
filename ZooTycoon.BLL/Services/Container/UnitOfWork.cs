using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Services.Personne;

namespace ZooTycoon.BLL.Services.Container
{
    public class UnitOfWork
    {
        private static HomeService _homeService;
        private static HuitreService _huitreService;
        private static BaleineService _baleineService;
        private static EnclosService _enclosService;
        private static SpectacleService _spectacleService;
        private static AnimateurService _animateurService;
        private static ClientService _clientService;
        private static ZooService _zooService;

        public UnitOfWork() { }

        #region animal
        public HomeService HomeService()
        {
            if (_homeService == null)
                _homeService = new HomeService();
            return _homeService;
        }
        public HuitreService HuitreService()
        {
            if (_huitreService == null)
                _huitreService = new HuitreService();
            return _huitreService;
        }
        public BaleineService BaleineService()
        {
            if (_baleineService == null)
                _baleineService = new BaleineService();
            return _baleineService;
        }
        public EnclosService EnclosService()
        {
            if (_enclosService == null)
                _enclosService = new EnclosService();
            return _enclosService;
        }
        public SpectacleService SpectacleService()
        {
            if (_spectacleService == null)
                _spectacleService = new SpectacleService();
            return _spectacleService;
        }
        #endregion

        #region personne
        public AnimateurService AnimateurService()
        {
            if (_animateurService == null)
                _animateurService = new AnimateurService();
            return _animateurService;
        }
        public ClientService ClientService()
        {
            if (_clientService == null)
                _clientService = new ClientService();
            return _clientService;
        }
        public ZooService ZooService()
        {
            if (_zooService == null)
                _zooService = new ZooService(this);
            return _zooService;
        }
        #endregion
    }
}
