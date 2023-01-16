using System;
using System.IO;

namespace HomeWork1
{
    public class Person
    {
        public string Name { get; set; }
        public string Passport { get; set; }
    }
    public class Student : Person
    { }
    public class Worker : Person
    {
        public string StartDate { get; set; }
    }
    public class University
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Departament
    {
        public string Name { get; set; }
    }
    public class Doctor : Worker
    { }
    public class PAS
    {

    }
    public class PDI
    { 

    }
}
