using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Animaux;
using ZooTycoon.DAL.Model.Interface;

namespace ZooTycoon.DAL.Gestionnaire
{
    public class AnimalRepository<T> where T : IAnimal
    {
        private ZooContext _context { get; set; }
        public AnimalRepository(ZooContext context)
        {
            _context = context;
        }

        public void Add(T animal)
        {
            if(animal is Baleine)
                 _context.listBaleine.Add((Animal)animal);
            else if (animal is Huitre)
                _context.listHuitre.Add((Animal)animal);
            else if (animal is Enclos)
                _context.listEnclos.Add((Enclos)animal);
        }

        public List<IAnimal> getItems()
        {
            if (T is Baleine)
                return _context.listBaleine;
            else if (animal is Huitre)
                _context.listHuitre.Add((Animal)animal);
            else if (animal is Enclos)
                _context.listEnclos.Add((Enclos)animal);
        }

    }
}
