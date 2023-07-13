using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Student
    {
        public int id;
        public string name;
        public string mobileNo;
        public string email;
        public int age;
        public Student()
        {

        }
        public Student(int id, string name, string mobileNo, string email,int age) : this()
        {
            this.id = id;
            this.name = name;
            this.mobileNo = mobileNo;
            this.email = email;
            this.age = age;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {id}\nName: {name}\nAge: {age}\nMoble No: {mobileNo}\nEmail : {email}");
        }

       
    }
}
