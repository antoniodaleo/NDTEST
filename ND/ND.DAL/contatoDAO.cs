using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ND.MODAL;
using System.Data.SqlClient;

namespace ND.DAL
{
    public class contatoDAO
    {
        public int inserirContato(contatos cont) 
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = @"INSERT INTO contatos
                (nome
                ,endereco
                ,lograduro
                ,numero
                ,complemento
               
                ,celular1
                ,celular2
                ,celular3 
                ,residencial 
                ,comercial1 
                ,comercial2
                ,email
                ,site
                ,bairro
                ,grupo) 
                
VALUES
                (@NOME
                ,@ENDERECO
                ,@LOGRADURO
                
                ,@NUMERO
                ,@COMPLEMENTO
                ,@CELULAR1
                ,@CELULAR2
                ,@CELULAR3 
                ,@RESIDENCIAL 
                ,@COMERCIAL1 
                ,@COMERCIAL2
                ,@EMAIL
                ,@SITE
                ,@BAIRRO
                ,@GRUPO)";

                command.Parameters.AddWithValue("@NOME", cont.nome);
                command.Parameters.AddWithValue("@ENDERECO", cont.endereco);
                command.Parameters.AddWithValue("@LOGRADURO", cont.lograduro);
               
                command.Parameters.AddWithValue("@NUMERO", cont.numero);
                command.Parameters.AddWithValue("@COMPLEMENTO", cont.complemento);
                command.Parameters.AddWithValue("@CELULAR1", cont.celular1);
                command.Parameters.AddWithValue("@CELULAR2", cont.celular2);
                command.Parameters.AddWithValue("@CELULAR3", cont.celular3);
                command.Parameters.AddWithValue("@RESIDENCIAL", cont.residencial);
                command.Parameters.AddWithValue("@COMERCIAL1", cont.comercial1);
                command.Parameters.AddWithValue("@COMERCIAL2", cont.comercial2);
                command.Parameters.AddWithValue("@EMAIL", cont.email);
                command.Parameters.AddWithValue("@SITE", cont.site);
                command.Parameters.AddWithValue("@BAIRRO", cont.idBairro);
                command.Parameters.AddWithValue("@GRUPO", cont.idGrupo);

                ConnectionFactory.Conectar();
                return command.ExecuteNonQuery(); 
            }
            catch (Exception)
            {
                
                throw;
            }
            finally 
            {
                ConnectionFactory.Desconectar();     
            }
        }


    }
}