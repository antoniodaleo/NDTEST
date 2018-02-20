using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.MODAL
{
    public class cidade
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public int idEstado { get; set; }
        public estado estado { get; set; }

    }
}