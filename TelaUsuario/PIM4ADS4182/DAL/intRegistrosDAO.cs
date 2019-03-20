using PIM4ADS4182.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4ADS4182.DAL
{
    interface intRegistrosDAO
    {
        void EnviarRegistros(Registros registros);
        Registros CarregarDF(Registros registros);
    }
}
