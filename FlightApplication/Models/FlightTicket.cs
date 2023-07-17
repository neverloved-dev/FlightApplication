namespace FlightApplication.Models
{
    public enum DestinationMark 
    {
        U,
        E,
        A,
        Z
    }
    public enum MealMark
    {
        G,
        H,
        K,
        g,
        h,
        k
    }

    public enum FlightClass
    {
        P,
        Q,
        R
    }
    public enum FromMark
    {
        EU,
        ZZ
    }
    public class FlightTicket
    {
        public int Id { get; set; }
        public DestinationMark Destination {  get; set; }
        public MealMark Meal { get; set; }
        public FlightClass Class { get; set; }
        public FromMark From { get; set; }
    }
}
