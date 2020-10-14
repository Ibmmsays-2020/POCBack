using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Models
{
    public class Category:BaseEntity
    {
        public IList<Product> Products { get; set; }
    }
}
