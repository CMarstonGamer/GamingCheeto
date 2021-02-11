using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public string CardNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public bool AccountStatus { get; set; }
    }
}