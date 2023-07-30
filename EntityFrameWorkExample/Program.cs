// See https://aka.ms/new-console-template for more information


using EntityFrameWorkExample;
using System.Security.Cryptography.X509Certificates;

StudentDbContext context = new StudentDbContext();

context.Students.Add(new Student { Name = "Hasan", Class = "MA", AdmissionDate = DateTime.Now, IsRegular = true});
context.Students.Add(new Student { Name = "C##", Class = "MA", AdmissionDate = DateTime.Now, IsRegular = true });
context.SaveChanges();

Student student = context.Students.Where(x=> x.Id==2).FirstOrDefault();

Console.WriteLine($"Name: {student.Name} Class: {student.Class}");

student.Name = "Angular";
context.SaveChanges();

context.Students.Remove(student);
context.SaveChanges();