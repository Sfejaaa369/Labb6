namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create stack
            Stack<Employee> employees = new Stack<Employee>();

            //create employees via construktor
            Employee employee1 = new Employee("E001", "Svea", "woman", 45000);
            Employee employee2 = new Employee("E002", "Oskar", "man", 44000);
            Employee employee3 = new Employee("E003", "Sara", "woman", 44500);
            Employee employee4 = new Employee("E004", "Elin", "woman", 44500);
            Employee employee5 = new Employee("E005", "Prislla", "woman", 44500);

            //push employees into stack
            employees.Push(employee5);
            employees.Push(employee4);
            employees.Push(employee3);
            employees.Push(employee2);
            employees.Push(employee1);

            //show all employee info + how many items in stack
            Console.WriteLine("Here's an overview of all employees:\n"); 
            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.Name}, {employee.Id}, {employee.Gender}, {employee.Salary}\n" +
                    $"Objects remaining in stack: {employees.Count}\n");
            }
        }
    }
}
