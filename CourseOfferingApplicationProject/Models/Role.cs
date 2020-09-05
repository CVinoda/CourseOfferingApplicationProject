using System;
using System.Collections.Generic;

namespace CourseOfferingApplicationProject.Models
{
    public partial class Role
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        public int RoleId { get; set; }
        public string Role1 { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
