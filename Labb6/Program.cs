namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employees = new Stack<Employee>();

            Employee employee1 = new Employee("E001", "Svea", "woman", 45000);
            Employee employee2 = new Employee("E002", "Oskar", "man", 44000);
            Employee employee3 = new Employee("E003", "Sara", "woman", 44500);
            Employee employee4 = new Employee("E004", "Elin", "woman", 44500);
            Employee employee5 = new Employee("E005", "Prislla", "man", 44500);

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

        }
    }
}
