using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.DAL.Model;
using ZooTycoon.DAL.Model.Animaux;

namespace ZooTycoon.DAL.Gestionnaire
{
    public class ZooContext
    {


        public List<Animal> listHuitre {get; set; }
        public List<Animal> listBaleine { get; set; }
        public List<Enclos> listEnclos { get; set; }

        public ZooContext()
        {
            Zoo zoo = Zoo.getInstance();
            List<Animal> listHuitre = new List<Animal>()
            {
                new Huitre("H1",1,"ocean", true, true),
                new Huitre("H2",4,"mer", false, false),
                new Huitre("H3",3,"ocean", true, false),
                new Huitre("H4",1,"mer", false, false)
            };

            this.listHuitre = listHuitre;


            List<Animal> listBaleine = new List<Animal>()
            {
                new Baleine("B1",1,"ocean", true, 2),
                new Baleine("B2",4,"mer", false, 2),
                new Baleine("B3",3,"ocean", true, 2),
                new Baleine("B4",1,"mer", false, 2)
            };

            this.listBaleine = listBaleine;


            List<Enclos> listEnclos = new List<Enclos>()
            {
                new Enclos("EnclosHuitre", 10,"Habitat", listHuitre, null),
                new Enclos("EnclosBaleine", 100,"Spectacle", listBaleine, null),
            };

            this.listEnclos = listEnclos;

        }
    }
}
