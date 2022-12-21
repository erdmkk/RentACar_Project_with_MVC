using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities.Concrete
{
    public class Users
    {
        [Key]
        public int userID { get; set; }
        public string userEmail { get; set; }
        public string userRole { get; set; }
        public string password { get; set; }
    }
}
