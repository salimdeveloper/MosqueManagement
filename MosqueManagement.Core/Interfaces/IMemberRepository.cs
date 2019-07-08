using System.Collections.Generic;
using System.Threading.Tasks;
using MosqueManagement.Core.Models;

namespace MosqueManagement.Core.Interfaces
{
    public interface IMemberRepository
    {
        void AddMember(Member member);
        //IEnumerable<Member> GetAllMembers();
        Task<List<Member>> GetAllMembersAsync();
    }
}