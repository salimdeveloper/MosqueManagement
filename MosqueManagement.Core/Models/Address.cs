namespace MosqueManagement.Core.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public string ContactNo { get; set; }

        internal void Modify(Address address)
        {
            this.Address1 = address.Address1;
            this.Address2 = address.Address2;
            this.City = address.City;
            this.ContactNo = address.ContactNo;
            this.State = address.State;
            this.Pin = address.Pin;
        }
    }
}