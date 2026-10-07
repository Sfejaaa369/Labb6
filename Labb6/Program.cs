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
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            //show all employee info + how many items in stack
            Console.WriteLine("OVERVIEW OF ALL EMPLOYEES\n"); 
            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.Name}, {employee.Id}, {employee.Gender}, {employee.Salary}\n" +
                    $"Objects remaining in stack: {employees.Count}\n");
            }

            //remove books via Pop
            Console.WriteLine("REMOVING EMPLOYEES:\n");
            Employee removedEmployee1 = employees.Pop();
            Console.WriteLine($"The removed employee is:\n" +
                $"{removedEmployee1.Name}, {removedEmployee1.Id}, {removedEmployee1.Gender}, {removedEmployee1.Salary}\n" +
                $"Objects remaining in stack: {employees.Count}\n");
            Employee removedEmployee2 = employees.Pop();
            Console.WriteLine($"The removed employee is:\n" +
                $"{removedEmployee2.Name},{removedEmployee2.Id}, {removedEmployee2.Gender}, {removedEmployee2.Salary}\n" +              
                $"Objects remaining in stack: {employees.Count}\n");
            Employee removedEmployee3 = employees.Pop();
            Console.WriteLine($"The removed employee is:\n" +
                $"{removedEmployee3.Name}, {removedEmployee3.Id}, {removedEmployee3.Gender}, {removedEmployee3.Salary}\n" +
            $"Objects remaining in stack: {employees.Count}\n");
            Employee removedEmployee4 = employees.Pop();
            Console.WriteLine($"The removed employee is:\n" +
                $"{removedEmployee4.Name}, {removedEmployee4.Id}, {removedEmployee4.Gender}, {removedEmployee4.Salary}\n" +
                $"Objects remaining in stack: {employees.Count}\n");
            Employee removedEmployee5 = employees.Pop();
            Console.WriteLine($"The removed employee is:\n" +
                $"{removedEmployee5.Name}, {removedEmployee5.Id}, {removedEmployee5.Gender}, {removedEmployee5.Salary}\n" +
                $"Objects remaining in stack: {employees.Count}\n");

            //add employees back to stack
            employees.Push(removedEmployee1);
            employees.Push(removedEmployee2);
            employees.Push(removedEmployee3);
            employees.Push(removedEmployee4);
            employees.Push(removedEmployee5);

            //retrieve via peek method
            Console.WriteLine("TOP OF THE LIST EMPLOYEES:\n");
            Console.WriteLine($"The employee on top of the list is:\n" +
                $"{employees.Peek().Name}, {employees.Peek().Id}, {employees.Peek().Gender}, {employees.Peek().Salary}\n" +
                $"Objects remaining in stack: {employees.Count}\n");
            Console.WriteLine($"The employee on top of the list is:\n" +
                $"{employees.Peek().Name}, {employees.Peek().Id}, {employees.Peek().Gender}, {employees.Peek().Salary}\n" +
                $"Objects remaining in stack: {employees.Count}\n");

            //check if employee 3 is in the stack
            if (employees.Contains(employee3))
            {
                Console.WriteLine("Yes, employee 3 is in the stack.");
            }
            else
            {
                Console.WriteLine("No, employee 3 is not in the stack.");
            }

            //create list
            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);

        }
    }
}
