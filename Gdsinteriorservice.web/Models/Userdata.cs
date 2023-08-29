using System.ComponentModel.DataAnnotations;

namespace Gdsinteriorservice.web.Models
{
    public class Userdata
    {
        [Key]
        public int GUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Flattype { get; set; }

    }
}
