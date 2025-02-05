using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    

   
        public static class InMemorySource
        {
            public static Plane Boeing1 { get; private set; }
            public static readonly Plane Boeing2;
            public static readonly Plane Airbus;

            public static readonly IList<Staff> Staffs = new List<Staff>
        {
            new Staff { FirstName = "Captain", LastName = "Captain", BirthDate = new DateTime(1965, 1, 1), EmployementDate = new DateTime(1999, 1, 1), Salary = 10000 },
            new Staff { FirstName = "Hostess1", LastName = "Hostess1", BirthDate = new DateTime(1995, 1, 1), EmployementDate = new DateTime(2019, 1, 1), Salary = 5000 }
        };

            public static readonly IList<Traveller> Travellers = new List<Traveller>
        {
            new Traveller { FirstName = "Traveller1", LastName = "Traveller1", BirthDate = new DateTime(1980, 1, 1), HealthInformation = "No troubles", Nationality = "American" }
        };

            public static readonly IList<Flight> Flights = new List<Flight>
        {
            new Flight { FlightId = 1, FlightDate = new DateTime(2022, 1, 1), Destination = "Paris", EffectiveArrival = new DateTime(2022, 1, 1), EstimatedDuration = 2 }
        };

            static InMemorySource()
            {
                Boeing1 = CreateBoeing1();
                Boeing2 = new Plane(PlaneType.Commercial, 150, new DateTime(2015, 2, 3));
                Airbus = new Plane { Type = PlaneType.Commercial, Capacity = 250, ManufactureDate = new DateTime(2020, 11, 11) };

                Flights[0].Plane = Boeing1;
                Flights[0].Passengers = new List<Passenger>(Staffs);
            }

            private static Plane CreateBoeing1()
            {
                Plane plane = new Plane();
                plane.Type = PlaneType.Commercial;
                plane.Capacity = 200;
                plane.ManufactureDate = new DateTime(2019, 12, 31);
                return plane;
            }
        }
    }




