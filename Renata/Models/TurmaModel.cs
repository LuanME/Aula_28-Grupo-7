namespace Aula28.Models
{
    public class TurmaModel
    {
        public List<Aluno> Alunos { get; set; }
    }

    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }    
        public string Sobrenome { get; set; }
        public string Status { get; set; }
    }
}
