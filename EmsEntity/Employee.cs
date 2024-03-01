using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsEntity
{
    public class Employee
    {
        [Key]
        [StringLength(6)]
        public string Emp_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Emp_First_Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Emp_Last_Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Emp_Date_of_Birth { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Joining")]
        public DateTime Emp_Date_of_Joining { get; set; }

        [Required]
        [Display(Name = "Department ID")]
        [ForeignKey("Department")]
        public int Emp_Dept_ID { get; set; }

        [Required]
        [StringLength(2)]
        [ForeignKey("Grade")]
        public string Emp_Grade { get; set; }

        [StringLength(50)]
        public string Emp_Designation { get; set; }

        [Required]
        public int Emp_Basic { get; set; }

        [Required]
        [StringLength(1)]
        public string Emp_Gender { get; set; }

        [Required]
        [StringLength(1)]
        [Display(Name = "Marital Status")]
        public string Emp_Marital_Status { get; set; }

        [StringLength(100)]
        [Display(Name = "Home Address")]
        public string Emp_Home_Address { get; set; }

        [StringLength(15)]
        [Display(Name = "Contact Number")]
        public string Emp_Contact_Num { get; set; }
    }
}
