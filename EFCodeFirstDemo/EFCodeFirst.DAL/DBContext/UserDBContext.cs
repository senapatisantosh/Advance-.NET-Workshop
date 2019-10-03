using EFCodeFirst.CL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.DAL.DBContext
{
    public class UserDBContext : DbContext
    {

        public UserDBContext() : base("name = UserEntities")
        {

        }

        //Add your Model or Entity
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }
}

