using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.model
{
    [Table("ErrorTypeMstr")]
    public class ErrorTypeMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorTypeId { get; set; }

        public int ErrorTypeCode { get; set; }

        public string ErrorTypeMnemonic { get; set; }

        public string? ErrorTypeDescription { get; set; }
    }
}
