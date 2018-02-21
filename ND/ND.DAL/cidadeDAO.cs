using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ND.MODAL;
using System.Data.SqlClient; 

namespace ND.DAL
{
    public class cidadeDAO
    {
        public List<cidade> obterTodasCidade()
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = "SELECT  bar.id , bar.descricao, cid.descricao  as cidade from  bairro bar inner join cidade cid on cid.id = bar.cidade";

                var listaCidade = new List<cidade>();

                ConnectionFactory.Conectar();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var cid = new cidade();

                    cid.id = Convert.ToInt32(reader["id"]);
                    cid.descricao = Convert.ToString(reader["descricao"]);
                    cid.idEstado = Convert.ToInt32(reader["estado"]);


                    listaCidade.Add(cid);

                }

                return listaCidade;
            }
            catch (Exception)
            {

                throw;
            }




        }


    }
}