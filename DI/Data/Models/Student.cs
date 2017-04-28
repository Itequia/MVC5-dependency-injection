using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}