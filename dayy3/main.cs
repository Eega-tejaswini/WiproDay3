

namespace dayy3
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter student id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            Student st = new Student(id, name, marks);
            st.display();

            Employee e = new Employee();
            Console.WriteLine("enter employee id");
            e.empId = Convert.ToInt32(Console.ReadLine()); //assigning the user input to the class member directly since it is public
            Console.WriteLine("Enter the EmployeeName");
            e.empnamee= Console.ReadLine();
            e.Display();

        }
    }
}
