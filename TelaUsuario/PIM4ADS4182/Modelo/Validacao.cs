using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4ADS4182.Modelo
{
    public class Validacao
    {

        public String mensagem;
        public int id;

        public Controle Controle
        {
            get => default(Controle);
            set
            {
            }
        }

        public void ValidarDados(List<String> dadosRegistros)
        {
            this.mensagem = "";
            if (dadosRegistros[1].Length > 50)
                this.mensagem = "Nome com mais de 50 caracteres \n";
            if (dadosRegistros[2].Length > 7)
                this.mensagem += "RA com mais de 7 caracteres \n";
            if (dadosRegistros[3].Length > 11)
                this.mensagem += "CPF com mais de 11 caracteres \n";
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
    }
}
