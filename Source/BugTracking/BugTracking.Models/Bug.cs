using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Models
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(50, ErrorMessage = "MinLength = 3, MaxLength = 50", MinimumLength = 3)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "MinLength = {2}, MaxLength = {1}")]
        public string Title { get; set; }
        
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreatedOn { get; set; }

        public Priority Priority { get; set; }

        [RegularExpression(@"^\d\.\d{2}$")]
        public string Version { get; set; }

        //public int CategoryId { get; set; }

        //public virtual BugsCategory Category { get; set; }

}
}
