using LibraryManager.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Infrastructure.Persistence.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder
                .HasOne(x => x.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId);

            builder
                 .HasOne(x => x.User)
                 .WithMany(u => u.Loans)
                 .HasForeignKey(l => l.UserId);

            builder
                .Property(x => x.LoanDate);

            builder
                .Property(x => x.LoanDate);
        }
    }
}
