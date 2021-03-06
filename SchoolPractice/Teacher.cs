﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Subject { get; set; }
        private int YearsTeaching { get; set; }
        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
            this.YearsTeaching = yearsTeaching;
        }
    }
}
