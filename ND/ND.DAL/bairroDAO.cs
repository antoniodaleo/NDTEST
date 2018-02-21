using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ND.MODAL;
using System.Data.SqlClient; 

namespace ND.DAL
{
    public class bairroDAO
    {
        public List<bairro> obterTodosBairros()
            {
            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = "SELECT *FROM bairro";
                
                var listaBairro = new List<bairro>();

                ConnectionFactory.Conectar();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var bar = new bairro();
                 
                    bar.id = Convert.ToInt32(reader["id"]);
                    bar.descricao = Convert.ToString(reader["descricao"]);
                    bar.idCidade = Convert.ToInt32(reader["cidade"]);
                    

                    listaBairro.Add(bar);

                }
                ConnectionFactory.Desconectar();
                return listaBairro;
                
            }
            catch (Exception)
            {

                throw;
            }
            



        }


    }
}