using System;
using System.Collections.Generic;
using System.Text;

namespace MosqueManagement.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAddressRepository Addresses { get; }
        IMemberRepository Members { get; }
        IMemberTypeRepository MemberTypes { get; }
        void Complete();
        void CompleteAsync();
    }
}
