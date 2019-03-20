using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaAdmOuvidoria.DAL
{
    public class Conexao
    {
        SqlConnection conexaoBD;

        public Conexao()
        {
            conexaoBD = new SqlConnection();
            conexaoBD.ConnectionString = @"Data Source=DESKTOP-81FUKQI\SQLEXPRESS01;
                Initial Catalog=ouvidoria;Integrated Security=true;";

        }
        //lembrar de colocar o usuário e senha

        public SqlConnection Conectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Closed)
                conexaoBD.Open();
            return conexaoBD;
        }

        public void Desconectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Open)
                conexaoBD.Close();
        }
    }
}
