﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {

        public int id { get; set; }

        [DisplayName("Marca")]

        public string descripcion { get; set; } 

        public override string ToString()
        {
            return descripcion;
        }
    }
}
