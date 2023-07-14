// See https://aka.ms/new-console-template for more information


using Polymorphism;

Student[] students= new Student[4];

students[0] = new RegularStudent();
students[1] = new IrregularStudent();
students[2] = new TempararyStudent();
students[3] = new Student();

foreach(Student student in students)
{
    student.FullName();
}

