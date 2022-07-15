using System;
using System.Collections.Generic;

namespace RazorIdentity.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public string CourseNum { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
