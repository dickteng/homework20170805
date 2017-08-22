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
                result = conn.Query<AccountViewModel>(sqlStatement).OrderBy(d=>d.Date).ToList();
            }
            return result;
        }

        public int Insert(AccountBook instance)
        {
            const string sqlStatement = "Insert Into accountbook(Id,Categoryyy,Amounttt,Dateee,Remarkkk)Values(@Id,@Categoryyy,@Amounttt,@Dateee,@Remarkkk)";
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                try
                {
                    return conn.Execute(sqlStatement, new
                    {
                        Id = Guid.NewGuid(),
                        Categoryyy = instance.Categoryyy,
                        Amounttt=instance.Amounttt,
                        Dateee=instance.Dateee,
                        Remarkkk=instance.Remarkkk
                    });
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}