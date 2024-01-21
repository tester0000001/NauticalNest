using System.Collections.Generic;

public class Ship
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<Reservation> Reservations { get; set; }
}
