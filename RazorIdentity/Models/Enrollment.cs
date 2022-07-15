using System;
using System.Collections.Generic;

namespace RazorIdentity.Models
{
    public partial class Enrollment
    {
        public string CourseNum { get; set; }
        public int StudentId { get; set; }

        public virtual Courses CourseNumNavigation { get; set; }
        public virtual Students Student { get; set; }
    }
}
