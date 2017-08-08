using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace homework20170805.Models
{
    public class AccountViewModel
    {
        [Display(Name ="類別")]
        public AccountType Type { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        [Display(Name ="日期")]
        public DateTime Date { get; set; }
        [Display(Name ="金額")]
        [DisplayFormat(DataFormatString ="{0:N0}")]
        public int Amount { get; set; }
    }

    public enum AccountType
    {
        收入,
        支出
    }
}