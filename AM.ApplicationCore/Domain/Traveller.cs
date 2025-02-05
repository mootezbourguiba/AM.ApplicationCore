namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public override string PassengerType => "Traveller passenger type";

        public override string ToString()
        {
            return base.ToString() + $" ({PassengerType})";
        }
    }
}
