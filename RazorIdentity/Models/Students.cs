using System;
using System.Collections.Generic;

namespace RazorIdentity.Models
{
    public partial class Students
    {
        public Students()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
