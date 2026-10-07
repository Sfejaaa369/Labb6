namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create stack
            Stack<Employee> employees = new Stack<Employee>();

            //create employees via construktor
            Employee Svea = new Employee("E001", "Svea", "woman", 45000);
            Employee Oskar = new Employee("E002", "Oskar", "man", 44000);
            Employee Sara = new Employee("E003", "Sara", "woman", 44500);
            Employee Elin = new Employee("E004", "Elin", "woman", 44500);
            Employee Prislla = new Employee("E005", "Prislla", "woman", 44500);

            //push employees into stack
            employees.Push(Svea);
            employees.Push(Oskar);
            employees.Push(Sara);
            employees.Push(Elin);
            employees.Push(Prislla);

            //show all employee info + how many items in stack
            Console.WriteLine("Here's an overview of all employees:\n"); 
            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.Name}, {employee.Id}, {employee.Gender}, {employee.Salary}\n" +
                    $"Objects remaining in stack: {employees.Count}\n");
            }

            //remove books via Pop
            Console.WriteLine("We are now removing employees:\n");

            //while(employees.Count > 0) //as long as the employees list is not empty
            //{
            //    Employee removedEmployee = employees.Pop(); //we remove an employee and save their object
            //    Console.WriteLine($"The removed employee is: {removedEmployee.Name}\n" + //write name of the removed employee
            //        $"Objects remaining in stack: {employees.Count}\n"); //write how many objects are left in the stack
            //}

            Employee removedEmployee1 = employees.Pop();
            Console.WriteLine($"The removed employee is: {removedEmployee1.Name}\n" +
                $"Objects remaining in stack: {employees.Count}\n");
            Employee removedEmployee2 = employees.Pop();
            Console.WriteLine($"The removed employee is: {removedEmployee2.Name}\n" +
                $"Objects remaining in stack: {employees.Count}\n");
            Employee removedEmployee3 = employees.Pop();
            Console.WriteLine($"The removed employee is: {removedEmployee3.Name}\n" +
                $"Objects remaining in stack: {employees.Count}\n");
            Employee removedEmployee4 = employees.Pop();
            Console.WriteLine($"The removed employee is: {removedEmployee4.Name}\n" +
                $"Objects remaining in stack: {employees.Count}\n");
            Employee removedEmployee5 = employees.Pop();
            Console.WriteLine($"The removed employee is: {removedEmployee5.Name}\n" +
                $"Objects remaining in stack: {employees.Count}\n");


            //add employees back to stack
            employees.Push(removedEmployee1);
            employees.Push(removedEmployee2);
            employees.Push(removedEmployee3);
            employees.Push(removedEmployee4);
            employees.Push(removedEmployee5);

        }
    }
}
