using System.ComponentModel.DataAnnotations;

namespace ControleDeMembros.Models
{
    public class Membros
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNasc { get; set; }
        public string Contato { get; set; }
        public string Endereço { get; set; }
    }
}
