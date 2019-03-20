using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaAdmOuvidoria.Modelo
{
    public class Registros : DAL.RegistrosDAO
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String ra { get; set; }
        public String cpf { get; set; }
        public String assunto { get; set; }
        public String email { get; set; }
        public String texto { get; set; }
    }
}
