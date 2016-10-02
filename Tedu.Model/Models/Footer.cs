using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tedu.Model.Models
{
    [Table("Footers")]
    internal class Footer
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}