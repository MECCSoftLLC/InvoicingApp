using System;
using System.Collections.Generic;
using System.Text;
using Invoicing.Core.Data;
using Invoicing.Core.Repositories;

namespace Invoicing.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork()
        {
            ApplicationDbContextFactory contextFactory = new ApplicationDbContextFactory();
            _context = contextFactory.CreateDbContext(new string[] { });
        }

        private ApplicationUserRepository applicationUserRepository;
        public ApplicationUserRepository ApplicationUsers
        {
            get {
                if (applicationUserRepository == null)
                    applicationUserRepository = new ApplicationUserRepository(_context);
                return applicationUserRepository;
            }
        }

        private ClientRepository clientRepository;
        public ClientRepository Clients
        {
            get
            {
                if (clientRepository == null)
                    clientRepository = new ClientRepository(_context);
                return clientRepository;
            }
        }

        private InvoiceRepository invoiceRepository;
        public InvoiceRepository Invoices
        {
            get
            {
                if (invoiceRepository == null)
                    invoiceRepository = new InvoiceRepository(_context);
                return invoiceRepository;
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
