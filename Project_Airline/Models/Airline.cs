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
        //This is the primary key
        public int Id { get; set; }
        //This is the variable to store the airline name
        public string airline_Name { get; set; }
        //This is the variable to store the airline email
        public string Email { get; set; }
        //This is the variable to store the airline mobile
        public int Mobile { get; set; }
        //This is the variable to store the airline ticket name
        public string ticket_Name { get; set; }
        //This is the variable to store the airline ticket cost
        public int cost { get; set; }

    }
}
