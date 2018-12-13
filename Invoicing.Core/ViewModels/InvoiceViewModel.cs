using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Core.ViewModels
{
    public class InvoiceViewModel
    {
        public Int32 Id { get; set; }
        public Int32 ClientId { get; set; }
        public String ClientName { get; set; }
        public Decimal Amount { get; set; }
        public String Status { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
