using System.Net.Mail;

namespace ClassLibrary
{
    public class DataManager
    {

        /// <summary>
        /// Save the list of airlines to a file
        /// </summary>
        /// <param name="listAirlines">List of airlines</param>
        /// <param name="file">File to save list of airlines</param>
        public static void SaveAirlines(List<Airline> listAirlines, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (Airline airline in listAirlines)
                {
                    // Line writes "Id;Name"
                    string line = $"{airline.Id};{airline.Name}";
                    sw.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Read the list of airlines from a file
        /// </summary>
        /// <param name="file">File that has list of airlines</param>
        /// <returns>List of airlines</returns>
        public static List<Airline> LoadAirlines(string file)
        {
            List<Airline> listAirlines = new List<Airline>(); // List of airlines to return at the end

            using (StreamReader sr = new StreamReader(file))
            {
                string line; // Line read by StreamReader

                while ((line = sr.ReadLine()) != null) // While the line read is not null
                {
                    // Split that line by ; "Id;Name" => parts[Id, Name]
                    string[] parts = line.Split(";");

                    Airline airline = new Airline // Create a new airline with those parameters
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                    };
                    listAirlines.Add(airline); // Add the airline to the list to return
                }
            }
            return listAirlines; // Return the list with the airlines read from the file
        }

        /// <summary>
        /// Save the list of airports to a file
        /// </summary>
        /// <param name="listAirports">List of airports</param>
        /// <param name="file">File to save list of airports</param>
        public static void SaveAirports(List<Airport> listAirports, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (Airport airport in listAirports)
                {
                    // Line writes "IATA;Country;City"
                    string linha = $"{airport.IATA};{airport.Country};{airport.City}";
                    sw.WriteLine(linha);
                }
            }
        }

        /// <summary>
        /// Read the list of airports from a file
        /// </summary>
        /// <param name="file">File that has list of airports</param>
        /// <returns>List of airports</returns>
        public static List<Airport> LoadAirports(string file)
        {
            List<Airport> listAirports = new List<Airport>(); // List of airports to return at the end

            using (StreamReader sr = new StreamReader(file))
            {
                string line; // Line read by StreamReader

                while ((line = sr.ReadLine()) != null) // While the line read is not null
                {
                    // Split that line by ; "IATA;Country;City" => parts[IATA, Country, City]
                    string[] parts = line.Split(";");

                    Airport airport = new Airport // Create a new airport with those parameters
                    {
                        IATA = parts[0],
                        Country = parts[1],
                        City = parts[2],
                    };
                    listAirports.Add(airport); // Add the airport to the list to return
                }
            }
            return listAirports; // Return the list with the airports read from the file
        }

        /// <summary>
        /// Save the list of aircrafts to a file
        /// </summary>
        /// <param name="listAircrafts">List of aircrafts</param>
        /// <param name="file">File to save list of aircrafts</param>
        public static void SaveAircrafts(List<Aircraft> listAircrafts, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (Aircraft aircraft in listAircrafts)
                {
                    // Line writes "Id;Brand;Model;Airline;Capacity;Rows;Status"
                    string line = $"{aircraft.Id};{aircraft.Brand};{aircraft.Model};{aircraft.Airline.Id};{aircraft.Capacity};{aircraft.Rows};{aircraft.Status}";
                    sw.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Read the list of aircrafts from a file
        /// </summary>
        /// <param name="listAirlines">List of airlines</param>
        /// <param name="file">File that has list of aircrafts</param>
        /// <returns>List of aircrafts</returns>
        public static List<Aircraft> LoadAircrafts(List<Airline> listAirlines, string file)
        {
            List<Aircraft> listAircrafts = new List<Aircraft>(); // List of aircrafts to return at the end

            using (StreamReader sr = new StreamReader(file))
            {
                string line; // Line read by StreamReader

                while ((line = sr.ReadLine()) != null) // While the line read is not null
                {
                    // Split that line by ; "Id;Brand;Model;Airline;Capacity;Rows;Status" => parts[Id, Brand, Model, Airline.Id, Capacity, Rows, Status]
                    string[] parts = line.Split(";");

                    Aircraft aircraft = new Aircraft // Create a new aircraft with those parameters
                    {
                        Id = int.Parse(parts[0]),
                        Brand = parts[1],
                        Model = parts[2],
                        Airline = listAirlines.FirstOrDefault(a => a.Id == int.Parse(parts[3])), // Return the single airline that matches the Id of parts[3]
                        Capacity = int.Parse(parts[4]),
                        Rows = int.Parse(parts[5]),
                        Status = bool.Parse(parts[6]),
                    };
                    listAircrafts.Add(aircraft); // Add the aircraft to the list to return
                }
            }
            return listAircrafts; // Return the list with the aircrafts read from the file
        }

        /// <summary>
        /// Save the list of flights to a file
        /// </summary>
        /// <param name="listFlights">List of flights</param>
        /// <param name="file">File to save list of flights</param>
        public static void SaveFlights(List<Flight> listFlights, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (Flight flight in listFlights)
                {
                    // Line writes "Id;DateDeparture;DateArrival;Duration;Origin;Destination;Aircraft.Id"
                    string line = $"{flight.Id};{flight.DateDeparture};{flight.DateArrival};{flight.Duration};{flight.Origin.IATA};{flight.Destination.IATA};{flight.Aircraft.Id}";
                    sw.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Read the list of flights from a file
        /// </summary>
        /// <param name="listAircrafts">List of aircrafts</param>
        /// <param name="file">File that has list of flights</param>
        /// <returns>List of flights</returns>
        public static List<Flight> LoadFlights(List<Aircraft> listAircrafts, List<Airport> listAirports, string file)
        {
            List<Flight> listFlights = new List<Flight>(); // List of flights to return at the end

            using (StreamReader sr = new StreamReader(file))
            {
                string line; // Line read by StreamReader

                while ((line = sr.ReadLine()) != null) // While the line read is not null
                {
                    // Split that line by ; "Id;DateDeparture;DateArrival;Duration;Origin.IATA;Destination.IATA;Aircraft.Id" => parts[Id, DateArrival, Duration, Origin.IATA, Destination.IATA, Aircraft.Id]
                    string[] parts = line.Split(";");

                    // Get the aircraft and extract the flights airline from it
                    Aircraft aircraft = listAircrafts.FirstOrDefault(a => a.Id == int.Parse(parts[6]));

                    Flight flight = new Flight // Create a new flight with those parameters
                    {
                        Id = int.Parse(parts[0]),
                        DateDeparture = DateTime.Parse(parts[1]),
                        DateArrival = DateTime.Parse(parts[2]),
                        Duration = TimeSpan.Parse(parts[3]),
                        Aircraft = aircraft,
                        Airline = aircraft.Airline,
                        Origin = listAirports.FirstOrDefault(a => a.IATA == parts[4]),
                        Destination = listAirports.FirstOrDefault(a => a.IATA == parts[5]),
                };
                    listFlights.Add(flight); // Add the flight to the list to return
                }
            }
            return listFlights; // Return the list with the flights read from the file
        }

        /// <summary>
        /// Save the list of tickets to a file
        /// </summary>
        /// <param name="listTickets">List of tickets</param>
        /// <param name="file">File to save list of tickets</param>
        public static void SaveTickets(List<Ticket> listTickets, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (Ticket ticket in listTickets)
                {
                    // Line writes "Id;Flight.Id;Client.Title;Client.FullName;Client.IdNumber;Client.ContactNumber;Client.Email;Client.DateOfBirth;Seat"
                    string line = $"{ticket.Id};{ticket.Flight.Id};{ticket.Client.Title};{ticket.Client.FullName};" +
                        $"{ticket.Client.IdNumber};{ticket.Client.ContactNumber};{ticket.Client.Email};{ticket.Client.DateOfBirth};{ticket.Seat}";
                    sw.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Load the list of tickets from a file
        /// </summary>
        /// <param name="listFlights">List of flights</param>
        /// <param name="file">File that has list of flights</param>
        /// <returns>List of tickets</returns>
        public static List<Ticket> LoadTickets(List<Flight> listFlights, string file)
        {
            List<Ticket> listTickets = new List<Ticket>(); // List of tickets to return at the end

            using (StreamReader sr = new StreamReader(file))
            {
                string line; // Line read by StreamReader

                while ((line = sr.ReadLine()) != null) // While the line read is not null
                {
                    // Split that line by ; "Id;Flight.Id;Client.Title;Client.FullName;Client.IdNumber;Client.ContactNumber;Client.Email;Client.DateOfBirth;Seat"
                    // => parts[Id, Flight.Id, Client.Title, Client.FullName, Client.IdNumber, Client.ContactNumber, Client.Email, Client.DateOfBirth, Seat]
                    string[] parts = line.Split(";");

                    MailAddress email;
                    try
                    {
                        email = new MailAddress(parts[6]);
                    }
                    catch (FormatException)
                    {
                        throw;
                    }

                    Ticket ticket = new Ticket // Create a new ticket with those parameters
                    {
                        Id = int.Parse(parts[0]),
                        Flight = listFlights.FirstOrDefault(f => f.Id == int.Parse(parts[1])),
                        Client = new Client
                        {
                            Title = parts[2],
                            FullName = parts[3],
                            IdNumber = parts[4],
                            ContactNumber = parts[5],
                            Email = email,
                            DateOfBirth = DateTime.Parse(parts[7]),
                        },
                        Seat = parts[8],
                    };
                    listTickets.Add(ticket); // Add the ticket to the list to return
                    ticket.Flight.UpdateTicketList(ticket, false); // Update the ticket list of the flight and seatings
                }
            }
            return listTickets; // Return the list with the tickets read from the file
        }

        /// <summary>
        /// Save the list of users to a file
        /// </summary>
        /// <param name="listUsers">List of users</param>
        /// <param name="file">File to save list of users</param>
        public static void SaveUsers(List<User> listUsers, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (User user in listUsers)
                {
                    // Line writes "Username, Password (encrypted)"
                    string line = $"{user.Username};{user.Password}";
                    sw.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Read the list of users from a file
        /// </summary>
        /// <param name="file">File that has list of users</param>
        /// <returns>List of users</returns>
        public static List<User> LoadUsers(string file)
        {
            List<User> listUsers = new List<User>(); // List of airlines to return at the end

            using (StreamReader sr = new StreamReader(file))
            {
                string line; // Line read by StreamReader

                while ((line = sr.ReadLine()) != null) // While the line read is not null
                {
                    // Split that line by ; "Username;Password" => parts[Username, Password]
                    string[] parts = line.Split(";");

                    User user = new User // Create a new user with those parameters
                    {
                        Username = parts[0],
                        Password = parts[1],
                    };
                    listUsers.Add(user); // Add the user to the list to return
                }
            }
            return listUsers; // Return the list with the users read from the file
        }
    }
}
