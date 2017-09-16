using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Personnes;

namespace ZooTycoon.BLL.Services.Personne
{
    public class ClientService : BaseService<Client>
    {
        public ClientService() { }

        public Client Add(string name, int age)
        {
            return EntiteGestionnaire<Client>.Add(new Client(name, age));
        }

    }
}
