using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace homework20170805.Models
{
    public partial class AccountBook
    {
        public System.Guid Id { get; set; }
        [DisplayName("類別")]
        public AccountType Categoryyy { get; set; }
        [DisplayName("金額")]
        [Range(0, int.MaxValue,ErrorMessage = "請輸入大於零的金額")]
        public int Amounttt { get; set; }
        [DisplayName("日期")]
        
        public System.DateTime Dateee { get; set; }
        [DisplayName("備註")]
        //[MaxLength(100,ErrorMessage = "輸入的內容請小於100個字")]
        [StringLength(10, ErrorMessage = "{0} 的內容長度必須小於 {1} 個字元。")]
        public string Remarkkk { get; set; }
    }
}