using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tedu.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int GroupID { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}