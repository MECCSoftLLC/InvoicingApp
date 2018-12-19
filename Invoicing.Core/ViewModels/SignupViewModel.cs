using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Core.ViewModels
{
    public class SignupViewModel
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String CompanyName { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
    }
}
