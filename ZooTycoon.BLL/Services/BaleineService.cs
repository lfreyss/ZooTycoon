﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooTycoon.BLL.Gestionnaire;
using ZooTycoon.BLL.Model.Animaux;

namespace ZooTycoon.BLL.Services
{
    public class BaleineService : BaseService<Baleine>
    {
        public BaleineService() { }

        public Baleine Add(string name, int age, string race, bool sexe, int nbNageoire)
        {
            return EntiteGestionnaire<Baleine>.Add(new Baleine(name, age, race, sexe, nbNageoire));
        }
    }
}