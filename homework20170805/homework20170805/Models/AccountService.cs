using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework20170805.Models
{
   public class AccountService
   {
       private readonly AccountDAO _dao;

       public AccountService()
       {
           _dao=new AccountDAO();
       }

       public IEnumerable<AccountViewModel> Getdata()
       {
           return _dao.GetAllAccounts();
       }
   }
}