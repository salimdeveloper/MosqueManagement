using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MosqueManagement.Core.Interfaces;
using MosqueManagement.Core.Models;
using MosqueManagement.Infrastructure.Data;

namespace MosqueManagement.Infrastructure
{
    public class MemberRepository : IMemberRepository
    {
        private ApplicationDbContext context;

        public MemberRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void AddMember(Member member)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Member>> GetAllMembersAsync()
        {
            return await context.Members.ToListAsync();
        }
    }
}