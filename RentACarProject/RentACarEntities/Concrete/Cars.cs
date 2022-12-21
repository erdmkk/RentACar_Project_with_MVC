using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities.Concrete
{
    public class Cars
    {
        [Key]
        public int carID { get; set; }
        public string carName { get; set; }
        public int carPrice { get; set; }
        public int quantity { get; set; }
        public int doors { get; set; }
        public int brandID { get; set; }
        public int categoryID { get; set; }
        public Brands Brand { get; set; }
        public ICollection<Categories> Category{ get; set; }
    }
}
