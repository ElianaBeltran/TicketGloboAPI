﻿using TicketGlobo.TicketManagement.Domain.Common;

namespace TicketGlobo.TicketManagement.Domain.Entities;

public class Event: AuditableEntity
{
    public Guid EventId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
    public string Artist { get; set; }
    public string ImageUrl { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    
    
}