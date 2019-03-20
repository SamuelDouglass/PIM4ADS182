using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaAdmOuvidoria.Modelo;

namespace TelaAdmOuvidoria.DAL
{
    public class RegistrosDAO : Controle, intRegistrosDAO
    {
        Conexao conexaoBD = new Conexao();
        SqlDataReader dataReader;
        public String mensagem;

        internal intRegistrosDAO intRegistrosDAO
        {
            get => default(intRegistrosDAO);
            set
            {
            }
        }

        public Modelo.Registros PesquisarPorID(Modelo.Registros registros)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from registroD 
                where id = @id";
            cmd.Parameters.AddWithValue("@id", registros.id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    registros.nome = dataReader["nome"].ToString();
                    registros.ra = dataReader["ra"].ToString();
                    registros.cpf = dataReader["cpf"].ToString();
                    registros.assunto = dataReader["assunto"].ToString();
                    registros.email = dataReader["email"].ToString();
                    registros.texto = dataReader["texto"].ToString();
                }
                else
                {
                    registros.id = 0;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return registros;
        }
        /*
            public Modelo.Registros CarregarDF(Modelo.Registros registros)
            {
            
                this.mensagem = "";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"select * from duvidasfrequentes 
                        where id = @id";
                cmd.Parameters.AddWithValue("@id", registros.id);
                try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    registros.pergunta = dataReader["duvidas"].ToString();
                }
                else
                {
                    registros.id = 0;
                }
                    dataReader.Close();
                    conexaoBD.Desconectar();
                }
                catch (SqlException e)
                {
                    this.mensagem = e.ToString();
                }
                return registros;
            }
            public void AtualizarDuvidas(Registros registros)
            {
                this.mensagem = "";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"insert into duvidasfrequentes
                    (duvida, resposta)
                    values
                    (@duvida, @resposta)";
                cmd.Parameters.AddWithValue("@duvida", registros.pergunta);
                cmd.Parameters.AddWithValue("@resposta", registros.resposta);

            try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar();
                    this.mensagem = "Atualização feita com sucesso !!!!!";
                }
                catch (SqlException e)
                {
                    this.mensagem = e.ToString();
                }
            }
            */
    }
}
