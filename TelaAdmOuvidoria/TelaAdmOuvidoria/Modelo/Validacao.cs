using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaAdmOuvidoria.Modelo
{
    public class Validacao : Registros
    {

        public String mensagem;
        public int id;

        public void ValidarDados(List<String> dadosRegistros)
        {
            this.mensagem = "";
            if (dadosRegistros[1].Length > 50)
                this.mensagem = "Nome com mais de 50 caracteres \n";
            if (dadosRegistros[2].Length > 7)
                this.mensagem += "RA com mais de 7 caracteres \n";
            if (dadosRegistros[3].Length > 13)
                this.mensagem += "CPF com mais de 13 caracteres \n";
            if (dadosRegistros[4].Length > 50)
                this.mensagem += "Assunto com mais de 50 caracteres, tente ser mais direto \n";

            try
            {
                this.id = Convert.ToInt32(dadosRegistros[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID inválido";
            }
        }
        /*
        public void ValidarDadosDF(List<String> dadosRegistros)
        {
            this.mensagem = "";
            if (dadosRegistros[1].Length > 80)
                this.mensagem = "Pergunta com mais de 80 caracteres \n";
            if (dadosRegistros[2].Length > 100)
                this.mensagem += "Resposta atinge o limite de 100 caracteres \n";

            try
            {
                this.id = Convert.ToInt32(dadosRegistros[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID inválido";
            }
          */
    }
}
