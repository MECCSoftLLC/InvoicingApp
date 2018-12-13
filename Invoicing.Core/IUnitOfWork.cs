using Invoicing.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Core
{
    public interface IUnitOfWork
    {
        ApplicationUserRepository ApplicationUsers { get; }
        ClientRepository Clients { get; }
        InvoiceRepository Invoices { get; }

        int SaveChanges();
    }
}
