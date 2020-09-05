using System;
using System.Collections.Generic;

namespace CourseOfferingApplicationProject.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
