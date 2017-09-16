using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model;

namespace ZooTycoon.BLL.Services
{
    public class BaseService<T>
        where T : IEntity
    {

        public BaseService() { }

        public List<T> GetAll()
        {
            return EntiteGestionnaire<T>.GetAll();
        }

        public T GetOneById(int id)
        {
            return EntiteGestionnaire<T>.GetOneById(id);
        }
    }
}
