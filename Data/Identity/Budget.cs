namespace Hotel.Data.Identity
{
    public class Budget
    {
        public Budget(int startCapital) 
        {
            CurrentState = startCapital;
        } 
        public int CurrentState { get; set; }

    }
}
