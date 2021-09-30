namespace sistema_escolar
{
    public class Aluno : EntidadeBase
    {
        private Ano Ano { get; set; }
        private Nota Nota { get; set; }
        private Status Status { get; set; }

        public Aluno (int id, string nome, string sobrenome, string cpf, Ano ano /*Nota nota,*/)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.Ano = ano;
            //this.Nota = nota;
            this.Status = Status.CURSANDO;
            this.Desativado = false;
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
        public Ano retornaAno()
        {
            return this.Ano;
        }
        public Nota retornaNota()
        {
            return this.Nota;
        }
        public Status retornaStatus()
        {
            return this.Status;
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