using TicketGlobo.TicketManagement.Domain.Common;

namespace TicketGlobo.TicketManagement.Domain.Entities;

public class Category: AuditableEntity
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    
}