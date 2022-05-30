// See https://aka.ms/new-console-template for more information
using lcs_core_console.Repositories;
using lcs_core_console.Entities;

using (var context = new ApplicationDBContext())
{
    var studentGuest = new StudentGuest();
    var studentProvider = new StudentProvider();
    var studentOrganization = new StudentOrganization();

    context.Add(studentGuest);
    context.Add(studentProvider);
    context.Add(studentOrganization);

    context.SaveChanges();

    foreach(var student in context.Students)
    {
        Console.WriteLine(student.Name);
    }
}
