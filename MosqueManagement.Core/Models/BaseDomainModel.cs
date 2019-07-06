using System;

namespace MosqueManagement.Core.Models
{
    public class BaseDomainModel
    {
      
        public DateTime LastModifiedDate { get; private set; }
        public void UpdateModifiedDate()
        {
            this.LastModifiedDate = DateTime.UtcNow;

        }
       

    }
}