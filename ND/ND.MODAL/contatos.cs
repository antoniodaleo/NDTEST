using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.MODAL
{
    public class contatos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string lograduro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string celular1 { get; set; }
        public string celular2 { get; set; }
        public string celular3 { get; set; }
        public string residencial { get; set; }
        public string comercial1 { get; set; }
        public string comercial2 { get; set; }
        public string email { get; set; }
        public string site { get; set; }
        public DateTime data_cad { get; set; }

        public int idBairro { get; set; }
        public int idGrupo { get; set; }

        public bairro bairro { get; set; }
        public grupo grupo { get; set; }
    }
}