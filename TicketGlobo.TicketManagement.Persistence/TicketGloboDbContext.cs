
using Microsoft.EntityFrameworkCore;

namespace TicketGlobo.TicketManagement.Persistence;

public class TicketGloboDbContext: DbContext
{
    public TicketGloboDbContext(DbContextOptions<TicketGloboDbContext> options) : base(options){}
}