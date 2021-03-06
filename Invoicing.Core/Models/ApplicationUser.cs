﻿using System;
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

        [StringLength(250)]
        public String Name { get; set; }

        [StringLength(250)]
        public String CompanyName { get; set; }

        [StringLength(250)]
        public String Address { get; set; }

        [StringLength(15)]
        public String Phone { get; set; }

    }
}
