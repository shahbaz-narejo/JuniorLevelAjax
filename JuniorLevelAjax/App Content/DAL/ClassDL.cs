using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using JuniorLevelAjax.App_Content.DBContext;
using JuniorLevelAjax.Models;

namespace JuniorLevelAjax.App_Content.DAL
{
    public class ClassDL
    {
        public virtual DataTable GetAllClass()
        {

            return SqlHelper.ExecuteDataset(DBConnection.ConnectionString, CommandType.StoredProcedure, "SelectClass").Tables[0];
        }
        public IEnumerable<ViewModel> GetFacilityByAcronym(string Acronym, string AccessCode)
        {
            ViewModel facility = new ViewModel();
            var param = new { Acronym, AccessCode };
            try
            {
                con.Open();
                facility = SqlMapper.QueryFirstOrDefault<ViewModel>(con, "sp_GetFacilityByAcronym", param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception ex)
            {

            }
            return facility;
        }
    }
}