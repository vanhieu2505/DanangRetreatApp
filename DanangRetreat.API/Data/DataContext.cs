using DanangRetreat.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DanangRetreat.API.Data
{
    public class DataContext : DbContext
    {        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<AccommodationPrice> AccommodationPrices { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewType> ReviewTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }        
        public DbSet<RoomBed> RoomBed { get; set; }
        public DbSet<AccommodationRoom> AccommodationRoom { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AccommodationRoom>()
                .HasKey(x => new { x.AccommodationId, x.RoomId });

            builder.Entity<AccommodationRoom>()
                .HasOne(x => x.Accommodation)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.AccommodationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AccommodationRoom>()
                .HasOne(x => x.Room)
                .WithMany(x => x.Accommodations)
                .HasForeignKey(x => x.RoomId)
                .OnDelete(DeleteBehavior.Restrict);                
                
            builder.Entity<RoomBed>()
                .HasKey(x => new { x.RoomId, x.BedId });

            builder.Entity<RoomBed>()
                .HasOne(x => x.Room)
                .WithMany(x => x.Beds)
                .HasForeignKey(x => x.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RoomBed>()
                .HasOne(x => x.Bed)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.BedId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}