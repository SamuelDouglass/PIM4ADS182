using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaAdmOuvidoria.Modelo
{
    public class Controle
    {
        public String mensagem;

        internal DAL.intRegistrosDAO intRegistrosDAO
        {
            get => default(DAL.intRegistrosDAO);
            set
            {
            }
        }

        public Modelo.Registros PesquisarPorID(List<String> dadosRegistros)
        {
            this.mensagem = "";
            Registros registros = new Registros();
            Validacao validacao = new Validacao();
            validacao.ValidarDados(dadosRegistros);
            if (validacao.mensagem.Equals(""))
            {
                registros.id = validacao.id;
                DAL.RegistrosDAO registrosDAO = new DAL.RegistrosDAO();
                registros = registrosDAO.PesquisarPorID(registros);
                this.mensagem = registrosDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return registros;
        }
        /*
        public void CarregarDF(List<String> dadosRegistros)
        {
            

        }
        public void AtualizarDuvidas(List<String> dadosRegistros)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosDF(dadosRegistros);
            if (validacao.mensagem.Equals(""))
            {
                Registros registros = new Registros();
                registros.pergunta = dadosRegistros[1];
                registros.resposta = dadosRegistros[2];
                DAL.RegistrosDAO registrosDAO = new DAL.RegistrosDAO();
                registrosDAO.CarregarDF(registros);
                this.mensagem = registrosDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
        */
    }
}
