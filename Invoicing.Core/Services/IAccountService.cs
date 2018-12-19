using System;
using System.Collections.Generic;
using System.Text;
using Invoicing.Core.ViewModels;

namespace Invoicing.Core.Services
{
    public interface IAccountService
    {
        Boolean Login(String email, String password);
        Boolean Signup(SignupViewModel signupData);
    }
}
