using System;
using sistema_escolar.Classes.Repositorios;

namespace sistema_escolar.Metodos
{
    public class MetodosProfessor
    {
        public static ProfessorRepositorio repositorioProfessor = new ProfessorRepositorio();
        public static NotaRepositorio repositorioNota = new NotaRepositorio();
        public void ListarProfessores()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE PROFESSORES");

            Console.Write("\n");

            try
            {
                var lista = repositorioProfessor.Lista();

                foreach (var professor in lista)
                {
                    Console.Write($"ID: {professor.Id} | NOME: {professor.retornaNome()} {professor.retornaSobrenome()}");
                    Console.WriteLine($" | DISCIPLINA: {professor.retornaDisciplina()} | DESATIVADO: {professor.retornaDesativado()}");
                }

                if (lista.Count == 0)
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
        public void ListarProfessor()
        {
            Console.Clear();

            try
            {
                Console.Write("Insira o ID do professor: ");
                int idE = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n");

                Professor professor = repositorioProfessor.RetornaPorId(idE);

                Console.Clear();

                Console.WriteLine("DADOS NO SISTEMA");

                Console.Write("\n");

                Console.WriteLine($"NOME......: {professor.retornaNome()} {professor.retornaNome()}");
                Console.WriteLine($"CPF.......: {professor.retornaCPF()}");
                Console.WriteLine($"DISCIPLINA: {professor.retornaDisciplina()}");
                Console.WriteLine($"DESATIVADO: {professor.retornaDesativado()}");

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
        public void CadastrarProfessor()
        {
            Console.Clear();

            try
            {
                Console.WriteLine("CADASTRO DE PROFESSOR");

                Console.Write("\n");

                Professor professor = criaProfessor();

                repositorioProfessor.Inserir(professor);
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
        public void ExibeDisciplinas()
        {
            Console.Write("\n");

            Console.WriteLine("DISCIPLINAS");

            Console.Write("\n");

            foreach (int i in Enum.GetValues(typeof(Disciplina)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Disciplina), i));
            }

            Console.Write("\n");
        }
        public void AtualizarProfessor()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE PROFESSOR");

            Console.Write("\n");

            try
            {
                Console.Write("Informe o ID do professor: ");
                int idE = Convert.ToInt32(Console.ReadLine());

                Professor professor = criaProfessor();

                repositorioProfessor.Atualizar(idE, professor);

                Console.Write("\n");

                Console.WriteLine("Professor atualizado com sucesso!");

                Console.Clear();

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
        public Professor criaProfessor()
        {
            try
            {
                Console.Write("Digite o Nome.......: ");
                string nomeE = Console.ReadLine();

                Console.Write("Digite o Sobrenome..: ");
                string sobrenomeE = Console.ReadLine();

                Console.Write("Digite o CPF........: ");
                string cpfE = Console.ReadLine();

                ExibeDisciplinas();

                Console.Write("Escolha a Disciplina: ");
                int disciplinaE = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("DADOS INSERIDOS");

                Console.Write("\n");

                Console.WriteLine($"NOME......: {nomeE}");
                Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
                Console.WriteLine($"CPF.......: {cpfE}");
                Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), disciplinaE)}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

                return new Professor(
                    id: repositorioProfessor.ProximoId(),
                    nome: nomeE,
                    sobrenome: sobrenomeE,
                    cpf: cpfE,
                    disciplina: (Disciplina)disciplinaE
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
        public void InserirNota()
        {
            Console.Clear();

            Console.WriteLine("INSERÇÃO DE NOTA");

            Console.Write("\n");

            try
            {
                Console.Write("Informe o ID do aluno: ");
                int idE = Convert.ToInt32(Console.ReadLine());

                Nota nota = criaNota(idE);

                repositorioNota.Inserir(nota);

                Console.Write("\n");
                Console.Write("Nota inserida com sucesso.");
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
        public Nota criaNota(int id)
        {
            Console.Write("\n");

            Console.Write("Informe a disciplina: ");
            Console.Write("\n");

            ExibeDisciplinas();

            int disciplina = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");
            Console.Write("Escolha a nota a ser inserida a partir das opções abaixo");
            Console.Write("\n");

            Console.WriteLine("1 - Primeira Nota");
            Console.WriteLine("2 - Segunda Nota");
            Console.WriteLine("3 - Terceira Nota");
            Console.WriteLine("4 - Quarta Nota");

            int opcaoNota = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            Console.Write("Insira a nota do aluno: ");
            double notaE = Convert.ToDouble(Console.ReadLine());

            Nota nota = new Nota(id, (Disciplina)disciplina);

            nota.InserirNota(opcaoNota, notaE);

            Console.Clear();

            Console.WriteLine("Dados digitados:");
            Console.Write("\n");
            Console.WriteLine($"ID........: {id}");
            Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), disciplina)}");
            Console.WriteLine($"NOTA......: {notaE}");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            return nota;
        }
        public void DesativarProfessor()
        {
            Console.Clear();

            Console.WriteLine("DESATIVAR PROFESSOR");

            Console.Write("\n");

            try
            {
                Console.Write("Informe o ID do professor: ");
                int idE = Convert.ToInt32(Console.ReadLine());

                repositorioProfessor.Desativa(idE);

                Console.Write("\n");

                Console.WriteLine("Professor desativado com sucesso!");

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