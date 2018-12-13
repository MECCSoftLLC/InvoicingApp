using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Core.Services
{
    public interface IAccountService
    {
        Boolean Login(String email, String password);
    }
}
