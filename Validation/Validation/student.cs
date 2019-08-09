using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validation
{
    class student
    {
        public string name
        {  get; set;}
        private double gpa;
        public  double GPA
        {  get
            {
                return gpa;
            }
            set
            {
                if ((value >= 0.00) && (value <= 4.00))
                    gpa = value;
                else { throw new ArgumentException();
                }}} }
}