using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_Blazor_App.Data
{
    public class Publisher
    {
        public string PublisherId { get; set; }
        public string Publisher_Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Publisher()
        {

        }

        public Publisher(string pub_id, string publisher_name, string city, string state, string country)
        {
            PublisherId = pub_id;
            Publisher_Name = publisher_name;
            City = city;
            State = state;
            Country = country;
        }
        public string City { get; set; }
    }
}
