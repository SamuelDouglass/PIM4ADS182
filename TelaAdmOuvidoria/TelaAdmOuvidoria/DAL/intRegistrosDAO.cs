using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaAdmOuvidoria.Modelo;

namespace TelaAdmOuvidoria.DAL
{
    interface intRegistrosDAO
    {
        //void AtualizarDuvidas(Registros registros);
        Registros PesquisarPorID(Registros registros);
        //Registros CarregarDF(Registros registros);
    }
}
