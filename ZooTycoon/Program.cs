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
        private static MagasinController _magasinController { get; set; }

        public static void Main(string[] args)
        {
            try
            {
                uow = new UnitOfWork();
                _homeController = new HomeController(uow);
                _animalController = new AnimalController(uow);
                _clientController = new ClientController(uow);
                _magasinController = new MagasinController(uow);

                _homeController.initialisation();
                menuHome();
            }
            catch (Exception ex)
            {
                menuHome();
                Console.WriteLine("Une erreur s'est produite...");
                Console.WriteLine(ex.Message);
            }

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

        public static void menuHome(string message = "")
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
            Console.WriteLine(message);
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
            _animalController.GetAllEnclos().ForEach(x =>
            {
                Console.WriteLine(x.Id + " - " + _animalController.DescriptionEnclos(x));
            });
            Console.WriteLine("");
            Console.WriteLine("1. Donner à manger aux animaux ");
            Console.WriteLine("2. Construire un enclos ");
            Console.WriteLine("3. Acheter des animaux ");
            string res = Console.ReadLine();
            switch (res.ToString())
            {
                case "1":
                    Console.WriteLine("Choisir l'enclos --> Taper le numéro");
                    string res2 = Console.ReadLine();
                    DonnerManger(res2);
                    break;
                case "2":
                    ConstruireEnclos();
                    break;
                case "3":
                    AcheterAnimal();
                    break;
                default:
                    menuHome();
                    break;
            }
            retourHome();
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
            Console.WriteLine("4. Ouvrir le zoo");
            Console.WriteLine("5. Retour Menu");
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
                    _clientController.EntreZoo();
                    menuHome("Votre zoo est désormais ouvert, les clients commencent à arriver.");
                    break;
                case "5":
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
            Console.WriteLine("");
            Console.WriteLine("1. Ouvrir le magasin ");
            string res = Console.ReadLine();
            switch (res.ToString())
            {
                case "1":
                    OuvrirMagasin();
                    break;
                default:
                    menuHome();
                    break;
            }
            retourHome();
        }

        public static void menuNourriture()
        {
            Console.Clear();
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Bienvenue dans le magasin de nourriture :");
            Console.WriteLine("");
            Console.WriteLine("1. Acheter nourriture animal ");
            string res = Console.ReadLine();
            switch (res.ToString())
            {
                case "1":
                    _magasinController.GetAllMagAnimal().ForEach(x => Console.WriteLine(x.Description()));
                    Console.WriteLine("Choisir le magasin --> Tapez le numéro");
                    string res2 = Console.ReadLine();
                    VendreAlimAnimaux(res2);
                    break;
                default:
                    menuHome();
                    break;
            }
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

        public static void DonnerManger(string id)
        {
            Console.WriteLine("#######################################################################################################################");
            var enclos = _animalController.GetEnclosById(int.Parse(id));
            _animalController.DescriptionAllProduct(enclos).ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Choisir le produit : Taper l'id");
            var idProduit = Console.ReadLine();
            var produit = _animalController.GetProduitById(int.Parse(idProduit));
            
            Console.WriteLine(_animalController.DonnerManger(produit, enclos));
        }

        public static void VendreAlimAnimaux(string id)
        {
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Votre trésorerie est de " + _magasinController.getTresorerieZoo());
            var mag = _magasinController.GetMagasinById(int.Parse(id));
            _magasinController.GetAllProdMagAnimal(mag).ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Choisir le produit : exemple --> Tapez 1");
            var idProduit = Console.ReadLine();
            Console.WriteLine(_magasinController.VendreProduit(int.Parse(id), int.Parse(idProduit)));
        }

        public static void OuvrirMagasin()
        {
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Votre trésorerie est de " + _magasinController.getTresorerieZoo());
            var mag = _homeController.GetMagasin();
            _magasinController.OpenMagasin(mag);
        }

        private static void AcheterAnimal()
        {
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Votre trésorerie est de " + _magasinController.getTresorerieZoo() + " euros.");
            Console.WriteLine("Vous achetez un animal pour quel enclos ?");
            _animalController.GetAllEnclos().ForEach(x =>
            {
                Console.WriteLine(x.Id + " - " + _animalController.DescriptionEnclos(x));
            });
            var enclosId = Console.ReadLine();

            Console.WriteLine("Choix de l'animal (Taper le numéro):");
            Console.WriteLine("** 1 - Baleine");
            Console.WriteLine("** 2 - Lama");
            Console.WriteLine("** 3 - Huitre");
            Console.WriteLine("** 4 - Pterodactyle");
            Console.WriteLine("** 5 - Ornithorynque");
            var animal = Console.ReadLine();

            Console.WriteLine("Nom :");
            var nom = Console.ReadLine();
            Console.WriteLine("Age :");
            var age = Console.ReadLine();
            Console.WriteLine("Race");
            var race = Console.ReadLine();
            Console.WriteLine("Sexe [M|F]");
            var sexe = Console.ReadLine();
            Console.WriteLine(_animalController.AcheterAnimal(nom, int.Parse(age), race, sexe, animal, _animalController.GetEnclosById(int.Parse(enclosId))));

        }

        private static void ConstruireEnclos()
        {
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Votre trésorerie est de " + _magasinController.getTresorerieZoo() + " euros. Un enclos coute le prix : Taille * 2 euros.");
            Console.WriteLine("Nom de l'enclos :");
            var nom = Console.ReadLine();
            Console.WriteLine("Taille de l'enclos :");
            var taille = Console.ReadLine();
            Console.WriteLine("Type de l'enclos [Habitation||Spectacle] :");
            var type = Console.ReadLine();
            Console.WriteLine(_animalController.AcheterEnclos(nom, int.Parse(taille), type));
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
