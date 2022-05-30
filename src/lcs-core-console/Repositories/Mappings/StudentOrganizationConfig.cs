using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using lcs_core_console.Entities;

namespace lcs_core_console.Repositories.Mappings
{
    public class StudentOrganizationConfig : IEntityTypeConfiguration<StudentOrganization>
    {
        public void Configure(EntityTypeBuilder<StudentOrganization> builder)
        {
            builder.ToTable("Student");

            builder.Property(x => x.OrganizationId).IsRequired(true);
        }
    }
}