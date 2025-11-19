using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public string Telefone { get; set;}
        [Display(Name = ("e-mail"))]
        public string Email { get; set;}
        [Display(Name=("Instituição"))]
        public int InstituicaoId { get; set;}
        public Instituição? InstituiçãoOrigem { get; set;}
        [Display(Name = ("Coordenador"))]
        public string NomeCoordenador { get; set;}
    }
}
