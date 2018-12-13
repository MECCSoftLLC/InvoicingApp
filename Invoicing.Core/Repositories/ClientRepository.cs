using Invoicing.Core.Data;
using Invoicing.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Core.Repositories
{
    public class ClientRepository : Repository<Client>
    {
        public ClientRepository(ApplicationDbContext context) :
            base(context)
        {

        }
    }
}
