using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Services.Container;

namespace ZooTycoon.BLL.Services
{
    public class ZooService
    {
        private UnitOfWork _uow { get; set; }
        public ZooService(UnitOfWork _uow) {
            this._uow = _uow;
        }

        public Zoo Create()
        {
            return Zoo.getInstance();
        }

        public string EntreZoo(int pourcentage, int randomNumber)
        {
            var res = "";
            if(randomNumber < pourcentage)
            {
                Random random = new Random();
                int randomId = random.Next(0, 10000);
                int randomAge = random.Next(0, 90);

                var client = _uow.ClientService().Add("Client" + randomId.ToString(), randomAge);
                Zoo.getInstance().AddClient(client);
                if(Zoo.listClient.Count % 20 == 0)
                    res =  "Un nouvelle arrivage de client est arrivé !!";
            }
            return res;
        }
    }
}
