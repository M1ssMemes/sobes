using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobes
{
    class Citizen
    {
        public readonly string Name;
        public readonly string Lastname;
        public readonly string Surname;
        public readonly DateTime Dayofbirth;
        public readonly string Address;
        public readonly string City;

        public override string ToString()
        {
            return string.Format( "Name : {0}, " +
                                  "Lastname : {1}, " +
                                  "Surname : {2}, " +
                                  "Day of birth {3}, " +
                                  "Address : {4}, " +
                                  "City : {5} ",
                                  Name, Lastname, Surname, 
                                  Dayofbirth, Address, City);
        }

        public Citizen(string name, string lastname, string surname, DateTime dayofbirth, string address, string city)
        {
            Name = name;
            Lastname = lastname;
            Surname = surname;
            Dayofbirth = dayofbirth;
            Address = address;
            City = city;
        }
    }
}
