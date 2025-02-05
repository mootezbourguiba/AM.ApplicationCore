using System;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual string PassengerType => "Unknown passenger type";

        public override string ToString()
        {
            return $"{FirstName} {LastName}, born on {BirthDate.ToShortDateString()}";
        }
    }
}
