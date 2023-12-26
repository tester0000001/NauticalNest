using System.Collections.Generic;

public class Reservation
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; } 
    public DateTime EndTime { get; set; } 

    
    public int BerthId { get; set; }
    public Berth Berth { get; set; }
    public int ShipId { get; set; }
    public Ship Ship { get; set; }
    
    //  Link to User that made a reservation
    public int? UserId { get; set; }
    public User User { get; set; }
}