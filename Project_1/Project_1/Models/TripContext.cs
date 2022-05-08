using Microsoft.EntityFrameworkCore;

namespace Project_1.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    Destination = "England",
                    StartDate = 1,
                    EndDate = 2,
                    Accomodations = "Hotel",
                    ToDo = "Sightseeing"
                }
            );
        }
    }
}