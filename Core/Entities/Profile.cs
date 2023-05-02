using Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Profile :BaseEntity<Guid>
    {  
        public Profile()
        {
            this.Certificates=new List<Certificates>();
            this.Skills=new List<Skills>();
            this.Languages=new List<Languages>();
            this.Education=new List<Education>();
            this.Hobbies=new List<Hobbies>();
            this.Experience=new List<Experience>();
        }
        [Display(Name = " الاسم الاول  ")]
        public string? FristName { get; set; }

        [Display(Name = " الاسم الاخير ")]
        public string? LastName { get; set; }

        [Display(Name = " الوصف  ")]
        public string? Description { get; set; }

        [Display(Name = " الايميل  ")]
        public string? Email { get; set; }

        [Display(Name = " الجنسية  ")]
        public string? Nationality { get; set; }

        [Display(Name = " تاريخ الميلاد  ")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = " الحالة الاجتماعية  ")]
        public MaritalStatus? MaritalStatus { get; set; }

        [Display(Name = " نبذه عني  ")]
        public string? AboutMe { get; set; }

        [Display(Name = " فيس بوك  ")]
        public string? Facebook { get; set; }

        [Display(Name = " جيت هب  ")]
        public string? GitHub { get; set; }

        [Display(Name = " لينكدأن  ")]
        public string? LinkedIn { get; set; }

        [Display(Name = " تويتر  ")]
        public string? Twitter { get; set; }

        public List<Skills> Skills { get; set; }
        public IList<Hobbies> Hobbies { get; set; } 
        public IList<Experience> Experience { get; set; } 
        public IList<Education> Education { get; set; } 
        public IList<Languages> Languages { get; set; } 
        public IList<Certificates> Certificates { get; set; } 

        public Address? Address { get; set; } 

    }
    public enum MaritalStatus
    {
        [Display(Name = " الوصف  ")]
        Single,
        [Display(Name = " الوصف  ")]
        Married

    }
}
