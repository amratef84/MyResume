using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Hobbies : BaseNameEntity<Guid>
    {

        [Display(Name = " البروفايل  ")]
        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
