using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Models
{
    public class MilkEntryUpload
    {
        public int Id { get; set; }
        public int EmployeesId { get; set; }
        public string SYear { get; set; }
        public string SMonth { get; set; }
        public double _1 { get; set; }
        public double _2 { get; set; }
        public double _3 { get; set; }
        public double _4 { get; set; }
        public double _5 { get; set; }
        public double _6 { get; set; }
        public double _7 { get; set; }
        public double _8 { get; set; }
        public double _9 { get; set; }
        public double _10 { get; set; }
        public double _11 { get; set; }
        public double _12 { get; set; }
        public double _13 { get; set; }
        public double _14 { get; set; }
        public double _15 { get; set; }
        public double _16 { get; set; }
        public double _17 { get; set; }
        public double _18 { get; set; }
        public double _19 { get; set; }
        public double _20 { get; set; }
        public double _21 { get; set; }
        public double _22 { get; set; }
        public double _23 { get; set; }
        public double _24 { get; set; }
        public double _25 { get; set; }
        public double _26 { get; set; }
        public double _27 { get; set; }
        public double _28 { get; set; }
        public double _29 { get; set; }
        public double _30 { get; set; }
        public double _31 { get; set; }

        public double TotalMilk { get; set; }
        public double Amount { get; set; }        
        public virtual Employees Employees { get; set; }

    }
    public enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    };
    public enum SelectYear
    {
        Y2018,
        Y2019,
        Y2020,
        Y2021
    };
    
}
