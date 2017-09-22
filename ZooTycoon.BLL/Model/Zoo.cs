using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model.Animaux;
using ZooTycoon.BLL.Model.Personnes;

namespace ZooTycoon.BLL.Model
{
    public class Zoo
    {

        private string Nom { get; set; }
        private string Location { get; set; }
        private int NumTel { get; set; }
        private static int PrixAdulte { get; set; }
        private static int PrixEnfant { get; set; }
        public static int tresorerie { get; set; }
        public static List<Enclos> listEnclos { get; private set; }
        public static List<Employe> listEmploye{ get; private set; }
        public static List<Client> listClient{ get; private set; }

        private static Zoo _instance;

        private Zoo(string nom, string location, int numTel, int prixAdulte, int prixEnfant)
        {
            Nom = nom;
            Location = location;
            NumTel = numTel;
            PrixAdulte = prixAdulte;
            PrixEnfant = prixEnfant;
            listClient = new List<Client>();
            listEmploye = new List<Employe>();
            listEnclos = new List<Enclos>();
        }

        public static Zoo getInstance()
        {
            if (_instance == null) 
				_instance = new Zoo("ZooTycoon", "NY", 038854782, 25, 10);

            return _instance;
        }

        public void AddClient(Client client)
        {
            listClient.Add(client);
            if (client.Age <= 14)
                tresorerie += PrixEnfant;
            else
                tresorerie += PrixAdulte;
        }

        public void RemoveMoney(int money)
        {
            tresorerie = tresorerie - money;
        }

        public void AddMoney(int money)
        {
            tresorerie = tresorerie + money;
        }
    }
}
