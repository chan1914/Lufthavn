using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lufthavn.Models.FlightDescription;

namespace Lufthavn.Models
{
    public class FlightContext : DbContext
    {
        public FlightContext (DbContextOptions<FlightContext> options)
            : base(options)
        {
        }

        public DbSet<Lufthavn.Models.FlightDescription.Flight> Flight { get; set; }
    }
}
