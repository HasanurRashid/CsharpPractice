﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public bool IsActive { get; set; }
        public DateTime ClassStartDate { get; set; }
    }
}
