using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.model
{
    [Table("EventTypeMstr")]
    public class EventTypeMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventTypeId { get; set; }

        public int EventTypeCode { get; set; }

        [Required]
        public string ErrorTypeMnemonic { get; set; }

        public string? ErrorTypeDescription { get; set; }
    }
}
