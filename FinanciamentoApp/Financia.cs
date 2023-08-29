using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciamentoApp
{
    public class Financia
    {
        public static double CalculoFinanciamento(double valor_emprestimo, double tx_juros, double parcelas)
        {
            double taxa = (valor_emprestimo / 100) * tx_juros;
            return (valor_emprestimo / parcelas) + taxa;
        }
    }

}
