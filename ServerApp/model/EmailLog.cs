using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.model
{
    [Table("EmailLog")]
    public class EmailLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmailId { get; set; }

        public long ErrorId { get; set; }

        public long EventId { get; set; }
        public string EmailSubject { get; set; }

        public string EmailBody { get; set; }

        public DateTime CreatedDTime { get; set; }

    }
}
