namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEL 1: STACK
            Console.WriteLine("==== DEL 1: STACK ====\n");

            //create stack
            Stack<Employee> employees = new Stack<Employee>();

            //create employees via construktor
            Employee employee1 = new Employee("E001", "Svea", "woman", 45000);
            Employee employee2 = new Employee("E002", "Oskar", "man", 44000);
            Employee employee3 = new Employee("E003", "Sara", "woman", 44500);
            Employee employee4 = new Employee("E004", "Elin", "woman", 44500);
            Employee employee5 = new Employee("E005", "Joseph", "man", 44500);

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

            //remove books via Pop - with while loop to avoid double coding
            Console.WriteLine("REMOVING EMPLOYEES:\n");

            //create a list for the removed employees so we save their data so we can push them back to the list later on
            List<Employee> removedEmployees = new List<Employee>();

            while (employees.Count > 0) //as long as the employees list is not empty
            {
                Employee removedEmployee = employees.Pop(); //remove an employee and save them as a variable
                Console.WriteLine($"The removed employee is: {removedEmployee.Name}\n" +
                    $"Objects remaining in stack: {employees.Count}\n");
                removedEmployees.Add(removedEmployee); //add the saved variable of the removed employee to the remoedEmployees list
            }

            //add all the removed employees in the removedmployees list back into the employees list via push method
            foreach(var employee in removedEmployees)
            {
                employees.Push(employee);
            }
            
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

            ///DEL 2: List
            Console.WriteLine("\n==== DEL 2: LIST ====\n");

            //create list
            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);

            //check if employee 2 is in the list via contains
            if (employeesList.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }

            //write out first object that has gender male via find method
            //save the result of the find method in an employee variable, that we can then write out afterwards
            Employee maleEmployee = employeesList.Find(emp => emp.Gender == "man");
            Console.WriteLine($"{maleEmployee.Name}, {maleEmployee.Id}, {maleEmployee.Gender}, {maleEmployee.Salary}\n");

            //write out all male employees via find all method
            //save the male employees in a list, which we then write out later on via foreach loop
            List<Employee> maleEmployees = employeesList.FindAll(emp => emp.Gender == "man");
            foreach(var maleEmp in maleEmployees)
            {
                Console.WriteLine($"{maleEmp.Name},{maleEmp.Id}, {maleEmp.Gender}, {maleEmp.Salary}");
            }

        }
    }
}
