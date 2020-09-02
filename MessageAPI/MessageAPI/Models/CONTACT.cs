using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessageAPI.Models
{
    [Table("CONTACT")]
    public class CONTACT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ID { get; set; }
        public Int64 ID_USER { get; set; }
        public Int64 ID_CONTACT { get; set; }

    }
}
