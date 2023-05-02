using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class BaseNameEntity<Tkey> : BaseEntity<Tkey>
    {

        [Display(Name = " الاسم  ")]
        public string? Name { get; set; }

        [Display(Name = " الاسم المختصر ")]
        public string? ShortName { get; set; }

        [Display(Name = " الوصف  ")]
        public string? Description { get; set; }

    }
}
