using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class SettingsRecordRowValue
    {
        [Key]
        public Guid Id { get; set; }
        public Resource Resource { get; set; }
        public SettingsRecordData SettingsRecordData { get; set; }
        public string Value { get; set; }
    }
}