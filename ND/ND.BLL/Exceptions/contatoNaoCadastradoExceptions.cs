using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ND.BLL.Exceptions
{
    public class contatoNaoCadastradoExceptions:Exception
    {
        public contatoNaoCadastradoExceptions() { }
        public contatoNaoCadastradoExceptions(string message) : base(message) { }

    }
}