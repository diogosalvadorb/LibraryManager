using LibraryManager.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Infrastructure.Persistence.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title)
                .HasMaxLength(50);

            builder.Property(x => x.Author)
                .HasMaxLength(50);

            builder.Property(x => x.Isbn)
               .HasMaxLength(13);

            builder.HasIndex(x => x.Isbn)
                .IsUnique();

            builder
                .HasMany(x => x.Loans)
                .WithOne(l => l.Book)
                .HasForeignKey(l => l.BookId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
