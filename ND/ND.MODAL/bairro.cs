﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.MODAL
{
    public class bairro
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public int idCidade { get; set; }
        public cidade cidade { get; set; }
    }
}