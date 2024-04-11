namespace Hotel.Data.Identity
{
    public class HotelClass
    {
        public HotelClass(string Hname, Budget Hbudget) 
        {
            name = Hname;
            budget = Hbudget;

        }
        public string name { get; set; }
        public List<Order> orders;
        public List<HotelRoom> rooms;
        public Budget budget;
    }
}
