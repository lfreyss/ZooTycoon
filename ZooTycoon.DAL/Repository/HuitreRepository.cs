using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Animaux;
using ZooTycoon.DAL.Model.Interface;

namespace ZooTycoon.DAL.Repository
{
    public class HuitreRepository
    {
        private ZooContext _context { get; set; }
        public HuitreRepository(ZooContext context)
        {
            _context = context;
        }

        public void Add(Huitre item)
        {
            if(item is Huitre)
                 _context.listHuitre.Add((Animal)item);
        }

        public void Remove(Huitre item)
        {
            if (item is Huitre)
                _context.listHuitre.Remove((Animal)item);
        }

        public List<Animal> getItems()
        {
            return _context.listHuitre;
        }

    }
}
