// See https://aka.ms/new-console-template for more information

using MethodHidings;

RegularEmployee re = new RegularEmployee();
re.firstName = "Halimatuzzahra";
re.lastName = "binte Hasan and Zihan";
re.printFullName();

Employee r = new RegularEmployee();

r.firstName = "Halima Cast";
r.lastName = "binte Hasan and Zihan";
((Employee)r).printFullName();