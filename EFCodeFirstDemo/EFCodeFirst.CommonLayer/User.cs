using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.CL.Entity
{
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public long? DeptID { get; set; }

        [ForeignKey("DeptID")]
        public virtual Department Department { get; set; }
    }
}
