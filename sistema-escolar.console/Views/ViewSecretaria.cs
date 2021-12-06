using System;
using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewSecretaria
    {
        public void HomeSecretaria()
        {
            string opcao, pagina = "1";

            do
            {
                Console.Clear();

                switch(pagina)
                {
                    case "1":
                        PrimeiraPagina();
                        break;
                    case "2":
                        SegundaPagina();
                        break;
                    default:
                        break;
                }

                Console.Write("\n  Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                if(opcao == "9")
                {
                    if(pagina == "2")
                    {
                        pagina = "1";
                        continue;
                    }
                    
                    pagina = "2";
                    continue;
                }

                Opcoes(pagina, opcao);
            } while (opcao != "X");
        }
        public void PrimeiraPagina()
        {
            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |           Interface de Secretario(a)           |");
            Console.WriteLine("  +------------------------------------------------+");
            Console.WriteLine("  | Insira a opção com base na ação preferida:     |");
            Console.WriteLine("  +------------------------------------------------+");
            Console.WriteLine("  | 1 - LISTAR DADOS DE ALUNO CADASTRADO NO        |");
            Console.WriteLine("  |     SISTEMA                                    |");
            Console.WriteLine("  | 2 - LISTAR ALUNOS CADASTRADOS NO SISTEMA       |");
            Console.WriteLine("  | 3 - LISTAR DADOS DE PROFESSORES CADASTRADOS NO |");
            Console.WriteLine("  |     SISTEMA                                    |");
            Console.WriteLine("  | 4 - LISTAR PROFESSORES CADASTRADOS NO SISTEMA  |");
            Console.WriteLine("  | 5 - CADASTRAR ALUNO NO SISTEMA                 |");
            Console.WriteLine("  | 6 - CADASTRAR PROFESSOR NO SISTEMA             |");
            Console.WriteLine("  | 7 - ATUALIZAR DADOS DE ALUNO CADASTRADO NO     |");
            Console.WriteLine("  |     SISTEMA                                    |");
            Console.WriteLine("  | 8 - ATUALIZAR DADOS DE PROFESSOR CADASTRADO NO |");
            Console.WriteLine("  |     SISTEMA                                    |");
            Console.WriteLine("  +------------------------------------------------+");
            Console.WriteLine("  | 9 - PRÓXIMA PÁGINA                             |");
            Console.WriteLine("  | X - VOLTAR PARA A HOME                         |");
            Console.WriteLine("  +------------------------------------------------+");
            Console.WriteLine("  |                   PÁGINA 1/2                   |");
            Console.WriteLine("  +================================================+");
        }
        public void SegundaPagina()
        {
            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |           Interface de Secretario(a)           |");
            Console.WriteLine("  +------------------------------------------------+");
            Console.WriteLine("  | Insira a opção com base na ação preferida:     |");
            Console.WriteLine("  +------------------------------------------------+");
            Console.WriteLine("  | 1 - CADASTRAR UMA NOVA SALA                    |");
            Console.WriteLine("  | 2 - ATUALIZAR UMA SALA EXISTENTE               |");
            Console.WriteLine("  | 3 - ADICIONAR ALUNO A UMA SALA                 |");
            Console.WriteLine("  | 4 - RETIRAR ALUNO DE UMA SALA                  |");
            Console.WriteLine("  +------------------------------------------------+");
            Console.WriteLine("  | 9 - VOLTA PARA A PÁGINA ANTERIOR               |");
            Console.WriteLine("  | X - VOLTAR PARA A HOME                         |");
            Console.WriteLine("  +------------------------------------------------+");
            Console.WriteLine("  |                   PÁGINA 2/2                   |");
            Console.WriteLine("  +================================================+");
        }
        public void Opcoes(string opcao, string pagina)
        {
            switch(pagina)
            {
                case "1":
                    OpcoesPrimeiraPagina(opcao);
                    break;
                case "2":
                    OpcoesSegundaPagina(opcao);
                    break;
                default:
                    break;
            }
        }
        public void OpcoesPrimeiraPagina(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    listarAluno();
                    break;
                case "2":
                    listarAlunos();
                    break;
                case "3":
                    listarProfessor();
                    break;
                case "4":
                    listarProfessores();
                    break;
                case "5":
                    cadastrarAluno();
                    break;
                case "6":
                    cadastrarProfessor();
                    break;
                case "7":
                    atualizarAluno();
                    break;
                case "8":
                    atualizarProfessor();
                    break;
                default:
                    break;
            }
        }
        public void OpcoesSegundaPagina(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    cadastrarSala();
                    break;
                case "2":
                    atualizarSala();
                    break;
                case "3":
                    adicionarAlunoNaSala();
                    break;
                case "4":
                    retirarAlunoDaSala();
                    break;
                default:
                    break;
            }
        }
        public void listarAluno()
        {
            try
            {
                Metodos.Metodos.ListarAluno();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void listarAlunos()
        {
            try
            {
                Metodos.Metodos.ListarAlunos();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void listarProfessor()
        {
            try
            {
                Metodos.Metodos.ListarProfessor();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void listarProfessores()
        {
            try
            {
                Metodos.Metodos.ListarProfessores();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void cadastrarAluno()
        {
            try
            {
                Metodos.Metodos.CadastrarAluno();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void cadastrarProfessor()
        {
            try
            {
                Metodos.Metodos.CadastrarProfessor();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void atualizarAluno()
        {
            try
            {
                Metodos.Metodos.AtualizarAluno();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void atualizarProfessor()
        {
            try
            {
                Metodos.Metodos.AtualizarProfessor();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void cadastrarSala()
        {
            Console.WriteLine("  FUNDCIONA.");
            MetodosComplementares.EsperaTecla();
        }
        public void atualizarSala()
        {
            Console.WriteLine("  FUNDCIONA.");
            MetodosComplementares.EsperaTecla();
        }
        public void adicionarAlunoNaSala()
        {
            Console.WriteLine("  FUNDCIONA.");
            MetodosComplementares.EsperaTecla();
        }
        public void retirarAlunoDaSala()
        {
            Console.WriteLine("  FUNDCIONA.");
            MetodosComplementares.EsperaTecla();
        }
    }
}