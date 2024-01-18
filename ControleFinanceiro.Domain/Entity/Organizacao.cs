namespace ControleFinanceiro.Domain.Entity
{
    public class Organizacao
    {
        public Organizacao()
        {
            Pessoa = new Pessoa();
            Receita = new List<Receita>();
            Data = DateTime.Now;
            Despesa = new List<Despesa>();
        }

        public int OrganizacaoId { get; private set; }
        public Pessoa Pessoa { get; private set; }
        public List<Receita> Receita { get; private set; }
        public DateTime Data { get; private set; }
        public decimal Primicia { get; private set; }
        public decimal Dizimo { get; private set; }
        public decimal Saldo { get; private set; }
        public List<Despesa> Despesa { get; private set; }
        public decimal Total { get; private set; }
        public decimal SubTotal { get; private set; }
    }
}
