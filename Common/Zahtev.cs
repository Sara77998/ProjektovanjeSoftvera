﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Common
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }
    }
}
