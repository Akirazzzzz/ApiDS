namespace ApiSegundoDS.Models
{
    public class Aluno
    {
        public int Id { get; set; } 
        public string? Bagi { get; set; }
        public string? RNA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public int EscolaID { get; set; }
        public int ProfessorID { get; set; }
    }
}
