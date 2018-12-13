using Invoicing.Core.Data;
using Invoicing.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Core.Repositories
{
    public class InvoiceRepository : Repository<Invoice>
    {
        public InvoiceRepository(ApplicationDbContext context) :
            base(context)
        {

        }
    }
}
