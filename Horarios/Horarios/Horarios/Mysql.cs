using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Horarios {
    class Mysql {
        //conexão com o banco de dados
        public static MySqlConnection Conexao;

        //função para execução das querys
        public static MySqlCommand Comando;

        //responsável por inserir dados em uma datatable
        public static MySqlDataAdapter Adaptador;

        //liga banco com propriedades datasource        
        public static DataTable datTabela;


        public static void conectar() {
            //estabelece parametros de conexão ao banco
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=masterkey");

            //Abre conexão com bd
            Conexao.Open();

            //cria o banco com instruções SQL
            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_controle; use bd_controle", Conexao);

            //executa a query sql
            Comando.ExecuteNonQuery();

            //cria a tabela
            Comando = new MySqlCommand( "CREATE TABLE IF NOT EXISTS tb_usuarios " +
                                        "(id integer auto_increment primary key, " +
                                        "cpf integer (11), " +
                                        "nome char(50), " +
                                        "permissao integer (01), " + 
                                        "senha integer (04))", Conexao);

            Comando.ExecuteNonQuery();

            //Fecha a conexão com o banco
            Conexao.Close();

        }

    }
}
