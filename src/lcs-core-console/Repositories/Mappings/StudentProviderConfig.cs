using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using lcs_core_console.Entities;

namespace lcs_core_console.Repositories.Mappings
{
    public class StudentProviderConfig : IEntityTypeConfiguration<StudentProvider>
    {
        public void Configure(EntityTypeBuilder<StudentProvider> builder)
        {
            builder.ToTable("Student");

            builder.Property(x => x.ProviderId).IsRequired(true);
            builder.Property(x => x.EmployeeRegisterId).IsRequired(true);
        }
    }
}