namespace Lab_8_potta__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Del 1
            Stack<Employee> myStack = new Stack<Employee>();

            Employee employee1 = new Employee(1, "Elias", "Male", 2900);
            Employee employee2 = new Employee(2, "Lukas", "Male", 3100);
            Employee employee3 = new Employee(3, "Adam", "Male", 3200);
            Employee employee4 = new Employee(4, "Sofie", "Woman", 2600);
            Employee employee5 = new Employee(5, "Emilia", "Woman", 2700);

            myStack.Push(employee1);
            myStack.Push(employee2);
            myStack.Push(employee3);
            myStack.Push(employee4);
            myStack.Push(employee5);

            int num = myStack.Count();
            foreach (Employee emp in myStack)
            {
                Console.WriteLine("Items left in the stack = " + num--);
                Console.Write($"Id: {emp.Id}\nName: {emp.Name}\nGender: {emp.Gender}\nSalary: {emp.Salary}\n\n");
            }
            num = myStack.Count();

            Employee emp1 = myStack.Pop();
            Console.WriteLine($"Items left in the stack = {num--}\n{emp1}");
            Employee emp2 = myStack.Pop();
            Console.WriteLine($"Items left in the stack = {num--}\n{emp2}");
            Employee emp3 = myStack.Pop();
            Console.WriteLine($"Items left in the stack = {num--}\n{emp3}");
            Employee emp4 = myStack.Pop();
            Console.WriteLine($"Items left in the stack = {num--}\n{emp4}");
            Employee emp5 = myStack.Pop();
            Console.WriteLine($"Items left in the stack = {num--}\n{emp5}\n");

            myStack.Push(emp1);
            myStack.Push(emp2);
            myStack.Push(emp3);
            myStack.Push(emp4);
            myStack.Push(emp5);

            Employee firstElement = myStack.Peek();
            Employee secondElement = myStack.Peek();

            string first = "first";
            string second = "second";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Items left in the stack = {myStack.Count()}");
                if (i == 0)
                {
                    Console.Write($"{first} Element: \nId: {firstElement.Id}\nName: {firstElement.Name}\nGender: {firstElement.Gender}\nSalary: {firstElement.Salary}\n\n");
                }
                else
                {
                    Console.Write($"{second} Element: \nId:  {secondElement.Id} \nName:  {secondElement.Name} \nGender:  {secondElement.Gender} \nSalary:  {secondElement.Salary}\n");
                }
            }

            num = 0;
            foreach (Employee emp in myStack)
            {
                if (num == 2)
                {
                    Console.WriteLine($"\nPeek at the third element:\nId: {emp.Id}\nName: {emp.Name}\nGender: {emp.Gender}\nSalary: {emp.Salary}\n");
                }
                num++;
            }

            // Del 2
            List<Employee> myList = new List<Employee>();
            myList.AddRange(myStack);

            if (myList.Contains(emp2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Employee maleEmployee = myList.Find(emp => emp.Gender == "Male");
            Console.WriteLine($"\nFirst male employee:\nId: {maleEmployee.Id}\nName: {maleEmployee.Name}\nGender: {maleEmployee.Gender}\n");
            List<Employee> allMaleEmployee = myList.FindAll(emp => emp.Gender == "Male");

            num = 1;
            foreach (Employee emp in allMaleEmployee)
            {
                Console.WriteLine($"Male employee {num}:\nId: {emp.Id}\nName: {emp.Name} \nGender:  {emp.Gender}\n");
                num++;
            }

            Console.Write("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}