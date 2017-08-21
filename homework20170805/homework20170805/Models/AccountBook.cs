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
        public int Categoryyy { get; set; }
        [DisplayName("金額")]
        [Range(0, int.MaxValue)]
        public int Amounttt { get; set; }
        [DisplayName("日期")]
        public System.DateTime Dateee { get; set; }
        [DisplayName("備註")]
        public string Remarkkk { get; set; }
    }
}