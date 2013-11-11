using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Templates.Entities {
    public class MyDataContext:DbContext {
        public DbSet<Person> People { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
    public class Person {
        public Guid PersonKey { get; set; }
        [Required(ErrorMessage="First name is required.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Project {
        public Guid ProjectKey { get; set; }
        public Guid Name { get; set; }
        public IEnumerable<Vendor> Vendors { get; set; }
    }
    public class Vendor {
        public Guid VendorKey { get; set; }
        public Guid Name { get; set; }
    }
}
