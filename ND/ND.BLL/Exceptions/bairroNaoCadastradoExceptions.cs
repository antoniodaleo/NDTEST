using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.BLL.Exceptions
{
    public class bairroNaoCadastradoExceptions:Exception
    {
        public bairroNaoCadastradoExceptions() { }
        public bairroNaoCadastradoExceptions(string message) : base(message) { }

    }
}