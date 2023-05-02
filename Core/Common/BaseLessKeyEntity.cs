using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class BaseLessKeyEntity<TKey> //: IDXDataErrorInfo
    {
        [Display(Name = " تاريخ الانشاء ")]
        public DateTime CreateAt { get; set; } = DateTime.Now;
        [Display(Name = " تاريخ التعديل ")]
        public DateTime? UpdateAt { get; set; }
        public TKey? CreateById { get; set; }
        public TKey? UpdateById { get; set; }

    }
}
