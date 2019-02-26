using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prs.Models {
    public class Request {
        public int Id { get; set; }
        public int UserId { get; set; }
        [StringLength(80)]
        public string Description { get; set; }
        [StringLength(80)]
        public string Justification { get; set; }
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [StringLength(30)]
        public string DeliveryMode { get; set; }
        public DateTime? SubmittedDate { get; set; }
        [StringLength(10)]
        public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal(12, 2)")]
        public decimal Total { get; internal set; } = 0;
        public bool Active { get; set; } = true;

        public virtual User User { get; set; }
        public virtual IList<RequestLine> RequestLines { get; set; }

        public Request() {

        }
    }
}
