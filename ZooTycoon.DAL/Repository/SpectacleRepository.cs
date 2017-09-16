using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Animaux;

namespace ZooTycoon.DAL.Repository
{
    public class SpectacleRepository
    {
        private ZooContext _context { get; set; }
        public SpectacleRepository(ZooContext context)
        {
            _context = context;
        }

        public void Add(Spectacle item)
        {
            if (item is Spectacle)
                _context.listSpectacle.Add(item);
        }

        public void Remove(Spectacle item)
        {
            if (item is Spectacle)
                _context.listSpectacle.Remove(item);
        }

        public List<Animal> getItems()
        {
            return _context.listSpectacle;
        }
    }
}
