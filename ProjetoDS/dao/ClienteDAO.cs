using MySql.Data.MySqlClient;
using ProjetoDS.conexao;
using ProjetoDS.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS.dao
{
    public class ClienteDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public ClienteDAO()
        {
           //abre a conexao     
           conexao.Open();
        }

  //       `ID_Cliente` INT NOT NULL AUTO_INCREMENT,
  //`Nome` VARCHAR(100) NULL,
  //`Email` VARCHAR(50) NULL,
  //`Senha` VARCHAR(45) NULL,
  //`Sexo` VARCHAR(1) NULL,

        //metodos sql
        public void cadastrar(Cliente obj)
        {
            try
            {
                string sql = @"insert into cliente (nome, email, senha, sexo) values (@nome,@email,@senha,@sexo)";

                //2 passo - organizar o sql
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                executacmdsql.Parameters.AddWithValue("@email", obj.email);
                executacmdsql.Parameters.AddWithValue("@senha", obj.senha);
                executacmdsql.Parameters.AddWithValue("@sexo", obj.sexo);
              


                executacmdsql.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }

        internal void Cadastrar(Cliente obj)
        {
            throw new NotImplementedException();
        }

        //metodos sql
        public void alterar(Cliente obj)
        {
            try
            {
                string sql = @"update cliente set nome = @nome, email=@email, senha=@senha, sexo=@sexo where id_cliente = @id";
                               

                //2 passo - organizar o sql
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
              
                executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                executacmdsql.Parameters.AddWithValue("@email", obj.email);
                executacmdsql.Parameters.AddWithValue("@senha", obj.senha);
                executacmdsql.Parameters.AddWithValue("@sexo", obj.sexo);
               
                executacmdsql.Parameters.AddWithValue("@id", obj.id);


                executacmdsql.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }

        //metodos sql
        public void excluir(Cliente obj)
        {
            try
            {
                string sql = @"delete from cliente where id_cliente = @codigo";

                //2 passo - organizar o sql
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@id", obj.id);
            


                executacmdsql.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }


        //Metodo lIstar clientes


        public DataTable ListarTodosClientes()
        {
        
                //1 passo - comando sql
                string sql = @"select * from cliente";

                //2 passo - organizar o sql
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
               
                //3 passo - abrir a conexao e executar o comando                
                executacmdsql.ExecuteNonQuery();

                //4 passo - criar o MySQLDataAdapter
                
               MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                //5 passo - criar o DataTable
               
                DataTable tabelaCliente = new DataTable();
                da.Fill(tabelaCliente);
              
               //fechar conexão
                conexao.Close();

                //Retornar o DataTable com os dados
                return tabelaCliente;            

        }
    }
}
