using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Model;
using ZooTycoon.BLL.Model.Animaux;

namespace ZooTycoon.BLL.Gestionnaire
{
    public static class EntiteGestionnaire<T>
        where T : IEntity
    {
        private static List<T> listItem {get; set; }
        public static T Add(T item)
        {
            if (listItem == null)
                listItem = new List<T>();

            listItem.Add(item);
            return item;
        }

        public static void Remove(T item)
        {
            listItem.Remove(item);
        }

        public static List<T> GetAll()
        {
            return listItem;
        }

        public static T GetOneById(int id)
        {
            return listItem.Find(x => x.Id == id);
        }
        
    }
}
