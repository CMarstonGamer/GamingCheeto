using System;
namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public bool managerOrStaff { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string password { get; set; }
    }
}