using System;
using System.Collections.Generic;
using System.Linq;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class BasicFlightService : IBasicFlightService
    {
        private ICollection<Flight> _flights;

        public BasicFlightService(ICollection<Flight> source)
        {
            _flights = source;
        }

        public void ShowFlights(string filterType, string filterValue)
        {
            var filteredFlights = _flights.Where(f =>
                filterType.ToLower() switch
                {
                    "destination" => f.Destination.Equals(filterValue, StringComparison.OrdinalIgnoreCase),
                    "flightdate" => f.FlightDate == DateTime.Parse(filterValue),
                    "flightid" => f.FlightId == int.Parse(filterValue),
                    _ => throw new ArgumentException("Unknown filter")
                });

            foreach (var flight in filteredFlights)
            {
                Console.WriteLine($"Flight to {flight.Destination} on {flight.FlightDate}");
            }
        }
    }
}
