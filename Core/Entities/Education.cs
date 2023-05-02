using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Education : BaseEntity<Guid>
    {
        [Display(Name = " الجامعة  ")]
        public string? University { get; set; }

        [Display(Name = " القسم  ")]
        public string? Majors { get; set; }

        [Display(Name = " المعدل  ")]
        public int? GPA { get; set; }

        [Display(Name = " تاريخ التخرج  ")]
        public DateTime? DateGraduation  { get; set; }

        [Display(Name = " تاريخ الالتحاق  ")]
        public DateTime? DateRegistration  { get; set; }

        [Display(Name = " المرفقات  ")]
        public string? File { get; set; }

        [Display(Name = " البروفايل  ")]
        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
