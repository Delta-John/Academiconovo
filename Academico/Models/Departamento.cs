namespace Academico.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public string Telefone { get; set;}
        public string Email { get; set;}
        public int InstituicaoId { get; set;}
        public Instituição? InstituiçãoOrigem { get; set;}
    }
}
