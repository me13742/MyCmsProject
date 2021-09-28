﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageGroup
    {
        [Key]
        public int GroupID { get; set; }

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفاً نام را وارد کنید.")]
        [MaxLength(150)]
        public string GroupTitle { get; set; }

        public virtual List<Page> pages { get; set; }

        public PageGroup()
        {

        }
    }
}
