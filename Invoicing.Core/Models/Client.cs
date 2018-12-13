using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Invoicing.Core.Models
{
    public class Client : EntityBase
    {
        public Int32 ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [StringLength(50)]
        public String FirstName { get; set; }

        [StringLength(50)]
        public String LastName { get; set; }

        [StringLength(150)]
        public String Email { get; set; }

        [StringLength(2000)]
        public String Notes { get; set; }
    }
}
