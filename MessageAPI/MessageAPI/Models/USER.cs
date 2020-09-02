using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessageAPI.Models
{
    [Table("USER")]
    public class USER
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ID { get; set; }
        public string LOGIN { get; set; }
        public string PASSWORD { get; set; }
        public string NAME { get; set; }
        public Int64 TEL { get; set; }
    }
}
