using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ND.MODAL;
using ND.DAL;
using ND.BLL.Exceptions; 

namespace ND.BLL.Sistema
{
    public class grupoBLL
    {
        public List<grupo> listarTodosGrupos()
        {

            var grupoDAO = new grupoDAO();
            var listarGrupo = new List<grupo>();

            listarGrupo = grupoDAO.obterTodosGrupos();

            if (listarGrupo == null)
            {
                throw new grupoNaoCadastradoExceptions();
            }
            else
            {
                return listarGrupo;
            }

        } 
    }
}