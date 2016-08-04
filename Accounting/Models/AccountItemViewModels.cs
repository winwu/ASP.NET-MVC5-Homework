using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.Models
{
    public class AccountItemView
    {
        // ID  類別 支出 金額
        public int Id { get; set; }
        public string Type { get; set; }
        public String Datetime { get; set; }
        public int Price { get; set; }
    }
}