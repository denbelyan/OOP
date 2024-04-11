using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hotel.Data.Identity
{
        [Table("Orders", Schema = "data")]
        public class Order
        {
            public Order(int identifier, int UserGuestsNum, DateTime start, DateTime end)
            {
                ID = identifier;
                GuestsNum = UserGuestsNum;
                DateOfOrder = start;
                EndOfOrder = end;
                IsCompleted = false;
                Price = CalculatePrice();
            }
            public Order()
            {

            }
            public int ID { get; set; }

            [Required(ErrorMessage = "Enter number of Guests")]
            public int GuestsNum { get; set; }
            public float Price { get; set; }

            public bool IsCompleted { get; set; }

            [Required(ErrorMessage = "Enter Start Date")]
            public DateTime DateOfOrder { get; set; }

            [Required(ErrorMessage = "Enter End Date")]
            public DateTime EndOfOrder { get; set; }

            public int CalculatePrice()
            {
                return (EndOfOrder - DateOfOrder).Hours*100*GuestsNum;
            }
        }
    

}
