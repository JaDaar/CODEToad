using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEToad.Data.Models
{

    public class CodeNote
    {
        [Key]
        public int CodeNoteId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Snippet { get; set; }
        public DateTime UpdateDate { get; set; }

        [Required]
        [StringLength(1)]
        public string StatusCode { get; set; }
    }
}
