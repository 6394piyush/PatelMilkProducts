using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.VIewModels
{
    public class OverallDetails
    {
        public int Id { get; set; }
        
        public List<Employees> Employees { get; set; }
        public List<Khali> Khali { get; set; }
     //   public IEnumerable<MilkEntryUpload> MilkEntryUploads { get; set; }
    }
}