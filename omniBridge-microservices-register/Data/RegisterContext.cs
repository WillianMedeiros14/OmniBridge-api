using omniBridge_microservices_register.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace omniBridge_microservices_register.Data;

public class RegisterContext : IdentityDbContext<UserModel>
{
    public RegisterContext(DbContextOptions<RegisterContext> opts) : base(opts)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Ignore<Microsoft.AspNetCore.Identity.IdentityRole>();
        modelBuilder.Ignore<Microsoft.AspNetCore.Identity.IdentityUserRole<string>>();
        modelBuilder.Ignore<Microsoft.AspNetCore.Identity.IdentityUserClaim<string>>();
        modelBuilder.Ignore<Microsoft.AspNetCore.Identity.IdentityUserLogin<string>>();
        modelBuilder.Ignore<Microsoft.AspNetCore.Identity.IdentityUserToken<string>>();

    }
}