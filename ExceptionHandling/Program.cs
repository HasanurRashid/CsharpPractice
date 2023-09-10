// See https://aka.ms/new-console-template for more information


//StreamReader streamReader = new StreamReader("E:\\Hasan\\DevSkill\\FileRead.txt");
//Console.WriteLine(streamReader.ReadToEnd());

//StreamWriter streamWriter = new StreamWriter("E:\\Hasan\\DevSkill\\Logg.txt");
//streamWriter.Write(Console.ReadLine());
//streamWriter.Close();


Student[] studentList = new Student[2];
studentList[0] = new Student
{
    Name= "Test",
    Gender=Gender.Male
};
studentList[1] = new Student
{
    Name = "Test2",
    Gender = Gender.Female
};

foreach(Student student in studentList)
{
    Console.WriteLine("Student Name : {0}  and gender : {1}",student.Name,student.Gender);
}



string GetGender(Gender number)
{
    switch (number)
    {
        case Gender.Male:
            return "Male";
        case Gender.Female:

            return "Female";
        default:
            return "Invalid";
            break;
    }
}
enum Gender
{
    Unknown,
    Female,
    Male

}
class Student
{
   public string Name { get; set; }
   public Gender Gender { get; set; }

}