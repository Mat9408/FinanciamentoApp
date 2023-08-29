using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conhecimento_Basico
{
    public class Financia
    {
        public static double CalculoFinanciamento(double valor_emprestimo, double tx_juros, double parcelas)
        {
            double taxa = (valor_emprestimo / 100) * tx_juros;
            double resultado = (valor_emprestimo / parcelas) + taxa;
            return resultado;
        }
    }

}
