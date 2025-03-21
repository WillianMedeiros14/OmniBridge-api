using omniBridge_service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace omniBridge_service.Data;

public class OmniBridgeContext : IdentityDbContext<UserModel>
{
    public OmniBridgeContext(DbContextOptions<OmniBridgeContext> opts) : base(opts)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }

    public DbSet<AddressModel> Address { get; set; }
}