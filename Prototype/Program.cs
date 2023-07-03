using Prototype.Classes;
using Prototype.Interfaces;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Prototype\n");

            IPermanentEmployee permEmp1 = new PermanentEmployee()
            {
                Name = "Anurag",
                Department = "IT",
                Salary = 100000,
                Address = new Address("First Street", "East Orange", "N.J.")
            };
            permEmp1.ShowDetails();

            IPermanentEmployee permEmp2 = permEmp1.GetClone();
            permEmp2.ShowDetails();

            permEmp2.Name = "Pranaya";
            permEmp2.Department = "HR";
            permEmp2.Address = new Address("North Highland", "Sacramento", "California");
            permEmp2.ShowDetails();

            // Creating an Instance of Temporary Employee Class
            ITemporaryEmployee tempEmp3 = new TemporaryEmployee()
            {
                Name = "Preety",
                FixedAmount = 200000,
                 Address = new Address("Saint Street", "New Orleans", "Luisiana")
            };

            ITemporaryEmployee tempEmp4 = tempEmp3.GetClone();

            tempEmp4.Name = "Priyanka";
            tempEmp3.ShowDetails();
            tempEmp4.ShowDetails();

            List<IEmployee> l = new List<IEmployee>();
            l.Add(permEmp1);
            l.Add(permEmp2);
            l.Add(tempEmp3);
            l.Add(tempEmp4);

            l.ForEach(e => e.ShowDetails());
           
        }
    }
}