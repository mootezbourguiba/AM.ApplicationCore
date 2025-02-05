namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public double Salary { get; set; }

        public override string PassengerType => "Staff passenger type";

        public override string ToString()
        {
            return base.ToString() + $" ({PassengerType})";
        }
    }
}
