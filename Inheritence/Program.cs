// See https://aka.ms/new-console-template for more information

using Inheritence;

IrregularStudent irs = new IrregularStudent(1000);

irs.id= 1;
irs.name = "Mizanur Rashid";
irs.email = "mizan@gmail.com";
irs.mobileNo = "0181234567";
irs.age = 30;
irs.StudentInfo();
irs.PrintFine();

RegularStudent rs = new RegularStudent("Present");
rs.id = 2;
rs.name = "Hasanur Rashid";
rs.email = "Hasanur@gmail.com";
rs.mobileNo = "01812345678";
rs.age = 35;
rs.StudentInfo();
rs.TodaysAttendance();



