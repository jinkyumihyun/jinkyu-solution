using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Classes
{
    public static class EmployeeExtension
    {
        public static Employee NameOfTheEmployee(this Employee e, string FullName)
        {
            e.FullName = FullName;
            return e;
        }
        public static Employee Born(this Employee e, string DateOfBirth)
        {
            e.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return e;
        }
        public static Employee WorkingOn(this Employee e, string Department)
        {
            e.Department = Department;
            return e;
        }
        public static Employee StaysAt(this Employee e, string Address)
        {
            e.Address = Address;
            return e;
        }
        public static void ShowDetails(this Employee e)
        {
            Console.WriteLine($"Name: {e.FullName}, \nDateOfBirth: {e.DateOfBirth}, \nDepartment: {e.Department}, \nAddress: {e.Address}");
        }

    }
}
