﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Services.Entities
{
    [Table("Courses")]
    class Course
    {
        /// <summary>
        /// Unique ID for the course
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// An identifier for the template course
        /// Example: "T-514-VEFT"
        /// </summary>
        public string TemplateID { get; set; }

        /// <summary>
        /// Example: "17.08.2015"
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Example: "20.11.2015"
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Example: "20153"
        /// </summary>
        public String Semester { get; set; }

        /// <summary>
        /// Indicates how many students can be enrolled in a given course at any given time.
        /// Example: 35
        /// </summary>
        public int MaxStudents { get; set; }
    }
}
