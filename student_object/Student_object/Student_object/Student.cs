using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_object
{
    internal class Student
    {
        public string Name;
        public string Topic;
        public double gpa;

        public Student(string aName, string aTopic, double agpa)
        {
            Name = aName;
            Topic = aTopic;
            gpa = agpa;
        }

        public bool HasHonors()
        {
            return gpa >= 3.5;
        }
    }
}
