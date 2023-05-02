using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Address : BaseEntity<Guid>
    {
        [Display(Name = " الشارع  ")]
        public string? Street { get; set; }

        [Display(Name = " المدينة  ")]
        public string? City { get; set; }

        [Display(Name = " الرقم البريدي  ")]
        public string? PostalCode { get; set; }

        [Display(Name = " المقاطعة  ")]
        public string? State { get; set; }

        [Display(Name = " الدولة  ")]
        public string? Country { get; set; }

        [Display(Name = " رقم بداية الدولة  ")]
        public string? StartPhoneCountry { get; set; }

        [Display(Name = " البروفايل  ")]
        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }

    }
}
