using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class ResourceField
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public Resource Resource { get; set; }
    }
}

