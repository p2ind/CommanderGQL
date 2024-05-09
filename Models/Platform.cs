using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CommanderGQL.Models
{
    [GraphQLDescription("Represents any software or service that has a command line interface.")]
    public class Plateform
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;

        [GraphQLDescription("Represents a purhased, valid license for the pateform")]
        public string LicenseKey { get; set; } = null!;

        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}