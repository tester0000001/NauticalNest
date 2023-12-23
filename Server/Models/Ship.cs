using System.Collections.Generic;

public class Ship
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ArrivalTime { get; set; }
    public DateTime DepartureTime { get; set; }

    // Foreign Key
    public int BerthId { get; set; }
    public Berth Berth { get; set; }
}