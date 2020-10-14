using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Models
{
    public class Product:BaseEntity
    {
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile[] FormFiles { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid CategoryId { get; set; }
        public IList<Images> Images { get; set; }

    }
}
