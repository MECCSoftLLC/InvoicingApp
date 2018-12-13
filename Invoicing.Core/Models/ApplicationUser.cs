using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Invoicing.Core.Models
{
    public class ApplicationUser : EntityBase
    {
        [StringLength(150)]
        public String Email { get; set; }

        [StringLength(250)]
        public String Password { get; set; }
    }
}
