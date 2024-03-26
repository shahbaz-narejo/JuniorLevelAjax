using JuniorLevelAjax.App_Content.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JuniorLevelAjax.Models;

namespace JuniorLevelAjax.App_Content.BAL
{
    public class ClassBL:ClassDL
    {
        public override DataTable GetAllClass()
        {
            return base.GetAllClass();
        }

        public SelectList DropDownClassList(int? SelectedValue)
        {
            DataTable dt = base.GetAllClass();
            var selectList = (from DataRow dr in dt.Rows
                              select new SelectListItem
                              {
                                  Value = dr["Class_id"].ToString(),
                                  Text = dr["Class_name"].ToString()
                              }).ToList();
            return new SelectList(selectList, "Value", "Text", SelectedValue);
        }
    }
}