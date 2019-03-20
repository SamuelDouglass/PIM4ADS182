using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4ADS4182.Modelo
{
    public class Registros
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String ra { get; set; }
        public String cpf { get; set; }
        public String assunto { get; set; }
        public String email { get; set; }
        public String texto { get; set; }
        public String duvidas { get; set; }

        public DAL.RegistrosDAO RegistrosDAO
        {
            get => default(DAL.RegistrosDAO);
            set
            {
            }
        }
    }
}
