namespace MosqueManagement.Core.Models
{
    public class Member : BaseDomainModel
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public MemberType MemberType { get; set; }
        public Address Address { get; set; }
        public bool IsActive { get; private set; }
        public void DeActivateMember()
        {
            this.IsActive = false;
        }
        public void ActivateMember()
        {
            this.IsActive = true;
        }
    


    }
}