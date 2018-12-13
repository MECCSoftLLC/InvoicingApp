using System;
using System.Collections.Generic;
using System.Text;

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
            if (email == "michaelemerick@meccsoft.com" && password == "test")
                return true;
            else
                return false;
        }
    }
}
