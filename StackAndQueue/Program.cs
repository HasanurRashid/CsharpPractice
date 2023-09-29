// See https://aka.ms/new-console-template for more information




Queue<Customer> customersList = new Queue<Customer>();

customersList.Enqueue(new Customer() { Id=1,Name="Hasan",Gender="Male"});
customersList.Enqueue(new Customer() { Id=2,Name="Mamun",Gender="Male"});
customersList.Enqueue(new Customer() { Id=3,Name="Mizan",Gender="Male"});

foreach(Customer customer in customersList)
{
    Console.WriteLine($"Id: {customer.Id} Name: {customer.Name} Gender: {customer.Gender}");
}



Console.WriteLine(customersList.Count);

customersList.Dequeue();

foreach (Customer customer in customersList)
{
    Console.WriteLine($"Id: {customer.Id} Name: {customer.Name} Gender: {customer.Gender}");
}

Console.WriteLine(customersList.Count);
customersList.Peek();
 
Console.WriteLine(customersList.Count);

// ******************* //

Stack<Customer> stack = new Stack<Customer>();

stack.Push(new Customer() { Id = 1, Name = "Hasan", Gender = "Male" });
stack.Push(new Customer() { Id = 2, Name = "Mamun", Gender = "Male" });
stack.Push(new Customer() { Id = 3, Name = "Mizan", Gender = "Male" });
Console.WriteLine("Stack output");

foreach (Customer c in stack)
{
    Console.WriteLine($"Id: {c.Id}, Name: {c.Name}");
}
stack.Pop();

Console.WriteLine("Stack output after pop");

foreach (Customer c in stack)
{
    Console.WriteLine($"Id: {c.Id}, Name: {c.Name}");
}

Console.WriteLine(stack.Count);


class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    
}
