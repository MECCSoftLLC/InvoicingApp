using Invoicing.Core.Data;
using Invoicing.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Core.Repositories
{
    public class ApplicationUserRepository : Repository<ApplicationUser>
    {
        public ApplicationUserRepository(ApplicationDbContext context) :
            base(context)
        {

        }
    }
}
