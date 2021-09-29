namespace sistema_escolar
{
    public class EntidadeBase
    {
        public int Id { get; protected set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
    }
}