using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class SettingsRecordRow
    {
        [Key]
        public Guid Id { get; set; }
        public Resource Resource { get; set; }
        public List<SettingsRecordRowValue> SettingsRecordRowValue { get; set; }
    }
}
