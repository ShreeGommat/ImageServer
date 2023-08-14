using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.model
{
    [Table("ErrorLog")]
    public class ErrorLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorId { get; set; }

        [ForeignKey("ErrorTypeMstr")]
        public int ErrorTypeId { get; set; }

        public string ErrorDesc { get; set; }
        public string ErrorSource { get; set; }
        public string ErrorSrcIPAddr { get; set; }

        public DateTime ErrorDTime { get; set; }
    }
}
