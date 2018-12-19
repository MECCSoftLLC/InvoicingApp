using Invoicing.Core.Data;
using Invoicing.Core.Models;
using Invoicing.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Invoicing.Core.Repositories
{
    public class ApplicationUserRepository : Repository<ApplicationUser>
    {
        public ApplicationUserRepository(ApplicationDbContext context) :
            base(context)
        {

        }

        public void AddUser(SignupViewModel signupData)
        {
            ApplicationUser newUser = new ApplicationUser();
            newUser.Email = signupData.Email;
            newUser.Password = signupData.Password; // ENCRYPT ME!!
            newUser.Name = signupData.Name;
            newUser.CompanyName = signupData.CompanyName;
            newUser.Address = signupData.Address;
            newUser.Phone = signupData.Phone;

            _context.ApplicationUsers.Add(newUser);
        }

        public ApplicationUser GetApplicationUserByEmail(String email)
        {
            return _context.ApplicationUsers
                .Where(user => user.Email == email)
                .FirstOrDefault();
        }
    }
}
