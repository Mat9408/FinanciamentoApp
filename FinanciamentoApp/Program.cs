using FinanciamentoApp;

Console.WriteLine("Aplicação de Financiamento");

double valor_emprestimo = 1000;
double prestacoes = 10;
double tx_juros = 5;
double resultado;


resultado = Financia.CalculoFinanciamento(valor_emprestimo, prestacoes, tx_juros);
Console.WriteLine(resultado);







