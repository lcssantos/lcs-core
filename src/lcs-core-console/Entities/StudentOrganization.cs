using lcs_core_console.Enums;

namespace lcs_core_console.Entities
{
    public class StudentOrganization: Student
    {
        public Guid OrganizationId { get; set; }

        public override string Name { get => "Name Organization"; set => value = ""; }

        public override string PisNumber { get => "PisNumber Organization"; set => value = ""; }

        public override string CpfNumber { get => "CpfNumber Organization"; set => value = ""; }

        public override string CompanyName { get => "CompanyName Organization"; set => value = ""; }

        public StudentOrganization() : base()
        {
            StudentType = TypeStudent.Organization;

            OrganizationId = Guid.NewGuid();
        }
    }
}