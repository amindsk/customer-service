using System;

namespace ui.Models
{

    //Customer model to map list of customers fetched from API
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}