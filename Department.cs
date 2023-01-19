using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Department
    {

        public string Name { get; set; }
        StudentGrade studentGrade;
        Worker worker;

        public Department(Worker work, StudentGrade grade)
        {
            worker = work;
            studentGrade = grade;
        }

    }
}
