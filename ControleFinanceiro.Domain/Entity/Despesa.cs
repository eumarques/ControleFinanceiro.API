namespace ControleFinanceiro.Domain.Entity
{
    public class Despesa
    {
        public int IdDespesa { get; private set; }
        public string NomeDespesa { get; private set; }
        public int ValorDespesa { get; private set; }
        public DateTime DataVencimentoDespesa { get; private set; }
    }
}