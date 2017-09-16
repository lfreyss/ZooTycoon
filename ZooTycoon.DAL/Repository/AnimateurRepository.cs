using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model.Animaux;
using ZooTycoon.DAL.Model.Personnes;

namespace ZooTycoon.DAL.Repository
{
    public class AnimateurRepository
    {
        private ZooContext _context { get; set; }
        public AnimateurRepository(ZooContext context)
        {
            _context = context;
        }

        public void Add(Animateur item)
        {
            if (item is Animateur)
                _context.listAnimateur.Add(item);
        }

        public void Remove(Animateur item)
        {
            if (item is Animateur)
                _context.listAnimateur.Remove(item);
        }

        public List<Animateur> getItems()
        {
            return _context.listAnimateur;
        }
    }
}
