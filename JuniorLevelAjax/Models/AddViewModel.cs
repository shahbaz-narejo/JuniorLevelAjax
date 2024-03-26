using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JuniorLevelAjax.Models
{
    public class AddViewModel
    {
        public int S_id { get; set; }

        [Display(Name = "Name")]
        public string S_name { get; set; }

        [Display(Name = "Class")]
        public int Class_id { get; set; }

        [Display(Name = "Course")]
        public int[] Course_id { get; set; }

        [Display(Name = "Contact Number")]
        public string S_contact { get; set; }


        public SelectList ClassList { get; set; }
        public MultiSelectList CourseList { get; set; }
    }
}