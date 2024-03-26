using JuniorLevelAjax.App_Content.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JuniorLevelAjax.App_Content.BAL
{
    public class CourseBL:CourseDL
    {
        public override DataTable GetAllCourse()
        {
            return base.GetAllCourse();
        }

        public MultiSelectList DropDownCourseList(int[] SelectedValue)
        {
            DataTable dt = base.GetAllCourse();
            var selectList = (from DataRow dr in dt.Rows
                              select new SelectListItem
                              {
                                  Value = dr["Course_id"].ToString(),
                                  Text = dr["Course_name"].ToString()
                              }).ToList();
            return new MultiSelectList(selectList, "Value", "Text", SelectedValue);
        }
    }
}