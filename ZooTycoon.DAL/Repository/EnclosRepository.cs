using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Animaux;

namespace ZooTycoon.DAL.Repository
{
    public class EnclosRepository
    {
        private ZooContext _context { get; set; }
        public EnclosRepository(ZooContext context)
        {
            _context = context;
        }

        public void Add(Enclos item)
        {
            if (item is Enclos)
                _context.listEnclos.Add(item);
        }

        public void Remove(Enclos item)
        {
            if (item is Enclos)
                _context.listEnclos.Remove(item);
        }

        public List<Animal> getItems()
        {
            return _context.listEnclos;
        }
    }
}
