using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
    public class Plateform
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string LicenseKey { get; set; } = null!;
    }
}