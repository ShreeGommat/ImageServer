using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.model
{
    [Table("ServerAppSettings")]
    public class ServerAppSettings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SettingId { get; set; }

        public string ServerIPAddr { get; set; }

        public int ConfigIdelTimeout { get; set; }

        public int ConfigCaptureInterval { get; set; }

        public int ConfigCommIssueAutoResolveWindow { get; set; }

        public int ConfigHeartbeatInterval { get; set; }

        public string ConfigDestFolderPath { get; set; }

        public string ConfigAdminEmailAddr { get; set; }

        public string ConfigAdminADGroups { get; set; }
    }
}
