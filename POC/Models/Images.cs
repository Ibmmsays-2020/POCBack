using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Models
{
    public class Images
    {
        public Guid Id { get; set; }
        public string FullPath { get; set; }
        public Guid ProductId { get; set; }
    }
}
