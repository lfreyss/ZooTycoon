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
            uow = new UnitOfWork();
            _homeController = new HomeController(uow);
            _animalController = new AnimalController(uow);
            _clientController = new ClientController(uow);

            _homeController.initialisation();
            _clientController.EntreZoo();

            menuHome();

 /*
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
 */
        }

        public static void menuHome()
        {
            Console.Clear();
            string res;
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Bienvenue dans ZooTycoon");
            Console.WriteLine("Etes-vous prêt pour du GROS FUN ? ");
            dino();
            Console.WriteLine("");
            Console.WriteLine("Veuillez selectionner un des choix suivant : ");
            Console.WriteLine("1. Animaux");
            Console.WriteLine("2. Spectacle");
            Console.WriteLine("3. Magasin");
            Console.WriteLine("#######################################################################################################################");
            res = Console.ReadLine();
            switch (res.ToString())
            {
                case "1":
                    menuAnimaux();
                    break;
                case "2":
                    menuSpectacle();
                    break;
                case "3":
                    menuMagasin();
                    break;
                default:
                    menuHome();
                    break;
            }
        }
        public static void menuAnimaux()
        {
            Console.Clear();
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Les enclos présents dans le zoo sont les suivants :");
            var i = 0;
            _animalController.GetAllEnclos().ForEach(x =>
            {
                i++;
                Console.WriteLine(i + " - " + _animalController.DescriptionEnclos(x));
            });
            Console.WriteLine("1. Donner à manger aux animaux ");
            string res = Console.ReadLine();
            switch (res.ToString())
            {
                case "1":
                    Console.WriteLine("Choisir l'enclos --> Tapez le numéro");
                    string res2 = Console.ReadLine();
                    DonnerManger(res2);
                    break;
                default:
                    menuHome();
                    break;
            }
            retourHome();
            /*
                        _animalController.GetAllHuitre().ForEach(x =>
                        {
                            Console.WriteLine(x.Cri());
                        });
                        _animalController.GetAllBaleine().ForEach(x =>
                        {
                            Console.WriteLine(x.Cri());
                        });
                        
            */

        }

        public static void menuSpectacle()
        {
            Console.Clear();
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Les spectacles présents dans le zoo sont les suivants :");
            _animalController.GetAllSpectacles().ForEach(x =>
            {
                _animalController.DescriptionSpectacle(x);
            });
            Console.WriteLine("1. Lancer un spectacle ");
            string res = Console.ReadLine();
            switch (res.ToString())
            {
                case "1":
                    StartSpectacle(_animalController.GetAllSpectacles().First());
                    break;
                default:
                    menuHome();
                    break;
            }
        }

        public static void menuMagasin()
        {
            string res;
            Console.Clear();
            Console.WriteLine("#######################################################################################################################");
            magasin();
            Console.WriteLine("Vers quel type de magasin voulez vous aller ? :");
            Console.WriteLine("1. Magasin de Souvenir");
            Console.WriteLine("2. Magasin de Nourriture");
            Console.WriteLine("3. Magasin de Boisson");
            Console.WriteLine("4. Retour Menu");
            Console.WriteLine("#######################################################################################################################");
            res = Console.ReadLine();
            switch (res.ToString())
            {
                case "1":
                    menuSouvenir();
                    break;
                case "2":
                    menuNourriture();
                    break;
                case "3":
                    menuBoisson();
                    break;
                case "4":
                    menuHome();
                    break;
                default:
                    menuMagasin();
                    break;
            }
            Console.ReadLine();
        }

        public static void menuSouvenir()
        {
            Console.Clear();
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Bienvenue dans le magasin de souvenir :");
            retourHome();
        }

        public static void menuNourriture()
        {
            Console.Clear();
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Bienvenue dans le magasin de nourriture :");
            retourHome();
        }

        public static void menuBoisson()
        {
            Console.Clear();
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Bienvenue dans le magasin de boisson :");
            retourHome();
        }

        public static void StartSpectacle(Spectacle spectacle)
        {
            Console.Clear();
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Madame et Messieurs, bienvenue dans notre tout nouveau spectacle");
            Console.WriteLine(_animalController.DescriptionSpectacle(spectacle));

            Console.WriteLine("Que le spectacle commence !!");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(_animalController.StartSpectacle(spectacle));
            }

            Console.WriteLine("Je vous prie d'applaudir nos animateurs et nos animaux");
            Console.WriteLine(_animalController.DescriptionAnimateur(spectacle));
            Console.WriteLine("#######################################################################################################################");
            retourHome();
        }

        public static void DonnerManger(string numéro)
        {
            Console.WriteLine("#######################################################################################################################");
            _animalController.DescriptionAllProduct().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Choisir l'enclos et le produit : exemple --> Tapez 1 1");
            Console.WriteLine(_animalController.DescriptionSpectacle(spectacle));
        }

        public static void retourHome()
        {
            Console.ReadLine();
            menuHome();
        }

        public static void dino()
        {
            Console.WriteLine(@"                                    _
                                  .~q`,
                                 {__,  \
                                     \' \
                                      \  \
                                       \  \
                                        \  `._            __.__
                                         \    ~-._  _.==~~     ~~--.._
                                          \        '                  ~-.
                                           \      _-   -_                `.
                                            \    /       }        .-    .  \
                                             `. |      /  }      (       ;  \
                                               `|     /  /       (       :   '\
                                                \    |  /        |      /       \
                                                 |     /`-.______.\     |~-.      \
                                                 |   |/           (     |   `.      \_
                                                 |   ||            ~\   \      '._    `-.._____..----..___
                                                 |   |/             _\   \         ~-.__________.-~~~~~~~~~'''
                                               .o'___/            .o______}");
        }

        public static void magasin()
        {
            Console.WriteLine(@"                           ====
                           !!!!
      ==========================
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  ||      _____          _____    ||
  ||      | | |          | | |    ||
  ||      |-|-|          |-|-|    ||
  ||      #####          #####    ||
  ||                              ||
  ||      _____   ____   _____    ||
  ||      | | |   @@@@   | | |    ||
  ||      |-|-|   @@@@   |-|-|    ||
  ||      #####   @@*@   #####    ||
  ||              @@@@            ||
******************____****************
**************************************");
        }
    }
}
