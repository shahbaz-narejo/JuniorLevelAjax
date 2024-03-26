using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace JuniorLevelAjax.App_Content.DBContext
{
    public static class DBConnection
    {
        public static string ConnectionString
        {
            get
            {
                if (ConfigurationManager.ConnectionStrings["StudentDB"] == null)
                {
                    return string.Empty;
                }

                string conn = ConfigurationManager.ConnectionStrings["StudentDB"].ToString();
                return conn;
            }
        }
    }
}