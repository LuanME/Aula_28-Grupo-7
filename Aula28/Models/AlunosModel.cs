namespace Aula28.Models
{
    public class AlunosModel
    {
        public List <Aluno> Turma { get; set; }
        public List<Materia> Materias { get; set; }

    }
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Status { get; set; }
    }
    public class Materia
    {
        public string Descricao { get; set; }
        public double PrimeiroSemestre { get; set; }
        public double SegundoSemestre { get; set; }
        public double TerceiroSemestre { get; set; }
        public double QuartoSemestre { get; set; }
        public string Status { get; set; }

    }
}
