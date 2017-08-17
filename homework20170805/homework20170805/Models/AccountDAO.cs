using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Dapper;

namespace homework20170805.Models
{
    public class AccountDAO
    {
        private string ConnectionString { get; set; }

        public AccountDAO()
        {
            this.ConnectionString = WebConfigurationManager.ConnectionStrings["SkillTreeHomework"].ConnectionString;
        }

        public List<AccountViewModel> GetAllAccounts()
        {
            var result=new List<AccountViewModel>();
            const string sqlStatement = "Select Categoryyy Type,Dateee Date,Amounttt Amount From AccountBook";
            using (var conn=new SqlConnection(this.ConnectionString))
            {
                result = conn.Query<AccountViewModel>(sqlStatement).ToList();
            }
            return result;
        }
    }
}