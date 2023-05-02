using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Languages : BaseNameEntity<Guid>
    {
        [Display(Name = " المستوى  ")]
        public string? Level { get; set; }

        [Display(Name = " هل هي اللغة الأم  ")]
        public bool? IsMotherLang { get; set; }


        [Display(Name = " البروفايل  ")]
        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
