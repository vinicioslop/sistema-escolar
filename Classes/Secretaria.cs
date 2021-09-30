namespace sistema_escolar
{
    public class Secretaria : EntidadeBase
    {
        public Secretaria(int id, string Nome, string sobrenome, string cpf)
        {
            this.Id = id;
            this.Nome = Nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.Desativado = false;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public string retornaNome()
        {
            return this.Nome;
        }
        public string retornaSobrenome()
        {
            return this.Sobrenome;
        }
        public string retornaCPF()
        {
            return this.CPF;
        }
        public bool retornaDesativado()
        {
            return this.Desativado;
        }
        public void Desativar()
        {
            this.Desativado = true;
        }
    }
}