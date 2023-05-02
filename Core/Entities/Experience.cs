using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Experience : BaseEntity<Guid>
    {//Job-company-Details-From Date-To Date 
        [Display(Name = " المسمى الوضيفي  ")]
        public string? Job { get; set; }

        [Display(Name = " الشركة  ")]
        public string? Company { get; set; }

        [Display(Name = " شرح اكثر لهذه الوضيفة  ")]
        public string? Details { get; set; }

        [Display(Name = " تاريخ البداء  ")]
        public DateTime? FromDate { get; set; }

        [Display(Name = " تاريخ الانتهاء  ")]
        public DateTime? ToDate { get; set; }

        [Display(Name = " البروفايل  ")]
        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
