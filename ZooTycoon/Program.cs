using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Services;
using ZooTycoon.BLL.Services.Container;
using ZooTycoon.Controller;

namespace ZooTycoon
{
    public class Program
    {
        private static UnitOfWork uow { get; set; }
        private static HomeController _homeController { get; set; }
        private static AnimalController _animalController { get; set; }
        private static ClientController _clientController { get; set; }

        public static void Main(string[] args)
        {

            Console.WriteLine("######### ZooTycoon ########");
            uow = new UnitOfWork();
            _homeController = new HomeController(uow);
            _animalController = new AnimalController(uow);
            _clientController = new ClientController(uow);

            _homeController.initialisation();
            _clientController.EntreZoo();

            _animalController.GetAllHuitre().ForEach(x =>
            {
                Console.WriteLine(x.Cri());
            });

            _animalController.GetAllBaleine().ForEach(x =>
            {
                Console.WriteLine(x.Cri());
            });

            Console.WriteLine("Les enclos présents dans le zoo sont les suivants :");
            _animalController.GetAllEnclos().ForEach(x =>
            {
                _animalController.DescriptionEnclos(x);
            });

            Console.WriteLine("Les spectacles présents dans le zoo sont les suivants :");
            _animalController.GetAllSpectacles().ForEach(x =>
            {
                _animalController.DescriptionSpectacle(x);
            });

            Task t = Task.Run(() =>
            {
                while(_clientController.GetAllClient() == null || _clientController.GetAllClient().Count != 61)
                {
                }
                StartSpectacle(_animalController.GetAllSpectacles().First());
            });

            Console.ReadLine();
        }

        public static void StartSpectacle(Spectacle spectacle)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**********************************");
            Console.WriteLine("Madame et Messieurs, bienvenue dans notre tout nouveau spectacle");
            _animalController.DescriptionSpectacle(spectacle);

            Console.WriteLine("Que le spectacle commence !!");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(_animalController.StartSpectacle(spectacle));
            }

            Console.WriteLine("Je vous prie d'applaudir nos animateurs et nos animaux");
            Console.WriteLine(_animalController.DescriptionAnimateur(spectacle));
        }
    }
}
