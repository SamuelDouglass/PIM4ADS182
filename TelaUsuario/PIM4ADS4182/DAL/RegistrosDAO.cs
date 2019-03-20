using PIM4ADS4182.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4ADS4182.DAL
{
        public class RegistrosDAO : intRegistrosDAO
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

        public void EnviarRegistros(Registros registros)
            {
                this.mensagem = "";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"insert into registroD
                    (nome, ra, cpf, assunto, email, texto)
                    values
                    (@nome, @ra, @cpf, @assunto, @email, @texto)";
                cmd.Parameters.AddWithValue("@nome", registros.nome);
                cmd.Parameters.AddWithValue("@ra", registros.ra);
                cmd.Parameters.AddWithValue("@cpf", registros.cpf);
                cmd.Parameters.AddWithValue("@assunto", registros.assunto);
                cmd.Parameters.AddWithValue("@email", registros.email);
                cmd.Parameters.AddWithValue("@texto", registros.texto);

                try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar();
                    this.mensagem = "Dúvida enviada com sucesso !!!!!";
                }
                catch (SqlException e)
                {
                    this.mensagem = e.ToString();
                }
            }
            public Modelo.Registros CarregarDF(Modelo.Registros registros)
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
                        registros.duvidas = dataReader["duvidas"].ToString();
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
    }
}
