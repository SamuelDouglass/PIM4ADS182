using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4ADS4182.Modelo
{
    public class Controle : DAL.Conexao
    {
        public String mensagem;
        private object conexaoBD;

        internal DAL.intRegistrosDAO intRegistrosDAO
        {
            get => default(DAL.intRegistrosDAO);
            set
            {
            }
        }

        public void EnivarRegistros(List<String> dadosRegistros)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDados(dadosRegistros);
            if (validacao.mensagem.Equals(""))
            {
                Registros registros = new Registros();
                registros.nome = dadosRegistros[1];
                registros.ra = dadosRegistros[2];
                registros.cpf = dadosRegistros[3];
                registros.assunto = dadosRegistros[4];
                registros.email = dadosRegistros[5];
                registros.texto = dadosRegistros[6];
                DAL.RegistrosDAO registrosDAO = new DAL.RegistrosDAO();
                registrosDAO.EnviarRegistros(registros);
                this.mensagem = registrosDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
