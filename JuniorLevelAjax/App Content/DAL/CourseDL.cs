using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using JuniorLevelAjax.App_Content.DBContext;

namespace JuniorLevelAjax.App_Content.DAL
{
    public class CourseDL
    {
        public virtual DataTable GetAllCourse()
        {

            return SqlHelper.ExecuteDataset(DBConnection.ConnectionString, CommandType.StoredProcedure, "SelectCourse").Tables[0];
        }
    }
}