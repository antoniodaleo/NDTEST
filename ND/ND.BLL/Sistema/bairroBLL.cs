using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ND.MODAL;
using ND.DAL;
using ND.BLL.Exceptions; 

namespace ND.BLL.Sistema
{
    public class bairroBLL
    {
        public List<bairro> listarTodosBairros()
        {

            var bairroDAO = new bairroDAO();
            var listarBairro = new List<bairro>();

            listarBairro = bairroDAO.obterTodosBairros();

            if (listarBairro == null)
            {
                throw new bairroNaoCadastradoExceptions();
            }
            else
            {
                return listarBairro;
            }

        } 
    }
}