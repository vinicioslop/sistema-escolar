using sistema_escolar.console.Classes.Extras;
using sistema_escolar.console.Interfaces;
using sistema_escolar.console.Enum;

namespace sistema_escolar.console.Repositorios
{
    public class NotaRepositorio : IRepositorio<Nota>
    {
        private List<Nota> listaNota = new List<Nota>();
        public void Atualizar(int id, Nota nota)
        {
            listaNota[id] = nota;
        }
        public void Inserir(Nota nota)
        {
            listaNota.Add(nota);
        }
        public List<Nota> Lista()
        {
            return listaNota;
        }
        public int ProximoId()
        {
            return listaNota.Count;
        }
        public Nota RetornaPorId(int id)
        {
            return listaNota[id];
        }
        public Disciplina RetornaDisciplina(int id)
        {
            return listaNota[id].Disciplina;
        }
        public string AdicionaNota(int id, int opcao, double nota)
        {
            listaNota[id].Notas[opcao - 1] = nota;

            return "Nota inserida com sucesso.";
        }
        public string CalcularMedia(int id)
        {
            listaNota[id].Notas[4] = (listaNota[id].Notas[0] + listaNota[id].Notas[1] +
                listaNota[id].Notas[2] + listaNota[id].Notas[3]) / 4;

            DefineStatus(id);

            return "Média calculada com sucesso";
        }
        public void DefineStatus(int id)
        {
            if (listaNota[id].Notas[4] <= 5.4)
            {
                listaNota[id].AlteraStatus(Status.REPROVADO);
            }
            else if (listaNota[id].Notas[5] <= 6.9)
            {
                listaNota[id].AlteraStatus(Status.RECUPERACAO);
            }
            else
            {
                listaNota[id].AlteraStatus(Status.APROVADO);
            }
        }
    }
}
