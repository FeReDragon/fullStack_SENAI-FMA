using System.Collections.Generic;
using System.Linq;

public class AlunosRepository
{
    private static List<AlunoModel> lista = new List<AlunoModel>
    {
        new AlunoModel { Id = 1, Nome = "João", DataDeNascimento = new DateTime(2000, 1, 1) },
        new AlunoModel { Id = 2, Nome = "Maria", DataDeNascimento = new DateTime(1999, 5, 15) },
        new AlunoModel { Id = 3, Nome = "Pedro", DataDeNascimento = new DateTime(2002, 7, 20) },
        new AlunoModel { Id = 4, Nome = "Ana", DataDeNascimento = new DateTime(2001, 3, 10) }
    };

    public List<AlunoModel> ListarAlunos(string filtroNome)
    {
        if (string.IsNullOrEmpty(filtroNome))
            return lista;
        else
            return lista.Where(x => x.Nome.Equals(filtroNome, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public AlunoModel ObterAluno(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id);
    }

    public AlunoModel AdicionarAluno(AlunoModel aluno)
    {
        aluno.Id = lista.Count + 1;
        lista.Add(aluno);
        return aluno;
    }

    public void RemoverAluno(int id)
    {
        var aluno = ObterAluno(id);
        lista.Remove(aluno);
    }
}
