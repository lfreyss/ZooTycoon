﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Services.Magasin;
using ZooTycoon.BLL.Services.Personne;

namespace ZooTycoon.BLL.Services.Container
{
    public class UnitOfWork
    {
        private static HuitreService _huitreService;
        private static BaleineService _baleineService;
        private static LamaService _lamaService;
        private static OrnithorynqueService _ornithorynqueService;
        private static PterodactyleService _pterodactyleService;
        private static EnclosService _enclosService;
        private static SpectacleService _spectacleService;
        private static AnimateurService _animateurService;
        private static ClientService _clientService;
        private static ZooService _zooService;
        private static SoigneurService _soigneurService;
        private static ProduitAlimService _produitAlimService;
        private static ProduitSouvenirService _produitSouvenirService;
        private static StockService _stockService;
        private static MagAnimalService _magAnimalService;
        private static MagSouvenirService _magSouvenirService;

        public UnitOfWork() { }
       
        #region animal
        public LamaService LamaService()
        {
            if (_lamaService == null)
                _lamaService = new LamaService();
            return _lamaService;
        }
        public OrnithorynqueService OrnithorynqueService()
        {
            if (_ornithorynqueService == null)
                _ornithorynqueService = new OrnithorynqueService();
            return _ornithorynqueService;
        }
        public PterodactyleService PterodactyleService()
        {
            if (_pterodactyleService == null)
                _pterodactyleService = new PterodactyleService();
            return _pterodactyleService;
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

        public SoigneurService SoigneurService()
        {
            if (_soigneurService == null)
                _soigneurService = new SoigneurService();
            return _soigneurService;
        }

        public ZooService ZooService()
        {
            if (_zooService == null)
                _zooService = new ZooService(this);
            return _zooService;
        }
        #endregion

        #region Magasin
        public ProduitAlimService ProduitAlimService()
        {
            if (_produitAlimService == null)
                _produitAlimService = new ProduitAlimService();
            return _produitAlimService;
        }
        public StockService StockService()
        {
            if (_stockService == null)
                _stockService = new StockService();
            return _stockService;
        }
        
        public MagAnimalService MagAnimalService()
        {
            if (_magAnimalService == null)
                _magAnimalService = new MagAnimalService();
            return _magAnimalService;
        }
        public MagSouvenirService MagSouvenirService()
        {
            if (_magSouvenirService == null)
                _magSouvenirService = new MagSouvenirService();
            return _magSouvenirService;
        }
        public ProduitSouvenirService ProduitSouvenirService()
        {
            if (_produitSouvenirService == null)
                _produitSouvenirService = new ProduitSouvenirService();
            return _produitSouvenirService;
        }
        #endregion
    }
}
