
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OptimalApi.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
   

    public class ApplicationDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
             IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<User> User { get; set; }
        public DbSet<EventLog> EventLog { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Invite> Invite { get; set; }
        public DbSet<LoanApplication> LoanApplication { get; set; }
        public DbSet<LoanRequest> LoanRequest { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<xAccountContact> xAccountContact { get; set; }
        public DbSet<xLoanRequestFinancialInstitution> xLoanRequestFinancialInstitution { get; set; }
        public DbSet<zAccountStatus> zAccountStatus { get; set; }
        public DbSet<zContactStatus> zContactStatus { get; set; }
        public DbSet<zAccountType> zAccountType { get; set; }
        public DbSet<zAddressType> zAddressType { get; set; }
        public DbSet<zFinancialInstitution> zFinancialInstitution { get; set; }
        public DbSet<zInviteStatus> zInviteStatus { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {

            var entries = ChangeTracker.Entries().Where(e => (e.State == EntityState.Added || e.State == EntityState.Modified) && !(e.Entity is RefreshToken)).ToList();

            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Modified)
                {
                    entityEntry.Property("ModifiedOn").CurrentValue = DateTime.Now;
                }
                else if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property("CreateOn").CurrentValue = DateTime.Now;
                    entityEntry.Property("ModifiedOn").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
