﻿namespace DataAccess.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public override string ToString()
    {
        return Name;
    }
}
