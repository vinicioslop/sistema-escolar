using System;
using sistema_escolar.Classes.Repositorios;

namespace sistema_escolar.Metodos
{
    public class MetodosAluno
    {
        static AlunoRepositorio repositorio = new AlunoRepositorio();
        public void CadastrarAluno()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE ALUNO");

            Console.Write("\n");

            Aluno aluno = criaAluno();

            repositorio.Inserir(aluno);
        }
        public void ListarAluno()
        {
            Console.Clear();

            try
            {
                Console.Write("Insira o seu ID: ");
                int idE = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n");

                Aluno aluno = repositorio.RetornaPorId(idE);

                Console.Clear();

                Console.WriteLine("DADOS NO SISTEMA");

                Console.Write("\n");

                Console.WriteLine($"NOME......: {aluno.retornaNome()} {aluno.retornaNome()}");
                Console.WriteLine($"CPF.......: {aluno.retornaCPF()}");
                Console.WriteLine($"ANO.......: {aluno.retornaAno()}");
                Console.WriteLine($"STATUS....: {aluno.retornaStatus()}");
                Console.WriteLine($"DESATIVADO: {aluno.retornaDesativado()}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        }
        public void ListarAlunos()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE ALUNOS");

            Console.Write("\n");

            try
            {
                var lista = repositorio.Lista();

                foreach (var aluno in lista)
                {
                    Console.Write($"ID: {aluno.retornaId()} | NOME: {aluno.retornaNome()} {aluno.retornaSobrenome()}");
                    Console.Write($" | ANO: {aluno.retornaAno()} | STATUS: {aluno.retornaStatus()}");
                    Console.WriteLine($" | DESATIVADO: {aluno.retornaDesativado()}");
                }

                if(lista.Count == 0)
                {
                    Console.WriteLine("Não há alunos cadastrados.");
                }

                Console.Write("\n");

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public Aluno criaAluno()
        {
            try
            {
                Console.Write("Digite o Nome.........: ");
                string nomeE = Console.ReadLine();

                Console.Write("Digite o Sobrenome....: ");
                string sobrenomeE = Console.ReadLine();

                Console.Write("Digite o CPF..........: ");
                string cpfE = Console.ReadLine();

                ExibeAnos();

                Console.Write("Escolha o Ano do Aluno: ");
                int anoE = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("DADOS INSERIDOS");

                Console.Write("\n");

                Console.WriteLine($"NOME......: {nomeE}");
                Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
                Console.WriteLine($"CPF.......: {cpfE}");
                Console.WriteLine($"ANO.......: {Enum.GetName(typeof(Ano), anoE)}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

                return new Aluno(
                    id: repositorio.ProximoId(),
                    nome: nomeE,
                    sobrenome: sobrenomeE,
                    cpf: cpfE,
                    ano: (Ano)anoE
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

                return null;
            }
        }
        public void ExibeAnos()
        {
            Console.Write("\n");

            Console.WriteLine("ANOS");

            Console.Write("\n");

            foreach (int i in Enum.GetValues(typeof(Ano)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Ano), i));
            }

            Console.Write("\n");
        }
        public void AtualizarAluno()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE ALUNO");

            Console.Write("\n");

            try
            {
                Console.Write("Informe o ID do Aluno: ");
                int idE = Convert.ToInt32(Console.ReadLine());

                Aluno aluno = criaAluno();

                repositorio.Atualizar(idE, aluno);

                Console.Write("\n");

                Console.WriteLine("Aluno atualizado com sucesso.");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void DesativarAluno()
        {
            Console.Clear();

            Console.WriteLine("DESATIVAR ALUNO");

            Console.Write("\n");

            try
            {
                Console.Write("Informe o ID do aluno: ");
                int idE = Convert.ToInt32(Console.ReadLine());

                repositorio.Desativa(idE);

                Console.Write("\n");

                Console.WriteLine("Aluno desativado com sucesso!");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}