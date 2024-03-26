using JuniorLevelAjax.App_Content.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace JuniorLevelAjax.App_Content.BAL
{
    public class StudentBL:StudentDL
    {
        public override DataTable GetByID(int? S_id)
        {
            return base.GetByID(S_id);
        }

        public override int InsertStudent(string S_name, string S_contact, int Class_id)
        {
            return base.InsertStudent(S_name,S_contact,Class_id);
        }

        public override int UpdateStudent(string S_name, string S_contact, int Class_id, int S_id)
        {
            return base.UpdateStudent(S_name,S_contact,Class_id,S_id);
        }

        public override void DeleteStudent(int S_id)
        {
            base.DeleteStudent(S_id);
        }
    }
}