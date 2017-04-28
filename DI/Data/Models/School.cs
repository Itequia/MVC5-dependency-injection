using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Data.Models
{
    public class School
    {
        public School()
        {
            Students = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}