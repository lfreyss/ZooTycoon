using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Animaux;

namespace ZooTycoon.DAL.Repository
{
    public class BaleineRepository
    {
        private ZooContext _context { get; set; }
        public BaleineRepository(ZooContext context)
        {
            _context = context;
        }

        public void Add(Baleine item)
        {
            if (item is Baleine)
                _context.listBaleine.Add((Animal)item);
        }

        public void Remove(Baleine item)
        {
            if (item is Baleine)
                _context.listBaleine.Remove((Animal)item);
        }

        public List<Animal> getItems()
        {
            return _context.listBaleine;
        }
    }
}
