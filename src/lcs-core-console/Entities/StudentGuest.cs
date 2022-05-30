using lcs_core_console.Enums;

namespace lcs_core_console.Entities
{
    public class StudentGuest : Student
    {
        public override string Name { get; set; }

        public override string PisNumber { get; set; }

        public override string CpfNumber { get; set; }

        public override string CompanyName { get; set; }

        public StudentGuest() : base()
        {
            StudentType = TypeStudent.Guest;

            Name = "Name Guest";
            PisNumber = "PisNumber Guest";
            CpfNumber = "CpfNumber Guest";
            CompanyName = "CompanyName Guest";
        }
    }
}