using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Resource
    {
        [Key]
        public Guid Id { get; set; }
        public string Type { get; set; }
        public SettingsRecordData SettingsRecordData { get; set; }
        public SettingsRecordRow SettingsRecordRows { get; set; }
        public List<ResourceField> ResourceFields { get; set; }
    }
}
