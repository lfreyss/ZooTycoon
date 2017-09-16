using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon.BLL.Model
{
    public class BaseEntity : IEntity
    {
        public int Id {get; set;}
        private static int dernierId = 0;
        public BaseEntity()
        {
            this.Id = dernierId++;
        }
    }
}
