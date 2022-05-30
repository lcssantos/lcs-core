using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using lcs_core_console.Entities;

namespace lcs_core_console.Repositories.Mappings
{
    public class StudentGuestConfig : IEntityTypeConfiguration<StudentGuest>
    {
        public void Configure(EntityTypeBuilder<StudentGuest> builder)
        {
            builder.ToTable("Student");

            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.PisNumber).IsRequired(true);
            builder.Property(x => x.CpfNumber).IsRequired(true);
            builder.Property(x => x.CompanyName).IsRequired(true);
        }
    }
}