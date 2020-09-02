using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessageAPI.Models
{
    [Table("MESSAGE")]
    public class MESSAGE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ID { get; set; }
        public Int64 ID_SENDER { get; set; }
        public Int64 ID_RECEIVER { get; set; }
        public string MSG { get; set; }
    }
}
