using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model.Personnes
{
    public class Client : Personnes
    {
        public Client(string nom, int age) : base (nom, age)
        {
        }
    }
}
