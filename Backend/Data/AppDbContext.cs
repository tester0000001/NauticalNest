
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<User> Users { get; set; }
    public DbSet<Berth> Berths { get; set; }
    public DbSet<Ship> Ships { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     // definition of relationships and keys
    modelBuilder.Entity<Reservation>()
        .HasOne(r => r.User)
        .WithMany(u => u.Reservations)
        .HasForeignKey(r => r.UserId);

    modelBuilder.Entity<Reservation>()
        .HasOne(r => r.Ship)
        .WithMany(s => s.Reservations)
        .HasForeignKey(r => r.ShipId);

    modelBuilder.Entity<Reservation>()
        .HasOne(r => r.Berth)
        .WithMany(b => b.Reservations) 
        .HasForeignKey(r => r.BerthId);
    }
}