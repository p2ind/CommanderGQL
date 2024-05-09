using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string HowTo { get; set; } = null!;

        [Required]
        public string CommandLine { get; set; } = null!;
        public int PlateformId { get; set; }
        public Plateform Plateform { get; set; }
    }
}