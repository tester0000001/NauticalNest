using System.Collections.Generic;

public class Berth
{
    public int Id { get; set; }
    public string Location { get; set; }
    public string Size { get; set; }
    
    
    public ICollection<Reservation> Reservations { get; set; }
}
