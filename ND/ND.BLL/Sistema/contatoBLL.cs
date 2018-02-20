using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ND.DAL; 
using ND.MODAL; 
using ND.BLL.Exceptions; 

namespace ND.BLL.Sistema
{
    public class contatoBLL
    {
        private contatoDAO _contatoDAO; 

        private void validarContato(contatos contato)
        {
            if (string.IsNullOrWhiteSpace(contato.nome) || string.IsNullOrWhiteSpace(contato.endereco) || string.IsNullOrWhiteSpace(contato.lograduro))
            {
                throw new contatoInvalidoExceptions(); 
            }
            
        }

        public void inserirContato(contatos contato) 
        {
            _contatoDAO = new contatoDAO();

            validarContato(contato);

            if (_contatoDAO.inserirContato(contato)==0)
            {
                throw new contatoNaoCadastradoExceptions();
            }

        }


    }
}