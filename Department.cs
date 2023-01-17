using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Department
    {

        Worker worker;
        public Department(Worker work)
        {
            worker = work;
        }
        StudentGrade studentGrade;
        public Department(StudentGrade grade)
        {
            studentGrade = grade;
        }
        public string Name { get; set; }

    }
}
