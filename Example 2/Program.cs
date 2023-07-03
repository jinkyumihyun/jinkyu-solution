using DependencyInversion.Classes_2;
using DependencyInversion.Interface_2;

namespace Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

        //parameter injection
        static void Test3()
        {
            var idProducer = new IdProducer();
            var nameProducer = new NameProducer();
            var salaryProducer = new SalaryProducer();
            var departmentProducer = new DepartmentProducer();

            var corporate = new Corporate(idProducer, nameProducer, salaryProducer, departmentProducer);
            var emp = corporate.GetEmployee();
            emp.Show();

            emp = corporate.GetEmployee(idProducer, nameProducer, salaryProducer, departmentProducer);
            emp.Show();

        }
        //constructor injection
        static void Test2()
        {
            var idProducer = new IdProducer();
            var nameProducer = new NameProducer();
            var salaryProducer = new SalaryProducer();
            var departmentProducer = new DepartmentProducer();
            var corporate = new Corporate(idProducer, nameProducer, salaryProducer, departmentProducer);
           
            for (int i = 0; i < 10; i++)
            {
                var emp = corporate.GetEmployee();
                emp.Show();
            }

        }
        //property injection
        static void Test1()
        {
            var corporate = new Corporate();
            var idProducer = new IdProducer();
            var nameProducer = new NameProducer();
            var salaryProducer = new SalaryProducer();
            var departmentProducer = new DepartmentProducer();

            corporate.SetProducers(idProducer, nameProducer, salaryProducer, departmentProducer);
            for (int i = 0; i < 10; i++)
            {
                var emp = corporate.GetEmployee();
                emp.Show();
            }
            
        }
    }

   
}