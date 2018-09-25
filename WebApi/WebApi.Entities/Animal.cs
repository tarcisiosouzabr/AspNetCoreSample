using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        public int? PersonId { get; set; }

        [ForeignKey("SpeciesId")]
        public virtual Person Person { get; set; }
    }
}
