using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using quiz_ynov.Business.Models;

namespace quiz_ynov.EntityFramework
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(q => q.Quizs)
                .WithOne(q => q.Category)
                .HasForeignKey(q => q.Id);
        }
    }
}
