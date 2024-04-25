namespace DataAccess.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public string? RoomType { get; set; }

    public string? Status { get; set; }

    public double? Price { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public override string ToString()
    {
        return RoomType;
    }
}
