using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Invoicing.Core.Models
{
    public class Invoice : EntityBase
    {
        public Int32 ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public Decimal Amount { get; set; }
        
        [StringLength(10)] // Paid, Unpaid
        public String Status { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? DueDate { get; set; }
    }
}
