using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.BLL.Exceptions
{
    public class grupoNaoCadastradoExceptions:Exception
    {
        public grupoNaoCadastradoExceptions() { }
        public grupoNaoCadastradoExceptions(string message) : base(message) { }

    }
}