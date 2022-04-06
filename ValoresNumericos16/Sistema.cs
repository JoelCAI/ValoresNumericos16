using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos16
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string cadenaUno;

            Validador.Bienvenida();

            cadenaUno = Validador.ValidarString("\n Ingrese una frase o un valor numérico, el sistema le indicará" +
                                                " si es un texto, o un valor numérico.");

            Validador.MostrarString(cadenaUno);

            Validador.CompararStringConNumeroInt(cadenaUno);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
