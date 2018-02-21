﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ND.MODAL;
using System.Data.SqlClient; 

namespace ND.DAL
{
    public class grupoDAO
    {
        public List<grupo> obterTodosGrupos()
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = "SELECT *FROM grupo";

                var listaGrupo= new List<grupo>();

                ConnectionFactory.Conectar();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var gru = new grupo();

                    gru.id = Convert.ToInt32(reader["id"]);
                    gru.descricao = Convert.ToString(reader["descricao"]);
                    


                    listaGrupo.Add(gru);

                }
                ConnectionFactory.Desconectar();
                return listaGrupo;
            }
            catch (Exception)
            {

                throw;
            }




        }

    }
}