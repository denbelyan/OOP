using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel
{
    [Table("Roles", Schema = "data")]
    public class RoleModel
    {
        public RoleModel() 
        {
            RoleName = "test";
            ID = 10234324;
        }
        public string RoleName { get; set; }

        public int ID { get; set; }
    }
}