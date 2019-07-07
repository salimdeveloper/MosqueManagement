using MosqueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MosqueManagement.Core.Interfaces
{
    public interface IAddressRepository
    {
        Address GetAddress(int id);
    }
}
