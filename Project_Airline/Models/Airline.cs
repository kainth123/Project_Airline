using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Airline.Models
{
    public class Airline
    {
        [Key]
        public int Id { get; set; }
        public string airline_Name { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string ticket_Name { get; set; }
        public int cost { get; set; }

    }
}
