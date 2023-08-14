using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.model
{
    [Table("EventLog")]
    public class EventLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [ForeignKey("EventTypeMstr")]
        public int EventTypeID { get; set; }

        public string EventDesc { get; set; }
        public string EventSource { get; set; }
        public string EventSrcIPAddr { get; set; }

        public DateTime EventDTime { get; set; }
    }
}
