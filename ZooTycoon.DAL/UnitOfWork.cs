using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Gestionnaire;
using ZooTycoon.DAL.Repository;

namespace ZooTycoon.DAL
{
    public class UnitOfWork
    {
        private ZooContext _context = new ZooContext();
        private HuitreRepository _huitreRepository;
        private BaleineRepository _baleineRepository;
        private EnclosRepository _enclosRepository;
        private SpectacleRepository _spectacleRepository;
        private AnimateurRepository _animateurRepository;

        public HuitreRepository huitreRepository
        {
            get
            {
              if(this._huitreRepository == null) this._huitreRepository = new HuitreRepository(_context);
              return _huitreRepository;
            }
        }

        public BaleineRepository baleineRepository
        {
            get
            {
                if (this._baleineRepository == null) this._baleineRepository = new BaleineRepository(_context);
                return _baleineRepository;
            }
        }

        public EnclosRepository enclosRepository
        {
            get
            {
                if (this._enclosRepository == null) this._enclosRepository = new EnclosRepository(_context);
                return _enclosRepository;
            }
        }

        public SpectacleRepository spectacleRepository
        {
            get
            {
                if (this._spectacleRepository == null) this._spectacleRepository = new SpectacleRepository(_context);
                return _spectacleRepository;
            }
        }

        public AnimateurRepository animateurRepository
        {
            get
            {
                if (this._animateurRepository == null) this._animateurRepository = new AnimateurRepository(_context);
                return _animateurRepository;
            }
        }



    }
}
