using System.ComponentModel.DataAnnotations;

namespace SenaiApp.Domain.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
