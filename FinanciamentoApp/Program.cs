using Conhecimento_Basico;
using System;

Console.WriteLine("Aplicação de Financiamento");

double valor_emprestimo = 1509; // valor que você deseja pegar emprestado
double prestacoes = 10; // total de prestações
double tx_juros = 2.5; // ao mês
double resultado;


resultado = Financia.CalculoFinanciamento(valor_emprestimo, tx_juros, prestacoes);
Console.WriteLine($"O valor da parcela é R$ {resultado}");
Console.WriteLine($"O valor total do financiamento é R$ {resultado * prestacoes}");
