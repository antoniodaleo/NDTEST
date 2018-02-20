using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.BLL.Exceptions
{
    public class contatoInvalidoExceptions:Exception
    {
        public contatoInvalidoExceptions() { }
        public contatoInvalidoExceptions(string message) : base(message) { }

    }
}