using JuniorLevelAjax.App_Content.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JuniorLevelAjax.App_Content.BAL
{
    public class StudentCourseBL:StudentCourseDL
    {
        public override int InsertStudentCourse(int S_id, int Course_id)
        {
            return base.InsertStudentCourse(S_id, Course_id);
        }

        public override void DeleteStudentCourse(int S_id)
        {
            base.DeleteStudentCourse(S_id);
        }
    }
}