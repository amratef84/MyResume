using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class BaseWithEnAndArNameEntity<Tkey> : BaseEntity<Tkey>
    {
        [Display(Name = " الاسم الاجنبي ")]
        public string? EnName { get; set; }

        [Display(Name = " الاسم المختصر الاجنبي")]
        public string? EnShortName { get; set; }

        [Display(Name = " الوصف الاجنبي ")]
        public string? EnDescription { get; set; }

        [Display(Name = " الاسم العربي ")]
        public string? ArName { get; set; }

        [Display(Name = " الاسم المختصر عربي")]
        public string? ArShortName { get; set; }
        [Display(Name = " الوصف ")]
        public string? ArDescription { get; set; }
    }
}
