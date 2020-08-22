﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo_system.Student_Entities
{
    public class RegisteredCourse : Course
    {
        #region RegisteredCourse Fields
        private int studentId;
        private double percent;
        private string symbol;
        private string courseDetails;
        #endregion

        #region RegisteredCourse Properties
        public int IDstudent
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        public string CourseDetails
        {
            get { return courseDetails; }
            set { courseDetails = value; }
        }
        #region

    }
}
