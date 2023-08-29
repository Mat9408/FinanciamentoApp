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
            return (valor_emprestimo * tx_juros * parcelas) / 100;
        }
    }

}