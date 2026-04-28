using System;

namespace RentingSystem.Models
{
    public class Property
    {
        public int PropertyID { get; set; }
        public int LandlordID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public decimal Price { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int Area { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedReason { get; set; }
    }
}