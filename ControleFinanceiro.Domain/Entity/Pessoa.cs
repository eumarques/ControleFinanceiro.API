namespace ControleFinanceiro.Domain.Entity
{
    public class Pessoa
    {
        public int PessoaId { get; private set; }
        public string NomePessoa { get; private set; }

        public void AdicionarNomePessoa(string nomePessoa)
        {
            if (!string.IsNullOrEmpty(nomePessoa))
            {
                NomePessoa = nomePessoa;
            };
        }
    }
}
