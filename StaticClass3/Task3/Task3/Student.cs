using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Student
    {
        private static int InstanceCount { get; set; } = 0;
        public Student()
        {
            InstanceCount++;
        }

        static public int ShowInstanceCount()
        {
            return InstanceCount;
        }
    }
}
