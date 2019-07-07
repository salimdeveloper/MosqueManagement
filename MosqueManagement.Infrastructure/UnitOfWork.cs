using MosqueManagement.Core.Interfaces;
using MosqueManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MosqueManagement.Infrastructure
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IAddressRepository Addresses { get; private set; }
        public IMemberRepository Members { get; private set; }
        public IMemberTypeRepository MemberTypes { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Addresses = new AddressRepository(context);
        }
        public void Complete()
        {
            _context.SaveChanges();
        }

        public void CompleteAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
