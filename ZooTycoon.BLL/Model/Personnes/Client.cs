using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model.Magasins;

namespace ZooTycoon.BLL.Model.Personnes
{
    public class Client : Personnes
    {
        public List<Produit> listProduit { get; set; }
        public int Bourse { get; set; }
        public Client(string nom, int age, int bourse = 100) : base (nom, age)
        {
            listProduit = new List<Produit>();
            Bourse = bourse;
        }

        public string BuyProduit(Produit item)
        {
            if(Bourse > item.Prix){
                listProduit.Add(item);
                Bourse -= item.Prix;
                return Nom + " a acheté " + item.Nom;
            }
            else
            {
                return Nom + " n'a pas assez d'argent pour acheter " + item.Nom;
            }
        }
    }
}
