// See https://aka.ms/new-console-template for more information

using AdoDottNett;

string connectionString = "Server=MAAQ-HP;Database=CsharpDB;User Id=sa;Password=M@@q_786;TrustServerCertificate=true";
DataUtility dataUtility = new DataUtility(connectionString);

//string sql = @"update Student set Name = 'Ahsan_Update' where name ='Ahsan'";
//string sql = @"Delete Student  where name ='Ahsan_Update'";
string sql = @"Select * from Student where name =@name";
//dataUtility.ExecuteSql(sql);
var name = Console.ReadLine();

var parameters = new Dictionary<string, object>
{
    { "@name",name}
};

IList< Dictionary<string,object> > data = dataUtility.DataRead(sql, parameters);

foreach(var item in data)
{
    foreach(var parameter in item)
    {

    }
    Console.WriteLine($"ID: {item["ID"]}, Name: {item["Name"]},Class: {item["Class"]}");
}
