using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Airline.Models;

namespace Project_Airline.Data
{
    public class Project_AirlineContext : DbContext
    {
        public Project_AirlineContext (DbContextOptions<Project_AirlineContext> options)
            : base(options)
        {
        }

        public DbSet<Project_Airline.Models.Airline> Airline { get; set; }
    }
}
