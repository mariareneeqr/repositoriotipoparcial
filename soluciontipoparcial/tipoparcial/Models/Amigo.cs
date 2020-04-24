

namespace tipoparcial.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum Typelist
    {
        Qua,
        Que,
        Qui,
        Quo,
        Quu,
    }
        
    public class Amigo
    {
        [Key]
        public int AmigoId { get; set; }
        [Required]
        [Display(Name =" Nombre completo")]
        [StringLength(50,MinimumLength = 5)]
        public string Name { get; set; }
        public Typelist List { get; set; }
        [Required]
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public int Birthday { get; set; }

    }
}