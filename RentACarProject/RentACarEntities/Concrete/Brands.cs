using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities.Concrete
{
    public class Brands
    {
        [Key]
        public int brandID { get; set; }
        public string brandName { get; set; }

        public ICollection<Cars> Car { get; set; }
    }
}
