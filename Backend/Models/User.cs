using System.Collections.Generic;
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    
    // Role property to define user type
    public string Role { get; set; }

    // Link to a user that made the reservation
    public ICollection<Reservation> Reservations { get; set; }
}