using System;
using System.Collections.Generic;
using System.Text;
using Invoicing.Core.Models;
using Invoicing.Core.ViewModels;

namespace Invoicing.Core.Services
{
    public class AccountService : ServiceBase, IAccountService
    {
        public AccountService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public Boolean Login(String email, String password)
        {
            ApplicationUser user = UnitOfWork.ApplicationUsers.GetApplicationUserByEmail(email);
            //if (email == "michaelemerick@meccsoft.com" && password == "test")
            if (user != null && user.Email == email && user.Password == password)
                return true;
            else
                return false;
        }

        public Boolean Signup(SignupViewModel signupData)
        {
            UnitOfWork.ApplicationUsers.AddUser(signupData);
            UnitOfWork.SaveChanges();
            return true;
        }
    }
}
