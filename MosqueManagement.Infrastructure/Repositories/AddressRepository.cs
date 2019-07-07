using MosqueManagement.Core.Interfaces;
using MosqueManagement.Core.Models;
using MosqueManagement.Infrastructure.Data;
using System.Linq;

namespace MosqueManagement.Infrastructure
{
    public class AddressRepository : IAddressRepository
    {
        private ApplicationDbContext _context;

        public AddressRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Address GetAddress(int id)
        {
            return _context.Addresses.Where(a => a.Id == id).SingleOrDefault();
        }
    }
}