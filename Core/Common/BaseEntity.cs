using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class BaseEntity<TKey>:BaseLessKeyEntity<TKey>
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.)]
        public Guid Id { get; set; }
        public bool? IsDeleted { get; set; }
        public int flag { get; set; }
    }
}
