using SenaiApp.Domain.Entidades;
using SenaiApp.Domain.Enums;

namespace SenaiApp.Domain.Entidade
{
    public class Cliente : BaseEntity
    {
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public SexoEnum Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
