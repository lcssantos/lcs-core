using lcs_core_console.Enums;

namespace lcs_core_console.Entities
{
    public class StudentProvider: Student
    {
        public Guid ProviderId { get; set; }

        public Guid EmployeeRegisterId { get; set; }

        public override string Name { get => "Name Provider"; set => value = ""; }

        public override string PisNumber { get => "PisNumber Provider"; set => value = ""; }

        public override string CpfNumber { get => "CpfNumber Provider"; set => value = ""; }

        public override string CompanyName { get => "CompanyName Provider"; set => value = ""; }

        public StudentProvider() : base()
        {
            StudentType = TypeStudent.Provider;

            ProviderId = Guid.NewGuid();
            EmployeeRegisterId = Guid.NewGuid();
        }
    }
}