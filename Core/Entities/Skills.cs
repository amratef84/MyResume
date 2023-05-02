using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Skills :BaseNameEntity<Guid>
    {
        [Display(Name = " نوع المهارة  ")]
        public string? SkillType { get; set; }

        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
