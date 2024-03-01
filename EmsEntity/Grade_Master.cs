using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsEntity
{
    public class Grade_Master
    {
        [Key]
        [StringLength(2)]
        [Display(Name = "Grade Code")]
        public string Grade_Code { get; set; }

        [Required]
        [StringLength(10)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Min Salary")]
        public int Min_Salary { get; set; }

        [Required]
        [Display(Name = "Max Salary")]
        public int Max_Salary { get; set; }
    }
}
