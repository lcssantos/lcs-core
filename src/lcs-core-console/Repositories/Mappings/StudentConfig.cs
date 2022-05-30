using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using lcs_core_console.Entities;
using lcs_core_console.Enums;

namespace lcs_core_console.Repositories.Mappings
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");

            builder.Property(x => x.Id).ValueGeneratedNever().IsRequired();

            builder.HasDiscriminator(x => x.StudentType)
                .HasValue<Student>(TypeStudent.None)
                .HasValue<StudentGuest>(TypeStudent.Guest)
                .HasValue<StudentProvider>(TypeStudent.Provider)
                .HasValue<StudentOrganization>(TypeStudent.Organization);

            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.StudentType).HasColumnType("int").IsRequired();

            builder.Ignore(x => x.Name);
            builder.Ignore(x => x.PisNumber);
            builder.Ignore(x => x.CpfNumber);
            builder.Ignore(x => x.CompanyName);
        }
    }
}