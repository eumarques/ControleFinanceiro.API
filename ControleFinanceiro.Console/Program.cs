// See https://aka.ms/new-console-template for more information
using ControleFinanceiro.Domain.Entity;



var organizacao = new Organizacao();

organizacao.Pessoa.AdicionarNomePessoa("Tiago Marques");


Console.WriteLine(organizacao.Pessoa);