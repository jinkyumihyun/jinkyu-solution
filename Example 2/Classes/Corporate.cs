using DependencyInversion.Interface_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DependencyInversion.Classes_2
{
    public class Corporate
    {
        IIdProducer _idProducer;
        INameProducer _nameProducer;
        ISalaryProducer _salaryProducer;
        IDepartmentProducer _departmentProducer;

        public Corporate() { }
        public Corporate(
            IIdProducer idProducer, 
            INameProducer nameProducer, 
            ISalaryProducer salaryProducer, 
            IDepartmentProducer departmentProducer)
        {
            if (idProducer is null || nameProducer is null 
                || salaryProducer is null || departmentProducer is null)
                throw new ArgumentNullException(nameof(idProducer));

            _idProducer = idProducer;
            _nameProducer = nameProducer;
            _salaryProducer = salaryProducer;
            _departmentProducer = departmentProducer;
        }
        public void SetProducers
            (IIdProducer idProducer, 
            INameProducer nameProducer, 
            ISalaryProducer salaryProducer, 
            IDepartmentProducer departmentProducer)
        {
            if (idProducer is null || nameProducer is null 
                || salaryProducer is null || departmentProducer is null)
                throw new ArgumentNullException(nameof(idProducer));

            _idProducer = idProducer;
            _nameProducer = nameProducer;
            _salaryProducer = salaryProducer;
            _departmentProducer = departmentProducer;
        }
        public IEmployee GetEmployee(
            IIdProducer idProducer, 
            INameProducer nameProducer, 
            ISalaryProducer salaryProducer, 
            IDepartmentProducer departmentProducer)
        {
            return new Employee()
            {
                ID = idProducer.Produce(),
                Name = nameProducer.Produce(),
                Salary = salaryProducer.Produce(),
                Department = departmentProducer.Produce(),
            };
        }
        public IEmployee GetEmployee()
        {
            return  new Employee()
            {
                ID = _idProducer.Produce(),
                Name = _nameProducer.Produce(),
                Salary = _salaryProducer.Produce(),
                Department = _departmentProducer.Produce(),
            };
        }
      
    }
}

