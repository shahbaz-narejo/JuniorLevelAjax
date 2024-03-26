using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using JuniorLevelAjax.App_Content.DBContext;

namespace JuniorLevelAjax.App_Content.DAL
{
    public class StudentDL
    {
        public virtual DataTable GetByID(int? S_id)
        {
            SqlParameter[] param = {
                                   new SqlParameter("@S_id",S_id)

                               };
            return SqlHelper.ExecuteDataset(DBConnection.ConnectionString, CommandType.StoredProcedure, "SelectAll", param).Tables[0];
        }

        public virtual int InsertStudent(string S_name, string S_contact, int Class_id)
        {
            SqlParameter[] param = {
                                   new SqlParameter("@S_name",S_name),
                                   new SqlParameter("@Class_id",Class_id),
                                   new SqlParameter("@S_contact",S_contact),

                               };
            return Convert.ToInt32(SqlHelper.ExecuteScalar(DBConnection.ConnectionString, CommandType.StoredProcedure, "InsertStudent", param));
        }

        public virtual int UpdateStudent(string S_name, string S_contact, int Class_id, int S_id)
        {
            SqlParameter[] param = {
                                    new SqlParameter("@S_id",S_id),
                                    new SqlParameter("@S_name",S_name),
                                    new SqlParameter("@S_contact",S_contact),
                                    new SqlParameter("@Class_id",Class_id),
                               };
            return Convert.ToInt32(SqlHelper.ExecuteScalar(DBConnection.ConnectionString, CommandType.StoredProcedure, "UpdateStudent", param));
        }

        public virtual void DeleteStudent(int S_id)
        {
            SqlParameter[] param = {
                                   new SqlParameter("@S_id",S_id)
                               };
            SqlHelper.ExecuteNonQuery(DBConnection.ConnectionString, CommandType.StoredProcedure, "DeleteStudent", param);
        }
    }
}