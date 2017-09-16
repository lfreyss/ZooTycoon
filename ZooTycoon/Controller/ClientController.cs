using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model.Personnes;
using ZooTycoon.BLL.Services.Container;

namespace ZooTycoon.Controller
{
    public class ClientController
    {
        private UnitOfWork _uow { get; set; }
        
        public ClientController(UnitOfWork _uow)
        {
            this._uow = _uow;
        }

        public Client AddClient(string name, int age)
        {
            return _uow.ClientService().Add(name, age);
        }

        public List<Client> GetAllClient()
        {
            return _uow.ClientService().GetAll();
        }

        public void EntreZoo()
        {
            Task t = Task.Run(() => {
                for (int ctr = 0; ctr <= 1000000; ctr++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(0, 100);
                    var pourcentageEntre = 60;
                    var res = _uow.ZooService().EntreZoo(pourcentageEntre, randomNumber);
                    if (res != "")
                        Console.WriteLine(res + " Nous avons " + _uow.ClientService().GetAll().Count.ToString() + " clients actuellement.");
                    Thread.Sleep(1500);
                }
               
            });
        }
    }
}
