namespace sistema_escolar.console
{
    public class EntidadeBase
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        public string CPF { get; protected set; }
    }
}