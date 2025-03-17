namespace ApiSegundoDS.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string? Bagi { get; set; }
        public string? RNA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public string? ComponenteCurricular { get; set; }
        public Escola? Escola { get; set; }
        public Aluno? Aluno{ get; set; }
    }
}