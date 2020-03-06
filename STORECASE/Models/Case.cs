using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STORECASE.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
