using System.Collections.Generic;

public class Reservation
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    // Foreign Keys
    public int UserId { get; set; }
    public User User { get; set; }
    public int BerthId { get; set; }
    public Berth Berth { get; set; }
}