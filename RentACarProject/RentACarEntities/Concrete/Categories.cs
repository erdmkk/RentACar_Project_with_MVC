using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities.Concrete
{
    public class Categories
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public virtual ICollection<Cars> Car { get; set; }
    }
}
