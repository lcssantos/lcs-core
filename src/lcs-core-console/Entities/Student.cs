using lcs_core_console.Enums;

namespace lcs_core_console.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public TypeStudent StudentType { get; set; }

        public bool Status { get; set; }

        public virtual string Name { get; set; }

        public virtual string PisNumber { get; set; }

        public virtual string CpfNumber { get; set; }

        public virtual string CompanyName { get; set; }

        public Student()
        {
            Id = Guid.NewGuid();
            Status = true;

            Name = "Name Base";
            PisNumber = "PisNumber Base";
            CpfNumber = "CpfNumber Base";
            CompanyName = "CompanyName Base";
        }
    }
}