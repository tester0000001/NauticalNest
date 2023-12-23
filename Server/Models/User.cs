using System.Collections.Generic;
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string Role { get; set; }

    // Navigation property for relationships
    public ICollection<Reservation> Reservations { get; set; }
}
