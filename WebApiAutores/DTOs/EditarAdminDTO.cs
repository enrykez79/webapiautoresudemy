using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.DTOs
{
    public class EditarAdminDTO
    {
        [Required]
        [EmailAddress]
        public string Emaili { get; set; }
    }
}
