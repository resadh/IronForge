using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IMS.WebApp.Data
{
    public class AccountDbContext : IdentityDbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {
            
        }

    }
}
