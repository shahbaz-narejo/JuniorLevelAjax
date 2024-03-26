using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using JuniorLevelAjax.App_Content.DBContext;

namespace JuniorLevelAjax.App_Content.DAL
{
    public class StudentCourseDL
    {

        public virtual int InsertStudentCourse(int S_id, int Course_id)
        {
            SqlParameter[] param = {
                                   new SqlParameter("@S_id",S_id),
                                   new SqlParameter("@Course_id",Course_id),


                               };
            return Convert.ToInt32(SqlHelper.ExecuteScalar(DBConnection.ConnectionString, CommandType.StoredProcedure, "InsertStudentCourse", param));
        }

        public virtual void DeleteStudentCourse(int S_id)
        {
            SqlParameter[] param = {
                                   new SqlParameter("@S_id",S_id)
                               };
            SqlHelper.ExecuteNonQuery(DBConnection.ConnectionString, CommandType.StoredProcedure, "DeleteStudentCourse", param);
        }
    }
}