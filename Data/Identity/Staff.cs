using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Data.Identity
{
    //[Authorize("Admin")]
    [Table("Staff", Schema = "data")]
    public class StaffClass
    {
        public string Name { get; set; }
        public int salary { get; set; }

        public string Email { get; set; }
        public string JobTitle { get; set; }
        public int ID { get; set; }
    }
}
