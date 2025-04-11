namespace TicketGlobo.TicketManagement.Domain.Common;

public class AuditableEntity
{
    public string CreatedBy { get; set; }
    public DateTime CreateDate { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}