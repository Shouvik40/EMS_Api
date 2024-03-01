﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsEntity
{
    public class Department
    {
        [Key]
        public int Dept_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Dept_Name { get; set; }
    }
}
